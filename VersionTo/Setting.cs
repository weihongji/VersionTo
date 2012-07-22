using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VersionTo
{
	class Setting
	{
		public static String Get(String key) {
			String value = "";
			if (File.Exists("config.ini")) {
				if (key[0] != '[') {
					key = "[" + key + "]";
				}
				StreamReader sr = new StreamReader("config.ini");
				String lineText;
				while (!sr.EndOfStream) {
					lineText = sr.ReadLine();
					if (lineText.IndexOf(key) == 0 && !sr.EndOfStream) {
						value = sr.ReadLine();
						break;
					}
				}
				sr.Close();
			}
			return value;
		}

		public static bool Set(String key, String value) {
			bool success = false;
			if (!File.Exists("config.ini")) { // Create this file if not exist
				StreamWriter sw = new StreamWriter("config.ini");
				sw.Write("");
				sw.Close();
			}
			if (key[0] != '[') {
				key = "[" + key + "]";
			}
			StreamReader sr = new StreamReader("config.ini");
			StringBuilder sb = new StringBuilder(100);
			String lineText;
			while (!sr.EndOfStream) {
				lineText = sr.ReadLine();
				sb.AppendLine(lineText);
				if (lineText.IndexOf(key) == 0 && !sr.EndOfStream) {
					sr.ReadLine();
					sb.AppendLine(value);
					success = true;
				}
			}
			sr.Close();
			if (success) {
				StreamWriter sw = new StreamWriter("config.ini", false);
				sw.Write(sb.ToString());
				sw.Close();
			}
			else { // No such a section, just add it.
				StreamWriter sw = new StreamWriter("config.ini", true);
				sw.WriteLine(key);
				sw.WriteLine(value);
				sw.WriteLine();
				sw.Close();
				success = true;
			}
			return success;
		}
	}
}
