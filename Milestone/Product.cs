using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Enrique Tovar
//This is my own work
namespace Milestone
{
    class Product
    {
        private String name;
        private String id;
        private String origin;
        private double weight;
        private double price;
        private String brand;
        private int stock;

        public Product(string n, string i, string o, double w, double p, string b, int s)
        {
            name = n;
            id = i;
            origin = o;
            weight = w;
            price = p;
            brand = b;
            stock = s;
        }
        public string getName() { return name; }
        public string getId() { return id; }
        public string getOrigin() { return origin; }
        public double getWeight() { return weight; }
        public double getPrice() { return price; }
        public string getBrand() { return brand; }
        public int getStock() { return stock; }

        public void setName(string n) { name = n; }
        public void setId(string i) { id = i; }
        public void setOrigin(string o) { origin = o; }
        public void setWeight(double w) { weight = w; }
        public void setPrice(double p) { price = p; }
        public void setBrand(string b) { brand = b; }
        public void setStock (int s) { stock = s; }


    }
}
