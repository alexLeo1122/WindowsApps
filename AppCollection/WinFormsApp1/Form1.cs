using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Unity_Click(object sender, EventArgs e)
        {
            try
            {
                // Path to the Unity executable
                string unityPath = @"C:\Program Files\Unity\Hub\Editor\2022.3.21f1\Editor\Unity.exe"; // Update this with your actual Unity installation path
                Run(unityPath);
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }

        private void Chrome_Click(object sender, EventArgs e)
        {
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            // Check if Unity executable exists
            Run(chromePath);
        }

        private void TxtFile_Click(object sender, EventArgs e)
        {
            string txtPath = @"H:\Access\gpt.txt";
            // Check if Unity executable exists
            // Start the process to open the file with the default text editor
            Process.Start(new ProcessStartInfo
            {
                FileName = txtPath,
                UseShellExecute = true
            });
        }

        private void GitDesktop_Click(object sender, EventArgs e)
        {
            string GitDesktopPath = @"C:\Users\RedWood\AppData\Local\GitHubDesktop\GitHubDesktop.exe";
            Run(GitDesktopPath);
        }

        private void Obsidian_Click(object sender, EventArgs e)
        {
            var noteAppPath = @"C:\Users\RedWood\AppData\Local\Programs\obsidian\Obsidian.exe";
            Run(noteAppPath);
        }
        private void Run(string path)
        {
            if (System.IO.File.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                MessageBox.Show("Path is wrong");
            }
        }
    }
}
