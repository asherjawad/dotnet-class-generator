namespace GNR8
{
	partial class Connect
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
			this.lblInitialCatalog = new System.Windows.Forms.Label();
			this.txtProvider = new System.Windows.Forms.TextBox();
			this.lblProviderName = new System.Windows.Forms.Label();
			this.cbUIS = new System.Windows.Forms.CheckBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUserId = new System.Windows.Forms.Label();
			this.lblServerName = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnTest = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.gbConnect = new System.Windows.Forms.GroupBox();
			this.btnCatalogs = new System.Windows.Forms.Button();
			this.cboCatalog = new System.Windows.Forms.ComboBox();
			this.btnServers = new System.Windows.Forms.Button();
			this.cboServers = new System.Windows.Forms.ComboBox();
			this.pbStatus = new System.Windows.Forms.PictureBox();
			this.ttConnect = new System.Windows.Forms.ToolTip(this.components);
			this.ttGet = new System.Windows.Forms.ToolTip(this.components);
			this.gbConnect.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.pbStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInitialCatalog
			// 
			this.lblInitialCatalog.Location = new System.Drawing.Point(11, 76);
			this.lblInitialCatalog.Name = "lblInitialCatalog";
			this.lblInitialCatalog.Size = new System.Drawing.Size(100, 21);
			this.lblInitialCatalog.TabIndex = 8;
			this.lblInitialCatalog.Text = "Initial Catalog:";
			this.lblInitialCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtProvider
			// 
			this.txtProvider.Location = new System.Drawing.Point(113, 22);
			this.txtProvider.Name = "txtProvider";
			this.txtProvider.Size = new System.Drawing.Size(200, 21);
			this.txtProvider.TabIndex = 0;
			this.txtProvider.TabStop = false;
			this.txtProvider.Text = "SQLOLEDB";
			// 
			// lblProviderName
			// 
			this.lblProviderName.Location = new System.Drawing.Point(11, 22);
			this.lblProviderName.Name = "lblProviderName";
			this.lblProviderName.Size = new System.Drawing.Size(100, 21);
			this.lblProviderName.TabIndex = 6;
			this.lblProviderName.Text = "Provider Name: ";
			this.lblProviderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbUIS
			// 
			this.cbUIS.AutoSize = true;
			this.cbUIS.Location = new System.Drawing.Point(113, 107);
			this.cbUIS.Name = "cbUIS";
			this.cbUIS.Size = new System.Drawing.Size(141, 17);
			this.cbUIS.TabIndex = 3;
			this.cbUIS.Text = "Use Integrated Security";
			this.cbUIS.UseVisualStyleBackColor = true;
			this.cbUIS.CheckedChanged += new System.EventHandler(this.cbUIS_CheckedChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(113, 157);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(200, 21);
			this.txtPassword.TabIndex = 5;
			// 
			// txtUserId
			// 
			this.txtUserId.Location = new System.Drawing.Point(113, 130);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(200, 21);
			this.txtUserId.TabIndex = 4;
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(11, 157);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(100, 21);
			this.lblPassword.TabIndex = 10;
			this.lblPassword.Text = "Password:";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblUserId
			// 
			this.lblUserId.Location = new System.Drawing.Point(11, 129);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(100, 21);
			this.lblUserId.TabIndex = 9;
			this.lblUserId.Text = "User ID:";
			this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblServerName
			// 
			this.lblServerName.Location = new System.Drawing.Point(11, 49);
			this.lblServerName.Name = "lblServerName";
			this.lblServerName.Size = new System.Drawing.Size(100, 21);
			this.lblServerName.TabIndex = 7;
			this.lblServerName.Text = "Server Name: ";
			this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnCancel
			// 
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Location = new System.Drawing.Point(12, 202);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.ttConnect.SetToolTip(this.btnCancel, "Cancel and Return to Main Form");
			// 
			// btnTest
			// 
			this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnTest.Location = new System.Drawing.Point(230, 202);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 2;
			this.btnTest.Text = "Test";
			this.ttConnect.SetToolTip(this.btnTest, "Test the selected connection");
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btnOk
			// 
			this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOk.Location = new System.Drawing.Point(311, 202);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.ttConnect.SetToolTip(this.btnOk, "Connect to the given database and schema");
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// gbConnect
			// 
			this.gbConnect.Controls.Add(this.btnCatalogs);
			this.gbConnect.Controls.Add(this.cboCatalog);
			this.gbConnect.Controls.Add(this.btnServers);
			this.gbConnect.Controls.Add(this.cboServers);
			this.gbConnect.Controls.Add(this.txtPassword);
			this.gbConnect.Controls.Add(this.cbUIS);
			this.gbConnect.Controls.Add(this.lblProviderName);
			this.gbConnect.Controls.Add(this.lblServerName);
			this.gbConnect.Controls.Add(this.txtProvider);
			this.gbConnect.Controls.Add(this.txtUserId);
			this.gbConnect.Controls.Add(this.lblUserId);
			this.gbConnect.Controls.Add(this.lblInitialCatalog);
			this.gbConnect.Controls.Add(this.lblPassword);
			this.gbConnect.Location = new System.Drawing.Point(12, 12);
			this.gbConnect.Name = "gbConnect";
			this.gbConnect.Size = new System.Drawing.Size(374, 184);
			this.gbConnect.TabIndex = 0;
			this.gbConnect.TabStop = false;
			this.gbConnect.Text = "Sql Connection";
			// 
			// btnCatalogs
			// 
			this.btnCatalogs.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnCatalogs.BackgroundImage")));
			this.btnCatalogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCatalogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCatalogs.Location = new System.Drawing.Point(345, 77);
			this.btnCatalogs.Name = "btnCatalogs";
			this.btnCatalogs.Size = new System.Drawing.Size(23, 23);
			this.btnCatalogs.TabIndex = 13;
			this.btnCatalogs.TabStop = false;
			this.ttConnect.SetToolTip(this.btnCatalogs, "Retrieve a list of schemas for the given server");
			this.btnCatalogs.UseVisualStyleBackColor = true;
			this.btnCatalogs.Click += new System.EventHandler(this.btnCatalogs_Click);
			// 
			// cboCatalog
			// 
			this.cboCatalog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cboCatalog.FormattingEnabled = true;
			this.cboCatalog.Location = new System.Drawing.Point(113, 77);
			this.cboCatalog.Name = "cboCatalog";
			this.cboCatalog.Size = new System.Drawing.Size(226, 21);
			this.cboCatalog.TabIndex = 2;
			this.ttConnect.SetToolTip(this.cboCatalog, "Discover all available schema for the chosen server");
			// 
			// btnServers
			// 
			this.btnServers.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnServers.BackgroundImage")));
			this.btnServers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnServers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnServers.Location = new System.Drawing.Point(345, 46);
			this.btnServers.Name = "btnServers";
			this.btnServers.Size = new System.Drawing.Size(23, 23);
			this.btnServers.TabIndex = 11;
			this.btnServers.TabStop = false;
			this.ttGet.SetToolTip(this.btnServers, resources.GetString("btnServers.ToolTip"));
			this.btnServers.UseVisualStyleBackColor = true;
			this.btnServers.Click += new System.EventHandler(this.btnServers_Click);
			// 
			// cboServers
			// 
			this.cboServers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboServers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cboServers.FormattingEnabled = true;
			this.cboServers.Location = new System.Drawing.Point(113, 48);
			this.cboServers.Name = "cboServers";
			this.cboServers.Size = new System.Drawing.Size(226, 21);
			this.cboServers.TabIndex = 1;
			// 
			// pbStatus
			// 
			this.pbStatus.Image = ((System.Drawing.Image) (resources.GetObject("pbStatus.Image")));
			this.pbStatus.Location = new System.Drawing.Point(98, 202);
			this.pbStatus.Name = "pbStatus";
			this.pbStatus.Size = new System.Drawing.Size(126, 23);
			this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbStatus.TabIndex = 9;
			this.pbStatus.TabStop = false;
			this.pbStatus.Visible = false;
			// 
			// ttGet
			// 
			this.ttGet.IsBalloon = true;
			this.ttGet.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
			this.ttGet.ToolTipTitle = "Warning";
			// 
			// Connect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(397, 231);
			this.Controls.Add(this.pbStatus);
			this.Controls.Add(this.gbConnect);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.btnOk);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.Name = "Connect";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect";
			this.gbConnect.ResumeLayout(false);
			this.gbConnect.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.pbStatus)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Label lblInitialCatalog;
		internal System.Windows.Forms.TextBox txtProvider;
		internal System.Windows.Forms.Label lblProviderName;
		private System.Windows.Forms.CheckBox cbUIS;
		internal System.Windows.Forms.TextBox txtPassword;
		internal System.Windows.Forms.TextBox txtUserId;
		internal System.Windows.Forms.Label lblPassword;
		internal System.Windows.Forms.Label lblUserId;
		internal System.Windows.Forms.Label lblServerName;
		internal System.Windows.Forms.Button btnCancel;
		internal System.Windows.Forms.Button btnTest;
		internal System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.GroupBox gbConnect;
		private System.Windows.Forms.PictureBox pbStatus;
		private System.Windows.Forms.ComboBox cboServers;
		private System.Windows.Forms.Button btnServers;
		private System.Windows.Forms.ToolTip ttConnect;
		private System.Windows.Forms.ComboBox cboCatalog;
		private System.Windows.Forms.Button btnCatalogs;
		private System.Windows.Forms.ToolTip ttGet;


	}
}