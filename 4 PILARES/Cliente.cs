using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PILARES
{
    public abstract class Cliente : ICliente
    {
        public string Nombre { get; set; }

        public abstract double ObtenerDescuento(double precio);
    }

    public class ClienteNormal : Cliente
    {
        public override double ObtenerDescuento(double precio)
        {
            return precio; // Sin descuento
        }
    }

    public class ClientePremium : Cliente
    {
        public override double ObtenerDescuento(double precio)
        {
            return precio * 0.9; // 10% de descuento
        }
    }

    public class ClienteVIP : Cliente
    {
        public override double ObtenerDescuento(double precio)
        {
            return precio * 0.8; // 20% de descuento
        }
    }

}
