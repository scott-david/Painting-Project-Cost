namespace Program_1
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
            this.wallSpaceTextBox = new System.Windows.Forms.TextBox();
            this.coatsOfPaintTextBox = new System.Windows.Forms.TextBox();
            this.priceOfPaintTextBox = new System.Windows.Forms.TextBox();
            this.wallSpaceLabel = new System.Windows.Forms.Label();
            this.desiredCoatsLabel = new System.Windows.Forms.Label();
            this.priceOfPaintLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalToBePaintedLabel = new System.Windows.Forms.Label();
            this.outputTotalToBePaintedLabel = new System.Windows.Forms.Label();
            this.gallonsOfPaintRequired = new System.Windows.Forms.Label();
            this.outputGallonsRequiredLabel = new System.Windows.Forms.Label();
            this.hoursOfLaborLabel = new System.Windows.Forms.Label();
            this.outputHoursOfLaborLabel = new System.Windows.Forms.Label();
            this.costOfPaintLabel = new System.Windows.Forms.Label();
            this.outputCostOfPaintLabel = new System.Windows.Forms.Label();
            this.costOfLaborLabel = new System.Windows.Forms.Label();
            this.outputCostOfLaborLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.outputTotalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wallSpaceTextBox
            // 
            this.wallSpaceTextBox.Location = new System.Drawing.Point(235, 20);
            this.wallSpaceTextBox.Name = "wallSpaceTextBox";
            this.wallSpaceTextBox.Size = new System.Drawing.Size(100, 22);
            this.wallSpaceTextBox.TabIndex = 0;
            // 
            // coatsOfPaintTextBox
            // 
            this.coatsOfPaintTextBox.Location = new System.Drawing.Point(235, 56);
            this.coatsOfPaintTextBox.Name = "coatsOfPaintTextBox";
            this.coatsOfPaintTextBox.Size = new System.Drawing.Size(100, 22);
            this.coatsOfPaintTextBox.TabIndex = 1;
            // 
            // priceOfPaintTextBox
            // 
            this.priceOfPaintTextBox.Location = new System.Drawing.Point(235, 90);
            this.priceOfPaintTextBox.Name = "priceOfPaintTextBox";
            this.priceOfPaintTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceOfPaintTextBox.TabIndex = 2;
            // 
            // wallSpaceLabel
            // 
            this.wallSpaceLabel.AutoSize = true;
            this.wallSpaceLabel.Location = new System.Drawing.Point(12, 20);
            this.wallSpaceLabel.Name = "wallSpaceLabel";
            this.wallSpaceLabel.Size = new System.Drawing.Size(187, 17);
            this.wallSpaceLabel.TabIndex = 3;
            this.wallSpaceLabel.Text = "Enter total wall space (sq ft):";
            // 
            // desiredCoatsLabel
            // 
            this.desiredCoatsLabel.AutoSize = true;
            this.desiredCoatsLabel.Location = new System.Drawing.Point(13, 56);
            this.desiredCoatsLabel.Name = "desiredCoatsLabel";
            this.desiredCoatsLabel.Size = new System.Drawing.Size(186, 17);
            this.desiredCoatsLabel.TabIndex = 4;
            this.desiredCoatsLabel.Text = "Enter coats of paint desired:";
            // 
            // priceOfPaintLabel
            // 
            this.priceOfPaintLabel.AutoSize = true;
            this.priceOfPaintLabel.Location = new System.Drawing.Point(12, 90);
            this.priceOfPaintLabel.Name = "priceOfPaintLabel";
            this.priceOfPaintLabel.Size = new System.Drawing.Size(222, 17);
            this.priceOfPaintLabel.TabIndex = 5;
            this.priceOfPaintLabel.Text = "Price of the paint per gallon:       $";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate Cost:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(452, 271);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 32);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(577, 271);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 32);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalToBePaintedLabel
            // 
            this.totalToBePaintedLabel.AutoSize = true;
            this.totalToBePaintedLabel.Location = new System.Drawing.Point(416, 25);
            this.totalToBePaintedLabel.Name = "totalToBePaintedLabel";
            this.totalToBePaintedLabel.Size = new System.Drawing.Size(172, 17);
            this.totalToBePaintedLabel.TabIndex = 9;
            this.totalToBePaintedLabel.Text = "Total to be painted (sq ft):";
            // 
            // outputTotalToBePaintedLabel
            // 
            this.outputTotalToBePaintedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTotalToBePaintedLabel.Location = new System.Drawing.Point(596, 22);
            this.outputTotalToBePaintedLabel.Name = "outputTotalToBePaintedLabel";
            this.outputTotalToBePaintedLabel.Size = new System.Drawing.Size(100, 23);
            this.outputTotalToBePaintedLabel.TabIndex = 10;
            this.outputTotalToBePaintedLabel.Text = "0";
            this.outputTotalToBePaintedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonsOfPaintRequired
            // 
            this.gallonsOfPaintRequired.AutoSize = true;
            this.gallonsOfPaintRequired.Location = new System.Drawing.Point(416, 61);
            this.gallonsOfPaintRequired.Name = "gallonsOfPaintRequired";
            this.gallonsOfPaintRequired.Size = new System.Drawing.Size(168, 17);
            this.gallonsOfPaintRequired.TabIndex = 11;
            this.gallonsOfPaintRequired.Text = "Gallons of paint required:";
            // 
            // outputGallonsRequiredLabel
            // 
            this.outputGallonsRequiredLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputGallonsRequiredLabel.Location = new System.Drawing.Point(596, 58);
            this.outputGallonsRequiredLabel.Name = "outputGallonsRequiredLabel";
            this.outputGallonsRequiredLabel.Size = new System.Drawing.Size(100, 23);
            this.outputGallonsRequiredLabel.TabIndex = 12;
            this.outputGallonsRequiredLabel.Text = "0";
            this.outputGallonsRequiredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursOfLaborLabel
            // 
            this.hoursOfLaborLabel.AutoSize = true;
            this.hoursOfLaborLabel.Location = new System.Drawing.Point(428, 95);
            this.hoursOfLaborLabel.Name = "hoursOfLaborLabel";
            this.hoursOfLaborLabel.Size = new System.Drawing.Size(156, 17);
            this.hoursOfLaborLabel.TabIndex = 13;
            this.hoursOfLaborLabel.Text = "Labor required (hours):";
            // 
            // outputHoursOfLaborLabel
            // 
            this.outputHoursOfLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputHoursOfLaborLabel.Location = new System.Drawing.Point(596, 95);
            this.outputHoursOfLaborLabel.Name = "outputHoursOfLaborLabel";
            this.outputHoursOfLaborLabel.Size = new System.Drawing.Size(100, 23);
            this.outputHoursOfLaborLabel.TabIndex = 14;
            this.outputHoursOfLaborLabel.Text = "0";
            this.outputHoursOfLaborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costOfPaintLabel
            // 
            this.costOfPaintLabel.AutoSize = true;
            this.costOfPaintLabel.Location = new System.Drawing.Point(492, 131);
            this.costOfPaintLabel.Name = "costOfPaintLabel";
            this.costOfPaintLabel.Size = new System.Drawing.Size(92, 17);
            this.costOfPaintLabel.TabIndex = 15;
            this.costOfPaintLabel.Text = "Cost of Paint:";
            // 
            // outputCostOfPaintLabel
            // 
            this.outputCostOfPaintLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputCostOfPaintLabel.Location = new System.Drawing.Point(596, 128);
            this.outputCostOfPaintLabel.Name = "outputCostOfPaintLabel";
            this.outputCostOfPaintLabel.Size = new System.Drawing.Size(100, 23);
            this.outputCostOfPaintLabel.TabIndex = 16;
            this.outputCostOfPaintLabel.Text = "$0.00";
            this.outputCostOfPaintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputCostOfPaintLabel.Click += new System.EventHandler(this.outputCostOfPaintLabel_Click);
            // 
            // costOfLaborLabel
            // 
            this.costOfLaborLabel.AutoSize = true;
            this.costOfLaborLabel.Location = new System.Drawing.Point(487, 164);
            this.costOfLaborLabel.Name = "costOfLaborLabel";
            this.costOfLaborLabel.Size = new System.Drawing.Size(97, 17);
            this.costOfLaborLabel.TabIndex = 17;
            this.costOfLaborLabel.Text = "Cost of Labor:";
            // 
            // outputCostOfLaborLabel
            // 
            this.outputCostOfLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputCostOfLaborLabel.Location = new System.Drawing.Point(596, 161);
            this.outputCostOfLaborLabel.Name = "outputCostOfLaborLabel";
            this.outputCostOfLaborLabel.Size = new System.Drawing.Size(100, 23);
            this.outputCostOfLaborLabel.TabIndex = 18;
            this.outputCostOfLaborLabel.Text = "$0.00";
            this.outputCostOfLaborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(31, 219);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(102, 20);
            this.totalCostLabel.TabIndex = 19;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // outputTotalCostLabel
            // 
            this.outputTotalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTotalCostLabel.Location = new System.Drawing.Point(149, 219);
            this.outputTotalCostLabel.Name = "outputTotalCostLabel";
            this.outputTotalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.outputTotalCostLabel.TabIndex = 20;
            this.outputTotalCostLabel.Text = "$0.00";
            this.outputTotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 315);
            this.Controls.Add(this.outputTotalCostLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.outputCostOfLaborLabel);
            this.Controls.Add(this.costOfLaborLabel);
            this.Controls.Add(this.outputCostOfPaintLabel);
            this.Controls.Add(this.costOfPaintLabel);
            this.Controls.Add(this.outputHoursOfLaborLabel);
            this.Controls.Add(this.hoursOfLaborLabel);
            this.Controls.Add(this.outputGallonsRequiredLabel);
            this.Controls.Add(this.gallonsOfPaintRequired);
            this.Controls.Add(this.outputTotalToBePaintedLabel);
            this.Controls.Add(this.totalToBePaintedLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceOfPaintLabel);
            this.Controls.Add(this.desiredCoatsLabel);
            this.Controls.Add(this.wallSpaceLabel);
            this.Controls.Add(this.priceOfPaintTextBox);
            this.Controls.Add(this.coatsOfPaintTextBox);
            this.Controls.Add(this.wallSpaceTextBox);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wallSpaceTextBox;
        private System.Windows.Forms.TextBox coatsOfPaintTextBox;
        private System.Windows.Forms.TextBox priceOfPaintTextBox;
        private System.Windows.Forms.Label wallSpaceLabel;
        private System.Windows.Forms.Label desiredCoatsLabel;
        private System.Windows.Forms.Label priceOfPaintLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalToBePaintedLabel;
        private System.Windows.Forms.Label outputTotalToBePaintedLabel;
        private System.Windows.Forms.Label gallonsOfPaintRequired;
        private System.Windows.Forms.Label outputGallonsRequiredLabel;
        private System.Windows.Forms.Label hoursOfLaborLabel;
        private System.Windows.Forms.Label outputHoursOfLaborLabel;
        private System.Windows.Forms.Label costOfPaintLabel;
        private System.Windows.Forms.Label outputCostOfPaintLabel;
        private System.Windows.Forms.Label costOfLaborLabel;
        private System.Windows.Forms.Label outputCostOfLaborLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label outputTotalCostLabel;
    }
}

