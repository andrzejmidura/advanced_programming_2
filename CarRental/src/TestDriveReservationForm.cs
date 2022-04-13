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
        private string idOrder;
        private DateTime date;
        public TestDriveReservationForm()
        {
            InitializeComponent();
        }

        public TestDriveReservationForm(ref DatabaseConnection dbc_)
        {
            InitializeComponent();
            this.dbc = dbc_;
            
        }

        private void TestDriveReservationForm_Load(object sender, EventArgs e)
        {
            refreshClientInfo();
            refreshReservations();
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

        public void setIdClient(int idClient_)
        {
            this.idClient = idClient_;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            if (validateBooking())
            {
                string reservationDate = date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString();
                dbc.query("insert into reservations(idClient, idOrder, reservationDate) values("+ idClient.ToString() + ", " + idOrder + ", '" + reservationDate +"');");
                refreshReservations();
            }
        }

        private bool validateBooking()
        {
            if (date.Date.CompareTo(DateTime.Today.Date) <= 0) // its today or day from the past selected
            {
                MessageBox.Show("You must select future date!", "Wrong date selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (idClient == -1)
            {
                MessageBox.Show("You haven't placed any orders thus you are not registered in our database!", "Client not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (orderedCarsGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must specify which car you want to test during test drive!", "Cars selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                idOrder = orderedCarsGridView.SelectedRows[0].Cells["idOrder"].Value.ToString();
                dbc.query("select * from reservations where idOrder=" + idOrder + ";");
                if (dbc.dt.Rows.Count != 0)
                {
                    MessageBox.Show("You have reserved test drive for this car already!", "Cars selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.date = monthCalendar1.SelectionStart;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (reservationsDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No selected reservations.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Are you sure you want to cancel the reservation/s?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                StringBuilder rows = new StringBuilder();
                foreach (DataGridViewRow row in reservationsDataGrid.SelectedRows)
                {
                    rows.Append(row.Cells["idReservation"].Value).Append(", ");
                }
                rows.Remove(rows.Length - 2, 2); // removes comma and space at the end
                dbc.query("delete from reservations where idReservation in (" + rows.ToString() + ");");
                refreshReservations();
            }
        }

        private void refreshReservations()
        {
                dbc.query("select r.idReservation, r.reservationDate, r.idOrder from clients c join reservations r using(idClient) join orders o using(idOrder) where c.idClient=" + idClient.ToString() + ";");
                if (dbc.dt.Rows.Count == 0)
                {
                    reservationsDataGrid.DataSource = null;
                }
                else
                {
                    try
                    {
                        reservationsDataGrid.DataSource = dbc.dt.DefaultView.ToTable(false, "idReservation", "reservationDate", "idOrder");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Query error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
    }
}
