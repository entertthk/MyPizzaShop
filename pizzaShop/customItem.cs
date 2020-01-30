using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{
    class CustomItem
    { 
        int id = 13;
        string name = "Custom Pizza";
        string add1;
        string add2;
        string add3;
        string add4;
        

        public CustomItem(int _id, string _add1, string _add2, string _add3, string _add4)
        {
            id = _id;
            add1 = _add1;
            add2 = _add2;
            add3 = _add3;
            add4 = _add4;
        }


        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }
        public void CustomPrintItem()
        {
            Console.WriteLine($"ID: {id}\n Your custom pizza \n Ingredient: {add1} \n Ingredient: {add2} \n Ingredient: {add3} \n Ingredient: {add4} \n Special price: 15");
        }


    }
}
