using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAN
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }


        private static bool IbanValidator(string iban)
        {
            iban.ToUpper();
            var ibanLenght = iban.Length;

            if (ibanLenght == 22)
            {
                for (var i = 0; i < 4; i++ )
                {
                    iban.ToArray()[i] = iban[22];
                }

                var BG = "BG";
                for (var bic = 4; bic <= 7; bic++)
                {
                    if(iban[bic]=='')

                }
                    if (BG[0] == iban[0])
                    {



                    }
                


            }
            else
            {
                Console.WriteLine("Your input is invalid!");
            }
           
            return true;
        }

    }
}
