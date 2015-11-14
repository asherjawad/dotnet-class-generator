namespace GNR8
{
	partial class Process
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Process));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.gbLocation = new System.Windows.Forms.GroupBox();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.lblPath = new System.Windows.Forms.Label();
			this.lblSelectLocation = new System.Windows.Forms.Label();
			this.fbdProcess = new System.Windows.Forms.FolderBrowserDialog();
			this.gbNamespace = new System.Windows.Forms.GroupBox();
			this.txtNameSpace = new System.Windows.Forms.TextBox();
			this.lblNamespace = new System.Windows.Forms.Label();
			this.gbCreator = new System.Windows.Forms.GroupBox();
			this.txtCreator = new System.Windows.Forms.TextBox();
			this.lblCreator = new System.Windows.Forms.Label();
			this.pbStatus = new System.Windows.Forms.PictureBox();
			this.gbLocation.SuspendLayout();
			this.gbNamespace.SuspendLayout();
			this.gbCreator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.pbStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Location = new System.Drawing.Point(12, 276);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.TabStop = false;
			this.btnCancel.Text = "&Cancel";
			// 
			// btnGenerate
			// 
			this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGenerate.Location = new System.Drawing.Point(277, 276);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.TabStop = false;
			this.btnGenerate.Text = "&Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// gbLocation
			// 
			this.gbLocation.Controls.Add(this.btnSelectFile);
			this.gbLocation.Controls.Add(this.lblPath);
			this.gbLocation.Controls.Add(this.lblSelectLocation);
			this.gbLocation.Location = new System.Drawing.Point(12, 12);
			this.gbLocation.Name = "gbLocation";
			this.gbLocation.Size = new System.Drawing.Size(340, 96);
			this.gbLocation.TabIndex = 5;
			this.gbLocation.TabStop = false;
			this.gbLocation.Text = "Save To";
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSelectFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.btnSelectFile.Location = new System.Drawing.Point(302, 61);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(28, 23);
			this.btnSelectFile.TabIndex = 0;
			this.btnSelectFile.Text = "...";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// lblPath
			// 
			this.lblPath.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblPath.Location = new System.Drawing.Point(10, 61);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(286, 23);
			this.lblPath.TabIndex = 1;
			// 
			// lblSelectLocation
			// 
			this.lblSelectLocation.Location = new System.Drawing.Point(10, 17);
			this.lblSelectLocation.Name = "lblSelectLocation";
			this.lblSelectLocation.Size = new System.Drawing.Size(320, 35);
			this.lblSelectLocation.TabIndex = 2;
			this.lblSelectLocation.Text = "Select a path to which to save the generated classes. If you leave this blank the" +
				" files will be created in the application path.";
			// 
			// fbdProcess
			// 
			this.fbdProcess.Description = "Select a folder to save the generated classes";
			// 
			// gbNamespace
			// 
			this.gbNamespace.Controls.Add(this.txtNameSpace);
			this.gbNamespace.Controls.Add(this.lblNamespace);
			this.gbNamespace.Location = new System.Drawing.Point(12, 114);
			this.gbNamespace.Name = "gbNamespace";
			this.gbNamespace.Size = new System.Drawing.Size(340, 81);
			this.gbNamespace.TabIndex = 6;
			this.gbNamespace.TabStop = false;
			this.gbNamespace.Text = "Namespace";
			// 
			// txtNameSpace
			// 
			this.txtNameSpace.Location = new System.Drawing.Point(13, 51);
			this.txtNameSpace.Name = "txtNameSpace";
			this.txtNameSpace.Size = new System.Drawing.Size(314, 21);
			this.txtNameSpace.TabIndex = 0;
			// 
			// lblNamespace
			// 
			this.lblNamespace.Location = new System.Drawing.Point(13, 17);
			this.lblNamespace.Name = "lblNamespace";
			this.lblNamespace.Size = new System.Drawing.Size(314, 31);
			this.lblNamespace.TabIndex = 1;
			this.lblNamespace.Text = "Enter a name to use as the namespace for the generated classes.";
			// 
			// gbCreator
			// 
			this.gbCreator.Controls.Add(this.txtCreator);
			this.gbCreator.Controls.Add(this.lblCreator);
			this.gbCreator.Location = new System.Drawing.Point(12, 201);
			this.gbCreator.Name = "gbCreator";
			this.gbCreator.Size = new System.Drawing.Size(340, 69);
			this.gbCreator.TabIndex = 7;
			this.gbCreator.TabStop = false;
			this.gbCreator.Text = "Creator";
			// 
			// txtCreator
			// 
			this.txtCreator.Location = new System.Drawing.Point(13, 40);
			this.txtCreator.Name = "txtCreator";
			this.txtCreator.Size = new System.Drawing.Size(314, 21);
			this.txtCreator.TabIndex = 0;
			// 
			// lblCreator
			// 
			this.lblCreator.Location = new System.Drawing.Point(13, 17);
			this.lblCreator.Name = "lblCreator";
			this.lblCreator.Size = new System.Drawing.Size(314, 20);
			this.lblCreator.TabIndex = 1;
			this.lblCreator.Text = "Enter a name to use as the name of the author/creator.";
			// 
			// pbStatus
			// 
			this.pbStatus.Image = ((System.Drawing.Image) (resources.GetObject("pbStatus.Image")));
			this.pbStatus.Location = new System.Drawing.Point(98, 276);
			this.pbStatus.Name = "pbStatus";
			this.pbStatus.Size = new System.Drawing.Size(173, 23);
			this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbStatus.TabIndex = 8;
			this.pbStatus.TabStop = false;
			this.pbStatus.Visible = false;
			// 
			// Process
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 305);
			this.Controls.Add(this.pbStatus);
			this.Controls.Add(this.gbCreator);
			this.Controls.Add(this.gbNamespace);
			this.Controls.Add(this.gbLocation);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnCancel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Process";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Process";
			this.gbLocation.ResumeLayout(false);
			this.gbNamespace.ResumeLayout(false);
			this.gbNamespace.PerformLayout();
			this.gbCreator.ResumeLayout(false);
			this.gbCreator.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.pbStatus)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.GroupBox gbLocation;
		private System.Windows.Forms.Button btnSelectFile;
		internal System.Windows.Forms.Label lblPath;
		internal System.Windows.Forms.Label lblSelectLocation;
		private System.Windows.Forms.FolderBrowserDialog fbdProcess;
		private System.Windows.Forms.GroupBox gbNamespace;
		private System.Windows.Forms.TextBox txtNameSpace;
		internal System.Windows.Forms.Label lblNamespace;
		private System.Windows.Forms.GroupBox gbCreator;
		private System.Windows.Forms.TextBox txtCreator;
		internal System.Windows.Forms.Label lblCreator;
		private System.Windows.Forms.PictureBox pbStatus;
	}
}