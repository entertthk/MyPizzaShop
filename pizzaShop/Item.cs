using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{
    class Item
    {
        Pizza pizza;
        int quantity;

        public Item(Pizza _pizza, int _quantity)
        {
            pizza = _pizza;
            quantity = _quantity;
        }
        public Pizza Pizza
        {
            get { return pizza; }
        }
       
        public void PrintItem()
        {
            Console.WriteLine($" ID: {pizza.Id} \n Name: {pizza.Name} \n Size: {pizza.Size} \n Price: {pizza.Price} \n Quantity: {quantity} Total: {CalculateItemTotal()}");
        }
        public double CalculateItemTotal()
        {
            return Pizza.Price * quantity;
        }
    }

}
