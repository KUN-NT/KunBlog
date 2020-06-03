using System;
using System.Linq;

namespace GenerateModelTool
{
    public static class StringHelper
    {
        public static string GetColumnType(this string dataType)
        {
            string columnType = "";
            switch (dataType.ToLower())
            {
                case "varchar":
                    columnType = "String";
                    break;
                case "datetime":
                    columnType = "DateTime?";
                    break;
                default:
                    columnType = "String";
                    break;
            }
            return columnType;
        }

        /// <summary>
        /// 首字母小写
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string FirstCharToLower(this string input)
        {
            if (String.IsNullOrEmpty(input))
                return input;
            string str = input.First().ToString().ToLower() + input.Substring(1);
            return str;
        }

        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string FirstCharToUpper(this string input)
        {
            if (String.IsNullOrEmpty(input))
                return input;
            string str = input.First().ToString().ToUpper() + input.Substring(1);
            return str;
        }
    }
}
