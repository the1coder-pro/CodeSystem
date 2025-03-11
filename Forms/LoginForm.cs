using CodeSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            GetUsers();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* load users in combobox */
        }

        private void GetUsers()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));

            var repo = new UserRepository();
            var users = repo.GetUsers();
            foreach ( var user in users ) {
                dataTable.Rows.Add(user.Id, user.Username, user.Password);
                Console.WriteLine(user.Username);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                usernameComboBox.Items.Add(dataTable.Rows[i]["Username"]);
            }
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Get the username and password from the textboxes

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
            UserRepository userRepository = new UserRepository();
            User user = userRepository.loginUser(username, password);
            if (user.Username == null)
            {
                MessageBox.Show("كلمة المرور غير صحيحة");
                passwordTextBox.Focus();

                return;
            }
            else
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Show();
                usernameComboBox.Text = "";
                passwordTextBox.Text = "";
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
