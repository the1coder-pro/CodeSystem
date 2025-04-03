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

        private async void AccountsForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            accountTypeComboBox.SelectedValueChanged += accountTypeComboBox_SelectedIndexChanged;

        }

        private async Task LoadDataAsync()
        {
            await Task.Run(() =>
            {
                this.tblAccountTypeTableAdapter.Fill(this.reportDataSet.tblAccountType);
                this.tblAccountTableAdapter.Fill(this.reportDataSet.tblAccount);
            });

            this.tblAccountTypeBindingSource.DataSource = this.reportDataSet.tblAccountType;
            this.tblAccountBindingSource.DataSource = this.reportDataSet.tblAccount;


        }

        private void accountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountTypeComboBox.SelectedValue != null)
            {
                var selectedId = accountTypeComboBox.SelectedValue; // Ensure type matches your ID column
                tblAccountBindingSource.Filter = $"AccountTypeID = {selectedId}"; // Fi
            }
        }

        private void paymentAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // get data of selected account in payment Account ComboBox
            var selectedAccount = paymentAccountComboBox.SelectedItem as DataRowView;

            // fill the textboxs with the selected payment account data
            accountIDTextBox.Text = selectedAccount["ID"].ToString();
            nameEnglishTextBox.Text = selectedAccount["NameEn"].ToString();
            nameArabicTextBox.Text = selectedAccount["NameAr"].ToString();
            branchTextBox.Text = selectedAccount["BranchID"].ToString();
            nationalityComboBox.Items.Clear();
            nationalityComboBox.Items.Add(selectedAccount["NationalityID"].ToString());
            addressTextBox.Text = selectedAccount["AddressAr"].ToString();
            //accountNotesTextBox.Text = selectedAccount["AccountNote"].ToString();



        }
    }
}
