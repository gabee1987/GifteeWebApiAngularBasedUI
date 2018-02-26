using GifteeWebApiAngularBasedUI.Models;
using AutoMapper;
using GifteeWebApiAngularBasedUI.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GifteeWebApiAngularBasedUI.Controllers.Resources;

namespace GifteeWebApiAngularBasedUI.Controllers
{
    [Route("/api/giftees")]
    public class GifteeController : Controller
    {
        private readonly IMapper mapper;
        private readonly GifteeDbContext context;

        public GifteeController(IMapper mapper, GifteeDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGiftee([FromBody] GifteeResource gifteeResource)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            //Check if user is exist
            var user = await context.Users.FindAsync(gifteeResource.UserId);

            if (user == null)
            {
                ModelState.AddModelError("UserId", "Invalid UserId");
                return BadRequest(ModelState);
            }

            var giftee = mapper.Map<GifteeResource, Giftee>(gifteeResource);
            giftee.User = user;

            context.Giftees.Add(giftee);
            await context.SaveChangesAsync();

            var result = mapper.Map<Giftee, GifteeResource>(giftee);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGiftee(int id, [FromBody] GifteeResource gifteeResource)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var giftee = await context.Giftees.FindAsync(id);

            if (giftee == null)
            {
                return NotFound();
            }

            mapper.Map<GifteeResource, Giftee>(gifteeResource, giftee);
            //giftee.User = user;

            await context.SaveChangesAsync();

            var result = mapper.Map<Giftee, GifteeResource>(giftee);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGiftee(int id)
        {
            var giftee = await context.Giftees.FindAsync(id);

            if (giftee == null)
            {
                return NotFound();
            }

            context.Remove(giftee);
            await context.SaveChangesAsync();

            return Ok(id);
        }
    }
}
