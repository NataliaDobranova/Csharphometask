using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorbike m = new Motorbike();
            m.Hello();
            m.Sell_bike();

            Console.WriteLine("I spent in travel " + m.Travel_time(100.7f) + " hours.\n");

            Motorbike m1 = new Motorbike(ModelEnum.Yamaha);

            if (m.CompareModels(m1))
                Console.WriteLine("Bikes are the same.\n");
            else
                Console.WriteLine("Bike models are different.\n");

            Console.WriteLine("Amount of wheels: " + Motorbike.amount_of_wheels);
            Console.WriteLine("Motorbikes are registrated in: " + Motorbike.country_of_regisration);

            Motorbike[] collection = new Motorbike[5];
            collection[0] = m;
            collection[1] = m1;
            collection[2] = new Motorbike(ModelEnum.ACXA, 6789.6f);
            collection[3] = new Motorbike(ModelEnum.ZONDER, 6789.6f, 18.7f);
            collection[4] = new Motorbike(ModelEnum.Yamaha, 6789.6f, 18.7f, 215, 55);

            Console.WriteLine("\nThis is my collection:");
            foreach (Motorbike bike in collection)
            {
                Console.WriteLine(bike.GetModel());
            }
        }
    }
}
