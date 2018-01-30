﻿namespace Card_Flip
{
    partial class cardFlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardFlip));
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showBackButton
            // 
            this.showBackButton.Location = new System.Drawing.Point(30, 209);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(115, 23);
            this.showBackButton.TabIndex = 0;
            this.showBackButton.Text = "Show the Card Back";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFaceButton
            // 
            this.showFaceButton.Location = new System.Drawing.Point(184, 209);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(112, 23);
            this.showFaceButton.TabIndex = 1;
            this.showFaceButton.Text = "Show the Card Face";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            // 
            // cardBackPictureBox
            // 
            this.cardBackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cardBackPictureBox.Image")));
            this.cardBackPictureBox.Location = new System.Drawing.Point(30, 44);
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.Size = new System.Drawing.Size(100, 140);
            this.cardBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBackPictureBox.TabIndex = 2;
            this.cardBackPictureBox.TabStop = false;
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cardFacePictureBox.Image")));
            this.cardFacePictureBox.Location = new System.Drawing.Point(184, 44);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(100, 140);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFacePictureBox.TabIndex = 3;
            this.cardFacePictureBox.TabStop = false;
            this.cardFacePictureBox.Visible = false;
            // 
            // cardFlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 273);
            this.Controls.Add(this.cardFacePictureBox);
            this.Controls.Add(this.cardBackPictureBox);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Name = "cardFlip";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
        private System.Windows.Forms.PictureBox cardBackPictureBox;
        private System.Windows.Forms.PictureBox cardFacePictureBox;
    }
}

