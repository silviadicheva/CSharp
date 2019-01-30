using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANvalidation
{
    class Program
    {
        static void Validation(string IBAN)
        {

            //Checking the length of the IBAN

            int valid = 0;
            int index = 0;
            int[] lettersIBAN = new int[2];
            int letter = 0;

            if (IBAN.Length < 22 || IBAN.Length > 22)
            {

                Console.WriteLine("This IBAN is invalid !!!");

            }

            else if (IBAN.Length == 22)
            {

                //Console.WriteLine("You've got correct number of symbols :)");
                valid++;
            }

            else
            {
                Console.WriteLine("This IBAN is invalid !!!");

            }

            // Console.WriteLine(valid);// Test 

            /////////////////////////////////////////

            // Checking for the bulgarian ID code 


            string bgCodeCheck = IBAN.Substring(0, 2).ToUpper();

            if (bgCodeCheck == "BG")
            {
                valid++;
            }

            else if (bgCodeCheck != "BG")
            {
                Console.WriteLine("Your IBAN is invalid !!!");
            }

            // Console.WriteLine(valid);

            ////////////////////////////////////////

            // Trying Alphabet logic :)

            if (valid == 2)
            {



                char[] charMassive = new char[IBAN.Length];

                charMassive = IBAN.ToCharArray();

                // Because of the Ascii table A is number 65 so 65 - 64 = 1 in our case we need 10, 1 + 9 = 10

                foreach (char element in charMassive)
                {

                    index = char.ToUpper(element) - 64 + 9;

                    if (index > 0)
                    {
                        lettersIBAN[letter] = index;

                        //Console.WriteLine(index);


                    }

                    letter++;

                }

                //Console.WriteLine("****************");

                //for (int i = 0; i < lettersIBAN.Length; i++)
                //{
                //    Console.WriteLine(lettersIBAN[i]);
                //}


                //////////////////////////////
                // Changing the positions of the 1st 4 symbols

                string subIBAN = IBAN.Substring(4);

                string newIBAN = subIBAN + lettersIBAN[0] + lettersIBAN[1];

                double finalIBAN = Convert.ToDouble(newIBAN);

                double result = finalIBAN % 97;

                if (result == 1)
                {
                    Console.WriteLine("Your IBAN is valid !!!");
                }


                else if (result != 1)
                {
                    Console.WriteLine("Your IBAN is invalid !!!");
                }

                else
                {
                    Console.WriteLine("Your IBAN is invalid !!!");
                }

            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your IBAN ");
            string iban = Console.ReadLine();

            Validation(iban);


        }
    }
}
