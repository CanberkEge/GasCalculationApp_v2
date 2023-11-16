namespace GasCalculationApp_v2
{
    partial class GasCalculatorForm
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
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.averageGasSpendTextBox = new System.Windows.Forms.TextBox();
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.resultLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.avgGasSpendLabel = new System.Windows.Forms.Label();
            this.timesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(283, 134);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 0;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(283, 181);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // averageGasSpendTextBox
            // 
            this.averageGasSpendTextBox.Location = new System.Drawing.Point(283, 223);
            this.averageGasSpendTextBox.Name = "averageGasSpendTextBox";
            this.averageGasSpendTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageGasSpendTextBox.TabIndex = 2;
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Location = new System.Drawing.Point(283, 296);
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.daysNumericUpDown.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Yellow;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultLabel.ForeColor = System.Drawing.Color.Red;
            this.resultLabel.Location = new System.Drawing.Point(583, 71);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(68, 16);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Sonuçlar";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(86, 37);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Hesapla";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click_1);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.distanceLabel.Location = new System.Drawing.Point(79, 138);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(58, 16);
            this.distanceLabel.TabIndex = 6;
            this.distanceLabel.Text = "Mesafe";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLabel.Location = new System.Drawing.Point(79, 185);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(120, 16);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Benzin litre fiyatı";
            // 
            // avgGasSpendLabel
            // 
            this.avgGasSpendLabel.AutoSize = true;
            this.avgGasSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.avgGasSpendLabel.Location = new System.Drawing.Point(79, 227);
            this.avgGasSpendLabel.Name = "avgGasSpendLabel";
            this.avgGasSpendLabel.Size = new System.Drawing.Size(171, 16);
            this.avgGasSpendLabel.TabIndex = 8;
            this.avgGasSpendLabel.Text = "100km\'de harcanan litre";
            // 
            // timesLabel
            // 
            this.timesLabel.AutoSize = true;
            this.timesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timesLabel.Location = new System.Drawing.Point(79, 296);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(198, 16);
            this.timesLabel.TabIndex = 9;
            this.timesLabel.Text = "Kaç günlük sonuç isteniyor?";
            // 
            // GasCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timesLabel);
            this.Controls.Add(this.avgGasSpendLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.daysNumericUpDown);
            this.Controls.Add(this.averageGasSpendTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.distanceTextBox);
            this.Name = "GasCalculatorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox averageGasSpendTextBox;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label avgGasSpendLabel;
        private System.Windows.Forms.Label timesLabel;
    }
}

