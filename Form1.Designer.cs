namespace aplikacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addPhoto = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.addPhoto1 = new System.Windows.Forms.Button();
            this.textName1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPhoto2 = new System.Windows.Forms.Button();
            this.textName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lName.Location = new System.Drawing.Point(22, 64);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(60, 26);
            this.lName.TabIndex = 0;
            this.lName.Text = "Imie:";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.Highlight;
            this.textName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.Location = new System.Drawing.Point(92, 61);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(226, 32);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "C:\\\\";
            // 
            // addPhoto
            // 
            this.addPhoto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPhoto.Location = new System.Drawing.Point(22, 99);
            this.addPhoto.Name = "addPhoto";
            this.addPhoto.Size = new System.Drawing.Size(296, 28);
            this.addPhoto.TabIndex = 4;
            this.addPhoto.Text = "Dodaj zdjeicie";
            this.addPhoto.UseVisualStyleBackColor = true;
            this.addPhoto.Click += new System.EventHandler(this.addPhoto_Click);
            // 
            // addUser
            // 
            this.addUser.Enabled = false;
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addUser.Location = new System.Drawing.Point(327, 392);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(235, 32);
            this.addUser.TabIndex = 5;
            this.addUser.Text = "Utworz uzytkownika";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // addPhoto1
            // 
            this.addPhoto1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addPhoto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPhoto1.Location = new System.Drawing.Point(22, 239);
            this.addPhoto1.Name = "addPhoto1";
            this.addPhoto1.Size = new System.Drawing.Size(296, 28);
            this.addPhoto1.TabIndex = 8;
            this.addPhoto1.Text = "Dodaj zdjeicie";
            this.addPhoto1.UseVisualStyleBackColor = true;
            this.addPhoto1.Click += new System.EventHandler(this.addPhoto1_Click);
            // 
            // textName1
            // 
            this.textName1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textName1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textName1.ForeColor = System.Drawing.Color.White;
            this.textName1.Location = new System.Drawing.Point(92, 201);
            this.textName1.Name = "textName1";
            this.textName1.Size = new System.Drawing.Size(226, 32);
            this.textName1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(22, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imie:";
            // 
            // addPhoto2
            // 
            this.addPhoto2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addPhoto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPhoto2.Location = new System.Drawing.Point(22, 361);
            this.addPhoto2.Name = "addPhoto2";
            this.addPhoto2.Size = new System.Drawing.Size(296, 28);
            this.addPhoto2.TabIndex = 11;
            this.addPhoto2.Text = "Dodaj zdjeicie";
            this.addPhoto2.UseVisualStyleBackColor = true;
            this.addPhoto2.Click += new System.EventHandler(this.addPhoto2_Click);
            // 
            // textName2
            // 
            this.textName2.BackColor = System.Drawing.SystemColors.Highlight;
            this.textName2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textName2.ForeColor = System.Drawing.Color.White;
            this.textName2.Location = new System.Drawing.Point(92, 322);
            this.textName2.Name = "textName2";
            this.textName2.Size = new System.Drawing.Size(226, 32);
            this.textName2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(22, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Imie:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Image = global::aplikacja.Properties.Resources.Bez_nazwy_2;
            this.label3.Location = new System.Drawing.Point(324, -21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 410);
            this.label3.TabIndex = 12;
            // 
            // print
            // 
            this.print.Enabled = false;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.print.Location = new System.Drawing.Point(568, 392);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(130, 32);
            this.print.TabIndex = 13;
            this.print.Text = "Drukuj";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addPhoto2);
            this.Controls.Add(this.textName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPhoto1);
            this.Controls.Add(this.textName1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.addPhoto);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button addPhoto;
        public System.Windows.Forms.TextBox textName;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button addPhoto1;
        public System.Windows.Forms.TextBox textName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPhoto2;
        public System.Windows.Forms.TextBox textName2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button print;
    }
}

