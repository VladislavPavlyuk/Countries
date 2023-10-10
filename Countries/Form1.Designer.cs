namespace Countries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Countries_groupBox = new GroupBox();
            ClearAllFields_button = new Button();
            ContinentName_textBox = new TextBox();
            Continent_label = new Label();
            EditCountry_button = new Button();
            DeleteCountry_button = new Button();
            AddCountry_button = new Button();
            Country_comboBox = new ComboBox();
            Square_textBox = new TextBox();
            Square_label = new Label();
            Population_textBox = new TextBox();
            Population_label = new Label();
            CapitalName_textBox = new TextBox();
            Capital_Name_label = new Label();
            CountryName_textBox = new TextBox();
            Country_Name_label = new Label();
            Queries_button = new Button();
            Countries_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Countries_groupBox
            // 
            Countries_groupBox.Controls.Add(Queries_button);
            Countries_groupBox.Controls.Add(ClearAllFields_button);
            Countries_groupBox.Controls.Add(ContinentName_textBox);
            Countries_groupBox.Controls.Add(Continent_label);
            Countries_groupBox.Controls.Add(EditCountry_button);
            Countries_groupBox.Controls.Add(DeleteCountry_button);
            Countries_groupBox.Controls.Add(AddCountry_button);
            Countries_groupBox.Controls.Add(Country_comboBox);
            Countries_groupBox.Controls.Add(Square_textBox);
            Countries_groupBox.Controls.Add(Square_label);
            Countries_groupBox.Controls.Add(Population_textBox);
            Countries_groupBox.Controls.Add(Population_label);
            Countries_groupBox.Controls.Add(CapitalName_textBox);
            Countries_groupBox.Controls.Add(Capital_Name_label);
            Countries_groupBox.Controls.Add(CountryName_textBox);
            Countries_groupBox.Controls.Add(Country_Name_label);
            Countries_groupBox.Location = new Point(14, 13);
            Countries_groupBox.Margin = new Padding(5, 4, 5, 4);
            Countries_groupBox.Name = "Countries_groupBox";
            Countries_groupBox.Padding = new Padding(5, 4, 5, 4);
            Countries_groupBox.Size = new Size(463, 242);
            Countries_groupBox.TabIndex = 4;
            Countries_groupBox.TabStop = false;
            Countries_groupBox.Text = "Countries";
            // 
            // ClearAllFields_button
            // 
            ClearAllFields_button.Location = new Point(285, 157);
            ClearAllFields_button.Margin = new Padding(5, 4, 5, 4);
            ClearAllFields_button.Name = "ClearAllFields_button";
            ClearAllFields_button.Size = new Size(161, 36);
            ClearAllFields_button.TabIndex = 14;
            ClearAllFields_button.Text = "Clear";
            ClearAllFields_button.UseVisualStyleBackColor = true;
            ClearAllFields_button.Click += ClearAllFields_button_Click;
            // 
            // ContinentName_textBox
            // 
            ContinentName_textBox.Location = new Point(118, 203);
            ContinentName_textBox.Margin = new Padding(5, 4, 5, 4);
            ContinentName_textBox.Name = "ContinentName_textBox";
            ContinentName_textBox.Size = new Size(162, 27);
            ContinentName_textBox.TabIndex = 13;
            // 
            // Continent_label
            // 
            Continent_label.AutoSize = true;
            Continent_label.Location = new Point(12, 210);
            Continent_label.Margin = new Padding(5, 0, 5, 0);
            Continent_label.Name = "Continent_label";
            Continent_label.Size = new Size(80, 20);
            Continent_label.TabIndex = 12;
            Continent_label.Text = "Continent :";
            // 
            // EditCountry_button
            // 
            EditCountry_button.Location = new Point(368, 67);
            EditCountry_button.Margin = new Padding(5, 4, 5, 4);
            EditCountry_button.Name = "EditCountry_button";
            EditCountry_button.Size = new Size(81, 36);
            EditCountry_button.TabIndex = 11;
            EditCountry_button.Text = "Edit";
            EditCountry_button.UseVisualStyleBackColor = true;
            EditCountry_button.Click += EditCountry_button_Click;
            // 
            // DeleteCountry_button
            // 
            DeleteCountry_button.Location = new Point(287, 113);
            DeleteCountry_button.Margin = new Padding(5, 4, 5, 4);
            DeleteCountry_button.Name = "DeleteCountry_button";
            DeleteCountry_button.Size = new Size(161, 36);
            DeleteCountry_button.TabIndex = 10;
            DeleteCountry_button.Text = "Delete ";
            DeleteCountry_button.UseVisualStyleBackColor = true;
            DeleteCountry_button.Click += DeleteCountry_button_Click;
            // 
            // AddCountry_button
            // 
            AddCountry_button.Location = new Point(287, 67);
            AddCountry_button.Margin = new Padding(5, 4, 5, 4);
            AddCountry_button.Name = "AddCountry_button";
            AddCountry_button.Size = new Size(76, 36);
            AddCountry_button.TabIndex = 9;
            AddCountry_button.Text = "Add";
            AddCountry_button.UseVisualStyleBackColor = true;
            AddCountry_button.Click += AddCountry_button_Click;
            // 
            // Country_comboBox
            // 
            Country_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Country_comboBox.FormattingEnabled = true;
            Country_comboBox.Location = new Point(287, 28);
            Country_comboBox.Margin = new Padding(5, 4, 5, 4);
            Country_comboBox.Name = "Country_comboBox";
            Country_comboBox.Size = new Size(159, 28);
            Country_comboBox.TabIndex = 8;
            Country_comboBox.SelectedIndexChanged += Country_comboBoxSelectedIndexChanged;
            // 
            // Square_textBox
            // 
            Square_textBox.Location = new Point(118, 160);
            Square_textBox.Margin = new Padding(5, 4, 5, 4);
            Square_textBox.Name = "Square_textBox";
            Square_textBox.Size = new Size(162, 27);
            Square_textBox.TabIndex = 7;
            // 
            // Square_label
            // 
            Square_label.AutoSize = true;
            Square_label.Location = new Point(12, 168);
            Square_label.Margin = new Padding(5, 0, 5, 0);
            Square_label.Name = "Square_label";
            Square_label.Size = new Size(62, 20);
            Square_label.TabIndex = 6;
            Square_label.Text = "Square :";
            // 
            // Population_textBox
            // 
            Population_textBox.Location = new Point(118, 116);
            Population_textBox.Margin = new Padding(5, 4, 5, 4);
            Population_textBox.Name = "Population_textBox";
            Population_textBox.Size = new Size(162, 27);
            Population_textBox.TabIndex = 5;
            // 
            // Population_label
            // 
            Population_label.AutoSize = true;
            Population_label.Location = new Point(12, 120);
            Population_label.Margin = new Padding(5, 0, 5, 0);
            Population_label.Name = "Population_label";
            Population_label.Size = new Size(87, 20);
            Population_label.TabIndex = 4;
            Population_label.Text = "Population :";
            // 
            // CapitalName_textBox
            // 
            CapitalName_textBox.Location = new Point(117, 72);
            CapitalName_textBox.Margin = new Padding(5, 4, 5, 4);
            CapitalName_textBox.Name = "CapitalName_textBox";
            CapitalName_textBox.Size = new Size(162, 27);
            CapitalName_textBox.TabIndex = 3;
            // 
            // Capital_Name_label
            // 
            Capital_Name_label.AutoSize = true;
            Capital_Name_label.Location = new Point(11, 77);
            Capital_Name_label.Margin = new Padding(5, 0, 5, 0);
            Capital_Name_label.Name = "Capital_Name_label";
            Capital_Name_label.Size = new Size(63, 20);
            Capital_Name_label.TabIndex = 2;
            Capital_Name_label.Text = "Capital :";
            // 
            // CountryName_textBox
            // 
            CountryName_textBox.Location = new Point(117, 29);
            CountryName_textBox.Margin = new Padding(5, 4, 5, 4);
            CountryName_textBox.Name = "CountryName_textBox";
            CountryName_textBox.Size = new Size(162, 27);
            CountryName_textBox.TabIndex = 1;
            // 
            // Country_Name_label
            // 
            Country_Name_label.AutoSize = true;
            Country_Name_label.Location = new Point(11, 32);
            Country_Name_label.Margin = new Padding(5, 0, 5, 0);
            Country_Name_label.Name = "Country_Name_label";
            Country_Name_label.Size = new Size(67, 20);
            Country_Name_label.TabIndex = 0;
            Country_Name_label.Text = "Country :";
            // 
            // Queries_button
            // 
            Queries_button.Location = new Point(285, 198);
            Queries_button.Margin = new Padding(5, 4, 5, 4);
            Queries_button.Name = "Queries_button";
            Queries_button.Size = new Size(161, 36);
            Queries_button.TabIndex = 15;
            Queries_button.Text = "Queries";
            Queries_button.UseVisualStyleBackColor = true;
            Queries_button.Click += Queries_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 268);
            Controls.Add(Countries_groupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Countries";
            Countries_groupBox.ResumeLayout(false);
            Countries_groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Countries_groupBox;
        private TextBox ContinentName_textBox;
        private Label Continent_label;
        private Button EditCountry_button;
        private Button DeleteCountry_button;
        private Button AddCountry_button;
        private ComboBox Country_comboBox;
        private TextBox Square_textBox;
        private Label Square_label;
        private TextBox Population_textBox;
        private Label Population_label;
        private TextBox CapitalName_textBox;
        private Label Capital_Name_label;
        private TextBox CountryName_textBox;
        private Label Country_Name_label;
        private Button ClearAllFields_button;
        private Button Queries_button;
    }
}