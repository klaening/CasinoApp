using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class GameOfChance
    {
        public void CheckMoney(Player p)
        {
            if (p.money > 0)
            {
                GameOfChanceGame(p);
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void GameOfChanceGame(Player p)
        {

            bool boolean = true;
            string guess;
            //int winnings = 1;

            while (boolean)
            {
                do
                {
                    Console.Clear();
                    ChanceHeader();
                    Console.WriteLine();

                    Player.ShowStatus(p);
                    Console.WriteLine();
                    int bet;

                    do
                    {
                        Console.Write("How much do you want to bet? ");
                        bet = int.Parse(Console.ReadLine());

                        if (bet > p.money || bet < 1)
                        {
                            Console.WriteLine("Invalid bet!");
                            Wait.RunWaiting(500);
                            Console.Clear();
                            ChanceHeader();
                            Console.WriteLine();
                            Player.ShowStatus(p);
                            Console.WriteLine();
                        }
                    } while (bet > p.money || bet < 1);
                    
                    p.money -= bet;
                    Console.Clear();
                    ChanceHeader();
                    Console.WriteLine();
                    Player.ShowStatus(p);
                    Console.WriteLine();

                    //Player.PlaceBet(p);
                    Console.WriteLine();

                    Console.WriteLine("Which colour do you want to bet on?");
                    Console.WriteLine("Red or Black? ");

                    guess = Console.ReadLine();
                    guess = guess.ToUpper();
                    Console.WriteLine();

                    if (guess == "RED" || guess == "BLACK")
                    {
                        Console.WriteLine($"You chose {guess}!");
                        Console.WriteLine("Press enter to see result");
                        Console.ReadKey();
                        Console.WriteLine();
                        Random randomNumber = new Random();
                        Wait.RunWaiting(500);
                        int result = randomNumber.Next(1, 3);

                        Console.Write("It was");

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                            Wait.RunWaiting(600);
                        }

                        switch (result)
                        {
                            case 1:
                                PrintRed();
                                break;

                            case 2:
                                PrintBlack();
                                break;
                        }

                        if (guess == "RED" && result == 1 || guess == "BLACK" && result == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Congratulations!");
                            Console.WriteLine($"You bet {bet}");
                            bet *= 2;
                            Console.WriteLine($"You just won {bet}");
                            p.money += bet;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Better luck next time!");
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Wrong input! Try again");
                        Console.ReadKey();
                        p.money += bet;
                    }
                } while (guess != "RED" && guess != "BLACK");


                string choice; 

                do
                {
                    Console.Write("Want to go again? Y or N: ");
                    choice = Console.ReadLine();
                    choice = choice.ToUpper();

                    switch (choice)
                    {
                        case "Y":
                            if (p.money > 0)
                            {
                                RunGameOfChance(p);
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds! Going back to Main menu");
                                Wait.RunWaiting(1000);
                                boolean = false;
                            }
                            break;

                        case "N":
                            Console.WriteLine("Going back to Main menu");
                            Wait.RunWaiting(600);
                            boolean = false;
                            break;

                        default:
                            Console.WriteLine("Wrong input!");
                            Wait.RunWaiting(900);
                            break;
                    } 
                } while (choice != "Y" && choice != "N");
            }
        }

        private static void PrintBlack()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(@"
          _____                    _____            _____                    _____                    _____          
         /\    \                  /\    \          /\    \                  /\    \                  /\    \         
        /::\    \                /::\____\        /::\    \                /::\    \                /::\____\        
       /::::\    \              /:::/    /       /::::\    \              /::::\    \              /:::/    /        
      /::::::\    \            /:::/    /       /::::::\    \            /::::::\    \            /:::/    /         
     /:::/\:::\    \          /:::/    /       /:::/\:::\    \          /:::/\:::\    \          /:::/    /          
    /:::/__\:::\    \        /:::/    /       /:::/__\:::\    \        /:::/  \:::\    \        /:::/____/           
   /::::\   \:::\    \      /:::/    /       /::::\   \:::\    \      /:::/    \:::\    \      /::::\    \           
  /::::::\   \:::\    \    /:::/    /       /::::::\   \:::\    \    /:::/    / \:::\    \    /::::::\____\________  
 /:::/\:::\   \:::\ ___\  /:::/    /       /:::/\:::\   \:::\    \  /:::/    /   \:::\    \  /:::/\:::::::::::\    \ 
/:::/__\:::\   \:::|    |/:::/____/       /:::/  \:::\   \:::\____\/:::/____/     \:::\____\/:::/  |:::::::::::\____\
\:::\   \:::\  /:::|____|\:::\    \       \::/    \:::\  /:::/    /\:::\    \      \::/    /\::/   |::|~~~|~~~~~     
 \:::\   \:::\/:::/    /  \:::\    \       \/____/ \:::\/:::/    /  \:::\    \      \/____/  \/____|::|   |          
  \:::\   \::::::/    /    \:::\    \               \::::::/    /    \:::\    \                    |::|   |          
   \:::\   \::::/    /      \:::\    \               \::::/    /      \:::\    \                   |::|   |          
    \:::\  /:::/    /        \:::\    \              /:::/    /        \:::\    \                  |::|   |          
     \:::\/:::/    /          \:::\    \            /:::/    /          \:::\    \                 |::|   |          
      \::::::/    /            \:::\    \          /:::/    /            \:::\    \                |::|   |          
       \::::/    /              \:::\____\        /:::/    /              \:::\____\               \::|   |          
        \::/____/                \::/    /        \::/    /                \::/    /                \:|   |          
         ~~                       \/____/          \/____/                  \/____/                  \|___|          
                                                                                                                     ");
            Console.WriteLine();
            Console.ResetColor();
        }

        private static void PrintRed()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
          _____                    _____                    _____          
         /\    \                  /\    \                  /\    \         
        /::\    \                /::\    \                /::\    \        
       /::::\    \              /::::\    \              /::::\    \       
      /::::::\    \            /::::::\    \            /::::::\    \      
     /:::/\:::\    \          /:::/\:::\    \          /:::/\:::\    \     
    /:::/__\:::\    \        /:::/__\:::\    \        /:::/  \:::\    \    
   /::::\   \:::\    \      /::::\   \:::\    \      /:::/    \:::\    \   
  /::::::\   \:::\    \    /::::::\   \:::\    \    /:::/    / \:::\    \  
 /:::/\:::\   \:::\____\  /:::/\:::\   \:::\    \  /:::/    /   \:::\ ___\ 
/:::/  \:::\   \:::|    |/:::/__\:::\   \:::\____\/:::/____/     \:::|    |
\::/   |::::\  /:::|____|\:::\   \:::\   \::/    /\:::\    \     /:::|____|
 \/____|:::::\/:::/    /  \:::\   \:::\   \/____/  \:::\    \   /:::/    / 
       |:::::::::/    /    \:::\   \:::\    \       \:::\    \ /:::/    /  
       |::|\::::/    /      \:::\   \:::\____\       \:::\    /:::/    /   
       |::| \::/____/        \:::\   \::/    /        \:::\  /:::/    /    
       |::|  ~|               \:::\   \/____/          \:::\/:::/    /     
       |::|   |                \:::\    \               \::::::/    /      
       \::|   |                 \:::\____\               \::::/    /       
        \:|   |                  \::/    /                \::/____/        
         \|___|                   \/____/                  ~~              ");
            Console.WriteLine();
            Console.WriteLine();

            Console.ResetColor();
        }

        private static void ChanceHeader()
        {
            Console.WriteLine(@" 
                                 ___                                                  __
                               //   ) )                                             //  ) ) 
                              //         ___      _   __      ___          ___   __//__     
                             //  ____  //   ) ) // ) )  ) ) //___) )     //   ) ) //        
                            //    / / //   / / // / /  / / //           //   / / //         
                           ((____/ / ((___( ( // / /  / / ((____       ((___/ / //          
                                                                                        
                                     ___                                                   
                                   //   ) )                                             
                                  //        / __      ___       __      ___      ___    
                                 //        //   ) ) //   ) ) //   ) ) //   ) ) //___) ) 
                                //        //   / / //   / / //   / / //       //        
                               ((____/ / //   / / ((___( ( //   / / ((____   ((____  
");
        }

        public static void RunGameOfChance(Player p)
        {
            GameOfChance gOC = new GameOfChance();
            gOC.GameOfChanceGame(p);
        }
    }
}
