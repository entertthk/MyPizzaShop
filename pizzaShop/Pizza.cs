using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{

    class Pizza
    {
        int id;
        string name;
        double price;
        string description;
        string size;
    
    

        public Pizza(int _id, string _name, double _price, string _description, string _size)
        {
            id = _id;
            name = _name;
            price = _price;
            description = _description;
            
            size = _size;
        }

        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return price; }
        }

        public string Description
        {
            get { return description; }
        }
     
        public string Size
        {
            get { return size; }
        }

    }
}
