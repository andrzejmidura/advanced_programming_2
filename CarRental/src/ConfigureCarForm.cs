using System.Windows.Forms;
using System.Data;

namespace CarRental
{
    public partial class ConfigureCarForm : Form
    {
        private DatabaseConnection dbc = new DatabaseConnection();
        private string[] brands;
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
            dbc.query("select distinct model from vehicles where brand='"+brandComboBox.SelectedItem.ToString()+"';");
            modelComboBox.Items.Clear();

            foreach (DataRow row in dbc.dt.Rows)
            {
                modelComboBox.Items.Add(row.Field<string>("model"));
            }
        }

        private void modelComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void engineComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void colorComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
