namespace Sales_Tax_and_Total
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
            this.amountOfPurchaseTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.stateTaxLabel = new System.Windows.Forms.Label();
            this.countyTaxLabel = new System.Windows.Forms.Label();
            this.totalSalesTaxLabel = new System.Windows.Forms.Label();
            this.totalOfSaleLabel = new System.Windows.Forms.Label();
            this.calculatedStateTaxLabel = new System.Windows.Forms.Label();
            this.calculatedCountyTaxLabel = new System.Windows.Forms.Label();
            this.calculatedTotalSalesTaxLabel = new System.Windows.Forms.Label();
            this.calculatedTotalOfSalesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amountOfPurchaseTextBox
            // 
            this.amountOfPurchaseTextBox.Location = new System.Drawing.Point(379, 83);
            this.amountOfPurchaseTextBox.Name = "amountOfPurchaseTextBox";
            this.amountOfPurchaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountOfPurchaseTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(102, 84);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(241, 16);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Enter the amount of the purchase: ";
            // 
            // stateTaxLabel
            // 
            this.stateTaxLabel.AutoSize = true;
            this.stateTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTaxLabel.Location = new System.Drawing.Point(226, 112);
            this.stateTaxLabel.Name = "stateTaxLabel";
            this.stateTaxLabel.Size = new System.Drawing.Size(117, 16);
            this.stateTaxLabel.TabIndex = 2;
            this.stateTaxLabel.Text = "The state tax is:";
            // 
            // countyTaxLabel
            // 
            this.countyTaxLabel.AutoSize = true;
            this.countyTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countyTaxLabel.Location = new System.Drawing.Point(215, 142);
            this.countyTaxLabel.Name = "countyTaxLabel";
            this.countyTaxLabel.Size = new System.Drawing.Size(128, 16);
            this.countyTaxLabel.TabIndex = 3;
            this.countyTaxLabel.Text = "The county tax is:";
            // 
            // totalSalesTaxLabel
            // 
            this.totalSalesTaxLabel.AutoSize = true;
            this.totalSalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesTaxLabel.Location = new System.Drawing.Point(188, 175);
            this.totalSalesTaxLabel.Name = "totalSalesTaxLabel";
            this.totalSalesTaxLabel.Size = new System.Drawing.Size(155, 16);
            this.totalSalesTaxLabel.TabIndex = 4;
            this.totalSalesTaxLabel.Text = "The total sales tax is:";
            // 
            // totalOfSaleLabel
            // 
            this.totalOfSaleLabel.AutoSize = true;
            this.totalOfSaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOfSaleLabel.Location = new System.Drawing.Point(178, 207);
            this.totalOfSaleLabel.Name = "totalOfSaleLabel";
            this.totalOfSaleLabel.Size = new System.Drawing.Size(165, 16);
            this.totalOfSaleLabel.TabIndex = 5;
            this.totalOfSaleLabel.Text = "The total of the sale is:";
            // 
            // calculatedStateTaxLabel
            // 
            this.calculatedStateTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedStateTaxLabel.Location = new System.Drawing.Point(379, 109);
            this.calculatedStateTaxLabel.Name = "calculatedStateTaxLabel";
            this.calculatedStateTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedStateTaxLabel.TabIndex = 6;
            this.calculatedStateTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedCountyTaxLabel
            // 
            this.calculatedCountyTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedCountyTaxLabel.Location = new System.Drawing.Point(379, 139);
            this.calculatedCountyTaxLabel.Name = "calculatedCountyTaxLabel";
            this.calculatedCountyTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedCountyTaxLabel.TabIndex = 7;
            this.calculatedCountyTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedTotalSalesTaxLabel
            // 
            this.calculatedTotalSalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedTotalSalesTaxLabel.Location = new System.Drawing.Point(379, 172);
            this.calculatedTotalSalesTaxLabel.Name = "calculatedTotalSalesTaxLabel";
            this.calculatedTotalSalesTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedTotalSalesTaxLabel.TabIndex = 8;
            this.calculatedTotalSalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedTotalOfSalesLabel
            // 
            this.calculatedTotalOfSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedTotalOfSalesLabel.Location = new System.Drawing.Point(379, 204);
            this.calculatedTotalOfSalesLabel.Name = "calculatedTotalOfSalesLabel";
            this.calculatedTotalOfSalesLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedTotalOfSalesLabel.TabIndex = 9;
            this.calculatedTotalOfSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(105, 263);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(247, 263);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(390, 263);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 329);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.calculatedTotalOfSalesLabel);
            this.Controls.Add(this.calculatedTotalSalesTaxLabel);
            this.Controls.Add(this.calculatedCountyTaxLabel);
            this.Controls.Add(this.calculatedStateTaxLabel);
            this.Controls.Add(this.totalOfSaleLabel);
            this.Controls.Add(this.totalSalesTaxLabel);
            this.Controls.Add(this.countyTaxLabel);
            this.Controls.Add(this.stateTaxLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.amountOfPurchaseTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountOfPurchaseTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label stateTaxLabel;
        private System.Windows.Forms.Label countyTaxLabel;
        private System.Windows.Forms.Label totalSalesTaxLabel;
        private System.Windows.Forms.Label totalOfSaleLabel;
        private System.Windows.Forms.Label calculatedStateTaxLabel;
        private System.Windows.Forms.Label calculatedCountyTaxLabel;
        private System.Windows.Forms.Label calculatedTotalSalesTaxLabel;
        private System.Windows.Forms.Label calculatedTotalOfSalesLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

