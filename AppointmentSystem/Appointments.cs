using System;
using System.Windows.Forms;

namespace AppointmentSystem
{
    public partial class Appointments : Form
    {
        private AdminMenu adminMenu;

        public Appointments(AdminMenu menu)
        {
            InitializeComponent();
            this.adminMenu = menu; // Store reference to AdminMenu

            // Hook up button click events
            button1.Click += new EventHandler(AcceptButton_Click);  // Accept button
            button2.Click += new EventHandler(DeclineButton_Click); // Decline button
            button3.Click += new EventHandler(BackButton_Click);    // Back button
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            // This would be the place to load data into the DataGridView
            // e.g., dataGridView1.DataSource = someDataSource;
        }

        // Event handler for "Accept" button
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get selected appointment (from DataGridView)
                var selectedRow = dataGridView1.SelectedRows[0];
                // Implement logic to accept the appointment (e.g., update the status in the database)

                MessageBox.Show("Appointment accepted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an appointment to accept.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for "Decline" button
        private void DeclineButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get selected appointment (from DataGridView)
                var selectedRow = dataGridView1.SelectedRows[0];
                // Implement logic to decline the appointment (e.g., remove or update the status in the database)

                MessageBox.Show("Appointment declined.", "Declined", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an appointment to decline.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for "Back" button
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Show the AdminMenu again
            adminMenu.Show();
            this.Close(); // Close the current Appointments form
        }

        // Optional: If you need to handle cell clicks for detailed appointment info
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Logic to handle clicking on a cell, if needed
        }
    }
}
