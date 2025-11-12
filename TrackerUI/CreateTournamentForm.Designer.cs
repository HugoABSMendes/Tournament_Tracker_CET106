namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            headerLabel = new Label();
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            TournamentPlayerListBox = new ListBox();
            TournamentPlayersLabel = new Label();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.Cyan;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(380, 48);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament:";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tournamentNameLabel.ForeColor = Color.PaleTurquoise;
            tournamentNameLabel.Location = new Point(12, 57);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(287, 32);
            tournamentNameLabel.TabIndex = 4;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(305, 60);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(326, 26);
            tournamentNameValue.TabIndex = 9;
            tournamentNameValue.TextAlign = HorizontalAlignment.Center;
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(305, 185);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(326, 26);
            entryFeeValue.TabIndex = 11;
            entryFeeValue.Text = "0";
            entryFeeValue.TextAlign = HorizontalAlignment.Center;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entryFeeLabel.ForeColor = Color.PaleTurquoise;
            entryFeeLabel.Location = new Point(12, 182);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(287, 32);
            entryFeeLabel.TabIndex = 10;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(305, 323);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(326, 26);
            selectTeamDropDown.TabIndex = 13;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = Color.PaleTurquoise;
            selectTeamLabel.Location = new Point(12, 316);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(287, 32);
            selectTeamLabel.TabIndex = 12;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.Location = new Point(18, 348);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(281, 22);
            createNewTeamLink.TabIndex = 14;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create New...";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.BorderSize = 5;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.Location = new Point(12, 441);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(287, 64);
            addTeamButton.TabIndex = 15;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.BorderSize = 5;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.Location = new Point(344, 441);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(287, 64);
            createPrizeButton.TabIndex = 16;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayerListBox
            // 
            TournamentPlayerListBox.BackColor = SystemColors.MenuBar;
            TournamentPlayerListBox.FormattingEnabled = true;
            TournamentPlayerListBox.ItemHeight = 18;
            TournamentPlayerListBox.Location = new Point(666, 67);
            TournamentPlayerListBox.Name = "TournamentPlayerListBox";
            TournamentPlayerListBox.Size = new Size(393, 112);
            TournamentPlayerListBox.TabIndex = 17;
            // 
            // TournamentPlayersLabel
            // 
            TournamentPlayersLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentPlayersLabel.ForeColor = Color.Cyan;
            TournamentPlayersLabel.Location = new Point(666, 9);
            TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            TournamentPlayersLabel.Size = new Size(393, 48);
            TournamentPlayersLabel.TabIndex = 18;
            TournamentPlayersLabel.Text = "Teams / Players";
            TournamentPlayersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.BorderSize = 5;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPlayerButton.Location = new Point(840, 185);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(219, 64);
            deleteSelectedPlayerButton.TabIndex = 19;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.BorderSize = 5;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPrizeButton.Location = new Point(840, 441);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(219, 64);
            deleteSelectedPrizeButton.TabIndex = 22;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizesLabel.ForeColor = Color.Cyan;
            prizesLabel.Location = new Point(666, 265);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(393, 48);
            prizesLabel.TabIndex = 21;
            prizesLabel.Text = "Prizes";
            prizesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prizesListBox
            // 
            prizesListBox.BackColor = SystemColors.MenuBar;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 18;
            prizesListBox.Location = new Point(666, 323);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(393, 112);
            prizesListBox.TabIndex = 20;
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = SystemColors.ActiveCaption;
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.BorderSize = 5;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.Location = new Point(12, 546);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(1047, 95);
            createTournamentButton.TabIndex = 23;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1071, 653);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(TournamentPlayersLabel);
            Controls.Add(TournamentPlayerListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox TournamentPlayerListBox;
        private Label TournamentPlayersLabel;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}