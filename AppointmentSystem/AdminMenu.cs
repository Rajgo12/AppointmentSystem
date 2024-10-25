using System;
using System.Windows.Forms;

namespace AppointmentSystem
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            // Attach event handlers for buttons
            button1.Click += new EventHandler(AppointmentsButton_Click);
            button2.Click += new EventHandler(RecordsButton_Click);
            button3.Click += new EventHandler(LogoutButton_Click);
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            // Open the Appointments form and pass the current AdminMenu instance
            Appointments appointmentsForm = new Appointments(this);
            appointmentsForm.Show();
            this.Hide(); // Hide the AdminMenu while the Appointments form is open
        }

        private void RecordsButton_Click(object sender, EventArgs e)
        {
            // Open the Records form and pass the current AdminMenu instance
            Records recordsForm = new Records(this);
            recordsForm.Show();
            this.Hide(); // Hide the AdminMenu while the Records form is open
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Return to the Main Menu
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Hide(); // Hide the current form
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            // Any initialization logic when the AdminMenu loads
        }
    }
}
