using E_Shop.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shop.Forms
{
    public partial class CustomerForm : Form
    {
        string username = LoginForm.lf.GetWelcomeUserData();
        public CustomerForm()
        {
            InitializeComponent();

            customer_menu_label.Text = $"Welcome, {username}\nType: Customer";

            shopping1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.lf.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            shopping1.BringToFront();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            customerSetting1.BringToFront();
        }
    }
}
