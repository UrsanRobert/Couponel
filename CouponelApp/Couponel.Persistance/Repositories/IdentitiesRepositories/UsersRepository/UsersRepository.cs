﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Couponel.Entities.Identities;
using Couponel.Persistence.Repositories.Repository;
using Microsoft.EntityFrameworkCore;

namespace Couponel.Persistence.Repositories.IdentitiesRepositories.UsersRepository
{
    public sealed class UsersRepository : Repository<User>, IUsersRepository
    {
        private readonly CouponelContext _context;

        public UsersRepository(CouponelContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<IList<User>> GetAllByRole(string role) =>
            await _context.Users.Where(x => x.Role == role).ToListAsync();

        public async Task<User> GetByEmail(string email) =>
            await _context.Users.Where(x => x.UserName == email).FirstOrDefaultAsync();

        public async Task<User> GetByUsername(string username) =>
            await _context.Users.Where(x => x.UserName == username).FirstOrDefaultAsync();
    }
}
