namespace Conversor_Moedas_IF
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEscolha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEscolha2 = new System.Windows.Forms.ComboBox();
            this.txtValorRec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUAL MOEDA EU CONVERTEREI?";
            // 
            // btnEscolha
            // 
            this.btnEscolha.FormattingEnabled = true;
            this.btnEscolha.Location = new System.Drawing.Point(21, 39);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(185, 21);
            this.btnEscolha.TabIndex = 3;
            this.btnEscolha.Text = "Escolha abaixo...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PARA QUAL DESEJA CONVERTER?";
            // 
            // btnEscolha2
            // 
            this.btnEscolha2.FormattingEnabled = true;
            this.btnEscolha2.Location = new System.Drawing.Point(21, 191);
            this.btnEscolha2.Name = "btnEscolha2";
            this.btnEscolha2.Size = new System.Drawing.Size(185, 21);
            this.btnEscolha2.TabIndex = 6;
            this.btnEscolha2.Text = "Escolha abaixo...";
            // 
            // txtValorRec
            // 
            this.txtValorRec.Location = new System.Drawing.Point(22, 113);
            this.txtValorRec.Name = "txtValorRec";
            this.txtValorRec.Size = new System.Drawing.Size(184, 20);
            this.txtValorRec.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUAL O VALOR A SER CONVERTIDO?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(55, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "CONVERTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(22, 327);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(0, 13);
            this.txtResultado.TabIndex = 10;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Location = new System.Drawing.Point(25, 219);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(0, 13);
            this.txtInfo.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 450);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorRec);
            this.Controls.Add(this.btnEscolha2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CONVERSOR DE MOEDAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox btnEscolha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox btnEscolha2;
        private System.Windows.Forms.TextBox txtValorRec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.Label txtInfo;
    }
}

