using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Dladzieci : UserControl
    {
        private IFormOperations glownaControl;
        public IFormOperations GlownaControl
        {
            get { return glownaControl; }
            set { glownaControl = value; }
        }

        public Dladzieci()
        {
            InitializeComponent();
            btnAdd2.Click += btnAdd2_Click;
            LoadBooks();
        }

        private void LoadBooks()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT Title FROM Books WHERE Genre = 'Dla Dzieci'";
                var command = new SQLiteCommand(query, connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBoxDla.Items.Add(reader["Title"].ToString());
                }
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();
            foreach (var item in listBoxDla.SelectedItems.OfType<string>().ToList())
            {
                selectedItems.Add(item);
            }

            GlownaControl?.AddItemsToZakupy(selectedItems);
        }
    }
}
