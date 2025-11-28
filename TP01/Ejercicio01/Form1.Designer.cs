namespace Ejercicio01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnAgregarCliente = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCrearCuenta = new Button();
            cmbTipoCuenta = new ComboBox();
            txtCodigoCuenta = new TextBox();
            txtLimite = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lstClientes = new ListBox();
            label10 = new Label();
            label11 = new Label();
            lstCuentas = new ListBox();
            groupBox3 = new GroupBox();
            label12 = new Label();
            txtMonto = new TextBox();
            btnDepositar = new Button();
            btnExtraer = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarCliente);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(86, 243);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(128, 23);
            btnAgregarCliente.TabIndex = 13;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click_1;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(109, 187);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(63, 118);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(132, 23);
            txtTelefono.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(48, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(63, 84);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(132, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(63, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(132, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(39, 22);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(127, 23);
            txtDNI.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 193);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 155);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 121);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCrearCuenta);
            groupBox2.Controls.Add(cmbTipoCuenta);
            groupBox2.Controls.Add(txtCodigoCuenta);
            groupBox2.Controls.Add(txtLimite);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(18, 334);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(214, 186);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nueva Cuenta";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(39, 146);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(128, 23);
            btnCrearCuenta.TabIndex = 7;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click_1;
            // 
            // cmbTipoCuenta
            // 
            cmbTipoCuenta.FormattingEnabled = true;
            cmbTipoCuenta.Items.AddRange(new object[] { "Caja Ahorro", "Cuenta Corriente" });
            cmbTipoCuenta.Location = new Point(43, 63);
            cmbTipoCuenta.Name = "cmbTipoCuenta";
            cmbTipoCuenta.Size = new Size(152, 23);
            cmbTipoCuenta.TabIndex = 6;
            // 
            // txtCodigoCuenta
            // 
            txtCodigoCuenta.Location = new Point(99, 27);
            txtCodigoCuenta.Name = "txtCodigoCuenta";
            txtCodigoCuenta.Size = new Size(115, 23);
            txtCodigoCuenta.TabIndex = 2;
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(99, 100);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(115, 23);
            txtLimite.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 30);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 2;
            label7.Text = "Código Cuenta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 66);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 3;
            label8.Text = "Tipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 103);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 4;
            label9.Text = "Límite/Tope ($)";
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(458, 51);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(274, 469);
            lstClientes.TabIndex = 2;
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(458, 33);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 3;
            label10.Text = "Lista de Clientes";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(738, 33);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 4;
            label11.Text = "Lista de Cuentas";
            // 
            // lstCuentas
            // 
            lstCuentas.FormattingEnabled = true;
            lstCuentas.ItemHeight = 15;
            lstCuentas.Location = new Point(738, 51);
            lstCuentas.Name = "lstCuentas";
            lstCuentas.Size = new Size(258, 469);
            lstCuentas.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtMonto);
            groupBox3.Controls.Add(btnDepositar);
            groupBox3.Controls.Add(btnExtraer);
            groupBox3.Location = new Point(238, 334);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(214, 186);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Operaciones";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 84);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 7;
            label12.Text = "Monto ($)";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(80, 76);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 8;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(14, 146);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(84, 23);
            btnDepositar.TabIndex = 9;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnExtraer
            // 
            btnExtraer.Location = new Point(104, 146);
            btnExtraer.Name = "btnExtraer";
            btnExtraer.Size = new Size(88, 23);
            btnExtraer.TabIndex = 10;
            btnExtraer.Text = "Extraer";
            btnExtraer.UseVisualStyleBackColor = true;
            btnExtraer.Click += btnExtraer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 600);
            Controls.Add(groupBox3);
            Controls.Add(lstCuentas);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(lstClientes);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnAgregarCliente;
        private GroupBox groupBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnCrearCuenta;
        private ComboBox cmbTipoCuenta;
        private TextBox txtCodigoCuenta;
        private TextBox txtLimite;
        private ListBox lstClientes;
        private Label label10;
        private Label label11;
        private ListBox lstCuentas;
        private GroupBox groupBox3;
        private Label label12;
        private TextBox txtMonto;
        private Button btnDepositar;
        private Button btnExtraer;
    }
}
