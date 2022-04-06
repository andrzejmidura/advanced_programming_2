using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void configureCarButton_Click(object sender, EventArgs e)
        {
            ConfigureCarForm ccf = new ConfigureCarForm();
            ccf.ShowDialog();
        }

        private void orderCarButton_Click(object sender, EventArgs e)
        {
            OrderForm of = new OrderForm();
            of.ShowDialog();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            TestDriveReservationForm tdrf = new TestDriveReservationForm();
            tdrf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
