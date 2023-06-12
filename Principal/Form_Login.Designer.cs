namespace Principal
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_ingresar = new System.Windows.Forms.Button();
            this.textBox_contrasenia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_puerto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_uasuario = new System.Windows.Forms.TextBox();
            this.textBox_baseDatos = new System.Windows.Forms.TextBox();
            this.textBox_servidor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_conexiones = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_conexiones);
            this.groupBox1.Controls.Add(this.button_cancelar);
            this.groupBox1.Controls.Add(this.button_ingresar);
            this.groupBox1.Controls.Add(this.textBox_contrasenia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_puerto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_uasuario);
            this.groupBox1.Controls.Add(this.textBox_baseDatos);
            this.groupBox1.Controls.Add(this.textBox_servidor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(114, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio de Sesión";
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(218, 307);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(136, 37);
            this.button_cancelar.TabIndex = 11;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_ingresar
            // 
            this.button_ingresar.Location = new System.Drawing.Point(59, 307);
            this.button_ingresar.Name = "button_ingresar";
            this.button_ingresar.Size = new System.Drawing.Size(136, 37);
            this.button_ingresar.TabIndex = 10;
            this.button_ingresar.Text = "Ingresar";
            this.button_ingresar.UseVisualStyleBackColor = true;
            this.button_ingresar.Click += new System.EventHandler(this.button_ingresar_Click);
            // 
            // textBox_contrasenia
            // 
            this.textBox_contrasenia.Location = new System.Drawing.Point(259, 249);
            this.textBox_contrasenia.Name = "textBox_contrasenia";
            this.textBox_contrasenia.PasswordChar = '*';
            this.textBox_contrasenia.Size = new System.Drawing.Size(139, 22);
            this.textBox_contrasenia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña: ";
            // 
            // textBox_puerto
            // 
            this.textBox_puerto.Location = new System.Drawing.Point(259, 205);
            this.textBox_puerto.Name = "textBox_puerto";
            this.textBox_puerto.Size = new System.Drawing.Size(139, 22);
            this.textBox_puerto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puerto: ";
            // 
            // textBox_uasuario
            // 
            this.textBox_uasuario.Location = new System.Drawing.Point(259, 160);
            this.textBox_uasuario.Name = "textBox_uasuario";
            this.textBox_uasuario.Size = new System.Drawing.Size(139, 22);
            this.textBox_uasuario.TabIndex = 5;
            // 
            // textBox_baseDatos
            // 
            this.textBox_baseDatos.Location = new System.Drawing.Point(259, 118);
            this.textBox_baseDatos.Name = "textBox_baseDatos";
            this.textBox_baseDatos.Size = new System.Drawing.Size(139, 22);
            this.textBox_baseDatos.TabIndex = 4;
            // 
            // textBox_servidor
            // 
            this.textBox_servidor.Location = new System.Drawing.Point(259, 68);
            this.textBox_servidor.Name = "textBox_servidor";
            this.textBox_servidor.Size = new System.Drawing.Size(139, 22);
            this.textBox_servidor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base de Datos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor:";
            // 
            // button_conexiones
            // 
            this.button_conexiones.Location = new System.Drawing.Point(375, 307);
            this.button_conexiones.Name = "button_conexiones";
            this.button_conexiones.Size = new System.Drawing.Size(136, 37);
            this.button_conexiones.TabIndex = 12;
            this.button_conexiones.Text = "Conexiones";
            this.button_conexiones.UseVisualStyleBackColor = true;
            this.button_conexiones.Click += new System.EventHandler(this.button_conexiones_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 474);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_ingresar;
        private System.Windows.Forms.TextBox textBox_contrasenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_puerto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_uasuario;
        private System.Windows.Forms.TextBox textBox_baseDatos;
        private System.Windows.Forms.TextBox textBox_servidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_conexiones;
    }
}