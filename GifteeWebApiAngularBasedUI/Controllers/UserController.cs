using AutoMapper;
using GifteeWebApiAngularBasedUI.Context;
using GifteeWebApiAngularBasedUI.Controllers.Resources;
using GifteeWebApiAngularBasedUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GifteeWebApiAngularBasedUI.Controllers
{
    public class UserController : Controller
    {
        private readonly GifteeDbContext context;
        private readonly IMapper mapper;

        public UserController(GifteeDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/users")]
        public async Task<IEnumerable<UserResource>> GetUsers()
        {
            var users = await context.Users.Include(u => u.Giftees).ToListAsync();

            return mapper.Map<List<User>, List<UserResource>>(users);
        }
    }
}
