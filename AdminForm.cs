using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string genre = txtGenre.Text;
            string author = txtAuthor.Text;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Title, Genre, and Author are required.");
                return;
            }

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Books (Title, Genre, Author) VALUES (@Title, @Genre, @Author)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@Author", author);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Book added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM Books WHERE Title = @Title";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Book deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting book: " + ex.Message);
            }
        }
    }
}
