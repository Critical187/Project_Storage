using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            clbMenu.Items.Add("Steak");
            clbMenu.Items.Add("Fries");
            clbMenu.Items.Add("Tea");
            for (int i = 1; i < 5; i++)
            {
                cbDisc.Items.Add(i);
            }
            cbDisc.SelectedItem = 1;
            rbSpecial.Checked = true;
            cbFirst.Enabled = false;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cbFirst.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cbFirst.Enabled = false;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            IRestaurantVisitor visitor = new SpecialRestaurantVisitor(Convert.ToInt32(cbDisc.Text));
            Steak steak;
            Fries fries;
            Tea tea;
            int cost=0;
            if(rbNormal.Checked)
            {
                if (cbFirst.Checked) { visitor = new RestaurantVisitor(true); }
                else {visitor = new RestaurantVisitor(false); } 
            }
            else if (rbSpecial.Checked)
            {
                visitor = new SpecialRestaurantVisitor(Convert.ToInt32(cbDisc.Text));
            }
            foreach(string item in clbMenu.CheckedItems)
            {
                switch (item.ToString())
                {
                    case "Steak":
                        if (cbSteak.Checked) { steak = new Steak(true); }
                        else { steak = new Steak(false); }
                        cost += steak.Accept(visitor);
                        break;
                    case "Tea":
                        if (cbTea.Checked) { tea = new Tea(true); }
                        else { tea = new Tea(false); }
                        cost += tea.Accept(visitor);
                        break;
                    case "Fries":
                        if (cbFries.Checked) { fries = new Fries(true); }
                        else { fries = new Fries(false); }
                        cost += fries.Accept(visitor);
                        break;
                }
            }
            MessageBox.Show("Your expenses: " + cost.ToString());
        }

    }
}
