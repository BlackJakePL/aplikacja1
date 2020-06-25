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
using System.Drawing.Printing;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.Threading;

namespace aplikacja
{
    public partial class Form1 : Form
    {
       
        XImage photo,photo1,photo2;
        XImage background = XImage.FromFile("Resources\\tlo.jpg");
        string fname;

        public Form1()
        {
            InitializeComponent();
        }


        private void Create_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPhoto_Click(object sender, EventArgs e)
        {
            var fileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //filePath = openFileDialog1.FileName;
                this.photo = XImage.FromFile(openFileDialog1.FileName);
                addUser.Enabled = true;
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {

            DateTime thisDay = DateTime.Today;
            string today = thisDay.ToString("dd/MM/yyyy");
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            page.Width = 1181;
            page.Height = 1748;
            XGraphics gfx = XGraphics.FromPdfPage(page);
            int width = this.photo.PixelWidth;
            int height = this.photo.PixelHeight;

            XFont font = new XFont("Spaceman", 32, XFontStyle.BoldItalic);
            XFont fontD = new XFont("Spaceman", 16, XFontStyle.BoldItalic);

            string subPath = "C:\\pdf\\";

            if (!Directory.Exists(subPath))
            {
               Directory.CreateDirectory(subPath);
            }
            
            if(!(textName.Text==""))
            {
                gfx.DrawImage(this.background, 0, 0, 1163, 587);
                gfx.DrawString(textName.Text , font, XBrushes.White,
                    new XRect(200, 365, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawImage(this.photo, 855, 190, 270, 350);
                gfx.DrawString(today, fontD, XBrushes.MediumBlue,
                    new XRect(260, 545, page.Width, page.Height), XStringFormats.TopLeft);
                addUser.Enabled = true;
            }
            if (!(textName1.Text == ""))
            {
                gfx.DrawImage(this.background, 0, 587, 1163, 587);
                gfx.DrawString(textName1.Text, font, XBrushes.White,
                    new XRect(200, 952, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawImage(this.photo1, 855, 777, 270, 350);
                gfx.DrawString(today, fontD, XBrushes.MediumBlue,
                    new XRect(260, 1132, page.Width, page.Height), XStringFormats.TopLeft);
                addUser.Enabled = true;
            }
            if (!(textName2.Text == ""))
            {
                gfx.DrawImage(this.background, 0, 1174, 1163, 587);
                gfx.DrawString(textName2.Text, font, XBrushes.White,
                    new XRect(200, 1539, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawImage(this.photo2, 855, 1364, 270, 350);
                gfx.DrawString(today, fontD, XBrushes.MediumBlue,
                    new XRect(260, 1719, page.Width, page.Height), XStringFormats.TopLeft);
                addUser.Enabled = true;
            }

            string filename = "C:\\pdf\\" + textName.Text + textName1.Text+textName2.Text ;
            while(File.Exists(filename+".pdf"))
            {
                filename = filename + "1";
            }
            fname = filename + ".pdf";
            document.Save(filename+".pdf");
            MessageBox.Show("Utworzono dokument w: " + filename + ".pdf");
           
            print.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lLastName_Click(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {

            string Filepath = @fname;

            using (PrintDialog Dialog = new PrintDialog())
            {
                Dialog.ShowDialog();

                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = Filepath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process printProcess = new Process();
                printProcess.StartInfo = printProcessInfo;
                printProcess.Start();

                printProcess.WaitForInputIdle();

                Thread.Sleep(3000);

                if (false == printProcess.CloseMainWindow())
                {
                    printProcess.Kill();
                }

            }
        }
        private void addPhoto1_Click(object sender, EventArgs e)
        {
            var fileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //filePath = openFileDialog1.FileName;
                this.photo1 = XImage.FromFile(openFileDialog1.FileName);
                addUser.Enabled = true;
            }
        }

        private void addPhoto2_Click(object sender, EventArgs e)
        {
            var fileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //filePath = openFileDialog1.FileName;
                this.photo2 = XImage.FromFile(openFileDialog1.FileName);
                addUser.Enabled = true;
            }
        }
    }
}
