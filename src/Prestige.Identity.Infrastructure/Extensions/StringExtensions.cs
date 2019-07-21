using System.Security.Cryptography;
using System.Text;

namespace Prestige.Identity.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string CreateHash(this string value)
        {
            byte[] valueBytes = Encoding.Unicode.GetBytes(value);
            valueBytes = MD5.Create().ComputeHash(valueBytes);
            valueBytes = SHA512.Create().ComputeHash(valueBytes);
            valueBytes = SHA384.Create().ComputeHash(valueBytes);
            return Encoding.Unicode.GetString(valueBytes);
        }
    }
}
