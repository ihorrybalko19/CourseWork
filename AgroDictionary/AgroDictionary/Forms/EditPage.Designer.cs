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
            panel2 = new Panel();
            comboBox1 = new ComboBox();
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
            panel4 = new Panel();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label9 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            titleError_label = new Label();
            hybridity_of_culture_comboBox = new ComboBox();
            label8 = new Label();
            label17 = new Label();
            exp_date_comboBox = new ComboBox();
            fetal_weight_comboBox = new ComboBox();
            matur_time_comboBox = new ComboBox();
            type_of_culture_comboBox = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            name_of_culture_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            cancel_button = new Button();
            save_button = new Button();
            label1 = new Label();
            titleError_label1 = new Label();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // description_field_textBox
            // 
            description_field_textBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            description_field_textBox.Location = new Point(71, 378);
            description_field_textBox.Multiline = true;
            description_field_textBox.Name = "description_field_textBox";
            description_field_textBox.ScrollBars = ScrollBars.Vertical;
            description_field_textBox.Size = new Size(723, 63);
            description_field_textBox.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Snow;
            label13.Location = new Point(15, 359);
            label13.Name = "label13";
            label13.Size = new Size(50, 26);
            label13.TabIndex = 26;
            label13.Text = "Опис";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(437, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 305);
            panel2.TabIndex = 28;
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
            comboBox3.Location = new Point(146, 8);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(205, 32);
            comboBox3.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Snow;
            label14.Location = new Point(9, 9);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(69, 2);
            label7.Name = "label7";
            label7.Size = new Size(197, 29);
            label7.TabIndex = 11;
            label7.Text = "Додаткові параметри";
            // 
            // panel1
            // 
            panel1.Controls.Add(titleError_label);
            panel1.Controls.Add(hybridity_of_culture_comboBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(exp_date_comboBox);
            panel1.Controls.Add(fetal_weight_comboBox);
            panel1.Controls.Add(matur_time_comboBox);
            panel1.Controls.Add(type_of_culture_comboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(name_of_culture_textbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(7, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 305);
            panel1.TabIndex = 27;
            // 
            // titleError_label
            // 
            titleError_label.AutoSize = true;
            titleError_label.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleError_label.ForeColor = Color.Red;
            titleError_label.Location = new Point(407, 43);
            titleError_label.Name = "titleError_label";
            titleError_label.Size = new Size(20, 23);
            titleError_label.TabIndex = 30;
            titleError_label.Text = "*";
            titleError_label.Visible = false;
            // 
            // hybridity_of_culture_comboBox
            // 
            hybridity_of_culture_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            hybridity_of_culture_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hybridity_of_culture_comboBox.FormattingEnabled = true;
            hybridity_of_culture_comboBox.Items.AddRange(new object[] { "наявна", "відсутня" });
            hybridity_of_culture_comboBox.Location = new Point(172, 207);
            hybridity_of_culture_comboBox.Name = "hybridity_of_culture_comboBox";
            hybridity_of_culture_comboBox.Size = new Size(233, 32);
            hybridity_of_culture_comboBox.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(57, 208);
            label8.Name = "label8";
            label8.Size = new Size(102, 26);
            label8.TabIndex = 11;
            label8.Text = "Гібридність";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Snow;
            label17.Location = new Point(8, 254);
            label17.Name = "label17";
            label17.Size = new Size(152, 26);
            label17.TabIndex = 15;
            label17.Text = "Термін зберігання";
            // 
            // exp_date_comboBox
            // 
            exp_date_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            exp_date_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exp_date_comboBox.FormattingEnabled = true;
            exp_date_comboBox.Items.AddRange(new object[] { "від 3-3,5 місяців", "до 4 місяців", "від 4-5 місяців", "понад 5 місяців" });
            exp_date_comboBox.Location = new Point(172, 256);
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
            type_of_culture_comboBox.Enabled = false;
            type_of_culture_comboBox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_of_culture_comboBox.FormattingEnabled = true;
            type_of_culture_comboBox.Items.AddRange(new object[] { "помідор", "огірок", "картопля", "перець", "цибуля ", "капуста" });
            type_of_culture_comboBox.Location = new Point(172, 83);
            type_of_culture_comboBox.Name = "type_of_culture_comboBox";
            type_of_culture_comboBox.Size = new Size(233, 32);
            type_of_culture_comboBox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(44, 81);
            label2.Name = "label2";
            label2.Size = new Size(115, 26);
            label2.TabIndex = 16;
            label2.Text = "Вид культури";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(132, 2);
            label6.Name = "label6";
            label6.Size = new Size(178, 29);
            label6.TabIndex = 10;
            label6.Text = "Основні параметри";
            // 
            // name_of_culture_textbox
            // 
            name_of_culture_textbox.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_of_culture_textbox.Location = new Point(172, 42);
            name_of_culture_textbox.MaxLength = 50;
            name_of_culture_textbox.Name = "name_of_culture_textbox";
            name_of_culture_textbox.Size = new Size(233, 29);
            name_of_culture_textbox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(112, 160);
            label4.Name = "label4";
            label4.Size = new Size(45, 26);
            label4.TabIndex = 4;
            label4.Text = "Вага";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(33, 124);
            label3.Name = "label3";
            label3.Size = new Size(130, 26);
            label3.TabIndex = 3;
            label3.Text = "Час дозрівання";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(30, 40);
            label5.Name = "label5";
            label5.Size = new Size(130, 26);
            label5.TabIndex = 1;
            label5.Text = "Назва культури";
            // 
            // cancel_button
            // 
            cancel_button.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            cancel_button.Location = new Point(684, 447);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(110, 29);
            cancel_button.TabIndex = 22;
            cancel_button.Text = "Відмінити";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // save_button
            // 
            save_button.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            save_button.Location = new Point(584, 447);
            save_button.Name = "save_button";
            save_button.Size = new Size(94, 29);
            save_button.TabIndex = 24;
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
            titleError_label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleError_label1.ForeColor = Color.Red;
            titleError_label1.Location = new Point(37, 385);
            titleError_label1.Name = "titleError_label1";
            titleError_label1.Size = new Size(20, 23);
            titleError_label1.TabIndex = 30;
            titleError_label1.Text = "*";
            titleError_label1.Visible = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(titleError_label1);
            panel3.Controls.Add(description_field_textBox);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(cancel_button);
            panel3.Controls.Add(save_button);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(5, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 491);
            panel3.TabIndex = 31;
            // 
            // EditPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(825, 503);
            Controls.Add(panel3);
            MinimumSize = new Size(843, 550);
            Name = "EditPage";
            Text = "Сторінка редагування";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox description_field_textBox;
        private Label label13;
        private Panel panel2;
        private ComboBox comboBox1;
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
        private Panel panel4;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label9;
        private Label label7;
        private Panel panel1;
        private ComboBox hybridity_of_culture_comboBox;
        private Label label8;
        private Label label17;
        private ComboBox exp_date_comboBox;
        private ComboBox fetal_weight_comboBox;
        private ComboBox matur_time_comboBox;
        private ComboBox type_of_culture_comboBox;
        private Label label2;
        private Label label6;
        private TextBox name_of_culture_textbox;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button cancel_button;
        private Button save_button;
        private Label label1;
        private Label titleError_label;
        private Label titleError_label1;
        private Panel panel3;
    }
}