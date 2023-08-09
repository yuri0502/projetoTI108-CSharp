
namespace PadariaCarmel
{
    partial class frmPesquisarFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFuncionarios));
            this.grbPesquisar = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.rbdNome = new System.Windows.Forms.RadioButton();
            this.rbdCodigo = new System.Windows.Forms.RadioButton();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lstPesquisar = new System.Windows.Forms.ListBox();
            this.bntPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPesquisar
            // 
            this.grbPesquisar.Controls.Add(this.txtDescricao);
            this.grbPesquisar.Controls.Add(this.rbdNome);
            this.grbPesquisar.Controls.Add(this.rbdCodigo);
            this.grbPesquisar.Controls.Add(this.lbldescricao);
            this.grbPesquisar.Location = new System.Drawing.Point(5, 5);
            this.grbPesquisar.Name = "grbPesquisar";
            this.grbPesquisar.Size = new System.Drawing.Size(494, 178);
            this.grbPesquisar.TabIndex = 0;
            this.grbPesquisar.TabStop = false;
            this.grbPesquisar.Text = "Pesquisar Por";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(163, 112);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(312, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // rbdNome
            // 
            this.rbdNome.AutoSize = true;
            this.rbdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdNome.Location = new System.Drawing.Point(258, 41);
            this.rbdNome.Name = "rbdNome";
            this.rbdNome.Size = new System.Drawing.Size(71, 22);
            this.rbdNome.TabIndex = 2;
            this.rbdNome.Text = "Nome";
            this.rbdNome.UseVisualStyleBackColor = true;
            // 
            // rbdCodigo
            // 
            this.rbdCodigo.AutoSize = true;
            this.rbdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdCodigo.Location = new System.Drawing.Point(66, 36);
            this.rbdCodigo.Name = "rbdCodigo";
            this.rbdCodigo.Size = new System.Drawing.Size(80, 22);
            this.rbdCodigo.TabIndex = 1;
            this.rbdCodigo.Text = "Código";
            this.rbdCodigo.UseVisualStyleBackColor = true;
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(63, 110);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(94, 20);
            this.lbldescricao.TabIndex = 0;
            this.lbldescricao.Text = "Descrição:";
            // 
            // lstPesquisar
            // 
            this.lstPesquisar.FormattingEnabled = true;
            this.lstPesquisar.Location = new System.Drawing.Point(5, 232);
            this.lstPesquisar.Name = "lstPesquisar";
            this.lstPesquisar.Size = new System.Drawing.Size(494, 160);
            this.lstPesquisar.TabIndex = 5;
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("bntPesquisar.Image")));
            this.bntPesquisar.Location = new System.Drawing.Point(540, 28);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(148, 128);
            this.bntPesquisar.TabIndex = 4;
            this.bntPesquisar.Text = "Pesquisar";
            this.bntPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntPesquisar.UseVisualStyleBackColor = true;
            this.bntPesquisar.Click += new System.EventHandler(this.bntPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(540, 243);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(148, 128);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPesquisarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.bntPesquisar);
            this.Controls.Add(this.lstPesquisar);
            this.Controls.Add(this.grbPesquisar);
            this.Name = "frmPesquisarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - PesquisarFuncionários";
            this.grbPesquisar.ResumeLayout(false);
            this.grbPesquisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.RadioButton rbdNome;
        private System.Windows.Forms.RadioButton rbdCodigo;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.ListBox lstPesquisar;
        private System.Windows.Forms.Button bntPesquisar;
        private System.Windows.Forms.Button btnLimpar;
    }
}