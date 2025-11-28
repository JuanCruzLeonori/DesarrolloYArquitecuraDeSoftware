using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{

    public enum TipoOperacion
    {
        Deposito,
        Extraccion
    }
    public class Operacion
    {
        public DateTime Fecha { get; private set; }
        public TipoOperacion Tipo { get; private set; }
        public decimal Monto { get; private set; }

        public Operacion(TipoOperacion tipo, decimal monto)
        {
            Fecha = DateTime.Now;
            Tipo = tipo;
            Monto = monto;
        }
    }
}
