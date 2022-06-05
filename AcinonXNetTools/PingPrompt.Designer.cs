namespace AcinonXNetTools
{
    partial class PingPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingPrompt));
            this.instrLabel = new System.Windows.Forms.Label();
            this.pingTargetInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ttlLabel = new System.Windows.Forms.Label();
            this.dFragLabel = new System.Windows.Forms.Label();
            this.rttLabel = new System.Windows.Forms.Label();
            this.bufSizeLabel = new System.Windows.Forms.Label();
            this.addrLabel = new System.Windows.Forms.Label();
            this.pingStatLabel = new System.Windows.Forms.Label();
            this.getResultsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instrLabel
            // 
            this.instrLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instrLabel.AutoSize = true;
            this.instrLabel.Font = new System.Drawing.Font("Tahoma", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrLabel.Location = new System.Drawing.Point(265, 9);
            this.instrLabel.Name = "instrLabel";
            this.instrLabel.Size = new System.Drawing.Size(237, 35);
            this.instrLabel.TabIndex = 0;
            this.instrLabel.Text = "Ping Hostname";
            this.instrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pingTargetInput
            // 
            this.pingTargetInput.Font = new System.Drawing.Font("Consolas", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingTargetInput.Location = new System.Drawing.Point(13, 79);
            this.pingTargetInput.Name = "pingTargetInput";
            this.pingTargetInput.Size = new System.Drawing.Size(704, 26);
            this.pingTargetInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(723, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ttlLabel
            // 
            this.ttlLabel.AutoSize = true;
            this.ttlLabel.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlLabel.Location = new System.Drawing.Point(13, 112);
            this.ttlLabel.Name = "ttlLabel";
            this.ttlLabel.Size = new System.Drawing.Size(94, 18);
            this.ttlLabel.TabIndex = 3;
            this.ttlLabel.Text = "Time to live: ";
            // 
            // dFragLabel
            // 
            this.dFragLabel.AutoSize = true;
            this.dFragLabel.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFragLabel.Location = new System.Drawing.Point(13, 130);
            this.dFragLabel.Name = "dFragLabel";
            this.dFragLabel.Size = new System.Drawing.Size(120, 18);
            this.dFragLabel.TabIndex = 4;
            this.dFragLabel.Text = "Don\'t Fragment: ";
            // 
            // rttLabel
            // 
            this.rttLabel.AutoSize = true;
            this.rttLabel.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rttLabel.Location = new System.Drawing.Point(13, 148);
            this.rttLabel.Name = "rttLabel";
            this.rttLabel.Size = new System.Drawing.Size(127, 18);
            this.rttLabel.TabIndex = 5;
            this.rttLabel.Text = "Round Trip Time: ";
            // 
            // bufSizeLabel
            // 
            this.bufSizeLabel.AutoSize = true;
            this.bufSizeLabel.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bufSizeLabel.Location = new System.Drawing.Point(13, 166);
            this.bufSizeLabel.Name = "bufSizeLabel";
            this.bufSizeLabel.Size = new System.Drawing.Size(83, 18);
            this.bufSizeLabel.TabIndex = 6;
            this.bufSizeLabel.Text = "Buffer Size:";
            // 
            // addrLabel
            // 
            this.addrLabel.AutoSize = true;
            this.addrLabel.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrLabel.Location = new System.Drawing.Point(13, 184);
            this.addrLabel.Name = "addrLabel";
            this.addrLabel.Size = new System.Drawing.Size(65, 18);
            this.addrLabel.TabIndex = 7;
            this.addrLabel.Text = "Address:";
            // 
            // pingStatLabel
            // 
            this.pingStatLabel.AutoSize = true;
            this.pingStatLabel.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingStatLabel.Location = new System.Drawing.Point(13, 202);
            this.pingStatLabel.Name = "pingStatLabel";
            this.pingStatLabel.Size = new System.Drawing.Size(85, 18);
            this.pingStatLabel.TabIndex = 8;
            this.pingStatLabel.Text = "Ping Status:";
            // 
            // getResultsBtn
            // 
            this.getResultsBtn.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getResultsBtn.Location = new System.Drawing.Point(13, 223);
            this.getResultsBtn.Name = "getResultsBtn";
            this.getResultsBtn.Size = new System.Drawing.Size(120, 25);
            this.getResultsBtn.TabIndex = 9;
            this.getResultsBtn.Text = "Get Results";
            this.getResultsBtn.UseVisualStyleBackColor = true;
            this.getResultsBtn.Click += new System.EventHandler(this.getResultsBtn_Click);
            // 
            // PingPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.getResultsBtn);
            this.Controls.Add(this.pingStatLabel);
            this.Controls.Add(this.addrLabel);
            this.Controls.Add(this.bufSizeLabel);
            this.Controls.Add(this.rttLabel);
            this.Controls.Add(this.dFragLabel);
            this.Controls.Add(this.ttlLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pingTargetInput);
            this.Controls.Add(this.instrLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PingPrompt";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ping Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instrLabel;
        private System.Windows.Forms.TextBox pingTargetInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ttlLabel;
        private System.Windows.Forms.Label dFragLabel;
        private System.Windows.Forms.Label rttLabel;
        private System.Windows.Forms.Label bufSizeLabel;
        private System.Windows.Forms.Label addrLabel;
        private System.Windows.Forms.Label pingStatLabel;
        private System.Windows.Forms.Button getResultsBtn;
    }
}