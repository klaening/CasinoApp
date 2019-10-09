using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class StealMoney
    {
        public void Stealing()
        {
            Random rndChance = new Random();
            rndChance.Next(1, 4);

            Wait.Waiting(10);

            Random rndMoney = new Random();
            rndMoney.Next(1, 200);

            Wait.RunWaiting(10);

            Console.Write("Want to try to steal money from another player? Y or N: ");

            string choice;
            choice = Console.ReadLine();

            do
            {
                switch (choice)
                {
                    case "Y":
                        if (true)
                        {

                        }
                        break;

                    case "N":
                        break;

                    default:
                        break;
                } 
            } while (choice != "Y" && choice != "N");
        }
    }
}
