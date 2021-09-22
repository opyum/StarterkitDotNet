using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VoyanceApi.Extension
{
    public static class StringExtension
    {
        public static Guid ToGuid(this string myString)
        {
            if (string.IsNullOrEmpty(myString)) return new Guid();
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.Default.GetBytes(myString));
                return new Guid(hash);
            }
        }
    }
}
