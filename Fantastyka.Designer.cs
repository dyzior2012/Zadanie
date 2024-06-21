namespace Zadanie
{
    partial class Fantastyka
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddFan;
        private System.Windows.Forms.ListBox listBoxFan;
        private System.Windows.Forms.PictureBox pictureBoxFan;

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
            this.btnAddFan = new System.Windows.Forms.Button();
            this.listBoxFan = new System.Windows.Forms.ListBox();
            this.pictureBoxFan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFan
            // 
            this.btnAddFan.Location = new System.Drawing.Point(120, 220);
            this.btnAddFan.Name = "btnAddFan";
            this.btnAddFan.Size = new System.Drawing.Size(75, 23);
            this.btnAddFan.TabIndex = 0;
            this.btnAddFan.Text = "Dodaj";
            this.btnAddFan.UseVisualStyleBackColor = true;
            // 
            // listBoxFan
            // 
            this.listBoxFan.FormattingEnabled = true;
            this.listBoxFan.Location = new System.Drawing.Point(20, 20);
            this.listBoxFan.Name = "listBoxFan";
            this.listBoxFan.Size = new System.Drawing.Size(240, 180);
            this.listBoxFan.TabIndex = 1;
            // 
            // pictureBoxFan
            // 
            this.pictureBoxFan.Image = global::Zadanie.Properties.Resources.fantasy;
            this.pictureBoxFan.Location = new System.Drawing.Point(200, 220);
            this.pictureBoxFan.Name = "pictureBoxFan";
            this.pictureBoxFan.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFan.TabIndex = 2;
            this.pictureBoxFan.TabStop = false;
            // 
            // Fantastyka
            // 
            this.Controls.Add(this.pictureBoxFan);
            this.Controls.Add(this.btnAddFan);
            this.Controls.Add(this.listBoxFan);
            this.Name = "Fantastyka";
            this.Size = new System.Drawing.Size(280, 260);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFan)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
