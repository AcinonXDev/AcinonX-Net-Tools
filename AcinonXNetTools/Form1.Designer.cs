namespace AcinonXNetTools
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabLayout = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.netInfoPanel = new System.Windows.Forms.Panel();
            this.netItrfCount = new System.Windows.Forms.Label();
            this.netUsageReceived = new System.Windows.Forms.Label();
            this.netUsageSent = new System.Windows.Forms.Label();
            this.netDataUsage = new System.Windows.Forms.Label();
            this.netName = new System.Windows.Forms.Label();
            this.internetAddr = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gotoOpsTab = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pingBtn = new System.Windows.Forms.ToolStripButton();
            this.tabLayout.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.netInfoPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayout
            // 
            this.tabLayout.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabLayout.Controls.Add(this.homeTab);
            this.tabLayout.Controls.Add(this.tabPage2);
            this.tabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayout.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLayout.ItemSize = new System.Drawing.Size(12, 32);
            this.tabLayout.Location = new System.Drawing.Point(0, 0);
            this.tabLayout.Multiline = true;
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(1424, 983);
            this.tabLayout.TabIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.homeTab.Controls.Add(this.label2);
            this.homeTab.Controls.Add(this.panel1);
            this.homeTab.Controls.Add(this.button1);
            this.homeTab.Controls.Add(this.titlePanel);
            this.homeTab.Controls.Add(this.label1);
            this.homeTab.Controls.Add(this.netInfoPanel);
            this.homeTab.Location = new System.Drawing.Point(36, 4);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1384, 975);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(3, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1378, 77);
            this.titlePanel.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 25.81132F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(488, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(364, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "AcinonX Net Tools";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Network Information";
            // 
            // netInfoPanel
            // 
            this.netInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.netInfoPanel.Controls.Add(this.netItrfCount);
            this.netInfoPanel.Controls.Add(this.netUsageReceived);
            this.netInfoPanel.Controls.Add(this.netUsageSent);
            this.netInfoPanel.Controls.Add(this.netDataUsage);
            this.netInfoPanel.Controls.Add(this.netName);
            this.netInfoPanel.Controls.Add(this.internetAddr);
            this.netInfoPanel.Location = new System.Drawing.Point(12, 135);
            this.netInfoPanel.Name = "netInfoPanel";
            this.netInfoPanel.Size = new System.Drawing.Size(463, 832);
            this.netInfoPanel.TabIndex = 1;
            // 
            // netItrfCount
            // 
            this.netItrfCount.AutoSize = true;
            this.netItrfCount.Font = new System.Drawing.Font("Tahoma", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netItrfCount.Location = new System.Drawing.Point(15, 20);
            this.netItrfCount.Name = "netItrfCount";
            this.netItrfCount.Size = new System.Drawing.Size(215, 25);
            this.netItrfCount.TabIndex = 5;
            this.netItrfCount.Text = "Network Interfaces... ";
            // 
            // netUsageReceived
            // 
            this.netUsageReceived.AutoSize = true;
            this.netUsageReceived.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netUsageReceived.Location = new System.Drawing.Point(32, 142);
            this.netUsageReceived.Name = "netUsageReceived";
            this.netUsageReceived.Size = new System.Drawing.Size(100, 23);
            this.netUsageReceived.TabIndex = 4;
            this.netUsageReceived.Text = "KB Sent... ";
            // 
            // netUsageSent
            // 
            this.netUsageSent.AutoSize = true;
            this.netUsageSent.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netUsageSent.Location = new System.Drawing.Point(31, 120);
            this.netUsageSent.Name = "netUsageSent";
            this.netUsageSent.Size = new System.Drawing.Size(131, 23);
            this.netUsageSent.TabIndex = 3;
            this.netUsageSent.Text = "KB Received...";
            // 
            // netDataUsage
            // 
            this.netDataUsage.AutoSize = true;
            this.netDataUsage.Font = new System.Drawing.Font("Tahoma", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netDataUsage.Location = new System.Drawing.Point(15, 95);
            this.netDataUsage.Name = "netDataUsage";
            this.netDataUsage.Size = new System.Drawing.Size(119, 25);
            this.netDataUsage.TabIndex = 2;
            this.netDataUsage.Text = "Data Usage";
            // 
            // netName
            // 
            this.netName.AutoSize = true;
            this.netName.Font = new System.Drawing.Font("Tahoma", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netName.Location = new System.Drawing.Point(15, 70);
            this.netName.Name = "netName";
            this.netName.Size = new System.Drawing.Size(157, 25);
            this.netName.TabIndex = 1;
            this.netName.Text = "User Domain... ";
            // 
            // internetAddr
            // 
            this.internetAddr.AutoSize = true;
            this.internetAddr.Font = new System.Drawing.Font("Tahoma", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internetAddr.Location = new System.Drawing.Point(15, 45);
            this.internetAddr.Name = "internetAddr";
            this.internetAddr.Size = new System.Drawing.Size(138, 25);
            this.internetAddr.TabIndex = 0;
            this.internetAddr.Text = "IP Address... ";
            this.internetAddr.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(36, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1384, 975);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operations";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quick Links";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.gotoOpsTab);
            this.panel1.Location = new System.Drawing.Point(499, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 832);
            this.panel1.TabIndex = 5;
            // 
            // gotoOpsTab
            // 
            this.gotoOpsTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gotoOpsTab.AutoSize = true;
            this.gotoOpsTab.Font = new System.Drawing.Font("Tahoma", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoOpsTab.Location = new System.Drawing.Point(161, 20);
            this.gotoOpsTab.Name = "gotoOpsTab";
            this.gotoOpsTab.Size = new System.Drawing.Size(113, 25);
            this.gotoOpsTab.TabIndex = 0;
            this.gotoOpsTab.TabStop = true;
            this.gotoOpsTab.Text = "Operations";
            this.gotoOpsTab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gotoOpsTab_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 25.81132F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Operations";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 77);
            this.panel2.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingBtn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 80);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1378, 36);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pingBtn
            // 
            this.pingBtn.AutoSize = false;
            this.pingBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pingBtn.Image = ((System.Drawing.Image)(resources.GetObject("pingBtn.Image")));
            this.pingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pingBtn.Name = "pingBtn";
            this.pingBtn.Size = new System.Drawing.Size(32, 32);
            this.pingBtn.Text = "Ping";
            this.pingBtn.Click += new System.EventHandler(this.pingBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1424, 983);
            this.Controls.Add(this.tabLayout);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcinonX Net Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabLayout.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.netInfoPanel.ResumeLayout(false);
            this.netInfoPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLayout;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label internetAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel netInfoPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label netName;
        private System.Windows.Forms.Label netDataUsage;
        private System.Windows.Forms.Label netUsageReceived;
        private System.Windows.Forms.Label netUsageSent;
        private System.Windows.Forms.Label netItrfCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel gotoOpsTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pingBtn;
    }
}

