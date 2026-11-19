using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BarcodeLib;
using ThoughtWorks.QRCode.Codec;


namespace testPrint
{
    public partial class Form1 : Form
    {
    	private List<string> listdata = new List<string>();

    	private QRCodeEncoder qrenCoder = new QRCodeEncoder();

    	private string path = Application.StartupPath + $"\\{Guid.NewGuid()}.jpg";

    	public Form1()
    	{
    		InitializeComponent();
    	}

    	private static IEnumerable<int> GetNumbers()
    	{
    		Console.WriteLine("Initializating...");
    		List<int> list = new List<int>();
    		for (int i = 0; i < 3; i++)
    		{
    			list.Add(i);
    		}
    		Console.WriteLine("Processing...");
    		for (int j = 0; j < list.Count; j++)
    		{
    			Console.WriteLine("Yield called.");
    			yield return list[j];
    		}
    		Console.WriteLine("Done.");
    	}

    	private void button1_Click(object sender, EventArgs e)
    	{
    		try
    		{
    			Additems();
    			if (cmbPrint.Text.Trim() != "")
    			{
    				printDocument1.PrinterSettings.PrinterName = cmbPrint.Text.Trim();
    			}
    			else
    			{
    				printDocument1.PrinterSettings.PrinterName = cmbPrint.Items[0].ToString();
    			}
    			if (chkQR.Checked)
    			{
    				qrenCoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
    				qrenCoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
    				qrenCoder.QRCodeVersion = Convert.ToInt32(txtversion.Text);
    				qrenCoder.QRCodeScale = 2;
    				switch (txtqcodeweight.Text)
    				{
    				case "1":
    					qrenCoder.QRCodeScale = 1;
    					break;
    				case "1.3":
    					qrenCoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
    					qrenCoder.QRCodeScale = 2;
    					break;
    				case "1.5":
    				case "2":
    					qrenCoder.QRCodeScale = 2;
    					break;
    				case "2.5":
    					qrenCoder.QRCodeScale = 3;
    					break;
    				case "3":
    					qrenCoder.QRCodeScale = 4;
    					break;
    				default:
    					qrenCoder.QRCodeScale = 2;
    					break;
    				}
    				Bitmap bitmap = qrenCoder.Encode(txtImageJson.Text);
    				path = Application.StartupPath + $"\\{Guid.NewGuid()}.jpg";
    				bitmap.Save(path);
    				imageList1.Images.Add(Image.FromFile(path));
    			}
    			if (chkCustom.Checked)
    			{
    				if (txtW.Text == "" || txtH.Text == "")
    				{
    					MessageBox.Show("输入高宽");
    					return;
    				}
    				printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom Size", Convert.ToInt32(txtW.Text), Convert.ToInt32(txtH.Text));
    			}
    			else if (!chkDefault.Checked)
    			{
    				if (txtW.Text == "" || txtH.Text == "")
    				{
    					MessageBox.Show("输入高宽");
    					return;
    				}
    				printDocument1.DefaultPageSettings.PaperSize = GetPrintSetting(printDocument1.PrinterSettings.PrinterName, Convert.ToInt32(txtW.Text), Convert.ToInt32(txtH.Text));
    			}
    			if (chkLandscape.Checked)
    			{
    				printDocument1.DefaultPageSettings.Landscape = true;
    			}
    			if (txtTopMargin.Text != "")
    			{
    				printDocument1.DefaultPageSettings.Margins.Top = Convert.ToInt32(txtTopMargin.Text);
    			}
    			if (txtLeftMargin.Text != "")
    			{
    				printDocument1.DefaultPageSettings.Margins.Left = Convert.ToInt32(txtLeftMargin.Text);
    			}
    			if (txtRightMargin.Text != "")
    			{
    				printDocument1.DefaultPageSettings.Margins.Right = Convert.ToInt32(txtRightMargin.Text);
    			}
    			if (txtDownMargin.Text != "")
    			{
    				printDocument1.DefaultPageSettings.Margins.Bottom = Convert.ToInt32(txtDownMargin.Text);
    			}
    			if (chkPrint.Checked)
    			{
    				PrintDialog printDialog = new PrintDialog();
    				printDialog.Document = printDocument1;
    				printDialog.ShowDialog();
    			}
    			if (chbPage.Checked)
    			{
    				PageSetupDialog pageSetupDialog = new PageSetupDialog();
    				pageSetupDialog.Document = printDocument1;
    				pageSetupDialog.ShowDialog();
    			}
    			if (MessageBox.Show("选中的纸为" + printDocument1.DefaultPageSettings.PaperSize.PaperName + "   MarginsTop:" + printDocument1.DefaultPageSettings.Margins.Top + "-- MarginsLeft:" + printDocument1.DefaultPageSettings.Margins.Left, "提示", MessageBoxButtons.YesNo) != DialogResult.No)
    			{
    				if (chkpreview.Checked)
    				{
    					printPreviewDialog1.Document = printDocument1;
    					printPreviewDialog1.ShowDialog();
    				}
    				else
    				{
    					printDocument1.Print();
    				}
    			}
    		}
    		catch (Exception ex)
    		{
    			MessageBox.Show(ex.Message);
    		}
    	}

