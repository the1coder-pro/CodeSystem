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

            currentUsernameLabel.Text = CurrentUser.Instance.user.NameArabic;
            versionLabel.Text = CurrentUser.Instance.appVersion;
               

            // Initialize language based on global setting
            TranslationHelper.LoadLanguage(CurrentUser.Instance.language);
            InitializeLanguage();
        }

      
        private void InitializeLanguage()
        {
           // for mainForm 
           foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && !string.IsNullOrEmpty(textBox.Name))
                {
                    textBox.Text = TranslationHelper.Translate(textBox.Name); // Translate TextBox
                }
                else if (control is Button button && !string.IsNullOrEmpty(button.Name))
                {
                    button.Text = TranslationHelper.Translate(button.Name); // Translate Button
                }
                else if (control is Label label && !string.IsNullOrEmpty(label.Name))
                {
                    label.Text = TranslationHelper.Translate(label.Name); // Translate Label
                } 
                // Add more control types as needed

                // for toolstrip 
                foreach (ToolStripItem item in toolStrip1.Items)
                {
                    if (item is ToolStripButton menuButton)
                    {
                        menuButton.Text = TranslationHelper.Translate(menuButton.Name); // Translate ToolStripMenuItem
                        
                    }
                }

                // for toolstrip menu and sub menu
                foreach (ToolStripItem item in menuStrip1.Items)
                {
                    if (item is ToolStripMenuItem menuItem)
                    {
                        menuItem.Text = TranslationHelper.Translate(menuItem.Name); // Translate ToolStripMenuItem
                        foreach (ToolStripItem subItem in menuItem.DropDownItems)
                        {
                            if (subItem is ToolStripMenuItem subMenuItem)
                            {
                                subMenuItem.Text = TranslationHelper.Translate(subMenuItem.Name); // Translate ToolStripMenuItem
                            }
                        }
                    }
                }
                currentUsernameLabel.Text = CurrentUser.Instance.user.Username;



            }


        }

        private void RefreshFlowLayoutPanel()
        {
            languageBtn.Text = TranslationHelper.Translate(languageBtn.Name);
            foreach (Control control in flowLayoutPanel3.Controls)
            {
                // Check if the control is a dynamic form or custom user control
                if (control is UserControl myForm)
                {
                    // Now you have access to the form and its controls
                    foreach (Control innerControl in myForm.Controls)
                    {
                        // Update TextBox content based on translations
                        if (innerControl is TextBox textBox && !string.IsNullOrEmpty(textBox.Name))
                        {
                            textBox.Text = TranslationHelper.Translate(textBox.Name); // Translate using the TextBox name
                        }
                        // Update Button content based on translations
                        else if (innerControl is Button button && !string.IsNullOrEmpty(button.Name))
                        {
                            button.Text = TranslationHelper.Translate(button.Name); // Translate using the Button name
                        }
                        // Add more control types if needed (e.g., Label, CheckBox, etc.)
                        else if (innerControl is Label label && !string.IsNullOrEmpty(label.Name))
                        {
                            label.Text = TranslationHelper.Translate(label.Name); // Translate using the Label name
                        }
                    }
                }
            }


            // Optionally refresh the entire form's language
            RefreshLanguage();
        }

        private void RefreshLanguage()
        {
           // this.Text = TranslationHelper.Translate("formTitle"); // Refresh the form title
           flowLayoutPanel3.Refresh(); // Refresh the flowLayoutPanel
           InitializeLanguage();
        }


        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            runCMDCommand("calc");
        }

        // show form and hide the current form in panel
        private void showFormInPanel(Control form)
        {
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel3.Visible = true;

            flowLayoutPanel3.Controls.Clear();

            flowLayoutPanel3.Controls.Add(form);


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
        
            showFormInPanel(new InvoicesForm());




        }

        private void الآلةالحاسبةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runCMDCommand("calc");

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://sites.google.com/view/ctit-soft");
        }

        private void الفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receiptsBtn_Click(sender, e);
        }

        private void أوامرالصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordersBtn_Click(sender, e);
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            showFormInPanel(new ItemsForm());
        }

        private void الأصنافToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showFormInPanel(new ItemsForm());
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accountsBtn_Click(object sender, EventArgs e)
        {
            showFormInPanel(new AccountsForm());
        }

        private void languageBtn_Click(object sender, EventArgs e)
        {
            CurrentUser.Instance.language = CurrentUser.Instance.language ==  "en" ? "ar" : "en";
            TranslationHelper.LoadLanguage(CurrentUser.Instance.language);
            
            // Refresh the flowLayoutPanel to reflect the updated language
            RefreshFlowLayoutPanel();
            InitializeLanguage();
        }
    }
    
}


