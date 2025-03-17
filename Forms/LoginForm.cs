using CodeSystem.Models;
using CodeSystem.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CodeSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UserRepository userRepository = new UserRepository();

            usernameComboBox.DataSource = User.UsernameList();

            // set the value member
            usernameComboBox.ValueMember = "ID";
            usernameComboBox.SelectedIndex = 0;

            // set the display member
            usernameComboBox.DisplayMember = "Username";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {


            //Get the username and password from the textboxes
            string username = usernameComboBox.Text;
            string password = passwordTextBox.Text;

            // Check if the username and password are empty
            if (username == "")
            {
                MessageBox.Show("يجب اختيار اسم المستخدم أولا");
                return;
            }

            if (password == "")
            {
                MessageBox.Show("يجب إدخال كلمة المرور أولا");
                return;
            }

            // Check if the username and password are correct
            User user = new User(usernameComboBox.Text, passwordTextBox.Text);


            
            if (user.Password.IsNullOrEmpty())
            {
                MessageBox.Show("كلمة المرور غير صحيحة");
                passwordTextBox.Focus();

                return;
            }

           
            if (user.Authenticate())
            {
                User.GetUserGroupID(int.Parse(usernameComboBox.SelectedValue.ToString()));

                // get use rdetails
                DataTable userTable = User.CurrentUserDetail(int.Parse(usernameComboBox.SelectedValue.ToString()));

                // convert user table to user object
                var currentUser = new User(
                    intID: int.Parse(userTable.Rows[0]["ID"].ToString()),
                    strNamear: userTable.Rows[0]["NameAr"].ToString(),
                    strNameEn: userTable.Rows[0]["NameEn"].ToString(),
                    strUserName: userTable.Rows[0]["UserName"].ToString(),
                    strPassword: userTable.Rows[0]["Password"].ToString(),
                    datFirstEntry: DateTime.Parse(userTable.Rows[0]["FirstEntry"].ToString()),
                    datLastEntry: DateTime.Parse(userTable.Rows[0]["LastEntry"].ToString()),
                    bytUserGroupID: byte.Parse(userTable.Rows[0]["UserGroupID"].ToString()),
                    intCurrentStatusID: int.Parse(userTable.Rows[0]["CurrentStatusID"].ToString()),
                    bolStopped: bool.Parse(userTable.Rows[0]["Stopped"].ToString())
                    );



                //GetDevalutUserMoneyaccount(cmb_UserID.SelectedValue);
                //this.Visible = false;
                //currentLanguage = Language.ar;

                this.Hide();
                CurrentUser.Instance.user = currentUser;
                CurrentUser.Instance.appVersion = "V1.0.0";
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                // InvoiceTypeSelectForm.Show();
                this.Show();
                
                passwordTextBox.Text = "";



                //var myTransactionHistory = new TransactionHistoryModel();
                //myTransactionHistory.ObjectID = ObjectEnum.frmLogIn;
                //myTransactionHistory.PCID = intThisPCID;
                //myTransactionHistory.RecordData = DateTime.Now.ToShortDateString();
                //myTransactionHistory.RecordDataar = this.cmb_UserID.Text + " - " + this.txt_Password.Text;
                //myTransactionHistory.RecordDataEn = this.cmb_UserID.Text + " - " + this.txt_Password.Text;
                //myTransactionHistory.RecordID = Convert.ToInt32(cmb_UserID.SelectedValue);
                //myTransactionHistory.TransactionTime = DateTime.Now.ToShortTimeString();
                //myTransactionHistory.TransactionTypeID = TransactionTypeEnum.Sign_In;
                //myTransactionHistory.UserID = Convert.ToInt32(cmb_UserID.SelectedValue);
                //myTransactionHistory.Add();
            }
            else
            {
                //var myTransactionHistory = new TransactionHistoryModel();
                //myTransactionHistory.ObjectID = ObjectEnum.frmLogIn;
                //myTransactionHistory.PCID = intThisPCID;
                //myTransactionHistory.RecordData = DateTime.Now.ToShortDateString();
                //myTransactionHistory.RecordDataar = this.cmb_UserID.Text + " - " + this.txt_Password.Text;
                //myTransactionHistory.RecordDataEn = this.cmb_UserID.Text + " - " + this.txt_Password.Text;
                //myTransactionHistory.RecordID = Convert.ToInt32(cmb_UserID.SelectedValue);
                //myTransactionHistory.TransactionTime = DateTime.Now.ToShortTimeString();
                //myTransactionHistory.TransactionTypeID = TransactionTypeEnum.Password_Wrong;
                //myTransactionHistory.UserID = Convert.ToInt32(cmb_UserID.SelectedValue);
                //myTransactionHistory.Add();

                // Status_Label.Text = "كلمة المرور غير صحيحة، حاول مرة أخرى"
                passwordTextBox.Focus();
                passwordTextBox.Text = "";
            }


        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository();
            DataTable tblItem =  repo.GetTableData("tblItem1");
            List<string> tblItemColumns = repo.GetColumns("tblItem1");

            // list all columns
            foreach (var column in tblItemColumns)
            {
                Console.WriteLine(column);
            }

            foreach (DataRow row in tblItem.Rows)
            {
                foreach (var column in tblItemColumns)
                {
                    Console.WriteLine(column);
                    Console.WriteLine(row[column]);
                }
            
               
            }

     

        }
    }
}
