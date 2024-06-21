namespace Zadanie
{
    partial class Edukuacyjne
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddEdu;
        private System.Windows.Forms.ListBox listBoxEdu;
        private System.Windows.Forms.PictureBox pictureBoxEdu;

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
            this.btnAddEdu = new System.Windows.Forms.Button();
            this.listBoxEdu = new System.Windows.Forms.ListBox();
            this.pictureBoxEdu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEdu
            // 
            this.btnAddEdu.Location = new System.Drawing.Point(120, 220);
            this.btnAddEdu.Name = "btnAddEdu";
            this.btnAddEdu.Size = new System.Drawing.Size(75, 23);
            this.btnAddEdu.TabIndex = 0;
            this.btnAddEdu.Text = "Dodaj";
            this.btnAddEdu.UseVisualStyleBackColor = true;
            // 
            // listBoxEdu
            // 
            this.listBoxEdu.FormattingEnabled = true;
            this.listBoxEdu.Location = new System.Drawing.Point(20, 20);
            this.listBoxEdu.Name = "listBoxEdu";
            this.listBoxEdu.Size = new System.Drawing.Size(240, 180);
            this.listBoxEdu.TabIndex = 1;
            // 
            // pictureBoxEdu
            // 
            this.pictureBoxEdu.Image = global::Zadanie.Properties.Resources.edukacja;
            this.pictureBoxEdu.Location = new System.Drawing.Point(200, 220);
            this.pictureBoxEdu.Name = "pictureBoxEdu";
            this.pictureBoxEdu.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxEdu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdu.TabIndex = 2;
            this.pictureBoxEdu.TabStop = false;
            // 
            // Edukuacyjne
            // 
            this.Controls.Add(this.pictureBoxEdu);
            this.Controls.Add(this.btnAddEdu);
            this.Controls.Add(this.listBoxEdu);
            this.Name = "Edukuacyjne";
            this.Size = new System.Drawing.Size(280, 260);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdu)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
