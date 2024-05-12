using AgroDictionary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            DisplayPlantInfo();
        }
        private void DisplayPlantInfo()
        {
            name_of_culture_label.Text = plant.Name;
            type_of_culture_label.Text = plant.Type;
            matur_time_label.Text = plant.Maturation_Time;
            fetal_weight_label.Text = plant.Weight;
            hybridity_of_culture_label.Text = plant.Hybridity;
            exp_date_label.Text = plant.Expiration_Date;
            description_of_culture_textbox.Text = plant.Description;

        }
    }
}
