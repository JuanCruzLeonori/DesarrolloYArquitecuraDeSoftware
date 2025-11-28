using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class CajaAhorro : Cuenta
    {
        public decimal LimiteExtraccion { get; set; }

        public CajaAhorro(int codigo, Cliente titular, decimal limiteExtraccion)
            : base(codigo, titular)
        {
            LimiteExtraccion = limiteExtraccion;
        }

        public override void Extraer(decimal monto)
        {
            if (monto > LimiteExtraccion)
                throw new Exception("El monto supera el límite permitido por extracción.");

            if (Saldo < monto)
                throw new Exception("Saldo insuficiente.");

            Saldo -= monto;
            Historial.Add(new Operacion(TipoOperacion.Extraccion, monto));
        }
    }
}
