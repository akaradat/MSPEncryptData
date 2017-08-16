using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenWithCS
{
    class En5 : Encrypt
    {
        public En5(string code) : base(code)
        {
        }

        public override string EnPass()
        {
            for (int i = code.Length - 1; i >= 0; i--)
            {
                pass += code[i];
            }

            return pass;
        }

        public override string DePass()
        {
            for (int i = code.Length - 1; i >= 0; i--)
            {
                pass += code[i];
            }
            return pass;
        }
    }
}
