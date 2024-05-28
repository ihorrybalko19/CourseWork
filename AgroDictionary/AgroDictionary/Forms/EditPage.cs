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
            name_of_culture_textbox.KeyPress += name_of_culture_textbox_KeyPress;
            type_of_culture_comboBox.SelectedIndexChanged += type_of_culture_comboBox_SelectedIndexChanged;
            type_of_pollution_comboBox.SelectedIndexChanged += type_of_pollution_comboBox_SelectedIndexChanged;
            cuboid_comboBox.SelectedIndexChanged += cuboid_comboBox_SelectedIndexChanged;
            indeterminate_comboBox.SelectedIndexChanged += indeterminate_comboBox_SelectedIndexChanged;
            shape_of_head_comboBox.SelectedIndexChanged += shape_of_head_comboBox_SelectedIndexChanged;
            starch_content_comboBox.SelectedIndexChanged += starch_content_comboBox_SelectedIndexChanged;

            this.plant = plant;
            this.jsonFilePath = jsonFilePath;
            DisplayPlantDetails();
        }
        private void name_of_culture_textbox_Validating(object? sender, CancelEventArgs e)
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
        private void description_field_textBox_Validating(object? sender, CancelEventArgs e)
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
        private void name_of_culture_textbox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Введення чисел заборонено.",
                "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void type_of_culture_comboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {

            string selectedCultureType = type_of_culture_comboBox.SelectedItem.ToString().ToLower();

            switch (selectedCultureType)
            {
                case "огірок":
                    type_of_pollution_comboBox.Enabled = true;
                    type_of_pollution_comboBox.SelectedIndex = 1;
                    cuboid_comboBox.Enabled = false;
                    cuboid_comboBox.SelectedIndex = 0;
                    indeterminate_comboBox.Enabled = false;
                    indeterminate_comboBox.SelectedIndex = 0;
                    shape_of_head_comboBox.Enabled = false;
                    shape_of_head_comboBox.SelectedIndex = 0;
                    starch_content_comboBox.Enabled = false;
                    starch_content_comboBox.SelectedIndex = 0;
                    break;
                case "перець":
                    cuboid_comboBox.Enabled = true;
                    cuboid_comboBox.SelectedIndex = 1;
                    type_of_pollution_comboBox.Enabled = false;
                    type_of_pollution_comboBox.SelectedIndex = 0;
                    indeterminate_comboBox.Enabled = false;
                    indeterminate_comboBox.SelectedIndex = 0;
                    shape_of_head_comboBox.Enabled = false;
                    shape_of_head_comboBox.SelectedIndex = 0;
                    starch_content_comboBox.Enabled = false;
                    starch_content_comboBox.SelectedIndex = 0;
                    break;
                case "помідор":
                    indeterminate_comboBox.Enabled = true;
                    indeterminate_comboBox.SelectedIndex = 1;
                    type_of_pollution_comboBox.Enabled = false;
                    type_of_pollution_comboBox.SelectedIndex = 0;
                    cuboid_comboBox.Enabled = false;
                    cuboid_comboBox.SelectedIndex = 0;
                    shape_of_head_comboBox.Enabled = false;
                    shape_of_head_comboBox.SelectedIndex = 0;
                    starch_content_comboBox.Enabled = false;
                    starch_content_comboBox.SelectedIndex = 0;
                    break;
                case "капуста":
                    shape_of_head_comboBox.Enabled = true;
                    shape_of_head_comboBox.SelectedIndex = 1;
                    type_of_pollution_comboBox.Enabled = false;
                    type_of_pollution_comboBox.SelectedIndex = 0;
                    cuboid_comboBox.Enabled = false;
                    cuboid_comboBox.SelectedIndex = 0;
                    indeterminate_comboBox.Enabled = false;
                    indeterminate_comboBox.SelectedIndex = 0;
                    starch_content_comboBox.Enabled = false;
                    starch_content_comboBox.SelectedIndex = 0;
                    break;
                case "картопля":
                    starch_content_comboBox.Enabled = true;
                    starch_content_comboBox.SelectedIndex = 1;
                    type_of_pollution_comboBox.Enabled = false;
                    type_of_pollution_comboBox.SelectedIndex = 0;
                    cuboid_comboBox.Enabled = false;
                    cuboid_comboBox.SelectedIndex = 0;
                    indeterminate_comboBox.Enabled = false;
                    indeterminate_comboBox.SelectedIndex = 0;
                    shape_of_head_comboBox.Enabled = false;
                    shape_of_head_comboBox.SelectedIndex = 0;
                    break;
            }
        }
        private void type_of_pollution_comboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (type_of_pollution_comboBox.Enabled == true)
            {

                if (type_of_pollution_comboBox.SelectedItem != null &&
                    type_of_pollution_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для огірка. " +
                        "\nТому автоматично вибрана перша категорія!!!",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    type_of_pollution_comboBox.SelectedIndex = 1;
                }
            }

        }
        private void cuboid_comboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cuboid_comboBox.Enabled == true)
            {
                if (cuboid_comboBox.SelectedItem != null &&
                    cuboid_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для перцю. " +
                        "\nТому автоматично вибрана перша категорія!!!",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuboid_comboBox.SelectedIndex = 1;
                }
            }
        }
        private void indeterminate_comboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (indeterminate_comboBox.Enabled == true)
            {
                if (indeterminate_comboBox.SelectedItem != null &&
                    indeterminate_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для помідора. " +
                        "\nТому автоматично вибрана перша категорія!!!",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    indeterminate_comboBox.SelectedIndex = 1;
                }
            }
        }
        private void shape_of_head_comboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (shape_of_head_comboBox.Enabled == true)
            {
                if (shape_of_head_comboBox.SelectedItem != null &&
                    shape_of_head_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для капусти." +
                        "\nТому автоматично вибрана перша категорія!!!"
                        , "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    shape_of_head_comboBox.SelectedIndex = 1;
                }
            }
        }
        private void starch_content_comboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (starch_content_comboBox.Enabled == true)
            {
                if (starch_content_comboBox.SelectedItem != null &&
                    starch_content_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для картоплі. " +
                        "\nТому автоматично вибрана перша категорія!!!"
                        , "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    starch_content_comboBox.SelectedIndex = 1;
                }
            }
        }
        private void DisplayPlantDetails()
        {
            name_of_culture_textbox.Text = plant.Name;

            type_of_culture_comboBox.SelectedItem = plant.Type;

            author_comboBox.SelectedItem = plant.Author;

            matur_time_comboBox.SelectedItem = plant.Maturation_Time;

            fetal_weight_comboBox.SelectedItem = plant.Weight;

            hybridity_of_culture_comboBox.SelectedItem = plant.Hybridity;

            frost_resistance_comboBox.SelectedItem = plant.Frost_Resistance;

            exp_date_comboBox.SelectedItem = plant.Expiration_Date;

            potential_harvest_comboBox.SelectedItem = plant.Potential_Harvest;

            type_of_pollution_comboBox.SelectedItem = plant.Type_of_Pollution;

            cuboid_comboBox.SelectedItem = plant.Is_Cuboid;

            indeterminate_comboBox.SelectedItem = plant.Is_Indeterminate;

            shape_of_head_comboBox.SelectedItem = plant.Shape_of_Head;

            starch_content_comboBox.SelectedItem = plant.Starch_Content;

            description_field_textBox.Text = plant.Description;
        }

        private void save_button_Click(object? sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(description_field_textBox.Text) || string.IsNullOrWhiteSpace(name_of_culture_textbox.Text))
            {
                MessageBox.Show("Будь ласка, введіть обов'язкові поля: назву та опис!!! ");
                return;
            }
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?", 
                "Підтвердження збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Plant updatedPlant = new Plant
                {
                    Id = plant.Id,

                    Name = name_of_culture_textbox.Text,

                    Type = type_of_culture_comboBox.SelectedItem.ToString(),

                    Author = author_comboBox.SelectedItem.ToString(),

                    Maturation_Time = matur_time_comboBox.SelectedItem.ToString(),

                    Weight = fetal_weight_comboBox.SelectedItem.ToString(),

                    Hybridity = hybridity_of_culture_comboBox.SelectedItem.ToString(),

                    Frost_Resistance = frost_resistance_comboBox.SelectedItem.ToString(),

                    Expiration_Date = exp_date_comboBox.SelectedItem.ToString(),

                    Potential_Harvest = potential_harvest_comboBox.SelectedItem.ToString(),

                    Type_of_Pollution = type_of_pollution_comboBox.SelectedItem.ToString(),

                    Is_Cuboid = cuboid_comboBox.SelectedItem.ToString(),

                    Is_Indeterminate = indeterminate_comboBox.SelectedItem.ToString(),

                    Shape_of_Head = shape_of_head_comboBox.SelectedItem.ToString(),

                    Starch_Content = starch_content_comboBox.SelectedItem.ToString(),

                    Description = description_field_textBox.Text
                };

                SaveChangesToJSON(updatedPlant);

                OnSaved(EventArgs.Empty);
                MessageBox.Show("Ваші зміни були збережені!!!");

                this.Close();
            }
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

        private void cancel_button_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
