using Harry.LabCOMMPort;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestForms
{
	public partial class TestForm : Form
	{

		private COMMBasePort usedPort = null;

		public TestForm()
		{
			InitializeComponent();
		}
		
		private void TestForm_Load(object sender, EventArgs e)
		{
			this.usedPort = new COMMSerialPort();
			this.commSerialPortPlus1.Init(this,this.usedPort,this.richTextBoxEx1,true,true);
		}
	}
}
