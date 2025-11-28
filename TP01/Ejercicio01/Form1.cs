namespace Ejercicio01
{
    public partial class Form1 : Form
    {

        private Banco miBanco;

        public Form1()
        {
            InitializeComponent();

            miBanco = new Banco();

            cmbTipoCuenta.SelectedIndex = 0;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }


        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            
        }


        private void ActualizarListaClientes()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = miBanco.ObtenerClientes();
        }

        private void LimpiarCamposCliente()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDNI.Focus();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstClientes.SelectedItem == null) return;


            Cliente clienteSeleccionado = (Cliente)lstClientes.SelectedItem;

            lstCuentas.DataSource = null;
            lstCuentas.DataSource = miBanco.ObtenerCuentasPorCliente(clienteSeleccionado.DNI);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCuentas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una cuenta primero.");
                    return;
                }


                Cuenta cuentaSeleccionada = (Cuenta)lstCuentas.SelectedItem;
                decimal monto = decimal.Parse(txtMonto.Text);


                cuentaSeleccionada.Depositar(monto);


                ActualizarListaCuentas();
                MessageBox.Show("Depósito realizado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCuentas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una cuenta primero.");
                    return;
                }

                Cuenta cuentaSeleccionada = (Cuenta)lstCuentas.SelectedItem;
                decimal monto = decimal.Parse(txtMonto.Text);


                cuentaSeleccionada.Extraer(monto);

                ActualizarListaCuentas();
                MessageBox.Show("Extracción realizada con éxito.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo extraer: " + ex.Message);
            }
        }

        private void ActualizarListaCuentas()
        {

            int indiceGuardado = lstCuentas.SelectedIndex;

            lstCuentas.DataSource = null;
            if (lstClientes.SelectedItem != null)
            {
                Cliente cliente = (Cliente)lstClientes.SelectedItem;
                lstCuentas.DataSource = miBanco.ObtenerCuentasPorCliente(cliente.DNI);
            }


            if (indiceGuardado >= 0 && indiceGuardado < lstCuentas.Items.Count)
            {
                lstCuentas.SelectedIndex = indiceGuardado;
            }
        }

        private void btnAgregarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("Por favor complete DNI, Nombre y Apellido.");
                    return;
                }


                int dni = int.Parse(txtDNI.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                DateTime nacimiento = dtpFechaNacimiento.Value;


                Cliente nuevoCliente = new Cliente(dni, nombre, apellido, nacimiento);
                nuevoCliente.Telefono = telefono;
                nuevoCliente.Email = email;


                miBanco.AgregarCliente(nuevoCliente);


                ActualizarListaClientes();
                LimpiarCamposCliente();

                MessageBox.Show("Cliente registrado correctamente.");
            }
            catch (FormatException)
            {
                MessageBox.Show("El DNI debe ser un número válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearCuenta_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (lstClientes.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un cliente de la lista para asignarle la cuenta.");
                    return;
                }


                Cliente titular = (Cliente)lstClientes.SelectedItem;


                int codigo = int.Parse(txtCodigoCuenta.Text);
                decimal limite = decimal.Parse(txtLimite.Text);
                string tipo = cmbTipoCuenta.SelectedItem.ToString();


                Cuenta nuevaCuenta;

                if (tipo == "Caja Ahorro")
                {

                    nuevaCuenta = new CajaAhorro(codigo, titular, limite);
                }
                else
                {

                    nuevaCuenta = new CuentaCorriente(codigo, titular, limite);
                }


                miBanco.AgregarCuenta(nuevaCuenta);

                MessageBox.Show($"Cuenta {tipo} creada para {titular.Nombre} {titular.Apellido}.");
                txtCodigoCuenta.Clear();
                txtLimite.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("El código y el límite deben ser números.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

}
