namespace BMI_Calculator
{
    partial class BMICalculator
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
            this.calcButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.heightInchesBox = new System.Windows.Forms.TextBox();
            this.heightFeetBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightLBSLabel = new System.Windows.Forms.Label();
            this.heightFeetLabel = new System.Windows.Forms.Label();
            this.heightInchesLabel = new System.Windows.Forms.Label();
            this.yourBMILabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calcButton.Location = new System.Drawing.Point(19, 228);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(118, 62);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resetButton.Location = new System.Drawing.Point(363, 229);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(118, 61);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // weightBox
            // 
            this.weightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.weightBox.Location = new System.Drawing.Point(84, 157);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 26);
            this.weightBox.TabIndex = 2;
            // 
            // heightInchesBox
            // 
            this.heightInchesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.heightInchesBox.Location = new System.Drawing.Point(215, 86);
            this.heightInchesBox.Name = "heightInchesBox";
            this.heightInchesBox.Size = new System.Drawing.Size(100, 26);
            this.heightInchesBox.TabIndex = 3;
            // 
            // heightFeetBox
            // 
            this.heightFeetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.heightFeetBox.Location = new System.Drawing.Point(84, 86);
            this.heightFeetBox.Name = "heightFeetBox";
            this.heightFeetBox.Size = new System.Drawing.Size(100, 26);
            this.heightFeetBox.TabIndex = 4;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(485, 39);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Welcome to the BMI Calculator";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.instructionsLabel.Location = new System.Drawing.Point(15, 48);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(384, 20);
            this.instructionsLabel.TabIndex = 6;
            this.instructionsLabel.Text = "Please fill in the information to calculate your BMI:\r\n";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.heightLabel.Location = new System.Drawing.Point(15, 89);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(63, 20);
            this.heightLabel.TabIndex = 7;
            this.heightLabel.Text = "Height:";
            this.heightLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.weightLabel.Location = new System.Drawing.Point(15, 160);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(66, 20);
            this.weightLabel.TabIndex = 8;
            this.weightLabel.Text = "Weight:";
            // 
            // weightLBSLabel
            // 
            this.weightLBSLabel.AutoSize = true;
            this.weightLBSLabel.Location = new System.Drawing.Point(115, 186);
            this.weightLBSLabel.Name = "weightLBSLabel";
            this.weightLBSLabel.Size = new System.Drawing.Size(36, 17);
            this.weightLBSLabel.TabIndex = 9;
            this.weightLBSLabel.Text = "(lbs)";
            // 
            // heightFeetLabel
            // 
            this.heightFeetLabel.AutoSize = true;
            this.heightFeetLabel.Location = new System.Drawing.Point(115, 115);
            this.heightFeetLabel.Name = "heightFeetLabel";
            this.heightFeetLabel.Size = new System.Drawing.Size(42, 17);
            this.heightFeetLabel.TabIndex = 10;
            this.heightFeetLabel.Text = "(feet)";
            // 
            // heightInchesLabel
            // 
            this.heightInchesLabel.AutoSize = true;
            this.heightInchesLabel.Location = new System.Drawing.Point(235, 115);
            this.heightInchesLabel.Name = "heightInchesLabel";
            this.heightInchesLabel.Size = new System.Drawing.Size(59, 17);
            this.heightInchesLabel.TabIndex = 11;
            this.heightInchesLabel.Text = "(inches)";
            // 
            // yourBMILabel
            // 
            this.yourBMILabel.AutoSize = true;
            this.yourBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.yourBMILabel.Location = new System.Drawing.Point(143, 239);
            this.yourBMILabel.Name = "yourBMILabel";
            this.yourBMILabel.Size = new System.Drawing.Size(134, 31);
            this.yourBMILabel.TabIndex = 12;
            this.yourBMILabel.Text = "Your BMI:";
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bmiLabel.Location = new System.Drawing.Point(275, 239);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(52, 31);
            this.bmiLabel.TabIndex = 13;
            this.bmiLabel.Text = "0.0";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 316);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.yourBMILabel);
            this.Controls.Add(this.heightInchesLabel);
            this.Controls.Add(this.heightFeetLabel);
            this.Controls.Add(this.weightLBSLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.heightFeetBox);
            this.Controls.Add(this.heightInchesBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calcButton);
            this.Name = "BMICalculator";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightInchesBox;
        private System.Windows.Forms.TextBox heightFeetBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label weightLBSLabel;
        private System.Windows.Forms.Label heightFeetLabel;
        private System.Windows.Forms.Label heightInchesLabel;
        private System.Windows.Forms.Label yourBMILabel;
        private System.Windows.Forms.Label bmiLabel;
    }
}

