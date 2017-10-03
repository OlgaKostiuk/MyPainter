namespace Painter.Views
{
    partial class MainForm
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
            this.pMenu = new Painter.Views.PMenu();
            this.pTabControl1 = new Painter.Views.PTabControl();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(949, 26);
            this.pMenu.TabIndex = 0;
            // 
            // pTabControl1
            // 
            this.pTabControl1.Location = new System.Drawing.Point(70, 32);
            this.pTabControl1.Name = "pTabControl1";
            this.pTabControl1.Size = new System.Drawing.Size(795, 544);
            this.pTabControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 603);
            this.Controls.Add(this.pTabControl1);
            this.Controls.Add(this.pMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        public PMenu pMenu;
        public PTabControl pTabControl1;
    }
}

