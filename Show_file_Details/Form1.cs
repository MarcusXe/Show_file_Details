using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using dbutil;


namespace Show_file_Details
{
    public partial class search_bt : Form
    {
        public search_bt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);//拖放的多个文件的路径列表
            this.filePath_tb.Text = filePaths[0];

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;//调用DragDrop事件
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                filePath_tb.Text = openFileDialog1.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.FileInfo file = new System.IO.FileInfo(filePath_tb.Text);

                fileName_tb.Text = file.Name;//文件名
                fileExt_tb.Text = file.Extension;
                fileSize_tb.Text = file.Length.ToString();//大小",
                file.LastAccessTime.ToString();//最后访问时间
                file.LastWriteTime.ToString();//最后修改时间
                DirName_tb.Text = file.DirectoryName;//路径
                dbutil.initConn();
                //file.
                FileStream fs = new FileStream(filePath_tb.Text, FileMode.Open);
                byte[] data = new byte[50];
                fs.Read(data, 0, 50);
                string t = file_info.ToHexString(data);
                if (file_info.ToHexString(data).ToLower().StartsWith(file_info.getIdCodeFromJson(file.Extension.Substring(1)).ToLower()))
                {
                    truetype_tb.Text = file.Extension;
                }
                fs.Close();
                //errorLog_lb.Text = file_info.ToHexString(data);
            }
            catch (Exception e1)
            {
                //errorLog_lb.Text = e1.ToString();
                //FileStream fs = new FileStream(filePath_tb.Text, FileMode.Open);
                myerrors.showErrors(e1);
               // Console.WriteLine(e1);
            }
        }
    }
}
