namespace JogoDaCobrinha
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
            this.components = new System.ComponentModel.Container();
            this.Panel_Screem = new System.Windows.Forms.Panel();
            this.Score_Point = new System.Windows.Forms.Label();
            this.menu_Bar = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Screem
            // 
            this.Panel_Screem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Screem.Location = new System.Drawing.Point(12, 94);
            this.Panel_Screem.Name = "Panel_Screem";
            this.Panel_Screem.Size = new System.Drawing.Size(428, 428);
            this.Panel_Screem.TabIndex = 0;
            // 
            // Score_Point
            // 
            this.Score_Point.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Score_Point.Location = new System.Drawing.Point(12, 54);
            this.Score_Point.Name = "Score_Point";
            this.Score_Point.Size = new System.Drawing.Size(183, 28);
            this.Score_Point.TabIndex = 1;
            this.Score_Point.Text = "Score: 000";
            this.Score_Point.Click += new System.EventHandler(this.label1_Click);
            // 
            // menu_Bar
            // 
            this.menu_Bar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menu_Bar.Location = new System.Drawing.Point(0, 0);
            this.menu_Bar.Name = "menu_Bar";
            this.menu_Bar.Size = new System.Drawing.Size(448, 28);
            this.menu_Bar.TabIndex = 2;
            this.menu_Bar.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarGameToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // iniciarGameToolStripMenuItem
            // 
            this.iniciarGameToolStripMenuItem.Name = "iniciarGameToolStripMenuItem";
            this.iniciarGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iniciarGameToolStripMenuItem.Text = "Iniciar Game";
            this.iniciarGameToolStripMenuItem.Click += new System.EventHandler(this.iniciarGameToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Frame
            // 
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOGameToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sobreOGameToolStripMenuItem
            // 
            this.sobreOGameToolStripMenuItem.Name = "sobreOGameToolStripMenuItem";
            this.sobreOGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sobreOGameToolStripMenuItem.Text = "Sobre o game";
            this.sobreOGameToolStripMenuItem.Click += new System.EventHandler(this.sobreOGameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 549);
            this.Controls.Add(this.Score_Point);
            this.Controls.Add(this.Panel_Screem);
            this.Controls.Add(this.menu_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menu_Bar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Da Cobrinha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Click);
            this.menu_Bar.ResumeLayout(false);
            this.menu_Bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Panel_Screem;
        private Label Score_Point;
        private MenuStrip menu_Bar;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem iniciarGameToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer Frame;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sobreOGameToolStripMenuItem;
    }
}