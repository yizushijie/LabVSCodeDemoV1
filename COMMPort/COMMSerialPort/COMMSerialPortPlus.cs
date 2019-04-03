using Harry.LabUserControlPlus;
using System;
using System.Windows.Forms;

namespace Harry.LabCOMMPort
{
	public partial class COMMSerialPortPlus : COMMBasePortPlus
	{

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
		public override PictureBox m_PictureBox_COMMState
		{
			get
			{
				return base.m_PictureBox_COMMState;
			}
			set
			{
				base.m_PictureBox_COMMState = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public override Button m_Button_COMMInit
		{
			get
			{
				return base.m_Button_COMMInit;
			}
			set
			{
				base.m_Button_COMMInit = value;
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

			this.AddEventHandler();
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(Form argForm)
		{
			InitializeComponent();

			base.Init(argForm);

			this.AddEventHandler();
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(RichTextBox argRichTextBox)
		{
			InitializeComponent();

			base.Init(argRichTextBox);

			this.AddEventHandler();
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(Form argForm, RichTextBox argRichTextBox)
		{
			InitializeComponent();

			base.Init(argForm,argRichTextBox);

			this.AddEventHandler();
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPortPlus(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox)
		{ 
			InitializeComponent();
			this.Init(argForm, argCOMM,argRichTextBox);

			this.AddEventHandler();
		}

		#endregion

		#region 重载函数

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
		public override void Init(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox,bool isRefreshDevice)
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
			if (isRefreshDevice==true)
			{
				if (this.m_COMMPort!=null)
				{
					this.m_COMMPort.GetPortNames(this.m_COMMComboBox, argRichTextBox);
				}
			}
			if (isAddWatcherPort==true)
			{
				//---注册端口监控
				this.AddWatcherPort();
			}
		}

		/// <summary>
		/// 添加端口拔插事件
		/// </summary>
		public override void AddWatcherPort()
		{
			base.AddWatcherPort();
		}

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

		#endregion

		#region 私有函数

		/// <summary>
		/// 注册事件处理函数
		/// </summary>
		private void AddEventHandler()
		{
			if (this.m_COMMPort!=null)
			{
				this.m_COMMPort.m_OnRemoveDeviceEvent = AddWatcherPortRemove;
			}
		}
		
		#endregion

	}
}
