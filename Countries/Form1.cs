using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Countries
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            try
            {
                using (var db = new CountryContext())
                {
                    var query = from b in db.Countries
                                select b;
                    Country_comboBox.DataSource = query.ToList();
                    Country_comboBox.DisplayMember = "CountryName";
                    Country_comboBox.SelectedIndex = SelectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int SelectedIndex { get; set; }
        private void Country_comboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Country_comboBox.Items.Count == 0)
                return;
            try
            {
                using (var db = new CountryContext())
                {
                    List<Country> list = Country_comboBox.DataSource as List<Country>;
                    if (list == null)
                        return;
                    string country = list[Country_comboBox.SelectedIndex].CountryName;
                    var query = (from b in db.Countries
                                 where b.CountryName == country
                                 select b).Single();

                    CountryName_textBox.Text = query.CountryName;
                    CapitalName_textBox.Text = query.CapitalName;
                    Population_textBox.Text = query.Population.ToString();
                    Square_textBox.Text = query.Square.ToString();
                    ContinentName_textBox.Text = query.ContinentName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddCountry_button_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedIndex = Country_comboBox.SelectedIndex;

                string countryName = CountryName_textBox.Text.Trim();
                string capitalName = CapitalName_textBox.Text.Trim();
                string continentName = ContinentName_textBox.Text.Trim();

                if (countryName == "" || capitalName == "" || continentName == "")
                {
                    MessageBox.Show("Country, Capital, Continent names are required!");
                    return;
                }

                int? population = null;
                if (Population_textBox.Text != "")
                    population = (int?)Convert.ToInt32(Population_textBox.Text);

                int? square = null;
                if (Square_textBox.Text != "")
                    square = Convert.ToInt32(Square_textBox.Text);

                using (var db = new CountryContext())
                {
                    var country = new Country
                    {
                        CountryName = countryName,
                        CapitalName = capitalName,
                        Population = population,
                        Square = square,
                        ContinentName = continentName
                    };
                    if (db.Countries.Any(country => country.CountryName == countryName))
                    {
                        MessageBox.Show("WARNING! " + countryName + " already exists!");
                        return;
                    }
                    db.Countries.Add(country);
                    db.SaveChanges();

                    var query = from b in db.Countries
                                select b;
                    Country_comboBox.DataSource = query.ToList();
                    Country_comboBox.DisplayMember = countryName;
                    Country_comboBox.SelectedIndex = SelectedIndex;

                    MessageBox.Show(countryName + " added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteCountry_button_Click(object sender, EventArgs e)
        {
            if (Country_comboBox.Items.Count == 0)
                return;
            try
            {
                using (var db = new CountryContext())
                {
                    List<Country> list = Country_comboBox.DataSource as List<Country>;
                    string country = list[Country_comboBox.SelectedIndex].CountryName;
                    var query = from b in db.Countries
                                where b.CountryName == country
                                select b;
                    db.Countries.RemoveRange(query);
                    db.SaveChanges();

                    var query2 = from b in db.Countries
                                 select b;

                    if (Country_comboBox.Items.Count == 0)
                    {
                        CountryName_textBox.Text = "";
                        CapitalName_textBox.Text = "";
                        Population_textBox.Text = "";
                        Square_textBox.Text = "";
                        ContinentName_textBox.Text = "";
                    }

                    MessageBox.Show(country + " removed successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCountry_button_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedIndex = Country_comboBox.SelectedIndex;

                string countryName = CountryName_textBox.Text.Trim();
                string capitalName = CapitalName_textBox.Text.Trim();
                string continentName = ContinentName_textBox.Text.Trim();
                if (countryName == "" || capitalName == "" || continentName == "")
                {
                    MessageBox.Show("Country, Capital, Continent names are required!");
                    return;
                }

                int? population = null;
                if (Population_textBox.Text != "")
                    population = Convert.ToInt32(Population_textBox.Text);

                int? square = null;
                if (Square_textBox.Text != "")
                    square = Convert.ToInt32(Square_textBox.Text);

                using (var db = new CountryContext())
                {
                    List<Country> list = Country_comboBox.DataSource as List<Country>;
                    string country = list[Country_comboBox.SelectedIndex].CountryName;

                    if (db.Countries.Any(country => country.CountryName == countryName
                    && country.CapitalName == capitalName
                    && country.ContinentName == continentName
                    && country.Population == population
                    && country.Square == square))
                    {
                        MessageBox.Show("WARNING! " + countryName + " already exists!");
                        return;
                    }

                    var query = (from b in db.Countries
                                 where b.CountryName == country
                                 select b).Single();

                    query.ContinentName = continentName;
                    query.CountryName = countryName;
                    query.CapitalName = capitalName;
                    query.Population = population;
                    query.Square = square;
                    db.SaveChanges();

                    var query2 = from b in db.Countries
                                 select b;
                    Country_comboBox.DataSource = query2.ToList();
                    Country_comboBox.SelectedIndex = SelectedIndex;
                    Country_comboBox.DisplayMember = "CountryName";

                    MessageBox.Show(countryName + " edited succsessfully!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAllFields_button_Click(object sender, EventArgs e)
        {
            CountryName_textBox.Text = "";
            CapitalName_textBox.Text = "";
            Population_textBox.Text = "";
            Square_textBox.Text = "";
            ContinentName_textBox.Text = "";
        }

        private void Queries_button_Click(object sender, EventArgs e)
        {
            Queries_Form form = new Queries_Form();
            form.Show();
        }
    }
}