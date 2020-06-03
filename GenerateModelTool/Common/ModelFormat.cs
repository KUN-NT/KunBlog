using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GenerateModelTool
{
    public class ModelFormat
    {
        public static void GetModel(string nameSpace, string path, string tableName, string sql)
        {
            var model = DataHelper.GetTable(sql);
            var myTableName = tableName.Split('_');
            var thisName = "";
            foreach (var name in myTableName)
            {
                thisName += name.FirstCharToUpper();
            }
            string modelStr = CreateModel(nameSpace, thisName, model);
            SaveFile(modelStr, thisName, path);
        }

        public static void SaveFile(string fileContent, string fileName, string dicPath)
        {
            if (string.IsNullOrEmpty(dicPath))
            {
                MessageBox.Show("文件保存路径为空");
                return;
            }
            var filePath = dicPath + fileName + ".cs";
            try
            {
                if (!File.Exists(filePath))
                {
                    FileStream fs1 = new FileStream(filePath, FileMode.Create, FileAccess.Write);//创建写入文件 
                    StreamWriter sw = new StreamWriter(fs1);
                    sw.WriteLine(fileContent);//开始写入值
                    sw.Close();
                    fs1.Close();
                }
                else
                {
                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                    StreamWriter sr = new StreamWriter(fs);
                    sr.WriteLine(fileContent);//开始写入值
                    sr.Close();
                    fs.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string CreateModel(string nameSpace, string tableName, DataTable model)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.ComponentModel.DataAnnotations;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("");
            sb.AppendLine($"namespace {nameSpace}");
            sb.AppendLine("{");
            sb.AppendLine($"\tpublic class {tableName}");
            sb.AppendLine("\t{");
            foreach (DataRow row in model.Rows)
            {
                var COLUMN_NAME = row.ItemArray[0].ToString();
                var DATA_TYPE = row.ItemArray[1].ToString();
                var COLUMN_TYPE = DATA_TYPE.GetColumnType();
                var COLUMN_LENGTH = row.ItemArray[2].ToString();
                var COLUMN_COMMENT = row.ItemArray[3].ToString();
                var COLUMN_KEY = row.ItemArray[4].ToString().ToUpper();
                
                sb.AppendLine($"\t\t//{(string.IsNullOrEmpty(COLUMN_COMMENT) ? COLUMN_NAME : COLUMN_COMMENT)}");
                if (COLUMN_KEY.Equals("PRI"))
                {
                    sb.AppendLine("\t\t[Key]");
                }
                if (COLUMN_TYPE.Equals("String"))
                {
                    sb.AppendLine($"\t\t[MaxLength({COLUMN_LENGTH})]");
                }
                sb.AppendLine($"\t\tpublic {COLUMN_TYPE} {COLUMN_NAME} {{get;set;}}\r\n");

            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
