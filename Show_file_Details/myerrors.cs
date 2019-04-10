using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show_file_Details
{
    public static class myerrors
    {
        public static void showErrors(Exception e)
        {
            //MessageBox.Show(e.ToString());
            FileStream fs = new FileStream(@"./Log.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(System.DateTime.Now.ToString() + e.ToString()+"\n");
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
