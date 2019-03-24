using System.Windows.Forms;

namespace Harry.LabCOMMPort
{
	public partial class COMMBasePortPlus : UserControl
    {
		#region 变量定义

		/// <summary>
		/// 
		/// </summary>
		private Form commForm = null;

		/// <summary>
		/// 
		/// </summary>
		private RichTextBox commRichTextBox = null;

		/// <summary>
		/// 
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
				return this.comboBox_COMMPortName;
			}
			set
			{
				if (value != null)
				{
					this.comboBox_COMMPortName = value;
				}
			}
		}

		/// <summary>
		/// 
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

		#endregion

		#region 构造函数
		/// <summary>
		/// 
		/// </summary>
		public COMMBasePortPlus()
		{
			InitializeComponent();
			this.Init();
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMBasePortPlus(Form argForm)
		{
			InitializeComponent();

			this.Init(argForm);
		}
		/// <summary>
		/// 
		/// </summary>
		public COMMBasePortPlus(RichTextBox argRichTextBox)
		{
			InitializeComponent();

			this.Init(argRichTextBox);
		}

		public COMMBasePortPlus(Form argForm, RichTextBox argRichTextBox)
		{
			InitializeComponent();

			this.Init(argForm, argRichTextBox);
		}

		/// <summary>
		/// 
		/// </summary>
		public COMMBasePortPlus(Form argForm, COMMBasePort argCOMM, RichTextBox argRichTextBox)
		{
			InitializeComponent();
			this.Init(argForm, argCOMM, argRichTextBox);
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
		public virtual void AddWatcherPort()
		{
			if (this.m_COMMPort!=null)
			{
				if (this.m_COMMForm!=null)
				{
					this.m_COMMPort.AddWatcherPort(this.comboBox_COMMPortName, this.m_COMMRichTextBox);
				}
				else
				{
					this.m_COMMPort.AddWatcherPort(this.m_COMMForm,this.comboBox_COMMPortName, this.m_COMMRichTextBox);
				}
			}
		}
		#endregion
	}
}
