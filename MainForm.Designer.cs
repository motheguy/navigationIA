namespace projet
{
    partial class MainForm
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
            this.pictureBoxOcean = new System.Windows.Forms.PictureBox();
            this.btnClic = new System.Windows.Forms.Button();
            this.textBoxXi = new System.Windows.Forms.TextBox();
            this.lblInitCordinates = new System.Windows.Forms.Label();
            this.lblXi = new System.Windows.Forms.Label();
            this.textBoxYi = new System.Windows.Forms.TextBox();
            this.lblYi = new System.Windows.Forms.Label();
            this.lblEndCordinates = new System.Windows.Forms.Label();
            this.lblXf = new System.Windows.Forms.Label();
            this.lblYf = new System.Windows.Forms.Label();
            this.textBoxXf = new System.Windows.Forms.TextBox();
            this.textBoxYf = new System.Windows.Forms.TextBox();
            this.lblWind = new System.Windows.Forms.Label();
            this.cmbBxWind = new System.Windows.Forms.ComboBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.labelExplication = new System.Windows.Forms.Label();
            this.labelSomme = new System.Windows.Forms.Label();
            this.textBoxSomme = new System.Windows.Forms.TextBox();
            this.labelNbSolution = new System.Windows.Forms.Label();
            this.textBoxNbSolution = new System.Windows.Forms.TextBox();
=======
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcean)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOcean
            // 
<<<<<<< HEAD
            this.pictureBoxOcean.Location = new System.Drawing.Point(568, 65);
            this.pictureBoxOcean.Margin = new System.Windows.Forms.Padding(4);
=======
            this.pictureBoxOcean.Location = new System.Drawing.Point(243, 28);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.pictureBoxOcean.Name = "pictureBoxOcean";
            this.pictureBoxOcean.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxOcean.TabIndex = 0;
            this.pictureBoxOcean.TabStop = false;
            // 
            // btnClic
            // 
            this.btnClic.AccessibleName = "";
<<<<<<< HEAD
            this.btnClic.Location = new System.Drawing.Point(38, 630);
            this.btnClic.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnClic.Location = new System.Drawing.Point(12, 12);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.btnClic.Name = "btnClic";
            this.btnClic.Size = new System.Drawing.Size(94, 29);
            this.btnClic.TabIndex = 1;
            this.btnClic.Text = "Demarrer";
            this.btnClic.UseVisualStyleBackColor = true;
            this.btnClic.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxXi
            // 
<<<<<<< HEAD
            this.textBoxXi.Location = new System.Drawing.Point(96, 275);
            this.textBoxXi.Margin = new System.Windows.Forms.Padding(4);
=======
            this.textBoxXi.Location = new System.Drawing.Point(58, 160);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.textBoxXi.Name = "textBoxXi";
            this.textBoxXi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxXi.Size = new System.Drawing.Size(130, 27);
            this.textBoxXi.TabIndex = 2;
            this.textBoxXi.Text = "100";
            this.textBoxXi.TextChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // lblInitCordinates
            // 
            this.lblInitCordinates.AutoSize = true;
<<<<<<< HEAD
            this.lblInitCordinates.Location = new System.Drawing.Point(38, 237);
            this.lblInitCordinates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lblInitCordinates.Location = new System.Drawing.Point(12, 126);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.lblInitCordinates.Name = "lblInitCordinates";
            this.lblInitCordinates.Size = new System.Drawing.Size(163, 20);
            this.lblInitCordinates.TabIndex = 3;
            this.lblInitCordinates.Text = "Coordonnées initiales : ";
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
<<<<<<< HEAD
            this.lblXi.Location = new System.Drawing.Point(52, 281);
            this.lblXi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lblXi.Location = new System.Drawing.Point(23, 162);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(29, 20);
            this.lblXi.TabIndex = 4;
            this.lblXi.Text = "Xi :";
            // 
            // textBoxYi
            // 
<<<<<<< HEAD
            this.textBoxYi.Location = new System.Drawing.Point(95, 337);
            this.textBoxYi.Margin = new System.Windows.Forms.Padding(4);
=======
            this.textBoxYi.Location = new System.Drawing.Point(58, 206);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.textBoxYi.Name = "textBoxYi";
            this.textBoxYi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxYi.Size = new System.Drawing.Size(130, 27);
            this.textBoxYi.TabIndex = 5;
            this.textBoxYi.Text = "200";
            this.textBoxYi.TextChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
