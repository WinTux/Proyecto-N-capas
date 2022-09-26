namespace Proyecto_N_capas
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
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.tablaSalida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(20, 108);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(289, 218);
            this.txtSalida.TabIndex = 0;
            // 
            // tablaSalida
            // 
            this.tablaSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSalida.Location = new System.Drawing.Point(378, 108);
            this.tablaSalida.Name = "tablaSalida";
            this.tablaSalida.RowTemplate.Height = 25;
            this.tablaSalida.Size = new System.Drawing.Size(383, 218);
            this.tablaSalida.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaSalida);
            this.Controls.Add(this.txtSalida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.DataGridView tablaSalida;
    }
}
