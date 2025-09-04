namespace PHubbsProgram13
{
    partial class TennisChampsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TennisChampsForm));
            btnTotalWins = new Button();
            btnBackToBack = new Button();
            btnExit = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lblOutput = new Label();
            cboxPlayerName = new ComboBox();
            cboxChampions = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnTotalWins
            // 
            btnTotalWins.Location = new Point(455, 43);
            btnTotalWins.Name = "btnTotalWins";
            btnTotalWins.Size = new Size(150, 36);
            btnTotalWins.TabIndex = 0;
            btnTotalWins.Text = "How many wins?";
            btnTotalWins.UseVisualStyleBackColor = true;
            btnTotalWins.Click += btnTotalWins_Click;
            // 
            // btnBackToBack
            // 
            btnBackToBack.Location = new Point(637, 43);
            btnBackToBack.Name = "btnBackToBack";
            btnBackToBack.Size = new Size(268, 36);
            btnBackToBack.TabIndex = 1;
            btnBackToBack.Text = "How many times back-to-back champions?";
            btnBackToBack.UseVisualStyleBackColor = true;
            btnBackToBack.Click += btnBackToBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(924, 43);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(71, 36);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 75);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(67, 15);
            lbl1.TabIndex = 3;
            lbl1.Text = "Top Players";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(210, 75);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(182, 15);
            lbl2.TabIndex = 4;
            lbl2.Text = "US Open Champions (since 1968)";
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.Fixed3D;
            lblOutput.Location = new Point(455, 101);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(526, 33);
            lblOutput.TabIndex = 5;
            // 
            // cboxPlayerName
            // 
            cboxPlayerName.FormattingEnabled = true;
            cboxPlayerName.Items.AddRange(new object[] { "Agnieszka Radwanska", "Amelie Mauresmo", "Andrea Jaeger", "Angelique Kerber", "Ann Jones", "Arantxa Sanchez Vicario", "Aryna Sabalenka", "Ashleigh Barty", "Betty Stove", "Bianca Andreescu", "Billie Jean King", "Caroline Garcia", "Chris Evert", "Coco Gauff", "Conchita Martinez", "Elena Rybakina", "Emma Raducanu", "Eugenie Bouchard", "Evonne Goolagong", "Flavia Pennetta", "Gabriela Sabatini", "Garbine Muguruza", "Hana Mandlikova", "Helena Sukova", "Iga Swiatek", "Jana Novotna", "Jennifer Capriati", "Jessica Pegula", "Judy Tegart", "Justine Henin", "Karolina Muchova", "Karolina Pliskova", "Kim Clijsters", "Lindsay Davenport", "Margaret Court", "Maria Sakkari", "Maria Sharapova", "Marion Bartoli", "Marketa Vondrousova", "Martina Hingis", "Martina Navratilova", "Mary Pierce", "Monica Seles", "Naomi Osaka", "Nathalie Tauziat", "Olga Morozova", "Ons Jabeur", "Petra Kvitova", "Sabine Lisicki", "Samantha Stosur", "Serena Williams", "Simona Halep", "Sloane Stephens", "Steffi Graf", "Svetlana Kuznetsova", "Tracy Austin", "Venus Williams", "Vera Zvonareva", "Virginia Wade", "Zina Garrison" });
            cboxPlayerName.Location = new Point(12, 111);
            cboxPlayerName.Name = "cboxPlayerName";
            cboxPlayerName.Size = new Size(166, 23);
            cboxPlayerName.TabIndex = 6;
            // 
            // cboxChampions
            // 
            cboxChampions.FormattingEnabled = true;
            cboxChampions.Items.AddRange(new object[] { "Virginia Wade", "Margaret Court", "Margaret Court", "Billie Jean King", "Billie Jean King", "Margaret Court", "Billie Jean King", "Chris Evert", "Chris Evert", "Chris Evert", "Chris Evert", "Tracy Austin", "Chris Evert", "Tracy Austin", "Chris Evert", "Martina Navratilova", "Martina Navratilova", "Hana Mandlíkova", "Martina Navratilova", "Martina Navratilova", "Steffi Graf", "Steffi Graf", "Gabriela Sabatini", "Monica Seles", "Monica Seles", "Steffi Graf", "Arantxa Sanchez Vicario", "Steffi Graf", "Steffi Graf", "Martina Hingis", "Lindsay Davenport", "Serena Williams", "Venus Williams", "Venus Williams", "Serena Williams", "Justine Henin", "Svetlana Kuznetsova", "Kim Clijsters", "Maria Sharapova", "Justine Henin", "Serena Williams", "Kim Clijsters", "Kim Clijsters", "Samantha Stosur", "Serena Williams", "Serena Williams", "Serena Williams", "Flavia Pennetta", "Angelique Kerber", "Sloane Stephens", "Naomi Osaka", "Bianca Andreescu", "Naomi Osaka", "Emma Raducanu", "Iga Swiatek", "Coco Gauff", "Aryna Sabalenka" });
            cboxChampions.Location = new Point(210, 111);
            cboxChampions.Name = "cboxChampions";
            cboxChampions.Size = new Size(182, 23);
            cboxChampions.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 389);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 8;
            label1.Text = "Developed by E. P. Hubbs";
            // 
            // TennisChampsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1017, 430);
            Controls.Add(label1);
            Controls.Add(cboxChampions);
            Controls.Add(cboxPlayerName);
            Controls.Add(lblOutput);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnExit);
            Controls.Add(btnBackToBack);
            Controls.Add(btnTotalWins);
            DoubleBuffered = true;
            Name = "TennisChampsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Open Singles Champions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTotalWins;
        private Button btnBackToBack;
        private Button btnExit;
        private Label lbl1;
        private Label lbl2;
        private Label lblOutput;
        private ComboBox cboxPlayerName;
        private ComboBox cboxChampions;
        private Label label1;
    }
}