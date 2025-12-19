using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Item
    {
        public string name;
        public string Category;
        public string Country;
        public int weight;
        public Item(string name, string category, string Country, int weight) 
        {
            this.name = name;
            this.Category = category;
            this.Country = Country;
            this.weight = weight;
        }
        public string GetInfo() 
        {
            return "Name - " + name + "\nCategory - " + Category + "\nCountry - " + Country + "\nPrice - " + weight;
        }
    }
}
