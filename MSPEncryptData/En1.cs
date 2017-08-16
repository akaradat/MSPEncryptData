using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***
 *      plus 5 char
 *      example A -> F
 */

namespace PassGenWithCS
{
    class En1 : Encrypt
    {
        public En1(string code) : base(code)
        {

        }

        public override string EnPass()
        {
            for (int i = 0; i < code.Length; i++)
            {

                if (code[i] >= 32 && code[i] <= 126)
                {

                    pass += (char)((code[i] - 32 + 5) % 95 + 32);
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
                if (code[i] >= 32 && code[i] <= 126)
                    pass += (char)((code[i] - 126 - 5) % 95 + 126);
                else
                {

                    pass += code[i];

                }

            }
            return pass;
        }
    }
}
