using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenterFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = Renter.Rent(110);

            Console.WriteLine("Mi hanno dato una " + car.Model);
            Console.ReadKey();
        }
    }
}
