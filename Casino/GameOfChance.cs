using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class GameOfChance
    {
        public void GameOfChanceGame()
        {
            bool boolean = true;
            string guess;

            while (boolean == true)
            {
                do
                {
                    Console.Clear();
                    ChanceHeader();

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
                        }
                        else if (guess == "BLACK" && result == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Congratulations!");
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

                if (choice == "N")
                {
                    boolean = false;
                }
                else
                {
                    boolean = true;
                }
            }

            Console.Write("Want to exit game? Y or N: ");
            string exitChoice = Console.ReadLine();
            exitChoice = exitChoice.ToUpper();

            if (exitChoice == "Y")
            {
                Environment.Exit(0);
            }
            else
            {
                GameOfChanceGame();
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

        public static void RunGameOfChance()
        {
            GameOfChance gOC = new GameOfChance();
            gOC.GameOfChanceGame();
        }
    }
}
