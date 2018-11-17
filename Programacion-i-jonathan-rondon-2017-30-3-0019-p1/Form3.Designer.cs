namespace Programacion_i_jonathan_rondon_2017_30_3_0019_p1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnprograma1 = new System.Windows.Forms.Button();
            this.btnprograma3 = new System.Windows.Forms.Button();
            this.btnprograma2 = new System.Windows.Forms.Button();
            this.btnprograma4 = new System.Windows.Forms.Button();
            this.btnprograma5 = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnprograma1
            // 
            this.btnprograma1.Location = new System.Drawing.Point(15, 13);
            this.btnprograma1.Name = "btnprograma1";
            this.btnprograma1.Size = new System.Drawing.Size(75, 40);
            this.btnprograma1.TabIndex = 0;
            this.btnprograma1.Text = "Calcular Sueldo";
            this.btnprograma1.UseVisualStyleBackColor = true;
            this.btnprograma1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnprograma3
            // 
            this.btnprograma3.Location = new System.Drawing.Point(269, 13);
            this.btnprograma3.Name = "btnprograma3";
            this.btnprograma3.Size = new System.Drawing.Size(75, 40);
            this.btnprograma3.TabIndex = 0;
            this.btnprograma3.Text = "Estructura Condicional";
            this.btnprograma3.UseVisualStyleBackColor = true;
            this.btnprograma3.Click += new System.EventHandler(this.btnprograma3_Click);
            // 
            // btnprograma2
            // 
            this.btnprograma2.Location = new System.Drawing.Point(146, 13);
            this.btnprograma2.Name = "btnprograma2";
            this.btnprograma2.Size = new System.Drawing.Size(75, 40);
            this.btnprograma2.TabIndex = 0;
            this.btnprograma2.Text = "Superficie Cuadrada";
            this.btnprograma2.UseVisualStyleBackColor = true;
            this.btnprograma2.Click += new System.EventHandler(this.btnprograma2_Click);
            // 
            // btnprograma4
            // 
            this.btnprograma4.Location = new System.Drawing.Point(15, 108);
            this.btnprograma4.Name = "btnprograma4";
            this.btnprograma4.Size = new System.Drawing.Size(75, 39);
            this.btnprograma4.TabIndex = 0;
            this.btnprograma4.Text = "Productor Numerico";
            this.btnprograma4.UseVisualStyleBackColor = true;
            this.btnprograma4.Click += new System.EventHandler(this.btnprograma4_Click);
            // 
            // btnprograma5
            // 
            this.btnprograma5.Location = new System.Drawing.Point(269, 108);
            this.btnprograma5.Name = "btnprograma5";
            this.btnprograma5.Size = new System.Drawing.Size(75, 39);
            this.btnprograma5.TabIndex = 0;
            this.btnprograma5.Text = "Estructura Condicional";
            this.btnprograma5.UseVisualStyleBackColor = true;
            this.btnprograma5.Click += new System.EventHandler(this.btnprograma5_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(146, 128);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 163);
            this.Controls.Add(this.btnprograma5);
            this.Controls.Add(this.btnprograma4);
            this.Controls.Add(this.btnprograma2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnprograma3);
            this.Controls.Add(this.btnprograma1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Operador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnprograma1;
        private System.Windows.Forms.Button btnprograma3;
        private System.Windows.Forms.Button btnprograma2;
        private System.Windows.Forms.Button btnprograma4;
        private System.Windows.Forms.Button btnprograma5;
        private System.Windows.Forms.Button btnsalir;
    }
}