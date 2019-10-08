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

            while (boolean == true)
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
                        }
                    } while (bet > p.money || bet < 1);
                    
                    p.money -= bet;

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
                        System.Threading.Thread.Sleep(500);
                        int result = randomNumber.Next(1, 3);

                        Console.Write("It was");

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                            System.Threading.Thread.Sleep(600);
                        }

                        if (result == 1)
                        {
                            PrintRed();
                        }
                        else
                        {
                            PrintBlack();
                        }

                        if (guess == "RED" && result == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Congratulations!");
                            Console.WriteLine($"You bet {bet}");
                            bet *= 2;
                            Console.WriteLine($"You just won {bet}");
                            p.money += bet;
                        }
                        else if (guess == "BLACK" && result == 2)
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
                        Console.Clear();
                        ChanceHeader();
                    }
                } while (guess != "RED" && guess != "BLACK");

                Console.Write("Want to go again? Y or N: ");
                string choice = Console.ReadLine();
                choice = choice.ToUpper();

                //Städa upp här, står i fel ordning
                //if (choice == "Y")
                //{
                //    if (p.money > 0)
                //    {

                //    }
                //}
                if (p.money > 0)
                {
                    if (choice == "N")
                    {
                    }
                    if (choice == "Y")
                    {
                        boolean = true;
                    }
                    else
                    {
                        while (choice != "Y" && choice != "N")
                        {
                            Console.WriteLine("Sorry, didn't catch that...");
                            Console.Write("Want to go again? Y or N: ");
                            choice = Console.ReadLine();
                            choice = choice.ToUpper();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, insufficient funds...");
                    Console.ReadKey();
                }
            }

            Console.Write("Want to exit game? Y or N or M for menu: ");
            string exitChoice = Console.ReadLine();
            exitChoice = exitChoice.ToUpper();

            if (exitChoice == "Y")
            {
                Environment.Exit(0);
            }
            else if (exitChoice == "M")
            {
                
            }
            else
            {
                RunGameOfChance(p);
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
