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
    public partial class EditPage : Form
    {
        private Plant plant;
        private string jsonFilePath;
        public event EventHandler Saved;
        public EditPage(Plant plant, string jsonFilePath)
        {
            InitializeComponent();
            name_of_culture_textbox.Validating += name_of_culture_textbox_Validating;
            description_field_textBox.Validating += description_field_textBox_Validating;
            this.plant = plant;
            this.jsonFilePath = jsonFilePath;
            DisplayPlantDetails();
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
        private void description_field_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(description_field_textBox.Text))
            {
                titleError_label1.Visible = true;
            }
            else
            {
                titleError_label1.Visible = false;
            }
        }
        private void DisplayPlantDetails()
        {
            name_of_culture_textbox.Text = plant.Name;
            type_of_culture_comboBox.SelectedItem = plant.Type;
            matur_time_comboBox.SelectedItem = plant.Maturation_Time;
            fetal_weight_comboBox.SelectedItem = plant.Weight;
            hybridity_of_culture_comboBox.SelectedItem = plant.Hybridity;
            exp_date_comboBox.SelectedItem = plant.Expiration_Date;
            description_field_textBox.Text = plant.Description;
        }

        private void save_button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(description_field_textBox.Text) || string.IsNullOrWhiteSpace(name_of_culture_textbox.Text))
            {
                MessageBox.Show("Будь ласка, введіть обов'язкові поля: назву та опис!!! ");
                return;
            }
                Plant updatedPlant = new Plant
            {
                Id = plant.Id,
                Name = name_of_culture_textbox.Text,
                Type = type_of_culture_comboBox.SelectedItem.ToString(),
                Maturation_Time = matur_time_comboBox.SelectedItem.ToString(),
                Weight = fetal_weight_comboBox.SelectedItem.ToString(),
                Hybridity = hybridity_of_culture_comboBox.SelectedItem.ToString(),
                Expiration_Date = exp_date_comboBox.SelectedItem.ToString(),
                Description = description_field_textBox.Text
            };

            SaveChangesToJSON(updatedPlant);

            OnSaved(EventArgs.Empty);
            MessageBox.Show("Ваші зміни були збережені!!!");

            this.Close();
        }
        public void SaveChangesToJSON(Plant updatedPlant)
        {
            try
            {

                string json = File.ReadAllText(jsonFilePath);


                List<Plant> allPlants = JsonConvert.DeserializeObject<List<Plant>>(json);


                int index = allPlants.FindIndex(p => p.Id == updatedPlant.Id);


                allPlants[index] = updatedPlant;


                string updatedJson = JsonConvert.SerializeObject(allPlants, Formatting.Indented);


                File.WriteAllText(jsonFilePath, updatedJson);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Помилка збереження даних у файл JSON: " + ex.Message);
            }
        }
        public virtual void OnSaved(EventArgs e)
        {
            Saved?.Invoke(this, e);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
