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
	public partial class COMMSerialPortPlus : COMMBasePortPlus
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

		/// <summary>
		/// 
		/// </summary>
		public override ComboBox m_COMMComboBox
		{
			get
			{
				return base.m_COMMComboBox;
			}

			set
			{
				base.m_COMMComboBox = value;
			}
		}

		#endregion

		#region 构造函数
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus():base()
		{
			InitializeComponent();
			base.Init();
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(Form argForm)
		{
			InitializeComponent();

			base.Init(argForm);
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(RichTextBox argRichTextBox)
		{
			InitializeComponent();

			base.Init(argRichTextBox);
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(Form argForm, RichTextBox argRichTextBox)
		{
			InitializeComponent();

			base.Init(argForm,argRichTextBox);
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox)
		{ 
			InitializeComponent();
			this.Init(argForm, argCOMM,argRichTextBox);
		}

		#endregion

		#region 函数定义

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="argCOMM"></param>
		/// <param name="argComboBox"></param>
		/// <param name="argRichTextBox"></param>
		public override void Init(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox)
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
