using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia01
{
    internal class Avion : Vehiculo
    {
        public void Aterrizar() 
        {
            Console.WriteLine("Aterrizando...");
        
        }

        public void Despega()
        {
            Console.WriteLine("Despegando...");


        }

        public override void conducir()
        {
            //base.conducir();
            Console.WriteLine("Surcando los cielos ");

        }
    }
}
