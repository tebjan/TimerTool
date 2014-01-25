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
using System.Windows.Forms;

namespace TimerTool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			DisplayTimerCaps();
		}
		
		private void DisplayTimerCaps()
		{
			var caps = WinApiCalls.QueryTimerResolution();
			CurrentLabel.Text = "Current: " + (caps.PeriodCurrent/10000.0) + " ms";
			MinLabel.Text = "Min: " + (caps.PeriodMin/10000.0) + " ms";
			MaxLabel.Text = "Max: " + (caps.PeriodMax/10000.0) + " ms";
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
