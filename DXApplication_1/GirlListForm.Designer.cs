namespace DXApplication_1
{
	partial class GirlListForm
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
			DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
			DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirlListForm));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemHyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
			this.repositoryItemHyperLinkDel = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkDel)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.DataMember = "Girl";
			this.gridControl1.DataSource = this.sqlDataSource1;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit,
            this.repositoryItemHyperLinkDel});
			this.gridControl1.Size = new System.Drawing.Size(1248, 400);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "localhost_db5_Connection";
			this.sqlDataSource1.Name = "sqlDataSource1";
			columnExpression1.ColumnName = "ID";
			table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"230\" />";
			table1.Name = "Girl";
			columnExpression1.Table = table1;
			column1.Expression = columnExpression1;
			columnExpression2.ColumnName = "Name";
			columnExpression2.Table = table1;
			column2.Expression = columnExpression2;
			columnExpression3.ColumnName = "Age";
			columnExpression3.Table = table1;
			column3.Expression = columnExpression3;
			selectQuery1.Columns.Add(column1);
			selectQuery1.Columns.Add(column2);
			selectQuery1.Columns.Add(column3);
			selectQuery1.Name = "Girl";
			selectQuery1.Tables.Add(table1);
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colAge});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colID
			// 
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.Visible = true;
			this.colID.VisibleIndex = 0;
			// 
			// colName
			// 
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 1;
			// 
			// colAge
			// 
			this.colAge.FieldName = "Age";
			this.colAge.Name = "colAge";
			this.colAge.Visible = true;
			this.colAge.VisibleIndex = 2;
			// 
			// repositoryItemHyperLinkEdit
			// 
			this.repositoryItemHyperLinkEdit.AutoHeight = false;
			this.repositoryItemHyperLinkEdit.Name = "repositoryItemHyperLinkEdit";
			this.repositoryItemHyperLinkEdit.NullText = "Edit";
			this.repositoryItemHyperLinkEdit.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit_Click);
			// 
			// repositoryItemHyperLinkDel
			// 
			this.repositoryItemHyperLinkDel.AutoHeight = false;
			this.repositoryItemHyperLinkDel.Name = "repositoryItemHyperLinkDel";
			this.repositoryItemHyperLinkDel.NullText = "Delete";
			this.repositoryItemHyperLinkDel.Click += new System.EventHandler(this.repositoryItemHyperLinkDel_Click);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(1103, 406);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(121, 51);
			this.simpleButton1.TabIndex = 1;
			this.simpleButton1.Text = "Logout";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(917, 406);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(123, 51);
			this.simpleButton2.TabIndex = 2;
			this.simpleButton2.Text = "Add";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// simpleButton3
			// 
			this.simpleButton3.Location = new System.Drawing.Point(717, 406);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new System.Drawing.Size(123, 51);
			this.simpleButton3.TabIndex = 3;
			this.simpleButton3.Text = "Refresh";
			this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
			// 
			// GirlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1250, 467);
			this.Controls.Add(this.simpleButton3);
			this.Controls.Add(this.simpleButton2);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.gridControl1);
			this.Name = "GirlForm";
			this.Text = "GirlForm";
			this.Load += new System.EventHandler(this.GirlForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkDel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colAge;
		private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkDel;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton simpleButton3;
	}
}