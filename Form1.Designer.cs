namespace TotalCommander
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lprzenies = new Button();
            lkopiuj = new Button();
            lzmien = new Button();
            lusun = new Button();
            pprzenies = new Button();
            pkopiuj = new Button();
            pzmien = new Button();
            pusun = new Button();
            label2 = new Label();
            zmienNazweBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ldodajkatalog = new Button();
            pdodajkatalog = new Button();
            label5 = new Label();
            label6 = new Label();
            lkatalognazwa = new TextBox();
            pkatalognazwa = new TextBox();
            latrybuty = new Button();
            patrybuty = new Button();
            browser1 = new Browser();
            browser2 = new Browser();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 22);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "przenieś";
            // 
            // lprzenies
            // 
            lprzenies.Location = new Point(386, 40);
            lprzenies.Name = "lprzenies";
            lprzenies.Size = new Size(38, 23);
            lprzenies.TabIndex = 3;
            lprzenies.Text = "-->";
            lprzenies.UseVisualStyleBackColor = true;
            lprzenies.Click += lprzenies_Click;
            // 
            // lkopiuj
            // 
            lkopiuj.Location = new Point(386, 120);
            lkopiuj.Name = "lkopiuj";
            lkopiuj.Size = new Size(38, 23);
            lkopiuj.TabIndex = 4;
            lkopiuj.Text = "-->";
            lkopiuj.UseVisualStyleBackColor = true;
            lkopiuj.Click += lkopiuj_Click;
            // 
            // lzmien
            // 
            lzmien.Location = new Point(386, 216);
            lzmien.Name = "lzmien";
            lzmien.Size = new Size(38, 23);
            lzmien.TabIndex = 5;
            lzmien.Text = "<";
            lzmien.UseVisualStyleBackColor = true;
            lzmien.Click += lzmien_Click;
            // 
            // lusun
            // 
            lusun.Location = new Point(386, 293);
            lusun.Name = "lusun";
            lusun.Size = new Size(38, 23);
            lusun.TabIndex = 6;
            lusun.Text = "<";
            lusun.UseVisualStyleBackColor = true;
            lusun.Click += lusun_Click;
            // 
            // pprzenies
            // 
            pprzenies.Location = new Point(461, 40);
            pprzenies.Name = "pprzenies";
            pprzenies.Size = new Size(38, 23);
            pprzenies.TabIndex = 7;
            pprzenies.Text = "<--";
            pprzenies.UseVisualStyleBackColor = true;
            pprzenies.Click += lprzenies_Click;
            // 
            // pkopiuj
            // 
            pkopiuj.Location = new Point(461, 120);
            pkopiuj.Name = "pkopiuj";
            pkopiuj.Size = new Size(38, 23);
            pkopiuj.TabIndex = 8;
            pkopiuj.Text = "<--";
            pkopiuj.UseVisualStyleBackColor = true;
            pkopiuj.Click += lkopiuj_Click;
            // 
            // pzmien
            // 
            pzmien.Location = new Point(461, 216);
            pzmien.Name = "pzmien";
            pzmien.Size = new Size(38, 23);
            pzmien.TabIndex = 9;
            pzmien.Text = ">";
            pzmien.UseVisualStyleBackColor = true;
            pzmien.Click += lzmien_Click;
            // 
            // pusun
            // 
            pusun.Location = new Point(461, 293);
            pusun.Name = "pusun";
            pusun.Size = new Size(38, 23);
            pusun.TabIndex = 10;
            pusun.Text = ">";
            pusun.UseVisualStyleBackColor = true;
            pusun.Click += lusun_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 102);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "kopiuj";
            // 
            // zmienNazweBox
            // 
            zmienNazweBox.Location = new Point(386, 187);
            zmienNazweBox.Name = "zmienNazweBox";
            zmienNazweBox.Size = new Size(113, 23);
            zmienNazweBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 160);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 13;
            label3.Text = "zmień nazwe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 275);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 14;
            label4.Text = "Usuń katalog";
            // 
            // ldodajkatalog
            // 
            ldodajkatalog.Location = new Point(25, 477);
            ldodajkatalog.Name = "ldodajkatalog";
            ldodajkatalog.Size = new Size(38, 23);
            ldodajkatalog.TabIndex = 15;
            ldodajkatalog.Text = "+";
            ldodajkatalog.UseVisualStyleBackColor = true;
            ldodajkatalog.Click += ldodajkatalog_Click;
            // 
            // pdodajkatalog
            // 
            pdodajkatalog.Location = new Point(798, 477);
            pdodajkatalog.Name = "pdodajkatalog";
            pdodajkatalog.Size = new Size(38, 23);
            pdodajkatalog.TabIndex = 16;
            pdodajkatalog.Text = "+";
            pdodajkatalog.UseVisualStyleBackColor = true;
            pdodajkatalog.Click += ldodajkatalog_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 477);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 17;
            label5.Text = "dodaj katalog";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(713, 477);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 18;
            label6.Text = "dodaj katalog";
            // 
            // lkatalognazwa
            // 
            lkatalognazwa.Location = new Point(25, 448);
            lkatalognazwa.Name = "lkatalognazwa";
            lkatalognazwa.Size = new Size(100, 23);
            lkatalognazwa.TabIndex = 19;
            // 
            // pkatalognazwa
            // 
            pkatalognazwa.Location = new Point(736, 448);
            pkatalognazwa.Name = "pkatalognazwa";
            pkatalognazwa.Size = new Size(100, 23);
            pkatalognazwa.TabIndex = 20;
            // 
            // latrybuty
            // 
            latrybuty.Location = new Point(262, 460);
            latrybuty.Name = "latrybuty";
            latrybuty.Size = new Size(75, 23);
            latrybuty.TabIndex = 21;
            latrybuty.Text = "atrybuty";
            latrybuty.UseVisualStyleBackColor = true;
            latrybuty.Click += latrybuty_Click;
            // 
            // patrybuty
            // 
            patrybuty.Location = new Point(523, 460);
            patrybuty.Name = "patrybuty";
            patrybuty.Size = new Size(75, 23);
            patrybuty.TabIndex = 22;
            patrybuty.Text = "atrybuty";
            patrybuty.UseVisualStyleBackColor = true;
            patrybuty.Click += latrybuty_Click;
            // 
            // browser1
            // 
            browser1.Location = new Point(-3, 7);
            browser1.Name = "browser1";
            browser1.Size = new Size(383, 435);
            browser1.TabIndex = 23;
            // 
            // browser2
            // 
            browser2.Location = new Point(505, 12);
            browser2.Name = "browser2";
            browser2.Size = new Size(383, 435);
            browser2.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 514);
            Controls.Add(browser2);
            Controls.Add(browser1);
            Controls.Add(patrybuty);
            Controls.Add(latrybuty);
            Controls.Add(pkatalognazwa);
            Controls.Add(lkatalognazwa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pdodajkatalog);
            Controls.Add(ldodajkatalog);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(zmienNazweBox);
            Controls.Add(label2);
            Controls.Add(pusun);
            Controls.Add(pzmien);
            Controls.Add(pkopiuj);
            Controls.Add(pprzenies);
            Controls.Add(lusun);
            Controls.Add(lzmien);
            Controls.Add(lkopiuj);
            Controls.Add(lprzenies);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TotalCommander - Copy";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button lprzenies;
        private Button lkopiuj;
        private Button lzmien;
        private Button lusun;
        private Button pprzenies;
        private Button pkopiuj;
        private Button pzmien;
        private Button pusun;
        private Label label2;
        private TextBox zmienNazweBox;
        private Label label3;
        private Label label4;
        private Button ldodajkatalog;
        private Button pdodajkatalog;
        private Label label5;
        private Label label6;
        private TextBox lkatalognazwa;
        private TextBox pkatalognazwa;
        private Button latrybuty;
        private Button patrybuty;
        private Browser browser1;
        private Browser browser2;
    }
}