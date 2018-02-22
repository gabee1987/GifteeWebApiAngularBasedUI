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

        [HttpPost("/new")]
        public async Task<IActionResult> CreateGiftee([FromBody] GifteeResource gifteeResource, UserResource userResource)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            // If server side validation is required
            //var user = await context.Users.FindAsync(userResource.Id);

            //if (user == null)
            //{
            //    ModelState.AddModelError("UserId", "Invalid UserId");
            //    return BadRequest(ModelState);
            //}

            var giftee = mapper.Map<GifteeResource, Giftee>(gifteeResource);
            //giftee.User = user;

            context.Giftees.Add(giftee);
            await context.SaveChangesAsync();

            var result = mapper.Map<Giftee, GifteeResource>(giftee);
            return Ok(result);
        }
    }
}
