using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Collections;
using System.Drawing.Imaging;


namespace MyComboBox
{
    public partial class MyComboBox : ComboBox
    {
        Label _label = new Mylabel(); 
        private System.ComponentModel.Container components = null;
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        public MyComboBox()
        {
            InitializeComponent();
            _label.Visible = false;
            _label.BorderStyle = BorderStyle.None ;
            _label.AutoSize = false;
            _label.ForeColor = Color.Green;
            _label.TextAlign = ContentAlignment.MiddleLeft;
            _label.EnabledChanged += new EventHandler(_label_EnabledChanged);


            this.ForeColor = Color.Red;//Color.Blue;
			this.Width = 150;
            this.FlatStyle   =   System.Windows.Forms.FlatStyle.Flat;
             
        }  

        private Color _linecolor = Color.DodgerBlue;
        /// <summary>
        /// 线条颜色
        /// </summary>
        public Color LineColor
        {
            get
            {
                return this._linecolor;
            }
            set
            {
                this._linecolor = value;
                this.Invalidate();
            }
        }
        private void DrawLine()
        {
            Graphics g = this.CreateGraphics();
            using (Pen p = new Pen(this._linecolor))
            {
                g.DrawLine(p, 0, this.Height - 1, this.Width, this.Height - 1);
            }
        }
        private const int WM_PAINT = 0xF;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                DrawLine();
            }
        }

        /// <summary>
        /// 当Enable = false 时字体颜色
        /// </summary>
        [Description("当Enable = false 时字体颜色")]
        public Color DisenableForeColor
        {
            get { return _label.ForeColor; }
            set { _label.ForeColor = value; }
        }


        /// <summary>
        ///当Enable = false 时背景颜色 
        /// </summary>
        [Description("当Enable = false 时背景颜色")]
        public Color DisenableBackColor
        {
            get { return _label.BackColor; }
            set { _label.BackColor = value; }
        }

        void _label_EnabledChanged(object sender, EventArgs e)
        {
            //使 Label的Enabled始终为 true
            _label.Enabled = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            _label.Text = this.Text;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            _label.Font = this.Font;
        }

        protected override void OnDockChanged(EventArgs e)
        {
            base.OnDockChanged(e);
            _label.Dock = this.Dock;
        }

        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);
            _label.RightToLeft = this.RightToLeft;
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            _label.Left = this.Left;
            _label.Top = this.Top;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            _label.Width = this.Width;
            _label.Height = this.Height;
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            _label.Parent = this.Parent;
        }


        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            if (this.SelectedItem == null)
                _label.Text = "";
            else
                _label.Text = this.SelectedItem.ToString();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            _label.Visible = !this.Enabled;
            this.Visible = this.Enabled;
        }

        private class Mylabel : Label
        {
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == 0xF)
                {
                    Graphics g = this.CreateGraphics();
                    using (Pen p = new Pen(Color.DodgerBlue))
                    {
                        g.DrawLine(p, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                }
            }
        }
    }
}
