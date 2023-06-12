namespace Principal
{
    partial class Form_ConexionesRegistradas
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
            this.dataGridView_conexionesRegistradas = new System.Windows.Forms.DataGridView();
            this.button_usar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_conexionesRegistradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_conexionesRegistradas
            // 
            this.dataGridView_conexionesRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_conexionesRegistradas.Location = new System.Drawing.Point(91, 31);
            this.dataGridView_conexionesRegistradas.Name = "dataGridView_conexionesRegistradas";
            this.dataGridView_conexionesRegistradas.RowHeadersWidth = 51;
            this.dataGridView_conexionesRegistradas.RowTemplate.Height = 24;
            this.dataGridView_conexionesRegistradas.Size = new System.Drawing.Size(604, 244);
            this.dataGridView_conexionesRegistradas.TabIndex = 0;
            // 
            // button_usar
            // 
            this.button_usar.Location = new System.Drawing.Point(91, 343);
            this.button_usar.Name = "button_usar";
            this.button_usar.Size = new System.Drawing.Size(106, 41);
            this.button_usar.TabIndex = 1;
            this.button_usar.Text = "Usar";
            this.button_usar.UseVisualStyleBackColor = true;
            this.button_usar.Click += new System.EventHandler(this.button_usar_Click);
            // 
            // Form_ConexionesRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_usar);
            this.Controls.Add(this.dataGridView_conexionesRegistradas);
            this.Name = "Form_ConexionesRegistradas";
            this.Text = "Form_ConexionesRegistradas";
            this.Load += new System.EventHandler(this.Form_ConexionesRegistradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_conexionesRegistradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_conexionesRegistradas;
        private System.Windows.Forms.Button button_usar;
    }
}