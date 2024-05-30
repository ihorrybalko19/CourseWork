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

namespace AgroDictionary.Forms
{
    public partial class DeletePage : Form
    {
        public DeletePage()
        {
            InitializeComponent();
            name_of_culture_textbox.KeyPress += name_of_culture_textbox_KeyPress;
            search_button.Click += search_button_Click;
            result_field_listbox.SelectedIndexChanged += result_field_listbox_SelectedIndexChanged;
            type_of_culture_comboBox.SelectedIndexChanged += type_of_culture_comboBox_SelectedIndexChanged;
            type_of_pollution_comboBox.SelectedIndexChanged += type_of_pollution_comboBox_SelectedIndexChanged;
            cuboid_comboBox.SelectedIndexChanged += cuboid_comboBox_SelectedIndexChanged;
            indeterminate_comboBox.SelectedIndexChanged += indeterminate_comboBox_SelectedIndexChanged;
            shape_of_head_comboBox.SelectedIndexChanged += shape_of_head_comboBox_SelectedIndexChanged;
            starch_content_comboBox.SelectedIndexChanged += starch_content_comboBox_SelectedIndexChanged;

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
                    type_of_pollution_comboBox.SelectedIndex = -1;
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
                    cuboid_comboBox.SelectedIndex = -1;
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
                    indeterminate_comboBox.SelectedIndex = -1;
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
                    shape_of_head_comboBox.SelectedIndex = -1;
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
                    starch_content_comboBox.SelectedIndex = -1;
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
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для огірка.",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    type_of_pollution_comboBox.SelectedIndex = -1;
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
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для перцю.",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cuboid_comboBox.SelectedIndex = -1;
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
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для помідора.",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    indeterminate_comboBox.SelectedIndex = -1;
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
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для капусти."
                        , "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    shape_of_head_comboBox.SelectedIndex = -1;
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
                    MessageBox.Show("Неможливо вибрати 'категорія відсутня' для картоплі."
                        , "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    starch_content_comboBox.SelectedIndex = -1;
                }
            }
        }


