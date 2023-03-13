namespace WinFormsApp1
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
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDTrabalhados = new System.Windows.Forms.TextBox();
            this.txtVDiaria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSBase = new System.Windows.Forms.TextBox();
            this.txtValorIR = new System.Windows.Forms.TextBox();
            this.txtSLiquido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(115, 28);
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(138, 23);
            this.mtxtCPF.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtDTrabalhados
            // 
            this.txtDTrabalhados.Location = new System.Drawing.Point(115, 116);
            this.txtDTrabalhados.Name = "txtDTrabalhados";
            this.txtDTrabalhados.Size = new System.Drawing.Size(100, 23);
            this.txtDTrabalhados.TabIndex = 2;
            // 
            // txtVDiaria
            // 
            this.txtVDiaria.Location = new System.Drawing.Point(115, 157);
            this.txtVDiaria.Name = "txtVDiaria";
            this.txtVDiaria.Size = new System.Drawing.Size(100, 23);
            this.txtVDiaria.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salário Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dias Trabalhados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor de Diária";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Salário Líquido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Valor do IR";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(307, 156);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSBase
            // 
            this.txtSBase.Location = new System.Drawing.Point(451, 36);
            this.txtSBase.Name = "txtSBase";
            this.txtSBase.ReadOnly = true;
            this.txtSBase.Size = new System.Drawing.Size(100, 23);
            this.txtSBase.TabIndex = 12;
            // 
            // txtValorIR
            // 
            this.txtValorIR.Location = new System.Drawing.Point(451, 65);
            this.txtValorIR.Name = "txtValorIR";
            this.txtValorIR.ReadOnly = true;
            this.txtValorIR.Size = new System.Drawing.Size(100, 23);
            this.txtValorIR.TabIndex = 13;
            // 
            // txtSLiquido
            // 
            this.txtSLiquido.Location = new System.Drawing.Point(451, 95);
            this.txtSLiquido.Name = "txtSLiquido";
            this.txtSLiquido.ReadOnly = true;
            this.txtSLiquido.Size = new System.Drawing.Size(100, 23);
            this.txtSLiquido.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 222);
            this.Controls.Add(this.txtSLiquido);
            this.Controls.Add(this.txtValorIR);
            this.Controls.Add(this.txtSBase);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVDiaria);
            this.Controls.Add(this.txtDTrabalhados);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mtxtCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox mtxtCPF;
        private TextBox txtNome;
        private TextBox txtDTrabalhados;
        private TextBox txtVDiaria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCalcular;
        private TextBox txtSBase;
        private TextBox txtValorIR;
        private TextBox txtSLiquido;
    }
}