<<<<<<< HEAD
            this.lblYi.Location = new System.Drawing.Point(52, 337);
            this.lblYi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lblYi.Location = new System.Drawing.Point(23, 206);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(28, 20);
            this.lblYi.TabIndex = 6;
            this.lblYi.Text = "Yi :";
            // 
            // lblEndCordinates
            // 
            this.lblEndCordinates.AutoSize = true;
<<<<<<< HEAD
            this.lblEndCordinates.Location = new System.Drawing.Point(37, 399);
            this.lblEndCordinates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lblEndCordinates.Location = new System.Drawing.Point(12, 254);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.lblEndCordinates.Name = "lblEndCordinates";
            this.lblEndCordinates.Size = new System.Drawing.Size(151, 20);
            this.lblEndCordinates.TabIndex = 7;
            this.lblEndCordinates.Text = "Coordonnées finales :";
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
<<<<<<< HEAD
            this.lblXf.Location = new System.Drawing.Point(48, 439);
            this.lblXf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lblXf.Location = new System.Drawing.Point(21, 286);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(30, 20);
            this.lblXf.TabIndex = 8;
            this.lblXf.Text = "Xf :";
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
<<<<<<< HEAD
            this.lblYf.Location = new System.Drawing.Point(51, 483);
            this.lblYf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lblYf.Location = new System.Drawing.Point(23, 322);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(29, 20);
            this.lblYf.TabIndex = 10;
            this.lblYf.Text = "Yf :";
            // 
            // textBoxXf
            // 
<<<<<<< HEAD
            this.textBoxXf.Location = new System.Drawing.Point(94, 439);
            this.textBoxXf.Margin = new System.Windows.Forms.Padding(4);
=======
            this.textBoxXf.Location = new System.Drawing.Point(58, 286);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.textBoxXf.Name = "textBoxXf";
            this.textBoxXf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxXf.Size = new System.Drawing.Size(130, 27);
            this.textBoxXf.TabIndex = 11;
            this.textBoxXf.Text = "200";
            this.textBoxXf.TextChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // textBoxYf
            // 
<<<<<<< HEAD
            this.textBoxYf.Location = new System.Drawing.Point(94, 483);
            this.textBoxYf.Margin = new System.Windows.Forms.Padding(4);
=======
            this.textBoxYf.Location = new System.Drawing.Point(58, 322);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.textBoxYf.Name = "textBoxYf";
            this.textBoxYf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxYf.Size = new System.Drawing.Size(130, 27);
            this.textBoxYf.TabIndex = 12;
            this.textBoxYf.Text = "100";
            this.textBoxYf.TextChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
<<<<<<< HEAD
            this.lblWind.Location = new System.Drawing.Point(38, 127);
            this.lblWind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lblWind.Location = new System.Drawing.Point(13, 60);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(100, 20);
            this.lblWind.TabIndex = 14;
            this.lblWind.Text = "Type de vent :";
            // 
            // cmbBxWind
            // 
            this.cmbBxWind.FormattingEnabled = true;
            this.cmbBxWind.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
<<<<<<< HEAD
            this.cmbBxWind.Location = new System.Drawing.Point(94, 160);
            this.cmbBxWind.Margin = new System.Windows.Forms.Padding(4);
=======
            this.cmbBxWind.Location = new System.Drawing.Point(58, 86);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.cmbBxWind.Name = "cmbBxWind";
            this.cmbBxWind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBxWind.Size = new System.Drawing.Size(130, 28);
            this.cmbBxWind.TabIndex = 15;
            this.cmbBxWind.Text = "a";
            // 
<<<<<<< HEAD
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 695);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Test Animation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(568, 448);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(378, 31);
            this.textBoxResult.TabIndex = 17;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(790, 583);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(230, 31);
=======
            // textBoxTime
            // 
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Location = new System.Drawing.Point(362, 394);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(185, 27);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.textBoxTime.TabIndex = 18;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
<<<<<<< HEAD
            this.labelTime.Location = new System.Drawing.Point(451, 583);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(335, 25);
=======
            this.labelTime.Location = new System.Drawing.Point(243, 397);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(119, 20);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.labelTime.TabIndex = 19;
            this.labelTime.Text = "Temps total de la navigation (en heures) :";
            // 
            // buttonReset
            // 
<<<<<<< HEAD
            this.buttonReset.Location = new System.Drawing.Point(178, 631);
=======
            this.buttonReset.Location = new System.Drawing.Point(122, 14);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(95, 27);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Réinitialiser";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.Reset);
            // 