        private void search_button_Click(object? sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(name_of_culture_textbox.Text) &&
        string.IsNullOrWhiteSpace(type_of_culture_comboBox.Text) &&
        string.IsNullOrWhiteSpace(author_comboBox.Text) &&
        string.IsNullOrWhiteSpace(matur_time_comboBox.Text) &&
        string.IsNullOrWhiteSpace(fetal_weight_comboBox.Text) &&
        string.IsNullOrWhiteSpace(hybridity_of_culture_comboBox.Text) &&
        string.IsNullOrWhiteSpace(frost_resistance_comboBox.Text) &&
        string.IsNullOrWhiteSpace(exp_date_comboBox.Text) &&
        string.IsNullOrWhiteSpace(potential_harvest_comboBox.Text))
            {
                MessageBox.Show("Увага!!! Ви не ввели жоден параметр. " +
                    "\nБудь ласка, введіть або виберіть хоча б один із основних параметрів",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result_field_listbox.Items.Clear();
                return;
            }

            result_field_listbox.Items.Clear();

            string NamePlant = name_of_culture_textbox.Text;

            string TypePlant = type_of_culture_comboBox.Text;

            string AuthorPlant = author_comboBox.Text;

            string MaturTimePlant = matur_time_comboBox.Text;

            string WeightPlant = fetal_weight_comboBox.Text;

            string HybridityPlant = hybridity_of_culture_comboBox.Text;

            string FrostResistancePlant = frost_resistance_comboBox.Text;

            string ExpDatePlant = exp_date_comboBox.Text;

            string PotentialHarvest = potential_harvest_comboBox.Text;

            string TypePollutionPlant = string.Empty;

            string CuboidPlant = string.Empty;

            string IndeterminatePlant = string.Empty;

            string ShapeHeadPlant = string.Empty;

            string StarchContentPlant = string.Empty;

            string selectedCultureType = type_of_culture_comboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCultureType))
            {
                switch (selectedCultureType)
                {
                    case "огірок":
                        TypePollutionPlant = type_of_pollution_comboBox.Text;
                        break;
                    case "перець":
                        CuboidPlant = cuboid_comboBox.Text;
                        break;
                    case "помідор":
                        IndeterminatePlant = indeterminate_comboBox.Text;
                        break;
                    case "капуста":
                        ShapeHeadPlant = shape_of_head_comboBox.Text;
                        break;
                    case "картопля":
                        StarchContentPlant = starch_content_comboBox.Text;
                        break;
                }
            }


            SearchClass search = new SearchClass();
            search.Load_Data_From_JSON("data_of_plants.json");

            List<Plant> searchresults = search.SearchInfo(NamePlant,
                TypePlant, AuthorPlant, MaturTimePlant, WeightPlant,
                HybridityPlant, FrostResistancePlant, ExpDatePlant,
                PotentialHarvest, TypePollutionPlant, CuboidPlant,
                IndeterminatePlant, ShapeHeadPlant, StarchContentPlant);

            if (searchresults.Count > 0)
            {
                foreach (var res in searchresults)
                {
                    string JSONplant = JsonConvert.SerializeObject(res);
                    result_field_listbox.Items.Add(res.Name + ", " + res.Type + "                                                                                                                                                                    " + JSONplant);
                }
            }
            else
            {
                MessageBox.Show("На жаль, результатів не знайдено. \nПримітка:" +
                    " якщо ви шукали культуру за ім'ям та іншим параметром," +
                    " то перевірте, чи немає у полі 'Ім'я культури' випадкових" +
                    " пробілів. Якщо є, то приберіть їх будь ласка, щоб полегшити" +
                    " пошук або введіть назву культури, якщо потрібно");

                result_field_listbox.Items.Clear();
            }
        }


        private void result_field_listbox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (result_field_listbox.SelectedItem != null)
            {
                string selectedplant = result_field_listbox.SelectedItem.ToString();

                string json_String = selectedplant.Substring(selectedplant.IndexOf("                                                                                                                                                                    ") + 1).Trim();

                Plant selected_Plant = JsonConvert.DeserializeObject<Plant>(json_String);

                DialogResult resultop = MessageBox.Show("Ви впевнені, " +
                    "що хочете видалити рослину?", "Підтвердження видалення"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultop == DialogResult.Yes)
                {
                    string json = File.ReadAllText("data_of_plants.json");

                    List<Plant> all_Plants = JsonConvert.DeserializeObject<List<Plant>>(json);

                    DeletePlant(selected_Plant, all_Plants);

                    MessageBox.Show("Вітаю. Рослина була успішно видалена!!!", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void DeletePlant(Plant deleted_Plant, List<Plant> all_Plants)
        {
            int index = all_Plants.FindIndex(p => p.Id == deleted_Plant.Id);

            if (index != -1)
            {
                all_Plants.RemoveAt(index);

                string updated_JSON = JsonConvert.SerializeObject(all_Plants, Formatting.Indented);

                File.WriteAllText("data_of_plants.json", updated_JSON);

                result_field_listbox.Items.Remove(result_field_listbox.SelectedItem);
            }
        }
        private void clear_button_Click_1(object? sender, EventArgs e)
        {
            name_of_culture_textbox.Text = "";

            type_of_culture_comboBox.SelectedIndex = -1;

            author_comboBox.SelectedIndex = -1;

            matur_time_comboBox.SelectedIndex = -1;

            fetal_weight_comboBox.SelectedIndex = -1;

            hybridity_of_culture_comboBox.SelectedIndex = -1;

            frost_resistance_comboBox.SelectedIndex = -1;

            exp_date_comboBox.SelectedIndex = -1;

            potential_harvest_comboBox.SelectedIndex = -1;

            type_of_pollution_comboBox.SelectedIndex = -1;

            cuboid_comboBox.SelectedIndex = -1;

            indeterminate_comboBox.SelectedIndex = -1;

            shape_of_head_comboBox.SelectedIndex = -1;

            starch_content_comboBox.SelectedIndex = -1;

            result_field_listbox.Items.Clear();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
