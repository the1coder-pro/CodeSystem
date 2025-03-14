using CodeSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSystem.Forms
{
    public partial class AccountsForm : UserControl
    {
        public AccountsForm()
        {
            InitializeComponent();
            InitializeTranslations();
        }

       
        private void InitializeTranslations()
        {
            // Load translations for the current language
            TranslationHelper.LoadLanguage(CurrentUser.Instance.language);

            

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
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