<<<<<<< HEAD
            // labelExplication
            // 
            this.labelExplication.AutoSize = true;
            this.labelExplication.Location = new System.Drawing.Point(38, 65);
            this.labelExplication.Name = "labelExplication";
            this.labelExplication.Size = new System.Drawing.Size(342, 25);
            this.labelExplication.TabIndex = 21;
            this.labelExplication.Text = "Veuillez sélectionner les valeurs suivantes :";
            // 
            // labelSomme
            // 
            this.labelSomme.AutoSize = true;
            this.labelSomme.Location = new System.Drawing.Point(384, 630);
            this.labelSomme.Name = "labelSomme";
            this.labelSomme.Size = new System.Drawing.Size(406, 25);
            this.labelSomme.TabIndex = 22;
            this.labelSomme.Text = "Somme des noeuds des listes Ouverts et Fermés :";
            // 
            // textBoxSomme
            // 
            this.textBoxSomme.Location = new System.Drawing.Point(790, 630);
            this.textBoxSomme.Name = "textBoxSomme";
            this.textBoxSomme.ReadOnly = true;
            this.textBoxSomme.Size = new System.Drawing.Size(230, 31);
            this.textBoxSomme.TabIndex = 23;
            // 
            // labelNbSolution
            // 
            this.labelNbSolution.AutoSize = true;
            this.labelNbSolution.Location = new System.Drawing.Point(522, 539);
            this.labelNbSolution.Name = "labelNbSolution";
            this.labelNbSolution.Size = new System.Drawing.Size(264, 25);
            this.labelNbSolution.TabIndex = 24;
            this.labelNbSolution.Text = "Nombre de noeuds du chemin :";
            // 
            // textBoxNbSolution
            // 
            this.textBoxNbSolution.Location = new System.Drawing.Point(790, 536);
            this.textBoxNbSolution.Name = "textBoxNbSolution";
            this.textBoxNbSolution.ReadOnly = true;
            this.textBoxNbSolution.Size = new System.Drawing.Size(230, 31);
            this.textBoxNbSolution.TabIndex = 25;
=======
            // richTextBoxResult
            // 
            this.richTextBoxResult.Enabled = false;
            this.richTextBoxResult.Location = new System.Drawing.Point(243, 334);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(300, 50);
            this.richTextBoxResult.TabIndex = 21;
            this.richTextBoxResult.Text = "";
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.textBoxNbSolution);
            this.Controls.Add(this.labelNbSolution);
            this.Controls.Add(this.textBoxSomme);
            this.Controls.Add(this.labelSomme);
            this.Controls.Add(this.labelExplication);
=======
            this.ClientSize = new System.Drawing.Size(582, 435);
            this.Controls.Add(this.richTextBoxResult);
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.cmbBxWind);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.textBoxYf);
            this.Controls.Add(this.textBoxXf);
            this.Controls.Add(this.lblYf);
            this.Controls.Add(this.lblXf);
            this.Controls.Add(this.lblEndCordinates);
            this.Controls.Add(this.lblYi);
            this.Controls.Add(this.textBoxYi);
            this.Controls.Add(this.lblXi);
            this.Controls.Add(this.lblInitCordinates);
            this.Controls.Add(this.textBoxXi);
            this.Controls.Add(this.btnClic);
            this.Controls.Add(this.pictureBoxOcean);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Navigation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcean)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOcean;
        private System.Windows.Forms.Button btnClic;
        private System.Windows.Forms.TextBox textBoxXi;
        private System.Windows.Forms.Label lblInitCordinates;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.TextBox textBoxYi;
        private System.Windows.Forms.Label lblYi;
        private System.Windows.Forms.Label lblEndCordinates;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.Label lblYf;
        private System.Windows.Forms.TextBox textBoxXf;
        private System.Windows.Forms.TextBox textBoxYf;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.ComboBox cmbBxWind;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonReset;
<<<<<<< HEAD
        private System.Windows.Forms.Label labelExplication;
        private System.Windows.Forms.Label labelSomme;
        private System.Windows.Forms.TextBox textBoxSomme;
        private System.Windows.Forms.Label labelNbSolution;
        private System.Windows.Forms.TextBox textBoxNbSolution;
=======
        private System.Windows.Forms.RichTextBox richTextBoxResult;
>>>>>>> 0858c596c8a11bfb850f72a5dd4792f14201db36
    }
}

