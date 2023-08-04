
namespace PadariaCarmel
{
    partial class frmCalculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculas));
            this.gpbOperacoes = new System.Windows.Forms.GroupBox();
            this.radDivisao = new System.Windows.Forms.RadioButton();
            this.radMultiplicacao = new System.Windows.Forms.RadioButton();
            this.radSubitracao = new System.Windows.Forms.RadioButton();
            this.radSoma = new System.Windows.Forms.RadioButton();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.gpbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOperacoes
            // 
            this.gpbOperacoes.Controls.Add(this.radDivisao);
            this.gpbOperacoes.Controls.Add(this.radMultiplicacao);
            this.gpbOperacoes.Controls.Add(this.radSubitracao);
            this.gpbOperacoes.Controls.Add(this.radSoma);
            this.gpbOperacoes.Location = new System.Drawing.Point(220, 112);
            this.gpbOperacoes.Margin = new System.Windows.Forms.Padding(4);
            this.gpbOperacoes.Name = "gpbOperacoes";
            this.gpbOperacoes.Padding = new System.Windows.Forms.Padding(4);
            this.gpbOperacoes.Size = new System.Drawing.Size(416, 302);
            this.gpbOperacoes.TabIndex = 2;
            this.gpbOperacoes.TabStop = false;
            this.gpbOperacoes.Text = "Operações";
            // 
            // radDivisao
            // 
            this.radDivisao.AutoSize = true;
            this.radDivisao.Location = new System.Drawing.Point(39, 256);
            this.radDivisao.Margin = new System.Windows.Forms.Padding(4);
            this.radDivisao.Name = "radDivisao";
            this.radDivisao.Size = new System.Drawing.Size(72, 20);
            this.radDivisao.TabIndex = 6;
            this.radDivisao.TabStop = true;
            this.radDivisao.Text = "Divisão";
            this.radDivisao.UseVisualStyleBackColor = true;
            // 
            // radMultiplicacao
            // 
            this.radMultiplicacao.AutoSize = true;
            this.radMultiplicacao.Location = new System.Drawing.Point(39, 176);
            this.radMultiplicacao.Margin = new System.Windows.Forms.Padding(4);
            this.radMultiplicacao.Name = "radMultiplicacao";
            this.radMultiplicacao.Size = new System.Drawing.Size(105, 20);
            this.radMultiplicacao.TabIndex = 5;
            this.radMultiplicacao.TabStop = true;
            this.radMultiplicacao.Text = "Multiplicação";
            this.radMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radSubitracao
            // 
            this.radSubitracao.AutoSize = true;
            this.radSubitracao.Location = new System.Drawing.Point(39, 103);
            this.radSubitracao.Margin = new System.Windows.Forms.Padding(4);
            this.radSubitracao.Name = "radSubitracao";
            this.radSubitracao.Size = new System.Drawing.Size(91, 20);
            this.radSubitracao.TabIndex = 4;
            this.radSubitracao.TabStop = true;
            this.radSubitracao.Text = "Subitração";
            this.radSubitracao.UseVisualStyleBackColor = true;
            // 
            // radSoma
            // 
            this.radSoma.AutoSize = true;
            this.radSoma.Location = new System.Drawing.Point(39, 44);
            this.radSoma.Margin = new System.Windows.Forms.Padding(4);
            this.radSoma.Name = "radSoma";
            this.radSoma.Size = new System.Drawing.Size(62, 20);
            this.radSoma.TabIndex = 3;
            this.radSoma.TabStop = true;
            this.radSoma.Text = "Soma";
            this.radSoma.UseVisualStyleBackColor = true;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(51, 255);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum2.MaxLength = 10;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(99, 22);
            this.txtNum2.TabIndex = 1;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(51, 133);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum1.MaxLength = 10;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(99, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(56, 110);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 16);
            this.lblNumero.TabIndex = 20;
            this.lblNumero.Text = "Número 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(47, 212);
            this.lblNumero2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(63, 16);
            this.lblNumero2.TabIndex = 21;
            this.lblNumero2.Text = "Número2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(687, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Calcular";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(687, 232);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "&Limpar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(687, 337);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sai&r";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(51, 308);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 16);
            this.lblResultado.TabIndex = 23;
            this.lblResultado.Text = "Resultado";
            // 
            // lblResposta
            // 
            this.lblResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResposta.Location = new System.Drawing.Point(50, 337);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(94, 20);
            this.lblResposta.TabIndex = 24;
            // 
            // frmCalculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 479);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.gpbOperacoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCalculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Calculadora";
            this.gpbOperacoes.ResumeLayout(false);
            this.gpbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOperacoes;
        private System.Windows.Forms.RadioButton radDivisao;
        private System.Windows.Forms.RadioButton radMultiplicacao;
        private System.Windows.Forms.RadioButton radSubitracao;
        private System.Windows.Forms.RadioButton radSoma;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResposta;
    }
}