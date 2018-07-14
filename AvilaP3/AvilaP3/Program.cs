using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP3
{
    class Program
    { 

        static void Main(string[] args)
        {
            string header = "Alfonzo Avila  aavila28@cnm.edu\n" +
                "Program 3 : Program Store\n" +
                "The objective of this program is to create a catalog of items for sale.\n\n";

            Console.WriteLine("{0}", header);
            
            string choice;

            CatalogItem[] items = new CatalogItem[0];
            Console.WriteLine("Welcome to the C# Program store!\n");
            Console.WriteLine("\nLet's start with our catalog items.");

            do
            {
                Console.WriteLine("\n                  *******Items*******\n"+
                                "\nItem #  |  SKU  |   Title   |   Description   |   Price\n");
               

                for(int i = 0; i <items.Length; ++i)
                {
                    int itemNum = 1 + i;
                    Console.WriteLine(itemNum +". | "+items[i] + "\n");

                }

                Console.WriteLine("\nWhat would you like to do?"+"\nHere are the commands\n"
                    + "Enter \"a\"  To Add an Item   \n" + "Enter \"r\"  To Remove an Item \n" +
                    "Enter \"q\"  To Quit \n");

                    choice = Console.ReadLine();

                if(choice == "a")
                {
                    CatalogItem newitem = new CatalogItem();
                  
                   items = NewItem(items, newitem);
                }

                else if(choice == "r")
                {
                    
                    
                        CatalogItem removed = new CatalogItem();
                        items = RemoveItem(items);
                    
                }

                else
                {
                    Console.WriteLine("\nThat is not a valid option. Please try again.");
                }




               


            } while (choice != "q");

            Console.WriteLine("\n\nThanks for visting! Until Next Time!\n");



        }


        static public CatalogItem[] NewItem(CatalogItem[] catalog, CatalogItem newitem)
        {
            int newlength = catalog.Length + 1;

            CatalogItem[] result = new CatalogItem[newlength];
            string isku, ititle, idesc, temp;
            decimal iprice;

            Console.WriteLine("\n                  *******Add an Item*******\n");

            Console.WriteLine("\nEnter the SKU for the new product. ");
            isku = Console.ReadLine();

            Console.WriteLine("\nEnter the Title for the new product.   ");
            ititle = Console.ReadLine();

            Console.WriteLine("\nEnter the Description for the new product. ");
            idesc = Console.ReadLine();

            Console.WriteLine("\nEnter the Price for the new product.   ");
            temp = Console.ReadLine();
            iprice = System.Convert.ToDecimal(temp);

            newitem.SetSku(isku);
            newitem.SetTitle(ititle);
            newitem.SetDesc(idesc);
            newitem.SetPrice(iprice);

            for(int i=0; i < catalog.Length;++i)
            {
                result[i] = catalog[i];
            }
           
            result[newlength-1] = newitem;


            return result;

        }

        static public CatalogItem[] RemoveItem(CatalogItem[] items)
        {
            int newlength = items.Length - 1;
            int index, conv;
            string temp;
            
            // ask index
            Console.WriteLine("\n                  *******Remove an Item*******\n");

            if (newlength < 0)
            {
                Console.WriteLine("\nThere are no items to remove. Try another selection.\n");
                CatalogItem[] result = new CatalogItem[0]; 
                result = items;
                return result;


            }

            else
            {
                CatalogItem[] result = new CatalogItem[newlength];
                Console.WriteLine("\nEnter the item # you would like to remove.   ");

                temp = Console.ReadLine();
                bool parSucc = Int32.TryParse(temp, out conv);
                if (parSucc == false)
                {
                    Console.WriteLine("\nERROR CONVERTING STRING TO INT.\n");
                }

                index = conv - 1;



                
                int newcounter = 0;
                for (int i = 0; i < items.Length; ++i)
                {
                    if (i == index)
                    {
                        continue;
                    }
                    result[newcounter] = items[i];
                    newcounter++;

                }
                return result;
            }

            
        }


    }
}
