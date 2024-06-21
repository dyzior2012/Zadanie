namespace Zadanie
{
    partial class Przygodowe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.ListBox listBoxPrz;
        private System.Windows.Forms.PictureBox pictureBoxPrz;

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
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.listBoxPrz = new System.Windows.Forms.ListBox();
            this.pictureBoxPrz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd3
            // 
            this.btnAdd3.Location = new System.Drawing.Point(120, 220);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(75, 23);
            this.btnAdd3.TabIndex = 0;
            this.btnAdd3.Text = "Dodaj";
            this.btnAdd3.UseVisualStyleBackColor = true;
            // 
            // listBoxPrz
            // 
            this.listBoxPrz.FormattingEnabled = true;
            this.listBoxPrz.Location = new System.Drawing.Point(20, 20);
            this.listBoxPrz.Name = "listBoxPrz";
            this.listBoxPrz.Size = new System.Drawing.Size(240, 180);
            this.listBoxPrz.TabIndex = 1;
            // 
            // pictureBoxPrz
            // 
            this.pictureBoxPrz.Image = global::Zadanie.Properties.Resources.przygoda;
            this.pictureBoxPrz.Location = new System.Drawing.Point(200, 220);
            this.pictureBoxPrz.Name = "pictureBoxPrz";
            this.pictureBoxPrz.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxPrz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPrz.TabIndex = 2;
            this.pictureBoxPrz.TabStop = false;
            // 
            // Przygodowe
            // 
            this.Controls.Add(this.pictureBoxPrz);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.listBoxPrz);
            this.Name = "Przygodowe";
            this.Size = new System.Drawing.Size(280, 260);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrz)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
