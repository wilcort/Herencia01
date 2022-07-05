using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia01
{
    internal class Coche : Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");

        }

        public void Frenar()
        {
            Console.WriteLine("Frenando...");


        }

        public override void conducir()
        {
            //base.conducir();
            Console.WriteLine("Manejando por carretera ");

        }


    }
}
