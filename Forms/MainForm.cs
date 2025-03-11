using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            runCMDCommand("calc");
        }
        public void runCMDCommand(String command)
        {
            Process process = new Process();
            // Set the StartInfo.FileName property to the path of the CMD executable.
            process.StartInfo.FileName = "cmd.exe";
            // Set the StartInfo.Arguments property to the CMD command that you want to execute.
            process.StartInfo.Arguments = "/c " + command;
            // Set the StartInfo.CreateNoWindow property to true.
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // Start the process.
            process.Start();
        }
    }
    
}


