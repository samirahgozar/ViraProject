using System;
using System.Collections.Generic;
using System.Text;

namespace Vira.Data.Infrastracture
{
    public class UserAuthorization
    {
        public static void CreatePasswordHash(string password, out byte[] passwordSalt, out byte[] passwordHash)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])

                        return false;

                }
                //Or:
                // if (computedHash.Where((t, i) => t != passwordHash[i]).Any())
                // return false;
            }

            return true;


        }
        public static void AddApplicationError()
        {

        }
    }
}
