//Alfonzo Avila     aavila28@cnm.edu
// File: AvilaP1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string boxnumber = "001";
            int numval;
            Int32.TryParse(boxnumber, out numval);
            
                Console.Write("{0}", numval);
            


            string repeat;

            string choice;
            string header= "Alfonzo Avila\nBurma Shave\n\n"+
                              "The objective of this program is to for the user to pick a number\n"+
                              "from 1 to 3. A different Burma Shave quote will appear for each number.\n";

            string instructions = "\n\nPick a number from 1 to 3    ";

            string quote;
     
              
                Console.WriteLine("{0}", header);
            do
            {

                Console.WriteLine("{0}", instructions);

                choice = Console.ReadLine();
               

                if (choice == "1")
                {

                    quote = "His cheek\nWas rough\nHis chick vamoosed\nAnd now she won't\nCome home to roost\nBurma-Shave\n";
                    Console.WriteLine("{0}", quote);

                }


                else if (choice == "2")
                {
                    quote = "Burma-Shave\nWas such a boom\nThey passed\nThe bride \nAnd kissed the groom\n";
                    Console.WriteLine("{0}", quote);


                }

                else if (choice == "3")
                {
                    quote = "A whiskery kiss\nFor the one\nYou adore\nMay not make her mad\nBut her face will be sore\nBurma-Shave\n";
                    Console.WriteLine("{0}", quote);

                }

                else
                {
                    Console.WriteLine("Your input was invalid.\n");

                }



                Console.Write("\nWould you like do another?\n");
                Console.Write("Enter \"y\" for yes and \"n\" for no.");


                repeat = Console.ReadLine();

            } while (repeat == "y");

            Console.WriteLine("\nThank you for using my program. :D \n");


        }
    }
}
