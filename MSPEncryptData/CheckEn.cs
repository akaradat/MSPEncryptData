using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenWithCS
{
    class CheckEn
    {
        private string code;
        private string order;
        private int check;
        private Encrypt encrypt;

        public CheckEn(string code, string order, int check)
        {
            this.code = code;
            this.order = order;
            this.check = check;
        }

        public String StartEn()
        {
            if (check==1)
            {
                return GetEnpass();
            }
            else if (check==0)
            {
                return GetDePass();
            }
            else return "Choose e/n";
        }
        
        public String GetEnpass()
        {
            for (int i = 0; i < order.Length; i++)
            {
                switch (order[i])
                {
                    case '0':
                        {
                            encrypt = new En0(code);
                            code = encrypt.EnPass();
                            break;
                        }

                    case '1':
                        {
                            encrypt = new En1(code);
                            code = encrypt.EnPass();
                            break;
                        }

                    case '2':
                        {
                            encrypt = new En2(code);
                            code = encrypt.EnPass();
                            break;
                        }

                    case '3':
                        {
                            encrypt = new En3(code);
                            code = encrypt.EnPass();
                            break;
                        }

                    case '4':
                        {
                            encrypt = new En4(code);
                            code = encrypt.EnPass();
                            break;
                        }

                    case '5':
                        {
                            encrypt = new En5(code);
                            code = encrypt.EnPass();
                            break;
                        }

                    case '6':
                        {
                            encrypt = new En6(code);
                            code = encrypt.EnPass();
                            break;
                        }

                    case '7':
                        {
                            encrypt = new En7(code);
                            code = encrypt.EnPass();
                            break;
                        }

                    case '8':
                        {
                            encrypt = new En8(code);
                            code = encrypt.EnPass();
                            break;
                        }

                    case '9':
                        {
                            encrypt = new En9(code);
                            code = encrypt.EnPass();
                            break;
                        }

                }
            }
            return code;
        }

        public String GetDePass()
        {
            for (int i = order.Length - 1; i >= 0; i--)
            {
                switch (order[i])
                {
                    case '0':
                        {
                            encrypt = new En0(code);
                            code = encrypt.DePass();
                            break;
                        }

                    case '1':
                        {
                            encrypt = new En1(code);
                            code = encrypt.DePass();
                            break;
                        }

                    case '2':
                        {
                            encrypt = new En2(code);
                            code = encrypt.DePass();
                            break;
                        }

                    case '3':
                        {
                            encrypt = new En3(code);
                            code = encrypt.DePass();
                            break;
                        }

                    case '4':
                        {
                            encrypt = new En4(code);
                            code = encrypt.DePass();
                            break;
                        }

                    case '5':
                        {
                            encrypt = new En5(code);
                            code = encrypt.DePass();
                            break;
                        }

                    case '6':
                        {
                            encrypt = new En6(code);
                            code = encrypt.DePass();
                            break;
                        }

                    case '7':
                        {
                            encrypt = new En7(code);
                            code = encrypt.DePass();
                            break;
                        }

                    case '8':
                        {
                            encrypt = new En8(code);
                            code = encrypt.DePass();
                            break;
                        }

                    case '9':
                        {
                            encrypt = new En9(code);
                            code = encrypt.DePass();
                            break;
                        }


                }
            }
            return code;
        }
    }
}
