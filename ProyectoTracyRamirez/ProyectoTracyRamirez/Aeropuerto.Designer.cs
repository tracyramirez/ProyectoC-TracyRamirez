namespace ProyectoTracyRamirez
{
    partial class Aeropuerto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtiata = new System.Windows.Forms.TextBox();
            this.btnAcertarAerop = new System.Windows.Forms.Button();
            this.dataAerop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataAerop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDENTIFICADOR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOCALIDAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IATA";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(144, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Location = new System.Drawing.Point(144, 118);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtlocalidad.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(144, 69);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtiata
            // 
            this.txtiata.Location = new System.Drawing.Point(144, 160);
            this.txtiata.Name = "txtiata";
            this.txtiata.Size = new System.Drawing.Size(100, 20);
            this.txtiata.TabIndex = 7;
            // 
            // btnAcertarAerop
            // 
            this.btnAcertarAerop.Location = new System.Drawing.Point(348, 214);
            this.btnAcertarAerop.Name = "btnAcertarAerop";
            this.btnAcertarAerop.Size = new System.Drawing.Size(75, 23);
            this.btnAcertarAerop.TabIndex = 8;
            this.btnAcertarAerop.Text = "Acerptar";
            this.btnAcertarAerop.UseVisualStyleBackColor = true;
            this.btnAcertarAerop.Click += new System.EventHandler(this.btnAcertarAerop_Click);
            // 
            // dataAerop
            // 
            this.dataAerop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAerop.Location = new System.Drawing.Point(12, 229);
            this.dataAerop.Name = "dataAerop";
            this.dataAerop.Size = new System.Drawing.Size(299, 198);
            this.dataAerop.TabIndex = 11;
            // 
            // Aeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 459);
            this.Controls.Add(this.dataAerop);
            this.Controls.Add(this.btnAcertarAerop);
            this.Controls.Add(this.txtiata);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Aeropuerto";
            this.Text = "Aeropuerto";
            this.Load += new System.EventHandler(this.dataAeropuerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAerop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtiata;
        private System.Windows.Forms.Button btnAcertarAerop;
        private System.Windows.Forms.DataGridView dataAerop;
    }
}