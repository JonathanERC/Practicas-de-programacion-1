namespace Programacion_i_jonathan_rondon_2017_30_3_0019_p1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn1enviar = new System.Windows.Forms.Button();
            this.btn1nuevo = new System.Windows.Forms.Button();
            this.txt1salario = new System.Windows.Forms.TextBox();
            this.txt1edad = new System.Windows.Forms.TextBox();
            this.txt1nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt1descripcion = new System.Windows.Forms.TextBox();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2numero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb2suma = new System.Windows.Forms.ComboBox();
            this.cb2resta = new System.Windows.Forms.ComboBox();
            this.cb2mult = new System.Windows.Forms.ComboBox();
            this.cb2div = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 314);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Error-C";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn1enviar
            // 
            this.btn1enviar.Location = new System.Drawing.Point(344, 216);
            this.btn1enviar.Name = "btn1enviar";
            this.btn1enviar.Size = new System.Drawing.Size(98, 42);
            this.btn1enviar.TabIndex = 3;
            this.btn1enviar.Text = "Enviar";
            this.btn1enviar.UseVisualStyleBackColor = true;
            this.btn1enviar.Click += new System.EventHandler(this.btn1enviar_Click);
            // 
            // btn1nuevo
            // 
            this.btn1nuevo.Location = new System.Drawing.Point(344, 141);
            this.btn1nuevo.Name = "btn1nuevo";
            this.btn1nuevo.Size = new System.Drawing.Size(98, 42);
            this.btn1nuevo.TabIndex = 2;
            this.btn1nuevo.Text = "Nuevo";
            this.btn1nuevo.UseVisualStyleBackColor = true;
            this.btn1nuevo.Click += new System.EventHandler(this.btn1nuevo_Click);
            // 
            // txt1salario
            // 
            this.txt1salario.Location = new System.Drawing.Point(122, 144);
            this.txt1salario.Name = "txt1salario";
            this.txt1salario.Size = new System.Drawing.Size(100, 20);
            this.txt1salario.TabIndex = 1;
            // 
            // txt1edad
            // 
            this.txt1edad.Location = new System.Drawing.Point(122, 87);
            this.txt1edad.Name = "txt1edad";
            this.txt1edad.Size = new System.Drawing.Size(60, 20);
            this.txt1edad.TabIndex = 1;
            // 
            // txt1nombre
            // 
            this.txt1nombre.Location = new System.Drawing.Point(122, 37);
            this.txt1nombre.Name = "txt1nombre";
            this.txt1nombre.Size = new System.Drawing.Size(156, 20);
            this.txt1nombre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabla-C";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(448, 317);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn1enviar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn1nuevo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt1descripcion);
            this.groupBox1.Controls.Add(this.txt1salario);
            this.groupBox1.Controls.Add(this.txt1nombre);
            this.groupBox1.Controls.Add(this.txt1edad);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos";
            // 
            // txt1descripcion
            // 
            this.txt1descripcion.Location = new System.Drawing.Point(122, 191);
            this.txt1descripcion.Multiline = true;
            this.txt1descripcion.Name = "txt1descripcion";
            this.txt1descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt1descripcion.Size = new System.Drawing.Size(185, 67);
            this.txt1descripcion.TabIndex = 1;
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt2numero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 134);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese Datos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb2div);
            this.groupBox3.Controls.Add(this.cb2mult);
            this.groupBox3.Controls.Add(this.cb2resta);
            this.groupBox3.Controls.Add(this.cb2suma);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 136);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabla Aritmética";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número";
            // 
            // txt2numero
            // 
            this.txt2numero.Location = new System.Drawing.Point(103, 56);
            this.txt2numero.Name = "txt2numero";
            this.txt2numero.Size = new System.Drawing.Size(170, 20);
            this.txt2numero.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Suma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Resta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Multiplicación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "División";
            // 
            // cb2suma
            // 
            this.cb2suma.FormattingEnabled = true;
            this.cb2suma.Location = new System.Drawing.Point(9, 71);
            this.cb2suma.Name = "cb2suma";
            this.cb2suma.Size = new System.Drawing.Size(101, 21);
            this.cb2suma.TabIndex = 1;
            // 
            // cb2resta
            // 
            this.cb2resta.FormattingEnabled = true;
            this.cb2resta.Location = new System.Drawing.Point(129, 71);
            this.cb2resta.Name = "cb2resta";
            this.cb2resta.Size = new System.Drawing.Size(101, 21);
            this.cb2resta.TabIndex = 1;
            // 
            // cb2mult
            // 
            this.cb2mult.FormattingEnabled = true;
            this.cb2mult.Location = new System.Drawing.Point(236, 71);
            this.cb2mult.Name = "cb2mult";
            this.cb2mult.Size = new System.Drawing.Size(101, 21);
            this.cb2mult.TabIndex = 1;
            // 
            // cb2div
            // 
            this.cb2div.FormattingEnabled = true;
            this.cb2div.Location = new System.Drawing.Point(355, 71);
            this.cb2div.Name = "cb2div";
            this.cb2div.Size = new System.Drawing.Size(101, 21);
            this.cb2div.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 336);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Operador";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn1enviar;
        private System.Windows.Forms.Button btn1nuevo;
        private System.Windows.Forms.TextBox txt1salario;
        private System.Windows.Forms.TextBox txt1edad;
        private System.Windows.Forms.TextBox txt1nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt1descripcion;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb2div;
        private System.Windows.Forms.ComboBox cb2mult;
        private System.Windows.Forms.ComboBox cb2resta;
        private System.Windows.Forms.ComboBox cb2suma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt2numero;
        private System.Windows.Forms.Label label5;
    }
}