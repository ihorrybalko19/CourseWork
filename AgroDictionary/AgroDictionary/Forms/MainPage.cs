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
            result_field_listbox.SelectedIndexChanged += result_field_listbox_SelectedIndexChanged;
            name_of_culture_textbox.Validating += name_of_culture_textbox_Validating;
            type_of_culture_comboBox.Validating += type_of_culture_comboBox_Validating;
        }
        private void name_of_culture_textbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_of_culture_textbox.Text))
            {
                titleError_label.Visible = true;
            }
            else
            {
                titleError_label.Visible = false;
            }
        }
        private void type_of_culture_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (type_of_culture_comboBox.SelectedIndex == -1)
            {
                titleError2_label.Visible = true;
            }
            else
            {
                titleError2_label.Visible = false;
            }
        }
        private void search_button_Click(object sender, EventArgs e) 
        { 
            if (string.IsNullOrWhiteSpace(name_of_culture_textbox.Text) || type_of_culture_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка, введіть або оберіть обов'язкові поля: назву та вид рослини!!! ");
                return;
            }
            result_field_listbox.Items.Clear();

            string NamePlant = name_of_culture_textbox.Text;
            string TypePlant = type_of_culture_comboBox.Text;
            string MaturTimePlant = matur_time_comboBox.Text;
            string WeightPlant = fetal_weight_comboBox.Text;
            string HybridityPlant = hybridity_of_culture_comboBox.Text;
            string ExpDatePlant = exp_date_comboBox.Text;

            SearchClass search = new SearchClass();
            search.Load_Data_From_JSON("data_of_plants.json");

            List<Plant> searchresults = search.SearchInfo(NamePlant, TypePlant, MaturTimePlant, WeightPlant, HybridityPlant, ExpDatePlant);

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
                result_field_listbox.Items.Clear();
            }
        }
        private void result_field_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (result_field_listbox.SelectedItem != null)
                { 
                    
                    string selectedplant = result_field_listbox.SelectedItem.ToString();

                    string jsonString = selectedplant.Substring(selectedplant.IndexOf("                                                                                                                                                                    ") + 1).Trim();

                    Plant selectedPlant = JsonConvert.DeserializeObject<Plant>(jsonString);

                    ShowPlantInfo(selectedPlant);

                    result_field_listbox.Items.Clear();
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
        
        private void ShowPlantInfo(Plant plant)
        {
            
            InfoForm plantDetailsForm = new InfoForm(plant);

            plantDetailsForm.ShowDialog();
        }
    }
}
