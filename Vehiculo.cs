using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia01
{
    internal class Vehiculo
    {
        public void ArrancaMotor(string sonidoArranque)
        {

            Console.WriteLine($"Arranca el Motor:   { sonidoArranque}");

        }

        public void PararMotor(string sonidoParar)
        {

            Console.WriteLine($"Parar el Motor:   { sonidoParar}");

        }

        public virtual void conducir() 
        {
            Console.WriteLine("Codigo generico para el metodo conducir ");

        }

    }
}
