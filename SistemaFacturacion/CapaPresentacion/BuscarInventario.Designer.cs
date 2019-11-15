namespace CapaPresentacion
{
    partial class BuscarInventario
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
            this.dataprod = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataprod)).BeginInit();
            this.SuspendLayout();
            // 
            // dataprod
            // 
            this.dataprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataprod.Location = new System.Drawing.Point(26, 112);
            this.dataprod.Name = "dataprod";
            this.dataprod.Size = new System.Drawing.Size(744, 296);
            this.dataprod.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(404, 62);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(145, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            this.txtbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtbuscar_KeyUp);
            // 
            // BuscarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataprod);
            this.Name = "BuscarInventario";
            this.Text = "BuscarInventario";
            this.Load += new System.EventHandler(this.BuscarInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataprod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}