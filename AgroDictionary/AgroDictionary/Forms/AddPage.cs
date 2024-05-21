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
            name_of_culture_textbox.Validating += name_of_culture_textbox_Validating;
            type_of_culture_comboBox.Validating += type_of_culture_comboBox_Validating;
            matur_time_comboBox.Validating += matur_time_comboBox_Validating;
            fetal_weight_comboBox.Validating += fetal_weight_comboBox_Validating;
            hybridity_of_culture_comboBox.Validating += hybridity_of_culture_comboBox_Validating;
            exp_date_comboBox.Validating += exp_date_comboBox_Validating;
            description_field_textBox.Validating += description_field_textBox_Validating;
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
                titleError_label1.Visible = true;
            }
            else
            {
                titleError_label1.Visible = false;
            }
        }
        private void matur_time_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (type_of_culture_comboBox.SelectedIndex == -1)
            {
                titleError_label2.Visible = true;
            }
            else
            {
                titleError_label2.Visible = false;
            }
        }
        private void fetal_weight_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (type_of_culture_comboBox.SelectedIndex == -1)
            {
                titleError_label3.Visible = true;
            }
            else
            {
                titleError_label3.Visible = false;
            }
        }
        private void hybridity_of_culture_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (type_of_culture_comboBox.SelectedIndex == -1)
            {
                titleError_label4.Visible = true;
            }
            else
            {
                titleError_label4.Visible = false;
            }
        }
        private void exp_date_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (type_of_culture_comboBox.SelectedIndex == -1)
            {
                titleError_label5.Visible = true;
            }
            else
            {
                titleError_label5.Visible = false;
            }
        }
        private void description_field_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(description_field_textBox.Text))
            {
                titleError_label6.Visible = true;
            }
            else
            {
                titleError_label6.Visible = false;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(name_of_culture_textbox.Text) || type_of_culture_comboBox.SelectedIndex == -1 || matur_time_comboBox.SelectedIndex == -1 || fetal_weight_comboBox.SelectedIndex == -1 || hybridity_of_culture_comboBox.SelectedIndex == -1 || exp_date_comboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(description_field_textBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть або оберіть усі основні параметри рослини та її опис!!! ");
                return;
            }
            string name = name_of_culture_textbox.Text;
            string type = type_of_culture_comboBox.SelectedItem.ToString();
            string matur_time = matur_time_comboBox.SelectedItem.ToString();
            string weight = fetal_weight_comboBox.SelectedItem.ToString();
            string hyb = hybridity_of_culture_comboBox.SelectedItem.ToString();
            string exp_date = exp_date_comboBox.SelectedItem.ToString();
            string description = description_field_textBox.Text;


            Plant newPlant = new Plant
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Type = type,
                Maturation_Time = matur_time,
                Weight = weight,
                Hybridity = hyb,
                Expiration_Date = exp_date,
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
