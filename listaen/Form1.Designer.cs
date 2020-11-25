namespace listaen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textmatri = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textApater = new System.Windows.Forms.TextBox();
            this.textAMater = new System.Windows.Forms.TextBox();
            this.textDirecc = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.richlista = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apelldio Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion:";
            // 
            // textmatri
            // 
            this.textmatri.Location = new System.Drawing.Point(148, 59);
            this.textmatri.Name = "textmatri";
            this.textmatri.Size = new System.Drawing.Size(100, 20);
            this.textmatri.TabIndex = 5;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(148, 107);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(100, 20);
            this.textnombre.TabIndex = 6;
            // 
            // textApater
            // 
            this.textApater.Location = new System.Drawing.Point(148, 153);
            this.textApater.Name = "textApater";
            this.textApater.Size = new System.Drawing.Size(100, 20);
            this.textApater.TabIndex = 7;
            // 
            // textAMater
            // 
            this.textAMater.Location = new System.Drawing.Point(148, 191);
            this.textAMater.Name = "textAMater";
            this.textAMater.Size = new System.Drawing.Size(100, 20);
            this.textAMater.TabIndex = 8;
            // 
            // textDirecc
            // 
            this.textDirecc.Location = new System.Drawing.Point(148, 235);
            this.textDirecc.Multiline = true;
            this.textDirecc.Name = "textDirecc";
            this.textDirecc.Size = new System.Drawing.Size(180, 56);
            this.textDirecc.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(31, 320);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(148, 320);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(281, 320);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 15;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // richlista
            // 
            this.richlista.Location = new System.Drawing.Point(486, 36);
            this.richlista.Name = "richlista";
            this.richlista.Size = new System.Drawing.Size(230, 306);
            this.richlista.TabIndex = 16;
            this.richlista.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richlista);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textDirecc);
            this.Controls.Add(this.textAMater);
            this.Controls.Add(this.textApater);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textmatri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textmatri;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textApater;
        private System.Windows.Forms.TextBox textAMater;
        private System.Windows.Forms.TextBox textDirecc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.RichTextBox richlista;
    }
}

