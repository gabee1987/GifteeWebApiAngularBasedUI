using GifteeWebApiAngularBasedUI.Persistence;
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
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserController(IMapper mapper, IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("/api/users")]
        public async Task<IEnumerable<UserResource>> GetUsers()
        {
            var users = await userRepository.GetAllUsersAsync(includeRelatedGiftees: false);
            var userList = users.ToList();

            return mapper.Map<List<User>, List<UserResource>>(userList);
        }
    }
}
