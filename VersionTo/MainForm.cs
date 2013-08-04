using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VersionTo
{
	public partial class MainForm : Form
	{
		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			// Check the config file
			if (!File.Exists("config.ini")) {
				Setting.Set("[Warcraft]", @"D:\Warcraft III");
				Setting.Set("[Patches]", @"D:\RepKing\Data\Patches");
				Setting.Set("[7-zip]", "7z.exe");
			}
			String firstRun = Setting.Get("FirstRun");
			if (firstRun == "" || firstRun.ToUpper() == "TRUE") {
				Setting.Set("[FirstRun]", "FALSE");
				// This is the first time user runs this tool. So, show user the setting dialog.
				btnSetting_Click(null, null);
			}

			// Initialize version combo box and set the default selection.
			LoadVersions();
		}

		private void SwitchVersion(bool force = false) {
			if (!force) {
				String lastPatch = Setting.Get("LastPatch");
				if (string.Compare(lastPatch, cmbVersion.Text, true) == 0) {
					return; // Switch isn't needed if the selected version hasn't been changed.
				}
			}

			String zipAppPath = Setting.Get("7-zip");
			String warcraftPath = Setting.Get("Warcraft");
			String patchPath = Setting.Get("Patches");

			if (patchPath.Length > 0 && patchPath[patchPath.Length - 1] != '\\') {
				patchPath += "\\";
			}
			patchPath = patchPath + cmbVersion.Text + ".zip";
			if (!File.Exists(patchPath)) {
				MessageBox.Show("Patch for selected version is not found.", "VersionTo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!File.Exists(zipAppPath)) {
				MessageBox.Show("Zip application is not found.", "VersionTo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Directory.Exists(warcraftPath)) {
				MessageBox.Show("Warcraft path \"" + warcraftPath + "\" is not found.", "VersionTo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Process process = new Process();
			process.StartInfo.FileName = zipAppPath;
			process.StartInfo.Arguments = " x \"" + patchPath + "\" -y -o\"" + warcraftPath + "\"";
			process.Start();
			process.WaitForExit();
			process.Close();

			//Update "LastPatch" section in the config file
			Setting.Set("LastPatch", cmbVersion.Text);
		}

		private void btnRunWar3_Click(object sender, EventArgs e) {
			// Switch to the selected version
			SwitchVersion(chkEnforce.Checked);

			// Run the game
			String warcraftPath = Setting.Get("Warcraft");
			if (warcraftPath.Length > 0 && warcraftPath[warcraftPath.Length - 1] != '\\') {
				warcraftPath += "\\";
			}
			warcraftPath = warcraftPath + "Frozen Throne.exe";
			if (!File.Exists(warcraftPath)) {
				MessageBox.Show("Warcraft \"" + warcraftPath + "\" is not found.", "VersionTo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Process process = new Process();
			process.StartInfo.FileName = warcraftPath;
			process.Start();
			process.Close();
		}

		private void btnSetting_Click(object sender, EventArgs e) {
			SettingDialog frmSetting = new SettingDialog();
			DialogResult result = frmSetting.ShowDialog();
			if (result == DialogResult.OK) { // Refresh this form according to "new" settings.
				LoadVersions();
			}
		}

		private void LoadVersions() {
			String patchPath = Setting.Get("Patches");
			if (Directory.Exists(patchPath)) {
				String[] patches = Directory.GetFiles(patchPath, "*.zip");
				for (int i = 0; i < patches.Length; i++) {
					patches[i] = patches[i].Substring(0, patches[i].Length - 4).Substring(patches[i].LastIndexOf("\\") + 1);
				}
				cmbVersion.DataSource = patches;
				String lastPatch = Setting.Get("LastPatch");
				int defaultIndex = cmbVersion.FindString(lastPatch);
				if (defaultIndex >= 0) {
					cmbVersion.SelectedIndex = defaultIndex;
				}
			}
		}
	}
}