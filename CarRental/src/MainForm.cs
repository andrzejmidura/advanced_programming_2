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
        ConfigureCarForm ccf;
        OrderForm of;
        TestDriveReservationForm tdrf;
        public MainForm()
        {
            InitializeComponent();
            ccf = new ConfigureCarForm();
            of = new OrderForm();
            tdrf = new TestDriveReservationForm();
        }

        private void configureCarButton_Click(object sender, EventArgs e)
        {
            ccf.ShowDialog();
        }

        private void orderCarButton_Click(object sender, EventArgs e)
        {
            of.ShowDialog();
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
