namespace ejercicio3
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
            this.txtporc1 = new System.Windows.Forms.TextBox();
            this.txtinver3 = new System.Windows.Forms.TextBox();
            this.txtinver2 = new System.Windows.Forms.TextBox();
            this.txtinver1 = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtporc3 = new System.Windows.Forms.TextBox();
            this.txtporc2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "invercionistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "porcentajes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1";
            // 
            // txtporc1
            // 
            this.txtporc1.Location = new System.Drawing.Point(318, 89);
            this.txtporc1.Name = "txtporc1";
            this.txtporc1.Size = new System.Drawing.Size(100, 20);
            this.txtporc1.TabIndex = 3;
            // 
            // txtinver3
            // 
            this.txtinver3.Location = new System.Drawing.Point(54, 199);
            this.txtinver3.Name = "txtinver3";
            this.txtinver3.Size = new System.Drawing.Size(100, 20);
            this.txtinver3.TabIndex = 4;
            // 
            // txtinver2
            // 
            this.txtinver2.Location = new System.Drawing.Point(54, 139);
            this.txtinver2.Name = "txtinver2";
            this.txtinver2.Size = new System.Drawing.Size(100, 20);
            this.txtinver2.TabIndex = 5;
            // 
            // txtinver1
            // 
            this.txtinver1.Location = new System.Drawing.Point(54, 89);
            this.txtinver1.Name = "txtinver1";
            this.txtinver1.Size = new System.Drawing.Size(100, 20);
            this.txtinver1.TabIndex = 6;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(54, 302);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 7;
            // 
            // txtporc3
            // 
            this.txtporc3.Location = new System.Drawing.Point(318, 199);
            this.txtporc3.Name = "txtporc3";
            this.txtporc3.Size = new System.Drawing.Size(100, 20);
            this.txtporc3.TabIndex = 8;
            // 
            // txtporc2
            // 
            this.txtporc2.Location = new System.Drawing.Point(318, 139);
            this.txtporc2.Name = "txtporc2";
            this.txtporc2.Size = new System.Drawing.Size(100, 20);
            this.txtporc2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "total invercion";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(54, 361);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(181, 361);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 14;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(318, 361);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtporc2);
            this.Controls.Add(this.txtporc3);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtinver1);
            this.Controls.Add(this.txtinver2);
            this.Controls.Add(this.txtinver3);
            this.Controls.Add(this.txtporc1);
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
        private System.Windows.Forms.TextBox txtporc1;
        private System.Windows.Forms.TextBox txtinver3;
        private System.Windows.Forms.TextBox txtinver2;
        private System.Windows.Forms.TextBox txtinver1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtporc3;
        private System.Windows.Forms.TextBox txtporc2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

