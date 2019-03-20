using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harry.LabCOMMPort
{
    public class COMMSerialPort:COMMBasePort
    {
        #region 变量定义

        /// <summary>
        /// 使用的串口
        /// </summary>
        private SerialPort commSerialPort = null; 

        #endregion

        #region 属性定义

        #region 自定义属性

        public SerialPort m_COMMSerialPort
        {
            get
            {
                return this.commSerialPort;
            }
            set
            {
                this.commSerialPort = value;
            }
        }

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
        public override COMMDATASTRUCT m_COMMWriteData
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
        public override COMMDATASTRUCT m_COMMReadData
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

		#endregion

		#endregion

		#region 构造函数

		#endregion

		#region 析构函数

		#endregion

		#region 函数定义

		#region 自定义函数

		#endregion

		#region 重载函数

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

		#endregion

	}
}
