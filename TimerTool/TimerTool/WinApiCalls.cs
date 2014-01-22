/*
 * Created by SharpDevelop.
 * User: Tebjan Halm
 * Date: 21.01.2014
 * Time: 16:55
 * 
 * 
 */
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TimerTool
{
	[StructLayout(LayoutKind.Sequential)]
	public struct TimerCaps
	{
		public ulong PeriodMin;
		public ulong PeriodMax;
		public ulong PeriodCurrent;
	};
	
	/// <summary>
	/// Description of WinApiCalls.
	/// </summary>
	public static class WinApiCalls
	{

		[DllImport("ntdll.dll", SetLastError=true)]
		private static extern int NtQueryTimerResolution(out ulong MinimumResolution, out ulong MaximumResolution, out ulong ActualResolution);
		
		public static TimerCaps QueryTimerResolution()
		{
			var caps = new TimerCaps();
			var result = NtQueryTimerResolution(out caps.PeriodMin, out caps.PeriodMax, out caps.PeriodCurrent);
			return caps;
		}
		
		/// <summary>TimeBeginPeriod(). See the Windows API documentation for details.</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"), SuppressUnmanagedCodeSecurity]
		[DllImport("winmm.dll", EntryPoint="timeBeginPeriod", SetLastError=true)]
		public static extern uint TimeBeginPeriod(uint uMilliseconds);

		/// <summary>TimeEndPeriod(). See the Windows API documentation for details.</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"), SuppressUnmanagedCodeSecurity]
		[DllImport("winmm.dll", EntryPoint="timeEndPeriod", SetLastError=true)]
		public static extern uint TimeEndPeriod(uint uMilliseconds);
		
	}
}
