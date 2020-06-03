using System;
using System.Windows.Forms;

namespace GenerateModelTool
{
    public partial class TableHome : Form
    {
        string dataBaseName;
        public TableHome(string dataBaseName)
        {
            InitializeComponent();
            this.dataBaseName = dataBaseName;
            string sql = $"select table_name from information_schema.tables where table_schema='{dataBaseName}'";
            this.dataGridView1.DataSource = DataHelper.GetTable(sql);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            labFinish.Text = "";
            foreach (DataGridViewTextBoxCell currentTable in dataGridView1.SelectedCells)
            {
                string tableName = currentTable.Value.ToString();
                string sql = $"select COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,COLUMN_COMMENT,COLUMN_KEY from information_schema.columns where table_schema = '{this.dataBaseName}' and table_name = '{tableName}'";
                ModelFormat.GetModel(txtNameSpace.Text, txtPath.Text, tableName, sql);
            }
            labFinish.Text = "Success";
        }

        private void TableHome_Load(object sender, EventArgs e)
        {
            txtNameSpace.Text = "KunBlog.SDM.Models";
            txtPath.Text = @"E:\MyCode\KunBlog\Models\";
        }
    }
}
