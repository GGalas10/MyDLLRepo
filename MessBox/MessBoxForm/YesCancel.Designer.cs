namespace MessBox
{
    partial class YesCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YesCancel));
            this.YesBtn = new System.Windows.Forms.Button();
            this.TextLbl = new System.Windows.Forms.Label();
            this.IconPic = new System.Windows.Forms.Label();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TextPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // YesBtn
            // 
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesBtn.Location = new System.Drawing.Point(5, 212);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(75, 32);
            this.YesBtn.TabIndex = 1;
            this.YesBtn.Text = "Nie";
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // TextLbl
            // 
            this.TextLbl.AutoEllipsis = true;
            this.TextLbl.BackColor = System.Drawing.Color.Transparent;
            this.TextLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TextLbl.Location = new System.Drawing.Point(0, 0);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(277, 175);
            this.TextLbl.TabIndex = 2;
            this.TextLbl.Text = resources.GetString("TextLbl.Text");
            // 
            // IconPic
            // 
            this.IconPic.Image = global::MessBox.Properties.Resources.Info;
            this.IconPic.Location = new System.Drawing.Point(12, 75);
            this.IconPic.Name = "IconPic";
            this.IconPic.Size = new System.Drawing.Size(64, 64);
            this.IconPic.TabIndex = 3;
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.TextLbl);
            this.TextPanel.Location = new System.Drawing.Point(82, 31);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(277, 175);
            this.TextPanel.TabIndex = 4;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.Image = global::MessBox.Properties.Resources.Exit;
            this.ExitBtn.Location = new System.Drawing.Point(347, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(24, 24);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Click += new System.EventHandler(this.label2_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.TitleLbl);
            this.TitlePanel.Controls.Add(this.ExitBtn);
            this.TitlePanel.ForeColor = System.Drawing.Color.White;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(371, 24);
            this.TitlePanel.TabIndex = 6;
            // 
            // TitleLbl
            // 
            this.TitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(0, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(347, 24);
            this.TitleLbl.TabIndex = 6;
            this.TitleLbl.Text = "label1";
            this.TitleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLbl_MouseDown);
            // 
            // CancelBtn
            // 
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(291, 212);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 32);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Nie";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // YesCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(371, 247);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.IconPic);
            this.Controls.Add(this.YesBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 247);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(371, 247);
            this.Name = "YesCancel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YesNo";
            this.TextPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Label IconPic;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button CancelBtn;
    }
}