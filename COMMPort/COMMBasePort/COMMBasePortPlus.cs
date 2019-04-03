using Harry.LabUserControlPlus;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Harry.LabCOMMPort
{
	public partial class COMMBasePortPlus : UserControl,IDisposable
    {
		#region 变量定义

		/// <summary>
		/// 窗体
		/// </summary>
		private Form commForm = null;

		/// <summary>
		/// 消息
		/// </summary>
		private RichTextBox commRichTextBox = null;

		/// <summary>
		/// 端口
		/// </summary>
		private COMMBasePort commPort = null;

		#endregion


		#region 属性定义

		/// <summary>
		/// 
		/// </summary>
		public virtual Form m_COMMForm
		{
			get
			{
				return this.commForm;
			}
			set
			{
				if (this.commForm==null)
				{
					this.commForm = new Form();
				}
				this.commForm = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public virtual RichTextBox m_COMMRichTextBox
		{
			get
			{
				return this.commRichTextBox;
			}
			set
			{
				if (this.commRichTextBox == null)
				{
					this.commRichTextBox = new RichTextBox();
				}
				this.commRichTextBox = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public virtual ComboBox m_COMMComboBox
		{
			get
			{
				return this.comboBox_COMMName;
			}
			set
			{
				if (value != null)
				{
					this.comboBox_COMMName = value;
				}
			}
		}

		/// <summary>
		/// 端口
		/// </summary>
		public virtual COMMBasePort m_COMMPort
		{
			get
			{
				return this.commPort;
			}
			set
			{
				if (this.commPort == null)
				{
					this.commPort = new COMMBasePort();
				}
				this.commPort = value;
			}
		}

		/// <summary>
		/// 状态图片
		/// </summary>
		public virtual PictureBox m_PictureBox_COMMState
		{
			get
			{
				return this.pictureBox_COMMState;
			}
			set
			{
				this.pictureBox_COMMState=value;
			}
		}

		/// <summary>
		/// 设备初始化按钮
		/// </summary>
		public virtual Button m_Button_COMMInit
		{
			get
			{
				return this.button_COMMInit;
			}
			set
			{
				this.button_COMMInit = value;
			}
		}
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 
		/// </summary>
		public COMMBasePortPlus()
		{
			InitializeComponent();
			this.Init();

			this.AddEventHandler();
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMBasePortPlus(Form argForm)
		{
			InitializeComponent();

			this.Init(argForm);

			this.AddEventHandler();
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMBasePortPlus(RichTextBox argRichTextBox)
		{
			InitializeComponent();

			this.Init(argRichTextBox);

			this.AddEventHandler();
		}

		public COMMBasePortPlus(Form argForm, RichTextBox argRichTextBox)
		{
			InitializeComponent();

			this.Init(argForm, argRichTextBox);

			this.AddEventHandler();
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMBasePortPlus(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox)
		{
			InitializeComponent();
			this.Init(argForm, argCOMM, argRichTextBox);

			this.AddEventHandler();
		}

		#endregion

		#region 函数定义

		/// <summary>
		/// 
		/// </summary>
		public virtual void Init()
		{
			this.commForm = null;
			this.commRichTextBox = null;
			this.commPort = null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		public virtual void Init(Form argForm)
		{
			this.m_COMMForm = argForm;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="argComboBox"></param>
		/// <param name="argRichTextBox"></param>
		public virtual void Init(RichTextBox argRichTextBox)
		{
			this.m_COMMRichTextBox = argRichTextBox;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="argComboBox"></param>
		/// <param name="argRichTextBox"></param>
		public virtual void Init(Form argForm,RichTextBox argRichTextBox)
		{
			this.m_COMMForm = argForm;
			this.m_COMMRichTextBox = argRichTextBox;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="argCOMM"></param>
		/// <param name="argComboBox"></param>
		/// <param name="argRichTextBox"></param>
		public virtual void Init(Form argForm, COMMBasePort argCOMM,RichTextBox argRichTextBox)
		{
			this.m_COMMForm = argForm;
			this.m_COMMRichTextBox = argRichTextBox;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="argCOMM"></param>
		/// <param name="argRichTextBox"></param>
		public virtual void Init(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox, bool isRefreshDevice)
		{
			this.m_COMMForm = argForm;
			this.m_COMMRichTextBox = argRichTextBox;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="argCOMM"></param>
		/// <param name="argRichTextBox"></param>
		/// <param name="isRefreshDevice"></param>
		/// <param name="isAddWatcherPort"></param>
		public virtual void Init(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox, bool isRefreshDevice,bool isAddWatcherPort)
		{
			this.m_COMMForm = argForm;
			this.m_COMMRichTextBox = argRichTextBox;
		}

		/// <summary>
		/// 添加端口监控
		/// </summary>
		public virtual void AddWatcherPort()
		{
			if (this.m_COMMPort!=null)
			{
				if (this.m_COMMForm!=null)
				{
					this.m_COMMPort.AddWatcherPort(this.comboBox_COMMName, this.m_COMMRichTextBox);
				}
				else
				{
					this.m_COMMPort.AddWatcherPort(this.m_COMMForm,this.comboBox_COMMName, this.m_COMMRichTextBox);
				}
			}
		}


		/// <summary>
		/// 监控端口的移除处理函数
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public virtual void AddWatcherPortRemove(object sender, System.EventArgs e)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public virtual void Button_Clik(object sender, System.EventArgs e)
		{
			Button btn = (Button)sender;
			btn.Enabled = false;
			switch (btn.Name)
			{
				case "button_COMMInit":

					if (btn.Text == "打开设备")
					{
						if ((this.commPort!=null)&&(this.commPort.OpenDevice(this.comboBox_COMMName.Text, this.commRichTextBox) == 0))
						{
							btn.Text = "关闭设备";
							this.pictureBox_COMMState.Image = Properties.Resources.open;
							
							//---消息显示
							if (this.commRichTextBox != null)
							{
								RichTextBoxPlus.AppendTextInfoTopWithDataTime(this.commRichTextBox, "设备打开成功!\r\n", Color.Black, false);
							}

							//---加载设备移除处理
							if (this.commPort.m_OnRemoveDeviceEvent==null)
							{
								this.commPort.m_OnRemoveDeviceEvent = AddWatcherPortRemove;
							}
						}
						else
						{
							this.pictureBox_COMMState.Image = Properties.Resources.error;
							if (this.commRichTextBox != null)
							{
								RichTextBoxPlus.AppendTextInfoTopWithDataTime(this.commRichTextBox, "设备打开失败!\r\n", Color.Red, false);
							}
						}
					}
					else if (btn.Text == "关闭设备")
					{
						if (this.commPort != null)
						{
							this.commPort.CloseDevice();
							btn.Text = "打开设备";
							this.pictureBox_COMMState.Image = Properties.Resources.lost;
							
							//---消息显示
							if (this.commRichTextBox != null)
							{
								RichTextBoxPlus.AppendTextInfoTopWithDataTime(this.commRichTextBox, "设备关闭成功!\r\n", Color.Black, false);
							}
						}
					}
					else
					{
						MessageBoxPlus.Show(this.commForm, "设备操作异常！错误操作：" + btn.Text, "错误提示");
					}
					break;

				default:
					break;
			}
			btn.Enabled = true;
		}

		/// <summary>
		/// 图片单击事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public virtual void PictureBox_Click(object sender, System.EventArgs e)
		{
			PictureBox ptb = (PictureBox)sender;
			ptb.Enabled = false;
			switch (ptb.Name)
			{
				case "pictureBox_COMMState":
					if (button_COMMInit.Text == "打开设备")
					{
						if (this.commPort!=null)
						{
							//---刷新设备
							this.commPort.RefreshDevice(this.comboBox_COMMName, this.commRichTextBox);
						}
					}
					break;
				default:
					break;
			}
			ptb.Enabled = true;
		}


		#endregion

		#region 私有函数

		/// <summary>
		/// 添加事件处理函数
		/// </summary>
		private void AddEventHandler()
		{
			this.button_COMMInit.Click += new System.EventHandler(this.Button_Clik);
			this.pictureBox_COMMState.Click += new EventHandler(this.PictureBox_Click);
				 
		}

		#endregion
	}
}
