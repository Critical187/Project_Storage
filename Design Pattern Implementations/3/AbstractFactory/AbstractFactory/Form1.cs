using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        private ICarFactory SelectedFactory { get { return cboxFactories.SelectedItem as ICarFactory; } }
        /// <summary>dictionary populated when the cboxFactories changes. Connects a list view item's representation to a car
        /// All selectable cars are also present in the listViewOffer
        /// </summary>
        Dictionary<ListViewItem, Car> selectableCars = new Dictionary<ListViewItem, Car>();
        /// <summary>Holds the path of an image and it's Memory representation. dictionary populated when an image is downloaded.</summary>
        Dictionary<string, Image> imageCache = new Dictionary<string, Image>();

        /// <summary>Invese iteration of selectableCars over the current selected items in the offers listView</summary>
        private Car[] SelectedCars
        {
            get
            {
                Car[] selected = new Car[listViewOffers.SelectedItems.Count];
                for (int i = 0; i < selected.Length; i++)
                {
                    selected[i] = selectableCars[listViewOffers.SelectedItems[i]];
                }
                return selected;
            }
        }

        public Form1()
        {
            InitializeComponent();
            //populates the combo box with all Factories that implement ICarFactory in the assembly of ICarFactory
            IEnumerable<Type> factories = typeof(ICarFactory).Assembly.GetTypes().Where(x => x.GetInterfaces().Where(y => y == typeof(ICarFactory)).Any());
            cboxFactories.Items.AddRange(factories.Select(x => Activator.CreateInstance(x)).ToArray());

            //generate image container for the car's images for the list views
            ImageList carsImageList = new ImageList();
            carsImageList.ImageSize = new System.Drawing.Size(64, 64);

            listViewCars.LargeImageList = carsImageList;
            listViewOffers.LargeImageList = carsImageList;

            listViewCars.SmallImageList = carsImageList;
            listViewOffers.SmallImageList = carsImageList;
        }
        
        /// <summary>Downloads an image at specified html path</summary>
        /// <returns>null when unsuccesful or Bitmap of the downloaded image</returns>
        private Image DownloadImage(string url)
        {
            if (imageCache.ContainsKey(url)) return imageCache[url];
            Image result = null;
            var request = System.Net.WebRequest.Create(url);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
                result = Bitmap.FromStream(stream);
            if(result != null)
                imageCache.Add(url, result);
            return result;
        }

        /// <summary> Populates the offers list view and specific selection boxes</summary>
        private void FillBrandCars(ICarFactory factory)
        {
            this.listViewOffers.Clear();
            selectableCars.Clear();
            if (factory == null)
            {
                lowCostPurchaseBtn.Enabled = false;
                medCostPurchaseBtn.Enabled = false;
                highCostPurchaseBtn.Enabled = false;
                return;
            }

            lowCostPurchaseBtn.Enabled = true;
            medCostPurchaseBtn.Enabled = true;
            highCostPurchaseBtn.Enabled = true;

            foreach (var car in factory.AllModels())
            {
                ListViewItem item = new ListViewItem(car.Description);

                //add image to listView's image container if not existing
                if (!this.listViewOffers.LargeImageList.Images.ContainsKey(car.ImageURL))
                    this.listViewOffers.LargeImageList.Images.Add(car.ImageURL, DownloadImage(car.ImageURL));

                item.ImageKey = car.ImageURL;
                this.listViewOffers.Items.Add(item);

                selectableCars.Add(item, car);
            }

            SetSingleSelectCar(factory.CreateLowCostCar(), lowCostPB, lowCostTBox);
            SetSingleSelectCar(factory.CreateMediumCostCar(), medCostPB, medCostTBox);
            SetSingleSelectCar(factory.CreateHighCostCar(), highCostPB, highCostTBox);
        }

        private void SetSingleSelectCar(Car car, PictureBox imageBox, RichTextBox descriptionBox)
        {
            imageBox.Image = imageCache[car.ImageURL];
            descriptionBox.Text = car.Description;
        }

        private void listViewOffers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOffers.SelectedItems.Count == 0)
                purchaseBtn.Enabled = false;
            else
                purchaseBtn.Enabled = true;
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewOffers.SelectedItems)
            {
                BuyCar(item.ImageKey);
            }
        }

        private void cboxFactories_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillBrandCars(SelectedFactory);
        }

        private void lowCostPurchaseBtn_Click(object sender, EventArgs e)
        {
            BuyCar(lowCostPB);
        }

        private void medCostPurchaseBtn_Click(object sender, EventArgs e)
        {
            BuyCar(medCostPB);
        }

        private void highCostPurchaseBtn_Click(object sender, EventArgs e)
        {
            BuyCar(highCostPB);
        }

        /// <summary>Buys a car corresponding to the picture box's image</summary>
        private void BuyCar(PictureBox pictureBox)
        {
            BuyCar(pictureBox.Image);
        }

        /// <summary>Iterates all images in the cache to find it's html Path represntation and buy it based on the path found</summary>
        private void BuyCar(Image image)
        {
            foreach (var cachedImage in imageCache)
            {
                if (cachedImage.Value == image)
                {
                    BuyCar(cachedImage.Key);
                    return;
                }
            }
        }

        ///<summary>iterates all cars from the current brand within the listViewOffers to find the one with the corresponding image</summary>
        private void BuyCar(string imageURL)
        {
            foreach (var car in selectableCars)
            {
                if (car.Value.ImageURL == imageURL)
                {
                    listViewCars.Items.Add(car.Key.Clone() as ListViewItem);
                    return;
                }
            }
        }
    }
}
