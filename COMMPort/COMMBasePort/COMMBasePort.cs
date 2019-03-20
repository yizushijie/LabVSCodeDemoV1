using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harry.LabCOMMPort
{
    /// <summary>
    /// CRC校验方式
    /// </summary>
    public enum USE_CRC:byte
    {
        CRC_NONE = 0,           //---无校验方式
        CRC_CHECKSUM = 1,       //---检验和
        CRC_CRC8 = 2,           //---CRC8校验
        CRC_CRC16 = 3,          //---CRC16校验
        CRC_CRC32 = 4,          //---CRC32校验
    };

    /// <summary>
	/// 通信状态
	/// </summary>
	public enum USE_STATE : byte
    {
        IDLE = 0,                       //---空闲状态
        POLL_READ = 1,                  //---轮训读取状态
        WRITE=2,                        //---写入状态
        EVENT_READ=3,                   //---事件读取状态
        ERROR = 4,                      //---错误状态
    };

    /// <summary>
    /// 数据通讯结构
    /// </summary>
    public struct COMMDATASTRUCT
    {
        /// <summary>
        /// crc校验值
        /// </summary>
        public UInt32 commCRCVal;

        /// <summary>
        /// 使用的CRC方式
        /// </summary>
        public USE_STATE commCRC;

        /// <summary>
        /// 数据存储
        /// </summary>
        public List<byte> commByte;

    };

    /// <summary>
    /// 通讯串口的参数
    /// </summary>
    public struct COMMSerialPortParam
    {
        string name;
        int bandRate;
        Parity parity;
        int databit;
        StopBits stopBits;
    };

    public partial class COMMBasePort
    {
        #region 变量定义

        /// <summary>
        /// 通讯端口
        /// </summary>
        private string commName = null;

        /// <summary>
        /// 通讯端口的索引号
        /// </summary>
        private int commIndex = 0;

        /// <summary>
        /// 通讯端口的工作状态
        /// </summary>
        private USE_STATE commSTATE = USE_STATE.IDLE;

        /// <summary>
        /// 写数据的缓存区
        /// </summary>
        private int commWriteBufferSize = 64;

        /// <summary>
        /// 写数据的校验方式
        /// </summary>
        private USE_CRC commWriteCRC = USE_CRC.CRC_NONE;

        /// <summary>
        /// 写数据的信息
        /// </summary>
        private COMMDATASTRUCT commWriteData = new COMMDATASTRUCT();

        /// <summary>
        /// 读数据的缓存区
        /// </summary>
        private int commReadBufferSize = 64;

        /// <summary>
        /// 读数据的校验方式
        /// </summary>
        private USE_CRC commReadCRC = USE_CRC.CRC_NONE;

        /// <summary>
        /// 读数据的信息
        /// </summary>
        private COMMDATASTRUCT commReadData = new COMMDATASTRUCT();

        /// <summary>
        /// 通信耗时
        /// </summary>
        private TimeSpan commTime= TimeSpan.MinValue;

        /// <summary>
        /// 通讯错误信息
        /// </summary>
        private string commErrMsg = string.Empty;

        /// <summary>
        /// 使用的船体
        /// </summary>
        private Form commForm = null;

        /// <summary>
        /// 通讯写数据报头
        /// </summary>
        private byte commWriteID = 0x55;

        /// <summary>
        /// 通讯读数据报头
        /// </summary>
        private byte commReadID = 0x55;

        /// <summary>
        /// 多设备通信是否使能
        /// </summary>
        private bool commIsMultiDevice = false;

        /// <summary>
        /// 多设备通讯过程中的设备id号
        /// </summary>
        private byte commMultiDeviceID = 0;

        #endregion

        #region 属性定义
        /// <summary>
        /// 通讯端口
        /// </summary>
        public virtual string m_COMMName
        {
            get
            {
                return this.commName;
            }
            set
            {
                this.commName = value;
            }
        }

        /// <summary>
        /// 通讯端口的索引号
        /// </summary>
        public virtual int m_COMMIndex
        {
            get
            {
                return this.commIndex;
            }
            set
            {
                this.commIndex = value;
            }
        }

        /// <summary>
        /// 通讯端口的工作状态
        /// </summary>
        public virtual USE_STATE m_COMMSTATE
        {
            get
            {
                return this.commSTATE;
            }
            set
            {
                this.commSTATE = value;
            }
        }

        /// <summary>
        /// 写数据的缓存区
        /// </summary>
        public virtual int m_COMMWriteBufferSize
        {
            get
            {
                return this.commWriteBufferSize;
            }
            set
            {
                this.commWriteBufferSize = value;
            }

        }

        /// <summary>
        /// 写数据的校验方式
        /// </summary>
        public virtual USE_CRC m_COMMWriteCRC
        {
            get
            {
                return this.commWriteCRC;
            }
            set
            {
                this.commWriteCRC = value;
            }
        }

        /// <summary>
        /// 写数据的信息
        /// </summary>
        public virtual COMMDATASTRUCT m_COMMWriteData
        {
            get
            {
                return this.commWriteData;
            }
            set
            {
                this.commWriteData = value;
            }
        }

        /// <summary>
        /// 读数据的缓存区
        /// </summary>
        public virtual int m_COMMReadBufferSize
        {
            get
            {
                return this.commReadBufferSize;
            }
            set
            {
                this.commReadBufferSize = value;
            }
        }

        /// <summary>
        /// 读数据的校验方式
        /// </summary>
        public virtual USE_CRC m_COMMReadCRC
        {
            get
            {
                return this.commReadCRC;
            }
            set
            {
                this.commReadCRC = value;
            }
        }

        /// <summary>
        /// 读数据的信息
        /// </summary>
        public virtual COMMDATASTRUCT m_COMMReadData
        {
            get
            {
                return this.commReadData;
            }
            set
            {
                this.commReadData = value;
            }
        }

        /// <summary>
        /// 通信耗时
        /// </summary>
        public virtual TimeSpan m_COMMTime
        {
            get
            {
                return this.commTime;
            }
            set
            {
                this.commTime = value;
            }
        }

        /// <summary>
        /// 通讯错误信息
        /// </summary>
        public virtual string m_COMMErrMsg
        {
            get
            {
                return this.commErrMsg;
            }
            set
            {
                this.commErrMsg = value;
            }
        }
        /// <summary>
        /// 通讯写数据报头
        /// </summary>
        public virtual byte m_COMMWriteID
        {
            get
            {
                return this.commWriteID;
            }
            set
            {
                this.commWriteID=value;
            }
        }

        /// <summary>
        /// 通讯读数据报头
        /// </summary>
        public virtual byte m_COMMReadID
        {
            get
            {
                return this.commReadID;
            }
            set
            {
                this.commReadID = value;
            }
        }

        /// <summary>
        /// 多设备通信是否使能
        /// </summary>
        public virtual bool m_COMMIsMultiDevice
        {
            get
            {
                return this.commIsMultiDevice;
            }
            set
            {
                this.commIsMultiDevice = value;
            }
        }

        /// <summary>
        /// 多设备通讯过程中的设备id号
        /// </summary>
        public virtual byte m_COMMMultiDeviceID
        {
            get
            {
                return this.commMultiDeviceID;
            }
            set
            {
                this.commMultiDeviceID = value;
            }
        }

        #endregion

        #region 构造函数

        /// <summary>
        /// 
        /// </summary>
        public COMMBasePort()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argForm"></param>
        public COMMBasePort(Form argForm)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isMultiDevice"></param>
        /// <param name="multiDeviceID"></param>
        /// <param name="msg"></param>
        public COMMBasePort(bool isMultiDevice,byte multiDeviceID,RichTextBox msg)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argForm"></param>
        /// <param name="isMultiDevice"></param>
        /// <param name="multiDeviceID"></param>
        /// <param name="msg"></param>
        public COMMBasePort(Form argForm,bool isMultiDevice, byte multiDeviceID, RichTextBox msg)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bandRate"></param>
        /// <param name="msg"></param>
        public COMMBasePort(int bandRate, RichTextBox msg)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argForm"></param>
        /// <param name="bandRate"></param>
        /// <param name="msg"></param>
        public COMMBasePort(Form argForm, int bandRate, RichTextBox msg)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bandRate"></param>
        /// <param name="msg"></param>
        public COMMBasePort(COMMSerialPortParam commSerialPortParam, RichTextBox msg)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commSerialPortParam"></param>
        /// <param name="msg"></param>
        public COMMBasePort(Form argForm, COMMSerialPortParam commSerialPortParam, RichTextBox msg)
        {

        }


        #endregion

        #region 析构函数

        /// <summary>
		/// 析构函数
		/// </summary>
		~COMMBasePort()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region 函数定义

        #endregion

        #region 事件定义


        /// <summary>
        /// 委托事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void COMMEventHandler(object sender, EventArgs e);


        /// <summary>
        /// 接收事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Description("委托接收事件"), Category("自定义事件")]
        private event COMMEventHandler OnReceivedEvent = null;

        /// <summary>
        /// 事件的属性为读写
        /// </summary>
        public virtual COMMEventHandler m_OnReceivedEvent
        {
            get
            {
                return this.OnReceivedEvent;
            }
            set
            {
                //---判断事件是否为空，避免多次进入
                if (this.OnReceivedEvent!= null)
                {
                    this.OnReceivedEvent = null;
                }
                this.OnReceivedEvent = value;
            }
        }


        /// <summary>
        /// 通讯数据接收事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void COMMReceivedEventHandler(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
