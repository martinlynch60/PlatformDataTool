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
            this.DatasetLabel = new System.Windows.Forms.Label();
            this.Dataset = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.Application = new System.Windows.Forms.ComboBox();
            this.OrganisationsTab = new System.Windows.Forms.TabPage();
            this.OrganisationNameLabel = new System.Windows.Forms.Label();
            this.OrganisationName = new System.Windows.Forms.TextBox();
            this.OrganisationIdLabel = new System.Windows.Forms.Label();
            this.OrganisationId = new System.Windows.Forms.TextBox();
            this.OrganisationSupportRefLabel = new System.Windows.Forms.Label();
            this.OrganisationSupportRef = new System.Windows.Forms.TextBox();
            this.OrganisationSearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainFormTab.SuspendLayout();
            this.SubscriptionsTab.SuspendLayout();
            this.OrganisationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormTab
            // 
            this.MainFormTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormTab.Controls.Add(this.OrganisationsTab);
            this.MainFormTab.Controls.Add(this.SubscriptionsTab);
            this.MainFormTab.Location = new System.Drawing.Point(12, 12);
            this.MainFormTab.Name = "MainFormTab";
            this.MainFormTab.SelectedIndex = 0;
            this.MainFormTab.Size = new System.Drawing.Size(442, 372);
            this.MainFormTab.TabIndex = 0;
            // 
            // SubscriptionsTab
            // 
            this.SubscriptionsTab.Controls.Add(this.DatasetLabel);
            this.SubscriptionsTab.Controls.Add(this.Dataset);
            this.SubscriptionsTab.Controls.Add(this.UserLabel);
            this.SubscriptionsTab.Controls.Add(this.User);
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
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.Location = new System.Drawing.Point(29, 38);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(59, 13);
            this.ApplicationLabel.TabIndex = 1;
            this.ApplicationLabel.Text = "Application";
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
            // OrganisationsTab
            // 
            this.OrganisationsTab.Controls.Add(this.dataGridView1);
            this.OrganisationsTab.Controls.Add(this.OrganisationSearchButton);
            this.OrganisationsTab.Controls.Add(this.OrganisationSupportRefLabel);
            this.OrganisationsTab.Controls.Add(this.OrganisationSupportRef);
            this.OrganisationsTab.Controls.Add(this.OrganisationIdLabel);
            this.OrganisationsTab.Controls.Add(this.OrganisationId);
            this.OrganisationsTab.Controls.Add(this.OrganisationNameLabel);
            this.OrganisationsTab.Controls.Add(this.OrganisationName);
            this.OrganisationsTab.Location = new System.Drawing.Point(4, 22);
            this.OrganisationsTab.Name = "OrganisationsTab";
            this.OrganisationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrganisationsTab.Size = new System.Drawing.Size(434, 346);
            this.OrganisationsTab.TabIndex = 1;
            this.OrganisationsTab.Text = "Organisations";
            this.OrganisationsTab.UseVisualStyleBackColor = true;
            // 
            // OrganisationNameLabel
            // 
            this.OrganisationNameLabel.AutoSize = true;
            this.OrganisationNameLabel.Location = new System.Drawing.Point(31, 40);
            this.OrganisationNameLabel.Name = "OrganisationNameLabel";
            this.OrganisationNameLabel.Size = new System.Drawing.Size(35, 13);
            this.OrganisationNameLabel.TabIndex = 5;
            this.OrganisationNameLabel.Text = "Name";
            // 
            // OrganisationName
            // 
            this.OrganisationName.Location = new System.Drawing.Point(161, 37);
            this.OrganisationName.Name = "OrganisationName";
            this.OrganisationName.Size = new System.Drawing.Size(247, 20);
            this.OrganisationName.TabIndex = 4;
            // 
            // OrganisationIdLabel
            // 
            this.OrganisationIdLabel.AutoSize = true;
            this.OrganisationIdLabel.Location = new System.Drawing.Point(31, 66);
            this.OrganisationIdLabel.Name = "OrganisationIdLabel";
            this.OrganisationIdLabel.Size = new System.Drawing.Size(16, 13);
            this.OrganisationIdLabel.TabIndex = 7;
            this.OrganisationIdLabel.Text = "Id";
            // 
            // OrganisationId
            // 
            this.OrganisationId.Location = new System.Drawing.Point(161, 63);
            this.OrganisationId.Name = "OrganisationId";
            this.OrganisationId.Size = new System.Drawing.Size(247, 20);
            this.OrganisationId.TabIndex = 6;
            // 
            // OrganisationSupportRefLabel
            // 
            this.OrganisationSupportRefLabel.AutoSize = true;
            this.OrganisationSupportRefLabel.Location = new System.Drawing.Point(31, 92);
            this.OrganisationSupportRefLabel.Name = "OrganisationSupportRefLabel";
            this.OrganisationSupportRefLabel.Size = new System.Drawing.Size(64, 13);
            this.OrganisationSupportRefLabel.TabIndex = 9;
            this.OrganisationSupportRefLabel.Text = "Support Ref";
            // 
            // OrganisationSupportRef
            // 
            this.OrganisationSupportRef.Location = new System.Drawing.Point(161, 89);
            this.OrganisationSupportRef.Name = "OrganisationSupportRef";
            this.OrganisationSupportRef.Size = new System.Drawing.Size(247, 20);
            this.OrganisationSupportRef.TabIndex = 8;
            // 
            // OrganisationSearchButton
            // 
            this.OrganisationSearchButton.Location = new System.Drawing.Point(333, 115);
            this.OrganisationSearchButton.Name = "OrganisationSearchButton";
            this.OrganisationSearchButton.Size = new System.Drawing.Size(75, 23);
            this.OrganisationSearchButton.TabIndex = 10;
            this.OrganisationSearchButton.Text = "Search";
            this.OrganisationSearchButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(393, 162);
            this.dataGridView1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 396);
            this.Controls.Add(this.MainFormTab);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormTab.ResumeLayout(false);
            this.SubscriptionsTab.ResumeLayout(false);
            this.SubscriptionsTab.PerformLayout();
            this.OrganisationsTab.ResumeLayout(false);
            this.OrganisationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainFormTab;
        private System.Windows.Forms.TabPage SubscriptionsTab;
        private System.Windows.Forms.TabPage OrganisationsTab;
        private System.Windows.Forms.ComboBox Application;
        private System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label DatasetLabel;
        private System.Windows.Forms.TextBox Dataset;
        private System.Windows.Forms.Label OrganisationNameLabel;
        private System.Windows.Forms.TextBox OrganisationName;
        private System.Windows.Forms.Label OrganisationSupportRefLabel;
        private System.Windows.Forms.TextBox OrganisationSupportRef;
        private System.Windows.Forms.Label OrganisationIdLabel;
        private System.Windows.Forms.TextBox OrganisationId;
        private System.Windows.Forms.Button OrganisationSearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

