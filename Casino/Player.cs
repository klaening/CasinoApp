using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        public int money = 100;

        public void Bet()
        {
            int bet;
            
            do
            {
                Console.Write("How much do you want to bet? ");
                bet = int.Parse(Console.ReadLine());

                if (bet > money || bet < 1)
                {
                    Console.WriteLine("Invalid bet!");
                }
                else
                {
                    money -= bet;
                    break;
                }
            } while (bet > money || bet < 0);
        }

        public void Status()
        {
            Console.WriteLine($"In bank: {money}");
        }

        public static void ShowStatus(Player p)
        {
            p.Status();
        }

        public static void PlaceBet(Player p)
        {
            p.Bet();
        }
    }
}
