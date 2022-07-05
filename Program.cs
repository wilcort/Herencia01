using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Probando el avion");


            Avion miAvion = new Avion();

            miAvion.ArrancaMotor(" shshhshshshsh");
            miAvion.Despega();
            miAvion.conducir();
            miAvion.PararMotor("bolf blof ");

            Console.WriteLine("**************");

            Console.WriteLine("Probando el coche");

            Coche miCoche = new Coche();

            miCoche.ArrancaMotor("blur blur blur");
            miCoche.conducir();
            miCoche.Frenar();
            miCoche.PararMotor("stop stop ");

            Console.WriteLine("++++++++++++++++++");

            Console.WriteLine("POLIMORFISMO");

            Vehiculo miVehiculo = miCoche;

            miVehiculo.conducir();

            miVehiculo = miAvion;

            miVehiculo.conducir();

            

        }
    }
}
