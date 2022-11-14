namespace PreprostRaziskovalec
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
            this.trvDrevo = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trvDrevo
            // 
            this.trvDrevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.trvDrevo.Location = new System.Drawing.Point(0, 0);
            this.trvDrevo.Name = "trvDrevo";
            this.trvDrevo.Size = new System.Drawing.Size(790, 354);
            this.trvDrevo.TabIndex = 0;
            this.trvDrevo.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDrevo_BeforeExpand);
            this.trvDrevo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDrevo_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 735);
            this.Controls.Add(this.trvDrevo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Preprost raziskovalec";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvDrevo;
    }
}

