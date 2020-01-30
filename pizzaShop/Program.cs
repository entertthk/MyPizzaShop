using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a warehouse object
            Warehouse currentlyInStock = new Warehouse();
            //create a shopping cart object
            ShoppingCart shoppingCart = new ShoppingCart();
            
            Console.WriteLine("MY PIZZA SHOP");

            //display the warehouse content
            currentlyInStock.PrintInStock();
            

            Console.WriteLine("Small, large or custom pizza (small/large/custom)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "small")
            {
                Console.Clear();
                currentlyInStock.PrintInStock();
                AddItemsToShoppingCart(currentlyInStock, shoppingCart);
            }
            else if (answer == "large")
            {
                Console.Clear();
                currentlyInStock.PrintLargeStock();
                AddLargeShoppingCart(currentlyInStock, shoppingCart);
            }
            else if (answer == "custom")
            {
                Console.Clear();
                currentlyInStock.PrintInStockIngredients();
                AddCustomItems(currentlyInStock, shoppingCart);
            }


            while (true)
            {
                
                Console.WriteLine("Add/Remove/Confirm");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "add")
                {
                    Console.WriteLine("Small or large pizza (small/large/custom)");
                    string answer2 = Console.ReadLine().ToLower();
                    if (answer2 == "small")
                    {
                        Console.Clear();
                        currentlyInStock.PrintInStock();
                        AddItemsToShoppingCart(currentlyInStock, shoppingCart);
                        
                    }
                    else if (answer2 == "large")
                    {
                        Console.Clear();
                        currentlyInStock.PrintLargeStock();
                        AddLargeShoppingCart(currentlyInStock, shoppingCart);
                    }
                    else if (answer2 == "custom")
                    {
                        Console.Clear();
                        currentlyInStock.PrintInStockIngredients();
                        AddCustomItems(currentlyInStock, shoppingCart);
                    }
                }
                else if (userInput == "remove")
                {
                    Console.WriteLine("Enter the id of the product to remove from the shopping cart");
                    int itemIdToRemove = int.Parse(Console.ReadLine());
                    shoppingCart.RemoveFromShoppingCart(itemIdToRemove);
                    shoppingCart.PrintShoppingCart();
                }
                else if (userInput == "confirm")
                {
                    Console.Clear();
                    shoppingCart.PrintShoppingCart();
                    shoppingCart.Sum();
                    Console.WriteLine($"TOTAL:{shoppingCart.BasketSum}");
                }

            }
            Console.ReadLine();
        }

        public static void AddItemsToShoppingCart(Warehouse currentlyInStock, ShoppingCart shoppingCart)
        {
            Console.WriteLine("Enter the id of the product to add it to the shopping cart: ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            Pizza articleToAdd = currentlyInStock.GetFromStock(productID);
            shoppingCart.AddToShoppingCart(articleToAdd, quantity);
            
            Console.WriteLine("Add ingredients? (yes/no)");
            string answer3 = Console.ReadLine().ToLower();
            if (answer3 == "yes")
            {
                Console.Clear();
                currentlyInStock.PrintInStockIngredients();
                AddIngredientsShoppingCart(currentlyInStock, shoppingCart);
            }
            else if (answer3 == "no")
            {
                shoppingCart.PrintShoppingCart();
            }
            
        }

        public static void AddLargeShoppingCart(Warehouse currentlyInStock, ShoppingCart shoppingCart)
        {
            Console.WriteLine("Enter the id of the product to add it to the shopping cart: ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            Pizza articleToAdd = currentlyInStock.GetLargeFromStock(productID);
            shoppingCart.AddToShoppingCart(articleToAdd, quantity);
            
            Console.WriteLine("Add ingredients? (yes/no)");
            string answer3 = Console.ReadLine().ToLower();
            if (answer3 == "yes")
            {
                Console.Clear();
                currentlyInStock.PrintInStockIngredients();
                AddIngredientsShoppingCart(currentlyInStock, shoppingCart);
            }
            else if (answer3 == "no")
            {
                shoppingCart.PrintShoppingCart();
            }
            
        }

        public static void AddIngredientsShoppingCart(Warehouse currentlyInStock, ShoppingCart shoppingCart)
        {
            Console.WriteLine("Enter the id of the Ingredients to add it to the shopping cart: ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            Pizza articleToAdd = currentlyInStock.GetIngredientsFromStock(productID);
            shoppingCart.AddToShoppingCart(articleToAdd, quantity);
            shoppingCart.PrintShoppingCart();
        }

        public static void AddCustomItems(Warehouse currentlyInStock, ShoppingCart shoppingCart)
        {
            //parsemine ei hakanud tööle
            Console.WriteLine("Enter the name of the 1. Ingredient to add it to the pizza: ");
            string productID = Console.ReadLine();
            Console.WriteLine("Enter the name of the 2. Ingredient to add it to the pizza: ");
            string productID2 = Console.ReadLine();
            Console.WriteLine("Enter the name of the 3. Ingredient to add it to the pizza: ");
            string productID3 = Console.ReadLine();
            Console.WriteLine("Enter the name of the 4. Ingredient to add it to the pizza: ");
            string productID4 = Console.ReadLine();



            shoppingCart.AddToCustomShoppingCart(13, productID, productID2, productID3, productID4);
            shoppingCart.PrintShoppingCart();


        }


    }
}

