namespace GNR8
{
	partial class Primary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Primary));
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lstObjects = new System.Windows.Forms.CheckedListBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.ttPrimary = new System.Windows.Forms.ToolTip(this.components);
            this.tsPrimary = new System.Windows.Forms.ToolStrip();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGenerate = new System.Windows.Forms.ToolStripButton();
            this.tbsCustom = new System.Windows.Forms.ToolStripButton();
            this.tsbTokens = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnGenerateClasses = new System.Windows.Forms.Button();
            this.tsPrimary.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Enabled = false;
            this.chkSelectAll.Location = new System.Drawing.Point(12, 323);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(68, 17);
            this.chkSelectAll.TabIndex = 6;
            this.chkSelectAll.Text = "&Select all";
            this.ttPrimary.SetToolTip(this.chkSelectAll, "Select/Deselect all listed objects");
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // lstObjects
            // 
            this.lstObjects.CheckOnClick = true;
            this.lstObjects.FormattingEnabled = true;
            this.lstObjects.Location = new System.Drawing.Point(12, 66);
            this.lstObjects.Name = "lstObjects";
            this.lstObjects.Size = new System.Drawing.Size(347, 244);
            this.lstObjects.Sorted = true;
            this.lstObjects.TabIndex = 5;
            this.lstObjects.ThreeDCheckBoxes = true;
            // 
            // btnProcess
            // 
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProcess.Enabled = false;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcess.Location = new System.Drawing.Point(227, 317);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(132, 39);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.TabStop = false;
            this.btnProcess.Text = "&Process As Per Template";
            this.ttPrimary.SetToolTip(this.btnProcess, "Process selected objects");
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // tsPrimary
            // 
            this.tsPrimary.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrimary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConnect,
            this.tsbRefresh,
            this.toolStripSeparator3,
            this.tsbGenerate,
            this.tbsCustom,
            this.tsbTokens,
            this.toolStripSeparator1,
            this.tsbAbout,
            this.toolStripSeparator2,
            this.tsbExit});
            this.tsPrimary.Location = new System.Drawing.Point(0, 0);
            this.tsPrimary.Name = "tsPrimary";
            this.tsPrimary.Size = new System.Drawing.Size(371, 25);
            this.tsPrimary.TabIndex = 9;
            // 
            // tsbConnect
            // 
            this.tsbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnect.Image")));
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Size = new System.Drawing.Size(23, 22);
            this.tsbConnect.Text = "Connect";
            this.tsbConnect.ToolTipText = "Connect to a database";
            this.tsbConnect.Click += new System.EventHandler(this.tsbConnect_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.ToolTipText = "Refresh the object view";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbGenerate
            // 
            this.tsbGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGenerate.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerate.Image")));
            this.tsbGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerate.Name = "tsbGenerate";
            this.tsbGenerate.Size = new System.Drawing.Size(23, 22);
            this.tsbGenerate.Text = "Generate";
            this.tsbGenerate.ToolTipText = "Generate a new default Template file";
            this.tsbGenerate.Click += new System.EventHandler(this.tsbGenerate_Click);
            // 
            // tbsCustom
            // 
            this.tbsCustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsCustom.Image = ((System.Drawing.Image)(resources.GetObject("tbsCustom.Image")));
            this.tbsCustom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsCustom.Name = "tbsCustom";
            this.tbsCustom.Size = new System.Drawing.Size(23, 22);
            this.tbsCustom.Text = "Custom Tokens";
            this.tbsCustom.ToolTipText = "Add/Edit/Delete Custom Tokens";
            this.tbsCustom.Click += new System.EventHandler(this.tbsCustom_Click);
            // 
            // tsbTokens
            // 
            this.tsbTokens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTokens.Image = ((System.Drawing.Image)(resources.GetObject("tsbTokens.Image")));
            this.tsbTokens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTokens.Name = "tsbTokens";
            this.tsbTokens.Size = new System.Drawing.Size(23, 22);
            this.tsbTokens.Text = "Tokens";
            this.tsbTokens.ToolTipText = "Display available tokens";
            this.tsbTokens.Click += new System.EventHandler(this.tsbTokens_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAbout
            // 
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(23, 22);
            this.tsbAbout.Text = "About";
            this.tsbAbout.ToolTipText = "About GNR8";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "Exit";
            this.tsbExit.ToolTipText = "Quit GNR8";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 40);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(289, 23);
            this.lblInfo.TabIndex = 10;
            // 
            // btnGenerateClasses
            // 
            this.btnGenerateClasses.Location = new System.Drawing.Point(100, 316);
            this.btnGenerateClasses.Name = "btnGenerateClasses";
            this.btnGenerateClasses.Size = new System.Drawing.Size(121, 40);
            this.btnGenerateClasses.TabIndex = 11;
            this.btnGenerateClasses.Text = "Generate Classes";
            this.btnGenerateClasses.UseVisualStyleBackColor = true;
            this.btnGenerateClasses.Click += new System.EventHandler(this.btnGenerateClasses_Click);
            // 
            // Primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 368);
            this.Controls.Add(this.btnGenerateClasses);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.tsPrimary);
            this.Controls.Add(this.lstObjects);
            this.Controls.Add(this.btnProcess);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Primary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GNR8";
            this.tsPrimary.ResumeLayout(false);
            this.tsPrimary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnProcess;
		private System.Windows.Forms.CheckedListBox lstObjects;
		private System.Windows.Forms.CheckBox chkSelectAll;
		private System.Windows.Forms.ToolTip ttPrimary;
		private System.Windows.Forms.ToolStrip tsPrimary;
		private System.Windows.Forms.ToolStripButton tsbConnect;
		private System.Windows.Forms.ToolStripButton tsbRefresh;
		private System.Windows.Forms.ToolStripButton tsbGenerate;
		private System.Windows.Forms.ToolStripButton tsbTokens;
		private System.Windows.Forms.ToolStripButton tsbAbout;
		private System.Windows.Forms.ToolStripButton tsbExit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.ToolStripButton tbsCustom;
        private System.Windows.Forms.Button btnGenerateClasses;
	}
}

