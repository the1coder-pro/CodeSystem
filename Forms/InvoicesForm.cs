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
    public partial class InvoicesForm : UserControl
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        void updateButtonColor(Button button)
        {
            button.BackColor = button.BackColor == Color.White ? Color.LightBlue : Color.White;
            // Reset all other buttons
            foreach (Control control in Panel1.Controls)
            {
                if (control is Button && control != button)
                {
                    control.BackColor = Color.White;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Remaind_Label_Click(object sender, EventArgs e)
        {

        }

        private void Cash_Button_Click(object sender, EventArgs e)
        {

            updateButtonColor(Cash_Button);


        }

        private void Network_Button_Click(object sender, EventArgs e)
        {
            updateButtonColor(Network_Button);
        }
    

        private void Credit_Button_Click(object sender, EventArgs e)
        {
            updateButtonColor(Credit_Button);

        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            updateButtonColor(Return_Button);
        }

        private void GivingDateLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
