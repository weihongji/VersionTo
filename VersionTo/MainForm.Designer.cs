namespace VersionTo
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.cmbVersion = new System.Windows.Forms.ComboBox();
			this.btnRunWar3 = new System.Windows.Forms.Button();
			this.btnSetting = new System.Windows.Forms.Button();
			this.lblVersion = new System.Windows.Forms.Label();
			this.chkEnforce = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// cmbVersion
			// 
			this.cmbVersion.FormattingEnabled = true;
			this.cmbVersion.Location = new System.Drawing.Point(161, 41);
			this.cmbVersion.Name = "cmbVersion";
			this.cmbVersion.Size = new System.Drawing.Size(100, 20);
			this.cmbVersion.TabIndex = 1;
			// 
			// btnRunWar3
			// 
			this.btnRunWar3.Location = new System.Drawing.Point(109, 90);
			this.btnRunWar3.Name = "btnRunWar3";
			this.btnRunWar3.Size = new System.Drawing.Size(80, 23);
			this.btnRunWar3.TabIndex = 3;
			this.btnRunWar3.Text = "&Warcraft";
			this.btnRunWar3.UseVisualStyleBackColor = true;
			this.btnRunWar3.Click += new System.EventHandler(this.btnRunWar3_Click);
			// 
			// btnSetting
			// 
			this.btnSetting.Location = new System.Drawing.Point(246, 90);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(80, 23);
			this.btnSetting.TabIndex = 4;
			this.btnSetting.Text = "S&etting...";
			this.btnSetting.UseVisualStyleBackColor = true;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Location = new System.Drawing.Point(45, 45);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(107, 12);
			this.lblVersion.TabIndex = 0;
			this.lblVersion.Text = "Warcraft Version:";
			// 
			// chkEnforce
			// 
			this.chkEnforce.AutoSize = true;
			this.chkEnforce.Location = new System.Drawing.Point(284, 43);
			this.chkEnforce.Name = "chkEnforce";
			this.chkEnforce.Size = new System.Drawing.Size(126, 16);
			this.chkEnforce.TabIndex = 2;
			this.chkEnforce.Text = "&Enforce to switch";
			this.toolTip1.SetToolTip(this.chkEnforce, "Check to enforce a version switch when [Warcraft] is clicked.\r\nIf this option is " +
        "not checked, [Warcraft] runs a version switch only when the selected version is " +
        "changed.");
			this.chkEnforce.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnRunWar3;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 181);
			this.Controls.Add(this.chkEnforce);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.btnSetting);
			this.Controls.Add(this.btnRunWar3);
			this.Controls.Add(this.cmbVersion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WarcraftIII Version Switcher";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbVersion;
		private System.Windows.Forms.Button btnRunWar3;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.CheckBox chkEnforce;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

