using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Show_file_Details
{
    static class file_info
    {
        public static string getFileName(string filePath)
        {
            return filePath.Substring(filePath.LastIndexOf("\\") + 1, (filePath.LastIndexOf(".") - filePath.LastIndexOf("\\") - 1));
        }
        public static string getFileExt(string filePath)
        {
            return filePath.Substring(filePath.LastIndexOf(".") + 1, (filePath.Length - filePath.LastIndexOf(".") - 1));
        }
        public static string ToHexString(byte[] bytes) // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                }
                hexString = strB.ToString();
            }
            return hexString;
        }
       public static string getIdCodeFromJson(String fileType)
        {
            // return
            try
            {
                JObject jo = (JObject)JsonConvert.DeserializeObject(new StreamReader(@"C:\Users\wdcsz\source\repos\Show_file_Details\Show_file_Details\data.json").ReadToEnd());
                return (jo[fileType.ToLower()]["idCode"].ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
