namespace Flags
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instructionLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.finlandPictureBox = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.germanPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(162, 45);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(206, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Click a flag to see the name of the country";
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(165, 180);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(203, 27);
            this.countryLabel.TabIndex = 1;
            this.countryLabel.Text = "\" \"";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finlandPictureBox
            // 
            this.finlandPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finlandPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("finlandPictureBox.Image")));
            this.finlandPictureBox.Location = new System.Drawing.Point(67, 76);
            this.finlandPictureBox.Name = "finlandPictureBox";
            this.finlandPictureBox.Size = new System.Drawing.Size(122, 72);
            this.finlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.finlandPictureBox.TabIndex = 2;
            this.finlandPictureBox.TabStop = false;
            this.finlandPictureBox.Click += new System.EventHandler(this.finlandPictureBox_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.francePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("francePictureBox.Image")));
            this.francePictureBox.Location = new System.Drawing.Point(216, 76);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(122, 72);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.francePictureBox.TabIndex = 3;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // germanPictureBox
            // 
            this.germanPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("germanPictureBox.Image")));
            this.germanPictureBox.Location = new System.Drawing.Point(359, 76);
            this.germanPictureBox.Name = "germanPictureBox";
            this.germanPictureBox.Size = new System.Drawing.Size(122, 72);
            this.germanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.germanPictureBox.TabIndex = 4;
            this.germanPictureBox.TabStop = false;
            this.germanPictureBox.Click += new System.EventHandler(this.germanPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 240);
            this.Controls.Add(this.germanPictureBox);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.finlandPictureBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.PictureBox finlandPictureBox;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.PictureBox germanPictureBox;
    }
}

