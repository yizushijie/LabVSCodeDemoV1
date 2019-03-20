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
            this.menuStrip_MdiFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_MdiFormMenu
            // 
            this.menuStrip_MdiFormMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.menuStrip_MdiFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Func,
            this.ToolStripMenuItem_Tool,
            this.ToolStripMenuItem_Wind,
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
            this.ToolStripMenuItem_Exit});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(66, 24);
            this.ToolStripMenuItem_File.Text = "文件(&F)";
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(125, 24);
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
            this.ToolStripMenuItem_TXT});
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
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(70, 24);
            this.ToolStripMenuItem_Help.Text = "帮助(&H)";
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 752);
            this.Controls.Add(this.menuStrip_MdiFormMenu);
            this.IsMdiContainer = true;
            this.Name = "MdiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdiForm";
            this.menuStrip_MdiFormMenu.ResumeLayout(false);
            this.menuStrip_MdiFormMenu.PerformLayout();
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
    }
}

