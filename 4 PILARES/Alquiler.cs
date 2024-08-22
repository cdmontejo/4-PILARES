using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PILARES
{
    public class Alquiler
    {
        public IAnimal Animal { get; set; }
        public ICliente Cliente { get; set; }
        public int Dias { get; set; }

        public Alquiler(IAnimal animal, ICliente cliente, int dias)
        {
            Animal = animal;
            Cliente = cliente;
            Dias = dias;
        }

        public double CalcularCosto()
        {
            double precioTotal = Animal.PrecioDiario * Dias;
            return Cliente.ObtenerDescuento(precioTotal);
        }
    }

}
