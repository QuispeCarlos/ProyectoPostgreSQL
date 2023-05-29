﻿namespace Principal
{
    partial class Form_Principal
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
            this.groupBox_servidores = new System.Windows.Forms.GroupBox();
            this.treeView_buscador = new System.Windows.Forms.TreeView();
            this.groupBox_query = new System.Windows.Forms.GroupBox();
            this.dataGridView_DataOutput = new System.Windows.Forms.DataGridView();
            this.textBox_dataOutput = new System.Windows.Forms.TextBox();
            this.button_ejecutar = new System.Windows.Forms.Button();
            this.textBox_query = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_PostgreSQL = new System.Windows.Forms.GroupBox();
            this.comboBox_tablespaces = new System.Windows.Forms.ComboBox();
            this.comboBox_groupRoles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_refrescar = new System.Windows.Forms.Button();
            this.comboBox_databases = new System.Windows.Forms.ComboBox();
            this.button_crear = new System.Windows.Forms.Button();
            this.groupBox_opciones = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schemasPublicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.columnasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasLasFilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_BD = new System.Windows.Forms.Label();
            this.groupBox_servidores.SuspendLayout();
            this.groupBox_query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataOutput)).BeginInit();
            this.groupBox_PostgreSQL.SuspendLayout();
            this.groupBox_opciones.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_servidores
            // 
            this.groupBox_servidores.Controls.Add(this.treeView_buscador);
            this.groupBox_servidores.Location = new System.Drawing.Point(13, 23);
            this.groupBox_servidores.Name = "groupBox_servidores";
            this.groupBox_servidores.Size = new System.Drawing.Size(260, 406);
            this.groupBox_servidores.TabIndex = 0;
            this.groupBox_servidores.TabStop = false;
            this.groupBox_servidores.Text = "Servidores";
            // 
            // treeView_buscador
            // 
            this.treeView_buscador.Location = new System.Drawing.Point(6, 31);
            this.treeView_buscador.Name = "treeView_buscador";
            this.treeView_buscador.Size = new System.Drawing.Size(235, 341);
            this.treeView_buscador.TabIndex = 0;
            // 
            // groupBox_query
            // 
            this.groupBox_query.Controls.Add(this.dataGridView_DataOutput);
            this.groupBox_query.Controls.Add(this.textBox_dataOutput);
            this.groupBox_query.Controls.Add(this.button_ejecutar);
            this.groupBox_query.Controls.Add(this.textBox_query);
            this.groupBox_query.Location = new System.Drawing.Point(606, 23);
            this.groupBox_query.Name = "groupBox_query";
            this.groupBox_query.Size = new System.Drawing.Size(466, 524);
            this.groupBox_query.TabIndex = 1;
            this.groupBox_query.TabStop = false;
            this.groupBox_query.Text = "Query";
            // 
            // dataGridView_DataOutput
            // 
            this.dataGridView_DataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DataOutput.Location = new System.Drawing.Point(17, 382);
            this.dataGridView_DataOutput.Name = "dataGridView_DataOutput";
            this.dataGridView_DataOutput.RowHeadersWidth = 51;
            this.dataGridView_DataOutput.RowTemplate.Height = 24;
            this.dataGridView_DataOutput.Size = new System.Drawing.Size(445, 103);
            this.dataGridView_DataOutput.TabIndex = 3;
            // 
            // textBox_dataOutput
            // 
            this.textBox_dataOutput.Location = new System.Drawing.Point(17, 304);
            this.textBox_dataOutput.Multiline = true;
            this.textBox_dataOutput.Name = "textBox_dataOutput";
            this.textBox_dataOutput.Size = new System.Drawing.Size(445, 52);
            this.textBox_dataOutput.TabIndex = 2;
            // 
            // button_ejecutar
            // 
            this.button_ejecutar.Location = new System.Drawing.Point(376, 263);
            this.button_ejecutar.Name = "button_ejecutar";
            this.button_ejecutar.Size = new System.Drawing.Size(86, 23);
            this.button_ejecutar.TabIndex = 1;
            this.button_ejecutar.Text = "Ejecutar";
            this.button_ejecutar.UseVisualStyleBackColor = true;
            this.button_ejecutar.Click += new System.EventHandler(this.button_ejecutar_Click);
            // 
            // textBox_query
            // 
            this.textBox_query.Location = new System.Drawing.Point(17, 31);
            this.textBox_query.Multiline = true;
            this.textBox_query.Name = "textBox_query";
            this.textBox_query.Size = new System.Drawing.Size(445, 215);
            this.textBox_query.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Databases";
            // 
            // groupBox_PostgreSQL
            // 
            this.groupBox_PostgreSQL.Controls.Add(this.comboBox_tablespaces);
            this.groupBox_PostgreSQL.Controls.Add(this.comboBox_groupRoles);
            this.groupBox_PostgreSQL.Controls.Add(this.label3);
            this.groupBox_PostgreSQL.Controls.Add(this.label2);
            this.groupBox_PostgreSQL.Controls.Add(this.button_eliminar);
            this.groupBox_PostgreSQL.Controls.Add(this.button_refrescar);
            this.groupBox_PostgreSQL.Controls.Add(this.comboBox_databases);
            this.groupBox_PostgreSQL.Controls.Add(this.button_crear);
            this.groupBox_PostgreSQL.Controls.Add(this.label1);
            this.groupBox_PostgreSQL.Location = new System.Drawing.Point(292, 23);
            this.groupBox_PostgreSQL.Name = "groupBox_PostgreSQL";
            this.groupBox_PostgreSQL.Size = new System.Drawing.Size(281, 297);
            this.groupBox_PostgreSQL.TabIndex = 2;
            this.groupBox_PostgreSQL.TabStop = false;
            this.groupBox_PostgreSQL.Text = "PostgreSQL";
            // 
            // comboBox_tablespaces
            // 
            this.comboBox_tablespaces.FormattingEnabled = true;
            this.comboBox_tablespaces.Location = new System.Drawing.Point(24, 258);
            this.comboBox_tablespaces.Name = "comboBox_tablespaces";
            this.comboBox_tablespaces.Size = new System.Drawing.Size(154, 24);
            this.comboBox_tablespaces.TabIndex = 13;
            // 
            // comboBox_groupRoles
            // 
            this.comboBox_groupRoles.FormattingEnabled = true;
            this.comboBox_groupRoles.Location = new System.Drawing.Point(24, 193);
            this.comboBox_groupRoles.Name = "comboBox_groupRoles";
            this.comboBox_groupRoles.Size = new System.Drawing.Size(154, 24);
            this.comboBox_groupRoles.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tablespaces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login/Group Roles";
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(179, 119);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 28);
            this.button_eliminar.TabIndex = 5;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_refrescar
            // 
            this.button_refrescar.Location = new System.Drawing.Point(179, 85);
            this.button_refrescar.Name = "button_refrescar";
            this.button_refrescar.Size = new System.Drawing.Size(75, 28);
            this.button_refrescar.TabIndex = 4;
            this.button_refrescar.Text = "Refrescar";
            this.button_refrescar.UseVisualStyleBackColor = true;
            this.button_refrescar.Click += new System.EventHandler(this.button_refrescar_Click);
            // 
            // comboBox_databases
            // 
            this.comboBox_databases.FormattingEnabled = true;
            this.comboBox_databases.Location = new System.Drawing.Point(24, 76);
            this.comboBox_databases.Name = "comboBox_databases";
            this.comboBox_databases.Size = new System.Drawing.Size(121, 24);
            this.comboBox_databases.TabIndex = 3;
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(179, 51);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(75, 28);
            this.button_crear.TabIndex = 2;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // groupBox_opciones
            // 
            this.groupBox_opciones.Controls.Add(this.menuStrip1);
            this.groupBox_opciones.Location = new System.Drawing.Point(279, 362);
            this.groupBox_opciones.Name = "groupBox_opciones";
            this.groupBox_opciones.Size = new System.Drawing.Size(294, 253);
            this.groupBox_opciones.TabIndex = 3;
            this.groupBox_opciones.TabStop = false;
            this.groupBox_opciones.Text = "Opciones";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schemasPublicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // schemasPublicToolStripMenuItem
            // 
            this.schemasPublicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnasToolStripMenuItem,
            this.triggersToolStripMenuItem});
            this.schemasPublicToolStripMenuItem.Name = "schemasPublicToolStripMenuItem";
            this.schemasPublicToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.schemasPublicToolStripMenuItem.Text = "Schemas - Public";
            // 
            // columnasToolStripMenuItem
            // 
            this.columnasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem1,
            this.columnasToolStripMenuItem2,
            this.verTodasLasFilasToolStripMenuItem});
            this.columnasToolStripMenuItem.Name = "columnasToolStripMenuItem";
            this.columnasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.columnasToolStripMenuItem.Text = "Tablas";
            // 
            // triggersToolStripMenuItem
            // 
            this.triggersToolStripMenuItem.Name = "triggersToolStripMenuItem";
            this.triggersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.triggersToolStripMenuItem.Text = "Triggers";
            this.triggersToolStripMenuItem.Click += new System.EventHandler(this.triggersToolStripMenuItem_Click);
            // 
            // tablasToolStripMenuItem1
            // 
            this.tablasToolStripMenuItem1.Name = "tablasToolStripMenuItem1";
            this.tablasToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.tablasToolStripMenuItem1.Text = "Tablas";
            this.tablasToolStripMenuItem1.Click += new System.EventHandler(this.tablasToolStripMenuItem1_Click);
            // 
            // columnasToolStripMenuItem2
            // 
            this.columnasToolStripMenuItem2.Name = "columnasToolStripMenuItem2";
            this.columnasToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.columnasToolStripMenuItem2.Text = "Columnas";
            this.columnasToolStripMenuItem2.Click += new System.EventHandler(this.columnasToolStripMenuItem2_Click);
            // 
            // verTodasLasFilasToolStripMenuItem
            // 
            this.verTodasLasFilasToolStripMenuItem.Name = "verTodasLasFilasToolStripMenuItem";
            this.verTodasLasFilasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verTodasLasFilasToolStripMenuItem.Text = "Ver todas las Filas";
            this.verTodasLasFilasToolStripMenuItem.Click += new System.EventHandler(this.verTodasLasFilasToolStripMenuItem_Click);
            // 
            // label_BD
            // 
            this.label_BD.AutoSize = true;
            this.label_BD.Location = new System.Drawing.Point(400, 340);
            this.label_BD.Name = "label_BD";
            this.label_BD.Size = new System.Drawing.Size(26, 16);
            this.label_BD.TabIndex = 4;
            this.label_BD.Text = "BD";
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 638);
            this.Controls.Add(this.label_BD);
            this.Controls.Add(this.groupBox_opciones);
            this.Controls.Add(this.groupBox_PostgreSQL);
            this.Controls.Add(this.groupBox_query);
            this.Controls.Add(this.groupBox_servidores);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Principal";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.groupBox_servidores.ResumeLayout(false);
            this.groupBox_query.ResumeLayout(false);
            this.groupBox_query.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataOutput)).EndInit();
            this.groupBox_PostgreSQL.ResumeLayout(false);
            this.groupBox_PostgreSQL.PerformLayout();
            this.groupBox_opciones.ResumeLayout(false);
            this.groupBox_opciones.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_servidores;
        private System.Windows.Forms.TreeView treeView_buscador;
        private System.Windows.Forms.GroupBox groupBox_query;
        private System.Windows.Forms.TextBox textBox_dataOutput;
        private System.Windows.Forms.Button button_ejecutar;
        private System.Windows.Forms.TextBox textBox_query;
        private System.Windows.Forms.DataGridView dataGridView_DataOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_PostgreSQL;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_refrescar;
        private System.Windows.Forms.ComboBox comboBox_databases;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.ComboBox comboBox_tablespaces;
        private System.Windows.Forms.ComboBox comboBox_groupRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_opciones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schemasPublicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem columnasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verTodasLasFilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggersToolStripMenuItem;
        private System.Windows.Forms.Label label_BD;
    }
}