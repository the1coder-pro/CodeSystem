using CodeSystem.Forms;
using CodeSystem.Models;
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

            currentUsernameLabel.Text = CurrentUser.Instance.user.Username;
            versionLabel.Text = CurrentUser.Instance.appVersion;
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

        private void logoutBtnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
          
           
        }
       
        private void receiptsBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;

            if (flowLayoutPanel1.Visible == true)
            {
                flowLayoutPanel1.Visible = false;
            }
            else
            {
                flowLayoutPanel1.Visible = true;

            }
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;

            if (flowLayoutPanel2.Visible == true)
            {
                flowLayoutPanel2.Visible = false;
            } else
            {
                flowLayoutPanel2.Visible = true;
                
            }
            

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void purchaseInvoiceBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel3.Visible = true;
             

             flowLayoutPanel3.Controls.Clear();

             InvoicesForm invoicesForm1 = new InvoicesForm();
             // Add the UserControl to the Panel
             flowLayoutPanel3.Controls.Add(invoicesForm1);


             

        }
    }
    
}


