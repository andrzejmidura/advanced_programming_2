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
    public partial class OrderForm : Form
    {
        public DatabaseConnection dbc;
        private int idClient = -1;
        private int idVehicle;
        private int phone;
        public OrderForm()
        {
            InitializeComponent();
        }
        public OrderForm(ref DatabaseConnection dbc_)
        {
            InitializeComponent();
            this.dbc = dbc_;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (idVehicle == -1)
            {
                MessageBox.Show("You must configure the car before placing an order!", "No car configured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textboxesAreValid())
            {
                    dbc.query("select idClient from clients where name='" + nameTextBox.Text +
                                                    "' and surname='" + surnameTextBox.Text +
                                                    "' and address='" + addressTextBox.Text +
                                                    "' and phone=" + phone.ToString() +"::NUMERIC;");
                    if (dbc.dt.Rows.Count == 0)
                    {
                        dbc.query("insert into clients(name, surname, address, phone) values ('" + nameTextBox.Text + "', '" + surnameTextBox.Text + "', '" + addressTextBox.Text + "', " + phone.ToString() + "::NUMERIC);");
                        dbc.query("select idClient from clients where name='" + nameTextBox.Text +
                                                    "' and surname='" + surnameTextBox.Text +
                                                    "' and address='" + addressTextBox.Text +
                                                    "' and phone=" + phone.ToString() + "::NUMERIC;");
                    }
                    idClient = dbc.dt.Rows[0].Field<int>("idClient");
                    string orderDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString(); 
                    dbc.query("insert into orders(idClient, idVehicle, orderDate) values(" + idClient.ToString() + ", " + idVehicle.ToString() + ", '" + orderDate + "');");
                    refreshOrders();
            }
            else
            {
                MessageBox.Show("Provide all necessary information!", "Information missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshOrders()
        {
            if (textboxesAreValid())
            {
                dbc.query("select o.idorder, v.brand, v.model, v.engine, v.color from clients c join orders o using(idClient) join vehicles v using(idVehicle) where c.name='" + nameTextBox.Text +
                                                                                                                                                          "' and c.surname='" + surnameTextBox.Text +
                                                                                                                                                          "' and c.address='" + addressTextBox.Text +
                                                                                                                                                          "' and c.phone=" + phone.ToString() + "::NUMERIC;");
                if (dbc.dt.Rows.Count == 0)
                {
                    ordersDataGrid.DataSource = null;
                    MessageBox.Show("No cars ordered by you.", "No cars ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        ordersDataGrid.DataSource = dbc.dt.DefaultView.ToTable(false, "idorder", "brand", "model", "engine", "color");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Query error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Provide all necessary information!", "Information missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            if (ordersDataGrid.SelectedRows.Count != 0)
            {
                StringBuilder rows = new StringBuilder();
                foreach (DataGridViewRow row in ordersDataGrid.SelectedRows)
                {
                    rows.Append(row.Cells["idOrder"].Value).Append(", ");
                }
                rows.Remove(rows.Length - 2, 2); // removes comma and space at the end
                dbc.query("delete from orders where idOrder in (" + rows.ToString() + ");");
                refreshOrders();
            }
        }

        public void setIdVehicle(int id)
        {
            this.idVehicle = id;
        }

        private void showOrdersButton_Click(object sender, EventArgs e)
        {
            if (!textboxesAreValid())
            {
                MessageBox.Show("Provide all necessary information!", "Information missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                refreshOrders();
            }
        }

        private bool textboxesAreValid()
        {
            if (nameTextBox.Text != "" &&
                surnameTextBox.Text != "" &&
                addressTextBox.Text != "" &&
                phoneTextBox.Text != "")
            {
                phone = Int32.Parse(phoneTextBox.Text);
                if (phone < 0 || phone > 999999999)
                {
                    MessageBox.Show("Provide correct phone number!", "Invalid phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        public int getIdClient()
        {
            return this.idClient;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textboxesAreValid())
            {
                dbc.query("select idClient from clients where name='" + nameTextBox.Text +
                                                    "' and surname='" + surnameTextBox.Text +
                                                    "' and address='" + addressTextBox.Text +
                                                    "' and phone=" + phone.ToString() + "::NUMERIC;");
                if (dbc.dt.Rows.Count == 1)
                {
                    idClient = dbc.dt.Rows[0].Field<int>("idClient");
                }
            }
        }
    }
}
