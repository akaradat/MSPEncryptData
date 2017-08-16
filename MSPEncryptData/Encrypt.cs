using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenWithCS
{
    class Encrypt
    {
        protected String code;
        protected String pass;

        public Encrypt(String code)
        {
            this.code = code;
            pass = "";
        }

        public virtual String EnPass()
        {
            return pass;
        }

        public virtual String DePass()
        {
            return pass;
        }
    }
}
