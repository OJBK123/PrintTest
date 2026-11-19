using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace testPrint
{
    public partial class frmDataFormat : Form
    {
        public const int LOCALE_SLONGDATE = 32;
        public const int LOCALE_SSHORTDATE = 31;
        public const int LOCALE_STIME = 4099;

    	public frmDataFormat()
    	{
    		InitializeComponent();
    	}

    	private void frmDataFormat_Load(object sender, EventArgs e)
    	{
    		try
    		{
    			textBox1.Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToLongDateString() + "\r\n";
    		}
    		catch (Exception ex)
    		{
    			MessageBox.Show(ex.StackTrace + ex.Message);
    		}
    	}

    	[DllImport("kernel32.dll")]
    	public static extern int GetSystemDefaultLCID();

    	[DllImport("kernel32.dll", EntryPoint = "SetLocaleInfoA")]
    	public static extern int SetLocaleInfo(int Locale, int LCType, string lpLCData);

    	public void SetDateTimeFormat(int kind)
    	{
    		try
    		{
    			int systemDefaultLCID = GetSystemDefaultLCID();
    			switch (kind)
    			{
    			case 0:
    				SetLocaleInfo(systemDefaultLCID, 4099, "HH:mm:ss");
    				break;
    			case 1:
    				SetLocaleInfo(systemDefaultLCID, 31, "yyyy-MM-dd");
    				break;
    			case 2:
    				SetLocaleInfo(systemDefaultLCID, 32, "yyyy-MM-dd");
    				break;
    			}
    		}
    		catch (Exception value)
    		{
    			Console.WriteLine(value);
    		}
    	}

    	private void button1_Click(object sender, EventArgs e)
    	{
    		try
    		{
    			SetDateTimeFormat(1);
    			TextBox textBox = textBox1;
    			textBox.Text = textBox.Text + DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToLongDateString() + "\r\n";
    		}
    		catch (Exception value)
    		{
    			Console.WriteLine(value);
    		}
    	}

    	private void button2_Click(object sender, EventArgs e)
    	{
    		try
    		{
    			string value = "2022/03/26/星期六";
    			DateTime dateTime = Convert.ToDateTime(value);
    			SetDateTimeFormat(0);
    			TextBox textBox = textBox1;
    			textBox.Text = textBox.Text + DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToLongDateString() + "\r\n";
    		}
    		catch (Exception value2)
    		{
    			Console.WriteLine(value2);
    		}
    	}

    	private void button4_Click(object sender, EventArgs e)
    	{
    		try
    		{
    			SetDateTimeFormat(2);
    			TextBox textBox = textBox1;
    			textBox.Text = textBox.Text + DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToLongDateString() + "\r\n";
    		}
    		catch (Exception value)
    		{
    			Console.WriteLine(value);
    		}
    	}
    }
}
