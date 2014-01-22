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
			MinMaxLabel.Text = "Current: " + (caps.PeriodCurrent/10000.0) + " Min: " + (caps.PeriodMin/10000.0) + " Max: " + (caps.PeriodMax/10000.0);
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			DisplayTimerCaps();
		}
		
		void BeginButtonClick(object sender, EventArgs e)
		{
			WinApiCalls.TimeBeginPeriod((uint)numericUpDown1.Value);
		}
		
		void EndButtonClick(object sender, EventArgs e)
		{
			WinApiCalls.TimeEndPeriod((uint)numericUpDown1.Value);
		}
	
	}
}
