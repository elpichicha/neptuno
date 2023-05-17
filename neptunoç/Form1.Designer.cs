namespace neptunoç
{
    partial class txtUsername
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.UsuarioLBL = new System.Windows.Forms.Label();
            this.ContraseñaLBL = new System.Windows.Forms.Label();
            this.MRCdatos = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compañia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provedore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRCdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(110, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // UsuarioLBL
            // 
            this.UsuarioLBL.AutoSize = true;
            this.UsuarioLBL.Location = new System.Drawing.Point(10, 16);
            this.UsuarioLBL.Name = "UsuarioLBL";
            this.UsuarioLBL.Size = new System.Drawing.Size(43, 13);
            this.UsuarioLBL.TabIndex = 2;
            this.UsuarioLBL.Text = "Usuario";
            // 
            // ContraseñaLBL
            // 
            this.ContraseñaLBL.AutoSize = true;
            this.ContraseñaLBL.Location = new System.Drawing.Point(10, 56);
            this.ContraseñaLBL.Name = "ContraseñaLBL";
            this.ContraseñaLBL.Size = new System.Drawing.Size(61, 13);
            this.ContraseñaLBL.TabIndex = 3;
            this.ContraseñaLBL.Text = "Contraseña";
            // 
            // MRCdatos
            // 
            this.MRCdatos.Controls.Add(this.ContraseñaLBL);
            this.MRCdatos.Controls.Add(this.UsuarioLBL);
            this.MRCdatos.Controls.Add(this.txtPassword);
            this.MRCdatos.Controls.Add(this.textBox1);
            this.MRCdatos.Location = new System.Drawing.Point(16, 14);
            this.MRCdatos.Name = "MRCdatos";
            this.MRCdatos.Size = new System.Drawing.Size(253, 86);
            this.MRCdatos.TabIndex = 4;
            this.MRCdatos.TabStop = false;
            this.MRCdatos.Enter += new System.EventHandler(this.MRCdatos_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clientes,
            this.Compañia,
            this.Detalles,
            this.Empleados,
            this.pedidos,
            this.Provedore});
            this.dataGridView1.Location = new System.Drawing.Point(16, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(302, 77);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Clientes
            // 
            this.Clientes.HeaderText = "Clientes";
            this.Clientes.Name = "Clientes";
            // 
            // Compañia
            // 
            this.Compañia.HeaderText = "Compañia";
            this.Compañia.Name = "Compañia";
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Nombre de cotacto";
            this.Detalles.Name = "Detalles";
            // 
            // Empleados
            // 
            this.Empleados.HeaderText = "Empleados";
            this.Empleados.Name = "Empleados";
            // 
            // pedidos
            // 
            this.pedidos.HeaderText = "Pedidos";
            this.pedidos.Name = "pedidos";
            // 
            // Provedore
            // 
            this.Provedore.HeaderText = "Provedores";
            this.Provedore.Name = "Provedore";
            // 
            // txtUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MRCdatos);
            this.Name = "txtUsername";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MRCdatos.ResumeLayout(false);
            this.MRCdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label UsuarioLBL;
        private System.Windows.Forms.Label ContraseñaLBL;
        private System.Windows.Forms.GroupBox MRCdatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compañia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provedore;
    }
}

