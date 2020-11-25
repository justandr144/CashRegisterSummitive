namespace CashRegisterSummitive
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
            this.burgerAmountLabel = new System.Windows.Forms.Label();
            this.drinkAmountLabel = new System.Windows.Forms.Label();
            this.friesAmountLabel = new System.Windows.Forms.Label();
            this.burgerText = new System.Windows.Forms.TextBox();
            this.drinkText = new System.Windows.Forms.TextBox();
            this.friesText = new System.Windows.Forms.TextBox();
            this.costButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.tenderedValueLabel = new System.Windows.Forms.Label();
            this.changeValueLabel = new System.Windows.Forms.Label();
            this.receiptBackLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.leftreceiptLabel = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.TextBox();
            this.rightreceiptLabel = new System.Windows.Forms.Label();
            this.subTotalCostLabel = new System.Windows.Forms.Label();
            this.taxCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerAmountLabel
            // 
            this.burgerAmountLabel.AutoSize = true;
            this.burgerAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerAmountLabel.Location = new System.Drawing.Point(9, 9);
            this.burgerAmountLabel.Name = "burgerAmountLabel";
            this.burgerAmountLabel.Size = new System.Drawing.Size(123, 16);
            this.burgerAmountLabel.TabIndex = 0;
            this.burgerAmountLabel.Text = "Number of Burgers:";
            // 
            // drinkAmountLabel
            // 
            this.drinkAmountLabel.AutoSize = true;
            this.drinkAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkAmountLabel.Location = new System.Drawing.Point(9, 48);
            this.drinkAmountLabel.Name = "drinkAmountLabel";
            this.drinkAmountLabel.Size = new System.Drawing.Size(114, 16);
            this.drinkAmountLabel.TabIndex = 1;
            this.drinkAmountLabel.Text = "Number of Drinks:";
            // 
            // friesAmountLabel
            // 
            this.friesAmountLabel.AutoSize = true;
            this.friesAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesAmountLabel.Location = new System.Drawing.Point(9, 86);
            this.friesAmountLabel.Name = "friesAmountLabel";
            this.friesAmountLabel.Size = new System.Drawing.Size(106, 16);
            this.friesAmountLabel.TabIndex = 2;
            this.friesAmountLabel.Text = "Number of Fries:";
            // 
            // burgerText
            // 
            this.burgerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerText.Location = new System.Drawing.Point(138, 6);
            this.burgerText.Name = "burgerText";
            this.burgerText.Size = new System.Drawing.Size(84, 22);
            this.burgerText.TabIndex = 3;
            // 
            // drinkText
            // 
            this.drinkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkText.Location = new System.Drawing.Point(138, 45);
            this.drinkText.Name = "drinkText";
            this.drinkText.Size = new System.Drawing.Size(84, 22);
            this.drinkText.TabIndex = 4;
            // 
            // friesText
            // 
            this.friesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesText.Location = new System.Drawing.Point(138, 83);
            this.friesText.Name = "friesText";
            this.friesText.Size = new System.Drawing.Size(84, 22);
            this.friesText.TabIndex = 5;
            // 
            // costButton
            // 
            this.costButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.costButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.costButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costButton.Location = new System.Drawing.Point(12, 133);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(210, 27);
            this.costButton.TabIndex = 6;
            this.costButton.Text = "Calculate Totals";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.CostButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(9, 195);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(69, 16);
            this.subTotalLabel.TabIndex = 7;
            this.subTotalLabel.Text = "Sub Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(9, 234);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(34, 16);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(9, 273);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(42, 16);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividerLabel.Location = new System.Drawing.Point(9, 299);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(213, 10);
            this.dividerLabel.TabIndex = 11;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(9, 324);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(71, 16);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(9, 407);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(58, 16);
            this.changeLabel.TabIndex = 13;
            this.changeLabel.Text = "Change:";
            // 
            // changeButton
            // 
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(12, 359);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(210, 27);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(12, 439);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(210, 27);
            this.receiptButton.TabIndex = 15;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // tenderedValueLabel
            // 
            this.tenderedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedValueLabel.Location = new System.Drawing.Point(86, 324);
            this.tenderedValueLabel.Name = "tenderedValueLabel";
            this.tenderedValueLabel.Size = new System.Drawing.Size(136, 23);
            this.tenderedValueLabel.TabIndex = 16;
            this.tenderedValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // changeValueLabel
            // 
            this.changeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeValueLabel.Location = new System.Drawing.Point(89, 407);
            this.changeValueLabel.Name = "changeValueLabel";
            this.changeValueLabel.Size = new System.Drawing.Size(133, 29);
            this.changeValueLabel.TabIndex = 17;
            this.changeValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptBackLabel
            // 
            this.receiptBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBackLabel.Location = new System.Drawing.Point(262, 9);
            this.receiptBackLabel.Name = "receiptBackLabel";
            this.receiptBackLabel.Size = new System.Drawing.Size(315, 415);
            this.receiptBackLabel.TabIndex = 18;
            // 
            // newOrderButton
            // 
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(262, 439);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(315, 27);
            this.newOrderButton.TabIndex = 19;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(340, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(167, 16);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Basic Fast Food Place Inc.";
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.orderNumberLabel.Location = new System.Drawing.Point(280, 50);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(281, 17);
            this.orderNumberLabel.TabIndex = 21;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLabel.Location = new System.Drawing.Point(280, 67);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(158, 16);
            this.dateLabel.TabIndex = 22;
            this.dateLabel.Text = "Date: November 26, 2020";
            // 
            // leftreceiptLabel
            // 
            this.leftreceiptLabel.AutoSize = true;
            this.leftreceiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftreceiptLabel.Location = new System.Drawing.Point(280, 113);
            this.leftreceiptLabel.Name = "leftreceiptLabel";
            this.leftreceiptLabel.Size = new System.Drawing.Size(0, 16);
            this.leftreceiptLabel.TabIndex = 23;
            // 
            // tenderedText
            // 
            this.tenderedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedText.Location = new System.Drawing.Point(138, 321);
            this.tenderedText.Name = "tenderedText";
            this.tenderedText.Size = new System.Drawing.Size(84, 22);
            this.tenderedText.TabIndex = 26;
            // 
            // rightreceiptLabel
            // 
            this.rightreceiptLabel.AutoSize = true;
            this.rightreceiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightreceiptLabel.Location = new System.Drawing.Point(438, 113);
            this.rightreceiptLabel.Name = "rightreceiptLabel";
            this.rightreceiptLabel.Size = new System.Drawing.Size(0, 16);
            this.rightreceiptLabel.TabIndex = 27;
            this.rightreceiptLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // subTotalCostLabel
            // 
            this.subTotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalCostLabel.Location = new System.Drawing.Point(92, 195);
            this.subTotalCostLabel.Name = "subTotalCostLabel";
            this.subTotalCostLabel.Size = new System.Drawing.Size(130, 29);
            this.subTotalCostLabel.TabIndex = 28;
            this.subTotalCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxCostLabel
            // 
            this.taxCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxCostLabel.Location = new System.Drawing.Point(89, 234);
            this.taxCostLabel.Name = "taxCostLabel";
            this.taxCostLabel.Size = new System.Drawing.Size(133, 33);
            this.taxCostLabel.TabIndex = 29;
            this.taxCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(75, 273);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(147, 26);
            this.totalCostLabel.TabIndex = 30;
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 478);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.taxCostLabel);
            this.Controls.Add(this.subTotalCostLabel);
            this.Controls.Add(this.rightreceiptLabel);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.leftreceiptLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.orderNumberLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptBackLabel);
            this.Controls.Add(this.changeValueLabel);
            this.Controls.Add(this.tenderedValueLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.friesText);
            this.Controls.Add(this.drinkText);
            this.Controls.Add(this.burgerText);
            this.Controls.Add(this.friesAmountLabel);
            this.Controls.Add(this.drinkAmountLabel);
            this.Controls.Add(this.burgerAmountLabel);
            this.Name = "Form1";
            this.Text = "Fast Food Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerAmountLabel;
        private System.Windows.Forms.Label drinkAmountLabel;
        private System.Windows.Forms.Label friesAmountLabel;
        private System.Windows.Forms.TextBox burgerText;
        private System.Windows.Forms.TextBox drinkText;
        private System.Windows.Forms.TextBox friesText;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label tenderedValueLabel;
        private System.Windows.Forms.Label changeValueLabel;
        private System.Windows.Forms.Label receiptBackLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label leftreceiptLabel;
        private System.Windows.Forms.TextBox tenderedText;
        private System.Windows.Forms.Label rightreceiptLabel;
        private System.Windows.Forms.Label subTotalCostLabel;
        private System.Windows.Forms.Label taxCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
    }
}

