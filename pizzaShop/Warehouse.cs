using System;
using System.Collections.Generic;
using System.Linq;

namespace pizzaShop
{
    class Warehouse
    {
        List<Pizza> InStock;
        List<Pizza> Custom;
        List<Pizza> Large;

        public Warehouse()
        {
            InStock = new List<Pizza>();
            Custom = new List<Pizza>();
            Large = new List<Pizza>();

            //Pizzas
            Pizza arizona = new Pizza(1, "Arizona", 8.99, "Peperoni, pickles, onion, cheese ", "Small");
            InStock.Add(arizona);

            Pizza california = new Pizza(2, "California", 7.99, "Pineapple, blue cheese, cheese, onion", "Small");
            InStock.Add(california);

            Pizza oklahoma = new Pizza(3, "Oklahoma", 6.99, "Chicken, pineapple, cheese, ham", "Small");
            InStock.Add(oklahoma);

            Pizza texas = new Pizza(4, "Texas", 9.99, "Kebab, onion, cheese, tomato", "Small");
            InStock.Add(texas);

            Pizza missouri = new Pizza(5, "Missouri", 10.99, "Tuna fish, sweet pepper,, cheese, pickles", "Small");
            InStock.Add(missouri);
            
            //Large pizzas
            Pizza arizonaLarge = new Pizza(1, "Arizona", 9.99, "Peperoni, pickles, onion, cheese ", "Large");
            Large.Add(arizonaLarge);

            Pizza californiaLarge = new Pizza(2, "California", 8.99, "Pineapple, blue cheese, cheese, onion", "Large");
            Large.Add(californiaLarge);

            Pizza oklahomaLarge = new Pizza(3, "Oklahoma", 7.99, "Chicken, pineapple, cheese, ham", "Large");
            Large.Add(oklahomaLarge);

            Pizza texasLarge = new Pizza(4, "Texas", 10.99, "Kebab, onion, cheese, tomato", "Large");
            Large.Add(texasLarge);

            Pizza missouriLarge = new Pizza(5, "Missouri", 11.99, "Tuna fish, sweet pepper, cheese, pickles", "Large");
            Large.Add(missouriLarge);

            //Ingredients
            Pizza cheese = new Pizza(1, "Ingredient ExtraCheese", 1, "", "");
            Custom.Add(cheese);

            Pizza bacon = new Pizza(2, "Bacon", 1.50, "", "");
            Custom.Add(bacon);

            Pizza tuna = new Pizza(3, "Tuna fish", 2, "", "");
            Custom.Add(tuna);

            Pizza shrimp = new Pizza(4, "Shrimp", 3, "", "");
            Custom.Add(shrimp);

            Pizza mushrooms = new Pizza(5, "Mushrooms", 1.50, "", "");
            Custom.Add(mushrooms);


        }

        public void PrintInStock()
        {
            foreach (Pizza pizza in InStock)
            {
                Console.WriteLine($"ID: {pizza.Id}");
                Console.WriteLine($"NAME: {pizza.Name}");
                Console.WriteLine($"Price: {pizza.Price}");
                Console.WriteLine($"Description: {pizza.Description}");
                Console.WriteLine($"Size: {pizza.Size}");
                Console.WriteLine();
            }
        }

        public void PrintLargeStock()
        {
            
            foreach (Pizza pizza in Large)
            {
                Console.WriteLine($"ID: {pizza.Id}");
                Console.WriteLine($"NAME: {pizza.Name}");
                Console.WriteLine($"Price: {pizza.Price}");
                Console.WriteLine($"Description: {pizza.Description}");
                Console.WriteLine($"Size: {pizza.Size}");
                Console.WriteLine();
            }
        }

        public void PrintInStockIngredients()
        {
            foreach (Pizza pizza in Custom)
            {
                Console.WriteLine($"ID: {pizza.Id}");
                Console.WriteLine($"Ingredient: {pizza.Name}");
                Console.WriteLine($"Price: {pizza.Price}");
                Console.WriteLine();
            }
        }

        //get an article object from the list
        public Pizza GetFromStock(int id)
        {
            return InStock[id - 1];
        }
        public Pizza GetLargeFromStock(int id)
        {
            return Large[id - 1];
        }
        public Pizza GetIngredientsFromStock(int id)
        {
            return Custom[id - 1];
        }

    }
}
