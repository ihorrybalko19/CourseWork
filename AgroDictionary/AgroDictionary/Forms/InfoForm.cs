using AgroDictionary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroDictionary.Forms
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }
      
        private Plant plant;

        public InfoForm(Plant plant)
        {
            InitializeComponent();
            this.plant = plant;
            /*DisplayPlantDetails();*/
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
