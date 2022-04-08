using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainForm : Form
    {
        private ConfigureCarForm ccf;
        private OrderForm of;
        private TestDriveReservationForm tdrf;
        public DatabaseConnection dbc;
        public MainForm()
        {
            InitializeComponent();
            dbc = new DatabaseConnection();
            ccf = new ConfigureCarForm(ref dbc);
            of = new OrderForm(ref dbc);
            tdrf = new TestDriveReservationForm();
        }

        private void configureCarButton_Click(object sender, EventArgs e)
        {
            ccf.ShowDialog();
        }

        private void orderCarButton_Click(object sender, EventArgs e)
        {
            if (ccf.getSavedIdVehicle()==-1)
            {
                MessageBox.Show("You must configure the car before placing an order!", "No car configured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                of.setIdVehicle(ccf.getSavedIdVehicle());
                of.ShowDialog();
            }
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            tdrf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
