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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcean)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOcean
            // 
            this.pictureBoxOcean.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOcean.Image")));
            this.pictureBoxOcean.Location = new System.Drawing.Point(243, 28);
            this.pictureBoxOcean.Name = "pictureBoxOcean";
            this.pictureBoxOcean.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxOcean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOcean.TabIndex = 0;
            this.pictureBoxOcean.TabStop = false;
            // 
            // btnClic
            // 
            this.btnClic.AccessibleName = "";
            this.btnClic.Location = new System.Drawing.Point(58, 28);
            this.btnClic.Name = "btnClic";
            this.btnClic.Size = new System.Drawing.Size(94, 29);
            this.btnClic.TabIndex = 1;
            this.btnClic.Text = "Demarrer";
            this.btnClic.UseVisualStyleBackColor = true;
            this.btnClic.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxXi
            // 
            this.textBoxXi.Location = new System.Drawing.Point(62, 120);
            this.textBoxXi.Name = "textBoxXi";
            this.textBoxXi.Size = new System.Drawing.Size(125, 27);
            this.textBoxXi.TabIndex = 2;
            this.textBoxXi.Text = "3";
            // 
            // lblInitCordinates
            // 
            this.lblInitCordinates.AutoSize = true;
            this.lblInitCordinates.Location = new System.Drawing.Point(12, 87);
            this.lblInitCordinates.Name = "lblInitCordinates";
            this.lblInitCordinates.Size = new System.Drawing.Size(163, 20);
            this.lblInitCordinates.TabIndex = 3;
            this.lblInitCordinates.Text = "Coordonnées initiales : ";
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(23, 124);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(29, 20);
            this.lblXi.TabIndex = 4;
            this.lblXi.Text = "Xi :";
            // 
            // textBoxYi
            // 
            this.textBoxYi.Location = new System.Drawing.Point(62, 164);
            this.textBoxYi.Name = "textBoxYi";
            this.textBoxYi.Size = new System.Drawing.Size(125, 27);
            this.textBoxYi.TabIndex = 5;
            this.textBoxYi.Text = "3";
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
            this.lblYi.Location = new System.Drawing.Point(23, 168);
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(28, 20);
            this.lblYi.TabIndex = 6;
            this.lblYi.Text = "Yi :";
            // 
            // lblEndCordinates
            // 
            this.lblEndCordinates.AutoSize = true;
            this.lblEndCordinates.Location = new System.Drawing.Point(12, 215);
            this.lblEndCordinates.Name = "lblEndCordinates";
            this.lblEndCordinates.Size = new System.Drawing.Size(151, 20);
            this.lblEndCordinates.TabIndex = 7;
            this.lblEndCordinates.Text = "Coordonnées finales :";
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(21, 248);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(30, 20);
            this.lblXf.TabIndex = 8;
            this.lblXf.Text = "Xf :";
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Location = new System.Drawing.Point(23, 284);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(29, 20);
            this.lblYf.TabIndex = 10;
            this.lblYf.Text = "Yf :";
            // 
            // textBoxXf
            // 
            this.textBoxXf.Location = new System.Drawing.Point(58, 248);
            this.textBoxXf.Name = "textBoxXf";
            this.textBoxXf.Size = new System.Drawing.Size(125, 27);
            this.textBoxXf.TabIndex = 11;
            this.textBoxXf.Text = "210";
            // 
            // textBoxYf
            // 
            this.textBoxYf.Location = new System.Drawing.Point(58, 284);
            this.textBoxYf.Name = "textBoxYf";
            this.textBoxYf.Size = new System.Drawing.Size(125, 27);
            this.textBoxYf.TabIndex = 12;
            this.textBoxYf.Text = "210";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 358);
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
    }
}

