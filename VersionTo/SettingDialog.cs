using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VersionTo
{
	public partial class SettingDialog : Form
	{
		public SettingDialog() {
			InitializeComponent();
		}

		private void SettingForm_Load(object sender, EventArgs e) {
			LoadSettings();
		}

		private void btnBrowseWarcraft_Click(object sender, EventArgs e) {
			folderBrowserDialog1.SelectedPath = txtWarFolder.Text;
			folderBrowserDialog1.ShowDialog();
			txtWarFolder.Text = folderBrowserDialog1.SelectedPath;
		}

		private void btnBrowsePatches_Click(object sender, EventArgs e) {
			folderBrowserDialog1.SelectedPath = txtPatchFolder.Text;
			folderBrowserDialog1.ShowDialog();
			txtPatchFolder.Text = folderBrowserDialog1.SelectedPath;
		}

		private void btnSave_Click(object sender, EventArgs e) {
			if (!Directory.Exists(txtWarFolder.Text)) {
				MessageBox.Show("Warcraft folder does not exist.", "VersionTo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtWarFolder.Focus();
				this.DialogResult = DialogResult.None;
				return;
			}
			if (!Directory.Exists(txtPatchFolder.Text)) {
				MessageBox.Show("Patches folder does not exist.", "VersionTo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtWarFolder.Focus();
				this.DialogResult = DialogResult.None;
				return;
			}
			Setting.Set("Warcraft", txtWarFolder.Text);
			Setting.Set("Patches", txtPatchFolder.Text);
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			if (txtWarFolder.Text != Setting.Get("Warcraft") || txtPatchFolder.Text != Setting.Get("Patches")) {
				DialogResult result = MessageBox.Show("Quit without saving your changes?\t", "VersionTo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (result == DialogResult.No) {
					this.DialogResult = DialogResult.None;
				}
			}
		}

		private void btnMore_Click(object sender, EventArgs e) {
			Process process = new Process();
			process.StartInfo.FileName = "notepad.exe";
			process.StartInfo.Arguments = "config.ini";
			process.Start();
			process.WaitForExit();
			process.Close();

			// Update settings on the form
			LoadSettings();
		}

		private void LoadSettings() {
			txtWarFolder.Text = Setting.Get("Warcraft");
			txtPatchFolder.Text = Setting.Get("Patches");
		}
	}
}