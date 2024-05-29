namespace AgroDictionary.Forms
{
    partial class EditPage
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
            description_field_textBox = new TextBox();
            label13 = new Label();
            titleError_label = new Label();
            cancel_button = new Button();
            save_button = new Button();
            label1 = new Label();
            titleError_label1 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            frost_resistance_comboBox = new ComboBox();
            author_comboBox = new ComboBox();
            label2 = new Label();
            potential_harvest_comboBox = new ComboBox();
            hybridity_of_culture_comboBox = new ComboBox();
            label3 = new Label();
            label10 = new Label();
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
            panel2 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            shape_of_head_comboBox = new ComboBox();
            panel9 = new Panel();
            label14 = new Label();
            panel6 = new Panel();
            indeterminate_comboBox = new ComboBox();
            label11 = new Label();
            panel7 = new Panel();
            cuboid_comboBox = new ComboBox();
            label12 = new Label();
            panel5 = new Panel();
            type_of_pollution_comboBox = new ComboBox();
            label9 = new Label();
            extraparameters_label = new Label();
            starch_content_comboBox = new ComboBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // description_field_textBox
            // 
            description_field_textBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            description_field_textBox.Location = new Point(8, 508);
            description_field_textBox.Multiline = true;
            description_field_textBox.Name = "description_field_textBox";
            description_field_textBox.ScrollBars = ScrollBars.Vertical;
            description_field_textBox.Size = new Size(816, 87);
            description_field_textBox.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Snow;
            label13.Location = new Point(6, 481);
            label13.Name = "label13";
            label13.Size = new Size(50, 26);
            label13.TabIndex = 26;
            label13.Text = "Опис";
            // 
            // titleError_label
            // 
            titleError_label.AutoSize = true;
            titleError_label.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleError_label.ForeColor = Color.Red;
            titleError_label.Location = new Point(414, 103);
            titleError_label.Name = "titleError_label";
            titleError_label.Size = new Size(21, 20);
            titleError_label.TabIndex = 30;
            titleError_label.Text = "*";
            titleError_label.Visible = false;
            // 
            // cancel_button
            // 
            cancel_button.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            cancel_button.Location = new Point(714, 601);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(110, 29);
            cancel_button.TabIndex = 17;
            cancel_button.Text = "Відмінити";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // save_button
            // 
            save_button.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            save_button.Location = new Point(608, 601);
            save_button.Name = "save_button";
            save_button.Size = new Size(94, 29);
            save_button.TabIndex = 16;
            save_button.Text = "Зберегти";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(277, 5);
            label1.Name = "label1";
            label1.Size = new Size(299, 43);
            label1.TabIndex = 23;
            label1.Text = "Редагування рослини";
            // 
            // titleError_label1
            // 
            titleError_label1.AutoSize = true;
            titleError_label1.BackColor = Color.ForestGreen;
            titleError_label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleError_label1.ForeColor = Color.Red;
            titleError_label1.ImageAlign = ContentAlignment.TopCenter;
            titleError_label1.Location = new Point(53, 485);
            titleError_label1.Name = "titleError_label1";
            titleError_label1.Size = new Size(21, 20);
            titleError_label1.TabIndex = 30;
            titleError_label1.Text = "*";
            titleError_label1.TextAlign = ContentAlignment.BottomCenter;
            titleError_label1.Visible = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(description_field_textBox);
            panel3.Controls.Add(titleError_label);
            panel3.Controls.Add(titleError_label1);
            panel3.Controls.Add(save_button);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cancel_button);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(18, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 648);
            panel3.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.Controls.Add(frost_resistance_comboBox);
            panel1.Controls.Add(author_comboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(potential_harvest_comboBox);
            panel1.Controls.Add(hybridity_of_culture_comboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label10);
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
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 413);
            panel1.TabIndex = 30;
            // 
            // frost_resistance_comboBox
            // 
            frost_resistance_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            frost_resistance_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frost_resistance_comboBox.FormattingEnabled = true;
            frost_resistance_comboBox.Items.AddRange(new object[] { "наявна", "відсутня" });
            frost_resistance_comboBox.Location = new Point(172, 284);
            frost_resistance_comboBox.Name = "frost_resistance_comboBox";
            frost_resistance_comboBox.Size = new Size(238, 32);
            frost_resistance_comboBox.TabIndex = 7;
            // 
            // author_comboBox
            // 
            author_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            author_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            author_comboBox.FormattingEnabled = true;
            author_comboBox.Items.AddRange(new object[] { "Монсанто (огірок, помідор, капуста)", "Сингента (огірок, помідор, капуста)", "Бейо Заден (огірок, помідор, капуста)", "Рійк Цваан (огірок, помідор, капуста)", "Нанхемс БАСФ (огірок)", "Семініс (перець)", "Енза Заден (перець, капуста)", "Хазера насіння (перець)", "Клауз (перець)", "Такіі насіння (перець)", "Саката насіння (помідор)", "ХЗПК (картопля)", "Агріко (картопля)", "Мейжер (картопля)", "Стет (картопля)", "Солана (картопля)" });
            author_comboBox.Location = new Point(172, 123);
            author_comboBox.Name = "author_comboBox";
            author_comboBox.Size = new Size(238, 32);
            author_comboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(29, 124);
            label2.Name = "label2";
            label2.Size = new Size(130, 26);
            label2.TabIndex = 20;
            label2.Text = "Автор культури";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // potential_harvest_comboBox
            // 
            potential_harvest_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            potential_harvest_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            potential_harvest_comboBox.FormattingEnabled = true;
            potential_harvest_comboBox.Items.AddRange(new object[] { "30-50 т/га", "40-70 т/га", "60-100 т/га" });
            potential_harvest_comboBox.Location = new Point(172, 367);
            potential_harvest_comboBox.Name = "potential_harvest_comboBox";
            potential_harvest_comboBox.Size = new Size(238, 32);
            potential_harvest_comboBox.TabIndex = 9;
            // 
            // hybridity_of_culture_comboBox
            // 
            hybridity_of_culture_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            hybridity_of_culture_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hybridity_of_culture_comboBox.FormattingEnabled = true;
            hybridity_of_culture_comboBox.Items.AddRange(new object[] { "наявна", "відсутня" });
            hybridity_of_culture_comboBox.Location = new Point(172, 243);
            hybridity_of_culture_comboBox.Name = "hybridity_of_culture_comboBox";
            hybridity_of_culture_comboBox.Size = new Size(238, 32);
            hybridity_of_culture_comboBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(26, 290);
            label3.Name = "label3";
            label3.Size = new Size(137, 26);
            label3.TabIndex = 18;
            label3.Text = "Морозостійкість";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Snow;
            label10.Location = new Point(3, 367);
            label10.Name = "label10";
            label10.Size = new Size(156, 26);
            label10.TabIndex = 11;
            label10.Text = "Потенціал урожаю";
            // 
            // hybridity_of_culture_label
            // 
            hybridity_of_culture_label.AutoSize = true;
            hybridity_of_culture_label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hybridity_of_culture_label.ForeColor = Color.Snow;
            hybridity_of_culture_label.Location = new Point(61, 247);
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
            exp_date_label.Location = new Point(14, 327);
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
            exp_date_comboBox.Items.AddRange(new object[] { "від 1 до 2 тижнів", "від 2 до 3 тижнів", "від 4 до 6 місяців", "від 6 до 8 місяців" });
            exp_date_comboBox.Location = new Point(172, 326);
            exp_date_comboBox.Name = "exp_date_comboBox";
            exp_date_comboBox.Size = new Size(238, 32);
            exp_date_comboBox.TabIndex = 8;
            // 
            // fetal_weight_comboBox
            // 
            fetal_weight_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fetal_weight_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fetal_weight_comboBox.FormattingEnabled = true;
            fetal_weight_comboBox.Items.AddRange(new object[] { "100 гр", "150 гр", "175 гр", "200 гр", "250 гр", "понад 1,5 кг", "понад 2-3 кг" });
            fetal_weight_comboBox.Location = new Point(172, 203);
            fetal_weight_comboBox.Name = "fetal_weight_comboBox";
            fetal_weight_comboBox.Size = new Size(238, 32);
            fetal_weight_comboBox.TabIndex = 5;
            // 
            // matur_time_comboBox
            // 
            matur_time_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            matur_time_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matur_time_comboBox.FormattingEnabled = true;
            matur_time_comboBox.Items.AddRange(new object[] { "ранньостиглі", "середньостиглі", "пізньостиглі" });
            matur_time_comboBox.Location = new Point(172, 163);
            matur_time_comboBox.Name = "matur_time_comboBox";
            matur_time_comboBox.Size = new Size(238, 32);
            matur_time_comboBox.TabIndex = 4;
            // 
            // type_of_culture_comboBox
            // 
            type_of_culture_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            type_of_culture_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_of_culture_comboBox.FormattingEnabled = true;
            type_of_culture_comboBox.Items.AddRange(new object[] { "огірок", "перець", "помідор", "капуста", "картопля" });
            type_of_culture_comboBox.Location = new Point(172, 81);
            type_of_culture_comboBox.Name = "type_of_culture_comboBox";
            type_of_culture_comboBox.Size = new Size(238, 32);
            type_of_culture_comboBox.TabIndex = 2;
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
            name_of_culture_textbox.Size = new Size(238, 29);
            name_of_culture_textbox.TabIndex = 1;
            // 
            // fetal_weight_label
            // 
            fetal_weight_label.AutoSize = true;
            fetal_weight_label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fetal_weight_label.ForeColor = Color.Snow;
            fetal_weight_label.Location = new Point(61, 204);
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
            matur_time_label.Location = new Point(29, 161);
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
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(extraparameters_label);
            panel2.Location = new Point(440, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 296);
            panel2.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(shape_of_head_comboBox);
            panel4.Location = new Point(3, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(378, 48);
            panel4.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(40, 8);
            label4.Name = "label4";
            label4.Size = new Size(119, 26);
            label4.TabIndex = 15;
            label4.Text = "Форма качану";
            // 
            // shape_of_head_comboBox
            // 
            shape_of_head_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shape_of_head_comboBox.Enabled = false;
            shape_of_head_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shape_of_head_comboBox.FormattingEnabled = true;
            shape_of_head_comboBox.Items.AddRange(new object[] { "категорія відсутня", "кругла", "загострена", "циліндрична" });
            shape_of_head_comboBox.Location = new Point(165, 7);
            shape_of_head_comboBox.Name = "shape_of_head_comboBox";
            shape_of_head_comboBox.Size = new Size(205, 32);
            shape_of_head_comboBox.TabIndex = 13;
            // 
            // panel9
            // 
            panel9.Controls.Add(starch_content_comboBox);
            panel9.Controls.Add(label14);
            panel9.Location = new Point(3, 245);
            panel9.Name = "panel9";
            panel9.Size = new Size(378, 43);
            panel9.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Snow;
            label14.Location = new Point(23, 5);
            label14.Name = "label14";
            label14.Size = new Size(136, 26);
            label14.TabIndex = 14;
            label14.Text = "Вміст крохмалю";
            // 
            // panel6
            // 
            panel6.Controls.Add(indeterminate_comboBox);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(3, 143);
            panel6.Name = "panel6";
            panel6.Size = new Size(378, 42);
            panel6.TabIndex = 16;
            // 
            // indeterminate_comboBox
            // 
            indeterminate_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            indeterminate_comboBox.Enabled = false;
            indeterminate_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            indeterminate_comboBox.FormattingEnabled = true;
            indeterminate_comboBox.Items.AddRange(new object[] { "категорія відсутня", "наявна", "відсутня" });
            indeterminate_comboBox.Location = new Point(165, 7);
            indeterminate_comboBox.Name = "indeterminate_comboBox";
            indeterminate_comboBox.Size = new Size(205, 32);
            indeterminate_comboBox.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold);
            label11.ForeColor = Color.Snow;
            label11.Location = new Point(7, 8);
            label11.Name = "label11";
            label11.Size = new Size(152, 26);
            label11.TabIndex = 14;
            label11.Text = "Індетермінатність";
            // 
            // panel7
            // 
            panel7.Controls.Add(cuboid_comboBox);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(3, 91);
            panel7.Name = "panel7";
            panel7.Size = new Size(378, 46);
            panel7.TabIndex = 15;
            // 
            // cuboid_comboBox
            // 
            cuboid_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cuboid_comboBox.Enabled = false;
            cuboid_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuboid_comboBox.FormattingEnabled = true;
            cuboid_comboBox.Items.AddRange(new object[] { "категорія відсутня", "наявна", "відсутня" });
            cuboid_comboBox.Location = new Point(165, 11);
            cuboid_comboBox.Name = "cuboid_comboBox";
            cuboid_comboBox.Size = new Size(205, 32);
            cuboid_comboBox.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Snow;
            label12.Location = new Point(43, 11);
            label12.Name = "label12";
            label12.Size = new Size(116, 26);
            label12.TabIndex = 11;
            label12.Text = "Кубовидність";
            // 
            // panel5
            // 
            panel5.Controls.Add(type_of_pollution_comboBox);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(3, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(378, 51);
            panel5.TabIndex = 15;
            // 
            // type_of_pollution_comboBox
            // 
            type_of_pollution_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            type_of_pollution_comboBox.Enabled = false;
            type_of_pollution_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_of_pollution_comboBox.FormattingEnabled = true;
            type_of_pollution_comboBox.Items.AddRange(new object[] { "категорія відсутня", "бджолозапильний", "партенокарпічний" });
            type_of_pollution_comboBox.Location = new Point(165, 8);
            type_of_pollution_comboBox.Name = "type_of_pollution_comboBox";
            type_of_pollution_comboBox.Size = new Size(205, 32);
            type_of_pollution_comboBox.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(30, 8);
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
            extraparameters_label.Location = new Point(104, 2);
            extraparameters_label.Name = "extraparameters_label";
            extraparameters_label.Size = new Size(197, 29);
            extraparameters_label.TabIndex = 11;
            extraparameters_label.Text = "Додаткові параметри";
            // 
            // starch_content_comboBox
            // 
            starch_content_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            starch_content_comboBox.Enabled = false;
            starch_content_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            starch_content_comboBox.FormattingEnabled = true;
            starch_content_comboBox.Items.AddRange(new object[] { "категорія відсутня", "0-5%", "5-10%", "10-15%", "15-20%", "понад 20%" });
            starch_content_comboBox.Location = new Point(165, -1);
            starch_content_comboBox.Name = "starch_content_comboBox";
            starch_content_comboBox.Size = new Size(205, 32);
            starch_content_comboBox.TabIndex = 15;
            // 
            // EditPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(881, 671);
            Controls.Add(panel3);
            MinimumSize = new Size(899, 718);
            Name = "EditPage";
            Text = "Сторінка редагування";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox description_field_textBox;
        private Label label13;
        private Button cancel_button;
        private Button save_button;
        private Label label1;
        private Label titleError_label;
        private Label titleError_label1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label label4;
        private ComboBox shape_of_head_comboBox;
        private Panel panel9;
        private Label label14;
        private Panel panel6;
        private ComboBox indeterminate_comboBox;
        private Label label11;
        private Panel panel7;
        private ComboBox cuboid_comboBox;
        private Label label12;
        private Panel panel5;
        private ComboBox type_of_pollution_comboBox;
        private Label label9;
        private Label extraparameters_label;
        private Panel panel1;
        private ComboBox frost_resistance_comboBox;
        private ComboBox author_comboBox;
        private Label label2;
        private ComboBox potential_harvest_comboBox;
        private ComboBox hybridity_of_culture_comboBox;
        private Label label3;
        private Label label10;
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
        private ComboBox starch_content_comboBox;
    }
}