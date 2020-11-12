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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label label1;
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
            this.textBoxVent = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcean)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOcean
            // 
            this.pictureBoxOcean.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOcean.Image")));
            this.pictureBoxOcean.Location = new System.Drawing.Point(304, 35);
            this.pictureBoxOcean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxOcean.Name = "pictureBoxOcean";
            this.pictureBoxOcean.Size = new System.Drawing.Size(375, 375);
            this.pictureBoxOcean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOcean.TabIndex = 0;
            this.pictureBoxOcean.TabStop = false;
            // 
            // btnClic
            // 
            this.btnClic.AccessibleName = "";
            this.btnClic.Location = new System.Drawing.Point(72, 25);
            this.btnClic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.textBoxXi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxXi.Name = "textBoxXi";
            this.textBoxXi.Size = new System.Drawing.Size(161, 31);
            this.textBoxXi.TabIndex = 2;
            this.textBoxXi.Text = "3";
            // 
            // lblInitCordinates
            // 
            this.lblInitCordinates.AutoSize = true;
            this.lblInitCordinates.Location = new System.Drawing.Point(15, 157);
            this.lblInitCordinates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitCordinates.Name = "lblInitCordinates";
            this.lblInitCordinates.Size = new System.Drawing.Size(196, 25);
            this.lblInitCordinates.TabIndex = 3;
            this.lblInitCordinates.Text = "Coordonnées initiales : ";
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(29, 203);
            this.lblXi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(36, 25);
            this.lblXi.TabIndex = 4;
            this.lblXi.Text = "Xi :";
            // 
            // textBoxYi
            // 
            this.textBoxYi.Location = new System.Drawing.Point(72, 258);
            this.textBoxYi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxYi.Name = "textBoxYi";
            this.textBoxYi.Size = new System.Drawing.Size(161, 31);
            this.textBoxYi.TabIndex = 5;
            this.textBoxYi.Text = "3";
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
            this.lblEndCordinates.Location = new System.Drawing.Point(15, 317);
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
            this.lblYf.Location = new System.Drawing.Point(29, 403);
            this.lblYf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(37, 25);
            this.lblYf.TabIndex = 10;
            this.lblYf.Text = "Yf :";
            // 
            // textBoxXf
            // 
            this.textBoxXf.Location = new System.Drawing.Point(72, 358);
            this.textBoxXf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxXf.Name = "textBoxXf";
            this.textBoxXf.Size = new System.Drawing.Size(161, 31);
            this.textBoxXf.TabIndex = 11;
            this.textBoxXf.Text = "210";
            // 
            // textBoxYf
            // 
            this.textBoxYf.Location = new System.Drawing.Point(72, 403);
            this.textBoxYf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxYf.Name = "textBoxYf";
            this.textBoxYf.Size = new System.Drawing.Size(161, 31);
            this.textBoxYf.TabIndex = 12;
            this.textBoxYf.Text = "210";
            // 
            // textBoxVent
            // 
            this.textBoxVent.Location = new System.Drawing.Point(72, 113);
            this.textBoxVent.Name = "textBoxVent";
            this.textBoxVent.Size = new System.Drawing.Size(161, 31);
            this.textBoxVent.TabIndex = 13;
            this.textBoxVent.Text = "a";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 25);
            label1.TabIndex = 14;
            label1.Text = "Type de vent :";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 448);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBoxVent);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBoxVent;
        private System.Windows.Forms.Label label1;
    }
}

