namespace Zadanie
{
    partial class Dladzieci
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.ListBox listBoxDla;
        private System.Windows.Forms.PictureBox pictureBoxDlaDzieci;

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
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.listBoxDla = new System.Windows.Forms.ListBox();
            this.pictureBoxDlaDzieci = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDlaDzieci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(120, 220);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 0;
            this.btnAdd2.Text = "Dodaj";
            this.btnAdd2.UseVisualStyleBackColor = true;
            // 
            // listBoxDla
            // 
            this.listBoxDla.FormattingEnabled = true;
            this.listBoxDla.Location = new System.Drawing.Point(20, 20);
            this.listBoxDla.Name = "listBoxDla";
            this.listBoxDla.Size = new System.Drawing.Size(240, 180);
            this.listBoxDla.TabIndex = 1;
            // 
            // pictureBoxDlaDzieci
            // 
            this.pictureBoxDlaDzieci.Image = global::Zadanie.Properties.Resources.dzieci;
            this.pictureBoxDlaDzieci.Location = new System.Drawing.Point(200, 220);
            this.pictureBoxDlaDzieci.Name = "pictureBoxDlaDzieci";
            this.pictureBoxDlaDzieci.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxDlaDzieci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDlaDzieci.TabIndex = 2;
            this.pictureBoxDlaDzieci.TabStop = false;
            // 
            // Dladzieci
            // 
            this.Controls.Add(this.pictureBoxDlaDzieci);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.listBoxDla);
            this.Name = "Dladzieci";
            this.Size = new System.Drawing.Size(280, 260);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDlaDzieci)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
