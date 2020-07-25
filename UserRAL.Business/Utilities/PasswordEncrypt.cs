using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UserRAL.Business.Abstract;

namespace UserRAL.Business.Utilities
{
    public class PasswordEncrypt: IEncryptText
    {
        public string Sha384Enc(string text)
        {

            SHA384 sha1Encrypting = new SHA384CryptoServiceProvider();
            byte[] bytes = sha1Encrypting.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder builder = new StringBuilder();

            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
