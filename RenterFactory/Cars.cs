using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenterFactory
{
    interface ICar
    {
        string Model { get; }
    }

    class Mercedes : ICar
    {
        public string Model => "Mercedes SL 350";
    }
    class Toyota : ICar
    {
        public string Model => "Toyota Yaris";
    }
    class BMW : ICar
    {
        private string targa;
        public string Model => "BMW Serie 3 Touring";
        public BMW(string targa)
        {
            this.targa = targa;
        }
    }
    class Catorcio : ICar
    {
        public string Model => "Sono un catorcio.";
    }
}
