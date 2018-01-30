namespace Latin_Translator
{
    partial class latinTranslator
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
            this.latinSinisterButton = new System.Windows.Forms.Button();
            this.latinDexterButton = new System.Windows.Forms.Button();
            this.latinMediumButton = new System.Windows.Forms.Button();
            this.translateInstructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // latinSinisterButton
            // 
            this.latinSinisterButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.latinSinisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latinSinisterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.latinSinisterButton.Location = new System.Drawing.Point(62, 83);
            this.latinSinisterButton.Name = "latinSinisterButton";
            this.latinSinisterButton.Size = new System.Drawing.Size(75, 23);
            this.latinSinisterButton.TabIndex = 0;
            this.latinSinisterButton.Text = "Sinister";
            this.latinSinisterButton.UseVisualStyleBackColor = false;
            this.latinSinisterButton.Click += new System.EventHandler(this.latinSinisterButton_Click);
            // 
            // latinDexterButton
            // 
            this.latinDexterButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.latinDexterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latinDexterButton.Location = new System.Drawing.Point(176, 83);
            this.latinDexterButton.Name = "latinDexterButton";
            this.latinDexterButton.Size = new System.Drawing.Size(75, 23);
            this.latinDexterButton.TabIndex = 1;
            this.latinDexterButton.Text = "Dexter";
            this.latinDexterButton.UseVisualStyleBackColor = false;
            this.latinDexterButton.Click += new System.EventHandler(this.latinDexterButton_Click);
            // 
            // latinMediumButton
            // 
            this.latinMediumButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.latinMediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latinMediumButton.Location = new System.Drawing.Point(291, 83);
            this.latinMediumButton.Name = "latinMediumButton";
            this.latinMediumButton.Size = new System.Drawing.Size(75, 23);
            this.latinMediumButton.TabIndex = 2;
            this.latinMediumButton.Text = "Medium";
            this.latinMediumButton.UseVisualStyleBackColor = false;
            this.latinMediumButton.Click += new System.EventHandler(this.latinMediumButton_Click);
            // 
            // translateInstructionLabel
            // 
            this.translateInstructionLabel.AutoSize = true;
            this.translateInstructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translateInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateInstructionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.translateInstructionLabel.Location = new System.Drawing.Point(34, 31);
            this.translateInstructionLabel.Name = "translateInstructionLabel";
            this.translateInstructionLabel.Size = new System.Drawing.Size(373, 22);
            this.translateInstructionLabel.TabIndex = 3;
            this.translateInstructionLabel.Text = "Click Buttons to Translate Words into English";
            this.translateInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latinTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(441, 146);
            this.Controls.Add(this.translateInstructionLabel);
            this.Controls.Add(this.latinMediumButton);
            this.Controls.Add(this.latinDexterButton);
            this.Controls.Add(this.latinSinisterButton);
            this.Name = "latinTranslator";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button latinSinisterButton;
        private System.Windows.Forms.Button latinDexterButton;
        private System.Windows.Forms.Button latinMediumButton;
        private System.Windows.Forms.Label translateInstructionLabel;
    }
}

