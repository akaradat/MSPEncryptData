using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***
 *      plus 3 character +2, *7 and +10
 *      example A -> eK
 */
namespace PassGenWithCS
{
    class En0 : Encrypt
    {
        public En0(string code) : base(code)
        {

        }

        public override string EnPass()
        {
            for (int i = 0; i < code.Length; i++)
            {

                if (code[i] >= 32 && code[i] <= 126)
                {
                    pass += (char)(((code[i] - 32) + 2) % 95 + 32);
                    pass += (char)(((code[i] - 32) * 7) % 95 + 32);
                    pass += (char)((code[i] - 32 + 10) % 95 + 32);
                }
                else
                {
                    pass += code[i];
                    pass += code[i];
                    pass += code[i];
                }
                


            }
            return pass;
        }

        public override string DePass()
        {
            for (int i = 0; i < code.Length; i += 3)
            {
                if (code[i] >= 32 && code[i] <= 126)
                {
                    pass += (char)((code[i] - 126 - 2) % 95 + 126);
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
