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
            this.lblInitCordinates = new System.Windows.Forms.Label();
            this.lblXi = new System.Windows.Forms.Label();
            this.lblYi = new System.Windows.Forms.Label();
            this.lblEndCordinates = new System.Windows.Forms.Label();
            this.lblXf = new System.Windows.Forms.Label();
            this.lblYf = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelExplication = new System.Windows.Forms.Label();
            this.labelSomme = new System.Windows.Forms.Label();
            this.labelNbSolution = new System.Windows.Forms.Label();
            this.textBoxNbSolution = new System.Windows.Forms.TextBox();
            this.textBoxSomme = new System.Windows.Forms.RichTextBox();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.numericUpDownXi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXf = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYf = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYf)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOcean
            // 
            this.pictureBoxOcean.Location = new System.Drawing.Point(488, 52);
            this.pictureBoxOcean.Name = "pictureBoxOcean";
            this.pictureBoxOcean.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxOcean.TabIndex = 0;
            this.pictureBoxOcean.TabStop = false;
            // 
            // btnClic
            // 
            this.btnClic.AccessibleName = "";
            this.btnClic.Location = new System.Drawing.Point(87, 456);
            this.btnClic.Name = "btnClic";
            this.btnClic.Size = new System.Drawing.Size(94, 29);
            this.btnClic.TabIndex = 1;
            this.btnClic.Text = "Démarrer";
            this.btnClic.UseVisualStyleBackColor = true;
            this.btnClic.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInitCordinates
            // 
            this.lblInitCordinates.AutoSize = true;
            this.lblInitCordinates.Location = new System.Drawing.Point(30, 190);
            this.lblInitCordinates.Name = "lblInitCordinates";
            this.lblInitCordinates.Size = new System.Drawing.Size(163, 20);
            this.lblInitCordinates.TabIndex = 3;
            this.lblInitCordinates.Text = "Coordonnées initiales : ";
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(42, 225);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(29, 20);
            this.lblXi.TabIndex = 4;
            this.lblXi.Text = "Xi :";
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
            this.lblYi.Location = new System.Drawing.Point(42, 270);
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(28, 20);
            this.lblYi.TabIndex = 6;
            this.lblYi.Text = "Yi :";
            // 
            // lblEndCordinates
            // 
            this.lblEndCordinates.AutoSize = true;
            this.lblEndCordinates.Location = new System.Drawing.Point(30, 319);
            this.lblEndCordinates.Name = "lblEndCordinates";
            this.lblEndCordinates.Size = new System.Drawing.Size(151, 20);
            this.lblEndCordinates.TabIndex = 7;
            this.lblEndCordinates.Text = "Coordonnées finales :";
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(38, 351);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(30, 20);
            this.lblXf.TabIndex = 8;
            this.lblXf.Text = "Xf :";
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Location = new System.Drawing.Point(41, 386);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(29, 20);
            this.lblYf.TabIndex = 10;
            this.lblYf.Text = "Yf :";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(30, 102);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(100, 20);
            this.lblWind.TabIndex = 14;
            this.lblWind.Text = "Type de vent :";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(484, 358);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(303, 27);
            this.textBoxResult.TabIndex = 17;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(598, 456);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(185, 27);
            this.textBoxTime.TabIndex = 18;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(300, 458);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(282, 20);
            this.labelTime.TabIndex = 19;
            this.labelTime.Text = "Temps total de la navigation (en heures) :";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(87, 510);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 27);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Réinitialiser";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.Reset);
            // 
            // labelExplication
            // 
            this.labelExplication.AutoSize = true;
            this.labelExplication.Location = new System.Drawing.Point(30, 52);
            this.labelExplication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExplication.Name = "labelExplication";
            this.labelExplication.Size = new System.Drawing.Size(287, 20);
            this.labelExplication.TabIndex = 21;
            this.labelExplication.Text = "Veuillez sélectionner les valeurs suivantes :";
            // 
            // labelSomme
            // 
            this.labelSomme.AutoSize = true;
            this.labelSomme.Location = new System.Drawing.Point(250, 494);
            this.labelSomme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSomme.Name = "labelSomme";
            this.labelSomme.Size = new System.Drawing.Size(332, 20);
            this.labelSomme.TabIndex = 22;
            this.labelSomme.Text = "Somme des noeuds des listes Ouverts et Fermés :";
            // 
            // labelNbSolution
            // 
            this.labelNbSolution.AutoSize = true;
            this.labelNbSolution.Location = new System.Drawing.Point(365, 419);
            this.labelNbSolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNbSolution.Name = "labelNbSolution";
            this.labelNbSolution.Size = new System.Drawing.Size(217, 20);
            this.labelNbSolution.TabIndex = 24;
            this.labelNbSolution.Text = "Nombre de noeuds du chemin :";
            // 
            // textBoxNbSolution
            // 
            this.textBoxNbSolution.Location = new System.Drawing.Point(599, 417);
            this.textBoxNbSolution.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNbSolution.Name = "textBoxNbSolution";
            this.textBoxNbSolution.ReadOnly = true;
            this.textBoxNbSolution.Size = new System.Drawing.Size(185, 27);
            this.textBoxNbSolution.TabIndex = 25;
            // 
            // textBoxSomme
            // 
            this.textBoxSomme.Enabled = false;
            this.textBoxSomme.Location = new System.Drawing.Point(598, 493);
            this.textBoxSomme.Name = "textBoxSomme";
            this.textBoxSomme.Size = new System.Drawing.Size(185, 70);
            this.textBoxSomme.TabIndex = 26;
            this.textBoxSomme.Text = "";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(30, 140);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(38, 24);
            this.radioButtonA.TabIndex = 27;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "a";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(90, 140);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(39, 24);
            this.radioButtonB.TabIndex = 28;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "b";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(144, 140);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(37, 24);
            this.radioButtonC.TabIndex = 29;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "c";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // numericUpDownXi
            // 
            this.numericUpDownXi.Location = new System.Drawing.Point(77, 225);
            this.numericUpDownXi.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownXi.Name = "numericUpDownXi";
            this.numericUpDownXi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownXi.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownXi.TabIndex = 30;
            this.numericUpDownXi.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownXi.ValueChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // numericUpDownYi
            // 
            this.numericUpDownYi.Location = new System.Drawing.Point(77, 270);
            this.numericUpDownYi.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownYi.Name = "numericUpDownYi";
            this.numericUpDownYi.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownYi.TabIndex = 31;
            this.numericUpDownYi.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownYi.ValueChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // numericUpDownXf
            // 
            this.numericUpDownXf.Location = new System.Drawing.Point(74, 349);
            this.numericUpDownXf.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownXf.Name = "numericUpDownXf";
            this.numericUpDownXf.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownXf.TabIndex = 32;
            this.numericUpDownXf.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownXf.ValueChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // numericUpDownYf
            // 
            this.numericUpDownYf.Location = new System.Drawing.Point(74, 386);
            this.numericUpDownYf.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownYf.Name = "numericUpDownYf";
            this.numericUpDownYf.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownYf.TabIndex = 33;
            this.numericUpDownYf.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownYf.ValueChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 595);
            this.Controls.Add(this.numericUpDownYf);
            this.Controls.Add(this.numericUpDownXf);
            this.Controls.Add(this.numericUpDownYi);
            this.Controls.Add(this.numericUpDownXi);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.textBoxSomme);
            this.Controls.Add(this.textBoxNbSolution);
            this.Controls.Add(this.labelNbSolution);
            this.Controls.Add(this.labelSomme);
            this.Controls.Add(this.labelExplication);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblYf);
            this.Controls.Add(this.lblXf);
            this.Controls.Add(this.lblEndCordinates);
            this.Controls.Add(this.lblYi);
            this.Controls.Add(this.lblXi);
            this.Controls.Add(this.lblInitCordinates);
            this.Controls.Add(this.btnClic);
            this.Controls.Add(this.pictureBoxOcean);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Navigation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOcean;
        private System.Windows.Forms.Button btnClic;
        private System.Windows.Forms.Label lblInitCordinates;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.Label lblYi;
        private System.Windows.Forms.Label lblEndCordinates;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.Label lblYf;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelExplication;
        private System.Windows.Forms.Label labelSomme;
        private System.Windows.Forms.Label labelNbSolution;
        private System.Windows.Forms.TextBox textBoxNbSolution;
        private System.Windows.Forms.RichTextBox textBoxSomme;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.NumericUpDown numericUpDownXi;
        private System.Windows.Forms.NumericUpDown numericUpDownYi;
        private System.Windows.Forms.NumericUpDown numericUpDownXf;
        private System.Windows.Forms.NumericUpDown numericUDownYf;
        private System.Windows.Forms.NumericUpDown numericUpDownYf;
    }
}

