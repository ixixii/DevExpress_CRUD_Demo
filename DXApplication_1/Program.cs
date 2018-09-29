using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.IO;

namespace DXApplication_1
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			BonusSkins.Register();
			SkinManager.EnableFormSkins();
			UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
			// read login state
			if (File.Exists("login.txt")) {
				var savedStr = File.ReadAllText("login.txt");
				if (savedStr == "HasLogin")
				{
					Application.Run(new GirlListForm());
					return;
				}
			}
			
			LoginForm loginForm = new LoginForm();
			loginForm.ShowDialog();
			if (loginForm.DialogResult == DialogResult.OK) {
				Application.Run(new GirlListForm());
			}
		}
	}
}
