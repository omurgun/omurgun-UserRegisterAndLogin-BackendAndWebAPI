using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRAL.Business.Abstract
{
    public interface IEncryptText
    {
        string Sha384Enc(string text);
    }
}
