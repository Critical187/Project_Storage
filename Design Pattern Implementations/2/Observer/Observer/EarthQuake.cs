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
    public partial class EarthQuake : Form, IEarthQuake
    {
        private List<string> cities = new List<string>()
        {
            "Eindhoven", "Sofia", "Springfield", "Moscow", "London"
        };

        public string City { get; private set; }
        public double ScaleOfQuake { get; private set; }
        List<IPullObserver> pullObservers;
        List<IPushObserver> pushObservers;
        public EarthQuake()
        {
            InitializeComponent();
            pullObservers = new List<IPullObserver>();
            pushObservers = new List<IPushObserver>();
            City = "";
            ScaleOfQuake = 0;
        }
        //attaches a pull observer
        public void Attach(IPullObserver observer)
        {
            bool exists = pullObservers.Contains(observer);
            if (!exists)
            {
                pullObservers.Add(observer);
                lblNum2.Text = pullObservers.Count.ToString();
            }
        }
        //attaches a push observer
        public void Attach(IPushObserver observer)
        {
            bool exists = pushObservers.Contains(observer);
            if (!exists)
            {
                pushObservers.Add(observer);
                lblNum1.Text = pushObservers.Count.ToString();
            }
        }
        //detaches a push observer
        public void Detach(IPushObserver observer)
        {
            bool exists = pushObservers.Contains(observer);
            if (exists)
            {
                pushObservers.Remove(observer);
                lblNum1.Text = pushObservers.Count.ToString();
            }
        }
        //detaches a pull observer
        public void Detach(IPullObserver observer)
        {
            bool exists = pullObservers.Contains(observer);
            if (exists)
            {
                pullObservers.Remove(observer);
                lblNum2.Text = pullObservers.Count.ToString();
            }
        }
        /// <summary>
        /// updates all the information for all the observers
        /// </summary>
        public void Notify()
        {
            foreach (IPullObserver observer in pullObservers)
            {
                observer.Update();
            }

            foreach (IPushObserver observer in pushObservers)
            {
                observer.Update(City, ScaleOfQuake);
            }
        }

        //creates a new pull observer
        private void button2_Click(object sender, EventArgs e)
        {
            new PullObserver(this).Show();
        }

        //creates a new push observer
        private void btnCPush_Click(object sender, EventArgs e)
        {
            new PushObserver(this).Show();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            City = tbCity.Text;
            if (tbScale.Text.Length == 0) tbScale.Text = "0";
            ScaleOfQuake = Convert.ToDouble(tbScale.Text);
            Notify();
        }

        Random generator = new Random();

        private void quakeTimer_Tick(object sender, EventArgs e)
        {
            if (pullObservers.Count == 0 && pushObservers.Count == 0) return;

            double scale = generator.Next(0, 12) * generator.NextDouble();
            int cityID = generator.Next(cities.Count);

            this.City = cities[cityID];
            this.ScaleOfQuake = scale;

            Notify();
        }
    }
}
