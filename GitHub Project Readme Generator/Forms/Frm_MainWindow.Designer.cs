namespace GitHub_Project_Readme_Generator.Forms
{
    partial class Frm_MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainWindow));
            this.repositoryLinkTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.projectNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.descriptionTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.projectFolderPathTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.changeProjectPathBtn = new Guna.UI2.WinForms.Guna2Button();
            this.generateReadmeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AboutTheProjectTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.addFeaturesCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.firstTimeGenerateCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.createChangelogCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.app_buttombar = new System.Windows.Forms.Panel();
            this.githubBtn = new System.Windows.Forms.PictureBox();
            this.supportBtn = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.app_buttombar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryLinkTxt
            // 
            this.repositoryLinkTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repositoryLinkTxt.DefaultText = "";
            this.repositoryLinkTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.repositoryLinkTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.repositoryLinkTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repositoryLinkTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repositoryLinkTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repositoryLinkTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.repositoryLinkTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repositoryLinkTxt.Location = new System.Drawing.Point(26, 115);
            this.repositoryLinkTxt.Name = "repositoryLinkTxt";
            this.repositoryLinkTxt.PasswordChar = '\0';
            this.repositoryLinkTxt.PlaceholderText = "https://github.com/user/repository";
            this.repositoryLinkTxt.SelectedText = "";
            this.repositoryLinkTxt.Size = new System.Drawing.Size(338, 36);
            this.repositoryLinkTxt.TabIndex = 0;
            // 
            // projectNameTxt
            // 
            this.projectNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.projectNameTxt.DefaultText = "";
            this.projectNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.projectNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.projectNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.projectNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.projectNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.projectNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.projectNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.projectNameTxt.Location = new System.Drawing.Point(26, 31);
            this.projectNameTxt.Name = "projectNameTxt";
            this.projectNameTxt.PasswordChar = '\0';
            this.projectNameTxt.PlaceholderText = "Project Name";
            this.projectNameTxt.SelectedText = "";
            this.projectNameTxt.Size = new System.Drawing.Size(338, 36);
            this.projectNameTxt.TabIndex = 0;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTxt.DefaultText = "";
            this.descriptionTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTxt.Location = new System.Drawing.Point(26, 73);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.PasswordChar = '\0';
            this.descriptionTxt.PlaceholderText = "Project Description";
            this.descriptionTxt.SelectedText = "";
            this.descriptionTxt.Size = new System.Drawing.Size(338, 36);
            this.descriptionTxt.TabIndex = 1;
            // 
            // projectFolderPathTxt
            // 
            this.projectFolderPathTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.projectFolderPathTxt.DefaultText = "";
            this.projectFolderPathTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.projectFolderPathTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.projectFolderPathTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.projectFolderPathTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.projectFolderPathTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.projectFolderPathTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.projectFolderPathTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.projectFolderPathTxt.Location = new System.Drawing.Point(26, 213);
            this.projectFolderPathTxt.Name = "projectFolderPathTxt";
            this.projectFolderPathTxt.PasswordChar = '\0';
            this.projectFolderPathTxt.PlaceholderText = "example: C:\\Users\\User\\OneDrive\\Dokumente\\Visual Studio 2022\\Projects\\TestProject" +
    "\\";
            this.projectFolderPathTxt.SelectedText = "";
            this.projectFolderPathTxt.Size = new System.Drawing.Size(338, 36);
            this.projectFolderPathTxt.TabIndex = 2;
            // 
            // changeProjectPathBtn
            // 
            this.changeProjectPathBtn.Animated = true;
            this.changeProjectPathBtn.AutoRoundedCorners = true;
            this.changeProjectPathBtn.BorderRadius = 13;
            this.changeProjectPathBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeProjectPathBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeProjectPathBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeProjectPathBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeProjectPathBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeProjectPathBtn.ForeColor = System.Drawing.Color.White;
            this.changeProjectPathBtn.Location = new System.Drawing.Point(266, 255);
            this.changeProjectPathBtn.Name = "changeProjectPathBtn";
            this.changeProjectPathBtn.Size = new System.Drawing.Size(98, 28);
            this.changeProjectPathBtn.TabIndex = 3;
            this.changeProjectPathBtn.Text = "Change";
            this.changeProjectPathBtn.Click += new System.EventHandler(this.changeProjectPathBtn_Click);
            // 
            // generateReadmeBtn
            // 
            this.generateReadmeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateReadmeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateReadmeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateReadmeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateReadmeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generateReadmeBtn.ForeColor = System.Drawing.Color.White;
            this.generateReadmeBtn.Location = new System.Drawing.Point(591, 401);
            this.generateReadmeBtn.Name = "generateReadmeBtn";
            this.generateReadmeBtn.Size = new System.Drawing.Size(180, 45);
            this.generateReadmeBtn.TabIndex = 4;
            this.generateReadmeBtn.Text = "Generate";
            this.toolTip.SetToolTip(this.generateReadmeBtn, "Generate");
            this.generateReadmeBtn.Click += new System.EventHandler(this.generateReadmeBtn_Click);
            // 
            // AboutTheProjectTxt
            // 
            this.AboutTheProjectTxt.Animated = true;
            this.AboutTheProjectTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AboutTheProjectTxt.DefaultText = "";
            this.AboutTheProjectTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AboutTheProjectTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AboutTheProjectTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AboutTheProjectTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AboutTheProjectTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AboutTheProjectTxt.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.AboutTheProjectTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AboutTheProjectTxt.Location = new System.Drawing.Point(497, 31);
            this.AboutTheProjectTxt.Multiline = true;
            this.AboutTheProjectTxt.Name = "AboutTheProjectTxt";
            this.AboutTheProjectTxt.PasswordChar = '\0';
            this.AboutTheProjectTxt.PlaceholderText = "About The Project....";
            this.AboutTheProjectTxt.SelectedText = "";
            this.AboutTheProjectTxt.Size = new System.Drawing.Size(274, 36);
            this.AboutTheProjectTxt.TabIndex = 0;
            this.AboutTheProjectTxt.Click += new System.EventHandler(this.AboutTheProjectTxt_Click);
            // 
            // updater
            // 
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // addFeaturesCB
            // 
            this.addFeaturesCB.AutoSize = true;
            this.addFeaturesCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addFeaturesCB.CheckedState.BorderRadius = 0;
            this.addFeaturesCB.CheckedState.BorderThickness = 0;
            this.addFeaturesCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addFeaturesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.addFeaturesCB.Location = new System.Drawing.Point(497, 73);
            this.addFeaturesCB.Name = "addFeaturesCB";
            this.addFeaturesCB.Size = new System.Drawing.Size(110, 20);
            this.addFeaturesCB.TabIndex = 5;
            this.addFeaturesCB.Text = "Add Features";
            this.toolTip.SetToolTip(this.addFeaturesCB, "Adds a feature post");
            this.addFeaturesCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.addFeaturesCB.UncheckedState.BorderRadius = 0;
            this.addFeaturesCB.UncheckedState.BorderThickness = 0;
            this.addFeaturesCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.addFeaturesCB.CheckedChanged += new System.EventHandler(this.addFeaturesCB_CheckedChanged);
            // 
            // firstTimeGenerateCB
            // 
            this.firstTimeGenerateCB.AutoSize = true;
            this.firstTimeGenerateCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstTimeGenerateCB.CheckedState.BorderRadius = 0;
            this.firstTimeGenerateCB.CheckedState.BorderThickness = 0;
            this.firstTimeGenerateCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstTimeGenerateCB.Location = new System.Drawing.Point(26, 263);
            this.firstTimeGenerateCB.Name = "firstTimeGenerateCB";
            this.firstTimeGenerateCB.Size = new System.Drawing.Size(165, 20);
            this.firstTimeGenerateCB.TabIndex = 6;
            this.firstTimeGenerateCB.Text = "Create Issue Template";
            this.toolTip.SetToolTip(this.firstTimeGenerateCB, "automatically creates an issue template");
            this.firstTimeGenerateCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.firstTimeGenerateCB.UncheckedState.BorderRadius = 0;
            this.firstTimeGenerateCB.UncheckedState.BorderThickness = 0;
            this.firstTimeGenerateCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.firstTimeGenerateCB.CheckedChanged += new System.EventHandler(this.firstTimeGenerateCB_CheckedChanged);
            // 
            // createChangelogCB
            // 
            this.createChangelogCB.AutoSize = true;
            this.createChangelogCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createChangelogCB.CheckedState.BorderRadius = 0;
            this.createChangelogCB.CheckedState.BorderThickness = 0;
            this.createChangelogCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createChangelogCB.Location = new System.Drawing.Point(26, 289);
            this.createChangelogCB.Name = "createChangelogCB";
            this.createChangelogCB.Size = new System.Drawing.Size(138, 20);
            this.createChangelogCB.TabIndex = 7;
            this.createChangelogCB.Text = "Create Changelog";
            this.toolTip.SetToolTip(this.createChangelogCB, "automatically creates a changelog.md file");
            this.createChangelogCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.createChangelogCB.UncheckedState.BorderRadius = 0;
            this.createChangelogCB.UncheckedState.BorderThickness = 0;
            this.createChangelogCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.createChangelogCB.CheckedChanged += new System.EventHandler(this.createChangelogCB_CheckedChanged);
            // 
            // app_buttombar
            // 
            this.app_buttombar.BackColor = System.Drawing.Color.LightGray;
            this.app_buttombar.Controls.Add(this.supportBtn);
            this.app_buttombar.Controls.Add(this.githubBtn);
            this.app_buttombar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.app_buttombar.Location = new System.Drawing.Point(0, 452);
            this.app_buttombar.Name = "app_buttombar";
            this.app_buttombar.Size = new System.Drawing.Size(796, 31);
            this.app_buttombar.TabIndex = 8;
            // 
            // githubBtn
            // 
            this.githubBtn.Image = ((System.Drawing.Image)(resources.GetObject("githubBtn.Image")));
            this.githubBtn.Location = new System.Drawing.Point(754, 0);
            this.githubBtn.Name = "githubBtn";
            this.githubBtn.Size = new System.Drawing.Size(42, 31);
            this.githubBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.githubBtn.TabIndex = 9;
            this.githubBtn.TabStop = false;
            this.toolTip.SetToolTip(this.githubBtn, "Open GitHub");
            this.githubBtn.Click += new System.EventHandler(this.githubBtn_Click);
            // 
            // supportBtn
            // 
            this.supportBtn.Image = ((System.Drawing.Image)(resources.GetObject("supportBtn.Image")));
            this.supportBtn.Location = new System.Drawing.Point(705, 0);
            this.supportBtn.Name = "supportBtn";
            this.supportBtn.Size = new System.Drawing.Size(43, 31);
            this.supportBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.supportBtn.TabIndex = 9;
            this.supportBtn.TabStop = false;
            this.toolTip.SetToolTip(this.supportBtn, "Issues / Feature Request");
            this.supportBtn.Click += new System.EventHandler(this.supportBtn_Click);
            // 
            // Frm_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 483);
            this.Controls.Add(this.app_buttombar);
            this.Controls.Add(this.createChangelogCB);
            this.Controls.Add(this.firstTimeGenerateCB);
            this.Controls.Add(this.addFeaturesCB);
            this.Controls.Add(this.generateReadmeBtn);
            this.Controls.Add(this.changeProjectPathBtn);
            this.Controls.Add(this.projectFolderPathTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.projectNameTxt);
            this.Controls.Add(this.AboutTheProjectTxt);
            this.Controls.Add(this.repositoryLinkTxt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(814, 530);
            this.MinimumSize = new System.Drawing.Size(814, 530);
            this.Name = "Frm_MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub Project readme Generator";
            this.Load += new System.EventHandler(this.Frm_MainWindow_Load);
            this.app_buttombar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.githubBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox repositoryLinkTxt;
        private Guna.UI2.WinForms.Guna2TextBox projectNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTxt;
        private Guna.UI2.WinForms.Guna2TextBox projectFolderPathTxt;
        private Guna.UI2.WinForms.Guna2Button changeProjectPathBtn;
        private Guna.UI2.WinForms.Guna2Button generateReadmeBtn;
        private Guna.UI2.WinForms.Guna2TextBox AboutTheProjectTxt;
        private System.Windows.Forms.Timer updater;
        private Guna.UI2.WinForms.Guna2CheckBox addFeaturesCB;
        private Guna.UI2.WinForms.Guna2CheckBox firstTimeGenerateCB;
        private Guna.UI2.WinForms.Guna2CheckBox createChangelogCB;
        private System.Windows.Forms.Panel app_buttombar;
        private System.Windows.Forms.PictureBox githubBtn;
        private System.Windows.Forms.PictureBox supportBtn;
        private System.Windows.Forms.ToolTip toolTip;
    }
}