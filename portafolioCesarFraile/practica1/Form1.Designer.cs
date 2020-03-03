namespace practica1
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtexamen1 = new System.Windows.Forms.TextBox();
            this.txtexamen2 = new System.Windows.Forms.TextBox();
            this.txtexamen3 = new System.Windows.Forms.TextBox();
            this.txtexamen4 = new System.Windows.Forms.TextBox();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "examen1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "examen2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "examen3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "examen4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "promedio";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(130, 249);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(255, 249);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 6;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(374, 248);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtexamen1
            // 
            this.txtexamen1.Location = new System.Drawing.Point(214, 13);
            this.txtexamen1.Name = "txtexamen1";
            this.txtexamen1.Size = new System.Drawing.Size(100, 20);
            this.txtexamen1.TabIndex = 8;
            // 
            // txtexamen2
            // 
            this.txtexamen2.Location = new System.Drawing.Point(214, 50);
            this.txtexamen2.Name = "txtexamen2";
            this.txtexamen2.Size = new System.Drawing.Size(100, 20);
            this.txtexamen2.TabIndex = 9;
            // 
            // txtexamen3
            // 
            this.txtexamen3.Location = new System.Drawing.Point(214, 101);
            this.txtexamen3.Name = "txtexamen3";
            this.txtexamen3.Size = new System.Drawing.Size(100, 20);
            this.txtexamen3.TabIndex = 10;
            // 
            // txtexamen4
            // 
            this.txtexamen4.Location = new System.Drawing.Point(214, 144);
            this.txtexamen4.Name = "txtexamen4";
            this.txtexamen4.Size = new System.Drawing.Size(100, 20);
            this.txtexamen4.TabIndex = 11;
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(214, 191);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(100, 20);
            this.txtpromedio.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.txtexamen4);
            this.Controls.Add(this.txtexamen3);
            this.Controls.Add(this.txtexamen2);
            this.Controls.Add(this.txtexamen1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
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
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtexamen1;
        private System.Windows.Forms.TextBox txtexamen2;
        private System.Windows.Forms.TextBox txtexamen3;
        private System.Windows.Forms.TextBox txtexamen4;
        private System.Windows.Forms.TextBox txtpromedio;
    }
}

