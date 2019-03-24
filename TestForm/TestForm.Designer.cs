namespace TestForms
{
	partial class TestForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.richTextBoxEx1 = new Harry.LabUserControlPlus.RichTextBoxEx();
			this.commBasePortPlus1 = new Harry.LabCOMMPort.COMMBasePortPlus();
			this.commSerialPortPlusFull1 = new Harry.LabCOMMPort.COMMSerialPortPlusFull();
			this.commSerialPortPlus1 = new Harry.LabCOMMPort.COMMSerialPortPlus();
			this.appContainer1 = new Harry.LabUserControlPlus.PanelPlus();
			this.SuspendLayout();
			// 
			// richTextBoxEx1
			// 
			this.richTextBoxEx1.Location = new System.Drawing.Point(0, 339);
			this.richTextBoxEx1.Name = "richTextBoxEx1";
			this.richTextBoxEx1.Size = new System.Drawing.Size(420, 165);
			this.richTextBoxEx1.TabIndex = 2;
			this.richTextBoxEx1.Text = "";
			// 
			// commBasePortPlus1
			// 
			this.commBasePortPlus1.Location = new System.Drawing.Point(0, 257);
			this.commBasePortPlus1.m_COMMForm = null;
			this.commBasePortPlus1.m_COMMPort = null;
			this.commBasePortPlus1.m_COMMRichTextBox = null;
			this.commBasePortPlus1.Name = "commBasePortPlus1";
			this.commBasePortPlus1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.commBasePortPlus1.Size = new System.Drawing.Size(267, 61);
			this.commBasePortPlus1.TabIndex = 3;
			// 
			// commSerialPortPlusFull1
			// 
			this.commSerialPortPlusFull1.Location = new System.Drawing.Point(0, 60);
			this.commSerialPortPlusFull1.m_COMMForm = null;
			this.commSerialPortPlusFull1.m_COMMPort = null;
			this.commSerialPortPlusFull1.m_COMMRichTextBox = null;
			this.commSerialPortPlusFull1.Name = "commSerialPortPlusFull1";
			this.commSerialPortPlusFull1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.commSerialPortPlusFull1.Size = new System.Drawing.Size(157, 191);
			this.commSerialPortPlusFull1.TabIndex = 1;
			// 
			// commSerialPortPlus1
			// 
			this.commSerialPortPlus1.Location = new System.Drawing.Point(0, 2);
			this.commSerialPortPlus1.m_COMMForm = null;
			this.commSerialPortPlus1.m_COMMPort = null;
			this.commSerialPortPlus1.m_COMMRichTextBox = null;
			this.commSerialPortPlus1.Name = "commSerialPortPlus1";
			this.commSerialPortPlus1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.commSerialPortPlus1.Size = new System.Drawing.Size(267, 61);
			this.commSerialPortPlus1.TabIndex = 0;
			// 
			// appContainer1
			// 
			this.appContainer1.Location = new System.Drawing.Point(469, 156);
			this.appContainer1.Name = "appContainer1";
			this.appContainer1.Size = new System.Drawing.Size(480, 320);
			this.appContainer1.TabIndex = 4;
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 516);
			this.Controls.Add(this.appContainer1);
			this.Controls.Add(this.commBasePortPlus1);
			this.Controls.Add(this.richTextBoxEx1);
			this.Controls.Add(this.commSerialPortPlusFull1);
			this.Controls.Add(this.commSerialPortPlus1);
			this.Name = "TestForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.TestForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Harry.LabCOMMPort.COMMSerialPortPlus commSerialPortPlus1;
		private Harry.LabCOMMPort.COMMSerialPortPlusFull commSerialPortPlusFull1;
		private Harry.LabUserControlPlus.RichTextBoxEx richTextBoxEx1;
		private Harry.LabCOMMPort.COMMBasePortPlus commBasePortPlus1;
		private Harry.LabUserControlPlus.PanelPlus appContainer1;
	}
}

