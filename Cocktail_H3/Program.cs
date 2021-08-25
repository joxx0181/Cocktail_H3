using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail_H3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your password: ");
            string userPass = Console.ReadLine();

            if (userPass == "9911")
            {
                Console.WriteLine("\nVelcome to the Administrator. \n\nYou have the following options: ");
                Console.WriteLine("\n1) Create data in all empty tables. \n2) Add new data to a table. \n3) Delete data from a table.");
                string adminChoice = Console.ReadLine();

                int choiceA = int.Parse(adminChoice);

                // Statement depending on user input!
                switch (choiceA)
                {
                    case 1:

                        // Create object and call methods to fill database with data!
                        DrinkDataLayer d = new DrinkDataLayer();
                        d.LoadAlcoBrandData();
                        d.LoadAlcoQtyData();
                        d.LoadIngredientData();
                        d.LoadIngredientQtyData();
                        d.LoadDrinkData();

                        Console.WriteLine("Data generated successfully.");
                        break;
                    case 2:

                        using (CocktailH3Context ctx = new CocktailH3Context())
                        {
                            AlcoBrand addToBrandData = new AlcoBrand();

                            // View all brands with Lambda!
                            IEnumerable<AlcoBrand> showBrand = ctx.AlcoBrands.Where(s => s.BrandId > 0);
                            foreach (AlcoBrand b in showBrand)
                            {
                                Console.WriteLine(b.BrandId + b.BrandName);
                            }

                            Console.Write("Enter a alco brand to the database: ");
                            string userBrand = Console.ReadLine();

                            // Adding fields to be insert in database!
                            addToBrandData.BrandId = 100;
                            addToBrandData.BrandName = userBrand;
                            ctx.AlcoBrands.Add(addToBrandData);

                            // executes commands to implement the changes to the database!
                            ctx.SaveChanges();

                            Console.WriteLine("Data generated successfully.");
                        }

                        break;
                    case 3:

                        // Delete data from table!
             
                            break;
                    default:
                        break;
                }
            }
            else if (userPass == "7744" || userPass == "4477")
            {
                Console.WriteLine("\nVelcome to the cocktail database. \n\nYou have the following options: ");
                Console.WriteLine("\n1) Search for a specific drink, brand or ingredient. \n2) View all drinks.");
                string userChoice = Console.ReadLine();

                int choiceU = int.Parse(userChoice);

                // Statement depending on user input!
                switch (choiceU) {
                    case 1:

                        Console.Write("Enter a specific drink name or alco brand: ");
                        string userSearch = Console.ReadLine();

                        using (CocktailH3Context ctx = new CocktailH3Context())
                        {
                            // View search result with joins, where and Contains!
                            var query = from d in ctx.Drinks
                                        join aq in ctx.AlcoQuantities
                                          on d.AlcoQtyId equals aq.AlcoQtyId
                                        join ab in ctx.AlcoBrands
                                          on aq.BrandId equals ab.BrandId
                                        where (ab.BrandName.Contains(userSearch) || d.DrinkName.Contains(userSearch))
                                        select new
                                        {
                                            d.DrinkName,
                                            ab.BrandName
                                        };

                            foreach (var all in query)
                            {
                                Console.WriteLine(all.DrinkName + " include this brand: " + all.BrandName);
                            }
                        }
                        break;
                    case 2:

                        // View all drinks with joins!
                        using (CocktailH3Context ctx = new CocktailH3Context())
                        {
                            var query = from d in ctx.Drinks
                                        join aq in ctx.AlcoQuantities
                                          on d.AlcoQtyId equals aq.AlcoQtyId
                                        join ab in ctx.AlcoBrands
                                          on aq.BrandId equals ab.BrandId
                                        join iq in ctx.IngredientQuantities
                                          on d.QtyId equals iq.QtyId
                                        join ing in ctx.Ingredients
                                          on iq.IngredId equals ing.IngredId 
                                        select new
                                        {
                                            d.DrinkName,
                                            aq.AlcoQtyNum,
                                            aq.AlcoQtyUnit,
                                            ab.BrandName,
                                            iq.QtyNum,
                                            iq.QtyUnit,
                                            ing.IngredName
                                        };

                            foreach (var all in query)
                            {
                                Console.WriteLine(all.DrinkName + " include this brand and indgredient: " + all.AlcoQtyNum + all.AlcoQtyUnit + " " + all.BrandName + " " + all.QtyNum + all.QtyUnit + " " + all.IngredName);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("You do not have authorized access to this database.");
            }
            Console.ReadKey();
        }
    }
}
