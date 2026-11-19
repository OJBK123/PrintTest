using System.ComponentModel;
using System.Windows.Forms;

namespace testPrint
{
    partial class frmDataFormat
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
    	private IContainer components = null;

    	private TextBox textBox1;

    	private DateTimePicker dateTimePicker1;

    	private Button button1;

    	private Button button2;

    	private Button button4;

    	internal DateTimePicker dtpStart;

    	private DateTimePicker dateTimePicker2;

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
    		this.textBox1 = new System.Windows.Forms.TextBox();
    		this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
    		this.button1 = new System.Windows.Forms.Button();
    		this.button2 = new System.Windows.Forms.Button();
    		this.button4 = new System.Windows.Forms.Button();
    		this.dtpStart = new System.Windows.Forms.DateTimePicker();
    		this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
    		this.SuspendLayout();
    		this.textBox1.Location = new System.Drawing.Point(39, 116);
    		this.textBox1.Multiline = true;
    		this.textBox1.Name = "textBox1";
    		this.textBox1.Size = new System.Drawing.Size(198, 119);
    		this.textBox1.TabIndex = 0;
    		this.dateTimePicker1.Location = new System.Drawing.Point(39, 45);
    		this.dateTimePicker1.Name = "dateTimePicker1";
    		this.dateTimePicker1.Size = new System.Drawing.Size(723, 21);
    		this.dateTimePicker1.TabIndex = 1;
    		this.button1.Location = new System.Drawing.Point(317, 175);
    		this.button1.Name = "button1";
    		this.button1.Size = new System.Drawing.Size(138, 60);
    		this.button1.TabIndex = 2;
    		this.button1.Text = "修改电脑短日期格式";
    		this.button1.UseVisualStyleBackColor = true;
    		this.button1.Click += new System.EventHandler(this.button1_Click);
    		this.button2.Location = new System.Drawing.Point(317, 109);
    		this.button2.Name = "button2";
    		this.button2.Size = new System.Drawing.Size(138, 60);
    		this.button2.TabIndex = 2;
    		this.button2.Text = "修改电脑日期格式";
    		this.button2.UseVisualStyleBackColor = true;
    		this.button2.Click += new System.EventHandler(this.button2_Click);
    		this.button4.Location = new System.Drawing.Point(317, 241);
    		this.button4.Name = "button4";
    		this.button4.Size = new System.Drawing.Size(138, 60);
    		this.button4.TabIndex = 2;
    		this.button4.Text = "修改电脑长日期格式";
    		this.button4.UseVisualStyleBackColor = true;
    		this.button4.Click += new System.EventHandler(this.button4_Click);
    		this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm";
    		this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
    		this.dtpStart.Location = new System.Drawing.Point(39, 72);
    		this.dtpStart.Name = "dtpStart";
    		this.dtpStart.Size = new System.Drawing.Size(136, 21);
    		this.dtpStart.TabIndex = 8;
    		this.dateTimePicker2.Location = new System.Drawing.Point(581, 139);
    		this.dateTimePicker2.Name = "dateTimePicker2";
    		this.dateTimePicker2.Size = new System.Drawing.Size(136, 21);
    		this.dateTimePicker2.TabIndex = 9;
    		this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
    		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    		this.ClientSize = new System.Drawing.Size(804, 345);
    		this.Controls.Add(this.dateTimePicker2);
    		this.Controls.Add(this.dtpStart);
    		this.Controls.Add(this.button4);
    		this.Controls.Add(this.button2);
    		this.Controls.Add(this.button1);
    		this.Controls.Add(this.dateTimePicker1);
    		this.Controls.Add(this.textBox1);
    		this.Name = "frmDataFormat";
    		this.Text = "frmDataFormat";
    		this.Load += new System.EventHandler(this.frmDataFormat_Load);
    		this.ResumeLayout(false);
    		this.PerformLayout();
    	}
    }
}
