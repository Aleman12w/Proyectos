namespace proyectoEVALUCACION1_Antonio_Aleman
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
            this.PupusasCantidad = new System.Windows.Forms.TextBox();
            this.PupusasPrecio = new System.Windows.Forms.TextBox();
            this.BebidasCantidad = new System.Windows.Forms.TextBox();
            this.BebidasPrecio = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Pupusas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio de pupusas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Bebidas\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pupuseria Aleman ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de Bebidas";
            // 
            // PupusasCantidad
            // 
            this.PupusasCantidad.Location = new System.Drawing.Point(264, 126);
            this.PupusasCantidad.Name = "PupusasCantidad";
            this.PupusasCantidad.Size = new System.Drawing.Size(100, 20);
            this.PupusasCantidad.TabIndex = 5;
            this.PupusasCantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PupusasPrecio
            // 
            this.PupusasPrecio.Location = new System.Drawing.Point(264, 179);
            this.PupusasPrecio.Name = "PupusasPrecio";
            this.PupusasPrecio.Size = new System.Drawing.Size(100, 20);
            this.PupusasPrecio.TabIndex = 6;
            // 
            // BebidasCantidad
            // 
            this.BebidasCantidad.Location = new System.Drawing.Point(264, 232);
            this.BebidasCantidad.Name = "BebidasCantidad";
            this.BebidasCantidad.Size = new System.Drawing.Size(100, 20);
            this.BebidasCantidad.TabIndex = 7;
            // 
            // BebidasPrecio
            // 
            this.BebidasPrecio.Location = new System.Drawing.Point(264, 286);
            this.BebidasPrecio.Name = "BebidasPrecio";
            this.BebidasPrecio.Size = new System.Drawing.Size(100, 20);
            this.BebidasPrecio.TabIndex = 8;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(141, 353);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 20);
            this.Total.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.BebidasPrecio);
            this.Controls.Add(this.BebidasCantidad);
            this.Controls.Add(this.PupusasPrecio);
            this.Controls.Add(this.PupusasCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PupusasCantidad;
        private System.Windows.Forms.TextBox PupusasPrecio;
        private System.Windows.Forms.TextBox BebidasCantidad;
        private System.Windows.Forms.TextBox BebidasPrecio;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Button button1;
    }
}

