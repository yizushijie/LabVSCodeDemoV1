﻿namespace Harry.LabCOMMPort
{
	partial class COMMSerialPortPlusFull
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
			this.label_COMMPortBaudRate = new System.Windows.Forms.Label();
			this.comboBox_COMMPortBaudRate = new System.Windows.Forms.ComboBox();
			this.comboBox_COMMPortStopBits = new System.Windows.Forms.ComboBox();
			this.label_COMMPortStopBits = new System.Windows.Forms.Label();
			this.comboBox_COMMPortDataBits = new System.Windows.Forms.ComboBox();
			this.label_COMMPortDataBits = new System.Windows.Forms.Label();
			this.comboBox_COMMPortParity = new System.Windows.Forms.ComboBox();
			this.label_COMMPortParity = new System.Windows.Forms.Label();
			this.panel_COMMPortName.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMMPortState)).BeginInit();
			this.panel_COMMPort.SuspendLayout();
			this.groupBox_COMMPortName.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_COMMPortName
			// 
			this.panel_COMMPortName.Controls.Add(this.comboBox_COMMPortParity);
			this.panel_COMMPortName.Controls.Add(this.label_COMMPortParity);
			this.panel_COMMPortName.Controls.Add(this.comboBox_COMMPortDataBits);
			this.panel_COMMPortName.Controls.Add(this.label_COMMPortDataBits);
			this.panel_COMMPortName.Controls.Add(this.comboBox_COMMPortStopBits);
			this.panel_COMMPortName.Controls.Add(this.label_COMMPortStopBits);
			this.panel_COMMPortName.Controls.Add(this.comboBox_COMMPortBaudRate);
			this.panel_COMMPortName.Controls.Add(this.label_COMMPortBaudRate);
			this.panel_COMMPortName.Size = new System.Drawing.Size(145, 163);
			this.panel_COMMPortName.Controls.SetChildIndex(this.comboBox_COMMPortName, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.button_COMMPortInit, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.pictureBox_COMMPortState, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.label_COMMPortBaudRate, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.comboBox_COMMPortBaudRate, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.label_COMMPortStopBits, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.comboBox_COMMPortStopBits, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.label_COMMPortDataBits, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.comboBox_COMMPortDataBits, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.label_COMMPortParity, 0);
			this.panel_COMMPortName.Controls.SetChildIndex(this.comboBox_COMMPortParity, 0);
			// 
			// pictureBox_COMMPortState
			// 
			this.pictureBox_COMMPortState.Location = new System.Drawing.Point(19, 135);
			// 
			// button_COMMPortInit
			// 
			this.button_COMMPortInit.Location = new System.Drawing.Point(57, 135);
			this.button_COMMPortInit.Size = new System.Drawing.Size(83, 25);
			// 
			// panel_COMMPort
			// 
			this.panel_COMMPort.Size = new System.Drawing.Size(157, 189);
			// 
			// groupBox_COMMPortName
			// 
			this.groupBox_COMMPortName.Size = new System.Drawing.Size(151, 183);
			// 
			// label_COMMPortBaudRate
			// 
			this.label_COMMPortBaudRate.AutoSize = true;
			this.label_COMMPortBaudRate.Location = new System.Drawing.Point(6, 34);
			this.label_COMMPortBaudRate.Name = "label_COMMPortBaudRate";
			this.label_COMMPortBaudRate.Size = new System.Drawing.Size(47, 12);
			this.label_COMMPortBaudRate.TabIndex = 4;
			this.label_COMMPortBaudRate.Tag = "";
			this.label_COMMPortBaudRate.Text = "波特率:";
			// 
			// comboBox_COMMPortBaudRate
			// 
			this.comboBox_COMMPortBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_COMMPortBaudRate.FormattingEnabled = true;
			this.comboBox_COMMPortBaudRate.Items.AddRange(new object[] {
            "自定义",
            "1382400",
            "921600",
            "460800",
            "256000",
            "230400",
            "128000",
            "115200",
            "76800",
            "57600",
            "43000",
            "38400",
            "19200",
            "9600",
            "4800",
            "2400",
            "1200"});
			this.comboBox_COMMPortBaudRate.Location = new System.Drawing.Point(57, 31);
			this.comboBox_COMMPortBaudRate.Name = "comboBox_COMMPortBaudRate";
			this.comboBox_COMMPortBaudRate.Size = new System.Drawing.Size(83, 20);
			this.comboBox_COMMPortBaudRate.TabIndex = 5;
			// 
			// comboBox_COMMPortStopBits
			// 
			this.comboBox_COMMPortStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_COMMPortStopBits.FormattingEnabled = true;
			this.comboBox_COMMPortStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
			this.comboBox_COMMPortStopBits.Location = new System.Drawing.Point(57, 57);
			this.comboBox_COMMPortStopBits.Name = "comboBox_COMMPortStopBits";
			this.comboBox_COMMPortStopBits.Size = new System.Drawing.Size(83, 20);
			this.comboBox_COMMPortStopBits.TabIndex = 7;
			// 
			// label_COMMPortStopBits
			// 
			this.label_COMMPortStopBits.AutoSize = true;
			this.label_COMMPortStopBits.Location = new System.Drawing.Point(6, 60);
			this.label_COMMPortStopBits.Name = "label_COMMPortStopBits";
			this.label_COMMPortStopBits.Size = new System.Drawing.Size(47, 12);
			this.label_COMMPortStopBits.TabIndex = 6;
			this.label_COMMPortStopBits.Tag = "";
			this.label_COMMPortStopBits.Text = "停止位:";
			// 
			// comboBox_COMMPortDataBits
			// 
			this.comboBox_COMMPortDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_COMMPortDataBits.FormattingEnabled = true;
			this.comboBox_COMMPortDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
			this.comboBox_COMMPortDataBits.Location = new System.Drawing.Point(57, 83);
			this.comboBox_COMMPortDataBits.Name = "comboBox_COMMPortDataBits";
			this.comboBox_COMMPortDataBits.Size = new System.Drawing.Size(83, 20);
			this.comboBox_COMMPortDataBits.TabIndex = 9;
			// 
			// label_COMMPortDataBits
			// 
			this.label_COMMPortDataBits.AutoSize = true;
			this.label_COMMPortDataBits.Location = new System.Drawing.Point(6, 86);
			this.label_COMMPortDataBits.Name = "label_COMMPortDataBits";
			this.label_COMMPortDataBits.Size = new System.Drawing.Size(47, 12);
			this.label_COMMPortDataBits.TabIndex = 8;
			this.label_COMMPortDataBits.Tag = "";
			this.label_COMMPortDataBits.Text = "数据位:";
			// 
			// comboBox_COMMPortParity
			// 
			this.comboBox_COMMPortParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_COMMPortParity.FormattingEnabled = true;
			this.comboBox_COMMPortParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
			this.comboBox_COMMPortParity.Location = new System.Drawing.Point(57, 109);
			this.comboBox_COMMPortParity.Name = "comboBox_COMMPortParity";
			this.comboBox_COMMPortParity.Size = new System.Drawing.Size(83, 20);
			this.comboBox_COMMPortParity.TabIndex = 11;
			// 
			// label_COMMPortParity
			// 
			this.label_COMMPortParity.AutoSize = true;
			this.label_COMMPortParity.Location = new System.Drawing.Point(6, 112);
			this.label_COMMPortParity.Name = "label_COMMPortParity";
			this.label_COMMPortParity.Size = new System.Drawing.Size(47, 12);
			this.label_COMMPortParity.TabIndex = 10;
			this.label_COMMPortParity.Tag = "";
			this.label_COMMPortParity.Text = "校验位:";
			// 
			// COMMSerialPortPlusFull
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "COMMSerialPortPlusFull";
			this.Size = new System.Drawing.Size(157, 191);
			this.panel_COMMPortName.ResumeLayout(false);
			this.panel_COMMPortName.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMMPortState)).EndInit();
			this.panel_COMMPort.ResumeLayout(false);
			this.groupBox_COMMPortName.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox_COMMPortBaudRate;
		private System.Windows.Forms.Label label_COMMPortBaudRate;
		private System.Windows.Forms.ComboBox comboBox_COMMPortParity;
		private System.Windows.Forms.Label label_COMMPortParity;
		private System.Windows.Forms.ComboBox comboBox_COMMPortDataBits;
		private System.Windows.Forms.Label label_COMMPortDataBits;
		private System.Windows.Forms.ComboBox comboBox_COMMPortStopBits;
		private System.Windows.Forms.Label label_COMMPortStopBits;
	}
}