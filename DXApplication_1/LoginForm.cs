using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace DXApplication_1
{
	public partial class LoginForm : DevExpress.XtraEditors.XtraForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			var userName = textEdit1.EditValue.ToString();
			var password = textEdit2.EditValue.ToString();
			if (userName == "beyond" && password =="123456") {
				// save login state
				File.AppendAllText("login.txt", "HasLogin");

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else {
				MessageBox.Show("username or password is wrong");	
			}
			
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}
	}
}