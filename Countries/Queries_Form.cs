using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Countries
{
    public partial class Queries_Form : Form
    {
        public Queries_Form()
        {
            InitializeComponent();
        }

        private void Queries_Form_Load(object sender, EventArgs e)
        {

        }

        private void AllCountriesInfo_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CountryContext())
                {
                    var query = from b in db.Countries
                                select new
                                {
                                    Country = b.CountryName,
                                    Capital = b.CapitalName,
                                    Continent = b.ContinentName,
                                    Population = b.Population,
                                    Square = b.Square
                                };
                    var result = query.ToList();

                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllCountriesNames_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CountryContext())
                {
                    var query = from b in db.Countries
                                select new
                                {
                                    Country = b.CountryName,
                                };
                    var result = query.ToList();

                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllCapitals_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CountryContext())
                {
                    var query = from b in db.Countries
                                select new
                                {
                                    Capital = b.CapitalName,
                                };
                    var result = query.ToList();

                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllEuropeCapitals_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CountryContext())
                {
                    var query = from b in db.Countries
                                where b.ContinentName == "Europe"
                                select new
                                {
                                    Capital = b.CapitalName,
                                };
                    var result = query.ToList();

                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllCountriesSquare_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CountryContext())
                {
                    var query = from b in db.Countries
                                where b.Square > SquareTextBox
                                select new
                                {
                                    Country = b.CountryName,
                                    Square = b.Square
                                };
                    var result = query.ToList();

                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Square_textBox_TextChanged(object sender, EventArgs e)
        {
            SquareTextBox = int.Parse(Square_textBox.Text);
        }
        private int SquareTextBox { get; set; }

        private void AllCountriesHavingLetters_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CountryContext())
                {
                    var query = from b in db.Countries
                                where
                                b.CountryName.Contains(LetterTextBox1) &&
                                b.CountryName.Contains(LetterTextBox2)
                                select new
                                {
                                    Country = b.CountryName,
                                };
                    var result = query.ToList();

                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string LetterTextBox1 { get; set; }
        private string LetterTextBox2 { get; set; }

        private void Letter_textBox1_TextChanged(object sender, EventArgs e)
        {
            LetterTextBox1 = Letter_textBox1.Text;
        }
        private void Letter_textBox2_TextChanged(object sender, EventArgs e)
        {
            LetterTextBox2 = Letter_textBox2.Text;
        }
        private void AllCountriesFirstLetter_button_Click(object sender, EventArgs e)
        {
            try
             {
                 using (var db = new CountryContext())
                 {
                     var query = from b in db.Countries
                                 where
                                 b.CountryName.StartsWith(FirstLetterTextBox)
                                 select new
                                 {
                                     Country = b.CountryName,
                                 };
                     var result = query.ToList();

                     dataGridView1.DataSource = result;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private string FirstLetterTextBox { set; get; }
        private void FirstLetter_textBox_TextChanged(object sender, EventArgs e)
        {
            FirstLetterTextBox = FirstLetter_textBox.Text
                ;
        }

        private int SquareTextBox1 { set; get; }
        private int SquareTextBox2 { set; get; }
        private void Square_textBox1_TextChanged(object sender, EventArgs e)
        {
            SquareTextBox1 = int.Parse(Square_textBox1.Text);
        }
        private void Square_textBox2_TextChanged(object sender, EventArgs e)
        {
            SquareTextBox2 = int.Parse(Square_textBox2.Text);
        }

        private void AllCountriesSquareBetween_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CountryContext())
                {
                    var query = from b in db.Countries
                                where
                                b.Square > SquareTextBox1 &&
                                b.Square < SquareTextBox2
                                select new
                                {
                                    Country = b.CountryName,
                                    Square = b.Square
                                };
                    var result = query.ToList();

                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllCountriesPopulation_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CountryContext())
                {
                    var query = from b in db.Countries
                                where
                                b.Population > PopulationTextBox

                                select new
                                {
                                    Country = b.CountryName,
                                    Population = b.Population
                                };
                    var result = query.ToList();

                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int PopulationTextBox { set; get; }
        private void Population_textBox_TextChanged(object sender, EventArgs e)
        {
            PopulationTextBox = int.Parse(Population_textBox.Text);
        }
    }
}
