namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(305, 60);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(239, 26);
            teamNameValue.TabIndex = 12;
            teamNameValue.TextAlign = HorizontalAlignment.Center;
            // 
            // teamNameLabel
            // 
            teamNameLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = Color.PaleTurquoise;
            teamNameLabel.Location = new Point(12, 57);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(287, 32);
            teamNameLabel.TabIndex = 11;
            teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.Cyan;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(380, 48);
            headerLabel.TabIndex = 10;
            headerLabel.Text = "Create Team:";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.BorderSize = 5;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMemberButton.Location = new Point(19, 195);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(287, 64);
            addMemberButton.TabIndex = 18;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(305, 145);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(239, 26);
            selectTeamMemberDropDown.TabIndex = 17;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = Color.PaleTurquoise;
            selectTeamMemberLabel.Location = new Point(12, 138);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(287, 32);
            selectTeamMemberLabel.TabIndex = 16;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewMemberGroupBox.Location = new Point(19, 265);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(525, 345);
            addNewMemberGroupBox.TabIndex = 19;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(271, 71);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(248, 39);
            firstNameValue.TabIndex = 21;
            firstNameValue.TextAlign = HorizontalAlignment.Center;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.PaleTurquoise;
            firstNameLabel.Location = new Point(12, 71);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(253, 32);
            firstNameLabel.TabIndex = 20;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(271, 118);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(248, 39);
            lastNameValue.TabIndex = 23;
            lastNameValue.TextAlign = HorizontalAlignment.Center;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.PaleTurquoise;
            lastNameLabel.Location = new Point(12, 118);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(253, 32);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(271, 171);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(248, 39);
            emailValue.TabIndex = 25;
            emailValue.TextAlign = HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.PaleTurquoise;
            emailLabel.Location = new Point(12, 171);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(253, 32);
            emailLabel.TabIndex = 24;
            emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(271, 224);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(248, 39);
            cellphoneValue.TabIndex = 27;
            cellphoneValue.TextAlign = HorizontalAlignment.Center;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cellphoneLabel.ForeColor = Color.PaleTurquoise;
            cellphoneLabel.Location = new Point(12, 224);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(253, 32);
            cellphoneLabel.TabIndex = 26;
            cellphoneLabel.Text = "Cell Number";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.BorderSize = 5;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createMemberButton.Location = new Point(12, 275);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(507, 64);
            createMemberButton.TabIndex = 20;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BackColor = SystemColors.MenuBar;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 18;
            teamMembersListBox.Location = new Point(554, 57);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(393, 418);
            teamMembersListBox.TabIndex = 20;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.BorderSize = 5;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedMemberButton.Location = new Point(790, 489);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(157, 115);
            deleteSelectedMemberButton.TabIndex = 21;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.BackColor = SystemColors.ActiveCaption;
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.BorderSize = 5;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTeamButton.Location = new Point(12, 630);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(935, 95);
            createTeamButton.TabIndex = 24;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(959, 737);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}