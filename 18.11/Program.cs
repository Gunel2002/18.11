using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone apple = new Phone();
            apple.manufacturer = "Apple";
            apple.model = "IPhone 13";
            apple.screenSize = 5.8;

            Phone samsung = new Phone();
            samsung.manufacturer = "Samsung";
            samsung.model = "Galaxy S21";
            samsung.screenSize = 6.5;

            Console.WriteLine("Смартфон: " + apple.manufacturer + " " + apple.model);
            apple.unlockScreen();
            Console.WriteLine("Смартфон: " + samsung.manufacturer + " " + samsung.model);
            samsung.blockScreen();

            Console.ReadKey();
        }
    }
}
