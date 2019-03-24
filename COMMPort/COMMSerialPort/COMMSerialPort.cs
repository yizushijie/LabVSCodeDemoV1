
using Harry.LabUserControlPlus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Harry.LabCOMMPort
{
	public class COMMSerialPort:COMMBasePort
    {
        #region 变量定义

        /// <summary>
        /// 使用的串口
        /// </summary>
        private SerialPort commSerialPort = null;

		/// <summary>
		/// 设备索引列表
		/// </summary>
		private List<byte> commIndexMemu = new List<byte>();

		#endregion

		#region 属性定义

		#region 自定义属性

		#endregion

		#region 重载属性

		/// <summary>
		/// 通讯端口
		/// </summary>
		public override string m_COMMName
        {
            get
            {
                return base.m_COMMName;
            }
            set
            {
                base.m_COMMName = value;
            }
        }
	    
        /// <summary>
        /// 通讯端口的索引号
        /// </summary>
        public override int m_COMMIndex
        {
            get
            {
                return base.m_COMMIndex;
            }
            set
            {
                base.m_COMMIndex = value;
            }
        }
	    
        /// <summary>
        /// 通讯端口的工作状态
        /// </summary>
        public override USE_STATE m_COMMSTATE
        {
            get
            {
                return base.m_COMMSTATE;
            }
            set
            {
                base.m_COMMSTATE = value;
            }
        }
	    
        /// <summary>
        /// 写数据的缓存区
        /// </summary>
        public override int m_COMMWriteBufferSize
        {
            get
            {
                return base.m_COMMWriteBufferSize;
            }
            set
            {
                base.m_COMMWriteBufferSize = value;
            }
	    
        }
	    
        /// <summary>
        /// 写数据的校验方式
        /// </summary>
        public override USE_CRC m_COMMWriteCRC
        {
            get
            {
                return base.m_COMMWriteCRC;
            }
            set
            {
                base.m_COMMWriteCRC = value;
            }
        }
	    
        /// <summary>
        /// 写数据的信息
        /// </summary>
        public override COMMDataType m_COMMWriteData
        {
            get
            {
                return base.m_COMMWriteData;
            }
            set
            {
                base.m_COMMWriteData = value;
            }
        }
	    
        /// <summary>
        /// 读数据的缓存区
        /// </summary>
        public override int m_COMMReadBufferSize
        {
            get
            {
                return base.m_COMMReadBufferSize;
            }
            set
            {
                base.m_COMMReadBufferSize = value;
            }
        }
	    
        /// <summary>
        /// 读数据的校验方式
        /// </summary>
        public override USE_CRC m_COMMReadCRC
        {
            get
            {
                return base.m_COMMReadCRC;
            }
            set
            {
                base.m_COMMReadCRC = value;
            }
        }
	    
        /// <summary>
        /// 读数据的信息
        /// </summary>
        public override COMMDataType m_COMMReadData
        {
            get
            {
                return base.m_COMMReadData;
            }
            set
            {
                base.m_COMMReadData = value;
            }
        }
	    
        /// <summary>
        /// 通信耗时
        /// </summary>
        public override TimeSpan m_COMMTime
        {
            get
            {
                return base.m_COMMTime;
            }
            set
            {
                base.m_COMMTime = value;
            }
        }
	    
        /// <summary>
        /// 通讯错误信息
        /// </summary>
        public override string m_COMMErrMsg
        {
            get
            {
                return base.m_COMMErrMsg;
            }
            set
            {
                base.m_COMMErrMsg = value;
            }
        }

		/// <summary>
		/// 使用的窗体
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
		/// 通讯写数据报头
		/// </summary>
		public override byte m_COMMWriteID
        {
            get
            {
                return base.m_COMMWriteID;
            }
            set
            {
                base.m_COMMWriteID = value;
            }
        }
	    
        /// <summary>
        /// 通讯读数据报头
        /// </summary>
        public override byte m_COMMReadID
        {
            get
            {
                return base.m_COMMReadID;
            }
            set
            {
                base.m_COMMReadID = value;
            }
        }
	    
        /// <summary>
        /// 多设备通信是否使能
        /// </summary>
        public override bool m_COMMIsMultiDevice
        {
            get
            {
                return base.m_COMMIsMultiDevice;
            }
            set
            {
                base.m_COMMIsMultiDevice = value;
            }
        }
	    
        /// <summary>
        /// 多设备通讯过程中的设备id号
        /// </summary>
        public override byte m_COMMMultiDeviceID
        {
            get
            {
                return base.m_COMMMultiDeviceID;
            }
            set
            {
                base.m_COMMMultiDeviceID = value;
            }
        }

		/// <summary>
		/// 消息显示窗口
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
		/// 端口控件
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

		#endregion

		#region 构造函数

		/// <summary>
		/// 
		/// </summary>
		public COMMSerialPort():base()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		public COMMSerialPort(Form argForm)
		{
			this.m_COMMForm = argForm;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		public COMMSerialPort(Form argForm, ComboBox cbb, RichTextBox msg)
		{
			this.m_COMMForm = argForm;
			this.m_COMMComboBox = cbb;
			this.m_COMMRichTextBox = msg;
			this.GetPortNames(cbb, msg);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		public COMMSerialPort(Form argForm,string argName,RichTextBox msg)
		{
			this.m_COMMForm = argForm;
			this.Init(argName,msg);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="isMultiDevice"></param>
		/// <param name="multiDeviceID"></param>
		/// <param name="msg"></param>
		public COMMSerialPort(bool isMultiDevice, byte multiDeviceID, RichTextBox msg)
		{
			this.m_COMMIsMultiDevice = isMultiDevice;
			this.m_COMMMultiDeviceID = multiDeviceID;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="isMultiDevice"></param>
		/// <param name="multiDeviceID"></param>
		/// <param name="msg"></param>
		public COMMSerialPort(Form argForm, bool isMultiDevice, byte multiDeviceID, RichTextBox msg)
		{
			this.m_COMMForm = argForm;
			this.m_COMMIsMultiDevice = isMultiDevice;
			this.m_COMMMultiDeviceID = multiDeviceID;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bandRate"></param>
		/// <param name="msg"></param>
		public COMMSerialPort(COMMSerialPortParam commSerialPortParam, RichTextBox msg)
		{
			this.Init(commSerialPortParam, msg);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="commSerialPortParam"></param>
		/// <param name="msg"></param>
		public COMMSerialPort(Form argForm, COMMSerialPortParam commSerialPortParam, RichTextBox msg)
		{
			this.m_COMMForm = argForm;
			this.Init(commSerialPortParam, msg);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="isMultiDevice"></param>
		/// <param name="multiDeviceID"></param>
		/// <param name="msg"></param>
		public COMMSerialPort(COMMSerialPortParam commSerialPortParam, bool isMultiDevice, byte multiDeviceID, RichTextBox msg)
		{
			this.Init(commSerialPortParam, msg);
			this.m_COMMIsMultiDevice = isMultiDevice;
			this.m_COMMMultiDeviceID = multiDeviceID;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="isMultiDevice"></param>
		/// <param name="multiDeviceID"></param>
		/// <param name="msg"></param>
		public COMMSerialPort(Form argForm, COMMSerialPortParam commSerialPortParam, bool isMultiDevice, byte multiDeviceID, RichTextBox msg)
		{
			this.m_COMMForm = argForm;
			this.Init(commSerialPortParam, msg);
			this.m_COMMIsMultiDevice = isMultiDevice;
			this.m_COMMMultiDeviceID = multiDeviceID;
		}
		
		#endregion

		#region 析构函数

		/// <summary>
		/// 析构函数
		/// </summary>
		~COMMSerialPort()
		{
			GC.SuppressFinalize(this);
		}

		#endregion

		#region 函数定义

		#region 自定义函数

		/// <summary>
		/// 获取校验位信息
		/// </summary>
		/// <param name="parity"></param>
		/// <returns></returns>
		private Parity GetParityBits(string parityBits)
		{
			//---获取校验位
			Parity _return = new Parity();

			//---奇校验
			if (parityBits.StartsWith("奇") || parityBits.StartsWith("Odd") || parityBits.StartsWith("ODD") || parityBits.StartsWith("odd") || parityBits.StartsWith("oDD"))
			{
				_return = Parity.Odd;
			}

			//---偶校验
			else if (parityBits.StartsWith("偶") || parityBits.StartsWith("Even") || parityBits.StartsWith("EVEN") || parityBits.StartsWith("even") || parityBits.StartsWith("eVEN"))
			{
				_return = Parity.Even;
			}

			//---无校验位
			else
			{
				_return = Parity.None;
			}
			return _return;
		}

		/// <summary>
		/// 获取停止位
		/// </summary>
		/// <param name="stopBits"></param>
		/// <returns></returns>
		private StopBits GetStopBits(string stopBits)
		{
			//---获取校验位
			StopBits _return = new StopBits();
			try
			{
				double stopVal = Math.Truncate(Convert.ToDouble(stopBits));

				int temp = (int)(stopVal * 10);

				//---1位停止位
				if (temp == 10)
				{
					_return = StopBits.One;
				}

				//---1.5位停止位
				else if (temp == 15)
				{
					_return = StopBits.OnePointFive;
				}

				//---2位停止位
				else if (temp == 20)
				{
					_return = StopBits.Two;
				}
				else
				{
					_return = StopBits.None;
				}
			}
			catch
			{
				_return = StopBits.None;
			}
			return _return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public List<byte> GetPortIndex( string[] argNames )
		{
			if ((argNames.Length==0)||(argNames==null))
			{
				return null;
			}
			List<byte> temp = new List<byte>();
			List<byte> _return = new List<byte>();
			//---遍历端口信息
			for (int index = 0; index < argNames.Length; index++)
			{
				//---判断端口名称是否合法
				if (argNames[index].StartsWith("COM") || argNames[index].StartsWith("com"))
				{
					//---去除字符串中非数字字符
					string str = Regex.Replace(argNames[index], @"[^\d]*", "");
					//---将字符串转换成数字
					temp.Add((byte)(int.Parse(str)));
				}
			}
			//---从到大小排列数据
			_return.AddRange((temp.ToArray().OrderBy(x => x).ToArray()));
			//---返回测试结果
			return _return;
		}

		/// <summary>
		/// 获取设备的端口
		/// </summary>
		public void GetPortNames(ComboBox cbb,RichTextBox msg=null)
		{
			//---获取当前设备的端口
			string[] argNames = SerialPort.GetPortNames();
			if ((argNames==null)||(argNames.Length==0))
			{
				this.commIndexMemu = new List<byte>();
				if (cbb != null)
				{
					//---异步调用
					if (cbb.InvokeRequired)
					{
						cbb.Invoke((EventHandler)
								 (delegate
								 {
									 cbb.Items.Clear();
									 cbb.SelectedIndex = -1;
								 }));
					}
					else
					{
						cbb.Items.Clear();
						cbb.SelectedIndex = -1;
					}
				}
				if (msg != null)
				{
					RichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, "获取设备失败，请插入设备！\r\n", Color.Red, false);
				}
			}
			else
			{
				this.commIndexMemu = this.GetPortIndex(argNames);
				if (cbb != null)
				{
					//---异步调用
					if (cbb.InvokeRequired)
					{
						cbb.Invoke((EventHandler)
								 (delegate
								 {
									 cbb.Items.Clear();
									 for (int i = 0; i < this.commIndexMemu.Count; i++)
									 {
										 cbb.Items.Add("COM" + this.commIndexMemu[i].ToString());
									 }
									 cbb.SelectedIndex = 0;
								 }));
					}
					else
					{
						cbb.Items.Clear();
						for (int i = 0; i < this.commIndexMemu.Count; i++)
						{
							cbb.Items.Add("COM" + this.commIndexMemu[i].ToString());
						}
						cbb.SelectedIndex = 0;
					}
				}
				if (msg != null)
				{
					RichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, "获取设备成功，请选择设备！\r\n", Color.Black, false);
				}
			}
			
		}

		#endregion

		#region 重载函数

		/// <summary>
		/// 初始化
		/// </summary>
		/// <returns></returns>
		public override int Init()
		{
			return 1;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cbb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int Init(ComboBox cbb, RichTextBox msg =null)
		{
			this.GetPortNames(cbb, msg);
			return 0;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <returns></returns>
		public override int Init(string argName, RichTextBox msg = null)
		{
			if (this.commSerialPort==null)
			{
				this.commSerialPort = new SerialPort();
			}
			if (this.commSerialPort.IsOpen)
			{
				this.commSerialPort.Close();
			}
			this.commSerialPort.PortName = argName;
			//---端口名称
			this.m_COMMName = argName;
			//---获取端口序号
			this.m_COMMIndex = Convert.ToInt16(this.m_COMMName.Replace("COM", ""), 10);

			return 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <param name="bandRate"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int Init(string argName, int bandRate, RichTextBox msg = null)
		{
			if (this.commSerialPort == null)
			{
				this.commSerialPort = new SerialPort();
			}
			if (this.commSerialPort.IsOpen)
			{
				this.commSerialPort.Close();
			}
			this.commSerialPort.PortName = argName;
			this.commSerialPort.BaudRate = bandRate;

			//---端口名称
			this.m_COMMName = argName;
			//---获取端口序号
			this.m_COMMIndex = Convert.ToInt16(this.m_COMMName.Replace("COM", ""), 10);

			return 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <param name="commSerialPortParam"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int Init(COMMSerialPortParam commSerialPortParam, RichTextBox msg = null)
		{
			if (this.commSerialPort == null)
			{
				this.commSerialPort = new SerialPort();
			}
			if (this.commSerialPort.IsOpen)
			{
				this.commSerialPort.Close();
			}
			this.commSerialPort.PortName = commSerialPortParam.name;
			this.commSerialPort.BaudRate = int.Parse(commSerialPortParam.baudRate);
			this.commSerialPort.Parity = this.GetParityBits(commSerialPortParam.parity);
			this.commSerialPort.StopBits = this.GetStopBits(commSerialPortParam.stopBits);
			this.commSerialPort.DataBits = int.Parse(commSerialPortParam.dataBits);

			//---端口名称
			this.m_COMMName = commSerialPortParam.name;
			//---获取端口序号
			this.m_COMMIndex = Convert.ToInt16(this.m_COMMName.Replace("COM", ""), 10);

			return 0;
		}

		/// <summary>
		/// 设置多设备通信
		/// </summary>
		/// <param name="isMultiDevice"></param>
		/// <param name="multiDeviceID"></param>
		/// <returns></returns>
		public override void SetMultiDevice(bool isMultiDevice, byte multiDeviceID)
		{
			this.m_COMMIsMultiDevice = isMultiDevice;
			this.m_COMMMultiDeviceID = multiDeviceID;
		}

		/// <summary>
		/// 设备从设备的ID信息
		/// </summary>
		/// <param name="multiDeviceID"></param>
		public override void SetMultiDeviceID(byte multiDeviceID)
		{
			this.m_COMMMultiDeviceID = multiDeviceID;
		}
		/// <summary>
		/// 清除多设备模式
		/// </summary>
		public override void ClearMultiDevice()
		{
			this.m_COMMIsMultiDevice = false;
			this.m_COMMMultiDeviceID = 0;
		}

		/// <summary>
		/// 添加监控设备
		/// </summary>
		/// <returns></returns>
		public override bool AddWatcherPort(ComboBox cbb=null, RichTextBox msg=null)
		{
			this.m_COMMComboBox = cbb;
			this.m_COMMRichTextBox = msg;
			return base.AddWatcherPortEvent(this.WatcherPortEventHandler, this.WatcherPortEventHandler, new TimeSpan(0, 0, 1));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argForm"></param>
		/// <param name="cbb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override bool AddWatcherPort(Form argForm, ComboBox cbb = null, RichTextBox msg = null)
		{
			this.m_COMMForm = argForm;
			this.m_COMMComboBox = cbb;
			this.m_COMMRichTextBox = msg;
			return base.AddWatcherPortEvent(this.WatcherPortEventHandler, this.WatcherPortEventHandler, new TimeSpan(0, 0, 1));
		}

		/// <summary>
		/// 添加设备
		/// </summary>
		/// <returns></returns>
		public override int AddDevice()
		{
			return this.AddDevice(null,null);
		}

		/// <summary>
		/// 添加设备
		/// </summary>
		/// <param name="cbb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int AddDevice(ComboBox cbb, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 移除设备
		/// </summary>
		/// <returns></returns>
		public override int RemoveDevice()
		{
			return this.RemoveDevice(null,null);
		}

		/// <summary>
		/// 移除设备
		/// </summary>
		/// <param name="cbb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int RemoveDevice(ComboBox cbb, RichTextBox msg = null)
		{
			int _return = 0;
			//---获取当前设备存在的通信端口
			string[] argNames = SerialPort.GetPortNames();
			
			return _return;
		}

		/// <summary>
		/// 刷新设备
		/// </summary>
		/// <returns></returns>
		public override int RefreshDevice()
		{
			return RefreshDevice(null,null);
		}

		/// <summary>
		/// 刷新设备
		/// </summary>
		/// <param name="cbb"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int RefreshDevice(ComboBox cbb, RichTextBox msg = null)
		{
			int _return = 0;
			//---获取当前设备存在的通信端口
			string[] argNames = SerialPort.GetPortNames();

			return _return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int WriteToDevice(byte cmd, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <param name="cmd"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int WriteToDevice(string argName, byte cmd, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int WriteToDevice(byte[] cmd, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int WriteToDevice(ref byte[] cmd, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <param name="cmd"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int WriteToDevice(string argName, byte[] cmd, RichTextBox msg = null)
		{
			return 1;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <param name="cmd"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int WriteToDevice(string argName, ref byte[] cmd, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="timeout"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int ReadFromDevice(ref byte[] cmd, int timeout = 200, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <param name="cmd"></param>
		/// <param name="timeout"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int ReadFromDevice(string argName, ref byte[] cmd, int timeout = 200, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="res"></param>
		/// <param name="timeout"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int SendCmdAndReadResponse(byte[] cmd, ref byte[] res, int timeout = 200, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="res"></param>
		/// <param name="timeout"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int SendCmdAndReadResponse(ref byte[] cmd, ref byte[] res, int timeout = 200, RichTextBox msg = null)
		{
			return 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override int OpenDevice()
		{
			int _return = 0;
			if ((this.m_COMMIndex != 0)&&(this.commSerialPort!=null))
			{
				//---判断当前端口是否可用
				if (this.commSerialPort.IsOpen)
				{
					//---响应窗体事件
					Application.DoEvents();
					//---关闭端口
					this.commSerialPort.Close();
				}
				//---判断端口状态
				if (this.commSerialPort.IsOpen == false)
				{
					//---获取端口名称
					if (this.commSerialPort.PortName != this.m_COMMName)
					{
						this.commSerialPort.PortName = m_COMMName;
					}

					//---打开端口
					this.commSerialPort.Open();
					//---判断端口打开是否成功
					if (this.commSerialPort.IsOpen == false)
					{
						this.m_COMMErrMsg = "端口：" + this.m_COMMName + "打开失败!\r\n";
						_return = 1;
					}
				}
				else
				{
					this.m_COMMErrMsg = "端口：" + this.m_COMMName + "初始化失败!\r\n";
					_return = 2;
				}
				//---消息显示
				if (_return == 0)
				{
					RichTextBoxPlus.AppendTextInfoTopWithDataTime(this.m_COMMRichTextBox, "端口：" + this.m_COMMName + "打开成功!\r\n", Color.Black, false);
				}
				//---消息插件弹出
				if (_return != 0)
				{
					MessageBoxPlus.Show(this.m_COMMForm, this.m_COMMErrMsg + "\r\n" + "错误号：" + _return.ToString() + "\r\n", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBoxPlus.Show(this.m_COMMForm, "端口名称不合法!\r\n", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_return = 3;
			}
			return _return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int OpenDevice(string argName, RichTextBox msg = null)
		{
			int _return = 0;
			if (((argName != string.Empty) && (argName != null) && (argName != "") && (argName.StartsWith("COM"))))
			{
				//---判断串口类是否有效
				if (this.commSerialPort == null)
				{
					this.m_COMMErrMsg = "端口对象参数配置错误！\r\n";
					_return = 1;
				}
				else
				{

					//---判断当前端口是否可用
					if (this.commSerialPort.IsOpen)
					{
						//---响应窗体事件
						Application.DoEvents();
						//---关闭端口
						this.commSerialPort.Close();
					}
					//---判断端口状态
					if (this.commSerialPort.IsOpen==false)
					{
						//---获取端口名称
						if (this.commSerialPort.PortName != argName)
						{
							this.commSerialPort.PortName = argName;
							this.m_COMMName = argName;
						}
						//---获取端口序号
						this.m_COMMIndex = Convert.ToInt16(this.m_COMMName.Replace("COM", ""), 10);

						//---打开端口
						this.commSerialPort.Open();
						//---判断端口打开是否成功
						if (this.commSerialPort.IsOpen == false)
						{
							this.m_COMMErrMsg = "端口：" + this.m_COMMName + "打开失败!\r\n";
							_return = 2;
						}
					}
					else
					{
						this.m_COMMErrMsg = "端口：" + this.m_COMMName + "初始化失败!\r\n";
						_return = 3;
					}
				}
				
				//---消息显示
				if (_return==0)
				{
					RichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, "端口：" + this.m_COMMName + "打开成功!\r\n", Color.Black, false);
				}
				//---消息插件弹出
				if (_return != 0)
				{
					MessageBoxPlus.Show(this.m_COMMForm, this.m_COMMErrMsg+"\r\n"+ "错误号："+_return.ToString()+"\r\n", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			else
			{
				MessageBoxPlus.Show(this.m_COMMForm, "端口名称不合法!\r\n", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_return = 4;
			}
			return _return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <param name="baudRate"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int OpenDevice(string argName, int baudRate, RichTextBox msg = null)
		{
			int _return = 0;
			if (((argName != string.Empty) && (argName != null) && (argName != "") && (argName.StartsWith("COM"))))
			{
				//---判断串口类是否有效
				if (this.commSerialPort == null)
				{
					this.m_COMMErrMsg = "端口对象参数配置错误！\r\n";
					_return = 1;
				}
				else
				{

					//---判断当前端口是否可用
					if (this.commSerialPort.IsOpen)
					{
						//---响应窗体事件
						Application.DoEvents();
						//---关闭端口
						this.commSerialPort.Close();
					}
					//---判断端口状态
					if (this.commSerialPort.IsOpen == false)
					{
						//---获取端口名称
						if (this.commSerialPort.PortName != argName)
						{
							this.commSerialPort.PortName = argName;
							this.m_COMMName = argName;
						}
						//---获取端口序号
						this.m_COMMIndex = Convert.ToInt16(this.m_COMMName.Replace("COM", ""), 10);

						//---配置波特率
						this.commSerialPort.BaudRate = baudRate;

						//---打开端口
						this.commSerialPort.Open();
						//---判断端口打开是否成功
						if (this.commSerialPort.IsOpen == false)
						{
							this.m_COMMErrMsg = "端口：" + this.m_COMMName + "打开失败!\r\n";
							_return = 2;
						}
					}
					else
					{
						this.m_COMMErrMsg = "端口：" + this.m_COMMName + "初始化失败!\r\n";
						_return = 3;
					}
				}

				//---消息显示
				if (_return == 0)
				{
					RichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, "端口：" + this.m_COMMName + "打开成功!\r\n", Color.Black, false);
				}
				//---消息插件弹出
				if (_return != 0)
				{
					MessageBoxPlus.Show(this.m_COMMForm, this.m_COMMErrMsg + "\r\n" + "错误号：" + _return.ToString() + "\r\n", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			else
			{
				MessageBoxPlus.Show(this.m_COMMForm, "端口名称不合法!\r\n", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_return = 4;
			}
			return _return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="commSerialPortParam"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int OpenDevice(COMMSerialPortParam commSerialPortParam, RichTextBox msg = null)
		{
			int _return = 0;
			if (!Regex.IsMatch(commSerialPortParam.baudRate, @"^[+-]?/d*[.]?/d*$") || !Regex.IsMatch(commSerialPortParam.dataBits, @"^[+-]?/d*[.]?/d*$"))
			{
				_return=1;
				this.m_COMMErrMsg = "端口参数错误!\r\n";
			}
			else
			{
				if (this.commSerialPort==null)
				{
					this.commSerialPort = new SerialPort(); 
				}
				if (this.commSerialPort.IsOpen)
				{
					Application.DoEvents();
					this.commSerialPort.Close();
				}
				if (this.commSerialPort.IsOpen)
				{
					_return = 2;
					this.m_COMMErrMsg = "端口：" + this.m_COMMName + "初始化失败!\r\n";
				}
				else
				{
					this.commSerialPort.PortName = commSerialPortParam.name;
					this.commSerialPort.BaudRate = int.Parse(commSerialPortParam.baudRate);
					this.commSerialPort.Parity = this.GetParityBits(commSerialPortParam.parity);
					this.commSerialPort.StopBits = this.GetStopBits(commSerialPortParam.stopBits);
					this.commSerialPort.DataBits = int.Parse(commSerialPortParam.dataBits);
					//---端口名称
					this.m_COMMName = commSerialPortParam.name;
					//---获取端口序号
					this.m_COMMIndex = Convert.ToInt16(this.m_COMMName.Replace("COM", ""), 10);
					//---打开端口
					this.commSerialPort.Open();
					//---判断端口打开是否成功
					if (this.commSerialPort.IsOpen == false)
					{
						this.m_COMMErrMsg = "端口：" + this.m_COMMName + "打开失败!\r\n";
						_return = 3;
					}
				}

			}
			//---消息显示
			if (_return == 0)
			{
				RichTextBoxPlus.AppendTextInfoTopWithDataTime(msg, "端口：" + this.m_COMMName + "打开成功!\r\n", Color.Black, false);
			}
			//---消息插件弹出
			if (_return != 0)
			{
				MessageBoxPlus.Show(this.m_COMMForm, this.m_COMMErrMsg + "\r\n" + "错误号：" + _return.ToString() + "\r\n", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return _return;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override int CloseDevice()
		{
			int _return = 0;
			if ((this.commSerialPort!=null)&&(this.m_COMMIndex!=0))
			{
				if (this.commSerialPort.IsOpen)
				{
					this.commSerialPort.Close();
					if (this.commSerialPort.IsOpen==false)
					{
						this.m_COMMErrMsg = "端口关闭成功！\r\n";
					}
					else
					{
						this.m_COMMErrMsg = "端口关闭失败！\r\n";
						_return = 1;
					}
					this.m_COMMName = null;
					this.m_COMMIndex = 0;
				}
				else
				{
					this.m_COMMErrMsg = "端口初始化失败！\r\n";
					_return = 2;
				}
			}
			else
			{
				this.m_COMMErrMsg = "端口对象未初始化！\r\n";
				_return = 3;
			}
			//---消息插件弹出
			if (_return != 0)
			{
				MessageBoxPlus.Show(this.m_COMMForm, this.m_COMMErrMsg + "\r\n" + "错误号：" + _return.ToString() + "\r\n", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return _return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="argName"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public override int CloseDevice(string argName, RichTextBox msg = null)
		{
			int _return = 0;
			if (this.commSerialPort != null)
			{
				if (this.commSerialPort.PortName==argName)
				{
					if (this.commSerialPort.IsOpen)
					{
						this.commSerialPort.Close();
						if (this.commSerialPort.IsOpen == false)
						{
							this.m_COMMErrMsg = "端口关闭成功！\r\n";
						}
						else
						{
							this.m_COMMErrMsg = "端口关闭失败！\r\n";
							_return = 1;
						}
					}
					else
					{
						this.m_COMMErrMsg = "端口初始化失败！\r\n";
						_return = 2;
					}
					this.m_COMMName = null;
					this.m_COMMIndex = 0;
				}
				else
				{
					this.m_COMMErrMsg = "端口名称不匹配！\r\n";
					_return = 3;
				}
			}
			else
			{
				this.m_COMMErrMsg = "端口对象未初始化！\r\n";
				_return = 4;
			}
			//---消息插件弹出
			if (_return != 0)
			{
				MessageBoxPlus.Show(this.m_COMMForm, this.m_COMMErrMsg + "\r\n" + "错误号：" + _return.ToString() + "\r\n", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return _return;
		}

		/// <summary>
		/// 检测设备
		/// </summary>
		/// <returns></returns>
		public override bool IsAttached()
		{
			if (this.commSerialPort!=null)
			{
				return this.commSerialPort.IsOpen;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="portIndex"></param>
		/// <returns></returns>
		public override bool IsAttached(string argName)
		{

			if ((this.commSerialPort != null) && (this.commSerialPort.PortName == argName))
			{
				return this.commSerialPort.IsOpen;
			}
			else
			{
				return false;
			}
		}

		#endregion

		#endregion

		#region 事件定义
		/// <summary>
		/// 事件的属性为读写
		/// </summary>
		public override COMMEventHandler m_OnReceivedEvent
		{
			get
			{
				return base.m_OnReceivedEvent;
			}
			set
			{
				base.m_OnReceivedEvent = value;
			}
		}

		/// <summary>
		/// 通讯数据接收事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public override void COMMReceivedEventHandler(object sender, EventArgs e)
		{
			string str = e.ToString();
			//---判断事件的类型
			if ((str == "SerialDataReceivedEventArgs") || (str == "System.IO.Ports.SerialDataReceivedEventArgs"))
			{
				if ( (this.m_OnReceivedEvent != null)&&(this.m_COMMSTATE==USE_STATE.IDLE) )
				{
					this.m_COMMSTATE = USE_STATE.EVENT_READ;
					//---执行委托函数
					this.m_OnReceivedEvent(sender, e);
					//---置位执行完成
					this.m_COMMSTATE = USE_STATE.IDLE;
				}
			}
		}


		/// <summary>
		/// 监控端口事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <param name="cbb"></param>
		/// <param name="msg"></param>
		public override void WatcherPortEventHandler(Object sender, EventArrivedEventArgs e)
		{
			if (e.NewEvent.ClassPath.ClassName == "__InstanceCreationEvent")
			{
				this.AddDevice(this.m_COMMComboBox, this.m_COMMRichTextBox);
			}
			else if (e.NewEvent.ClassPath.ClassName == "__InstanceDeletionEvent")
			{
				this.RemoveDevice(this.m_COMMComboBox, this.m_COMMRichTextBox);
			}
		}

		#endregion

	}
}
