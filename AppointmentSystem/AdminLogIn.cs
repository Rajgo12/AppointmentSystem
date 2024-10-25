using System;
using System.Windows.Forms;

namespace AppointmentSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username == "123" && password == "123") // Example credentials
            {


                // Create and show the AdminMenu form
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();  // Show the AdminMenu
                this.Hide();       // Hide the current AdminLogin form
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
