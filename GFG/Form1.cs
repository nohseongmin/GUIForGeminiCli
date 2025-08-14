using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace GFG
{
    public partial class Form1 : Form
    {
        private Process cmdProcess;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
            tbxQuest.KeyDown += TbxQuest_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartCmdProcess();
        }

        private void StartCmdProcess()
        {
            cmdProcess = new Process();
            cmdProcess.StartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/K chcp 949", // Set Korean code page
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.GetEncoding(949), // Match the code page
                StandardErrorEncoding = Encoding.GetEncoding(949)
            };

            cmdProcess.OutputDataReceived += CmdProcess_DataReceived;
            cmdProcess.ErrorDataReceived += CmdProcess_DataReceived;

            try
            {
                cmdProcess.Start();
                cmdProcess.BeginOutputReadLine();
                cmdProcess.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show("cmd.exe를 시작하지 못했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdProcess_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // Check if the control's handle is created before invoking.
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(() =>
                    {
                        tbxAnswer.AppendText(e.Data + Environment.NewLine);
                    }));
                }
            }
        }

        private void TbxQuest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(tbxQuest.Text))
            {
                e.SuppressKeyPress = true; // Prevent the 'ding' sound
                string command = tbxQuest.Text;
                tbxQuest.Clear();

                if (cmdProcess != null && !cmdProcess.HasExited)
                {
                    cmdProcess.StandardInput.WriteLine(command);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmdProcess != null && !cmdProcess.HasExited)
            {
                cmdProcess.Kill();
            }
        }
    }
}