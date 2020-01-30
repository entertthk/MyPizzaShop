using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{
    class ShoppingCart
    {
        List<Item> shoppingCart;
        List<CustomItem> customCart;
        double basketSum;

        public ShoppingCart()
        {
            shoppingCart = new List<Item>();
            customCart = new List<CustomItem>();
            basketSum = 0;
        }

        public double BasketSum
        {
            get { return basketSum; }
        }

        public void AddToShoppingCart(Pizza pizza, int quantity)
        {
            Item newItem = new Item(pizza, quantity);
            shoppingCart.Add(newItem);
        }
        public void AddToCustomShoppingCart(int id, string add1, string add2, string add3, string add4)
        {
            CustomItem newItem = new CustomItem(id,add1, add2, add3, add4);
            customCart.Add(newItem);
        }

        public void RemoveFromShoppingCart(int id)
        {
            for (int i = 0; i < shoppingCart.Count; i++)
            {
                if (shoppingCart[i].Pizza.Id == id)
                {
                    Console.WriteLine($"{shoppingCart[i].Pizza.Name} has been removed. ");
                    shoppingCart.Remove(shoppingCart[i]);
                }
            }



            //PrintShoppingCart();
        }

        public void PrintShoppingCart()
        {
            if (shoppingCart.Count == 0 & customCart.Count == 0)
            {
                Console.WriteLine("shopping cart is empty");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("SHOPPING CART:");
                foreach (Item item in shoppingCart)
                {
                    item.PrintItem();
                }
                
                foreach (CustomItem CustomItem in customCart)
                {
                    CustomItem.CustomPrintItem();
                }
            }
        }

        public void Sum()
        {
            if (customCart.Count > 0)
            {
                foreach (Item item in shoppingCart)
                {
                    basketSum = basketSum + item.CalculateItemTotal();
                }

                basketSum = basketSum + 15;
            }
            else
            {

                foreach (Item item in shoppingCart)
                {
                    basketSum = basketSum + item.CalculateItemTotal();
                }
            }
        }
    }
}
