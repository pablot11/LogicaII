namespace pryTorresLogicaII
{
    partial class frmCarga
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
            this.lstProducto = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCargaProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProducto
            // 
            this.lstProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Items.AddRange(new object[] {
            "Tornillos",
            "Tuercas"});
            this.lstProducto.Location = new System.Drawing.Point(68, 9);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(121, 21);
            this.lstProducto.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(114, 36);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCargaProducto
            // 
            this.lblCargaProducto.AutoSize = true;
            this.lblCargaProducto.Location = new System.Drawing.Point(12, 9);
            this.lblCargaProducto.Name = "lblCargaProducto";
            this.lblCargaProducto.Size = new System.Drawing.Size(50, 13);
            this.lblCargaProducto.TabIndex = 2;
            this.lblCargaProducto.Text = "Producto";
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 80);
            this.Controls.Add(this.lblCargaProducto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstProducto);
            this.Name = "frmCarga";
            this.Text = "Carga Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCargaProducto;
    }
}