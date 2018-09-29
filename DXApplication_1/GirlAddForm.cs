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
using System.Data.SqlClient;

namespace DXApplication_1
{
	public partial class GirlAddForm : DevExpress.XtraEditors.XtraForm
	{
		public GirlAddForm()
		{
			InitializeComponent();
		}
		// Cancel Btn Clicked
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		// Add Btn Clicked
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			// get input 
			if (textEdit1_name.EditValue == null || textEdit2_age.EditValue == null)
			{
				MessageBox.Show("Empty Not Allowed");
				return;
			}
			var girlName = textEdit1_name.EditValue.ToString();
			var girlAge = textEdit2_age.EditValue.ToString();
			if (String.IsNullOrEmpty(girlName) || String.IsNullOrEmpty(girlAge)) {
				MessageBox.Show("Empty Not Allowed");
				return;
			}
			// insert db
			// write sql,  Server=DESKTOP-1G3JHJP;
			var connStr = "server=.;database=db5;Integrated Security=true;";
			SqlConnection conn = new SqlConnection(connStr);
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "insert into Girl values (@Name,@Age)";
			cmd.Parameters.Clear();
			cmd.Parameters.Add("@Name", girlName);
			cmd.Parameters.Add("@Age", girlAge);
			conn.Open();
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			conn.Close();
			// close form and tell parent to refresh 
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void GirlAddForm_Load(object sender, EventArgs e)
		{

		}
	}
}