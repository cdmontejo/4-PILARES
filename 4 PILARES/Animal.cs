using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PILARES
{
    public abstract class Animal : IAnimal
    {
        public string Nombre { get; set; }
        public abstract double PrecioDiario { get; }

        public abstract void MostrarDetalles();
    }

    public class Burro : Animal
    {
        public override double PrecioDiario => 10;

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Burro: {Nombre}, Precio diario: {PrecioDiario}.");
        }
    }

    public class Caballo : Animal
    {
        public override double PrecioDiario => 25;

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Caballo: {Nombre}, Precio diario: {PrecioDiario}.");
        }
    }

    public class Llegua : Animal
    {
        public override double PrecioDiario => 20;

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Llegua: {Nombre}, Precio diario: {PrecioDiario}.");
        }
    }

    public class Alpaca : Animal
    {
        public override double PrecioDiario => 15;

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Alpaca: {Nombre}, Precio diario: {PrecioDiario}.");
        }
    }

}
