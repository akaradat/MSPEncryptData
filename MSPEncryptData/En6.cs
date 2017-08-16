using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenWithCS
{
    class En6 : Encrypt
    {
        public En6(string code) : base(code)
        {
        }

        public override string EnPass()
        {
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] >= 'a' && code[i] <= 'z')
                {
                    pass += (char)(code[i] - 32);
                }

                else if (code[i] >= 'A' && code[i] <= 'Z')
                {
                    pass += (char)(code[i] + 32);
                }

                else
                {
                    pass += code[i];
                }

            }
            return pass;
        }

        public override string DePass()
        {
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] >= 'a' && code[i] <= 'z')
                {
                    pass += (char)(code[i] - 32);
                }

                else if (code[i] >= 'A' && code[i] <= 'Z')
                {
                    pass += (char)(code[i] + 32);
                }

                else
                {
                    pass += code[i];
                }
            }
            return pass;
        }
    }
}
