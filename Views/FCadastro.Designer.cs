
namespace CRUD.Views
{
    partial class FCadastro
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
            this.LId = new System.Windows.Forms.Label();
            this.LNome = new System.Windows.Forms.Label();
            this.LSite = new System.Windows.Forms.Label();
            this.LQtd = new System.Windows.Forms.Label();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtSite = new System.Windows.Forms.TextBox();
            this.TxtQtdFunc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LId
            // 
            this.LId.AutoSize = true;
            this.LId.Location = new System.Drawing.Point(150, 37);
            this.LId.Name = "LId";
            this.LId.Size = new System.Drawing.Size(21, 15);
            this.LId.TabIndex = 0;
            this.LId.Text = "ID:";
            // 
            // LNome
            // 
            this.LNome.AutoSize = true;
            this.LNome.Location = new System.Drawing.Point(128, 67);
            this.LNome.Name = "LNome";
            this.LNome.Size = new System.Drawing.Size(43, 15);
            this.LNome.TabIndex = 1;
            this.LNome.Text = "Nome:";
            // 
            // LSite
            // 
            this.LSite.AutoSize = true;
            this.LSite.Location = new System.Drawing.Point(142, 98);
            this.LSite.Name = "LSite";
            this.LSite.Size = new System.Drawing.Size(29, 15);
            this.LSite.TabIndex = 2;
            this.LSite.Text = "Site:";
            // 
            // LQtd
            // 
            this.LQtd.AutoSize = true;
            this.LQtd.Location = new System.Drawing.Point(12, 124);
            this.LQtd.Name = "LQtd";
            this.LQtd.Size = new System.Drawing.Size(159, 15);
            this.LQtd.TabIndex = 3;
            this.LQtd.Text = "Quantidade de Funcionários:";
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(621, 29);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 4;
            this.BtnGravar.Text = "Incluir";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(621, 59);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(177, 29);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(94, 23);
            this.TxtId.TabIndex = 0;
            this.TxtId.Leave += new System.EventHandler(this.TxtId_Leave);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(177, 58);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(320, 23);
            this.TxtNome.TabIndex = 1;
            // 
            // TxtSite
            // 
            this.TxtSite.Location = new System.Drawing.Point(177, 87);
            this.TxtSite.Name = "TxtSite";
            this.TxtSite.Size = new System.Drawing.Size(320, 23);
            this.TxtSite.TabIndex = 2;
            // 
            // TxtQtdFunc
            // 
            this.TxtQtdFunc.Location = new System.Drawing.Point(177, 116);
            this.TxtQtdFunc.Name = "TxtQtdFunc";
            this.TxtQtdFunc.Size = new System.Drawing.Size(320, 23);
            this.TxtQtdFunc.TabIndex = 3;
            // 
            // FCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtQtdFunc);
            this.Controls.Add(this.TxtSite);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.LQtd);
            this.Controls.Add(this.LSite);
            this.Controls.Add(this.LNome);
            this.Controls.Add(this.LId);
            this.Name = "FCadastro";
            this.Text = "Cadastro - Empresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FCadastro_FormClosed);
            this.Load += new System.EventHandler(this.FCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LId;
        private System.Windows.Forms.Label LNome;
        private System.Windows.Forms.Label LSite;
        private System.Windows.Forms.Label LQtd;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtSite;
        private System.Windows.Forms.TextBox TxtQtdFunc;
    }
}