using System.Formats.Tar;

namespace WinFormsApp1
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
            Unity = new Button();
            Chrome = new Button();
            TxtFile = new Button();
            GitDesktop = new Button();
            Obsidian = new Button();
            SuspendLayout();
            // 
            // Unity
            // 
            Unity.Location = new Point(86, 71);
            Unity.Name = "Unity";
            Unity.Size = new Size(77, 71);
            Unity.TabIndex = 0;
            Unity.Text = "Unity";
            Unity.UseVisualStyleBackColor = true;
            Unity.Click += Unity_Click;
            // 
            // Chrome
            // 
            Chrome.Location = new Point(494, 71);
            Chrome.Name = "Chrome";
            Chrome.Size = new Size(77, 71);
            Chrome.TabIndex = 1;
            Chrome.Text = "Chrome";
            Chrome.UseVisualStyleBackColor = true;
            Chrome.Click += Chrome_Click;
            // 
            // TxtFile
            // 
            TxtFile.Location = new Point(891, 294);
            TxtFile.Name = "TxtFile";
            TxtFile.Size = new Size(77, 71);
            TxtFile.TabIndex = 2;
            TxtFile.Text = "TxtFile";
            TxtFile.UseVisualStyleBackColor = true;
            TxtFile.Click += TxtFile_Click;
            // 
            // GitDesktop
            // 
            GitDesktop.Location = new Point(86, 303);
            GitDesktop.Name = "GitDesktop";
            GitDesktop.Size = new Size(77, 71);
            GitDesktop.TabIndex = 3;
            GitDesktop.Text = "GitDesktop";
            GitDesktop.UseVisualStyleBackColor = true;
            GitDesktop.Click += GitDesktop_Click;
            // 
            // Obsidian
            // 
            Obsidian.Location = new Point(288, 303);
            Obsidian.Name = "Obsidian";
            Obsidian.Size = new Size(77, 71);
            Obsidian.TabIndex = 4;
            Obsidian.Text = "Obsidian";
            Obsidian.UseVisualStyleBackColor = true;
            Obsidian.Click += Obsidian_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 450);
            Controls.Add(Obsidian);
            Controls.Add(GitDesktop);
            Controls.Add(TxtFile);
            Controls.Add(Chrome);
            Controls.Add(Unity);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Unity;
        private Button Chrome;
        private Button TxtFile;
        private Button GitDesktop;
        private Button Obsidian;
    }
}
