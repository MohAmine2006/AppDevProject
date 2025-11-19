namespace SmartExpenseTracker
{
    partial class SmartExpenseTrackerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartExpenseTrackerForm));
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.aboutButton = new FontAwesome.Sharp.IconButton();
            this.helpButton = new FontAwesome.Sharp.IconButton();
            this.reportsButton = new FontAwesome.Sharp.IconButton();
            this.transactionButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.iconLabelButton = new FontAwesome.Sharp.IconButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.clockLabelContainer = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.AutoScroll = true;
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.sideMenuPanel.Controls.Add(this.exitButton);
            this.sideMenuPanel.Controls.Add(this.aboutButton);
            this.sideMenuPanel.Controls.Add(this.helpButton);
            this.sideMenuPanel.Controls.Add(this.reportsButton);
            this.sideMenuPanel.Controls.Add(this.transactionButton);
            this.sideMenuPanel.Controls.Add(this.homeButton);
            this.sideMenuPanel.Controls.Add(this.titlePanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(282, 694);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.exitButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 24;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 642);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(282, 52);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutButton.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.aboutButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aboutButton.IconSize = 24;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(0, 404);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(282, 52);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "About";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpButton.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.helpButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.helpButton.IconSize = 24;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(0, 352);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(282, 52);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Help";
            this.helpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // reportsButton
            // 
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportsButton.IconChar = FontAwesome.Sharp.IconChar.RectangleList;
            this.reportsButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportsButton.IconSize = 24;
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(0, 300);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(282, 52);
            this.reportsButton.TabIndex = 3;
            this.reportsButton.Text = "Reports";
            this.reportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // transactionButton
            // 
            this.transactionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.transactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transactionButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsTurnToDots;
            this.transactionButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transactionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.transactionButton.IconSize = 24;
            this.transactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionButton.Location = new System.Drawing.Point(0, 248);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(282, 52);
            this.transactionButton.TabIndex = 2;
            this.transactionButton.Text = "Transactions";
            this.transactionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transactionButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.House;
            this.homeButton.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.IconSize = 24;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 196);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(282, 52);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.iconLabelButton);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(282, 196);
            this.titlePanel.TabIndex = 0;
            // 
            // iconLabelButton
            // 
            this.iconLabelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.iconLabelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconLabelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.iconLabelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLabelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLabelButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconLabelButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconLabelButton.IconColor = System.Drawing.Color.Gainsboro;
            this.iconLabelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLabelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLabelButton.Location = new System.Drawing.Point(0, 65);
            this.iconLabelButton.Name = "iconLabelButton";
            this.iconLabelButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconLabelButton.Size = new System.Drawing.Size(282, 131);
            this.iconLabelButton.TabIndex = 2;
            this.iconLabelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconLabelButton.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(282, 65);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Smart Expense Tracker";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.clockLabelContainer);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(282, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(796, 43);
            this.topPanel.TabIndex = 1;
            // 
            // clockLabelContainer
            // 
            this.clockLabelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.clockLabelContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabelContainer.ForeColor = System.Drawing.Color.DarkGray;
            this.clockLabelContainer.Location = new System.Drawing.Point(336, 0);
            this.clockLabelContainer.Name = "clockLabelContainer";
            this.clockLabelContainer.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.clockLabelContainer.Size = new System.Drawing.Size(460, 43);
            this.clockLabelContainer.TabIndex = 0;
            this.clockLabelContainer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(282, 43);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(796, 651);
            this.mainPanel.TabIndex = 2;
            // 
            // SmartExpenseTrackerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1078, 694);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SmartExpenseTrackerForm";
            this.Text = "Smart Expense Tracker";
            this.Load += new System.EventHandler(this.SmartExpenseTrackerForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private FontAwesome.Sharp.IconButton iconLabelButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label clockLabelContainer;
        private System.Windows.Forms.Timer clock;
        private FontAwesome.Sharp.IconButton homeButton;
        private FontAwesome.Sharp.IconButton transactionButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton aboutButton;
        private FontAwesome.Sharp.IconButton helpButton;
        private FontAwesome.Sharp.IconButton reportsButton;
        private System.Windows.Forms.Panel mainPanel;
    }
}

