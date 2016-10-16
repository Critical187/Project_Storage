using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class PushObserver : Form, IPushObserver
    {
        EarthQuake earth;
        /// <summary>
        /// Take a reference to the subject as parameter for the constructor
        /// </summary>
        public PushObserver(EarthQuake earth)
        {
            InitializeComponent();
            this.earth = earth;

            this.FormClosing += (x,y) => earth.Detach(this);
        }
        /// <summary>
        /// Receives all the parameters defined to the observer from the subject
        /// </summary>
        /// <param name="city"></param>
        /// <param name="scale"></param>
        public void Update(string city, double scale)
        {
            lblCity.Text = city;
            lblScale.Text = scale.ToString();
        }
        //attaches the observer to the subject
        private void btnA_Click(object sender, EventArgs e)
        {
            earth.Attach(this);
        }

        //detaches the observer from the subject
        private void btnD_Click(object sender, EventArgs e)
        {
            earth.Detach(this);
        }
    }
}
