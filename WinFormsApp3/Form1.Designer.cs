namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEstrato = new TextBox();
            label3 = new Label();
            txtConsumo = new TextBox();
            btnCalcular = new Button();
            lblCargoFijoValor = new Label();
            lblValorConsumoValor = new Label();
            lblBasurasValor = new Label();
            lblTotalValor = new Label();
            groupResultadoFactura = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupResultadoFactura.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 0);
            label1.Name = "label1";
            label1.Size = new Size(428, 45);
            label1.TabIndex = 0;
            label1.Text = "Factura de Agua por Estrato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 105);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el estrato (1 - 6):\r\n";
            // 
            // txtEstrato
            // 
            txtEstrato.Location = new Point(343, 102);
            txtEstrato.Name = "txtEstrato";
            txtEstrato.Size = new Size(100, 23);
            txtEstrato.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 145);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 3;
            label3.Text = "Consumo de agua (m³):\r\n";
            // 
            // txtConsumo
            // 
            txtConsumo.Location = new Point(343, 145);
            txtConsumo.Name = "txtConsumo";
            txtConsumo.Size = new Size(100, 23);
            txtConsumo.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(343, 196);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular factura";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCargoFijoValor
            // 
            lblCargoFijoValor.AutoSize = true;
            lblCargoFijoValor.Location = new Point(92, 40);
            lblCargoFijoValor.Name = "lblCargoFijoValor";
            lblCargoFijoValor.Size = new Size(16, 15);
            lblCargoFijoValor.TabIndex = 6;
            lblCargoFijoValor.Text = " $";
            lblCargoFijoValor.Click += lblCargoFijoValor_Click;
            // 
            // lblValorConsumoValor
            // 
            lblValorConsumoValor.AutoSize = true;
            lblValorConsumoValor.Location = new Point(122, 93);
            lblValorConsumoValor.Name = "lblValorConsumoValor";
            lblValorConsumoValor.Size = new Size(13, 15);
            lblValorConsumoValor.TabIndex = 7;
            lblValorConsumoValor.Text = "$";
            lblValorConsumoValor.Click += lblValorConsumoValor_Click;
            // 
            // lblBasurasValor
            // 
            lblBasurasValor.AutoSize = true;
            lblBasurasValor.Location = new Point(389, 40);
            lblBasurasValor.Name = "lblBasurasValor";
            lblBasurasValor.Size = new Size(13, 15);
            lblBasurasValor.TabIndex = 8;
            lblBasurasValor.Text = "$";
            lblBasurasValor.Click += lblBasurasValor_Click;
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalValor.Location = new Point(376, 93);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(14, 15);
            lblTotalValor.TabIndex = 9;
            lblTotalValor.Text = "$";
            // 
            // groupResultadoFactura
            // 
            groupResultadoFactura.Controls.Add(label7);
            groupResultadoFactura.Controls.Add(label6);
            groupResultadoFactura.Controls.Add(label5);
            groupResultadoFactura.Controls.Add(label4);
            groupResultadoFactura.Controls.Add(lblCargoFijoValor);
            groupResultadoFactura.Controls.Add(lblTotalValor);
            groupResultadoFactura.Controls.Add(lblValorConsumoValor);
            groupResultadoFactura.Controls.Add(lblBasurasValor);
            groupResultadoFactura.Location = new Point(99, 239);
            groupResultadoFactura.Name = "groupResultadoFactura";
            groupResultadoFactura.Size = new Size(522, 185);
            groupResultadoFactura.TabIndex = 10;
            groupResultadoFactura.TabStop = false;
            groupResultadoFactura.Text = "Resultado de la Factura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(275, 93);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 13;
            label7.Text = "TOTAL A PAGAR:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 40);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 12;
            label6.Text = "Basuras y alcantarillado:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 93);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 11;
            label5.Text = "Valor por consumo:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 40);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "Cargo fijo:\r\n";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 504);
            Controls.Add(groupResultadoFactura);
            Controls.Add(btnCalcular);
            Controls.Add(txtConsumo);
            Controls.Add(label3);
            Controls.Add(txtEstrato);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupResultadoFactura.ResumeLayout(false);
            groupResultadoFactura.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEstrato;
        private Label label3;
        private TextBox txtConsumo;
        private Button btnCalcular;
        private Label lblCargoFijoValor;
        private Label lblValorConsumoValor;
        private Label lblBasurasValor;
        private Label lblTotalValor;
        private GroupBox groupResultadoFactura;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}
