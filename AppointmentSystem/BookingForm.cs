using System;
using System.Windows.Forms;

namespace AppointmentSystem
{
    public partial class BookingForm : Form
    {
        public BookingForm(MainMenu menu)
        {
            InitializeComponent();
            this.Owner = menu; // Set the owner to MainMenu

            // Hook up the button click events
            button1.Click += buttonBook_Click;  // Book button
            button2.Click += buttonCancel_Click; // Cancel button

            // Populate the time slots in comboBox1
            PopulateTimeSlots();
        }

        // Method to populate the time slots in the ComboBox
        private void PopulateTimeSlots()
        {
            comboBox1.Items.Clear(); // Clear existing items
            DateTime startTime = new DateTime(2023, 1, 1, 7, 30, 0); // Start at 7:30 AM
            DateTime endTime = new DateTime(2023, 1, 1, 16, 30, 0); // End at 4:30 PM
            TimeSpan interval = TimeSpan.FromMinutes(30); // 30-minute interval

            while (startTime <= endTime)
            {
                comboBox1.Items.Add(startTime.ToString("hh:mm tt")); // Add formatted time to comboBox1
                startTime = startTime.Add(interval); // Increment time by interval
            }

            comboBox1.SelectedIndex = 0; // Set default selection
        }

        // Event handler for the "Book" button click
        private void buttonBook_Click(object sender, EventArgs e)
        {
            // Collecting data from input fields
            string name = textBox1.Text;
            string studentId = textBox2.Text;
            string email = textBox3.Text;
            string yearLevel = textBox4.Text;
            string selectedTimeSlot = comboBox1.SelectedItem?.ToString(); // Get selected time slot
            DateTime appointmentDateTime = dateTimePicker3.Value;

            // Basic validation: Ensure fields are not empty
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(studentId) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(yearLevel) ||
                selectedTimeSlot == null) // Check for selected time slot
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Here you could add logic to save the appointment to a database or file

            MessageBox.Show("Appointment booked successfully!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Show the MainMenu again
            this.Owner.Show(); // Show the MainMenu
            this.Close(); // Close the BookingForm
        }

        // Event handler for the "Cancel" button click
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Show the MainMenu again when canceling
            this.Owner.Show(); // Show the MainMenu
            this.Close(); // Close the BookingForm
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
