using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class CarShop : Form
    {
        public CarShop()
        {
            InitializeComponent();
            //add the decorator names to the listview
            lbAvailable.Items.Add("Snow tires");
            lbAvailable.Items.Add("Bull bar");
            lbAvailable.Items.Add("Air conditioning");
        }

        /// <summary>
        /// Selects a decoration for purchase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectAddon_Click(object sender, EventArgs e)
        {
            if (lbAvailable.SelectedItem != null && !lbSelected.Items.Contains(lbAvailable.SelectedItem))
            {
                lbSelected.Items.Add(lbAvailable.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// Removes a selected decoration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveAddon_Click(object sender, EventArgs e)
        {
            if(lbSelected.SelectedItem !=null)
            {
                lbSelected.Items.Remove(lbSelected.SelectedItem);
            }
        }
        /// <summary>
        /// Calculates how much many and the description for the car and its decorations selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnBuy_Click(object sender, EventArgs e)
        {
            ICar car;
            if (rbVolk.Checked)
            {
                car = new VolkswagenBeetle();
            }
            else if (rbFord.Checked)
            {
                car = new FordTaunus();
            }
            else { MessageBox.Show("Please select a car!"); return; }

            foreach (string item in lbSelected.Items)
            {
                switch (item.ToString())
                {
                    case "Bull bar":
                        car = new Bullbar(car);
                        break;
                    case "Air conditioning":
                        car = new Airco(car);
                        break;
                    case "Snow tires":
                        car = new SnowTires(car);
                        break;
                }
            }
            MessageBox.Show("Your purchase is complete!\nTotal price: " + car.getPrice() + "\nDescription: " + car.getDescription());
        }
    }
   
    
}
