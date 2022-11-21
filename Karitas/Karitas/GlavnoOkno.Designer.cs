namespace Karitas
{
    partial class GlavnoOkno
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaščitaInObnovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaščitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obnovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.vnosToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.tiskanjeToolStripMenuItem,
            this.zaščitaInObnovaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // vnosToolStripMenuItem
            // 
            this.vnosToolStripMenuItem.Name = "vnosToolStripMenuItem";
            this.vnosToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.vnosToolStripMenuItem.Text = "Vnos";
            this.vnosToolStripMenuItem.Click += new System.EventHandler(this.vnosToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // tiskanjeToolStripMenuItem
            // 
            this.tiskanjeToolStripMenuItem.Name = "tiskanjeToolStripMenuItem";
            this.tiskanjeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tiskanjeToolStripMenuItem.Text = "Tiskanje";
            this.tiskanjeToolStripMenuItem.Click += new System.EventHandler(this.tiskanjeToolStripMenuItem_Click);
            // 
            // zaščitaInObnovaToolStripMenuItem
            // 
            this.zaščitaInObnovaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaščitaToolStripMenuItem,
            this.obnovaToolStripMenuItem});
            this.zaščitaInObnovaToolStripMenuItem.Name = "zaščitaInObnovaToolStripMenuItem";
            this.zaščitaInObnovaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.zaščitaInObnovaToolStripMenuItem.Text = "Zaščita in obnova";
            // 
            // zaščitaToolStripMenuItem
            // 
            this.zaščitaToolStripMenuItem.Name = "zaščitaToolStripMenuItem";
            this.zaščitaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.zaščitaToolStripMenuItem.Text = "Zaščita";
            this.zaščitaToolStripMenuItem.Click += new System.EventHandler(this.zaščitaToolStripMenuItem_Click);
            // 
            // obnovaToolStripMenuItem
            // 
            this.obnovaToolStripMenuItem.Name = "obnovaToolStripMenuItem";
            this.obnovaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.obnovaToolStripMenuItem.Text = "Obnova";
            this.obnovaToolStripMenuItem.Click += new System.EventHandler(this.obnovaToolStripMenuItem_Click);
            // 
            // GlavnoOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 690);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlavnoOkno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GlavnoOkno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaščitaInObnovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaščitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obnovaToolStripMenuItem;
    }
}