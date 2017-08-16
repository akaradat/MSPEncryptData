using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenWithCS
{
    class En3 : Encrypt
    {
        public En3(string code) : base(code)
        {
        }

        public override string EnPass()
        {
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] >= 'a' && code[i] <= 'z')
                {
                    pass += (char)((code[i] - 'a' + 13) % 26 + 'a');
                }

                else if (code[i] >= 'A' && code[i] <= 'Z')
                {
                    pass += (char)((code[i] - 'A' + 13) % 26 + 'A');
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
                    pass += (char)((code[i] - 'a' + 13) % 26 + 'a');
                }

                else if (code[i] >= 'A' && code[i] <= 'Z')
                {
                    pass += (char)((code[i] - 'A' + 13) % 26 + 'A');
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
