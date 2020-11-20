﻿/*  Memory Cleaner is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Memory Cleaner is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Memory Cleaner.  If not, see <https://www.gnu.org/licenses/>. */

namespace Memory_Cleaner
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ButtonTwitter = new System.Windows.Forms.Button();
            this.ButtonDonate = new System.Windows.Forms.Button();
            this.ButtonDiscord = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Info = new System.Windows.Forms.Label();
            this.LinkGitHub = new System.Windows.Forms.LinkLabel();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonTwitter
            // 
            this.ButtonTwitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonTwitter.AutoSize = true;
            this.ButtonTwitter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonTwitter.Location = new System.Drawing.Point(5, 103);
            this.ButtonTwitter.Name = "ButtonTwitter";
            this.ButtonTwitter.Size = new System.Drawing.Size(53, 23);
            this.ButtonTwitter.TabIndex = 61;
            this.ButtonTwitter.Text = "Twitter";
            this.ButtonTwitter.UseVisualStyleBackColor = true;
            this.ButtonTwitter.Click += new System.EventHandler(this.ButtonTwitter_Click);
            // 
            // ButtonDonate
            // 
            this.ButtonDonate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDonate.AutoSize = true;
            this.ButtonDonate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDonate.Location = new System.Drawing.Point(62, 103);
            this.ButtonDonate.Name = "ButtonDonate";
            this.ButtonDonate.Size = new System.Drawing.Size(56, 23);
            this.ButtonDonate.TabIndex = 60;
            this.ButtonDonate.Text = "Donate";
            this.ButtonDonate.UseVisualStyleBackColor = true;
            this.ButtonDonate.Click += new System.EventHandler(this.ButtonDonate_Click);
            // 
            // ButtonDiscord
            // 
            this.ButtonDiscord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDiscord.AutoSize = true;
            this.ButtonDiscord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDiscord.Location = new System.Drawing.Point(122, 103);
            this.ButtonDiscord.Name = "ButtonDiscord";
            this.ButtonDiscord.Size = new System.Drawing.Size(57, 23);
            this.ButtonDiscord.TabIndex = 59;
            this.ButtonDiscord.Text = "Discord";
            this.ButtonDiscord.UseVisualStyleBackColor = true;
            this.ButtonDiscord.Click += new System.EventHandler(this.ButtonDiscord_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClose.AutoSize = true;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonClose.Location = new System.Drawing.Point(183, 103);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(47, 23);
            this.ButtonClose.TabIndex = 58;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.Info, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.LinkGitHub, 0, 2);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(225, 94);
            this.TableLayoutPanel1.TabIndex = 57;
            // 
            // Info
            // 
            this.Info.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(3, 2);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(136, 65);
            this.Info.TabIndex = 0;
            this.Info.Text = "Memory Cleaner\r\nVersion 1.6.1\r\n\r\nCopyright 2020 Danske\r\nunder GNU GPL v3 license";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LinkGitHub
            // 
            this.LinkGitHub.ActiveLinkColor = System.Drawing.Color.White;
            this.LinkGitHub.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LinkGitHub.AutoSize = true;
            this.LinkGitHub.LinkColor = System.Drawing.SystemColors.ControlText;
            this.LinkGitHub.Location = new System.Drawing.Point(3, 77);
            this.LinkGitHub.Name = "LinkGitHub";
            this.LinkGitHub.Size = new System.Drawing.Size(105, 13);
            this.LinkGitHub.TabIndex = 1;
            this.LinkGitHub.TabStop = true;
            this.LinkGitHub.Text = "github.com/danskee";
            this.LinkGitHub.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGitHub_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 128);
            this.Controls.Add(this.ButtonTwitter);
            this.Controls.Add(this.ButtonDonate);
            this.Controls.Add(this.ButtonDiscord);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonTwitter;
        private System.Windows.Forms.Button ButtonDonate;
        private System.Windows.Forms.Button ButtonDiscord;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.LinkLabel LinkGitHub;
    }
}