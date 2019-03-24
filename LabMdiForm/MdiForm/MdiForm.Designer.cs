namespace Harry.LabMdiForm
{
    partial class MdiForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.menuStrip_MdiFormMenu = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Func = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Tool = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Calc = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_TXT = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Wind = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Printf = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_PrintfView = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Custom = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Option = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator_Tool1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator_File1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator_File2 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator_File3 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip_MdiFormStatu = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel_SysTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel_Separator1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer_MdiFormSysTime = new System.Windows.Forms.Timer(this.components);
			this.menuStrip_MdiFormMenu.SuspendLayout();
			this.statusStrip_MdiFormStatu.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip_MdiFormMenu
			// 
			this.menuStrip_MdiFormMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
			this.menuStrip_MdiFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Func,
            this.ToolStripMenuItem_Wind,
            this.ToolStripMenuItem_Tool,
            this.ToolStripMenuItem_Help});
			this.menuStrip_MdiFormMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip_MdiFormMenu.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_MdiFormMenu.Name = "menuStrip_MdiFormMenu";
			this.menuStrip_MdiFormMenu.Size = new System.Drawing.Size(1272, 28);
			this.menuStrip_MdiFormMenu.TabIndex = 2;
			this.menuStrip_MdiFormMenu.Text = "menuStrip1";
			// 
			// ToolStripMenuItem_File
			// 
			this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Open,
            this.ToolStripMenuItem_New,
            this.ToolStripSeparator_File1,
            this.ToolStripMenuItem_Save,
            this.ToolStripMenuItem_SaveAs,
            this.ToolStripSeparator_File2,
            this.ToolStripMenuItem_Printf,
            this.ToolStripMenuItem_PrintfView,
            this.ToolStripSeparator_File3,
            this.ToolStripMenuItem_Exit});
			this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
			this.ToolStripMenuItem_File.Size = new System.Drawing.Size(66, 24);
			this.ToolStripMenuItem_File.Text = "文件(&F)";
			// 
			// ToolStripMenuItem_Exit
			// 
			this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
			this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(180, 24);
			this.ToolStripMenuItem_Exit.Text = "退出(&X)";
			// 
			// ToolStripMenuItem_Edit
			// 
			this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
			this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(67, 24);
			this.ToolStripMenuItem_Edit.Text = "编辑(&E)";
			// 
			// ToolStripMenuItem_Func
			// 
			this.ToolStripMenuItem_Func.Name = "ToolStripMenuItem_Func";
			this.ToolStripMenuItem_Func.Size = new System.Drawing.Size(66, 24);
			this.ToolStripMenuItem_Func.Text = "功能(&F)";
			// 
			// ToolStripMenuItem_Tool
			// 
			this.ToolStripMenuItem_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Calc,
            this.ToolStripMenuItem_TXT,
            this.ToolStripSeparator_Tool1,
            this.ToolStripMenuItem_Custom,
            this.ToolStripMenuItem_Option});
			this.ToolStripMenuItem_Tool.Name = "ToolStripMenuItem_Tool";
			this.ToolStripMenuItem_Tool.Size = new System.Drawing.Size(67, 24);
			this.ToolStripMenuItem_Tool.Text = "工具(&T)";
			// 
			// ToolStripMenuItem_Calc
			// 
			this.ToolStripMenuItem_Calc.Name = "ToolStripMenuItem_Calc";
			this.ToolStripMenuItem_Calc.Size = new System.Drawing.Size(158, 24);
			this.ToolStripMenuItem_Calc.Text = "计算器(&Calc)";
			// 
			// ToolStripMenuItem_TXT
			// 
			this.ToolStripMenuItem_TXT.Name = "ToolStripMenuItem_TXT";
			this.ToolStripMenuItem_TXT.Size = new System.Drawing.Size(158, 24);
			this.ToolStripMenuItem_TXT.Text = "记事本(&TXT)";
			// 
			// ToolStripMenuItem_Wind
			// 
			this.ToolStripMenuItem_Wind.Name = "ToolStripMenuItem_Wind";
			this.ToolStripMenuItem_Wind.Size = new System.Drawing.Size(73, 24);
			this.ToolStripMenuItem_Wind.Text = "窗口(&W)";
			// 
			// ToolStripMenuItem_Help
			// 
			this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_About});
			this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
			this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(70, 24);
			this.ToolStripMenuItem_Help.Text = "帮助(&H)";
			// 
			// ToolStripMenuItem_New
			// 
			this.ToolStripMenuItem_New.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripMenuItem_New.Name = "ToolStripMenuItem_New";
			this.ToolStripMenuItem_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.ToolStripMenuItem_New.Size = new System.Drawing.Size(180, 24);
			this.ToolStripMenuItem_New.Text = "新建(&N)";
			// 
			// ToolStripMenuItem_Open
			// 
			this.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open";
			this.ToolStripMenuItem_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.ToolStripMenuItem_Open.Size = new System.Drawing.Size(180, 24);
			this.ToolStripMenuItem_Open.Text = "打开(&O)";
			// 
			// ToolStripMenuItem_Save
			// 
			this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
			this.ToolStripMenuItem_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(180, 24);
			this.ToolStripMenuItem_Save.Text = "保存(&S)";
			// 
			// ToolStripMenuItem_SaveAs
			// 
			this.ToolStripMenuItem_SaveAs.Name = "ToolStripMenuItem_SaveAs";
			this.ToolStripMenuItem_SaveAs.Size = new System.Drawing.Size(180, 24);
			this.ToolStripMenuItem_SaveAs.Text = "另存为(&A)";
			// 
			// ToolStripMenuItem_Printf
			// 
			this.ToolStripMenuItem_Printf.Name = "ToolStripMenuItem_Printf";
			this.ToolStripMenuItem_Printf.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.ToolStripMenuItem_Printf.Size = new System.Drawing.Size(180, 24);
			this.ToolStripMenuItem_Printf.Text = "打印(&P)";
			// 
			// ToolStripMenuItem_PrintfView
			// 
			this.ToolStripMenuItem_PrintfView.Name = "ToolStripMenuItem_PrintfView";
			this.ToolStripMenuItem_PrintfView.Size = new System.Drawing.Size(180, 24);
			this.ToolStripMenuItem_PrintfView.Text = "打印预览(&V)";
			// 
			// ToolStripMenuItem_Custom
			// 
			this.ToolStripMenuItem_Custom.Name = "ToolStripMenuItem_Custom";
			this.ToolStripMenuItem_Custom.Size = new System.Drawing.Size(158, 24);
			this.ToolStripMenuItem_Custom.Text = "自定义(&C)";
			// 
			// ToolStripMenuItem_Option
			// 
			this.ToolStripMenuItem_Option.Name = "ToolStripMenuItem_Option";
			this.ToolStripMenuItem_Option.Size = new System.Drawing.Size(158, 24);
			this.ToolStripMenuItem_Option.Text = "选项(&O)";
			// 
			// ToolStripSeparator_Tool1
			// 
			this.ToolStripSeparator_Tool1.Name = "ToolStripSeparator_Tool1";
			this.ToolStripSeparator_Tool1.Size = new System.Drawing.Size(155, 6);
			// 
			// ToolStripSeparator_File1
			// 
			this.ToolStripSeparator_File1.Name = "ToolStripSeparator_File1";
			this.ToolStripSeparator_File1.Size = new System.Drawing.Size(177, 6);
			// 
			// ToolStripSeparator_File2
			// 
			this.ToolStripSeparator_File2.Name = "ToolStripSeparator_File2";
			this.ToolStripSeparator_File2.Size = new System.Drawing.Size(177, 6);
			// 
			// ToolStripSeparator_File3
			// 
			this.ToolStripSeparator_File3.Name = "ToolStripSeparator_File3";
			this.ToolStripSeparator_File3.Size = new System.Drawing.Size(177, 6);
			// 
			// ToolStripMenuItem_About
			// 
			this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
			this.ToolStripMenuItem_About.Size = new System.Drawing.Size(152, 24);
			this.ToolStripMenuItem_About.Text = "关于(&A)";
			// 
			// statusStrip_MdiFormStatu
			// 
			this.statusStrip_MdiFormStatu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel_Separator1,
            this.ToolStripStatusLabel_SysTime});
			this.statusStrip_MdiFormStatu.Location = new System.Drawing.Point(0, 730);
			this.statusStrip_MdiFormStatu.Name = "statusStrip_MdiFormStatu";
			this.statusStrip_MdiFormStatu.Size = new System.Drawing.Size(1272, 22);
			this.statusStrip_MdiFormStatu.TabIndex = 4;
			this.statusStrip_MdiFormStatu.Text = "statusStrip1";
			// 
			// ToolStripStatusLabel_SysTime
			// 
			this.ToolStripStatusLabel_SysTime.Name = "ToolStripStatusLabel_SysTime";
			this.ToolStripStatusLabel_SysTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ToolStripStatusLabel_SysTime.Size = new System.Drawing.Size(134, 17);
			this.ToolStripStatusLabel_SysTime.Text = "系统时间：2019-03-24";
			// 
			// ToolStripStatusLabel_Separator1
			// 
			this.ToolStripStatusLabel_Separator1.Name = "ToolStripStatusLabel_Separator1";
			this.ToolStripStatusLabel_Separator1.Size = new System.Drawing.Size(1092, 17);
			this.ToolStripStatusLabel_Separator1.Spring = true;
			// 
			// timer_MdiFormSysTime
			// 
			this.timer_MdiFormSysTime.Enabled = true;
			this.timer_MdiFormSysTime.Interval = 1000;
			this.timer_MdiFormSysTime.Tag = "timer_MdiFormSysTime";
			// 
			// MdiForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1272, 752);
			this.Controls.Add(this.statusStrip_MdiFormStatu);
			this.Controls.Add(this.menuStrip_MdiFormMenu);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip_MdiFormMenu;
			this.Name = "MdiForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MdiForm";
			this.menuStrip_MdiFormMenu.ResumeLayout(false);
			this.menuStrip_MdiFormMenu.PerformLayout();
			this.statusStrip_MdiFormStatu.ResumeLayout(false);
			this.statusStrip_MdiFormStatu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_MdiFormMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Func;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Tool;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Calc;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TXT;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Wind;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_New;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Open;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAs;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Printf;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_PrintfView;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Custom;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Option;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator_Tool1;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator_File1;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator_File2;
		private System.Windows.Forms.ToolStripSeparator ToolStripSeparator_File3;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
		private System.Windows.Forms.StatusStrip statusStrip_MdiFormStatu;
		private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_SysTime;
		private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_Separator1;
		private System.Windows.Forms.Timer timer_MdiFormSysTime;
	}
}

