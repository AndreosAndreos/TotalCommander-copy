namespace TotalCommander
{
    partial class Browser
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            cdrivers = new ComboBox();
            label1 = new Label();
            lbrowser = new ListBox();
            dysk = new Label();
            currentdir = new Label();
            SuspendLayout();
            // 
            // cdrivers
            // 
            cdrivers.FormattingEnabled = true;
            cdrivers.Location = new Point(126, 19);
            cdrivers.Name = "cdrivers";
            cdrivers.Size = new Size(121, 23);
            cdrivers.TabIndex = 0;
            cdrivers.SelectedIndexChanged += cdrivers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 22);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Drivers";
            // 
            // lbrowser
            // 
            lbrowser.FormattingEnabled = true;
            lbrowser.ItemHeight = 15;
            lbrowser.Location = new Point(32, 48);
            lbrowser.Name = "lbrowser";
            lbrowser.Size = new Size(315, 319);
            lbrowser.TabIndex = 2;
            lbrowser.DoubleClick += lbrowser_DoubleClick;
            // 
            // dysk
            // 
            dysk.AutoSize = true;
            dysk.Location = new Point(32, 397);
            dysk.Name = "dysk";
            dysk.Size = new Size(100, 15);
            dysk.TabIndex = 3;
            dysk.Text = "Miejsce na dysku:";
            // 
            // currentdir
            // 
            currentdir.AutoSize = true;
            currentdir.Location = new Point(32, 370);
            currentdir.Name = "currentdir";
            currentdir.Size = new Size(27, 15);
            currentdir.TabIndex = 4;
            currentdir.Text = "dir: ";
            // 
            // Browser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(currentdir);
            Controls.Add(dysk);
            Controls.Add(lbrowser);
            Controls.Add(label1);
            Controls.Add(cdrivers);
            Name = "Browser";
            Size = new Size(383, 435);
            Load += Browser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cdrivers;
        private Label label1;
        private ListBox lbrowser;
        private Label dysk;
        private Label currentdir;
    }
}
