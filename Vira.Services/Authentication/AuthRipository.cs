using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vira.Core.Domain;
using Vira.Data;
using Vira.Data.Infrastracture;

namespace Vira.Services.Authentication
{
    public class AuthRipository : IAuthRepository
    {
        private readonly ViraDbContext _context;

        public AuthRipository(ViraDbContext context)
        {
            _context = context;
        }
        public async Task<User> Register(User user, string password)
        {
            //Infrastracture.Infsture.CreatePasswordHash(UserForRegisterDto.Username,out byte[]passwordHash,out byte[]passwordSalt);
            UserAuthorization.CreatePasswordHash(password, out var passwordSalt, out var passwordHash);
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == username);
            if (user == null)
                return null;
            return !(UserAuthorization.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt)) ? null : user;
        }

        public async Task<bool> UserExist(string username)
        {
            return await _context.Users.AnyAsync(x => x.Username == username);

        }

    }
}

