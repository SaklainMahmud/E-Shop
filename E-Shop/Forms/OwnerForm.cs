using System;
using System.Windows.Forms;

namespace E_Shop
{
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
            string sharedData = LoginForm.lf.GetWelcomeUserData();
            owner_menu_label.Text = $"Hello, {sharedData}";
            ownerDashboard1.Dock = DockStyle.Fill;
            ownerDashboard1.BringToFront();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.lf.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ownerDashboard1.BringToFront();
        }

        private void managementBtn_Click(object sender, EventArgs e)
        {
            ownerManagement1.BringToFront();
        }

        private void financeBtn_Click(object sender, EventArgs e)
        {
            ownerFinance1.BringToFront();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ownerSettings1.BringToFront();
        }

        private void OwnershipBtn_Click(object sender, EventArgs e)
        {
            ownership1.BringToFront();
        }
    }
}