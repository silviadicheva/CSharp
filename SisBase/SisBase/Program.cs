using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SisBase
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Моля въведете вашето търсене:");
        Start:
            string check = Console.ReadLine();

            bool chech = Regex.IsMatch(check, (@"[0-9]"));
            while (chech == true)
            {
                Console.WriteLine("Моля въведете коректен запис(без цифри)!!!");

                goto Start;
            }

            using (Model1Container myTable = new Model1Container())

            { 
            
                List<Categroies> allElements = myTable.CategroiesSet.Where(x => x.CategoriesName.Contains(check)).ToList();
                foreach (Categroies z in allElements)
                {
                    Console.WriteLine(": " + z.CategoriesName + "\n");
                    {
                        List<Products> computers = z.Products.ToList();
                        foreach (Products n in computers)
                        {
                            Console.WriteLine(": " + n.ProductsName + "\n");
                        }
                    }
                }

            }
        }
    }
}
