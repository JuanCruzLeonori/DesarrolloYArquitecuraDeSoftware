using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class Banco
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Cuenta> cuentas = new List<Cuenta>();

        
        public void AgregarCliente(Cliente nuevoCliente)
        {
            
            if (clientes.Any(c => c.DNI == nuevoCliente.DNI))
            {
                throw new Exception("Ya existe un cliente con ese DNI.");
            }
            clientes.Add(nuevoCliente);
        }

        public void ModificarCliente(Cliente clienteModificado)
        {
            var clienteExistente = BuscarCliente(clienteModificado.DNI);
            if (clienteExistente != null)
            {
                clienteExistente.Nombre = clienteModificado.Nombre;
                clienteExistente.Apellido = clienteModificado.Apellido;
                clienteExistente.Email = clienteModificado.Email;
                clienteExistente.Telefono = clienteModificado.Telefono;
            }
        }

        
        public void EliminarCliente(int dni)
        {
            var cliente = BuscarCliente(dni);
            if (cliente == null) throw new Exception("Cliente no encontrado");

            
            if (cuentas.Any(c => c.Titular.DNI == dni))
                throw new Exception("No se puede eliminar: El cliente posee cuentas asignadas.");

            clientes.Remove(cliente);
        }

        public Cliente BuscarCliente(int dni)
        {
            return clientes.FirstOrDefault(c => c.DNI == dni);
        }

       
        public void AgregarCuenta(Cuenta nuevaCuenta)
        {
            if (cuentas.Any(c => c.Codigo == nuevaCuenta.Codigo))
                throw new Exception("Ya existe una cuenta con ese código.");

            cuentas.Add(nuevaCuenta);
        }

        
        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        public List<Cuenta> ObtenerCuentasPorCliente(int dniTitular)
        {
            
            return cuentas.Where(c => c.Titular.DNI == dniTitular).ToList();
        }
    }
}
