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
    public partial class SummonerMatchHIstory : Form
    {
        public SummonerMatchHIstory()
        {
            InitializeComponent();

            //Change title
            this.Text = "Summoner Match History";
        }

        //Overloaded constructor with summoner name
        public SummonerMatchHIstory(string name)
        {
            InitializeComponent();

            //Change title and capitlize first letter in the summoners name
            this.Text = "Match History For " + name.First().ToString().ToUpper() + name.Substring(1);
        }

        private void SummonerMatchHIstory_Load(object sender, EventArgs e)
        {

        }
    }
}
