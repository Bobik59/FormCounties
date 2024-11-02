using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private DataClasses1DataContext context;
        public Form1()
        {
            InitializeComponent();
            context = new DataClasses1DataContext();

            comboBoxTasks.Items.Add("Показать полную информацию о странах");
            comboBoxTasks.Items.Add("Показать информацию о конкретной стране");
            comboBoxTasks.Items.Add("Показать информацию о городах конкретной страны");
            comboBoxTasks.Items.Add("Показать все страны, чьё имя начинается с буквы");
            comboBoxTasks.Items.Add("Показать все столицы, чьё имя начинается с буквы");
            comboBoxTasks.Items.Add("Топ-3 столиц с наименьшим количеством жителей");
            comboBoxTasks.Items.Add("Топ-3 стран с наименьшим количеством жителей");
            comboBoxTasks.Items.Add("Среднее количество жителей в столицах по каждой части света");
            comboBoxTasks.Items.Add("Топ-3 стран по каждой части света с наименьшим количеством жителей");
            comboBoxTasks.Items.Add("Топ-3 стран по каждой части света с наибольшим количеством жителей");
            comboBoxTasks.Items.Add("Среднее количество жителей в конкретной стране");
            comboBoxTasks.Items.Add("Город с наименьшим количеством жителей в конкретной стране");
        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (chkId.Checked)
                dt.Columns.Add("Id");
            if (chkCountryName.Checked)
                dt.Columns.Add("CountryName");
            if (chkPopulation.Checked)
                dt.Columns.Add("Population");
            if (chkArea.Checked)
                dt.Columns.Add("Area");
            if (chkContinent.Checked)
                dt.Columns.Add("Continent");

            var countries = context.Countries.ToList();

            foreach (var country in countries)
            {
                DataRow row = dt.NewRow();
                if (chkId.Checked)
                    row["Id"] = country.Id;
                if (chkCountryName.Checked)
                    row["CountryName"] = country.CountryName;
                if (chkPopulation.Checked)
                    row["Population"] = country.Population;
                if (chkArea.Checked)
                    row["Area"] = country.Area;
                if (chkContinent.Checked)
                    row["Continent"] = country.Continent;

                dt.Rows.Add(row);
            }
            dataGridViewResults.DataSource = dt;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string selectedTask = comboBoxTasks.SelectedItem?.ToString();
            DataTable resultTable = null;

            switch (selectedTask)
            {
                case "Показать полную информацию о странах":
                    resultTable = GetAllCountries();
                    break;
                case "Показать информацию о конкретной стране":
                    string countryName = textBoxCountryName.Text;
                    resultTable = GetCountryInfo(countryName);
                    break;
                case "Показать информацию о городах конкретной страны":
                    string selectedCountry = textBoxCountryName.Text;
                    resultTable = GetCitiesByCountry(selectedCountry);
                    break;
                case "Показать все страны, чьё имя начинается с буквы":
                    char startingLetter = textBoxStartingLetter.Text.Length > 0 ? textBoxStartingLetter.Text[0] : ' ';
                    resultTable = GetCountriesStartingWith(startingLetter);
                    break;
                case "Показать все столицы, чьё имя начинается с буквы":
                    char capitalStartingLetter = textBoxStartingLetter.Text.Length > 0 ? textBoxStartingLetter.Text[0] : ' ';
                    resultTable = GetCapitalsStartingWith(capitalStartingLetter);
                    break;
                case "Топ-3 столиц с наименьшим количеством жителей":
                    resultTable = GetTop3CapitalsByPopulation();
                    break;
                case "Топ-3 стран с наименьшим количеством жителей":
                    resultTable = GetTop3CountriesByPopulation();
                    break;
                case "Среднее количество жителей в столицах по каждой части света":
                    resultTable = GetAveragePopulationCapitalsByContinent();
                    break;
                case "Топ-3 стран по каждой части света с наименьшим количеством жителей":
                    resultTable = GetTop3CountriesByContinentMinPopulation();
                    break;
                case "Топ-3 стран по каждой части света с наибольшим количеством жителей":
                    resultTable = GetTop3CountriesByContinentMaxPopulation();
                    break;
                case "Среднее количество жителей в конкретной стране":
                    string specificCountry = textBoxCountryName.Text;
                    resultTable = GetAveragePopulationInCountry(specificCountry);
                    break;
                case "Город с наименьшим количеством жителей в конкретной стране":
                    string countryForCity = textBoxCountryName.Text;
                    resultTable = GetCityWithMinPopulationInCountry(countryForCity);
                    break;
                default:
                    MessageBox.Show("Выберите задачу.");
                    return;
            }

            dataGridViewResults.DataSource = resultTable;
        }

        private DataTable GetAllCountries()
        {
            var countries = context.Countries.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("CountryName");
            dt.Columns.Add("Population");
            dt.Columns.Add("Area");
            dt.Columns.Add("Continent");

            foreach (var country in countries)
            {
                dt.Rows.Add(country.Id, country.CountryName, country.Population, country.Area, country.Continent);
            }

            return dt;
        }

        private DataTable GetCountryInfo(string countryName)
        {
            var country = context.Countries
          .FirstOrDefault(c => c.CountryName.ToLower() == countryName.ToLower());
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("CountryName");
            dt.Columns.Add("Population");
            dt.Columns.Add("Area");
            dt.Columns.Add("Continent");

            if (country != null)
            {
                dt.Rows.Add(country.Id, country.CountryName, country.Population, country.Area, country.Continent);
            }

            return dt;
        }


        private DataTable GetCitiesByCountry(string countryName)
        {
            var country = context.Countries
                    .FirstOrDefault(c => c.CountryName.ToLower() == countryName.ToLower()); 
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("CityName");
            dt.Columns.Add("CityPopulation");

            if (country != null)
            {
                var cities = context.Cities.Where(c => c.CountryId == country.Id).ToList();
                foreach (var city in cities)
                {
                    dt.Rows.Add(city.Id, city.CityName, city.CityPopulation);
                }
            }

            return dt;
        }

        private DataTable GetCountriesStartingWith(char letter)
        {
            string lowerLetter = letter.ToString().ToLower(); 
            var countries = context.Countries
                .Where(c => c.CountryName.ToLower().StartsWith(lowerLetter))
                .ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("CountryName");
            dt.Columns.Add("Population");
            dt.Columns.Add("Area");
            dt.Columns.Add("Continent");

            foreach (var country in countries)
            {
                dt.Rows.Add(country.Id, country.CountryName, country.Population, country.Area, country.Continent);
            }

            return dt;
        }

        private DataTable GetCapitalsStartingWith(char letter)
        {
            string lowerLetter = letter.ToString().ToLower();
            var capitals = context.Capitals
                .Where(c => c.CapitalName.ToLower().StartsWith(lowerLetter)) 
                .ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("CapitalName");
            dt.Columns.Add("CapitalPopulation");

            foreach (var capital in capitals)
            {
                dt.Rows.Add(capital.Id, capital.CapitalName, capital.CapitalPopulation);
            }

            return dt;
        }

        private DataTable GetTop3CapitalsByPopulation()
        {
            var capitals = (from c in context.Capitals
                            orderby c.CapitalPopulation ascending
                            select new { c.Id, c.CapitalName, c.CapitalPopulation })
                           .Take(3)
                           .ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("CapitalName");
            dt.Columns.Add("CapitalPopulation");

            foreach (var capital in capitals)
            {
                dt.Rows.Add(capital.Id, capital.CapitalName, capital.CapitalPopulation);
            }

            return dt;
        }

        private DataTable GetTop3CountriesByPopulation()
        {
            var countries = (from c in context.Countries
                             orderby c.Population ascending
                             select new { c.Id, c.CountryName, c.Population })
                            .Take(3)
                            .ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("CountryName");
            dt.Columns.Add("Population");

            foreach (var country in countries)
            {
                dt.Rows.Add(country.Id, country.CountryName, country.Population);
            }

            return dt;
        }

        private DataTable GetAveragePopulationCapitalsByContinent()
        {
            var averages = from c in context.Capitals
                           group c by c.Countries.Continent into g
                           select new
                           {
                               Continent = g.Key,
                               AveragePopulation = g.Average(c => (double?)c.CapitalPopulation) ?? 0
                           };

            DataTable dt = new DataTable();
            dt.Columns.Add("Continent");
            dt.Columns.Add("AveragePopulation");

            foreach (var average in averages)
            {
                dt.Rows.Add(average.Continent, average.AveragePopulation);
            }

            return dt;
        }

        private DataTable GetTop3CountriesByContinentMinPopulation()
        {
            var topCountries = from c in context.Countries
                               group c by c.Continent into g
                               select new
                               {
                                   Continent = g.Key,
                                   Countries = g.OrderBy(c => c.Population).Take(3)
                               };

            DataTable dt = new DataTable();
            dt.Columns.Add("Continent");
            dt.Columns.Add("CountryName");
            dt.Columns.Add("Population");

            foreach (var group in topCountries)
            {
                foreach (var country in group.Countries)
                {
                    dt.Rows.Add(group.Continent, country.CountryName, country.Population);
                }
            }

            return dt;
        }

        private DataTable GetTop3CountriesByContinentMaxPopulation()
        {
            var topCountries = from c in context.Countries
                               group c by c.Continent into g
                               select new
                               {
                                   Continent = g.Key,
                                   Countries = g.OrderByDescending(c => c.Population).Take(3)
                               };

            DataTable dt = new DataTable();
            dt.Columns.Add("Continent");
            dt.Columns.Add("CountryName");
            dt.Columns.Add("Population");

            foreach (var group in topCountries)
            {
                foreach (var country in group.Countries)
                {
                    dt.Rows.Add(group.Continent, country.CountryName, country.Population);
                }
            }

            return dt;
        }

        private DataTable GetAveragePopulationInCountry(string countryName)
        {
            var country = context.Countries
                    .FirstOrDefault(c => c.CountryName.ToLower() == countryName.ToLower()); 
            DataTable dt = new DataTable();
            dt.Columns.Add("AveragePopulation");

            if (country != null)
            {
                double averagePopulation = context.Cities
                    .Where(c => c.CountryId == country.Id)
                    .Average(c => (double?)c.CityPopulation) ?? 0;
                dt.Rows.Add(averagePopulation);
            }

            return dt;
        }


        private DataTable GetCityWithMinPopulationInCountry(string countryName)
        {
            var country = context.Countries
                   .FirstOrDefault(c => c.CountryName.ToLower() == countryName.ToLower());
            DataTable dt = new DataTable();
            dt.Columns.Add("CityName");
            dt.Columns.Add("CityPopulation");

            if (country != null)
            {
                var city = context.Cities
                    .Where(c => c.CountryId == country.Id)
                    .OrderBy(c => c.CityPopulation)
                    .FirstOrDefault();

                if (city != null)
                {
                    dt.Rows.Add(city.CityName, city.CityPopulation);
                }
            }

            return dt;
        }
    }
}