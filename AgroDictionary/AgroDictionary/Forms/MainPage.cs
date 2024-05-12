using AgroDictionary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgroDictionary.Forms
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string NamePlant = name_of_culture_textbox.Text;
            string TypePlant = type_of_culture_comboBox.Text;
            string MaturTimePlant = matur_time_comboBox.Text;
            string WeightPlant = fetal_weight_comboBox.Text;
            string HybridityPlant = hybridity_of_culture_comboBox.Text;
            string ExpDatePlant = exp_date_comboBox.Text;

            SearchClass search = new SearchClass();
            search.Load_Data_From_JSON("data_of_plants.json");

            List<Plant> searchresults = search.SearchInfo(NamePlant, TypePlant, MaturTimePlant, WeightPlant, HybridityPlant, ExpDatePlant);

            result_field_listbox.Items.Clear();

            if (searchresults.Count > 0)
            {
                foreach (var res in searchresults)
                {
                    string JSONplant = JsonConvert.SerializeObject(res);
                    result_field_listbox.Items.Add(res.Name + "                                                                                                                                                                    " + JSONplant);
                }
            }
            else
            {
                MessageBox.Show("На жаль, результатів не знайдено.");
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            name_of_culture_textbox.Text = "";
            type_of_culture_comboBox.SelectedIndex = -1;
            matur_time_comboBox.SelectedIndex = -1;
            fetal_weight_comboBox.SelectedIndex = -1;
            hybridity_of_culture_comboBox.SelectedIndex = -1;
            exp_date_comboBox.SelectedIndex = -1;
        }

        private void result_field_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (result_field_listbox.SelectedItem != null)
            {
                // Отримати вибраний об'єкт JSON з ListBox
                string selectedplant = result_field_listbox.SelectedItem.ToString();

                // Extract the JSON part from the selected item
                string jsonString = selectedplant.Substring(selectedplant.IndexOf("                                                                                                                                                                    ") + 1).Trim();

                // Перетворити JSON-рядок на об'єкт Plant
                Plant selectedPlant = JsonConvert.DeserializeObject<Plant>(jsonString);

                // Показати форму з детальною інформацією про рослину
                ShowPlantInfo(selectedPlant);

                result_field_listbox.Items.Clear();
            }

        }
        private void ShowPlantInfo(Plant plant)
        {
            
            InfoForm plantDetailsForm = new InfoForm(plant);
            plantDetailsForm.ShowDialog();
        }
    }
}
