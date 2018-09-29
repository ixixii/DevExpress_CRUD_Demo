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
	public partial class GirlEditForm : DevExpress.XtraEditors.XtraForm
	{
		public string ID { get; set; }
		public GirlEditForm()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void GirlEditForm_Load(object sender, EventArgs e)
		{
			// connect to sql
			var connStr = "server=.;database=db5;Integrated Security=true;";
			SqlConnection conn = new SqlConnection(connStr);
			// select by idstr
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "select ID,Name,Age from Girl where ID=@ID";
			cmd.Parameters.Clear();
			cmd.Parameters.Add("@ID", this.ID);
			conn.Open();
			//------------------
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.HasRows) {
				while (reader.Read()) {
					// bind value
					textEdit1.EditValue = reader["ID"].ToString();
					textEdit2.EditValue = reader["Name"].ToString();
					textEdit3.EditValue = reader["Age"].ToString();
				}
			}
			//------------------
			cmd.Dispose();
			conn.Close();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			// connect to sql
			var connStr = "server=.;database=db5;Integrated Security=true;";
			SqlConnection conn = new SqlConnection(connStr);
			// select by idstr
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "update Girl set Name = @Name,Age = @Age where ID=@ID";
			cmd.Parameters.Clear();
			cmd.Parameters.Add("@ID", this.ID);
			cmd.Parameters.Add(@"Name", textEdit2.EditValue);
			cmd.Parameters.Add(@"Age", textEdit3.EditValue);
			conn.Open();
			//------------------
			cmd.ExecuteNonQuery();
			//------------------
			// close form and tell parent to refresh 
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}