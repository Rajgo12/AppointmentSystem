using System;
using System.Windows.Forms;

namespace AppointmentSystem
{
    public partial class MainMenu : Form
    {
        private BookingForm bookingForm; // Keep a reference to the BookingForm

        public MainMenu()
        {
            InitializeComponent();
            // Hook up button click events
            button1.Click += new EventHandler(button1_Click); // Book An Appointment button
            button2.Click += new EventHandler(button2_Click); // Login As Admin button
        }

        // Event handler for the "Book An Appointment" button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the bookingForm is already open
            if (bookingForm == null || bookingForm.IsDisposed)
            {
                bookingForm = new BookingForm(this); // Pass the current instance of MainMenu
                bookingForm.Show(this); // Set the MainMenu as the owner
                this.Hide(); // Optionally, hide the MainMenu form
            }
            else
            {
                // If already open, bring it to the front
                bookingForm.BringToFront();
            }
        }

        // Event handler for the "Login As Admin" button click
        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of AdminLogin and show it
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            // Optionally, hide the MainMenu form
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // You can implement this event handler if needed
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Any initialization logic when the MainMenu loads
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional event handler for label click
        }
    }
}
