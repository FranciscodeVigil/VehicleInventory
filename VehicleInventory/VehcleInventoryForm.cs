using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleInventory
{
    public partial class VehcleInventoryForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public VehcleInventoryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = txbLicense.Text;
                sedan.VIN = txbVIN.Text;
                vehicles.Add(sedan);
                LbInventory.DataSource = null;
                LbInventory.DataSource = vehicles;
                txbResults.Text = "Successfully added sedan";
            }
            else if (cbType.Text == "Truck")
            {
                Truck truck = new Truck(txbVIN.Text, txbLicense.Text);
                vehicles.Add(truck);
                LbInventory.DataSource = null;
                LbInventory.DataSource = vehicles;
                txbResults.Text = "Successfully added truck";
            }
        }

        private void LbInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vehicle vehicle = (Vehicle)LbInventory.SelectedItem;
            TbxSummary.Text = vehicle.GetDescription();
        }
    }
}
