using System.Windows.Forms;

namespace pz_6
{
    public partial class Form1 : Form
    {
        private List<TravelEntry> travelEntries;

        public Form1()
        {
            InitializeComponent();
            travelEntries = new List<TravelEntry>();

            // Автоматичне завантаження файлу під час запуску програми
            LoadFromFile();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string city = cityTextBox.Text;
            string country = countryTextBox.Text;
            DateTime date = dateTextBox.Value;

            if (!string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(country))
            {
                travelEntries.Add(new TravelEntry(city, country, date));
                UpdateListView();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please enter both city and country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListView()
        {
            entriesListView.Items.Clear();
            foreach (var entry in travelEntries)
            {
                ListViewItem item = new ListViewItem(entry.City);
                item.SubItems.Add(entry.Country);
                item.SubItems.Add(entry.Date.ToShortDateString());
                entriesListView.Items.Add(item);
            }
        }

        private void ClearTextBoxes()
        {
            cityTextBox.Clear();
            countryTextBox.Clear();
            dateTextBox.Value = DateTime.Now;
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("travel_entries.txt"))
            {
                foreach (var entry in travelEntries)
                {
                    writer.WriteLine($"{entry.City},{entry.Country},{entry.Date.ToShortDateString()}");
                }
            }
            MessageBox.Show("Travel entries saved to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadFromFile()
        {
            travelEntries.Clear();
            entriesListView.Items.Clear();

            if (File.Exists("travel_entries.txt"))
            {
                using (StreamReader reader = new StreamReader("travel_entries.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string city = parts[0];
                            string country = parts[1];
                            DateTime date = DateTime.Parse(parts[2]);
                            travelEntries.Add(new TravelEntry(city, country, date));
                        }
                    }
                }
                UpdateListView();
                MessageBox.Show("Travel entries loaded from file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No saved travel entries found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void entriesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFileButton_Click(sender, e);
        }
    }

    public class TravelEntry
    {
        public string City { get; }
        public string Country { get; }
        public DateTime Date { get; }

        public TravelEntry(string city, string country, DateTime date)
        {
            City = city;
            Country = country;
            Date = date;
        }
    }

}


