namespace prilog
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem1,
            this.клиентыToolStripMenuItem,
            this.накладныеToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.товарыToolStripMenuItem.Text = "Выбрать";
            // 
            // товарыToolStripMenuItem1
            // 
            this.товарыToolStripMenuItem1.Name = "товарыToolStripMenuItem1";
            this.товарыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.товарыToolStripMenuItem1.Text = "Товары";
            this.товарыToolStripMenuItem1.Click += new System.EventHandler(this.товарыToolStripMenuItem1_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // накладныеToolStripMenuItem
            // 
            this.накладныеToolStripMenuItem.Name = "накладныеToolStripMenuItem";
            this.накладныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.накладныеToolStripMenuItem.Text = "Накладные";
            this.накладныеToolStripMenuItem.Click += new System.EventHandler(this.накладныеToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem товарыToolStripMenuItem1;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem накладныеToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
    }
}