    	private void OnEndPrint(PrintEventArgs e)
    	{
    	}

    	private void Additems()
    	{
    		listdata.Clear();
    		if (txtNo.Text == "")
    		{
    			listdata.Add("这是第一张卡片这是第一张卡片" + txtInput.Text.ToString());
    			listdata.Add("这是第二张卡片这是第二张卡片" + txtInput.Text.ToString());
    			return;
    		}
    		int num = Convert.ToInt32(txtNo.Text);
    		for (int i = 1; i <= num; i++)
    		{
    			listdata.Add(string.Format("这是第{0}张卡片这是第{0}张卡片" + txtInput.Text.ToString(), i));
    		}
    	}

    	public PaperSize GetPrintSetting(string PrinterName, int width, int height)
    	{
    		foreach (string installedPrinter in PrinterSettings.InstalledPrinters)
    		{
    			if (!(installedPrinter == PrinterName))
    			{
    				continue;
    			}
    			foreach (PaperSize paperSize in printDocument1.PrinterSettings.PaperSizes)
    			{
    				if (Math.Abs(paperSize.Width - width) < 10 && Math.Abs(paperSize.Height - height) < 10)
    				{
    					return paperSize;
    				}
    			}
    		}
    		return new PaperSize("Custom Size", width, height);
    	}

    	public void GetPrintSetting(string PrinterName)
    	{
    		listPagesize.Items.Clear();
    		if (PrinterName != "")
    		{
    			printDocument1.PrinterSettings.PrinterName = PrinterName;
    		}
    		foreach (string installedPrinter in PrinterSettings.InstalledPrinters)
    		{
    			if (!(installedPrinter == PrinterName))
    			{
    				continue;
    			}
    			foreach (PaperSize paperSize in printDocument1.PrinterSettings.PaperSizes)
    			{
    				listPagesize.Items.Add(string.Format("\r\n PaperName{2} PaperKind{3} width{0} height{1} _{0}_{1}", paperSize.Width, paperSize.Height, paperSize.PaperName, paperSize.RawKind.ToString()));
    			}
    		}
    	}

