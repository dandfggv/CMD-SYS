using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BeatsCmdRunner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                process.StandardInput.WriteLine(txtCommand.Text);
                process.StandardInput.WriteLine("exit");

                string output = process.StandardOutput.ReadToEnd();
                txtOutput.Text = output;

                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
