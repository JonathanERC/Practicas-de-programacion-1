namespace Programacion_i_jonathan_rondon_2017_30_3_0019_p1
{
    partial class Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.btnentrada1 = new System.Windows.Forms.Button();
            this.btnentrada2 = new System.Windows.Forms.Button();
            this.btnsalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnentrada1
            // 
            this.btnentrada1.Location = new System.Drawing.Point(78, 41);
            this.btnentrada1.Name = "btnentrada1";
            this.btnentrada1.Size = new System.Drawing.Size(120, 50);
            this.btnentrada1.TabIndex = 0;
            this.btnentrada1.Text = "Primera Sección";
            this.btnentrada1.UseVisualStyleBackColor = true;
            this.btnentrada1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnentrada2
            // 
            this.btnentrada2.Location = new System.Drawing.Point(78, 126);
            this.btnentrada2.Name = "btnentrada2";
            this.btnentrada2.Size = new System.Drawing.Size(120, 50);
            this.btnentrada2.TabIndex = 0;
            this.btnentrada2.Text = "Segunda Sección";
            this.btnentrada2.UseVisualStyleBackColor = true;
            this.btnentrada2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsalida
            // 
            this.btnsalida.Location = new System.Drawing.Point(197, 227);
            this.btnsalida.Name = "btnsalida";
            this.btnsalida.Size = new System.Drawing.Size(75, 23);
            this.btnsalida.TabIndex = 0;
            this.btnsalida.Text = "Salir";
            this.btnsalida.UseVisualStyleBackColor = true;
            this.btnsalida.Click += new System.EventHandler(this.button3_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnsalida);
            this.Controls.Add(this.btnentrada2);
            this.Controls.Add(this.btnentrada1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Entrada";
            this.Text = "Operador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnentrada1;
        private System.Windows.Forms.Button btnentrada2;
        private System.Windows.Forms.Button btnsalida;
    }
}