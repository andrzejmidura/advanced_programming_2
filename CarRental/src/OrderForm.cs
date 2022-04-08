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
        private int idClient;
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
            if (textboxesAreValid())
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
        }

        private void refreshOrders()
        {
            dbc.query("select o.idorder, v.brand, v.model, v.engine, v.color from clients c join orders o using(idClient) join vehicles v using(idVehicle) where c.name='" + nameTextBox.Text +
                                                                                                                                                          "' and c.surname='" + surnameTextBox.Text +
                                                                                                                                                          "' and c.address='" + addressTextBox.Text +
                                                                                                                                                          "' and c.phone=" + phone.ToString() + "::NUMERIC;");
            ordersDataGrid.DataSource = dbc.dt.DefaultView.ToTable(false, "idorder", "brand", "model", "engine", "color");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ordersDataGrid.SelectedRows)
            {
                dbc.query("delete from orders where idOrder=" + row.Cells["idorder"].Value.ToString() + ";");
            }
            refreshOrders();
        }

        public void setIdVehicle(int id)
        {
            this.idVehicle = id;
        }

        private void showOrdersButton_Click(object sender, EventArgs e)
        {
            if (textboxesAreValid()) 
            { 
                refreshOrders();
            }
        }

        private bool textboxesAreValid()
        {
            if (nameTextBox.Text == "" ||
                surnameTextBox.Text == "" ||
                addressTextBox.Text == "" ||
                phoneTextBox.Text == "")
            {
                MessageBox.Show("Provide all necessary information!", "Information missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
    }
}
