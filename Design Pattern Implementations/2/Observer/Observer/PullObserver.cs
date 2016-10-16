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
    public partial class PullObserver : Form, IPullObserver
    {
        EarthQuake earth;
        /// <summary>
        /// Take a reference to the subject as parameter for the constructor
        /// </summary>
        public PullObserver(EarthQuake earth)
        {
            InitializeComponent();
            chart1.Series.Clear();
            this.earth = earth;

            this.FormClosing += (x,y) => earth.Detach(this);
        }
        /// <summary>
        /// updates the form using the params from the subject
        /// </summary>
        public void Update()
        {
            if (!chart1.Series.Any(x => x.Name == earth.City))
                chart1.Series.Add(earth.City);
            chart1.Series[earth.City].Points.Add(earth.ScaleOfQuake);
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
