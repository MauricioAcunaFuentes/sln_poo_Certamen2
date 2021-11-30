namespace WindowsFormsEmpleado
{
    partial class Form1
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
            this.bt_agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_rut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(62, 221);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 23);
            this.bt_agregar.TabIndex = 17;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefono";
            // 
            // tx_telefono
            // 
            this.tx_telefono.Location = new System.Drawing.Point(62, 174);
            this.tx_telefono.Name = "tx_telefono";
            this.tx_telefono.Size = new System.Drawing.Size(131, 20);
            this.tx_telefono.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido";
            // 
            // tx_apellido
            // 
            this.tx_apellido.Location = new System.Drawing.Point(62, 88);
            this.tx_apellido.Name = "tx_apellido";
            this.tx_apellido.Size = new System.Drawing.Size(227, 20);
            this.tx_apellido.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(62, 53);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(227, 20);
            this.tx_nombre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rut";
            // 
            // tx_rut
            // 
            this.tx_rut.Location = new System.Drawing.Point(62, 23);
            this.tx_rut.Name = "tx_rut";
            this.tx_rut.Size = new System.Drawing.Size(131, 20);
            this.tx_rut.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email";
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(62, 129);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(227, 20);
            this.tx_email.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 270);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_rut);
            this.Name = "Form1";
            this.Text = "Mantenedor Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_rut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_email;
    }
}

