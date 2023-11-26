namespace Calculator
{
    partial class Info
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
            git_link = new LinkLabel();
            SuspendLayout();
            // 
            // git_link
            // 
            git_link.AutoSize = true;
            git_link.LinkColor = Color.Black;
            git_link.Location = new Point(189, 104);
            git_link.Margin = new Padding(6, 0, 6, 0);
            git_link.Name = "git_link";
            git_link.Size = new Size(127, 32);
            git_link.TabIndex = 0;
            git_link.TabStop = true;
            git_link.Text = "My Github";
            git_link.LinkClicked += git_link_LinkClicked;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 240);
            Controls.Add(git_link);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Info";
            Text = "Info";
            Load += Info_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel git_link;
    }
}