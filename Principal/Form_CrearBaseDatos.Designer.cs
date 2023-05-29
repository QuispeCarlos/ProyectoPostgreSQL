namespace Principal
{
    partial class Form_CrearBaseDatos
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
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.textBox_nombreBaseDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(349, 138);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(114, 32);
            this.button_cancelar.TabIndex = 7;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(205, 138);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(114, 32);
            this.button_crear.TabIndex = 6;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // textBox_nombreBaseDatos
            // 
            this.textBox_nombreBaseDatos.Location = new System.Drawing.Point(296, 52);
            this.textBox_nombreBaseDatos.Name = "textBox_nombreBaseDatos";
            this.textBox_nombreBaseDatos.Size = new System.Drawing.Size(167, 22);
            this.textBox_nombreBaseDatos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // Form_CrearBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 254);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_crear);
            this.Controls.Add(this.textBox_nombreBaseDatos);
            this.Controls.Add(this.label1);
            this.Name = "Form_CrearBaseDatos";
            this.Text = "Form_CrearBaseDatos";
            this.Load += new System.EventHandler(this.Form_CrearBaseDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.TextBox textBox_nombreBaseDatos;
        private System.Windows.Forms.Label label1;
    }
}