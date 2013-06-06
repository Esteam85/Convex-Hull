namespace Cierre_convexo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list = new System.Windows.Forms.ListBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.list3 = new System.Windows.Forms.ListBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.tipoCierre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Generar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBRojo = new System.Windows.Forms.RadioButton();
            this.radioBAzul = new System.Windows.Forms.RadioButton();
            this.radioBVerde = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cPuntos = new System.Windows.Forms.MaskedTextBox();
            this.GeneraPuntos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic);
            this.groupBox1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pic
            // 
            resources.ApplyResources(this.pic, "pic");
            this.pic.Name = "pic";
            this.pic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            resources.ApplyResources(this.list, "list");
            this.list.Name = "list";
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            resources.ApplyResources(this.list2, "list2");
            this.list2.Name = "list2";
            // 
            // list3
            // 
            this.list3.FormattingEnabled = true;
            resources.ApplyResources(this.list3, "list3");
            this.list3.Name = "list3";
            this.list3.SelectedIndexChanged += new System.EventHandler(this.list3_SelectedIndexChanged);
            // 
            // Limpiar
            // 
            resources.ApplyResources(this.Limpiar, "Limpiar");
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tipoCierre
            // 
            this.tipoCierre.FormattingEnabled = true;
            resources.ApplyResources(this.tipoCierre, "tipoCierre");
            this.tipoCierre.Name = "tipoCierre";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Generar
            // 
            resources.ApplyResources(this.Generar, "Generar");
            this.Generar.Name = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // radioBRojo
            // 
            resources.ApplyResources(this.radioBRojo, "radioBRojo");
            this.radioBRojo.Name = "radioBRojo";
            this.radioBRojo.TabStop = true;
            this.radioBRojo.UseVisualStyleBackColor = true;
            this.radioBRojo.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioBAzul
            // 
            resources.ApplyResources(this.radioBAzul, "radioBAzul");
            this.radioBAzul.Name = "radioBAzul";
            this.radioBAzul.TabStop = true;
            this.radioBAzul.UseVisualStyleBackColor = true;
            this.radioBAzul.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioBVerde
            // 
            resources.ApplyResources(this.radioBVerde, "radioBVerde");
            this.radioBVerde.Name = "radioBVerde";
            this.radioBVerde.TabStop = true;
            this.radioBVerde.UseVisualStyleBackColor = true;
            this.radioBVerde.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cPuntos
            // 
            resources.ApplyResources(this.cPuntos, "cPuntos");
            this.cPuntos.Name = "cPuntos";
            // 
            // GeneraPuntos
            // 
            resources.ApplyResources(this.GeneraPuntos, "GeneraPuntos");
            this.GeneraPuntos.Name = "GeneraPuntos";
            this.GeneraPuntos.UseVisualStyleBackColor = true;
            this.GeneraPuntos.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tiempo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.GeneraPuntos);
            this.groupBox2.Controls.Add(this.cPuntos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioBVerde);
            this.groupBox2.Controls.Add(this.radioBAzul);
            this.groupBox2.Controls.Add(this.radioBRojo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Generar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tipoCierre);
            this.groupBox2.Controls.Add(this.Limpiar);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tiempo
            // 
            resources.ApplyResources(this.tiempo, "tiempo");
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            this.tiempo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list3);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.ListBox list3;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.ComboBox tipoCierre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBRojo;
        private System.Windows.Forms.RadioButton radioBAzul;
        private System.Windows.Forms.RadioButton radioBVerde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox cPuntos;
        private System.Windows.Forms.Button GeneraPuntos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tiempo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

