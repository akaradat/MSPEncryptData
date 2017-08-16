using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenWithCS
{
    class En2 : Encrypt
    {
        public En2(string code) : base(code)
        {
        }

        public override string EnPass()
        {
            for (int i = 0; i < code.Length; i++)
            {
                
                if (code[i] >= 32 && code[i] <= 126)
                {
                    pass += (char)(126 + 32 - code[i]);
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
                {
                    pass += (char)(126 + 32 - code[i]);
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
