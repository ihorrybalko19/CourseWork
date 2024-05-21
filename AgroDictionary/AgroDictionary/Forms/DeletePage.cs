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
                MessageBox.Show("Будь ласка, введіть або оберіть обов'язкові поля: назву та вид рослини!!!");
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

                string json_String = selectedplant.Substring(selectedplant.IndexOf("                                                                                                                                                                    ") + 1).Trim();

                Plant selected_Plant = JsonConvert.DeserializeObject<Plant>(json_String);

                DialogResult resultop = MessageBox.Show("Ви впевнені, що хочете видалити рослину?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultop == DialogResult.Yes)
                {
                    string json = File.ReadAllText("data_of_plants.json");

                    List<Plant> all_Plants = JsonConvert.DeserializeObject<List<Plant>>(json);

                    DeletePlant(selected_Plant, all_Plants);

                    MessageBox.Show("Вітаю. Ваша рослина була успішно видалена!!!");
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

        private void clear_button_Click(object sender, EventArgs e)
        {
            name_of_culture_textbox.Text = "";
            type_of_culture_comboBox.SelectedIndex = -1;
            matur_time_comboBox.SelectedIndex = -1;
            fetal_weight_comboBox.SelectedIndex = -1;
            hybridity_of_culture_comboBox.SelectedIndex = -1;
            exp_date_comboBox.SelectedIndex = -1;
        }
    }
}
