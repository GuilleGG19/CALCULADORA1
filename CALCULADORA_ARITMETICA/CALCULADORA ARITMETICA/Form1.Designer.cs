namespace CALCULADORA_ARITMETICA
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
            this.textResult = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonmultiplicar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonborrartodo = new System.Windows.Forms.Button();
            this.buttondivision = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonresta = new System.Windows.Forms.Button();
            this.buttonborrar = new System.Windows.Forms.Button();
            this.buttonpunto = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonsuma = new System.Windows.Forms.Button();
            this.buttonigual = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(12, 12);
            this.textResult.MaxLength = 17;
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(284, 42);
            this.textResult.TabIndex = 0;
            this.textResult.Text = "0";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(69, 73);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 52);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(126, 73);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 52);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonmultiplicar
            // 
            this.buttonmultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonmultiplicar.Location = new System.Drawing.Point(189, 131);
            this.buttonmultiplicar.Name = "buttonmultiplicar";
            this.buttonmultiplicar.Size = new System.Drawing.Size(52, 52);
            this.buttonmultiplicar.TabIndex = 4;
            this.buttonmultiplicar.Tag = "*";
            this.buttonmultiplicar.Text = "*";
            this.buttonmultiplicar.UseVisualStyleBackColor = true;
            this.buttonmultiplicar.Click += new System.EventHandler(this.clicoperador);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(126, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 52);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(69, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 52);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(12, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 52);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonborrartodo
            // 
            this.buttonborrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonborrartodo.Location = new System.Drawing.Point(247, 73);
            this.buttonborrartodo.Name = "buttonborrartodo";
            this.buttonborrartodo.Size = new System.Drawing.Size(49, 52);
            this.buttonborrartodo.TabIndex = 8;
            this.buttonborrartodo.Text = "CE";
            this.buttonborrartodo.UseVisualStyleBackColor = true;
            this.buttonborrartodo.Click += new System.EventHandler(this.buttonborrartodo_Click);
            // 
            // buttondivision
            // 
            this.buttondivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttondivision.Location = new System.Drawing.Point(190, 73);
            this.buttondivision.Name = "buttondivision";
            this.buttondivision.Size = new System.Drawing.Size(51, 52);
            this.buttondivision.TabIndex = 9;
            this.buttondivision.Tag = "/";
            this.buttondivision.Text = "/";
            this.buttondivision.UseVisualStyleBackColor = true;
            this.buttondivision.Click += new System.EventHandler(this.clicoperador);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonresta
            // 
            this.buttonresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonresta.Location = new System.Drawing.Point(189, 189);
            this.buttonresta.Name = "buttonresta";
            this.buttonresta.Size = new System.Drawing.Size(51, 52);
            this.buttonresta.TabIndex = 11;
            this.buttonresta.Tag = "-";
            this.buttonresta.Text = "-";
            this.buttonresta.UseVisualStyleBackColor = true;
            this.buttonresta.Click += new System.EventHandler(this.clicoperador);
            // 
            // buttonborrar
            // 
            this.buttonborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonborrar.Location = new System.Drawing.Point(245, 131);
            this.buttonborrar.Name = "buttonborrar";
            this.buttonborrar.Size = new System.Drawing.Size(51, 52);
            this.buttonborrar.TabIndex = 12;
            this.buttonborrar.Text = "C";
            this.buttonborrar.UseVisualStyleBackColor = true;
            this.buttonborrar.Click += new System.EventHandler(this.buttonborrar_Click);
            // 
            // buttonpunto
            // 
            this.buttonpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpunto.Location = new System.Drawing.Point(126, 247);
            this.buttonpunto.Name = "buttonpunto";
            this.buttonpunto.Size = new System.Drawing.Size(51, 52);
            this.buttonpunto.TabIndex = 13;
            this.buttonpunto.Text = ".";
            this.buttonpunto.UseVisualStyleBackColor = true;
            this.buttonpunto.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button00
            // 
            this.button00.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button00.Location = new System.Drawing.Point(12, 247);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(108, 52);
            this.button00.TabIndex = 14;
            this.button00.Text = "0";
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(126, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 52);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(69, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonsuma
            // 
            this.buttonsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonsuma.Location = new System.Drawing.Point(190, 246);
            this.buttonsuma.Name = "buttonsuma";
            this.buttonsuma.Size = new System.Drawing.Size(51, 52);
            this.buttonsuma.TabIndex = 17;
            this.buttonsuma.Tag = "+";
            this.buttonsuma.Text = "+";
            this.buttonsuma.UseVisualStyleBackColor = true;
            this.buttonsuma.Click += new System.EventHandler(this.clicoperador);
            // 
            // buttonigual
            // 
            this.buttonigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonigual.Location = new System.Drawing.Point(247, 189);
            this.buttonigual.Name = "buttonigual";
            this.buttonigual.Size = new System.Drawing.Size(51, 110);
            this.buttonigual.TabIndex = 18;
            this.buttonigual.Text = "=";
            this.buttonigual.UseVisualStyleBackColor = true;
            this.buttonigual.Click += new System.EventHandler(this.buttonigual_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(12, 72);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 52);
            this.button7.TabIndex = 19;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 308);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonigual);
            this.Controls.Add(this.buttonsuma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button00);
            this.Controls.Add(this.buttonpunto);
            this.Controls.Add(this.buttonborrar);
            this.Controls.Add(this.buttonresta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttondivision);
            this.Controls.Add(this.buttonborrartodo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonmultiplicar);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textResult);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonmultiplicar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonborrartodo;
        private System.Windows.Forms.Button buttondivision;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonresta;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.Button buttonpunto;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonsuma;
        private System.Windows.Forms.Button buttonigual;
        private System.Windows.Forms.Button button7;
    }
}

