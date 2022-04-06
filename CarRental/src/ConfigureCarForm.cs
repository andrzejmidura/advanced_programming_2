using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;

namespace CarRental
{
    public partial class ConfigureCarForm : Form
    {
        private DatabaseConnection dbc = new DatabaseConnection();
        private string[] brands;
        private int idVehicle;
        private int savedIdVehicle;
        public ConfigureCarForm()
        {
            InitializeComponent();
            dbc.connectToDatabase();
            updateBrandComboBox();
        }

        private void updateBrandComboBox()
        {
            dbc.query("select distinct brand from vehicles;");
            brandComboBox.Items.Clear();

            foreach (DataRow row in dbc.dt.Rows)
            {
                brandComboBox.Items.Add(row.Field<string>("brand"));
            }
        }

        private void brandComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (brandComboBox.SelectedIndex != -1)
            {
                dbc.query("select distinct model from vehicles where brand='" + brandComboBox.SelectedItem.ToString() + "';");
                modelComboBox.SelectedIndex = -1;
                modelComboBox.Items.Clear();
                engineComboBox.SelectedIndex = -1;
                engineComboBox.Items.Clear();
                colorComboBox.SelectedIndex = -1;
                colorComboBox.Items.Clear();
                imgPictureBox.Image = null;

                foreach (DataRow row in dbc.dt.Rows)
                {
                    modelComboBox.Items.Add(row.Field<string>("model"));
                }
            }
        }

        private void modelComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (modelComboBox.SelectedIndex != -1)
            {
                dbc.query("select distinct engine from vehicles where brand='" + brandComboBox.SelectedItem.ToString() +
                                                           "' and model='" + modelComboBox.SelectedItem.ToString() + "';");
                engineComboBox.SelectedIndex = -1;
                engineComboBox.Items.Clear();
                colorComboBox.SelectedIndex = -1;
                colorComboBox.Items.Clear();
                imgPictureBox.Image = null;

                foreach (DataRow row in dbc.dt.Rows)
                {
                    engineComboBox.Items.Add(row.Field<string>("engine"));
                }
            }
        }

        private void engineComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (engineComboBox.SelectedIndex != -1)
            {
                dbc.query("select distinct color from vehicles where brand='" + brandComboBox.SelectedItem.ToString() +
                                                           "' and model='" + modelComboBox.SelectedItem.ToString() +
                                                           "' and engine='" + engineComboBox.SelectedItem.ToString() + "';");
                colorComboBox.SelectedIndex = -1;
                colorComboBox.Items.Clear();
                imgPictureBox.Image = null;

                foreach (DataRow row in dbc.dt.Rows)
                {
                    colorComboBox.Items.Add(row.Field<string>("color"));
                }
            }
        }
        
        private void colorComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (colorComboBox.SelectedIndex != -1)
            {
                dbc.query("select distinct idVehicle from vehicles where brand='" + brandComboBox.SelectedItem.ToString() +
                                                                  "' and model='" + modelComboBox.SelectedItem.ToString() +
                                                                  "' and engine='" + engineComboBox.SelectedItem.ToString() +
                                                                  "' and color='" + colorComboBox.SelectedItem.ToString() + "';");
                if (dbc.dt.Rows.Count != 1)
                {
                    throw new System.Exception("Ambiguous query result: Expected 1 row, got " + dbc.dt.Rows.Count.ToString() + " instead (idVehicle)");
                }
                idVehicle = dbc.dt.Rows[0].Field<int>("idVehicle");


                imgPictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\..\\..\\resources\\" + idVehicle.ToString() + ".jpg");
            }
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (brandComboBox.SelectedIndex==-1 ||
                modelComboBox.SelectedIndex==-1 ||
                engineComboBox.SelectedIndex==-1 ||
                colorComboBox.SelectedIndex==-1)
            {
                MessageBox.Show("Fill missing attributes!", "Attribute not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                savedIdVehicle = idVehicle;
                MessageBox.Show("Saved succesfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearButton_Click(object sender, System.EventArgs e)
        {
            brandComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
            modelComboBox.Items.Clear();
            engineComboBox.SelectedIndex = -1;
            engineComboBox.Items.Clear();
            colorComboBox.SelectedIndex = -1;
            colorComboBox.Items.Clear();

            imgPictureBox.Image = null;
        }

        private void returnButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
