namespace Principal
{
    partial class Form_CrearUsuarios
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
            this.tabControl_creacionUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage_general = new System.Windows.Forms.TabPage();
            this.tabPage_privilegios = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_contrasenia = new System.Windows.Forms.TextBox();
            this.checkBox_logueo = new System.Windows.Forms.CheckBox();
            this.checkBox_superusuario = new System.Windows.Forms.CheckBox();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl_creacionUsuarios.SuspendLayout();
            this.tabPage_general.SuspendLayout();
            this.tabPage_privilegios.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_guardar);
            this.groupBox1.Controls.Add(this.button_cerrar);
            this.groupBox1.Controls.Add(this.tabControl_creacionUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(35, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creación - Login/Group Role";
            // 
            // tabControl_creacionUsuarios
            // 
            this.tabControl_creacionUsuarios.Controls.Add(this.tabPage_general);
            this.tabControl_creacionUsuarios.Controls.Add(this.tabPage_privilegios);
            this.tabControl_creacionUsuarios.Location = new System.Drawing.Point(29, 42);
            this.tabControl_creacionUsuarios.Name = "tabControl_creacionUsuarios";
            this.tabControl_creacionUsuarios.SelectedIndex = 0;
            this.tabControl_creacionUsuarios.Size = new System.Drawing.Size(692, 305);
            this.tabControl_creacionUsuarios.TabIndex = 0;
            // 
            // tabPage_general
            // 
            this.tabPage_general.Controls.Add(this.textBox_contrasenia);
            this.tabPage_general.Controls.Add(this.label3);
            this.tabPage_general.Controls.Add(this.textBox_nombre);
            this.tabPage_general.Controls.Add(this.label1);
            this.tabPage_general.Location = new System.Drawing.Point(4, 25);
            this.tabPage_general.Name = "tabPage_general";
            this.tabPage_general.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_general.Size = new System.Drawing.Size(684, 276);
            this.tabPage_general.TabIndex = 0;
            this.tabPage_general.Text = "General";
            this.tabPage_general.UseVisualStyleBackColor = true;
            // 
            // tabPage_privilegios
            // 
            this.tabPage_privilegios.Controls.Add(this.checkBox_superusuario);
            this.tabPage_privilegios.Controls.Add(this.checkBox_logueo);
            this.tabPage_privilegios.Location = new System.Drawing.Point(4, 25);
            this.tabPage_privilegios.Name = "tabPage_privilegios";
            this.tabPage_privilegios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_privilegios.Size = new System.Drawing.Size(684, 276);
            this.tabPage_privilegios.TabIndex = 2;
            this.tabPage_privilegios.Text = "Privilegios";
            this.tabPage_privilegios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(189, 35);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(265, 22);
            this.textBox_nombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // textBox_contrasenia
            // 
            this.textBox_contrasenia.Location = new System.Drawing.Point(189, 107);
            this.textBox_contrasenia.Name = "textBox_contrasenia";
            this.textBox_contrasenia.Size = new System.Drawing.Size(265, 22);
            this.textBox_contrasenia.TabIndex = 5;
            // 
            // checkBox_logueo
            // 
            this.checkBox_logueo.AutoSize = true;
            this.checkBox_logueo.Location = new System.Drawing.Point(220, 41);
            this.checkBox_logueo.Name = "checkBox_logueo";
            this.checkBox_logueo.Size = new System.Drawing.Size(144, 20);
            this.checkBox_logueo.TabIndex = 2;
            this.checkBox_logueo.Text = "Puede Loguearse?";
            this.checkBox_logueo.UseVisualStyleBackColor = true;
            // 
            // checkBox_superusuario
            // 
            this.checkBox_superusuario.AutoSize = true;
            this.checkBox_superusuario.Location = new System.Drawing.Point(220, 94);
            this.checkBox_superusuario.Name = "checkBox_superusuario";
            this.checkBox_superusuario.Size = new System.Drawing.Size(122, 20);
            this.checkBox_superusuario.TabIndex = 3;
            this.checkBox_superusuario.Text = "Super Usuario?";
            this.checkBox_superusuario.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(502, 380);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(79, 28);
            this.button_cerrar.TabIndex = 1;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(620, 380);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(79, 28);
            this.button_guardar.TabIndex = 2;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // Form_CrearUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_CrearUsuarios";
            this.Text = "Form_CrearUsuarios";
            this.Load += new System.EventHandler(this.Form_CrearUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl_creacionUsuarios.ResumeLayout(false);
            this.tabPage_general.ResumeLayout(false);
            this.tabPage_general.PerformLayout();
            this.tabPage_privilegios.ResumeLayout(false);
            this.tabPage_privilegios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl_creacionUsuarios;
        private System.Windows.Forms.TabPage tabPage_general;
        private System.Windows.Forms.TabPage tabPage_privilegios;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_contrasenia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_superusuario;
        private System.Windows.Forms.CheckBox checkBox_logueo;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cerrar;
    }
}