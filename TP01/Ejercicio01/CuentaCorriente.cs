using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class CuentaCorriente : Cuenta
    {
        public decimal TopeDescubierto { get; set; } 

        public CuentaCorriente(int codigo, Cliente titular, decimal topeDescubierto)
            : base(codigo, titular)
        {
            TopeDescubierto = topeDescubierto;
        }

        public override void Extraer(decimal monto)
        {
            
            if ((Saldo - monto) < -TopeDescubierto)
                throw new Exception("La extracción supera el límite de descubierto permitido.");

            Saldo -= monto;
            Historial.Add(new Operacion(TipoOperacion.Extraccion, monto));
        }
    }
}
