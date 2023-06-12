namespace Principal
{
    partial class Form_Permisos
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
            this.groupBox_permisos = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_baseDatos = new System.Windows.Forms.TabPage();
            this.button_guardarBase = new System.Windows.Forms.Button();
            this.button_cancelarBase = new System.Windows.Forms.Button();
            this.checkBox_baseConnect = new System.Windows.Forms.CheckBox();
            this.checkBox_baseTemporary = new System.Windows.Forms.CheckBox();
            this.checkBox_baseCreate = new System.Windows.Forms.CheckBox();
            this.checkBox_baseAll = new System.Windows.Forms.CheckBox();
            this.tabPage_esquema = new System.Windows.Forms.TabPage();
            this.button_esquemaGuardar = new System.Windows.Forms.Button();
            this.button_esquemaCancelar = new System.Windows.Forms.Button();
            this.checkBox_esquemaUsage = new System.Windows.Forms.CheckBox();
            this.checkBox_esquemaCreate = new System.Windows.Forms.CheckBox();
            this.checkBox_esquemaAll = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_tablaGuardar = new System.Windows.Forms.Button();
            this.button_tablaCancelar = new System.Windows.Forms.Button();
            this.checkBox_tablaTrigger = new System.Windows.Forms.CheckBox();
            this.checkBox_tablaReferences = new System.Windows.Forms.CheckBox();
            this.checkBox_tablaTruncate = new System.Windows.Forms.CheckBox();
            this.checkBox_tablaDelete = new System.Windows.Forms.CheckBox();
            this.checkBox_tablaUpdate = new System.Windows.Forms.CheckBox();
            this.checkBox_tablaSelect = new System.Windows.Forms.CheckBox();
            this.checkBox_tablaInsert = new System.Windows.Forms.CheckBox();
            this.checkBox_tablaAll = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_tabla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_base = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_usuario = new System.Windows.Forms.ComboBox();
            this.groupBox_permisos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_baseDatos.SuspendLayout();
            this.tabPage_esquema.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_permisos
            // 
            this.groupBox_permisos.Controls.Add(this.tabControl1);
            this.groupBox_permisos.Controls.Add(this.label1);
            this.groupBox_permisos.Controls.Add(this.comboBox_base);
            this.groupBox_permisos.Controls.Add(this.label2);
            this.groupBox_permisos.Controls.Add(this.comboBox_usuario);
            this.groupBox_permisos.Location = new System.Drawing.Point(23, 31);
            this.groupBox_permisos.Name = "groupBox_permisos";
            this.groupBox_permisos.Size = new System.Drawing.Size(796, 514);
            this.groupBox_permisos.TabIndex = 0;
            this.groupBox_permisos.TabStop = false;
            this.groupBox_permisos.Text = "Permisos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_baseDatos);
            this.tabControl1.Controls.Add(this.tabPage_esquema);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(41, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_baseDatos
            // 
            this.tabPage_baseDatos.Controls.Add(this.button_guardarBase);
            this.tabPage_baseDatos.Controls.Add(this.button_cancelarBase);
            this.tabPage_baseDatos.Controls.Add(this.checkBox_baseConnect);
            this.tabPage_baseDatos.Controls.Add(this.checkBox_baseTemporary);
            this.tabPage_baseDatos.Controls.Add(this.checkBox_baseCreate);
            this.tabPage_baseDatos.Controls.Add(this.checkBox_baseAll);
            this.tabPage_baseDatos.Location = new System.Drawing.Point(4, 25);
            this.tabPage_baseDatos.Name = "tabPage_baseDatos";
            this.tabPage_baseDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_baseDatos.Size = new System.Drawing.Size(705, 342);
            this.tabPage_baseDatos.TabIndex = 0;
            this.tabPage_baseDatos.Text = "Base De Datos";
            this.tabPage_baseDatos.UseVisualStyleBackColor = true;
            // 
            // button_guardarBase
            // 
            this.button_guardarBase.Location = new System.Drawing.Point(553, 219);
            this.button_guardarBase.Name = "button_guardarBase";
            this.button_guardarBase.Size = new System.Drawing.Size(101, 31);
            this.button_guardarBase.TabIndex = 9;
            this.button_guardarBase.Text = "GUARDAR";
            this.button_guardarBase.UseVisualStyleBackColor = true;
            this.button_guardarBase.Click += new System.EventHandler(this.button_guardarBase_Click);
            // 
            // button_cancelarBase
            // 
            this.button_cancelarBase.Location = new System.Drawing.Point(424, 219);
            this.button_cancelarBase.Name = "button_cancelarBase";
            this.button_cancelarBase.Size = new System.Drawing.Size(95, 31);
            this.button_cancelarBase.TabIndex = 8;
            this.button_cancelarBase.Text = "CANCELAR";
            this.button_cancelarBase.UseVisualStyleBackColor = true;
            // 
            // checkBox_baseConnect
            // 
            this.checkBox_baseConnect.AutoSize = true;
            this.checkBox_baseConnect.Location = new System.Drawing.Point(74, 172);
            this.checkBox_baseConnect.Name = "checkBox_baseConnect";
            this.checkBox_baseConnect.Size = new System.Drawing.Size(95, 20);
            this.checkBox_baseConnect.TabIndex = 7;
            this.checkBox_baseConnect.Text = "CONNECT";
            this.checkBox_baseConnect.UseVisualStyleBackColor = true;
            // 
            // checkBox_baseTemporary
            // 
            this.checkBox_baseTemporary.AutoSize = true;
            this.checkBox_baseTemporary.Location = new System.Drawing.Point(74, 125);
            this.checkBox_baseTemporary.Name = "checkBox_baseTemporary";
            this.checkBox_baseTemporary.Size = new System.Drawing.Size(115, 20);
            this.checkBox_baseTemporary.TabIndex = 6;
            this.checkBox_baseTemporary.Text = "TEMPORARY";
            this.checkBox_baseTemporary.UseVisualStyleBackColor = true;
            // 
            // checkBox_baseCreate
            // 
            this.checkBox_baseCreate.AutoSize = true;
            this.checkBox_baseCreate.Location = new System.Drawing.Point(74, 77);
            this.checkBox_baseCreate.Name = "checkBox_baseCreate";
            this.checkBox_baseCreate.Size = new System.Drawing.Size(84, 20);
            this.checkBox_baseCreate.TabIndex = 5;
            this.checkBox_baseCreate.Text = "CREATE";
            this.checkBox_baseCreate.UseVisualStyleBackColor = true;
            // 
            // checkBox_baseAll
            // 
            this.checkBox_baseAll.AutoSize = true;
            this.checkBox_baseAll.Location = new System.Drawing.Point(74, 35);
            this.checkBox_baseAll.Name = "checkBox_baseAll";
            this.checkBox_baseAll.Size = new System.Drawing.Size(52, 20);
            this.checkBox_baseAll.TabIndex = 4;
            this.checkBox_baseAll.Text = "ALL";
            this.checkBox_baseAll.UseVisualStyleBackColor = true;
            // 
            // tabPage_esquema
            // 
            this.tabPage_esquema.Controls.Add(this.button_esquemaGuardar);
            this.tabPage_esquema.Controls.Add(this.button_esquemaCancelar);
            this.tabPage_esquema.Controls.Add(this.checkBox_esquemaUsage);
            this.tabPage_esquema.Controls.Add(this.checkBox_esquemaCreate);
            this.tabPage_esquema.Controls.Add(this.checkBox_esquemaAll);
            this.tabPage_esquema.Location = new System.Drawing.Point(4, 25);
            this.tabPage_esquema.Name = "tabPage_esquema";
            this.tabPage_esquema.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_esquema.Size = new System.Drawing.Size(705, 342);
            this.tabPage_esquema.TabIndex = 1;
            this.tabPage_esquema.Text = "Esquema";
            this.tabPage_esquema.UseVisualStyleBackColor = true;
            // 
            // button_esquemaGuardar
            // 
            this.button_esquemaGuardar.Location = new System.Drawing.Point(561, 255);
            this.button_esquemaGuardar.Name = "button_esquemaGuardar";
            this.button_esquemaGuardar.Size = new System.Drawing.Size(98, 31);
            this.button_esquemaGuardar.TabIndex = 11;
            this.button_esquemaGuardar.Text = "GUARDAR";
            this.button_esquemaGuardar.UseVisualStyleBackColor = true;
            // 
            // button_esquemaCancelar
            // 
            this.button_esquemaCancelar.Location = new System.Drawing.Point(432, 255);
            this.button_esquemaCancelar.Name = "button_esquemaCancelar";
            this.button_esquemaCancelar.Size = new System.Drawing.Size(98, 31);
            this.button_esquemaCancelar.TabIndex = 10;
            this.button_esquemaCancelar.Text = "CANCELAR";
            this.button_esquemaCancelar.UseVisualStyleBackColor = true;
            // 
            // checkBox_esquemaUsage
            // 
            this.checkBox_esquemaUsage.AutoSize = true;
            this.checkBox_esquemaUsage.Location = new System.Drawing.Point(69, 139);
            this.checkBox_esquemaUsage.Name = "checkBox_esquemaUsage";
            this.checkBox_esquemaUsage.Size = new System.Drawing.Size(76, 20);
            this.checkBox_esquemaUsage.TabIndex = 2;
            this.checkBox_esquemaUsage.Text = "USAGE";
            this.checkBox_esquemaUsage.UseVisualStyleBackColor = true;
            // 
            // checkBox_esquemaCreate
            // 
            this.checkBox_esquemaCreate.AutoSize = true;
            this.checkBox_esquemaCreate.Location = new System.Drawing.Point(69, 95);
            this.checkBox_esquemaCreate.Name = "checkBox_esquemaCreate";
            this.checkBox_esquemaCreate.Size = new System.Drawing.Size(84, 20);
            this.checkBox_esquemaCreate.TabIndex = 1;
            this.checkBox_esquemaCreate.Text = "CREATE";
            this.checkBox_esquemaCreate.UseVisualStyleBackColor = true;
            // 
            // checkBox_esquemaAll
            // 
            this.checkBox_esquemaAll.AutoSize = true;
            this.checkBox_esquemaAll.Location = new System.Drawing.Point(69, 51);
            this.checkBox_esquemaAll.Name = "checkBox_esquemaAll";
            this.checkBox_esquemaAll.Size = new System.Drawing.Size(52, 20);
            this.checkBox_esquemaAll.TabIndex = 0;
            this.checkBox_esquemaAll.Text = "ALL";
            this.checkBox_esquemaAll.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_tablaGuardar);
            this.tabPage1.Controls.Add(this.button_tablaCancelar);
            this.tabPage1.Controls.Add(this.checkBox_tablaTrigger);
            this.tabPage1.Controls.Add(this.checkBox_tablaReferences);
            this.tabPage1.Controls.Add(this.checkBox_tablaTruncate);
            this.tabPage1.Controls.Add(this.checkBox_tablaDelete);
            this.tabPage1.Controls.Add(this.checkBox_tablaUpdate);
            this.tabPage1.Controls.Add(this.checkBox_tablaSelect);
            this.tabPage1.Controls.Add(this.checkBox_tablaInsert);
            this.tabPage1.Controls.Add(this.checkBox_tablaAll);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox_tabla);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 342);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Tabla";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_tablaGuardar
            // 
            this.button_tablaGuardar.Location = new System.Drawing.Point(558, 277);
            this.button_tablaGuardar.Name = "button_tablaGuardar";
            this.button_tablaGuardar.Size = new System.Drawing.Size(98, 31);
            this.button_tablaGuardar.TabIndex = 13;
            this.button_tablaGuardar.Text = "GUARDAR";
            this.button_tablaGuardar.UseVisualStyleBackColor = true;
            // 
            // button_tablaCancelar
            // 
            this.button_tablaCancelar.Location = new System.Drawing.Point(429, 277);
            this.button_tablaCancelar.Name = "button_tablaCancelar";
            this.button_tablaCancelar.Size = new System.Drawing.Size(99, 31);
            this.button_tablaCancelar.TabIndex = 12;
            this.button_tablaCancelar.Text = "CANCELAR";
            this.button_tablaCancelar.UseVisualStyleBackColor = true;
            // 
            // checkBox_tablaTrigger
            // 
            this.checkBox_tablaTrigger.AutoSize = true;
            this.checkBox_tablaTrigger.Location = new System.Drawing.Point(438, 162);
            this.checkBox_tablaTrigger.Name = "checkBox_tablaTrigger";
            this.checkBox_tablaTrigger.Size = new System.Drawing.Size(90, 20);
            this.checkBox_tablaTrigger.TabIndex = 9;
            this.checkBox_tablaTrigger.Text = "TRIGGER";
            this.checkBox_tablaTrigger.UseVisualStyleBackColor = true;
            // 
            // checkBox_tablaReferences
            // 
            this.checkBox_tablaReferences.AutoSize = true;
            this.checkBox_tablaReferences.Location = new System.Drawing.Point(438, 121);
            this.checkBox_tablaReferences.Name = "checkBox_tablaReferences";
            this.checkBox_tablaReferences.Size = new System.Drawing.Size(121, 20);
            this.checkBox_tablaReferences.TabIndex = 8;
            this.checkBox_tablaReferences.Text = "REFERENCES";
            this.checkBox_tablaReferences.UseVisualStyleBackColor = true;
            // 
            // checkBox_tablaTruncate
            // 
            this.checkBox_tablaTruncate.AutoSize = true;
            this.checkBox_tablaTruncate.Location = new System.Drawing.Point(438, 82);
            this.checkBox_tablaTruncate.Name = "checkBox_tablaTruncate";
            this.checkBox_tablaTruncate.Size = new System.Drawing.Size(104, 20);
            this.checkBox_tablaTruncate.TabIndex = 7;
            this.checkBox_tablaTruncate.Text = "TRUNCATE";
            this.checkBox_tablaTruncate.UseVisualStyleBackColor = true;
            // 
            // checkBox_tablaDelete
            // 
            this.checkBox_tablaDelete.AutoSize = true;
            this.checkBox_tablaDelete.Location = new System.Drawing.Point(438, 41);
            this.checkBox_tablaDelete.Name = "checkBox_tablaDelete";
            this.checkBox_tablaDelete.Size = new System.Drawing.Size(82, 20);
            this.checkBox_tablaDelete.TabIndex = 6;
            this.checkBox_tablaDelete.Text = "DELETE";
            this.checkBox_tablaDelete.UseVisualStyleBackColor = true;
            // 
            // checkBox_tablaUpdate
            // 
            this.checkBox_tablaUpdate.AutoSize = true;
            this.checkBox_tablaUpdate.Location = new System.Drawing.Point(277, 162);
            this.checkBox_tablaUpdate.Name = "checkBox_tablaUpdate";
            this.checkBox_tablaUpdate.Size = new System.Drawing.Size(85, 20);
            this.checkBox_tablaUpdate.TabIndex = 5;
            this.checkBox_tablaUpdate.Text = "UPDATE";
            this.checkBox_tablaUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBox_tablaSelect
            // 
            this.checkBox_tablaSelect.AutoSize = true;
            this.checkBox_tablaSelect.Location = new System.Drawing.Point(277, 121);
            this.checkBox_tablaSelect.Name = "checkBox_tablaSelect";
            this.checkBox_tablaSelect.Size = new System.Drawing.Size(81, 20);
            this.checkBox_tablaSelect.TabIndex = 4;
            this.checkBox_tablaSelect.Text = "SELECT";
            this.checkBox_tablaSelect.UseVisualStyleBackColor = true;
            // 
            // checkBox_tablaInsert
            // 
            this.checkBox_tablaInsert.AutoSize = true;
            this.checkBox_tablaInsert.Location = new System.Drawing.Point(277, 82);
            this.checkBox_tablaInsert.Name = "checkBox_tablaInsert";
            this.checkBox_tablaInsert.Size = new System.Drawing.Size(79, 20);
            this.checkBox_tablaInsert.TabIndex = 3;
            this.checkBox_tablaInsert.Text = "INSERT";
            this.checkBox_tablaInsert.UseVisualStyleBackColor = true;
            // 
            // checkBox_tablaAll
            // 
            this.checkBox_tablaAll.AutoSize = true;
            this.checkBox_tablaAll.Location = new System.Drawing.Point(277, 41);
            this.checkBox_tablaAll.Name = "checkBox_tablaAll";
            this.checkBox_tablaAll.Size = new System.Drawing.Size(52, 20);
            this.checkBox_tablaAll.TabIndex = 2;
            this.checkBox_tablaAll.Text = "ALL";
            this.checkBox_tablaAll.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecciona la tabla";
            // 
            // comboBox_tabla
            // 
            this.comboBox_tabla.FormattingEnabled = true;
            this.comboBox_tabla.Location = new System.Drawing.Point(32, 67);
            this.comboBox_tabla.Name = "comboBox_tabla";
            this.comboBox_tabla.Size = new System.Drawing.Size(168, 24);
            this.comboBox_tabla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la base: ";
            // 
            // comboBox_base
            // 
            this.comboBox_base.FormattingEnabled = true;
            this.comboBox_base.Location = new System.Drawing.Point(188, 43);
            this.comboBox_base.Name = "comboBox_base";
            this.comboBox_base.Size = new System.Drawing.Size(168, 24);
            this.comboBox_base.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el usuario: ";
            // 
            // comboBox_usuario
            // 
            this.comboBox_usuario.FormattingEnabled = true;
            this.comboBox_usuario.Location = new System.Drawing.Point(561, 43);
            this.comboBox_usuario.Name = "comboBox_usuario";
            this.comboBox_usuario.Size = new System.Drawing.Size(168, 24);
            this.comboBox_usuario.TabIndex = 3;
            // 
            // Form_Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 557);
            this.Controls.Add(this.groupBox_permisos);
            this.Name = "Form_Permisos";
            this.Text = "Form_Permisos";
            this.Load += new System.EventHandler(this.Form_Permisos_Load);
            this.groupBox_permisos.ResumeLayout(false);
            this.groupBox_permisos.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_baseDatos.ResumeLayout(false);
            this.tabPage_baseDatos.PerformLayout();
            this.tabPage_esquema.ResumeLayout(false);
            this.tabPage_esquema.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_permisos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_baseDatos;
        private System.Windows.Forms.TabPage tabPage_esquema;
        private System.Windows.Forms.ComboBox comboBox_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_base;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_baseConnect;
        private System.Windows.Forms.CheckBox checkBox_baseTemporary;
        private System.Windows.Forms.CheckBox checkBox_baseCreate;
        private System.Windows.Forms.CheckBox checkBox_baseAll;
        private System.Windows.Forms.Button button_guardarBase;
        private System.Windows.Forms.Button button_cancelarBase;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox_esquemaUsage;
        private System.Windows.Forms.CheckBox checkBox_esquemaCreate;
        private System.Windows.Forms.CheckBox checkBox_esquemaAll;
        private System.Windows.Forms.Button button_esquemaGuardar;
        private System.Windows.Forms.Button button_esquemaCancelar;
        private System.Windows.Forms.CheckBox checkBox_tablaTrigger;
        private System.Windows.Forms.CheckBox checkBox_tablaReferences;
        private System.Windows.Forms.CheckBox checkBox_tablaTruncate;
        private System.Windows.Forms.CheckBox checkBox_tablaDelete;
        private System.Windows.Forms.CheckBox checkBox_tablaUpdate;
        private System.Windows.Forms.CheckBox checkBox_tablaSelect;
        private System.Windows.Forms.CheckBox checkBox_tablaInsert;
        private System.Windows.Forms.CheckBox checkBox_tablaAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tabla;
        private System.Windows.Forms.Button button_tablaGuardar;
        private System.Windows.Forms.Button button_tablaCancelar;
    }
}