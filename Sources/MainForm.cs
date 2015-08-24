/*
 * Created by SharpDevelop.
 * User: Tebjan Halm
 * Date: 21.01.2014
 * Time: 16:55
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Globalization;

namespace TimerTool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	    public MainForm(string[] args)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            ResourceManager resources = new ResourceManager(typeof(MainForm));

            this.Resize += MainForm_Resize;

            notifyIcon1.BalloonTipText = "TimerTool running...";
            notifyIcon1.BalloonTipTitle = "TimerTool";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Text = "TimerTool";
            notifyIcon1.Icon = (Icon)resources.GetObject("TimerIcon");
            notifyIcon1.Click += NotifyIcon1_Click;

            //apply commandline args
            allowVisible = true;
            var i = 0;
            foreach(var arg in args)
            {
                
                if(arg == "-t")
                {
                    if (args.Length > (i + 1))
                    {
                        double val;
                        if (double.TryParse(args[i+1], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out val))
                        {
                            WinApiCalls.SetTimerResolution((uint)(val * 10000));
                        }
                    }
                }

                if(arg == "-minimized")
                {
                    allowVisible = false;
                }

                i++;
            }
        }

        private bool allowVisible;     // ContextMenu's Show command used
        private bool allowClose = true;       // ContextMenu's Exit command used

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            allowVisible = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                Minimize();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void Minimize()
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(250);
            this.Hide();
        }

        void MainFormLoad(object sender, EventArgs e)
		{
			DisplayTimerCaps();
		}

        private void DisplayTimerCaps()
		{
			var caps = WinApiCalls.QueryTimerResolution();
			CurrentLabel.Text = "Current: " + (caps.PeriodCurrent/10000.0) + " ms";
			MinLabel.Text = "Max: " + (caps.PeriodMin/10000.0) + " ms";
			MaxLabel.Text = "Min: " + (caps.PeriodMax/10000.0) + " ms";
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			DisplayTimerCaps();
		}
		
		void SetTimerButtonClick(object sender, EventArgs e)
		{
			WinApiCalls.SetTimerResolution((uint)(numericUpDown2.Value * 10000));
		}
		
		void UnsetTimerClick(object sender, EventArgs e)
		{
			WinApiCalls.SetTimerResolution(0, false);
		}
	}
}
