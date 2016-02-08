namespace Holography
{
    partial class windowsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileName = new System.Windows.Forms.TextBox();
            this.SelectionImage = new System.Windows.Forms.Button();
            this.SafeFileName = new System.Windows.Forms.TextBox();
            this.LabelTailleEcran = new System.Windows.Forms.Label();
            this.textBoxTailleEcran = new System.Windows.Forms.TextBox();
            this.BouttonDemarrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(142, 60);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(191, 20);
            this.FileName.TabIndex = 0;
            // 
            // SelectionImage
            // 
            this.SelectionImage.Location = new System.Drawing.Point(33, 49);
            this.SelectionImage.Name = "SelectionImage";
            this.SelectionImage.Size = new System.Drawing.Size(103, 41);
            this.SelectionImage.TabIndex = 1;
            this.SelectionImage.Text = "Selectionner une image";
            this.SelectionImage.UseVisualStyleBackColor = true;
            this.SelectionImage.Click += new System.EventHandler(this.SelectionImage_Click);
            // 
            // SafeFileName
            // 
            this.SafeFileName.Location = new System.Drawing.Point(33, 96);
            this.SafeFileName.Name = "SafeFileName";
            this.SafeFileName.Size = new System.Drawing.Size(300, 20);
            this.SafeFileName.TabIndex = 2;
            // 
            // LabelTailleEcran
            // 
            this.LabelTailleEcran.AutoSize = true;
            this.LabelTailleEcran.Location = new System.Drawing.Point(33, 188);
            this.LabelTailleEcran.Name = "LabelTailleEcran";
            this.LabelTailleEcran.Size = new System.Drawing.Size(146, 13);
            this.LabelTailleEcran.TabIndex = 3;
            this.LabelTailleEcran.Text = "Longueur de l\'ecran (carre) :  ";
            // 
            // textBoxTailleEcran
            // 
            this.textBoxTailleEcran.Location = new System.Drawing.Point(221, 186);
            this.textBoxTailleEcran.Name = "textBoxTailleEcran";
            this.textBoxTailleEcran.Size = new System.Drawing.Size(66, 20);
            this.textBoxTailleEcran.TabIndex = 4;
            // 
            // BouttonDemarrer
            // 
            this.BouttonDemarrer.Location = new System.Drawing.Point(168, 245);
            this.BouttonDemarrer.Name = "BouttonDemarrer";
            this.BouttonDemarrer.Size = new System.Drawing.Size(165, 30);
            this.BouttonDemarrer.TabIndex = 5;
            this.BouttonDemarrer.Text = "Demarrer !";
            this.BouttonDemarrer.UseVisualStyleBackColor = true;
            this.BouttonDemarrer.Click += new System.EventHandler(this.BouttonDemarrer_Click);
            // 
            // windowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 323);
            this.Controls.Add(this.BouttonDemarrer);
            this.Controls.Add(this.textBoxTailleEcran);
            this.Controls.Add(this.LabelTailleEcran);
            this.Controls.Add(this.SafeFileName);
            this.Controls.Add(this.SelectionImage);
            this.Controls.Add(this.FileName);
            this.Name = "windowsForm";
            this.Text = "windowsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button SelectionImage;
        private System.Windows.Forms.TextBox SafeFileName;
        private System.Windows.Forms.Label LabelTailleEcran;
        private System.Windows.Forms.TextBox textBoxTailleEcran;
        private System.Windows.Forms.Button BouttonDemarrer;
    }
}