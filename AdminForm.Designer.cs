namespace Zadanie
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor; // Nowe pole dla autora
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor; // Etykieta dla autora
        private System.Windows.Forms.Label lblGenre;

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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox(); // Inicjalizacja nowego pola dla autora
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label(); // Inicjalizacja etykiety dla autora
            this.lblGenre = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(116, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(156, 20);
            this.txtTitle.TabIndex = 0;

            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(116, 68);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(156, 20);
            this.txtAuthor.TabIndex = 1; // Inicjalizacja nowego pola dla autora

            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(116, 104);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(156, 20);
            this.txtGenre.TabIndex = 2;

            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(116, 140);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Dodaj";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(34, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Tytuł";

            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(34, 71);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(35, 13);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Autor"; // Etykieta dla autora

            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(34, 107);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 13);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Gatunek";

            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 187);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAuthor); // Dodanie etykiety autora do formularza
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAuthor); // Dodanie pola autora do formularza
            this.Controls.Add(this.txtTitle);
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
