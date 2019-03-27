namespace Harry.LabCOMMPort
{
	partial class COMMBasePortPlus
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMMBasePortPlus));
			this.groupBox_COMMPortName = new System.Windows.Forms.GroupBox();
			this.panel_COMMPortName = new System.Windows.Forms.Panel();
			this.pictureBox_COMMPortState = new System.Windows.Forms.PictureBox();
			this.button_COMMPortInit = new System.Windows.Forms.Button();
			this.label_COMMPortName = new System.Windows.Forms.Label();
			this.comboBox_COMMPortName = new System.Windows.Forms.ComboBox();
			this.panel_COMMPort = new System.Windows.Forms.Panel();
			this.groupBox_COMMPortName.SuspendLayout();
			this.panel_COMMPortName.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMMPortState)).BeginInit();
			this.panel_COMMPort.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_COMMPortName
			// 
			this.groupBox_COMMPortName.Controls.Add(this.panel_COMMPortName);
			resources.ApplyResources(this.groupBox_COMMPortName, "groupBox_COMMPortName");
			this.groupBox_COMMPortName.Name = "groupBox_COMMPortName";
			this.groupBox_COMMPortName.TabStop = false;
			// 
			// panel_COMMPortName
			// 
			this.panel_COMMPortName.Controls.Add(this.pictureBox_COMMPortState);
			this.panel_COMMPortName.Controls.Add(this.button_COMMPortInit);
			this.panel_COMMPortName.Controls.Add(this.label_COMMPortName);
			this.panel_COMMPortName.Controls.Add(this.comboBox_COMMPortName);
			resources.ApplyResources(this.panel_COMMPortName, "panel_COMMPortName");
			this.panel_COMMPortName.Name = "panel_COMMPortName";
			// 
			// pictureBox_COMMPortState
			// 
			resources.ApplyResources(this.pictureBox_COMMPortState, "pictureBox_COMMPortState");
			this.pictureBox_COMMPortState.Name = "pictureBox_COMMPortState";
			this.pictureBox_COMMPortState.TabStop = false;
			this.pictureBox_COMMPortState.Tag = "1";
			// 
			// button_COMMPortInit
			// 
			resources.ApplyResources(this.button_COMMPortInit, "button_COMMPortInit");
			this.button_COMMPortInit.Name = "button_COMMPortInit";
			this.button_COMMPortInit.UseVisualStyleBackColor = true;
			// 
			// label_COMMPortName
			// 
			resources.ApplyResources(this.label_COMMPortName, "label_COMMPortName");
			this.label_COMMPortName.Name = "label_COMMPortName";
			// 
			// comboBox_COMMPortName
			// 
			this.comboBox_COMMPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_COMMPortName.FormattingEnabled = true;
			resources.ApplyResources(this.comboBox_COMMPortName, "comboBox_COMMPortName");
			this.comboBox_COMMPortName.Name = "comboBox_COMMPortName";
			// 
			// panel_COMMPort
			// 
			this.panel_COMMPort.Controls.Add(this.groupBox_COMMPortName);
			resources.ApplyResources(this.panel_COMMPort, "panel_COMMPort");
			this.panel_COMMPort.Name = "panel_COMMPort";
			// 
			// COMMBasePortPlus
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel_COMMPort);
			this.Name = "COMMBasePortPlus";
			this.groupBox_COMMPortName.ResumeLayout(false);
			this.panel_COMMPortName.ResumeLayout(false);
			this.panel_COMMPortName.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMMPortState)).EndInit();
			this.panel_COMMPort.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_COMMPortName;
		public System.Windows.Forms.Panel panel_COMMPortName;
		public System.Windows.Forms.PictureBox pictureBox_COMMPortState;
		public System.Windows.Forms.Button button_COMMPortInit;
		public System.Windows.Forms.Panel panel_COMMPort;
		public System.Windows.Forms.ComboBox comboBox_COMMPortName;
		public System.Windows.Forms.GroupBox groupBox_COMMPortName;
	}
}
