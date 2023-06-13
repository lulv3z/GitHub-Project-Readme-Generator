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
            this.generateReadmeBtn.Location = new System.Drawing.Point(982, 521);
            this.generateReadmeBtn.Name = "generateReadmeBtn";
            this.generateReadmeBtn.Size = new System.Drawing.Size(180, 45);
            this.generateReadmeBtn.TabIndex = 4;
            this.generateReadmeBtn.Text = "Generate";
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
            this.firstTimeGenerateCB.Size = new System.Drawing.Size(147, 20);
            this.firstTimeGenerateCB.TabIndex = 6;
            this.firstTimeGenerateCB.Text = "First Time Generate";
            this.firstTimeGenerateCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.firstTimeGenerateCB.UncheckedState.BorderRadius = 0;
            this.firstTimeGenerateCB.UncheckedState.BorderThickness = 0;
            this.firstTimeGenerateCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.firstTimeGenerateCB.CheckedChanged += new System.EventHandler(this.firstTimeGenerateCB_CheckedChanged);
            // 
            // Frm_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 578);
            this.Controls.Add(this.firstTimeGenerateCB);
            this.Controls.Add(this.addFeaturesCB);
            this.Controls.Add(this.generateReadmeBtn);
            this.Controls.Add(this.changeProjectPathBtn);
            this.Controls.Add(this.projectFolderPathTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.projectNameTxt);
            this.Controls.Add(this.AboutTheProjectTxt);
            this.Controls.Add(this.repositoryLinkTxt);
            this.MinimumSize = new System.Drawing.Size(1192, 625);
            this.Name = "Frm_MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub Project readme Generator";
            this.Load += new System.EventHandler(this.Frm_MainWindow_Load);
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
    }
}