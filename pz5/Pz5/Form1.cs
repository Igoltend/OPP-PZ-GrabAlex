using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pz5
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> carModels = new Dictionary<string, List<string>>
        {
            {
                "Audi", new List<string>
                {
                    "A3", "A4", "A6"
                }
            },
            {
                "BMW", new List<string>
                {
                    "3 Series", "5 Series", "7 Series"
                }
            },
            {
                "Mercedes-Benz", new List<string>
                {
                    "C-Class", "E-Class", "S-Class"
                }
            }
        };

        // Створюємо словник для збереження автомобілів за моделлю та роком
        private Dictionary<string, List<(string, string)>> carList = new Dictionary<string, List<(string, string)>>
        {
            {
                "A3", new List<(string, string)>
                {
                    ("Audi A3 2021", "Automatic"),
                    ("Audi A3 2020", "Manual"),
                    ("Audi A3 2019", "Automatic")
                }
            },
            {
                "A4", new List<(string, string)>
                {
                    ("Audi A4 2021", "Manual"),
                    ("Audi A4 2020", "Automatic"),
                    ("Audi A4 2019", "Automatic")
                }
            },
            {
                "A6", new List<(string, string)>
                {
                    ("Audi A6 2021", "Automatic"),
                    ("Audi A6 2020", "Automatic"),
                    ("Audi A6 2019", "Manual")
                }
            },
            {
                "3 Series", new List<(string, string)>
                {
                    ("BMW 3 Series 2021", "Manual"),
                    ("BMW 3 Series 2020", "Automatic"),
                    ("BMW 3 Series 2019", "Manual")
                }
            },
            {
                "5 Series", new List<(string, string)>
                {
                    ("BMW 5 Series 2021", "Automatic"),
                    ("BMW 5 Series 2020", "Automatic"),
                    ("BMW 5 Series 2019", "Manual")
                }
            },
            {
                "7 Series", new List<(string, string)>
                {
                    ("BMW 7 Series 2021", "Automatic"),
                    ("BMW 7 Series 2020", "Automatic"),
                    ("BMW 7 Series 2019", "Automatic")
                }
            },
            {
                "C-Class", new List<(string, string)>
                {
                    ("Mercedes-Benz C-Class 2021", "Manual"),
                    ("Mercedes-Benz C-Class 2020", "Automatic"),
                    ("Mercedes-Benz C-Class 2019", "Manual")
                }
            },
            {
                "E-Class", new List<(string, string)>
                {
                    ("Mercedes-Benz E-Class 2021", "Automatic"),
                    ("Mercedes-Benz E-Class 2020", "Manual"),
                    ("Mercedes-Benz E-Class 2019", "Automatic")
                }
            },
            {
                "S-Class", new List<(string, string)>
                {
                    ("Mercedes-Benz S-Class 2021", "Automatic"),
                    ("Mercedes-Benz S-Class 2020", "Automatic"),
                    ("Mercedes-Benz S-Class 2019", "Automatic")
                }
            }
        };

        public Form1()
        {
            InitializeComponent();
            InitializeCarBrands();
        }

        private void InitializeCarBrands()
        {
            comboBoxBrand.Items.AddRange(carModels.Keys.ToArray());
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = comboBoxModel.SelectedItem.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string brand = comboBoxBrand.SelectedItem.ToString();
            string model = comboBoxModel.SelectedItem?.ToString();
            string year = textBoxYear.Text;
            string transmission = radioButtonAutomatic.Checked ? "Automatic" : "Manual";

            if (string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Please select a car model.", "No Model Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<(string, string)> availableCars = carList[model];
            List<string> filteredCars = availableCars
                .Where(car => car.Item1.Contains(year) && car.Item2 == transmission)
                .Select(car => car.Item1)
                .ToList();

            if (filteredCars.Count == 0)
            {
                MessageBox.Show("There are no cars available for the selected model, year, and transmission.", "No Cars Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string message = $"Available {transmission} cars for {brand} {model} in {year}:\n\n";
            message += string.Join("\n", filteredCars);

            MessageBox.Show(message, "Available Cars", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //InitializeComponent();
        }
        private void comboBoxBrand_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedBrand = comboBoxBrand.SelectedItem.ToString();
            comboBoxModel.Items.Clear();
            comboBoxModel.Items.AddRange(carModels[selectedBrand].ToArray());
        }
    }
}
