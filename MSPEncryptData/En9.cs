using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenWithCS
{
    class En9 : Encrypt
    {
        public En9(string code) : base(code)
        {
        }

        public override string EnPass()
        {
            for (int i = 0; i < code.Length; i++)
            {

                if (code[i] >= 32 && code[i] <= 126 && i % 2 == 1)
                {

                    pass += (char)((code[i] - 32 + 7) % 95 + 32);

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

                if (code[i] >= 32 && code[i] <= 126 && i % 2 == 1)
                {

                    pass += (char)((code[i] - 126 - 7) % 95 + 126);

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
