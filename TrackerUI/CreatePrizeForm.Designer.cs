namespace TrackerUI
{
    partial class CreatePrizeForm
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
            headerLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            priceAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.Cyan;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(711, 48);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Create Prize:";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(268, 66);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(455, 26);
            placeNumberValue.TabIndex = 23;
            placeNumberValue.TextAlign = HorizontalAlignment.Center;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = Color.PaleTurquoise;
            placeNumberLabel.Location = new Point(9, 60);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(253, 32);
            placeNumberLabel.TabIndex = 22;
            placeNumberLabel.Text = "First Name";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(268, 108);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(455, 26);
            placeNameValue.TabIndex = 25;
            placeNameValue.TextAlign = HorizontalAlignment.Center;
            // 
            // placeNameLabel
            // 
            placeNameLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = Color.PaleTurquoise;
            placeNameLabel.Location = new Point(9, 104);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(253, 32);
            placeNameLabel.TabIndex = 24;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(268, 190);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(455, 26);
            prizeAmountValue.TabIndex = 27;
            prizeAmountValue.TextAlign = HorizontalAlignment.Center;
            // 
            // priceAmountLabel
            // 
            priceAmountLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceAmountLabel.ForeColor = Color.PaleTurquoise;
            priceAmountLabel.Location = new Point(9, 188);
            priceAmountLabel.Name = "priceAmountLabel";
            priceAmountLabel.Size = new Size(253, 32);
            priceAmountLabel.TabIndex = 26;
            priceAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(268, 254);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(455, 26);
            prizePercentageValue.TabIndex = 29;
            prizePercentageValue.TextAlign = HorizontalAlignment.Center;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizePercentageLabel.ForeColor = Color.PaleTurquoise;
            prizePercentageLabel.Location = new Point(9, 254);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(253, 32);
            prizePercentageLabel.TabIndex = 28;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orLabel.ForeColor = Color.PaleTurquoise;
            orLabel.Location = new Point(119, 219);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(253, 32);
            orLabel.TabIndex = 30;
            orLabel.Text = "-Or-";
            orLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = SystemColors.ActiveCaption;
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.BorderSize = 5;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.Location = new Point(9, 306);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(714, 95);
            createPrizeButton.TabIndex = 31;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(735, 422);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(priceAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label priceAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}