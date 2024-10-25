using System;
using System.Windows.Forms;

namespace AppointmentSystem
{
    public partial class Records : Form
    {
        private AdminMenu adminMenu;

        public Records(AdminMenu menu)
        {
            InitializeComponent();
            this.adminMenu = menu; // Store reference to AdminMenu
        }

        // Event handler for the "Back" button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Show the AdminMenu when the back button is clicked
            adminMenu.Show();
            this.Close(); // Close the current Records form
        }
    }
}
