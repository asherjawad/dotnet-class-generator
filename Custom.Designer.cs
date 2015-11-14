namespace GNR8
{
	partial class Custom
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom));
			this.btnCancel = new System.Windows.Forms.Button();
			this.dgTokens = new System.Windows.Forms.DataGridView();
			this.btnCreateOrAppend = new System.Windows.Forms.Button();
			this.ttCustom = new System.Windows.Forms.ToolTip(this.components);
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.gbAdd = new System.Windows.Forms.GroupBox();
			this.lblKeyInfo = new System.Windows.Forms.Label();
			this.lblCrLf = new System.Windows.Forms.Label();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.lblValue = new System.Windows.Forms.Label();
			this.lblKey = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) (this.dgTokens)).BeginInit();
			this.gbAdd.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Location = new System.Drawing.Point(8, 494);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "&Cancel";
			this.ttCustom.SetToolTip(this.btnCancel, "Cancel");
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// dgTokens
			// 
			this.dgTokens.AllowUserToAddRows = false;
			this.dgTokens.AllowUserToOrderColumns = true;
			this.dgTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgTokens.Location = new System.Drawing.Point(8, 12);
			this.dgTokens.MultiSelect = false;
			this.dgTokens.Name = "dgTokens";
			this.dgTokens.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgTokens.Size = new System.Drawing.Size(465, 255);
			this.dgTokens.TabIndex = 1;
			// 
			// btnCreateOrAppend
			// 
			this.btnCreateOrAppend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCreateOrAppend.Location = new System.Drawing.Point(384, 160);
			this.btnCreateOrAppend.Name = "btnCreateOrAppend";
			this.btnCreateOrAppend.Size = new System.Drawing.Size(75, 23);
			this.btnCreateOrAppend.TabIndex = 2;
			this.btnCreateOrAppend.Text = "&Save";
			this.ttCustom.SetToolTip(this.btnCreateOrAppend, "Add/Update a new custom token");
			this.btnCreateOrAppend.UseVisualStyleBackColor = true;
			this.btnCreateOrAppend.Click += new System.EventHandler(this.btnCreateOrAppend_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Location = new System.Drawing.Point(317, 494);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "&Delete";
			this.ttCustom.SetToolTip(this.btnDelete, "Delete selected item");
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEdit.Location = new System.Drawing.Point(398, 494);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 4;
			this.btnEdit.Text = "&Edit";
			this.ttCustom.SetToolTip(this.btnEdit, "Edit selected item");
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// gbAdd
			// 
			this.gbAdd.Controls.Add(this.lblKeyInfo);
			this.gbAdd.Controls.Add(this.lblCrLf);
			this.gbAdd.Controls.Add(this.txtValue);
			this.gbAdd.Controls.Add(this.txtKey);
			this.gbAdd.Controls.Add(this.lblValue);
			this.gbAdd.Controls.Add(this.lblKey);
			this.gbAdd.Controls.Add(this.btnCreateOrAppend);
			this.gbAdd.Location = new System.Drawing.Point(8, 273);
			this.gbAdd.Name = "gbAdd";
			this.gbAdd.Size = new System.Drawing.Size(465, 215);
			this.gbAdd.TabIndex = 0;
			this.gbAdd.TabStop = false;
			this.gbAdd.Text = "Add a new item";
			// 
			// lblKeyInfo
			// 
			this.lblKeyInfo.Location = new System.Drawing.Point(67, 42);
			this.lblKeyInfo.Name = "lblKeyInfo";
			this.lblKeyInfo.Size = new System.Drawing.Size(278, 32);
			this.lblKeyInfo.TabIndex = 9;
			this.lblKeyInfo.Text = "Ensure that you wrap keys with {} inside the template but they do not need to be " +
				"added here.";
			// 
			// lblCrLf
			// 
			this.lblCrLf.Location = new System.Drawing.Point(67, 160);
			this.lblCrLf.Name = "lblCrLf";
			this.lblCrLf.Size = new System.Drawing.Size(296, 44);
			this.lblCrLf.TabIndex = 8;
			this.lblCrLf.Text = "If you add {0} to the value it will translated as a cr\\lf.\r\nIf you add {1} to the" +
				" value it will be translated as a tab.\r\nYou can add as many of each as required." +
				"";
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(67, 77);
			this.txtValue.MaxLength = 1000;
			this.txtValue.Multiline = true;
			this.txtValue.Name = "txtValue";
			this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtValue.Size = new System.Drawing.Size(392, 76);
			this.txtValue.TabIndex = 1;
			// 
			// txtKey
			// 
			this.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtKey.Location = new System.Drawing.Point(67, 18);
			this.txtKey.MaxLength = 100;
			this.txtKey.Name = "txtKey";
			this.txtKey.Size = new System.Drawing.Size(278, 21);
			this.txtKey.TabIndex = 0;
			// 
			// lblValue
			// 
			this.lblValue.AutoSize = true;
			this.lblValue.Location = new System.Drawing.Point(7, 77);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(37, 13);
			this.lblValue.TabIndex = 7;
			this.lblValue.Text = "Value:";
			// 
			// lblKey
			// 
			this.lblKey.AutoSize = true;
			this.lblKey.Location = new System.Drawing.Point(7, 21);
			this.lblKey.Name = "lblKey";
			this.lblKey.Size = new System.Drawing.Size(29, 13);
			this.lblKey.TabIndex = 6;
			this.lblKey.Text = "Key:";
			// 
			// Custom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(481, 523);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.gbAdd);
			this.Controls.Add(this.dgTokens);
			this.Controls.Add(this.btnCancel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Custom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Custom";
			((System.ComponentModel.ISupportInitialize) (this.dgTokens)).EndInit();
			this.gbAdd.ResumeLayout(false);
			this.gbAdd.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.DataGridView dgTokens;
		private System.Windows.Forms.ToolTip ttCustom;
		private System.Windows.Forms.Button btnCreateOrAppend;
		private System.Windows.Forms.GroupBox gbAdd;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.TextBox txtKey;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.Label lblKey;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Label lblCrLf;
		private System.Windows.Forms.Label lblKeyInfo;
	}
}