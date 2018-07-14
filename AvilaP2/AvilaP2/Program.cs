using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alfonzo Avila    aavila28@cnm,edu\n"
                                +"Program 2 : Lottery\n\n"
                                +"The objective of this program is to generate 3 random numbers from 1 to 3.\n"
                                +"The user will then enter 3 numbers. If they match any of the randomly generated\n"
                                +"numbers, the user is awarded with money.\n\n");

            string repeat;

            Console.WriteLine("\nWelcome to the C# Lottery Game!\n");

            do
            {
                //initializing random number
                Random rnd1 = new Random();
              



                int[] rand;
                rand = new int[3];

                int[] userin;
                userin = new int[3];

                int[] match= new int[3];
               
                for(int i = 0; i<3;++i)
                {

                    // intializing array to keep track of matches. if > -1 there was a match
                    match[i] = -1;
                }

                string writeresult = "";
                string temp;
                int result;
                int award;

                rand[0]= rnd1.Next(1, 4);
                rand[1] = rnd1.Next(1, 4);
                rand[2] = rnd1.Next(1, 4);



                Console.WriteLine("\nEnter a number from 1-4.   ");
                temp = Console.ReadLine();

                bool parsucc = Int32.TryParse(temp, out result);

                if (parsucc == true)
                {
                    userin[0] = result;
                }
                else
                {
                    
                    Console.WriteLine("Attempted conversion of '{0}' failed.", temp);
                }




                Console.WriteLine("\nEnter another number from 1-4.   ");
                temp = Console.ReadLine();

                parsucc = Int32.TryParse(temp, out result);

                if (parsucc == true)
                {
                    userin[1] = result;
                }
                else
                {

                    Console.WriteLine("Attempted conversion of '{0}' failed.", temp);
                }

                Console.WriteLine("\nEnter one more number from 1-4.   ");
                temp = Console.ReadLine();

                parsucc = Int32.TryParse(temp, out result);

                if (parsucc == true)
                {
                    userin[2] = result;
                }
                else
                {

                    Console.WriteLine("Attempted conversion of '{0}' failed.", temp);
                }



                Console.WriteLine("\nAwesome! Your numbers are {0}, {1}, {2}.", userin[0], userin[1], userin[2]);
                Console.WriteLine("\nThe lottery numbers are {0}, {1}, {2}.", rand[0], rand[1], rand[2]);

                int numMatches=0;

                if (userin[0] == rand[0] & userin[1] == rand[1] & userin[2] == rand[2])
                {

                    award = 10000;
                    writeresult = "\nCongratulations, you matched all three numbers in exact order! You win $" + award + "!\n";
                    numMatches = -1;


                }

                else
                {
                    //loop for user choices
                    for (int i = 0; i < 3; ++i)
                    {

                        //loop for random numbers
                        for (int j = 0; j < 3; ++j)
                        {

                            if (userin[i] == rand[j])
                            {
                                userin[i] = 0;
                                rand[j] = 0;

                                //track which userin matched with which randomNum-AA
                                match[i] = j;

                                //track total matches
                                ++numMatches;
                                break;
                            }

                        }

                    }
                }


             
  
                //results analysis
             if(numMatches == 0)
                {
                    award = 0;
                    writeresult = "\nSorry, you had zero matches. You win $"+award+".\n";

                }

             else if(numMatches == 1)
                {
                    award = 10;
                    writeresult = "\nCongratulations, you matched one number! You win $" + award + "!\n";
                }

             else if(numMatches==2)
                {
                    award = 100;
                    writeresult= "\nCongratulations, you matched two numbers! You win $" + award + "!\n";
                }
                else if (numMatches == 3)
                {
                    award = 1000;
                    writeresult = "\nCongratulations, you matched all three numbers! You win $" + award + "!\n";
                }


                Console.WriteLine(writeresult);


                Console.WriteLine("\nWould you like to do another?\n" +
                                    "Enter \"y\" for YES and \"n\" for NO.  ");
                repeat = Console.ReadLine();

            } while (repeat == "y");

            Console.WriteLine("\nThanks for playing! Until next time ;D");


        }
    }
}
