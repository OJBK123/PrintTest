using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace testPrint
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
    	private IContainer components = null;

    	private Button btnPrint;

    	private PrintDocument printDocument1;

    	private PrintPreviewDialog printPreviewDialog1;

    	private ComboBox cmbPrint;

    	private TextBox txtH;

    	private TextBox txtW;

    	private Label lheight;

    	private Label lb;

    	private CheckBox chkCustom;

    	private ListBox listPagesize;

    	private CheckBox chkpreview;

    	private CheckBox chkLandscape;

    	private TextBox txtRightDeviation;

    	private Label label1;

    	private Label label2;

    	private TextBox txtNo;

    	private Label label3;

    	private Label label4;

    	private TextBox txtImageJson;

    	private Label lbh;

    	private Label lbw;

    	private CheckBox chkQR;

    	private Label label5;

    	private TextBox txtqcodeweight;

    	private Label label6;

    	private TextBox txtversion;

    	private CheckBox chkimg;

    	private ImageList imageList1;

    	private Label label7;

    	private TextBox txtImageHW;

    	private Label label8;

    	private TextBox txtTopMargin;

    	private TextBox txtDownMargin;

    	private Label label9;

    	private TextBox txtLeftMargin;

    	private Label label10;

    	private TextBox txtRightMargin;

    	private Label label11;

    	private GroupBox groupBox1;

    	private CheckBox chkPrint;

    	private CheckBox chbPage;

    	private CheckBox chkDefault;

    	private CheckBox checkBox1;

    	private CheckBox chkBlack;

    	private CheckBox checkBox2;

    	private TextBox txtBarCode;

    	private Label label12;

    	private TextBox txtResult;

    	private Label lbtt;

    	private TextBox txtInput;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    	protected override void Dispose(bool disposing)
    	{
    		if (disposing && components != null)
    		{
    			components.Dispose();
    		}
    		base.Dispose(disposing);
    	}

    	private void InitializeComponent()
    	{
    		this.components = new System.ComponentModel.Container();
    		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testPrint.Form1));
    		this.btnPrint = new System.Windows.Forms.Button();
    		this.printDocument1 = new System.Drawing.Printing.PrintDocument();
    		this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
    		this.cmbPrint = new System.Windows.Forms.ComboBox();
    		this.txtH = new System.Windows.Forms.TextBox();
    		this.txtW = new System.Windows.Forms.TextBox();
    		this.lheight = new System.Windows.Forms.Label();
    		this.lb = new System.Windows.Forms.Label();
    		this.chkCustom = new System.Windows.Forms.CheckBox();
    		this.listPagesize = new System.Windows.Forms.ListBox();
    		this.chkpreview = new System.Windows.Forms.CheckBox();
    		this.chkLandscape = new System.Windows.Forms.CheckBox();
    		this.txtRightDeviation = new System.Windows.Forms.TextBox();
    		this.label1 = new System.Windows.Forms.Label();
    		this.label2 = new System.Windows.Forms.Label();
    		this.txtNo = new System.Windows.Forms.TextBox();
    		this.label3 = new System.Windows.Forms.Label();
    		this.label4 = new System.Windows.Forms.Label();
    		this.txtImageJson = new System.Windows.Forms.TextBox();
    		this.lbh = new System.Windows.Forms.Label();
    		this.lbw = new System.Windows.Forms.Label();
    		this.chkQR = new System.Windows.Forms.CheckBox();
    		this.txtqcodeweight = new System.Windows.Forms.TextBox();
    		this.label5 = new System.Windows.Forms.Label();
    		this.label6 = new System.Windows.Forms.Label();
    		this.txtversion = new System.Windows.Forms.TextBox();
    		this.chkimg = new System.Windows.Forms.CheckBox();
    		this.imageList1 = new System.Windows.Forms.ImageList(this.components);
    		this.label7 = new System.Windows.Forms.Label();
    		this.txtImageHW = new System.Windows.Forms.TextBox();
    		this.label8 = new System.Windows.Forms.Label();
    		this.txtTopMargin = new System.Windows.Forms.TextBox();
    		this.txtDownMargin = new System.Windows.Forms.TextBox();
    		this.label9 = new System.Windows.Forms.Label();
    		this.txtLeftMargin = new System.Windows.Forms.TextBox();
    		this.label10 = new System.Windows.Forms.Label();
    		this.txtRightMargin = new System.Windows.Forms.TextBox();
    		this.label11 = new System.Windows.Forms.Label();
    		this.groupBox1 = new System.Windows.Forms.GroupBox();
    		this.chkPrint = new System.Windows.Forms.CheckBox();
    		this.chbPage = new System.Windows.Forms.CheckBox();
    		this.chkDefault = new System.Windows.Forms.CheckBox();
    		this.checkBox1 = new System.Windows.Forms.CheckBox();
    		this.chkBlack = new System.Windows.Forms.CheckBox();
    		this.checkBox2 = new System.Windows.Forms.CheckBox();
    		this.txtBarCode = new System.Windows.Forms.TextBox();
    		this.label12 = new System.Windows.Forms.Label();
    		this.txtResult = new System.Windows.Forms.TextBox();
    		this.lbtt = new System.Windows.Forms.Label();
    		this.txtInput = new System.Windows.Forms.TextBox();
    		this.groupBox1.SuspendLayout();
    		this.SuspendLayout();
    		this.btnPrint.Location = new System.Drawing.Point(463, 126);
    		this.btnPrint.Name = "btnPrint";
    		this.btnPrint.Size = new System.Drawing.Size(144, 54);
    		this.btnPrint.TabIndex = 0;
    		this.btnPrint.Text = "打印";
    		this.btnPrint.UseVisualStyleBackColor = true;
    		this.btnPrint.Click += new System.EventHandler(this.button1_Click);
    		this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
    		this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
    		this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
    		this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
    		this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
    		this.printPreviewDialog1.Enabled = true;
    		this.printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
    		this.printPreviewDialog1.Name = "printPreviewDialog1";
    		this.printPreviewDialog1.Visible = false;
    		this.cmbPrint.FormattingEnabled = true;
    		this.cmbPrint.Location = new System.Drawing.Point(8, 26);
    		this.cmbPrint.Name = "cmbPrint";
    		this.cmbPrint.Size = new System.Drawing.Size(435, 20);
    		this.cmbPrint.TabIndex = 2;
    		this.cmbPrint.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
    		this.txtH.Location = new System.Drawing.Point(524, 243);
    		this.txtH.Multiline = true;
    		this.txtH.Name = "txtH";
    		this.txtH.Size = new System.Drawing.Size(74, 41);
    		this.txtH.TabIndex = 1;
    		this.txtH.Leave += new System.EventHandler(this.txtH_Leave);
    		this.txtW.Location = new System.Drawing.Point(524, 302);
    		this.txtW.Multiline = true;
    		this.txtW.Name = "txtW";
    		this.txtW.Size = new System.Drawing.Size(74, 41);
    		this.txtW.TabIndex = 1;
    		this.txtW.Leave += new System.EventHandler(this.txtW_Leave);
    		this.lheight.AutoSize = true;
    		this.lheight.Location = new System.Drawing.Point(459, 264);
    		this.lheight.Name = "lheight";
    		this.lheight.Size = new System.Drawing.Size(41, 12);
    		this.lheight.TabIndex = 3;
    		this.lheight.Text = "height";
    		this.lb.AutoSize = true;
    		this.lb.Location = new System.Drawing.Point(459, 315);
    		this.lb.Name = "lb";
    		this.lb.Size = new System.Drawing.Size(35, 12);
    		this.lb.TabIndex = 3;
    		this.lb.Text = "width";
    		this.chkCustom.AutoSize = true;
    		this.chkCustom.Location = new System.Drawing.Point(476, 40);
    		this.chkCustom.Name = "chkCustom";
    		this.chkCustom.Size = new System.Drawing.Size(120, 16);
    		this.chkCustom.TabIndex = 4;
    		this.chkCustom.Text = "自定义纸张Custom";
    		this.chkCustom.UseVisualStyleBackColor = true;
    		this.listPagesize.FormattingEnabled = true;
    		this.listPagesize.ItemHeight = 12;
    		this.listPagesize.Location = new System.Drawing.Point(8, 77);
    		this.listPagesize.Name = "listPagesize";
    		this.listPagesize.Size = new System.Drawing.Size(435, 340);
    		this.listPagesize.TabIndex = 5;
    		this.listPagesize.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
    		this.chkpreview.AutoSize = true;
    		this.chkpreview.Checked = true;
    		this.chkpreview.CheckState = System.Windows.Forms.CheckState.Checked;
    		this.chkpreview.Location = new System.Drawing.Point(476, 17);
    		this.chkpreview.Name = "chkpreview";
    		this.chkpreview.Size = new System.Drawing.Size(84, 16);
    		this.chkpreview.TabIndex = 6;
    		this.chkpreview.Text = "打印先预览";
    		this.chkpreview.UseVisualStyleBackColor = true;
    		this.chkLandscape.AutoSize = true;
    		this.chkLandscape.Location = new System.Drawing.Point(476, 80);
    		this.chkLandscape.Name = "chkLandscape";
    		this.chkLandscape.Size = new System.Drawing.Size(48, 16);
    		this.chkLandscape.TabIndex = 7;
    		this.chkLandscape.Text = "横向";
    		this.chkLandscape.UseVisualStyleBackColor = true;
    		this.txtRightDeviation.Location = new System.Drawing.Point(524, 189);
    		this.txtRightDeviation.Name = "txtRightDeviation";
    		this.txtRightDeviation.Size = new System.Drawing.Size(74, 21);
    		this.txtRightDeviation.TabIndex = 8;
    		this.label1.AutoSize = true;
    		this.label1.Location = new System.Drawing.Point(461, 194);
    		this.label1.Name = "label1";
    		this.label1.Size = new System.Drawing.Size(29, 12);
    		this.label1.TabIndex = 9;
    		this.label1.Text = "偏移";
    		this.label2.AutoSize = true;
    		this.label2.Location = new System.Drawing.Point(461, 221);
    		this.label2.Name = "label2";
    		this.label2.Size = new System.Drawing.Size(53, 12);
    		this.label2.TabIndex = 11;
    		this.label2.Text = "打印次数";
    		this.txtNo.Location = new System.Drawing.Point(524, 216);
    		this.txtNo.Name = "txtNo";
    		this.txtNo.Size = new System.Drawing.Size(74, 21);
    		this.txtNo.TabIndex = 10;
    		this.txtNo.Text = "2";
    		this.label3.AutoSize = true;
    		this.label3.Location = new System.Drawing.Point(11, 9);
    		this.label3.Name = "label3";
    		this.label3.Size = new System.Drawing.Size(41, 12);
    		this.label3.TabIndex = 12;
    		this.label3.Text = "打印机";
    		this.label4.AutoSize = true;
    		this.label4.Location = new System.Drawing.Point(12, 59);
    		this.label4.Name = "label4";
    		this.label4.Size = new System.Drawing.Size(29, 12);
    		this.label4.TabIndex = 12;
    		this.label4.Text = "纸张";
    		this.txtImageJson.Location = new System.Drawing.Point(649, 22);
    		this.txtImageJson.Multiline = true;
    		this.txtImageJson.Name = "txtImageJson";
    		this.txtImageJson.Size = new System.Drawing.Size(169, 155);
    		this.txtImageJson.TabIndex = 1;
    		this.txtImageJson.Text = resources.GetString("txtImageJson.Text");
    		this.lbh.AutoSize = true;
    		this.lbh.Location = new System.Drawing.Point(615, 255);
    		this.lbh.Name = "lbh";
    		this.lbh.Size = new System.Drawing.Size(41, 12);
    		this.lbh.TabIndex = 13;
    		this.lbh.Text = "义齿高";
    		this.lbw.AutoSize = true;
    		this.lbw.Location = new System.Drawing.Point(615, 315);
    		this.lbw.Name = "lbw";
    		this.lbw.Size = new System.Drawing.Size(41, 12);
    		this.lbw.TabIndex = 13;
    		this.lbw.Text = "义齿宽";
    		this.chkQR.AutoSize = true;
    		this.chkQR.Location = new System.Drawing.Point(826, 216);
    		this.chkQR.Name = "chkQR";
    		this.chkQR.Size = new System.Drawing.Size(60, 16);
    		this.chkQR.TabIndex = 14;
    		this.chkQR.Text = "二维码";
    		this.chkQR.UseVisualStyleBackColor = true;
    		this.txtqcodeweight.Location = new System.Drawing.Point(724, 191);
    		this.txtqcodeweight.Name = "txtqcodeweight";
    		this.txtqcodeweight.Size = new System.Drawing.Size(64, 21);
    		this.txtqcodeweight.TabIndex = 15;
    		this.txtqcodeweight.Text = "1.3";
    		this.txtqcodeweight.TextChanged += new System.EventHandler(this.txtqcodeweight_TextChanged);
    		this.label5.AutoSize = true;
    		this.label5.Location = new System.Drawing.Point(640, 194);
    		this.label5.Name = "label5";
    		this.label5.Size = new System.Drawing.Size(65, 12);
    		this.label5.TabIndex = 16;
    		this.label5.Text = "二维码宽度";
    		this.label6.AutoSize = true;
    		this.label6.Location = new System.Drawing.Point(640, 219);
    		this.label6.Name = "label6";
    		this.label6.Size = new System.Drawing.Size(83, 12);
    		this.label6.TabIndex = 0;
    		this.label6.Text = "二维码version";
    		this.txtversion.Location = new System.Drawing.Point(724, 216);
    		this.txtversion.Name = "txtversion";
    		this.txtversion.Size = new System.Drawing.Size(64, 21);
    		this.txtversion.TabIndex = 0;
    		this.txtversion.Text = "0";
    		this.txtversion.TextChanged += new System.EventHandler(this.txtversion_TextChanged);
    		this.chkimg.AutoSize = true;
    		this.chkimg.Location = new System.Drawing.Point(824, 24);
    		this.chkimg.Name = "chkimg";
    		this.chkimg.Size = new System.Drawing.Size(48, 16);
    		this.chkimg.TabIndex = 17;
    		this.chkimg.Text = "图片";
    		this.chkimg.UseVisualStyleBackColor = true;
    		this.imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
    		this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
    		this.imageList1.Images.SetKeyName(0, "timg - 副 - 副本.png");
    		this.label7.AutoSize = true;
    		this.label7.Location = new System.Drawing.Point(819, 48);
    		this.label7.Name = "label7";
    		this.label7.Size = new System.Drawing.Size(53, 12);
    		this.label7.TabIndex = 19;
    		this.label7.Text = "图片高宽";
    		this.txtImageHW.Location = new System.Drawing.Point(903, 45);
    		this.txtImageHW.Name = "txtImageHW";
    		this.txtImageHW.Size = new System.Drawing.Size(64, 21);
    		this.txtImageHW.TabIndex = 18;
    		this.txtImageHW.Text = "10";
    		this.label8.AutoSize = true;
    		this.label8.Location = new System.Drawing.Point(73, 20);
    		this.label8.Name = "label8";
    		this.label8.Size = new System.Drawing.Size(41, 12);
    		this.label8.TabIndex = 20;
    		this.label8.Text = "上边距";
    		this.txtTopMargin.Location = new System.Drawing.Point(134, 17);
    		this.txtTopMargin.Name = "txtTopMargin";
    		this.txtTopMargin.Size = new System.Drawing.Size(64, 21);
    		this.txtTopMargin.TabIndex = 21;
    		this.txtDownMargin.Location = new System.Drawing.Point(135, 67);
    		this.txtDownMargin.Name = "txtDownMargin";
    		this.txtDownMargin.Size = new System.Drawing.Size(64, 21);
    		this.txtDownMargin.TabIndex = 21;
    		this.label9.AutoSize = true;
    		this.label9.Location = new System.Drawing.Point(74, 73);
    		this.label9.Name = "label9";
    		this.label9.Size = new System.Drawing.Size(41, 12);
    		this.label9.TabIndex = 20;
    		this.label9.Text = "下边距";
    		this.txtLeftMargin.Location = new System.Drawing.Point(64, 43);
    		this.txtLeftMargin.Name = "txtLeftMargin";
    		this.txtLeftMargin.Size = new System.Drawing.Size(64, 21);
    		this.txtLeftMargin.TabIndex = 21;
    		this.label10.AutoSize = true;
    		this.label10.Location = new System.Drawing.Point(8, 46);
    		this.label10.Name = "label10";
    		this.label10.Size = new System.Drawing.Size(41, 12);
    		this.label10.TabIndex = 20;
    		this.label10.Text = "左边距";
    		this.txtRightMargin.Location = new System.Drawing.Point(195, 43);
    		this.txtRightMargin.Name = "txtRightMargin";
    		this.txtRightMargin.Size = new System.Drawing.Size(64, 21);
    		this.txtRightMargin.TabIndex = 21;
    		this.label11.AutoSize = true;
    		this.label11.Location = new System.Drawing.Point(148, 46);
    		this.label11.Name = "label11";
    		this.label11.Size = new System.Drawing.Size(41, 12);
    		this.label11.TabIndex = 20;
    		this.label11.Text = "右边距";
    		this.groupBox1.Controls.Add(this.label11);
    		this.groupBox1.Controls.Add(this.label10);
    		this.groupBox1.Controls.Add(this.label9);
    		this.groupBox1.Controls.Add(this.label8);
    		this.groupBox1.Controls.Add(this.txtRightMargin);
    		this.groupBox1.Controls.Add(this.txtLeftMargin);
    		this.groupBox1.Controls.Add(this.txtDownMargin);
    		this.groupBox1.Controls.Add(this.txtTopMargin);
    		this.groupBox1.Location = new System.Drawing.Point(824, 80);
    		this.groupBox1.Name = "groupBox1";
    		this.groupBox1.Size = new System.Drawing.Size(268, 100);
    		this.groupBox1.TabIndex = 22;
    		this.groupBox1.TabStop = false;
    		this.groupBox1.Text = "纸张边距";
    		this.chkPrint.AutoSize = true;
    		this.chkPrint.Location = new System.Drawing.Point(476, 104);
    		this.chkPrint.Name = "chkPrint";
    		this.chkPrint.Size = new System.Drawing.Size(72, 16);
    		this.chkPrint.TabIndex = 23;
    		this.chkPrint.Text = "弹打印机";
    		this.chkPrint.UseVisualStyleBackColor = true;
    		this.chbPage.AutoSize = true;
    		this.chbPage.Location = new System.Drawing.Point(554, 104);
    		this.chbPage.Name = "chbPage";
    		this.chbPage.Size = new System.Drawing.Size(60, 16);
    		this.chbPage.TabIndex = 23;
    		this.chbPage.Text = "弹纸张";
    		this.chbPage.UseVisualStyleBackColor = true;
    		this.chkDefault.AutoSize = true;
    		this.chkDefault.Location = new System.Drawing.Point(476, 60);
    		this.chkDefault.Name = "chkDefault";
    		this.chkDefault.Size = new System.Drawing.Size(72, 16);
    		this.chkDefault.TabIndex = 24;
    		this.chkDefault.Text = "默认纸张";
    		this.chkDefault.UseVisualStyleBackColor = true;
    		this.checkBox1.AutoSize = true;
    		this.checkBox1.Location = new System.Drawing.Point(891, 216);
    		this.checkBox1.Name = "checkBox1";
    		this.checkBox1.Size = new System.Drawing.Size(108, 16);
    		this.checkBox1.TabIndex = 25;
    		this.checkBox1.Text = "二维码限制宽度";
    		this.checkBox1.UseVisualStyleBackColor = true;
    		this.chkBlack.AutoSize = true;
    		this.chkBlack.Location = new System.Drawing.Point(824, 189);
    		this.chkBlack.Name = "chkBlack";
    		this.chkBlack.Size = new System.Drawing.Size(60, 16);
    		this.chkBlack.TabIndex = 26;
    		this.chkBlack.Text = "黑色框";
    		this.chkBlack.UseVisualStyleBackColor = true;
    		this.checkBox2.AutoSize = true;
    		this.checkBox2.Location = new System.Drawing.Point(826, 238);
    		this.checkBox2.Name = "checkBox2";
    		this.checkBox2.Size = new System.Drawing.Size(84, 16);
    		this.checkBox2.TabIndex = 27;
    		this.checkBox2.Text = "删除框打印";
    		this.checkBox2.UseVisualStyleBackColor = true;
    		this.txtBarCode.Location = new System.Drawing.Point(524, 396);
    		this.txtBarCode.Name = "txtBarCode";
    		this.txtBarCode.Size = new System.Drawing.Size(100, 21);
    		this.txtBarCode.TabIndex = 28;
    		this.label12.AutoSize = true;
    		this.label12.Location = new System.Drawing.Point(473, 399);
    		this.label12.Name = "label12";
    		this.label12.Size = new System.Drawing.Size(47, 12);
    		this.label12.TabIndex = 29;
    		this.label12.Text = "条形码:";
    		this.txtResult.Location = new System.Drawing.Point(727, 264);
    		this.txtResult.Multiline = true;
    		this.txtResult.Name = "txtResult";
    		this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
    		this.txtResult.Size = new System.Drawing.Size(463, 175);
    		this.txtResult.TabIndex = 30;
    		this.lbtt.AutoSize = true;
    		this.lbtt.Location = new System.Drawing.Point(640, 399);
    		this.lbtt.Name = "lbtt";
    		this.lbtt.Size = new System.Drawing.Size(77, 12);
    		this.lbtt.TabIndex = 31;
    		this.lbtt.Text = "条码打印结果";
    		this.txtInput.Location = new System.Drawing.Point(461, 417);
    		this.txtInput.Name = "txtInput";
    		this.txtInput.Size = new System.Drawing.Size(244, 21);
    		this.txtInput.TabIndex = 32;
    		this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
    		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    		this.ClientSize = new System.Drawing.Size(1217, 474);
    		this.Controls.Add(this.txtInput);
    		this.Controls.Add(this.lbtt);
    		this.Controls.Add(this.txtResult);
    		this.Controls.Add(this.label12);
    		this.Controls.Add(this.txtBarCode);
    		this.Controls.Add(this.checkBox2);
    		this.Controls.Add(this.chkBlack);
    		this.Controls.Add(this.checkBox1);
    		this.Controls.Add(this.chkDefault);
    		this.Controls.Add(this.chbPage);
    		this.Controls.Add(this.chkPrint);
    		this.Controls.Add(this.groupBox1);
    		this.Controls.Add(this.label7);
    		this.Controls.Add(this.txtImageHW);
    		this.Controls.Add(this.chkimg);
    		this.Controls.Add(this.label6);
    		this.Controls.Add(this.txtversion);
    		this.Controls.Add(this.label5);
    		this.Controls.Add(this.txtqcodeweight);
    		this.Controls.Add(this.chkQR);
    		this.Controls.Add(this.lbw);
    		this.Controls.Add(this.lbh);
    		this.Controls.Add(this.label4);
    		this.Controls.Add(this.label3);
    		this.Controls.Add(this.label2);
    		this.Controls.Add(this.txtNo);
    		this.Controls.Add(this.label1);
    		this.Controls.Add(this.txtRightDeviation);
    		this.Controls.Add(this.chkLandscape);
    		this.Controls.Add(this.chkpreview);
    		this.Controls.Add(this.listPagesize);
    		this.Controls.Add(this.chkCustom);
    		this.Controls.Add(this.lb);
    		this.Controls.Add(this.lheight);
    		this.Controls.Add(this.cmbPrint);
    		this.Controls.Add(this.txtImageJson);
    		this.Controls.Add(this.txtW);
    		this.Controls.Add(this.txtH);
    		this.Controls.Add(this.btnPrint);
    		this.Name = "Form1";
    		this.Text = "打印测试小程序";
    		this.Load += new System.EventHandler(this.Form1_Load);
    		this.groupBox1.ResumeLayout(false);
    		this.groupBox1.PerformLayout();
    		this.ResumeLayout(false);
    		this.PerformLayout();
    	}
    }
}
