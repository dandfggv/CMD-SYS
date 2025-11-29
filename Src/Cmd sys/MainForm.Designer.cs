namespace BeatsCmdRunner
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblOutput;

        private void InitializeComponent()
        {
            this.btnRun = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblCommand
            this.lblCommand.Text = "🎧 Enter Command:";
            this.lblCommand.Location = new System.Drawing.Point(12, 20);
            this.lblCommand.ForeColor = System.Drawing.Color.White;
            this.lblCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // txtCommand
            this.txtCommand.Location = new System.Drawing.Point(180, 20);
            this.txtCommand.Size = new System.Drawing.Size(400, 30);
            this.txtCommand.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtCommand.BackColor = System.Drawing.Color.Black;
            this.txtCommand.ForeColor = System.Drawing.Color.Lime;

            // btnRun
            this.btnRun.Text = "▶ Run Beat";
            this.btnRun.Location = new System.Drawing.Point(600, 20);
            this.btnRun.Size = new System.Drawing.Size(120, 35);
            this.btnRun.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);

            // lblOutput
            this.lblOutput.Text = "🎵 Output:";
            this.lblOutput.Location = new System.Drawing.Point(12, 70);
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // txtOutput
            this.txtOutput.Location = new System.Drawing.Point(180, 70);
            this.txtOutput.Size = new System.Drawing.Size(540, 300);
            this.txtOutput.Multiline = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.ForeColor = System.Drawing.Color.Cyan;

            // MainForm
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Text = "Beats CMD Runner 🎶";
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30); // Dark theme
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
