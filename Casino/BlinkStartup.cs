﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class BlinkStartup
    {
        public static void CasinoHeader()
        {
            Console.WriteLine(@"        
        CCCCCCCCCCCCC                                    iiii  
     CCC::::::::::::C                                   i::::i 
   CC:::::::::::::::C                                    iiii  
  C:::::CCCCCCCC::::C                                             
 C:::::C       CCCCCC  aaaaaaaaaaaaa      ssssssssss   iiiiiiinnnn  nnnnnnnn       ooooooooooo  
C:::::C                a::::::::::::a   ss::::::::::s  i:::::in:::nn::::::::nn   oo:::::::::::oo
C:::::C                aaaaaaaaa:::::ass:::::::::::::s  i::::in::::::::::::::nn o:::::::::::::::o
C:::::C                         a::::as::::::ssss:::::s i::::inn:::::::::::::::no:::::ooooo:::::o  
C:::::C                  aaaaaaa:::::a s:::::s  ssssss  i::::i  n:::::nnnn:::::no::::o     o::::o
C:::::C                aa::::::::::::a   s::::::s       i::::i  n::::n    n::::no::::o     o::::o
C:::::C               a::::aaaa::::::a      s::::::s    i::::i  n::::n    n::::no::::o     o::::o
 C:::::C       CCCCCCa::::a    a:::::assssss   s:::::s  i::::i  n::::n    n::::no::::o     o::::o
  C:::::CCCCCCCC::::Ca::::a    a:::::as:::::ssss::::::si::::::i n::::n    n::::no:::::ooooo:::::o
   CC:::::::::::::::Ca:::::aaaa::::::as::::::::::::::s i::::::i n::::n    n::::no:::::::::::::::o 
     CCC::::::::::::C a::::::::::aa:::as:::::::::::ss  i::::::i n::::n    n::::n oo:::::::::::oo
        CCCCCCCCCCCCC  aaaaaaaaaa  aaaa sssssssssss    iiiiiiii nnnnnn    nnnnnn   ooooooooooo

       -----------------------------------------------------------------------------------------
       -----------------------------------------------------------------------------------------
");
        }

        public static void BlinkPressAnyKey()
        {
            string title = @"                                           Press any key";

            bool visible = true;
            while (!Console.KeyAvailable)
            {
                for (int i = 0; i <= 1; i++)
                {
                    Console.Write("\r" + (visible ? title : new String(' ', title.Length)));
                    System.Threading.Thread.Sleep(600);
                    visible = !visible;
                }
            }
        }
    }
}