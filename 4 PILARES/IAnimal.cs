using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PILARES
{
    public interface IAnimal
    {
        string Nombre { get; set; }
        double PrecioDiario { get; }
        void MostrarDetalles();
    }

    public interface ICliente
    {
        string Nombre { get; set; }
        double ObtenerDescuento(double precio);
    }

}
