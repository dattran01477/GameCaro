namespace GameCaro
{
    partial class GameCaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCaro));
            this.PanelBoardChess = new System.Windows.Forms.Panel();
            this.panelAnh = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.txtCompetitor = new System.Windows.Forms.TextBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtViewChat = new System.Windows.Forms.ListBox();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBoardChess
            // 
            this.PanelBoardChess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBoardChess.Location = new System.Drawing.Point(4, 2);
            this.PanelBoardChess.Name = "PanelBoardChess";
            this.PanelBoardChess.Size = new System.Drawing.Size(653, 610);
            this.PanelBoardChess.TabIndex = 0;
            // 
            // panelAnh
            // 
            this.panelAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAnh.BackgroundImage")));
            this.panelAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAnh.Location = new System.Drawing.Point(664, 2);
            this.panelAnh.Name = "panelAnh";
            this.panelAnh.Size = new System.Drawing.Size(287, 266);
            this.panelAnh.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.btnLan);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Controls.Add(this.txtIp);
            this.panelInfo.Controls.Add(this.txtYourName);
            this.panelInfo.Controls.Add(this.txtCompetitor);
            this.panelInfo.Location = new System.Drawing.Point(663, 274);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(288, 338);
            this.panelInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 4);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("VNI-Brush", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 93);
            this.label1.TabIndex = 5;
            this.label1.Text = "Caro Make By \r\n   ThanhDat";
            // 
            // btnLan
            // 
            this.btnLan.BackColor = System.Drawing.SystemColors.Control;
            this.btnLan.Location = new System.Drawing.Point(91, 212);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(98, 23);
            this.btnLan.TabIndex = 4;
            this.btnLan.Text = "Lan";
            this.btnLan.UseVisualStyleBackColor = false;
            this.btnLan.Click += new System.EventHandler(this.btnLan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(78, 174);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(132, 22);
            this.txtIp.TabIndex = 2;
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(3, 75);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(132, 22);
            this.txtYourName.TabIndex = 1;
            // 
            // txtCompetitor
            // 
            this.txtCompetitor.Location = new System.Drawing.Point(3, 36);
            this.txtCompetitor.Name = "txtCompetitor";
            this.txtCompetitor.Size = new System.Drawing.Size(132, 22);
            this.txtCompetitor.TabIndex = 0;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(860, 618);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(75, 50);
            this.btnChat.TabIndex = 4;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(663, 618);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(191, 50);
            this.txtChat.TabIndex = 5;
            // 
            // txtViewChat
            // 
            this.txtViewChat.FormattingEnabled = true;
            this.txtViewChat.ItemHeight = 16;
            this.txtViewChat.Location = new System.Drawing.Point(663, 690);
            this.txtViewChat.Name = "txtViewChat";
            this.txtViewChat.Size = new System.Drawing.Size(272, 116);
            this.txtViewChat.TabIndex = 6;
            // 
            // GameCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 810);
            this.Controls.Add(this.txtViewChat);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelAnh);
            this.Controls.Add(this.PanelBoardChess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameCaro";
            this.Text = "GameCaro";
            this.Load += new System.EventHandler(this.GameCaro_Load);
            this.Shown += new System.EventHandler(this.GameCaro_Shown);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBoardChess;
        private System.Windows.Forms.Panel panelAnh;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.TextBox txtCompetitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.ListBox txtViewChat;
    }
}

