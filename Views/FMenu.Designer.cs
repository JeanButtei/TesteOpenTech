
namespace CRUD
{
    partial class FMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmpresa});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuEmpresa
            // 
            this.menuEmpresa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.toolStripSeparator1,
            this.menuSair});
            this.menuEmpresa.Name = "menuEmpresa";
            this.menuEmpresa.Size = new System.Drawing.Size(64, 20);
            this.menuEmpresa.Text = "Empresa";
            // 
            // menuCadastro
            // 
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(121, 22);
            this.menuCadastro.Text = "Cadastro";
            this.menuCadastro.Click += new System.EventHandler(this.menuCadastro_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(121, 22);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Name = "FMenu";
            this.Text = "CRUD Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuEmpresa;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
    }
}