    	private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
    	{
    		try
    		{
    			int num = 0;
    			if (txtRightDeviation.Text != "")
    			{
    				num = Convert.ToInt32(txtRightDeviation.Text);
    			}
    			Graphics graphics = e.Graphics;
    			Pen pen = new Pen(Color.Red, 2f);
    			if (chkBlack.Checked)
    			{
    				pen = new Pen(Color.Black, 2f);
    			}
    			if (!checkBox2.Checked)
    			{
    				graphics.DrawRectangle(pen, e.PageBounds);
    			}
    			if (listdata.Count > 0)
    			{
    				Font font = new Font("宋体", 30f, FontStyle.Bold);
    				graphics.DrawString(listdata[0], font, Brushes.Black, 10 + num, 10 + num);
    				graphics.DrawString(listdata[0], font, Brushes.WhiteSmoke, 10 + num, 50 + num);
    				graphics.DrawString(listdata[0], font, Brushes.Black, 10 + num, 90 + num);
    				graphics.DrawString(listdata[0], font, Brushes.WhiteSmoke, 10 + num, 130 + num);
    				graphics.DrawString(listdata[0], font, Brushes.Black, 10 + num, 170 + num);
    				listdata.RemoveAt(0);
    				if (listdata.Count <= 0)
    				{
    					e.HasMorePages = false;
    					Additems();
    				}
    				else
    				{
    					e.HasMorePages = true;
    				}
    			}
    			if (chkQR.Checked)
    			{
    				Bitmap bitmap = new Bitmap("e5dab422-d044-4d93-9b25-95167ad7b8d9.jpg");
    				graphics.DrawImage(bitmap, 10 + num, 10 + num);
    				if (checkBox1.Checked)
    				{
    					graphics.DrawImage(bitmap, 10 + num, 10 + num, bitmap.Width, bitmap.Height);
    				}
    				else
    				{
    					graphics.DrawImage(bitmap, 10 + num, 10 + num);
    				}
    				if (!checkBox2.Checked)
    				{
    					graphics.DrawRectangle(pen, new Rectangle(10 + num, 10 + num, bitmap.Width, bitmap.Height));
    				}
    			}
    			if (chkimg.Checked)
    			{
    				Image image = imageList1.Images[0];
    				string filename = Application.StartupPath + $"\\{Guid.NewGuid()}.jpg";
    				image.Save(filename);
    				graphics.DrawImage(Image.FromFile(filename), 10 + num, 10 + num, Convert.ToInt32(txtImageHW.Text), Convert.ToInt32(txtImageHW.Text));
    			}
    			StringBuilder stringBuilder = new StringBuilder();
    			StringWriter stringWriter = new StringWriter(stringBuilder);
    			stringWriter.WriteLine("X0809000037");
    			stringWriter.WriteLine("");
    			stringWriter.WriteLine("X0809000038");
    			if (txtBarCode.Text.Trim() != "")
    			{
    				int num2 = Convert.ToInt32(txtBarCode.Text);
    				int num3 = 8;
    				txtResult.Text = "";
    				string text = "JDVF0153";
    				int num4 = 0;
    				for (int i = 0; i <= num2 - num3; i++)
    				{
    					string text2 = text;
    					for (int j = 0; j <= i; j++)
    					{
    						text2 += "4";
    					}
    					Barcode barcode = new Barcode();
    					for (int k = 100; k <= 400; k += 2)
    					{
    						try
    						{
    							Image image2 = barcode.Encode(TYPE.CODE128, text2, Color.Black, Color.White, k, 15);
    							graphics.DrawImage(image2, 100 + num, 400 + num + num4);
    							graphics.DrawRectangle(pen, new Rectangle(100 + num, 400 + num + num4, image2.Width, image2.Height));
    							num4 += 20;
    							TextBox textBox = txtResult;
    							textBox.Text = textBox.Text + text2 + ";len:" + text2.Length + ";minWeight:" + k + ";最佳：" + (5.5 * (double)text2.Length + 100.0) + Environment.NewLine;
    						}
    						catch (Exception)
    						{
    							continue;
    						}
    						break;
    					}
    				}
    			}
    			Font font2 = null;
    			font2 = new Font("C39P12DhTt", 10f);
    			e.Graphics.DrawString(stringBuilder.ToString(), font2, Brushes.Black, 30f, 30f, new StringFormat());
    		}
    		catch (Exception ex2)
    		{
    			MessageBox.Show(ex2.Message);
    		}
    	}

    	private void Form1_Load(object sender, EventArgs e)
    	{
    		try
    		{
    			cmbPrint.Items.Add("");
    			foreach (object installedPrinter in PrinterSettings.InstalledPrinters)
    			{
    				cmbPrint.Items.Add(installedPrinter);
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
    			GetPrintSetting(cmbPrint.Text);
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
    			object selectedItem = listPagesize.SelectedItem;
    			if (selectedItem != null)
    			{
    				string[] array = selectedItem.ToString().Split('_');
    				txtH.Text = array[2];
    				txtW.Text = array[1];
    				lbh.Text = "义齿高:" + Convert.ToInt32(Convert.ToDecimal(array[2]) / 100m * 25.4m);
    				lbw.Text = "义齿宽:" + Convert.ToInt32(Convert.ToDecimal(array[1]) / 100m * 25.4m);
    			}
    		}
    		catch (Exception ex)
    		{
    			MessageBox.Show(ex.Message);
    		}
    	}

    	private void printDocument1_EndPrint(object sender, PrintEventArgs e)
    	{
    		try
    		{
    		}
    		catch (Exception ex)
    		{
    			MessageBox.Show(ex.Message);
    		}
    	}

    	private void txtH_Leave(object sender, EventArgs e)
    	{
    		try
    		{
    			lbh.Text = "义齿高:" + Convert.ToInt32(Convert.ToDecimal(txtH.Text) / 100m * 25.4m);
    		}
    		catch (Exception ex)
    		{
    			MessageBox.Show(ex.Message);
    		}
    	}

    	private void txtW_Leave(object sender, EventArgs e)
    	{
    		try
    		{
    			lbw.Text = "义齿宽:" + Convert.ToInt32(Convert.ToDecimal(txtW.Text) / 100m * 25.4m);
    		}
    		catch (Exception ex)
    		{
    			MessageBox.Show(ex.Message);
    		}
    	}

    	private void txtqcodeweight_TextChanged(object sender, EventArgs e)
    	{
    	}

    	private void txtversion_TextChanged(object sender, EventArgs e)
    	{
    	}
    }
}
