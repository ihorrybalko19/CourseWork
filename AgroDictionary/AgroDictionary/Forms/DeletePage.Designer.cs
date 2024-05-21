namespace AgroDictionary.Forms
{
    partial class DeletePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPage_panel = new Panel();
            titleError2_label = new Label();
            titleError_label = new Label();
            titlehandbookofbreeder = new Label();
            panel1 = new Panel();
            hybridity_of_culture_comboBox = new ComboBox();
            hybridity_of_culture_label = new Label();
            exp_date_label = new Label();
            exp_date_comboBox = new ComboBox();
            fetal_weight_comboBox = new ComboBox();
            matur_time_comboBox = new ComboBox();
            type_of_culture_comboBox = new ComboBox();
            type_of_culture_label = new Label();
            basicparameters_label = new Label();
            name_of_culture_textbox = new TextBox();
            fetal_weight_label = new Label();
            matur_time_label = new Label();
            name_of_culture_label = new Label();
            title_searching_result = new Label();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            clear_button = new Button();
            label10 = new Label();
            panel9 = new Panel();
            comboBox3 = new ComboBox();
            label14 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            panel7 = new Panel();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            label12 = new Label();
            search_button = new Button();
            panel4 = new Panel();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label9 = new Label();
            extraparameters_label = new Label();
            result_field_listbox = new ListBox();
            MainPage_panel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // MainPage_panel
            // 
            MainPage_panel.Anchor = AnchorStyles.Top;
            MainPage_panel.Controls.Add(titleError2_label);
            MainPage_panel.Controls.Add(titleError_label);
            MainPage_panel.Controls.Add(titlehandbookofbreeder);
            MainPage_panel.Controls.Add(panel1);
            MainPage_panel.Controls.Add(title_searching_result);
            MainPage_panel.Controls.Add(panel2);
            MainPage_panel.Controls.Add(result_field_listbox);
            MainPage_panel.Location = new Point(17, 12);
            MainPage_panel.Name = "MainPage_panel";
            MainPage_panel.Size = new Size(809, 573);
            MainPage_panel.TabIndex = 30;
            // 
            // titleError2_label
            // 
            titleError2_label.AutoSize = true;
            titleError2_label.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleError2_label.ForeColor = Color.Red;
            titleError2_label.Location = new Point(414, 149);
            titleError2_label.Name = "titleError2_label";
            titleError2_label.Size = new Size(20, 23);
            titleError2_label.TabIndex = 30;
            titleError2_label.Text = "*";
            titleError2_label.Visible = false;
            // 
            // titleError_label
            // 
            titleError_label.AutoSize = true;
            titleError_label.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleError_label.ForeColor = Color.Red;
            titleError_label.Location = new Point(414, 109);
            titleError_label.Name = "titleError_label";
            titleError_label.Size = new Size(20, 23);
            titleError_label.TabIndex = 29;
            titleError_label.Text = "*";
            titleError_label.Visible = false;
            // 
            // titlehandbookofbreeder
            // 
            titlehandbookofbreeder.AutoSize = true;
            titlehandbookofbreeder.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titlehandbookofbreeder.ForeColor = Color.Snow;
            titlehandbookofbreeder.Location = new Point(287, 10);
            titlehandbookofbreeder.Name = "titlehandbookofbreeder";
            titlehandbookofbreeder.Size = new Size(279, 43);
            titlehandbookofbreeder.TabIndex = 28;
            titlehandbookofbreeder.Text = "Видалення рослини";
            // 
            // panel1
            // 
            panel1.Controls.Add(hybridity_of_culture_comboBox);
            panel1.Controls.Add(hybridity_of_culture_label);
            panel1.Controls.Add(exp_date_label);
            panel1.Controls.Add(exp_date_comboBox);
            panel1.Controls.Add(fetal_weight_comboBox);
            panel1.Controls.Add(matur_time_comboBox);
            panel1.Controls.Add(type_of_culture_comboBox);
            panel1.Controls.Add(type_of_culture_label);
            panel1.Controls.Add(basicparameters_label);
            panel1.Controls.Add(name_of_culture_textbox);
            panel1.Controls.Add(fetal_weight_label);
            panel1.Controls.Add(matur_time_label);
            panel1.Controls.Add(name_of_culture_label);
            panel1.Location = new Point(3, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 305);
            panel1.TabIndex = 24;
            // 
            // hybridity_of_culture_comboBox
            // 
            hybridity_of_culture_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            hybridity_of_culture_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hybridity_of_culture_comboBox.FormattingEnabled = true;
            hybridity_of_culture_comboBox.Items.AddRange(new object[] { "наявна", "відсутня" });
            hybridity_of_culture_comboBox.Location = new Point(172, 204);
            hybridity_of_culture_comboBox.Name = "hybridity_of_culture_comboBox";
            hybridity_of_culture_comboBox.Size = new Size(233, 32);
            hybridity_of_culture_comboBox.TabIndex = 20;
            // 
            // hybridity_of_culture_label
            // 
            hybridity_of_culture_label.AutoSize = true;
            hybridity_of_culture_label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hybridity_of_culture_label.ForeColor = Color.Snow;
            hybridity_of_culture_label.Location = new Point(61, 208);
            hybridity_of_culture_label.Name = "hybridity_of_culture_label";
            hybridity_of_culture_label.Size = new Size(102, 26);
            hybridity_of_culture_label.TabIndex = 11;
            hybridity_of_culture_label.Text = "Гібридність";
            // 
            // exp_date_label
            // 
            exp_date_label.AutoSize = true;
            exp_date_label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exp_date_label.ForeColor = Color.Snow;
            exp_date_label.Location = new Point(11, 254);
            exp_date_label.Name = "exp_date_label";
            exp_date_label.Size = new Size(152, 26);
            exp_date_label.TabIndex = 15;
            exp_date_label.Text = "Термін зберігання";
            // 
            // exp_date_comboBox
            // 
            exp_date_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            exp_date_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exp_date_comboBox.FormattingEnabled = true;
            exp_date_comboBox.Items.AddRange(new object[] { "від 3-3,5 місяців", "до 4 місяців", "від 4-5 місяців", "понад 5 місяців" });
            exp_date_comboBox.Location = new Point(172, 249);
            exp_date_comboBox.Name = "exp_date_comboBox";
            exp_date_comboBox.Size = new Size(233, 32);
            exp_date_comboBox.TabIndex = 13;
            // 
            // fetal_weight_comboBox
            // 
            fetal_weight_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fetal_weight_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fetal_weight_comboBox.FormattingEnabled = true;
            fetal_weight_comboBox.Items.AddRange(new object[] { "100 гр", "200 гр", "300 гр", "понад 300 гр." });
            fetal_weight_comboBox.Location = new Point(172, 162);
            fetal_weight_comboBox.Name = "fetal_weight_comboBox";
            fetal_weight_comboBox.Size = new Size(233, 32);
            fetal_weight_comboBox.TabIndex = 19;
            // 
            // matur_time_comboBox
            // 
            matur_time_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            matur_time_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matur_time_comboBox.FormattingEnabled = true;
            matur_time_comboBox.Items.AddRange(new object[] { "ранньостиглі", "середньостиглі", "пізньостиглі" });
            matur_time_comboBox.Location = new Point(172, 124);
            matur_time_comboBox.Name = "matur_time_comboBox";
            matur_time_comboBox.Size = new Size(233, 32);
            matur_time_comboBox.TabIndex = 18;
            // 
            // type_of_culture_comboBox
            // 
            type_of_culture_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            type_of_culture_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_of_culture_comboBox.FormattingEnabled = true;
            type_of_culture_comboBox.Items.AddRange(new object[] { "помідор", "огірок", "картопля", "перець", "цибуля ", "капуста" });
            type_of_culture_comboBox.Location = new Point(172, 81);
            type_of_culture_comboBox.Name = "type_of_culture_comboBox";
            type_of_culture_comboBox.Size = new Size(233, 32);
            type_of_culture_comboBox.TabIndex = 17;
            // 
            // type_of_culture_label
            // 
            type_of_culture_label.AutoSize = true;
            type_of_culture_label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_of_culture_label.ForeColor = Color.Snow;
            type_of_culture_label.Location = new Point(44, 82);
            type_of_culture_label.Name = "type_of_culture_label";
            type_of_culture_label.Size = new Size(115, 26);
            type_of_culture_label.TabIndex = 16;
            type_of_culture_label.Text = "Вид культури";
            type_of_culture_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // basicparameters_label
            // 
            basicparameters_label.AutoSize = true;
            basicparameters_label.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            basicparameters_label.ForeColor = Color.Snow;
            basicparameters_label.Location = new Point(132, 2);
            basicparameters_label.Name = "basicparameters_label";
            basicparameters_label.Size = new Size(178, 29);
            basicparameters_label.TabIndex = 10;
            basicparameters_label.Text = "Основні параметри";
            // 
            // name_of_culture_textbox
            // 
            name_of_culture_textbox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_of_culture_textbox.Location = new Point(172, 42);
            name_of_culture_textbox.MaxLength = 30;
            name_of_culture_textbox.Name = "name_of_culture_textbox";
            name_of_culture_textbox.Size = new Size(233, 29);
            name_of_culture_textbox.TabIndex = 6;
            // 
            // fetal_weight_label
            // 
            fetal_weight_label.AutoSize = true;
            fetal_weight_label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fetal_weight_label.ForeColor = Color.Snow;
            fetal_weight_label.Location = new Point(61, 165);
            fetal_weight_label.Name = "fetal_weight_label";
            fetal_weight_label.Size = new Size(96, 26);
            fetal_weight_label.TabIndex = 4;
            fetal_weight_label.Text = "Вага плоду";
            // 
            // matur_time_label
            // 
            matur_time_label.AutoSize = true;
            matur_time_label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matur_time_label.ForeColor = Color.Snow;
            matur_time_label.Location = new Point(29, 122);
            matur_time_label.Name = "matur_time_label";
            matur_time_label.Size = new Size(130, 26);
            matur_time_label.TabIndex = 3;
            matur_time_label.Text = "Час дозрівання";
            // 
            // name_of_culture_label
            // 
            name_of_culture_label.AutoSize = true;
            name_of_culture_label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_of_culture_label.ForeColor = Color.Snow;
            name_of_culture_label.Location = new Point(29, 42);
            name_of_culture_label.Name = "name_of_culture_label";
            name_of_culture_label.Size = new Size(130, 26);
            name_of_culture_label.TabIndex = 1;
            name_of_culture_label.Text = "Назва культури";
            // 
            // title_searching_result
            // 
            title_searching_result.AutoSize = true;
            title_searching_result.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_searching_result.ForeColor = Color.Snow;
            title_searching_result.Location = new Point(326, 392);
            title_searching_result.Name = "title_searching_result";
            title_searching_result.Size = new Size(165, 49);
            title_searching_result.TabIndex = 27;
            title_searching_result.Text = "Результат";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(clear_button);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(search_button);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(extraparameters_label);
            panel2.Location = new Point(452, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 332);
            panel2.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "до 100 т на гектар", "від 100-300 т на гектар", "від 300-500 т на гектар", "понад 500 т" });
            comboBox1.Location = new Point(149, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 32);
            comboBox1.TabIndex = 12;
            // 
            // clear_button
            // 
            clear_button.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_button.Location = new Point(256, 294);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(94, 29);
            clear_button.TabIndex = 19;
            clear_button.Text = "Очистити";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Snow;
            label10.Location = new Point(-6, 205);
            label10.Name = "label10";
            label10.Size = new Size(156, 26);
            label10.TabIndex = 11;
            label10.Text = "Потенціал урожаю";
            // 
            // panel9
            // 
            panel9.Controls.Add(comboBox3);
            panel9.Controls.Add(label14);
            panel9.Location = new Point(3, 245);
            panel9.Name = "panel9";
            panel9.Size = new Size(351, 43);
            panel9.TabIndex = 18;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "від 30 до 50%", "від 50 до 60 %", "від 60 до 70%", "понад 70 %" });
            comboBox3.Location = new Point(146, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(205, 32);
            comboBox3.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Snow;
            label14.Location = new Point(10, 4);
            label14.Name = "label14";
            label14.Size = new Size(136, 26);
            label14.TabIndex = 14;
            label14.Text = "Вміст крохмалю";
            // 
            // panel6
            // 
            panel6.Controls.Add(label11);
            panel6.Controls.Add(radioButton5);
            panel6.Controls.Add(radioButton6);
            panel6.Location = new Point(0, 160);
            panel6.Name = "panel6";
            panel6.Size = new Size(354, 34);
            panel6.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold);
            label11.ForeColor = Color.Snow;
            label11.Location = new Point(18, 5);
            label11.Name = "label11";
            label11.Size = new Size(132, 26);
            label11.TabIndex = 14;
            label11.Text = "Індетермінатна";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold);
            radioButton5.ForeColor = Color.Snow;
            radioButton5.Location = new Point(243, 3);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(50, 30);
            radioButton5.TabIndex = 13;
            radioButton5.TabStop = true;
            radioButton5.Text = "Ні";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold);
            radioButton6.ForeColor = Color.Snow;
            radioButton6.Location = new Point(150, 1);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(59, 30);
            radioButton6.TabIndex = 12;
            radioButton6.TabStop = true;
            radioButton6.Text = "Так";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(radioButton7);
            panel7.Controls.Add(radioButton8);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(3, 110);
            panel7.Name = "panel7";
            panel7.Size = new Size(351, 46);
            panel7.TabIndex = 15;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton7.ForeColor = Color.Snow;
            radioButton7.Location = new Point(240, 10);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(100, 30);
            radioButton7.TabIndex = 13;
            radioButton7.TabStop = true;
            radioButton7.Text = "Відсутня";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton8.ForeColor = Color.Snow;
            radioButton8.Location = new Point(146, 10);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(89, 30);
            radioButton8.TabIndex = 12;
            radioButton8.TabStop = true;
            radioButton8.Text = "Наявна";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Snow;
            label12.Location = new Point(30, 12);
            label12.Name = "label12";
            label12.Size = new Size(116, 26);
            label12.TabIndex = 11;
            label12.Text = "Кубовидність";
            // 
            // search_button
            // 
            search_button.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_button.Location = new Point(150, 294);
            search_button.Name = "search_button";
            search_button.Size = new Size(94, 29);
            search_button.TabIndex = 16;
            search_button.Text = "Пошук";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(radioButton3);
            panel4.Controls.Add(radioButton4);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(3, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(351, 70);
            panel4.TabIndex = 15;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.Snow;
            radioButton3.Location = new Point(147, 37);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(178, 30);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Партенокарпічний";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = Color.Snow;
            radioButton4.Location = new Point(147, 6);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(178, 30);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "Бджолозапильний";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(16, 6);
            label9.Name = "label9";
            label9.Size = new Size(129, 26);
            label9.TabIndex = 14;
            label9.Text = "Тип запилення";
            // 
            // extraparameters_label
            // 
            extraparameters_label.AutoSize = true;
            extraparameters_label.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            extraparameters_label.ForeColor = Color.Snow;
            extraparameters_label.Location = new Point(69, 2);
            extraparameters_label.Name = "extraparameters_label";
            extraparameters_label.Size = new Size(197, 29);
            extraparameters_label.TabIndex = 11;
            extraparameters_label.Text = "Додаткові параметри";
            // 
            // result_field_listbox
            // 
            result_field_listbox.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result_field_listbox.FormattingEnabled = true;
            result_field_listbox.ItemHeight = 29;
            result_field_listbox.Location = new Point(26, 444);
            result_field_listbox.Name = "result_field_listbox";
            result_field_listbox.Size = new Size(755, 120);
            result_field_listbox.TabIndex = 26;
            // 
            // DeletePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(845, 587);
            Controls.Add(MainPage_panel);
            MinimumSize = new Size(863, 634);
            Name = "DeletePage";
            Text = "Сторінка видалення рослини";
            MainPage_panel.ResumeLayout(false);
            MainPage_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPage_panel;
        private Label titleError2_label;
        private Label titleError_label;
        private Label titlehandbookofbreeder;
        private Panel panel1;
        private ComboBox hybridity_of_culture_comboBox;
        private Label hybridity_of_culture_label;
        private Label exp_date_label;
        private ComboBox exp_date_comboBox;
        private ComboBox fetal_weight_comboBox;
        private ComboBox matur_time_comboBox;
        private ComboBox type_of_culture_comboBox;
        private Label type_of_culture_label;
        private Label basicparameters_label;
        private TextBox name_of_culture_textbox;
        private Label fetal_weight_label;
        private Label matur_time_label;
        private Label name_of_culture_label;
        private Label title_searching_result;
        private Panel panel2;
        private ComboBox comboBox1;
        private Button clear_button;
        private Label label10;
        private Panel panel9;
        private ComboBox comboBox3;
        private Label label14;
        private Panel panel6;
        private Label label11;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Panel panel7;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private Label label12;
        private Button search_button;
        private Panel panel4;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label9;
        private Label extraparameters_label;
        private ListBox result_field_listbox;
    }
}