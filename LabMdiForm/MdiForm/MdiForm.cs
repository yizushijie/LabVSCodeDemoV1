
using Harry.LabUserControlPlus;
using System;
using System.Windows.Forms;

namespace Harry.LabMdiForm
{
    public partial class MdiForm : Form
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public MdiForm()
        {
            InitializeComponent();

            //---注册船体加载事件
            this.Load += new System.EventHandler(this.MdiForm_FormLoad);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="argForm"></param>
        public MdiForm(Form argForm)
        {
            InitializeComponent();

            //---注册船体加载事件
            this.Load += new System.EventHandler(this.MdiForm_FormLoad);
        }

        #endregion

        #region 初始化

        /// <summary>
        /// 船体初始化函数
        /// </summary>
        private void MdiForm_Init()
        {
            //---事件注册
            this.FormClosing += new FormClosingEventHandler(this.MdiForm_FormClosing);

            //---退出操作
            this.ToolStripMenuItem_Exit.Click += new EventHandler(this.ToolStripMenuItem_Click);
        }

        #endregion

        #region 事件处理

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MdiForm_FormLoad(object sender, System.EventArgs e)
        {
            this.MdiForm_Init();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MdiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.None:
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                case CloseReason.MdiFormClosing:
                case CloseReason.UserClosing:
                    if (DialogResult.OK == MessageBoxPlus.Show(this, "你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        if (this.IsMdiContainer)
                        {
                            //----为保证Application.Exit();时不再弹出提示，所以将FormClosing事件取消
                            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.MdiForm_FormClosing);
                        }

                        //---确认关闭事件
                        e.Cancel = false;

                        //---退出当前窗体
                        this.Dispose();
                    }
                    else
                    {
                        //---取消关闭事件
                        e.Cancel = true;
                    }
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.ApplicationExitCall:
                    break;
                default:
                    break;
            }
        }

        
        /// <summary>
        /// 菜单单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            tsm.Enabled = false;
            switch (tsm.Name)
            {
                //---退出操作
                case "ToolStripMenuItem_Exit":
                    if (DialogResult.OK == MessageBoxPlus.Show(this, "你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        if (this.IsMdiContainer)
                        {
                            //----为保证Application.Exit();时不再弹出提示，所以将FormClosing事件取消
                            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.MdiForm_FormClosing);
                        }
                        
                        //---退出当前窗体
                        this.Dispose();
                    }
                    break;
                //---调用计算器
                case "ToolStripMenuItem_Calc":
                    break;
                //---调用文本编辑器
                case "ToolStripMenuItem_TXT":
                    break;
                default:
                    break;
            }
            tsm.Enabled = true;
        }

        #endregion


    }
}
