namespace Zadanie
{
    partial class Glowna
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnLogin; // Deklaracja przycisku logowania
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button(); // Inicjalizacja przycisku logowania
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();

            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel.Controls.Add(this.lblCategories, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblBooks, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblCart, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.listBoxCategories, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.listBoxBooks, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.listBoxCart, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.btnAddToCart, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnSum, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.btnLogin, 0, 2); // Dodanie przycisku logowania do tabeli
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 1;

            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategories.ForeColor = System.Drawing.Color.White;
            this.lblCategories.Location = new System.Drawing.Point(3, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(258, 30);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Kategorie";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;

            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBooks.ForeColor = System.Drawing.Color.White;
            this.lblBooks.Location = new System.Drawing.Point(267, 0);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(258, 30);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "Książki";
            this.lblBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBooks.BackColor = System.Drawing.Color.Transparent;

            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCart.ForeColor = System.Drawing.Color.White;
            this.lblCart.Location = new System.Drawing.Point(531, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(266, 30);
            this.lblCart.TabIndex = 2;
            this.lblCart.Text = "Koszyk";
            this.lblCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCart.BackColor = System.Drawing.Color.Transparent;

            // 
            // listBoxCategories
            // 
            this.listBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(3, 33);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(258, 364);
            this.listBoxCategories.TabIndex = 3;
            this.listBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);

            // 
            // listBoxBooks
            // 
            this.listBoxBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(267, 33);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(258, 364);
            this.listBoxBooks.TabIndex = 4;
            this.listBoxBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // listBoxCart
            // 
            this.listBoxCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.Location = new System.Drawing.Point(531, 33);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(266, 364);
            this.listBoxCart.TabIndex = 5;
            this.listBoxCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.BackColor = System.Drawing.Color.LightGray;
            this.btnAddToCart.Location = new System.Drawing.Point(267, 403);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(258, 44);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Dodaj do koszyka";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);

            // 
            // btnSum
            // 
            this.btnSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSum.BackColor = System.Drawing.Color.LightGray;
            this.btnSum.Location = new System.Drawing.Point(531, 403);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(266, 44);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "Finalizuj";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);

            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(3, 403);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(258, 44);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zadanie.Properties.Resources.library_background; // Ustawienie tła formularza
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "glowna";
            this.Text = "Biblioteka Internetowa";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
