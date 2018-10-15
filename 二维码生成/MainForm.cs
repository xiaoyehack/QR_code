using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using ZXing.Common;
using ZXing.Rendering;
using System.Drawing.Imaging;
using System.Threading;

namespace 二维码生成
{
    public partial class MainForm : Form
    {
        EncodingOptions Options = null;
        BarcodeWriter Write = null;
        public MainForm()
        {
            InitializeComponent();

            Options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = codePictureBox.Width,
                Height = codePictureBox.Height
            };
            Write = new BarcodeWriter();
            Write.Format = BarcodeFormat.QR_CODE;
            Write.Options = Options;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static void Create_Qcode(string prefix,string SaveName)
        {

            string code_content = prefix + SaveName;
            //配置文件生成路径
            string FileName = System.Environment.CurrentDirectory + "\\Data\\";
            BarcodeWriter Write = new BarcodeWriter();
            Write.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions Options = new QrCodeEncodingOptions();

            Options.DisableECI = true;

            //设置内容编码

            Options.CharacterSet = "UTF-8";

            //设置二维码宽度和高度

            Options.Width = 400;
            Options.Height = 400;

            //设置二维码边距
            Options.Margin = 1;
            Write.Options = Options;
            Bitmap PicQcode = Write.Write(code_content.ToLower());   
                  
            FileName = FileName + SaveName.ToLower()+".png";
            PicQcode.Save(FileName,ImageFormat.Png);
            PicQcode.Dispose();  

        }

 

        private void DisplayQcrod_Click(object sender, EventArgs e)
        {
            try
            {
                if (QcodeIdBox.Text == string.Empty)
                {
                    MessageBox.Show("输入内容不能为空");
                    return;
                }
                Bitmap bitmap = Write.Write(IdPrefixBox.Text + QcodeIdBox.Text);
                codePictureBox.Image = bitmap;
            }
            catch
            {


            }
        }

        private void Qcord_GenerateBut_Click(object sender, EventArgs e)
        {
            QcodeProductionBar.Value = 0;
            label5.Text = "";

            if (0 != QcodeIdBox.TextLength)
            {

                if (0 != QcodeNumbox.TextLength)
                {
                    int Qcode_Num = int.Parse(QcodeNumbox.Text);
                    if (Qcode_Num < 10000)
                    {
                        string Qcode_String = QcodeIdBox.Text;
                        int Qcode_Count = int.Parse(QcodeNumbox.Text);
                        int QcodeContent_Lenght = QcodeIdBox.TextLength;
                        QcodeProductionBar.Maximum = Qcode_Count;
                        QcodeProductionBar.Minimum = 0;

                        try
                        {
                            for (int i = 0; i < Qcode_Count; i++)
                            {
                                
                                Application.DoEvents();//实时响应文本框中的值
                                
                                Create_Qcode(IdPrefixBox.Text, Qcode_String);
                                Qcode_String = (Convert.ToInt64(Qcode_String, 16) + 0x01).ToString("X2");
                                QcodeIdBox.Text = Qcode_String.ToString().PadLeft(QcodeContent_Lenght, '0');
                                Qcode_String = Qcode_String.PadLeft(QcodeContent_Lenght, '0');
                                QcodeProductionBar.Value = i + 1;
                                label5.Text = (QcodeProductionBar.Value * 100 / QcodeProductionBar.Maximum).ToString() + "%";
                            }
                            Bitmap bitmap = Write.Write(IdPrefixBox.Text + QcodeIdBox.Text);
                            codePictureBox.Image = bitmap;

                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("每次能生成数量最多为10000", "提示");
                    }

                }
                else
                {
                    MessageBox.Show("请检查二维码生成数量", "提示");
                }
            }
            else
            {
                MessageBox.Show("内容不能为空", "提示");
            }
        }
    }
}
