﻿namespace final_oosee.AdministratorInterface
{
    partial class MainForm_Administrator
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
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.statisticBtn = new FontAwesome.Sharp.IconButton();
            this.accountManageBtn = new FontAwesome.Sharp.IconButton();
            this.logOutButton = new FontAwesome.Sharp.IconButton();
            this.sideBarButton = new FontAwesome.Sharp.IconButton();
            this.panelSideBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panelSideBar.Controls.Add(this.statisticBtn);
            this.panelSideBar.Controls.Add(this.accountManageBtn);
            this.panelSideBar.Controls.Add(this.logOutButton);
            this.panelSideBar.Controls.Add(this.panelLogo);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(230, 753);
            this.panelSideBar.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.sideBarButton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 70);
            this.panelLogo.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Location = new System.Drawing.Point(236, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1134, 731);
            this.panelContent.TabIndex = 3;
            // 
            // statisticBtn
            // 
            this.statisticBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticBtn.FlatAppearance.BorderSize = 0;
            this.statisticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticBtn.ForeColor = System.Drawing.Color.White;
            this.statisticBtn.IconChar = FontAwesome.Sharp.IconChar.Signal;
            this.statisticBtn.IconColor = System.Drawing.Color.White;
            this.statisticBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statisticBtn.IconSize = 30;
            this.statisticBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticBtn.Location = new System.Drawing.Point(0, 130);
            this.statisticBtn.Name = "statisticBtn";
            this.statisticBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.statisticBtn.Size = new System.Drawing.Size(230, 60);
            this.statisticBtn.TabIndex = 5;
            this.statisticBtn.Text = "Statistics";
            this.statisticBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.statisticBtn.UseVisualStyleBackColor = true;
            // 
            // accountManageBtn
            // 
            this.accountManageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountManageBtn.FlatAppearance.BorderSize = 0;
            this.accountManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountManageBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountManageBtn.ForeColor = System.Drawing.Color.White;
            this.accountManageBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.accountManageBtn.IconColor = System.Drawing.Color.White;
            this.accountManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountManageBtn.IconSize = 30;
            this.accountManageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountManageBtn.Location = new System.Drawing.Point(0, 70);
            this.accountManageBtn.Name = "accountManageBtn";
            this.accountManageBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.accountManageBtn.Size = new System.Drawing.Size(230, 60);
            this.accountManageBtn.TabIndex = 4;
            this.accountManageBtn.Text = "Manage Account";
            this.accountManageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountManageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accountManageBtn.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logOutButton.IconColor = System.Drawing.Color.White;
            this.logOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logOutButton.IconSize = 30;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(0, 693);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(230, 60);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // sideBarButton
            // 
            this.sideBarButton.FlatAppearance.BorderSize = 0;
            this.sideBarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBarButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.sideBarButton.IconColor = System.Drawing.Color.White;
            this.sideBarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBarButton.Location = new System.Drawing.Point(3, 7);
            this.sideBarButton.Name = "sideBarButton";
            this.sideBarButton.Size = new System.Drawing.Size(60, 60);
            this.sideBarButton.TabIndex = 1;
            this.sideBarButton.UseVisualStyleBackColor = true;
            // 
            // MainForm_Administrator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.Name = "MainForm_Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_Administrator";
            this.Load += new System.EventHandler(this.MainForm_Administrator_Load);
            this.panelSideBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private FontAwesome.Sharp.IconButton statisticBtn;
        private FontAwesome.Sharp.IconButton accountManageBtn;
        private FontAwesome.Sharp.IconButton logOutButton;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton sideBarButton;
        private System.Windows.Forms.Panel panelContent;
    }
}