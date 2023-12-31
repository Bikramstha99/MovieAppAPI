﻿using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using MovieAppAPI.Data;
using MovieAppAppication.Interface.IRepository;
using MovieAppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppInfrastructure.Implementation.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MovieDb _context;
        public UserRepository(MovieDb context)
        {
            _context = context;
        }
        public async Task<bool> RegisterUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            return true;
        }

        public async Task<User> LoginUserAsync(User user)
        {
            var users = _context.Users.SingleOrDefault(x => x.Email ==user.Email);
            return users;
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByUserIdAsync(int Userid)
        {
            return await _context.Users.FindAsync(Userid);
        }

        public async Task<bool> DeleteUserAsync(int Userid)
        {
            var userToDelete = await _context.Users.FindAsync(Userid);

            if (userToDelete != null)
            {
                _context.Users.Remove(userToDelete);
                return true;
            }
            return false;
        }
    }
}
