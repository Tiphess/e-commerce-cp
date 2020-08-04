using System;
using System.Collections.Generic;
using System.Linq;
using Konscious.Security.Cryptography;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace e_commerce_cp.Utils
{
    public static class PasswordUtils
    {
        private const int SaltSize = 16;
        private const int KeySize = 32;
        private const int Iterations = 10000;

        public static string Hash(string password)
        {
            using (var hasher = new Rfc2898DeriveBytes(password, SaltSize, Iterations, HashAlgorithmName.SHA256))
            {
                var key = Convert.ToBase64String(hasher.GetBytes(KeySize));
                var salt = Convert.ToBase64String(hasher.Salt);

                return string.Format("{0}.{1}.{2}", Iterations, salt, key);
            }
        }

        public static bool Verify(string hash, string password)
        {
            var parts = hash.Split('.', 3);

            if (parts.Length != 3)
            {
                throw new FormatException("Unexpected hash format. " +
                  "Should be formatted as `{iterations}.{salt}.{hash}`");
            }

            var iterations = Convert.ToInt32(parts[0]);
            var salt = Convert.FromBase64String(parts[1]);
            var key = Convert.FromBase64String(parts[2]);

            using (var hasher = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                var keyToCompare = hasher.GetBytes(KeySize);
                return keyToCompare.SequenceEqual(key);
            }
        }
    }
}
