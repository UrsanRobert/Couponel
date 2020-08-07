﻿using Couponel.Business.Identities.Users.Models;
using System;
using System.Threading.Tasks;

namespace Couponel.Business.Identities.Users.Services.Interfaces
{
    public interface IUsersService
    {
        Task Update(UpdateUserModel model);
        Task<IUserDetailsModel> GetDetailsById(Guid id);
    }
}
