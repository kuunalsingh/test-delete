using EntropyAuthApp.Models;
using System.Security.Cryptography;
using System.Text;

namespace EntropyAuthApp.Services
{
    public class AuthService
    {
        public string GenerateAuthKey()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[16]; // 128 bits
                rng.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes);
            }
        }
    }
}
