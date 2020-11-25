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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcean)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOcean
            // 
            this.pictureBoxOcean.Location = new System.Drawing.Point(304, 35);
            this.pictureBoxOcean.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxOcean.Name = "pictureBoxOcean";
            this.pictureBoxOcean.Size = new System.Drawing.Size(375, 375);
            this.pictureBoxOcean.TabIndex = 0;
            this.pictureBoxOcean.TabStop = false;
            // 
            // btnClic
            // 
            this.btnClic.AccessibleName = "";
            this.btnClic.Location = new System.Drawing.Point(15, 15);
            this.btnClic.Margin = new System.Windows.Forms.Padding(4);
            this.btnClic.Name = "btnClic";
            this.btnClic.Size = new System.Drawing.Size(118, 36);
            this.btnClic.TabIndex = 1;
            this.btnClic.Text = "Demarrer";
            this.btnClic.UseVisualStyleBackColor = true;
            this.btnClic.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxXi
            // 
            this.textBoxXi.Location = new System.Drawing.Point(72, 200);
            this.textBoxXi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXi.Name = "textBoxXi";
            this.textBoxXi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxXi.Size = new System.Drawing.Size(162, 31);
            this.textBoxXi.TabIndex = 2;
            this.textBoxXi.Text = "100";
            this.textBoxXi.TextChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // lblInitCordinates
            // 
            this.lblInitCordinates.AutoSize = true;
            this.lblInitCordinates.Location = new System.Drawing.Point(15, 158);
            this.lblInitCordinates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitCordinates.Name = "lblInitCordinates";
            this.lblInitCordinates.Size = new System.Drawing.Size(196, 25);
            this.lblInitCordinates.TabIndex = 3;
            this.lblInitCordinates.Text = "Coordonnées initiales : ";
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(29, 202);
            this.lblXi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(36, 25);
            this.lblXi.TabIndex = 4;
            this.lblXi.Text = "Xi :";
            // 
            // textBoxYi
            // 
            this.textBoxYi.Location = new System.Drawing.Point(72, 258);
            this.textBoxYi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYi.Name = "textBoxYi";
            this.textBoxYi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxYi.Size = new System.Drawing.Size(162, 31);
            this.textBoxYi.TabIndex = 5;
            this.textBoxYi.Text = "200";
            this.textBoxYi.TextChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
            this.lblYi.Location = new System.Drawing.Point(29, 258);
            this.lblYi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(35, 25);
            this.lblYi.TabIndex = 6;
            this.lblYi.Text = "Yi :";
            // 
            // lblEndCordinates
            // 
            this.lblEndCordinates.AutoSize = true;
            this.lblEndCordinates.Location = new System.Drawing.Point(15, 318);
            this.lblEndCordinates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndCordinates.Name = "lblEndCordinates";
            this.lblEndCordinates.Size = new System.Drawing.Size(183, 25);
            this.lblEndCordinates.TabIndex = 7;
            this.lblEndCordinates.Text = "Coordonnées finales :";
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(26, 358);
            this.lblXf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(38, 25);
            this.lblXf.TabIndex = 8;
            this.lblXf.Text = "Xf :";
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Location = new System.Drawing.Point(29, 402);
            this.lblYf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(37, 25);
            this.lblYf.TabIndex = 10;
            this.lblYf.Text = "Yf :";
            // 
            // textBoxXf
            // 
            this.textBoxXf.Location = new System.Drawing.Point(72, 358);
            this.textBoxXf.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXf.Name = "textBoxXf";
            this.textBoxXf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxXf.Size = new System.Drawing.Size(162, 31);
            this.textBoxXf.TabIndex = 11;
            this.textBoxXf.Text = "200";
            this.textBoxXf.TextChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // textBoxYf
            // 
            this.textBoxYf.Location = new System.Drawing.Point(72, 402);
            this.textBoxYf.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYf.Name = "textBoxYf";
            this.textBoxYf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxYf.Size = new System.Drawing.Size(162, 31);
            this.textBoxYf.TabIndex = 12;
            this.textBoxYf.Text = "100";
            this.textBoxYf.TextChanged += new System.EventHandler(this.NewCoordinate);
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(16, 75);
            this.lblWind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(122, 25);
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
            this.cmbBxWind.Location = new System.Drawing.Point(72, 108);
            this.cmbBxWind.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxWind.Name = "cmbBxWind";
            this.cmbBxWind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBxWind.Size = new System.Drawing.Size(162, 33);
            this.cmbBxWind.TabIndex = 15;
            this.cmbBxWind.Text = "a";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 476);
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
            this.textBoxResult.Location = new System.Drawing.Point(304, 418);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(378, 31);
            this.textBoxResult.TabIndex = 17;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(452, 456);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(230, 31);
            this.textBoxTime.TabIndex = 18;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(304, 459);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(142, 25);
            this.labelTime.TabIndex = 19;
            this.labelTime.Text = "Temps de trajet :";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(153, 17);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 34);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Réinitialiser";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.Reset);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonReset;
    }
}

