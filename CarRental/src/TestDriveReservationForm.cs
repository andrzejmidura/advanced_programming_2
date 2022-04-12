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
    public partial class TestDriveReservationForm : Form
    {
        private DatabaseConnection dbc;
        private int idClient;
        public TestDriveReservationForm()
        {
            InitializeComponent();
        }

        public TestDriveReservationForm(ref DatabaseConnection dbc_)
        {
            InitializeComponent();
            this.dbc = dbc_;
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void TestDriveReservationForm_Load(object sender, EventArgs e)
        {
            refreshClientInfo();
        }

        private void refreshOrderedCars()
        {
            dbc.query("select o.idOrder, v.brand, v.model, v.engine, v.color from clients c join orders o using(idClient) join vehicles v using(idVehicle) where c.idClient='" + idClient.ToString() + "';");
            if (dbc.dt.Rows.Count == 0)
            {
                orderedCarsGridView.DataSource = null;
                MessageBox.Show("No cars ordered by you.", "No cars ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    orderedCarsGridView.DataSource = dbc.dt.DefaultView.ToTable(false, "idorder", "brand", "model", "engine", "color");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Query error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refreshClientInfo()
        {
            if (idClient == -1)
            {
                MessageBox.Show("Please provide client informations in OrderForm!", "Wrong idClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dbc.query("select * from clients where idClient=" + idClient.ToString() + ";");
                if (dbc.dt.Rows.Count == 1)
                {
                    nameTextBox.Text = dbc.dt.Rows[0].Field<string>("name");
                    surnameTextBox.Text = dbc.dt.Rows[0].Field<string>("surname");
                    addressTextBox.Text = dbc.dt.Rows[0].Field<string>("address");
                    phoneTextBox.Text = dbc.dt.Rows[0].Field<Object>("phone").ToString();
                    refreshOrderedCars();
                }
                else
                {
                    throw new Exception("Query error: Ambiguous idClient! Expected rows: 1\tgot:" + dbc.dt.Rows.Count.ToString());
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void setIdClient(int idClient_)
        {
            this.idClient = idClient_;
        }
    }
}
