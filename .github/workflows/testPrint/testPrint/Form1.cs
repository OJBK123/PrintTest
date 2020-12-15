using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
 

namespace testPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listdata = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            int a=0;
                listdata.Clear();
                listdata.Add("这是第一张卡片");
                listdata.Add("这是第二张卡片");
                //listdata.Add("3");
                //listdata.Add("4");
                //listdata.Add("5");
                //listdata.Add("6");
                //listdata.Add("7");
                //listdata.Add("8");
                if (comboBox1.Text.Trim() != "")
                    printDocument1.PrinterSettings.PrinterName = comboBox1.Text.Trim();
                else
                printDocument1.PrinterSettings.PrinterName = "Zebra P330i Card Printer USB";
//
                
                if (txtW.Text==""||txtH.Text=="")
                {
                    MessageBox.Show("输入高宽");
                    return;
                }
                if (checkBox1.Checked)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom Size", Convert.ToInt32(txtW.Text), Convert.ToInt32(txtH.Text));
                }
                else
                {
                    printDocument1.DefaultPageSettings.PaperSize = GetPrintSetting(printDocument1.PrinterSettings.PrinterName,Convert.ToInt32( txtW.Text), Convert.ToInt32( txtH .Text));
                }
                if (checkBox3.Checked)
                {
                    printDocument1.DefaultPageSettings.Landscape = true;
                }

               if( MessageBox.Show("选中的纸为" + printDocument1.DefaultPageSettings.PaperSize.PaperName, "提示", MessageBoxButtons.YesNo)==DialogResult.No)
               {
                   return;
               }
                if(checkBox2.Checked)
                {
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    printDocument1.Print();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public PaperSize GetPrintSetting(string PrinterName, int width, int height)
        {
            foreach (string sPrint in PrinterSettings.InstalledPrinters)
            {
                if (sPrint == PrinterName)
                {
                    foreach (PaperSize ps in printDocument1.PrinterSettings.PaperSizes)
                    {
                        if (Math.Abs(ps.Width - width) < 10)
                        {
                            if (Math.Abs(ps.Height - height) < 10)
                            {
                                return ps;
                            }
                        }
                    }
                }
            }
            return new PaperSize("Custom Size", width, height);
        }
        public void GetPrintSetting(string PrinterName)
        {
            listBox1.Items.Clear();
            if (PrinterName!="")
            {
                printDocument1.PrinterSettings.PrinterName = PrinterName;
            }
            foreach (string sPrint in PrinterSettings.InstalledPrinters)
            {
                if (sPrint == PrinterName)
                {
                    foreach (PaperSize ps in printDocument1.PrinterSettings.PaperSizes)
                    {
                         listBox1.Items.Add(string.Format("\r\n PaperName{2} PaperKind{3} width{0} height{1} _{0}_{1}", ps.Width, ps.Height,ps.PaperName,ps.RawKind.ToString()));
                    }
                }
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int xx = 0;
                if (textBox1.Text!="")
                {
                    xx = Convert.ToInt32(textBox1.Text);
                }
                Graphics g = e.Graphics;

                if (listdata.Count > 0)
                { 

                    Font newft = new Font("宋体", 30, FontStyle.Bold);
                    g.DrawString(listdata[0], newft, System.Drawing.Brushes.Black, 10 + xx, 10 + xx);
                    g.DrawString(listdata[0], newft, System.Drawing.Brushes.WhiteSmoke, 10 + xx, 50 + xx);
                    listdata.RemoveAt(0);
                    if (listdata.Count <= 0)
                    {
                        e.HasMorePages = false;
                        listdata.Add("这是第一张卡片");
                        listdata.Add("这是第二张卡片");
                    }
                    else
                    {
                        e.HasMorePages = true;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Add("");
                foreach (var v in   PrinterSettings.InstalledPrinters)
                {
                    comboBox1.Items.Add(v);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 
                GetPrintSetting(comboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var v = listBox1.SelectedItem;
                if(v!=null)
                {
                    var dd = v.ToString().Split('_');
                    txtH.Text = dd[2];
                    txtW.Text = dd[1];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
