using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonuses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type amount of hours: ");
            int b = Int32.Parse(Console.ReadLine());


            string c = Console.ReadLine();

            Post worker = Post.manager;

            if (c =="manager") {
                worker = Post.manager;

            }
            else if(c=="ceo"){
                worker = Post.ceo;
            }
            else if(c == "accountant")
            {
                worker = Post.accountant;
            }
            else
            {
                Console.WriteLine("There is no such worker");
            }


            bool a = Accauntant.AskForBonus(worker, b);
            if (a == true)
                Console.WriteLine("Will have bonuses");
            else
                Console.WriteLine("Woun't have bonuses");
            
            Console.ReadKey();
        }
    }
}
