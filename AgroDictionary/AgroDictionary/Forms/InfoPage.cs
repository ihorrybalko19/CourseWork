﻿using AgroDictionary.Models;
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
    public partial class InfoPage : Form
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private Plant plant;

        public InfoPage(Plant plant)
        {
            InitializeComponent();
            this.plant = plant;
            DisplayPlantInfo();
        }
        private void DisplayPlantInfo()
        {
            name_of_culture_label.Text = plant.Name;
            type_of_culture_label.Text = plant.Type;
            author_label.Text = plant.Author;
            matur_time_label.Text = plant.Maturation_Time;
            fetal_weight_label.Text = plant.Weight;
            hybridity_of_culture_label.Text = plant.Hybridity;
            frost_resistance_label.Text = plant.Frost_Resistance;
            exp_date_label.Text = plant.Expiration_Date;
            potential_of_harvest_label.Text = plant.Potential_Harvest;
            pollination_type_label.Text = plant.Type_of_Pollution;
            cuboid_label.Text = plant.Is_Cuboid;
            indeterminate_label.Text = plant.Is_Indeterminate;
            shape_of_head_label.Text = plant.Shape_of_Head;
            starch_content_label.Text = plant.Starch_Content;
            description_of_culture_textbox.Text = plant.Description;

        }

        private void редагуватиРослинуToolStripMenuItem1_Click(object? sender, EventArgs e)
        {
            EditPage edit_page = new EditPage(plant, "data_of_plants.json");

            edit_page.Saved += EditForm_Saved;

            edit_page.ShowDialog();

        }
        private void EditForm_Saved(object? sender, EventArgs e)
        {

            this.Close();
        }

    }
}
