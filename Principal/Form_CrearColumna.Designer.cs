namespace Principal
{
    partial class Form_CrearColumna
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
            this.groupBox_columnas = new System.Windows.Forms.GroupBox();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.comboBox_columnas = new System.Windows.Forms.ComboBox();
            this.groupBox_DB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tablas = new System.Windows.Forms.ComboBox();
            this.groupBox_campos = new System.Windows.Forms.GroupBox();
            this.checkBox_PrimaryKey = new System.Windows.Forms.CheckBox();
            this.checkBox_notNull = new System.Windows.Forms.CheckBox();
            this.comboBox_tipoDato = new System.Windows.Forms.ComboBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.groupBox_columnas.SuspendLayout();
            this.groupBox_DB.SuspendLayout();
            this.groupBox_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_columnas
            // 
            this.groupBox_columnas.Controls.Add(this.button_eliminar);
            this.groupBox_columnas.Controls.Add(this.comboBox_columnas);
            this.groupBox_columnas.Location = new System.Drawing.Point(300, 12);
            this.groupBox_columnas.Name = "groupBox_columnas";
            this.groupBox_columnas.Size = new System.Drawing.Size(393, 280);
            this.groupBox_columnas.TabIndex = 9;
            this.groupBox_columnas.TabStop = false;
            this.groupBox_columnas.Text = "Columnas Creadas";
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(246, 33);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(113, 33);
            this.button_eliminar.TabIndex = 1;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            // 
            // comboBox_columnas
            // 
            this.comboBox_columnas.FormattingEnabled = true;
            this.comboBox_columnas.Location = new System.Drawing.Point(20, 33);
            this.comboBox_columnas.Name = "comboBox_columnas";
            this.comboBox_columnas.Size = new System.Drawing.Size(161, 24);
            this.comboBox_columnas.TabIndex = 0;
            // 
            // groupBox_DB
            // 
            this.groupBox_DB.Controls.Add(this.label1);
            this.groupBox_DB.Controls.Add(this.comboBox_tablas);
            this.groupBox_DB.Location = new System.Drawing.Point(12, 12);
            this.groupBox_DB.Name = "groupBox_DB";
            this.groupBox_DB.Size = new System.Drawing.Size(261, 280);
            this.groupBox_DB.TabIndex = 8;
            this.groupBox_DB.TabStop = false;
            this.groupBox_DB.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la tabla:";
            // 
            // comboBox_tablas
            // 
            this.comboBox_tablas.FormattingEnabled = true;
            this.comboBox_tablas.Location = new System.Drawing.Point(18, 69);
            this.comboBox_tablas.Name = "comboBox_tablas";
            this.comboBox_tablas.Size = new System.Drawing.Size(212, 24);
            this.comboBox_tablas.TabIndex = 2;
            // 
            // groupBox_campos
            // 
            this.groupBox_campos.Controls.Add(this.checkBox_PrimaryKey);
            this.groupBox_campos.Controls.Add(this.checkBox_notNull);
            this.groupBox_campos.Controls.Add(this.comboBox_tipoDato);
            this.groupBox_campos.Controls.Add(this.textBox_nombre);
            this.groupBox_campos.Controls.Add(this.label6);
            this.groupBox_campos.Controls.Add(this.label5);
            this.groupBox_campos.Controls.Add(this.label4);
            this.groupBox_campos.Controls.Add(this.label3);
            this.groupBox_campos.Controls.Add(this.button_cancelar);
            this.groupBox_campos.Controls.Add(this.button_crear);
            this.groupBox_campos.Location = new System.Drawing.Point(30, 298);
            this.groupBox_campos.Name = "groupBox_campos";
            this.groupBox_campos.Size = new System.Drawing.Size(814, 209);
            this.groupBox_campos.TabIndex = 10;
            this.groupBox_campos.TabStop = false;
            this.groupBox_campos.Text = "Campos";
            // 
            // checkBox_PrimaryKey
            // 
            this.checkBox_PrimaryKey.AutoSize = true;
            this.checkBox_PrimaryKey.Location = new System.Drawing.Point(698, 72);
            this.checkBox_PrimaryKey.Name = "checkBox_PrimaryKey";
            this.checkBox_PrimaryKey.Size = new System.Drawing.Size(18, 17);
            this.checkBox_PrimaryKey.TabIndex = 13;
            this.checkBox_PrimaryKey.UseVisualStyleBackColor = true;
            // 
            // checkBox_notNull
            // 
            this.checkBox_notNull.AutoSize = true;
            this.checkBox_notNull.Location = new System.Drawing.Point(551, 72);
            this.checkBox_notNull.Name = "checkBox_notNull";
            this.checkBox_notNull.Size = new System.Drawing.Size(18, 17);
            this.checkBox_notNull.TabIndex = 12;
            this.checkBox_notNull.UseVisualStyleBackColor = true;
            // 
            // comboBox_tipoDato
            // 
            this.comboBox_tipoDato.FormattingEnabled = true;
            this.comboBox_tipoDato.Items.AddRange(new object[] {
            "\"BOOLEAN\"",
            "\"CHAR\"",
            "\"DATE\"",
            "\"DECIMAL\"",
            "\"INTEGER\"",
            "\"VARCHAR(10)\"",
            "\"VARCHAR(30)\""});
            this.comboBox_tipoDato.Location = new System.Drawing.Point(251, 65);
            this.comboBox_tipoDato.Name = "comboBox_tipoDato";
            this.comboBox_tipoDato.Size = new System.Drawing.Size(203, 24);
            this.comboBox_tipoDato.TabIndex = 11;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(32, 65);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(169, 22);
            this.textBox_nombre.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Primary key?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Not Null?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(686, 162);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(110, 32);
            this.button_cancelar.TabIndex = 5;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(577, 162);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(103, 32);
            this.button_crear.TabIndex = 4;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            // 
            // Form_CrearColumna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 530);
            this.Controls.Add(this.groupBox_campos);
            this.Controls.Add(this.groupBox_columnas);
            this.Controls.Add(this.groupBox_DB);
            this.Name = "Form_CrearColumna";
            this.Text = "Form_CrearColumna";
            this.Load += new System.EventHandler(this.Form_CrearColumna_Load);
            this.groupBox_columnas.ResumeLayout(false);
            this.groupBox_DB.ResumeLayout(false);
            this.groupBox_DB.PerformLayout();
            this.groupBox_campos.ResumeLayout(false);
            this.groupBox_campos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_columnas;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.ComboBox comboBox_columnas;
        private System.Windows.Forms.GroupBox groupBox_DB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tablas;
        private System.Windows.Forms.GroupBox groupBox_campos;
        private System.Windows.Forms.CheckBox checkBox_PrimaryKey;
        private System.Windows.Forms.CheckBox checkBox_notNull;
        private System.Windows.Forms.ComboBox comboBox_tipoDato;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_crear;
    }
}