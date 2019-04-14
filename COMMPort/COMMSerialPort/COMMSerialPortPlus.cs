using Harry.LabUserControlPlus;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Harry.LabCOMMPort
{
	public partial class COMMSerialPortPlus : COMMBasePortPlus
	{

		#region 变量定义
		/// <summary>
		/// 右键功能按键
		/// </summary>
		private ContextMenuStrip usedContextMenuStrip = new ContextMenuStrip();

		#endregion

		#region 属性定义


		#region 重载属性
		/// <summary>
		/// 窗体
		/// </summary>
		public override Form m_COMMForm
		{
			get
			{
				return base.m_COMMForm;
			}
			set
			{
				base.m_COMMForm = value;
			}
		}

		/// <summary>
		/// 消息
		/// </summary>
		public override RichTextBox m_COMMRichTextBox
		{
			get
			{
				return base.m_COMMRichTextBox;
			}
			set
			{
				base.m_COMMRichTextBox = value;
			}
		}

		/// <summary>
		/// 端口
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

		/// <summary>
		/// 
		/// </summary>
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
		public override PictureBox m_PictureBoxCOMMState
		{
			get
			{
				return base.m_PictureBoxCOMMState;
			}
			set
			{
				base.m_PictureBoxCOMMState = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public override Button m_ButtonCOMMInit
		{
			get
			{
				return base.m_ButtonCOMMInit;
			}
			set
			{
				base.m_ButtonCOMMInit = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public override GroupBox m_GroupBoxCOMMName
		{
			get
			{
				return base.m_GroupBoxCOMMName;
			}
			set
			{ 
				base. m_GroupBoxCOMMName = value;
			}
		}

		/// <summary>
		/// 配置端口参数
		/// </summary>
		public override COMMSerialPortParam m_COMMSerialPortParam
		{
			get
			{
				return base.m_COMMSerialPortParam;
			} 
			set
			{
				base.m_COMMSerialPortParam = value;
			} 
		}

		#endregion


		#endregion

		#region 构造函数
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus():base()
		{
			InitializeComponent();
			base.Init();

			this.AddCOMMSerialPortParam();

			//this.AddWatcherPortRemoveEvent();
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(Form argForm)
		{
			InitializeComponent();

			base.Init(argForm);

			this.AddCOMMSerialPortParam();

			//this.AddWatcherPortRemoveEvent();
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(RichTextBox argRichTextBox)
		{
			InitializeComponent();

			base.Init(argRichTextBox);

			this.AddCOMMSerialPortParam();

			//this.AddWatcherPortRemoveEvent();
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(Form argForm, RichTextBox argRichTextBox)
		{
			InitializeComponent();

			base.Init(argForm,argRichTextBox);

			this.AddCOMMSerialPortParam();

			//this.AddWatcherPortRemoveEvent();
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox)
		{ 
			InitializeComponent();
			this.Init(argForm, argCOMM,argRichTextBox);

			this.AddCOMMSerialPortParam();

			//this.AddWatcherPortRemoveEvent();
		}

		#endregion

		#region 函数定义

		#region 公共函数

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
		/// <param name="argForm"></param>
		/// <param name="argCOMM"></param>
		/// <param name="argComboBox"></param>
		/// <param name="argRichTextBox"></param>
		public override void Init(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox, bool isRefreshDevice)
		{
			base.m_COMMForm = argForm;
			this.m_COMMPort = (COMMSerialPort)argCOMM;
			base.m_COMMRichTextBox = argRichTextBox;
			//---判断是否属性设备
			if (isRefreshDevice)
			{
				this.m_COMMPort.GetPortNames(this.m_COMMComboBox, argRichTextBox);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="argCOMM"></param>
		/// <param name="argRichTextBox"></param>
		/// <param name="isRefreshDevice"></param>
		/// <param name="isAddWatcherPort"></param>
		public override void Init(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox, bool isRefreshDevice, bool isAddWatcherPort)
		{
			base.m_COMMForm = argForm;
			this.m_COMMPort = (COMMSerialPort)argCOMM;
			base.m_COMMRichTextBox = argRichTextBox;
			//---判断是否属性设备
			if (isRefreshDevice == true)
			{
				if (this.m_COMMPort != null)
				{
					this.m_COMMPort.GetPortNames(this.m_COMMComboBox, argRichTextBox);
				}
			}
			if (isAddWatcherPort == true)
			{
				//---注册端口监控
				base.AddWatcherPort();
			}
		}

		/*
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public override void AddWatcherPortRemove(object sender, EventArgs e)
		{
			if ((this.m_COMMPort.IsAttached()==false)&&(this.button_COMMInit.Text=="关闭设备"))
			{
				if (this.m_Button_COMMInit.InvokeRequired)
				{
					this.m_Button_COMMInit.BeginInvoke((EventHandler)
					//this.m_Button_COMMInit.Invoke((EventHandler)
								 (delegate
								 {
									 this.m_Button_COMMInit.Text = "打开设备";
								 }));
				}
				else
				{
					this.m_Button_COMMInit.Text = "打开设备";
				}
				//---执行端口关闭
				this.m_COMMPort.CloseDevice();
				//---刷新端口的只是ICO图标
				if (this.m_PictureBox_COMMState.InvokeRequired)
				{
					this.m_PictureBox_COMMState.BeginInvoke((EventHandler)
							 //this.m_PictureBox_COMMState.Invoke((EventHandler)
							 (delegate
							 {
								 this.m_PictureBox_COMMState.Image = Properties.Resources.lost;
							 }));
				}
				else
				{
					this.m_PictureBox_COMMState.Image = Properties.Resources.lost;
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public override void AddWatcherPortRemoveEvent()
		{
			if (this.m_COMMPort != null)
			{
				this.m_COMMPort.m_OnRemoveDeviceEvent = AddWatcherPortRemove;
			}
		}
		*/

		/// <summary>
		/// 设置参数
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void COMMSerialPortParam_Click(object sender, EventArgs e)
		{
			if ((this.m_COMMComboBox.Text!=null)&&(this.m_COMMComboBox.Items.Count>0))
			{
				COMMBaseForm p = new COMMSerialPortParamForm(this.m_COMMComboBox.Text);

				if (p.ShowDialog(this.m_COMMComboBox) != System.Windows.Forms.DialogResult.OK)
				{
					if (this.m_COMMRichTextBox != null)
					{
						RichTextBoxPlus.AppendTextInfoTopWithDataTime(this.m_COMMRichTextBox, "通信端口参数配置失败。\r\n", Color.Red, false);
					}
					return;
				}

				this.m_COMMSerialPortParam = ((COMMSerialPortParamForm) p).m_COMMSerialPortParam;

				if (this.m_COMMRichTextBox!=null)
				{
					RichTextBoxPlus.AppendTextInfoTopWithDataTime(this.m_COMMRichTextBox, "通信端口参数配置成功。\r\n", Color.Black, false);
				}

				p.CloseForm();
			}
		}

		#endregion

		#region 私有函数

		#endregion

		/// <summary>
		/// 添加串口参数配置
		/// </summary>
		private void AddCOMMSerialPortParam()
		{

			//---添加右键菜单
			//加载contextMenuTrip的子项---消息显示的清楚和
			ToolStripItem tsItem;

			this.ContextMenuStrip = this.usedContextMenuStrip;

			//---添加清楚消息的功能
			tsItem = ContextMenuPlus.AddContextMenu("参数配置", this.usedContextMenuStrip.Items, new EventHandler(this.COMMSerialPortParam_Click));

			this.ContextMenuStrip.Width = 32;
		}

		#endregion

	}
}
