namespace PlatformDataTool.Forms
{
    partial class MainForm
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
            this.MainFormTab = new System.Windows.Forms.TabControl();
            this.SubscriptionsTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Application = new System.Windows.Forms.ComboBox();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.Organisation = new System.Windows.Forms.TextBox();
            this.OrganisationLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.DatasetLabel = new System.Windows.Forms.Label();
            this.Dataset = new System.Windows.Forms.TextBox();
            this.MainFormTab.SuspendLayout();
            this.SubscriptionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTab
            // 
            this.MainFormTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormTab.Controls.Add(this.SubscriptionsTab);
            this.MainFormTab.Controls.Add(this.tabPage2);
            this.MainFormTab.Location = new System.Drawing.Point(12, 12);
            this.MainFormTab.Name = "MainFormTab";
            this.MainFormTab.SelectedIndex = 0;
            this.MainFormTab.Size = new System.Drawing.Size(442, 360);
            this.MainFormTab.TabIndex = 0;
            // 
            // SubscriptionsTab
            // 
            this.SubscriptionsTab.Controls.Add(this.DatasetLabel);
            this.SubscriptionsTab.Controls.Add(this.Dataset);
            this.SubscriptionsTab.Controls.Add(this.UserLabel);
            this.SubscriptionsTab.Controls.Add(this.User);
            this.SubscriptionsTab.Controls.Add(this.OrganisationLabel);
            this.SubscriptionsTab.Controls.Add(this.Organisation);
            this.SubscriptionsTab.Controls.Add(this.ApplicationLabel);
            this.SubscriptionsTab.Controls.Add(this.Application);
            this.SubscriptionsTab.Location = new System.Drawing.Point(4, 22);
            this.SubscriptionsTab.Name = "SubscriptionsTab";
            this.SubscriptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SubscriptionsTab.Size = new System.Drawing.Size(434, 334);
            this.SubscriptionsTab.TabIndex = 0;
            this.SubscriptionsTab.Text = "Subscriptions";
            this.SubscriptionsTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Application
            // 
            this.Application.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Application.FormattingEnabled = true;
            this.Application.Location = new System.Drawing.Point(159, 35);
            this.Application.Name = "Application";
            this.Application.Size = new System.Drawing.Size(231, 21);
            this.Application.TabIndex = 0;
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.Location = new System.Drawing.Point(29, 38);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(59, 13);
            this.ApplicationLabel.TabIndex = 1;
            this.ApplicationLabel.Text = "Application";
            // 
            // Organisation
            // 
            this.Organisation.Location = new System.Drawing.Point(159, 62);
            this.Organisation.Name = "Organisation";
            this.Organisation.Size = new System.Drawing.Size(231, 20);
            this.Organisation.TabIndex = 2;
            // 
            // OrganisationLabel
            // 
            this.OrganisationLabel.AutoSize = true;
            this.OrganisationLabel.Location = new System.Drawing.Point(29, 65);
            this.OrganisationLabel.Name = "OrganisationLabel";
            this.OrganisationLabel.Size = new System.Drawing.Size(66, 13);
            this.OrganisationLabel.TabIndex = 3;
            this.OrganisationLabel.Text = "Organisation";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(29, 91);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(29, 13);
            this.UserLabel.TabIndex = 5;
            this.UserLabel.Text = "User";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(159, 88);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(231, 20);
            this.User.TabIndex = 4;
            // 
            // DatasetLabel
            // 
            this.DatasetLabel.AutoSize = true;
            this.DatasetLabel.Location = new System.Drawing.Point(29, 117);
            this.DatasetLabel.Name = "DatasetLabel";
            this.DatasetLabel.Size = new System.Drawing.Size(44, 13);
            this.DatasetLabel.TabIndex = 7;
            this.DatasetLabel.Text = "Dataset";
            // 
            // Dataset
            // 
            this.Dataset.Location = new System.Drawing.Point(159, 114);
            this.Dataset.Name = "Dataset";
            this.Dataset.Size = new System.Drawing.Size(231, 20);
            this.Dataset.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 384);
            this.Controls.Add(this.MainFormTab);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormTab.ResumeLayout(false);
            this.SubscriptionsTab.ResumeLayout(false);
            this.SubscriptionsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainFormTab;
        private System.Windows.Forms.TabPage SubscriptionsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Application;
        private System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.Label OrganisationLabel;
        private System.Windows.Forms.TextBox Organisation;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label DatasetLabel;
        private System.Windows.Forms.TextBox Dataset;
    }
}

