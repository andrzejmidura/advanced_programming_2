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
            tdrf = new TestDriveReservationForm(ref dbc);
        }

        private void configureCarButton_Click(object sender, EventArgs e)
        {
            ccf.ShowDialog();
        }

        private void orderCarButton_Click(object sender, EventArgs e)
        {
            of.setIdVehicle(ccf.getSavedIdVehicle());
            of.ShowDialog();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            tdrf.setIdClient(of.getIdClient());
            tdrf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
