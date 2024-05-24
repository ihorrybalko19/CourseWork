using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroDictionary.Models;
using Newtonsoft.Json;

namespace AgroDictionary.Forms
{
    public partial class AddPage : Form
    {
        public AddPage()
        {
            InitializeComponent();
            name_of_culture_textbox.KeyPress += name_of_culture_textbox_KeyPress;
            name_of_culture_textbox.Validating += name_of_culture_textbox_Validating;
            type_of_culture_comboBox.Validating += type_of_culture_comboBox_Validating;
            author_comboBox.Validating += author_comboBox_Validating;
            matur_time_comboBox.Validating += matur_time_comboBox_Validating;
            fetal_weight_comboBox.Validating += fetal_weight_comboBox_Validating;
            hybridity_of_culture_comboBox.Validating += hybridity_of_culture_comboBox_Validating;
            frost_resistance_comboBox.Validating += frost_resistance_comboBox_Validating;
            exp_date_comboBox.Validating += exp_date_comboBox_Validating;
            potential_harvest_comboBox.Validating += potential_harvest_comboBox_Validating;
            description_field_textBox.Validating += description_field_textBox_Validating;
            type_of_culture_comboBox.SelectedIndexChanged += type_of_culture_comboBox_SelectedIndexChanged;
            type_of_pollution_comboBox.SelectedIndexChanged += type_of_pollution_comboBox_SelectedIndexChanged;
            cuboid_comboBox.SelectedIndexChanged += cuboid_comboBox_SelectedIndexChanged;
            indeterminate_comboBox.SelectedIndexChanged += indeterminate_comboBox_SelectedIndexChanged;
            shape_of_head_comboBox.SelectedIndexChanged += shape_of_head_comboBox_SelectedIndexChanged;
            starch_content_comboBox.SelectedIndexChanged += starch_content_comboBox_SelectedIndexChanged;
        }
        private void name_of_culture_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Введення чисел заборонено.",
                "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void name_of_culture_textbox_Validating(object? sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_of_culture_textbox.Text))
            {
                error_name_label.Visible = true;
            }
            else
            {
                error_name_label.Visible = false;
            }
        }
        private void type_of_culture_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (type_of_culture_comboBox.SelectedIndex == -1)
            {
                error_type_label.Visible = true;
            }
            else
            {
                error_type_label.Visible = false;
            }
        }
        private void author_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (author_comboBox.SelectedIndex == -1)
            {
                error_author_label.Visible = true;
            }
            else
            {
                error_author_label.Visible = false;
            }
        }
        private void matur_time_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (matur_time_comboBox.SelectedIndex == -1)
            {
                error_matur_time_label.Visible = true;
            }
            else
            {
                error_matur_time_label.Visible = false;
            }
        }
        private void fetal_weight_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (fetal_weight_comboBox.SelectedIndex == -1)
            {
                error_weight_label.Visible = true;
            }
            else
            {
                error_weight_label.Visible = false;
            }
        }
        private void hybridity_of_culture_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (hybridity_of_culture_comboBox.SelectedIndex == -1)
            {
                error_hybridity_label.Visible = true;
            }
            else
            {
                error_hybridity_label.Visible = false;
            }
        }
        private void frost_resistance_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (frost_resistance_comboBox.SelectedIndex == -1)
            {
                error_frost_resist_label.Visible = true;
            }
            else
            {
                error_frost_resist_label.Visible = false;
            }
        }
        private void exp_date_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (exp_date_comboBox.SelectedIndex == -1)
            {
                error_exp_date_label.Visible = true;
            }
            else
            {
                error_exp_date_label.Visible = false;
            }
        }
        private void potential_harvest_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (potential_harvest_comboBox.SelectedIndex == -1)
            {
                error_potential_harvest_label.Visible = true;
            }
            else
            {
                error_potential_harvest_label.Visible = false;
            }
        }
        private void description_field_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(description_field_textBox.Text))
            {
                error_description_label.Visible = true;
            }
            else
            {
                error_description_label.Visible = false;
            }
        }
        private void type_of_culture_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_of_culture_comboBox.SelectedItem == null || string.IsNullOrEmpty(type_of_culture_comboBox.Text))
            {
                type_of_pollution_comboBox.Enabled = false;
                type_of_pollution_comboBox.SelectedIndex = -1;
                cuboid_comboBox.Enabled = false;
                cuboid_comboBox.SelectedIndex = -1;
                indeterminate_comboBox.Enabled = false;
                indeterminate_comboBox.SelectedIndex = -1;
                shape_of_head_comboBox.Enabled = false;
                shape_of_head_comboBox.SelectedIndex = -1;
                starch_content_comboBox.Enabled = false;
                starch_content_comboBox.SelectedIndex = -1;
                return;
            }

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

        private void type_of_pollution_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_of_pollution_comboBox.Enabled == true)
            {

                if (type_of_pollution_comboBox.SelectedItem != null &&
                    type_of_pollution_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для огірка. " +
                        "Тому автоматично вибрана перша категорія!!!",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    type_of_pollution_comboBox.SelectedIndex = 1;
                }
            }

        }
        private void cuboid_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cuboid_comboBox.Enabled == true)
            {
                if (cuboid_comboBox.SelectedItem != null &&
                    cuboid_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для перцю. " +
                        "Тому автоматично вибрана перша категорія!!!",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuboid_comboBox.SelectedIndex = 1;
                }
            }
        }
        private void indeterminate_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (indeterminate_comboBox.Enabled == true)
            {
                if (indeterminate_comboBox.SelectedItem != null &&
                    indeterminate_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для помідора. " +
                        "Тому автоматично вибрана перша категорія!!!",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    indeterminate_comboBox.SelectedIndex = 1;
                }
            }
        }
        private void shape_of_head_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shape_of_head_comboBox.Enabled == true)
            {
                if (shape_of_head_comboBox.SelectedItem != null &&
                    shape_of_head_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для капусти." +
                        " Тому автоматично вибрана перша категорія!!!"
                        , "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    shape_of_head_comboBox.SelectedIndex = 1;
                }
            }
        }
        private void starch_content_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (starch_content_comboBox.Enabled == true)
            {
                if (starch_content_comboBox.SelectedItem != null &&
                    starch_content_comboBox.SelectedItem.ToString() == "категорія відсутня")
                {
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для картоплі. " +
                        "Тому автоматично вибрана перша категорія!!!"
                        , "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    starch_content_comboBox.SelectedIndex = 1;
                }
            }
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_of_culture_textbox.Text)
                || type_of_culture_comboBox.SelectedIndex == -1 ||
                author_comboBox.SelectedIndex == -1 ||
                matur_time_comboBox.SelectedIndex == -1 ||
                fetal_weight_comboBox.SelectedIndex == -1 ||
                hybridity_of_culture_comboBox.SelectedIndex == -1 ||
                frost_resistance_comboBox.SelectedIndex == -1 ||
                exp_date_comboBox.SelectedIndex == -1 ||
                potential_harvest_comboBox.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(description_field_textBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть або оберіть усі основні параметри рослини та її опис!!!",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете додати рослину?", "Підтвердження додавання", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string name = name_of_culture_textbox.Text;
                string type = type_of_culture_comboBox.SelectedItem.ToString();
                string author = author_comboBox.SelectedItem.ToString();
                string matur_time = matur_time_comboBox.SelectedItem.ToString();
                string weight = fetal_weight_comboBox.SelectedItem.ToString();
                string hyb = hybridity_of_culture_comboBox.SelectedItem.ToString();
                string frost_resist = frost_resistance_comboBox.SelectedItem.ToString();
                string exp_date = exp_date_comboBox.SelectedItem.ToString();
                string potential_harvest = potential_harvest_comboBox.SelectedItem.ToString();
                string type_of_poll = type_of_pollution_comboBox.SelectedItem.ToString();
                string cub = cuboid_comboBox.SelectedItem.ToString();
                string indet = indeterminate_comboBox.SelectedItem.ToString();
                string shape_head = shape_of_head_comboBox.SelectedItem.ToString();
                string starch_content = starch_content_comboBox.SelectedItem.ToString();
                string description = description_field_textBox.Text;


                Plant newPlant = new Plant
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = name,
                    Type = type,
                    Author = author,
                    Maturation_Time = matur_time,
                    Weight = weight,
                    Hybridity = hyb,
                    Frost_Resistance = frost_resist,
                    Expiration_Date = exp_date,
                    Potential_Harvest = potential_harvest,
                    Type_of_Pollution = type_of_poll,
                    Is_Cuboid = cub,
                    Is_Indeterminate = indet,
                    Shape_of_Head = shape_head,
                    Starch_Content = starch_content,
                    Description = description,
                };

                try
                {
                    string json = File.ReadAllText("data_of_plants.json");

                    List<Plant> allPlants = JsonConvert.DeserializeObject<List<Plant>>(json);

                    allPlants.Add(newPlant);

                    string updatedJson = JsonConvert.SerializeObject(allPlants, Formatting.Indented);

                    File.WriteAllText("data_of_plants.json", updatedJson);

                    MessageBox.Show("Вітаю. Нову рослину успішно додано!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка додавання рослини: " + ex.Message);
                }
            }
        }

    }
}
