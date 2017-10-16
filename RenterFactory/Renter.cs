using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenterFactory
{
    static class Renter
    {
        public static ICar Rent(double budget)
        {
            if(budget <= 80)
            {
                return new Toyota();
            }else if(budget > 80 && budget < 150)
            {
                return new Catorcio();
            }
            else
            {
                return new Mercedes();
            }
        }
    }
}
