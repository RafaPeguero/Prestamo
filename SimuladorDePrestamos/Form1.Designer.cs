namespace SimuladorDePrestamos
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.nudCuotas = new System.Windows.Forms.NumericUpDown();
            this.txtTasaPrestamo = new System.Windows.Forms.TextBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstCapitalRestante = new System.Windows.Forms.ListBox();
            this.lstCapitalAcumulado = new System.Windows.Forms.ListBox();
            this.lstMontoCuota = new System.Windows.Forms.ListBox();
            this.lstInteresCuota = new System.Windows.Forms.ListBox();
            this.lstCapitalCuota = new System.Windows.Forms.ListBox();
            this.lstNumCuota = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdCalcular);
            this.panel1.Controls.Add(this.nudCuotas);
            this.panel1.Controls.Add(this.txtTasaPrestamo);
            this.panel1.Controls.Add(this.txtMontoPrestamo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 147);
            this.panel1.TabIndex = 0;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.BackgroundImage = global::SimuladorDePrestamos.Properties.Resources.índice;
            this.cmdCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCalcular.Location = new System.Drawing.Point(320, 16);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(124, 95);
            this.cmdCalcular.TabIndex = 6;
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // nudCuotas
            // 
            this.nudCuotas.Location = new System.Drawing.Point(135, 89);
            this.nudCuotas.Maximum = new decimal(new int[] {
            260,
            0,
            0,
            0});
            this.nudCuotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCuotas.Name = "nudCuotas";
            this.nudCuotas.Size = new System.Drawing.Size(120, 20);
            this.nudCuotas.TabIndex = 5;
            this.nudCuotas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCuotas.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtTasaPrestamo
            // 
            this.txtTasaPrestamo.Location = new System.Drawing.Point(135, 54);
            this.txtTasaPrestamo.Name = "txtTasaPrestamo";
            this.txtTasaPrestamo.Size = new System.Drawing.Size(121, 20);
            this.txtTasaPrestamo.TabIndex = 4;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(135, 20);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(121, 20);
            this.txtMontoPrestamo.TabIndex = 3;
            this.txtMontoPrestamo.TextChanged += new System.EventHandler(this.txtMontoPrestamo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa Interes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto Prestamo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstCapitalRestante);
            this.panel2.Controls.Add(this.lstCapitalAcumulado);
            this.panel2.Controls.Add(this.lstMontoCuota);
            this.panel2.Controls.Add(this.lstInteresCuota);
            this.panel2.Controls.Add(this.lstCapitalCuota);
            this.panel2.Controls.Add(this.lstNumCuota);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(13, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 436);
            this.panel2.TabIndex = 1;
            // 
            // lstCapitalRestante
            // 
            this.lstCapitalRestante.FormattingEnabled = true;
            this.lstCapitalRestante.Location = new System.Drawing.Point(768, 78);
            this.lstCapitalRestante.Name = "lstCapitalRestante";
            this.lstCapitalRestante.Size = new System.Drawing.Size(120, 342);
            this.lstCapitalRestante.TabIndex = 14;
            // 
            // lstCapitalAcumulado
            // 
            this.lstCapitalAcumulado.FormattingEnabled = true;
            this.lstCapitalAcumulado.Location = new System.Drawing.Point(611, 78);
            this.lstCapitalAcumulado.Name = "lstCapitalAcumulado";
            this.lstCapitalAcumulado.Size = new System.Drawing.Size(120, 342);
            this.lstCapitalAcumulado.TabIndex = 13;
            // 
            // lstMontoCuota
            // 
            this.lstMontoCuota.FormattingEnabled = true;
            this.lstMontoCuota.Location = new System.Drawing.Point(468, 78);
            this.lstMontoCuota.Name = "lstMontoCuota";
            this.lstMontoCuota.Size = new System.Drawing.Size(120, 342);
            this.lstMontoCuota.TabIndex = 12;
            // 
            // lstInteresCuota
            // 
            this.lstInteresCuota.FormattingEnabled = true;
            this.lstInteresCuota.Location = new System.Drawing.Point(320, 78);
            this.lstInteresCuota.Name = "lstInteresCuota";
            this.lstInteresCuota.Size = new System.Drawing.Size(120, 342);
            this.lstInteresCuota.TabIndex = 11;
            // 
            // lstCapitalCuota
            // 
            this.lstCapitalCuota.FormattingEnabled = true;
            this.lstCapitalCuota.Location = new System.Drawing.Point(170, 78);
            this.lstCapitalCuota.Name = "lstCapitalCuota";
            this.lstCapitalCuota.Size = new System.Drawing.Size(120, 342);
            this.lstCapitalCuota.TabIndex = 10;
            // 
            // lstNumCuota
            // 
            this.lstNumCuota.FormattingEnabled = true;
            this.lstNumCuota.Location = new System.Drawing.Point(6, 78);
            this.lstNumCuota.Name = "lstNumCuota";
            this.lstNumCuota.Size = new System.Drawing.Size(120, 342);
            this.lstNumCuota.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Capital Acumulado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(786, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Capital Restante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Num Cuota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Capital Cuota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Monto Cuota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Interes Cuota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Simulador de prestamo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.NumericUpDown nudCuotas;
        private System.Windows.Forms.TextBox txtTasaPrestamo;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstCapitalRestante;
        private System.Windows.Forms.ListBox lstCapitalAcumulado;
        private System.Windows.Forms.ListBox lstMontoCuota;
        private System.Windows.Forms.ListBox lstInteresCuota;
        private System.Windows.Forms.ListBox lstCapitalCuota;
        private System.Windows.Forms.ListBox lstNumCuota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

