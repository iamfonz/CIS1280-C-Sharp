//TODO: -3 no comment header
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvilaP6
{
    class Program
    {
        static void Main(string[] args)
        {
            string header = "Alfonzo Avila  aavila28@cnm.edu\n" +
                "Program 5 : Program Store\n" +
                "The objective of this program is to create a catalog of items for sale\nusing constructors.\n\n";

            Console.WriteLine("{0}", header);

            string choice;

            Console.WriteLine("Welcome to the C# Program store!\n");
            Console.WriteLine("\nLet's start with our catalog items.");

            Catalog catalog = new Catalog();


            do
            {
                Console.WriteLine(catalog.ToString());

                Console.WriteLine("\nWhat would you like to do?" + "\n\n  ******Commands******\n"
                    + "Enter \"a\"  To Add an Item   \n" + "Enter \"r\"  To Remove an Item \n" +
                    "Enter \"q\"  To Quit \n");

                choice = Console.ReadLine();
                Catalog tempcat = new Catalog();

                if (choice == "a")
                {
                    List<CatalogItem> tlist = new List<CatalogItem>();

                    tlist = catalog.Items;

                    CatalogItem newitem = new CatalogItem();
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

                    newitem.Sku = isku;
                    newitem.Title = ititle;
                    newitem.Desc = idesc;
                    newitem.Price = iprice;

                    tlist.Add(newitem);

                    
                }

                else if (choice == "r")
                {
                    int index, conv;
                    string temp;

                    List<CatalogItem> tlist = new List<CatalogItem>();

                    tlist = catalog.Items;



                    // ask index
                    Console.WriteLine("\n                  *******Remove an Item*******\n");


                    if (tlist.Count == 0)
                    {
                        Console.WriteLine("There are no items in the catalog to remove.");
                    }

                    else
                    {

                        Console.WriteLine("\nEnter the item # you would like to remove.   ");

                        temp = Console.ReadLine();
                        bool parSucc = Int32.TryParse(temp, out conv);
                        if (parSucc)
                        {
                            index = conv - 1;

                            if (index > tlist.Count || index < 0)
                            {
                                Console.WriteLine("That entry is invalid.");
                            }
                            else
                            {
                                tlist.RemoveAt(index);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nERROR CONVERTING STRING TO INT.\n");
                        }
                    }


                    catalog.Items = tlist;

                }

                else if (choice == "q")
                {
                    Console.WriteLine("\n\nThanks for visting! Until Next Time!\n");

                }

                else
                {
                    Console.WriteLine("\nThat is not a valid option. Please try again.");
                }

            } while (choice != "q");
        }
    }
}
