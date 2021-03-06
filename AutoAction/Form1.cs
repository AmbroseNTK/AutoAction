﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace AutoAction
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string fileDir = "";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Position: " + Cursor.Position.X + " , " + Cursor.Position.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\default"))
            {
                this.Hide();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.FileName = "python";
                startInfo.Arguments = "default";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                Application.Exit();
            }
            timer1.Start();
           
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open script";
            openFileDialog.Filter = "Auto Script(*.autopy)|";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileDir = openFileDialog.FileName;
                tbScript.Text = File.ReadAllText(fileDir);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save script";
            saveFileDialog.Filter = "Auto Script(*.autopy)|";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileDir = saveFileDialog.FileName + ".autopy";
                tbScript.Text = "";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (fileDir == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save script";
                saveFileDialog.Filter = "Auto Script(*.autopy)|";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileDir = saveFileDialog.FileName + ".autopy";
                }
            }
            File.WriteAllText(fileDir, tbScript.Text);
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            SetStartup();
       
            this.WindowState = FormWindowState.Minimized;
            if(chkHideApp.Checked)
                this.Hide();
            string script = "";
            script += "from CallActions import *\n";
            script += tbScript.Text;
            File.WriteAllText(Application.StartupPath + "\\instance", script);

            if (chkSetStartupScript.Checked)
            {
                File.AppendAllText(Application.StartupPath + "\\default", script);
            }
            else
            {
                if (File.Exists(Application.StartupPath + "\\default"))
                {
                    File.Delete(Application.StartupPath + "\\default");
                }
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = !chkHide.Checked;
            startInfo.CreateNoWindow = chkHide.Checked;
            startInfo.FileName = "python";
            startInfo.Arguments = "instance";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();


            if (chkShutdown.Checked)
                Application.Exit();
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btBuild_Click(object sender, EventArgs e)
        {
            
            string dir = Path.GetDirectoryName(fileDir);
            string projectName = Path.GetFileNameWithoutExtension(fileDir);
            string tempFile = dir +"\\"+ projectName + "_exec";
            if (File.Exists(tempFile))
                File.Delete(tempFile);

            if (Directory.Exists(dir + "\\dist"))
            {
                Directory.Delete(dir + "\\dist",true);
                Directory.Delete(dir + "\\build",true);
            }

            File.AppendAllText(tempFile, File.ReadAllText(Application.StartupPath + "\\CallActions.py"));
            File.AppendAllText(tempFile, tbScript.Text);

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
            processStartInfo.WorkingDirectory = dir;
            processStartInfo.FileName = "pyinstaller";
            processStartInfo.Arguments = projectName+"_exec";
            process.StartInfo = processStartInfo;
            process.Start();
            process.WaitForExit();
        }
        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (chkStartup.Checked)
                rk.SetValue("WindowsAction", Application.ExecutablePath.ToString());
            else
                rk.DeleteValue("WindowsAction", false);

        }

    }
}
