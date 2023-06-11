using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals2
{
    public class Program
    {
        const int COST_PER_PIZZA = 200;
        const int COST_PER_PUFF = 40;
        const int COST_PER_PEPSI = 120;
        public static int Calculate (int pepsiCount, int puffCount, int pizzaCount) 
        {
            return pizza_cost(pizzaCount)+puff_cost(puffCount)+pepsi_cost(pepsiCount);
        }
        public static int pizza_cost (int count) => count*COST_PER_PIZZA;
        public static int puff_cost (int count) => count*COST_PER_PUFF;
        public static int pepsi_cost (int count) => count*COST_PER_PEPSI;
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of pizzas bought :"); 
            var pizzaCount = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter the number of puffs bought :"); 
            var puffCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of pepsi bought :"); 
            var pepsiCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bill Details"); 
            Console.WriteLine();

            Console.WriteLine($"Cost of Pizzas :{pizza_cost (pizzaCount)}"); 
            Console.WriteLine($"Cost of Puffs : {puff_cost (puffCount)}"); 
            Console.WriteLine($"Cost of Pepsis : {pepsi_cost (pepsiCount)}");

            var total = Calculate(pepsiCount, puffCount, pizzaCount);

            Console.WriteLine($"GST 12% : {0.12 * (float) total}");
            Console.WriteLine($"CESS 5% : {0.05 *(float) total}");

            Console.WriteLine($"Total Price: {total}");
        }
    }
}