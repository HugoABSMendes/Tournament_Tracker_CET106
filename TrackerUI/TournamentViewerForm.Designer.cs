namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneNameLabel = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoLabel = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.Cyan;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(263, 48);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tournamentName.ForeColor = Color.Cyan;
            tournamentName.Location = new Point(254, 9);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(562, 48);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            tournamentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundLabel
            // 
            roundLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundLabel.ForeColor = Color.PaleTurquoise;
            roundLabel.Location = new Point(12, 57);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(108, 32);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(126, 60);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(270, 26);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unplayedOnlyCheckbox.ForeColor = Color.PaleTurquoise;
            unplayedOnlyCheckbox.Location = new Point(126, 92);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(170, 28);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BackColor = SystemColors.InactiveCaption;
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 24;
            matchupListBox.Location = new Point(12, 153);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(349, 266);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneNameLabel
            // 
            teamOneNameLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamOneNameLabel.ForeColor = Color.PaleTurquoise;
            teamOneNameLabel.Location = new Point(367, 153);
            teamOneNameLabel.Name = "teamOneNameLabel";
            teamOneNameLabel.Size = new Size(286, 32);
            teamOneNameLabel.TabIndex = 6;
            teamOneNameLabel.Text = "<team one>";
            teamOneNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamOneScoreLabel.ForeColor = Color.PaleTurquoise;
            teamOneScoreLabel.Location = new Point(367, 185);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(93, 32);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(466, 188);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(187, 26);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(466, 386);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(187, 26);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamTwoScoreLabel.ForeColor = Color.PaleTurquoise;
            teamTwoScoreLabel.Location = new Point(367, 383);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(93, 32);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamTwoLabel.ForeColor = Color.PaleTurquoise;
            teamTwoLabel.Location = new Point(367, 351);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(286, 32);
            teamTwoLabel.TabIndex = 9;
            teamTwoLabel.Text = "<team two>";
            teamTwoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // versusLabel
            // 
            versusLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            versusLabel.ForeColor = Color.PaleTurquoise;
            versusLabel.Location = new Point(367, 268);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(286, 32);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            versusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.BorderSize = 5;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.Location = new Point(659, 214);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(157, 169);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(831, 431);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneNameLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneNameLabel;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}
