using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Glowna : Form, IFormOperations
    {
        public Glowna()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = new List<string> { "Dla Dzieci", "Edukacyjne", "Fantastyka", "Przygodowe" };
            listBoxCategories.Items.AddRange(categories.ToArray());
        }

        private void LoadBooks(string category)
        {
            listBoxBooks.Items.Clear();
            try
            {
                var books = DatabaseHelper.GetBooksByGenre(category);
                listBoxBooks.Items.AddRange(books.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        public void AddItemsToZakupy(List<string> items)
        {
            foreach (string item in items)
            {
                if (!listBoxCart.Items.Contains(item))
                {
                    listBoxCart.Items.Add(item);
                }
            }
        }

        public ListBox CartListBox => listBoxCart;

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
            {
                string selectedCategory = listBoxCategories.SelectedItem.ToString();
                LoadBooks(selectedCategory);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            var selectedItems = listBoxBooks.SelectedItems.OfType<string>().ToList();
            AddItemsToZakupy(selectedItems);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            using (var finalizacjaForm = new Finalizacja())
            {
                finalizacjaForm.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var loginForm = new LoginForm())
            {
                loginForm.ShowDialog();

                if (loginForm.IsAuthenticated)
                {
                    using (var adminForm = new AdminForm())
                    {
                        adminForm.ShowDialog();
                    }
                }
            }
        }
    }
}
