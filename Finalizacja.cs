using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Finalizacja : Form
    {

        public Finalizacja()
        {
            InitializeComponent();
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Gitara! Wyślemy książki jutro!", "Zamknięcie aplikacji", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                
                Application.Exit();
            }
        }
    }
}
