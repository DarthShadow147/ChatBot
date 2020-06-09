namespace Presentation
{
    partial class ChatUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatUI));
            this.PanelWindowControl = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.PanelChats = new System.Windows.Forms.Panel();
            this.BtnChat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChatBoxPanel = new System.Windows.Forms.Panel();
            this.btnLearn = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.EnterText = new System.Windows.Forms.TextBox();
            this.ChatHistory = new System.Windows.Forms.RichTextBox();
            this.PanelWindowControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelChats.SuspendLayout();
            this.ChatBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelWindowControl
            // 
            this.PanelWindowControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.PanelWindowControl.Controls.Add(this.btnClose);
            this.PanelWindowControl.Controls.Add(this.lblName);
            this.PanelWindowControl.Controls.Add(this.pictureBox1);
            this.PanelWindowControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelWindowControl.Location = new System.Drawing.Point(0, 0);
            this.PanelWindowControl.Name = "PanelWindowControl";
            this.PanelWindowControl.Size = new System.Drawing.Size(1229, 38);
            this.PanelWindowControl.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1201, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(50, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Hermes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(147)))));
            this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStatus.Location = new System.Drawing.Point(301, 38);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(928, 37);
            this.PanelStatus.TabIndex = 1;
            // 
            // PanelChats
            // 
            this.PanelChats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelChats.Controls.Add(this.BtnChat);
            this.PanelChats.Controls.Add(this.label1);
            this.PanelChats.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelChats.Location = new System.Drawing.Point(0, 38);
            this.PanelChats.Name = "PanelChats";
            this.PanelChats.Size = new System.Drawing.Size(301, 622);
            this.PanelChats.TabIndex = 2;
            // 
            // BtnChat
            // 
            this.BtnChat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnChat.FlatAppearance.BorderSize = 0;
            this.BtnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChat.ForeColor = System.Drawing.Color.White;
            this.BtnChat.Image = ((System.Drawing.Image)(resources.GetObject("BtnChat.Image")));
            this.BtnChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChat.Location = new System.Drawing.Point(0, 0);
            this.BtnChat.Name = "BtnChat";
            this.BtnChat.Size = new System.Drawing.Size(299, 73);
            this.BtnChat.TabIndex = 2;
            this.BtnChat.Text = "Hermes";
            this.BtnChat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(0, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "DarthShadow";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChatBoxPanel
            // 
            this.ChatBoxPanel.Controls.Add(this.btnLearn);
            this.ChatBoxPanel.Controls.Add(this.BtnSend);
            this.ChatBoxPanel.Controls.Add(this.EnterText);
            this.ChatBoxPanel.Controls.Add(this.ChatHistory);
            this.ChatBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatBoxPanel.Location = new System.Drawing.Point(301, 75);
            this.ChatBoxPanel.Name = "ChatBoxPanel";
            this.ChatBoxPanel.Size = new System.Drawing.Size(928, 585);
            this.ChatBoxPanel.TabIndex = 3;
            // 
            // btnLearn
            // 
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(147)))));
            this.btnLearn.Image = ((System.Drawing.Image)(resources.GetObject("btnLearn.Image")));
            this.btnLearn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLearn.Location = new System.Drawing.Point(682, 538);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(200, 35);
            this.btnLearn.TabIndex = 0;
            this.btnLearn.Text = "Enseñar";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSend.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(147)))));
            this.BtnSend.Image = ((System.Drawing.Image)(resources.GetObject("BtnSend.Image")));
            this.BtnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSend.Location = new System.Drawing.Point(682, 478);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(200, 54);
            this.BtnSend.TabIndex = 2;
            this.BtnSend.Text = "Enviar";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // EnterText
            // 
            this.EnterText.BackColor = System.Drawing.SystemColors.Window;
            this.EnterText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterText.Location = new System.Drawing.Point(18, 507);
            this.EnterText.Multiline = true;
            this.EnterText.Name = "EnterText";
            this.EnterText.Size = new System.Drawing.Size(658, 54);
            this.EnterText.TabIndex = 1;
            // 
            // ChatHistory
            // 
            this.ChatHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatHistory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ChatHistory.Location = new System.Drawing.Point(0, 0);
            this.ChatHistory.Name = "ChatHistory";
            this.ChatHistory.ReadOnly = true;
            this.ChatHistory.Size = new System.Drawing.Size(928, 472);
            this.ChatHistory.TabIndex = 0;
            this.ChatHistory.Text = "";
            // 
            // ChatUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 660);
            this.Controls.Add(this.ChatBoxPanel);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.PanelChats);
            this.Controls.Add(this.PanelWindowControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatUI";
            this.Load += new System.EventHandler(this.ChatUI_Load);
            this.PanelWindowControl.ResumeLayout(false);
            this.PanelWindowControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelChats.ResumeLayout(false);
            this.ChatBoxPanel.ResumeLayout(false);
            this.ChatBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelWindowControl;
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Panel PanelChats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ChatBoxPanel;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button BtnChat;
        private System.Windows.Forms.RichTextBox ChatHistory;
        private System.Windows.Forms.TextBox EnterText;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button btnLearn;
    }
}