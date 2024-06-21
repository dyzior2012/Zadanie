using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Edukuacyjne : UserControl
    {
        private IFormOperations glownaControl;
        public IFormOperations GlownaControl
        {
            get { return glownaControl; }
            set { glownaControl = value; }
        }

        public Edukuacyjne()
        {
            InitializeComponent();
            btnAddEdu.Click += btnAddEdu_Click;
            LoadBooks();
        }

        private void LoadBooks()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT Title FROM Books WHERE Genre = 'Edukacyjne'";
                var command = new SQLiteCommand(query, connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBoxEdu.Items.Add(reader["Title"].ToString());
                }
            }
        }

        private void btnAddEdu_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();
            foreach (var item in listBoxEdu.SelectedItems.OfType<string>().ToList())
            {
                selectedItems.Add(item);
            }

            GlownaControl?.AddItemsToZakupy(selectedItems);
        }
    }
}
