using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Apple = new Product("Honeycrisp", "1", "Oregon", .05, 2.00,"Tovar", 1000);
            //name test
            Console.WriteLine("Apple name is " + Apple.getName());

            Console.WriteLine("Setting apple name to Green");
            Apple.setName("Green");

            Console.WriteLine("Apple name is " + Apple.getName());

            //id test
            Console.WriteLine("Apple ID is " + Apple.getId());

            Console.WriteLine("Setting apple Id to 2");
            Apple.setId("2");

            Console.WriteLine("Apple ID is " + Apple.getId());

            //origin test
            Console.WriteLine("Apple origin is " + Apple.getOrigin());

            Console.WriteLine("Setting apple origin to Arizona");
            Apple.setOrigin("Arizona");

            Console.WriteLine("Apple origin is " + Apple.getOrigin());

            //weight test
            Console.WriteLine("Apple weight is " + Apple.getWeight());

            Console.WriteLine("Setting apple weight to 2.5");
            Apple.setWeight(2.5);

            Console.WriteLine("Apple weight is " + Apple.getWeight());

            //price test
            Console.WriteLine("Apple price is " + Apple.getPrice());

            Console.WriteLine("Setting apple price to 3.00");
            Apple.setPrice(3.00);

            Console.WriteLine("Apple price is " + Apple.getPrice());

            //brand test
            Console.WriteLine("Apple brand is " + Apple.getBrand());

            Console.WriteLine("Setting apple brand to Lopes");
            Apple.setBrand("Lopes");

            Console.WriteLine("Apple brand is " + Apple.getBrand());

            //stock test
            Console.WriteLine("Apple stock is " + Apple.getStock());

            Console.WriteLine("Setting apple stock to 300");
            Apple.setStock(300);

            Console.WriteLine("Apple stock is " + Apple.getStock());
        }
    }
}
