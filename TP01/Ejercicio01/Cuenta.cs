using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public abstract class Cuenta
    {
        public int Codigo { get; set; }
        public decimal Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public List<Operacion> Historial { get; private set; }

        public Cuenta(int codigo, Cliente titular)
        {
            Codigo = codigo;
            Titular = titular;
            Saldo = 0;
            Historial = new List<Operacion>();
        }

        public void Depositar(decimal monto)
        {
            if (monto <= 0) throw new Exception("El monto debe ser positivo.");

            Saldo += monto;
            Historial.Add(new Operacion(TipoOperacion.Deposito, monto));
        }

        
        public abstract void Extraer(decimal monto);

        public override string ToString()
        {
            
            return $"Cta: {Codigo} | Saldo: ${Saldo}";
        }
    }
}
