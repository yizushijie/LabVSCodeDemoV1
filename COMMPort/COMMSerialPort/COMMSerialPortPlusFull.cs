using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabCOMMPort
{
	public partial class COMMSerialPortPlusFull : COMMBasePortPlus
	{
		#region 属性定义

		public override COMMBasePort m_COMMPort
		{
			get
			{
				return base.m_COMMPort;
			}

			set
			{
				base.m_COMMPort = value;
			}
		}

		#endregion

		#region 构造函数
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlusFull():base()
		{
			InitializeComponent();
			this.InitControl();
			base.Init();
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlusFull(Form argForm)
		{
			InitializeComponent();
			this.InitControl();
			base.Init(argForm);
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlusFull(RichTextBox argRichTextBox)
		{
			InitializeComponent();
			this.InitControl();
			base.Init(argRichTextBox);
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlusFull(Form argForm, RichTextBox argRichTextBox)
		{
			InitializeComponent();
			this.InitControl();
			base.Init(argForm, argRichTextBox);
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlusFull(Form argForm, COMMBasePort argCOMM,  RichTextBox argRichTextBox)
		{
			InitializeComponent();
			this.InitControl();
			this.Init(argForm, argCOMM, argRichTextBox);
		}

		#endregion

		#region 函数定义

		/// <summary>
		/// 
		/// </summary>
		public virtual void InitControl()
		{
			this.comboBox_COMMPortBaudRate.SelectedIndex = 7;
			this.comboBox_COMMPortDataBits.SelectedIndex = 0;
			this.comboBox_COMMPortStopBits.SelectedIndex = 0;
			this.comboBox_COMMPortParity.SelectedIndex = 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="argCOMM"></param>
		/// <param name="argComboBox"></param>
		/// <param name="argRichTextBox"></param>
		public override void Init(Form argForm, COMMBasePort argCOMM,RichTextBox argRichTextBox)
		{
			base.m_COMMForm = argForm;
			this.m_COMMPort = (COMMSerialPort)argCOMM;
			base.m_COMMRichTextBox = argRichTextBox;
		}

		/// <summary>
		/// 
		/// </summary>
		public override void AddWatcherPort()
		{
			base.AddWatcherPort();
		}

		#endregion
	}
}
