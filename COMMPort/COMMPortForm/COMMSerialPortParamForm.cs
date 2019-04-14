using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harry.LabCOMMPort
{
	public partial class COMMSerialPortParamForm : COMMBaseForm
	{

		#region 变量定义


		#endregion

		#region 属性定义

		/// <summary>
		/// 配置参数
		/// </summary>
		public virtual COMMSerialPortParam m_COMMSerialPortParam
		{
			get
			{
				return this.commSerialPortPlusFullParam.m_COMMSerialPortParam;
			}
		}

		#endregion

		#region 构造函数

		/// <summary>
		/// 
		/// </summary>

		public COMMSerialPortParamForm()
		{
			InitializeComponent();
			//---限定最小尺寸
			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cbb"></param>
		public COMMSerialPortParamForm(string argName)
		{
			InitializeComponent();
			//---限定最小尺寸
			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;
			//---
			this.Init(argName);

		}

		#endregion

		#region 函数定义

		#region 公共函数

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cbb"></param>
		public virtual void Init(string argName)
		{
			this.commSerialPortPlusFullParam.m_COMMComboBox.Items.Clear();
			this.commSerialPortPlusFullParam.m_COMMComboBox.Items.Add(argName);
			this.commSerialPortPlusFullParam.m_COMMComboBox.SelectedIndex = 0;

			//---通信端口的名称不可更改
			this.commSerialPortPlusFullParam.RefreshComboBox(this.commSerialPortPlusFullParam.m_COMMComboBox, false);

			//---注册事件
			this.commSerialPortPlusFullParam.m_ButtonCOMMInit.Click += new EventHandler(this.Button_Click);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void Button_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		/// <summary>
		/// 
		/// </summary>
		public override void CloseForm()
		{
			base.CloseForm();
		}

		#endregion

		#endregion

	}
}
