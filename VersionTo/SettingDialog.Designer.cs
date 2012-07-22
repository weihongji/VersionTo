namespace VersionTo
{
	partial class SettingDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingDialog));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWarFolder = new System.Windows.Forms.TextBox();
			this.txtPatchFolder = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnBrowseWarcraft = new System.Windows.Forms.Button();
			this.btnBrowsePatches = new System.Windows.Forms.Button();
			this.btnMore = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Warcraft folder:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Patches folder:";
			// 
			// txtWarFolder
			// 
			this.txtWarFolder.Location = new System.Drawing.Point(144, 35);
			this.txtWarFolder.Name = "txtWarFolder";
			this.txtWarFolder.Size = new System.Drawing.Size(247, 21);
			this.txtWarFolder.TabIndex = 1;
			// 
			// txtPatchFolder
			// 
			this.txtPatchFolder.Location = new System.Drawing.Point(144, 75);
			this.txtPatchFolder.Name = "txtPatchFolder";
			this.txtPatchFolder.Size = new System.Drawing.Size(247, 21);
			this.txtPatchFolder.TabIndex = 4;
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(137, 137);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(250, 137);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// btnBrowseWarcraft
			// 
			this.btnBrowseWarcraft.Location = new System.Drawing.Point(394, 33);
			this.btnBrowseWarcraft.Name = "btnBrowseWarcraft";
			this.btnBrowseWarcraft.Size = new System.Drawing.Size(37, 23);
			this.btnBrowseWarcraft.TabIndex = 2;
			this.btnBrowseWarcraft.Text = "...";
			this.btnBrowseWarcraft.UseVisualStyleBackColor = true;
			this.btnBrowseWarcraft.Click += new System.EventHandler(this.btnBrowseWarcraft_Click);
			// 
			// btnBrowsePatches
			// 
			this.btnBrowsePatches.Location = new System.Drawing.Point(394, 73);
			this.btnBrowsePatches.Name = "btnBrowsePatches";
			this.btnBrowsePatches.Size = new System.Drawing.Size(37, 23);
			this.btnBrowsePatches.TabIndex = 5;
			this.btnBrowsePatches.Text = "...";
			this.btnBrowsePatches.UseVisualStyleBackColor = true;
			this.btnBrowsePatches.Click += new System.EventHandler(this.btnBrowsePatches_Click);
			// 
			// btnMore
			// 
			this.btnMore.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnMore.Location = new System.Drawing.Point(363, 137);
			this.btnMore.Name = "btnMore";
			this.btnMore.Size = new System.Drawing.Size(75, 23);
			this.btnMore.TabIndex = 8;
			this.btnMore.Text = "&More...";
			this.btnMore.UseVisualStyleBackColor = true;
			this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
			// 
			// SettingDialog
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(489, 195);
			this.Controls.Add(this.btnMore);
			this.Controls.Add(this.btnBrowsePatches);
			this.Controls.Add(this.btnBrowseWarcraft);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPatchFolder);
			this.Controls.Add(this.txtWarFolder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtWarFolder;
		private System.Windows.Forms.TextBox txtPatchFolder;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnBrowseWarcraft;
		private System.Windows.Forms.Button btnBrowsePatches;
		private System.Windows.Forms.Button btnMore;
	}
}