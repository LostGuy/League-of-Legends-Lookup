using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_of_Legends_Lookup
{
    public partial class Form1 : Form
    {
        //Array to hold all of League's regions
        string[] regions = {"br", "eune", "euw", "kr", "lan", "las", "na", "oce", "ru", "tr"};

        public Form1()
        {
            InitializeComponent();

            //Change title
            this.Text = "League of Legends Lookup";

            //Set background images
            setImages();

            //Populate Combo Boxes
            populateComboBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //First tab
                Image temp = (Image)(new Bitmap(Image.FromFile("images/tab1Backgroundv2.jpg"), tab1Image.Width, tab1Image.Height));
                tab1Image.Image = temp;
            }
            catch(Exception ex)
            {

            }
            
        }

        //Set the background images
        private void setImages()
        {
            
        }

        //Populate Combo Boxes
        private void populateComboBoxes()
        {
            tab1ComboBox.Items.AddRange(regions);
        }

        private void summonerLookupButton_Click(object sender, EventArgs e)
        {
            //Make sure there are values to pass
            if (tab1ComboBox.Text != "" && summonerNameBox.Text != "")
            {
                src.SummonerLookup sl = new src.SummonerLookup(tab1ComboBox.Text, summonerNameBox.Text);
            }
        }
    }
}
