/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using IFix.Core;
using MiHoYoSDKJSON;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public sealed class Thunder // TypeDefIndex: 8656
	{
		// Fields
		public static int MultiTaskCountLimit; // 0x00
		private Timer progressTimer; // 0x10
		public ulong startTime; // 0x18
		private static ulong lastDownloadDuration; // 0x08
		private static ulong downloadTime; // 0x10
		public static bool pausing; // 0x18
		private string _rawDownloadTasks; // 0x20
		private List<FileDownloadTask> pendingQueue; // 0x28
		private List<FileDownloadTask> failureTasks; // 0x30
		private List<FileDownloadTask> successTasks; // 0x38
		private List<DownloadPoint> downloadPoints; // 0x40
		private static ulong lastDownloadSize; // 0x20
		private static readonly Thunder instance; // 0x28
	
		// Properties
		public static Thunder Instance { /* [XID] */ /* 0x0000000189B5ED70-0x0000000189B5ED90 */ get => default; } // 0x0000000185A8DB80-0x0000000185A8DC50 
		private List<FileDownloadTask> _allTasks { /* [XID] */ /* 0x0000000189944C90-0x0000000189944CB0 */ get => default; } // 0x0000000185A8DC50-0x0000000185A8DD30 
	
		// Constructors
		private Thunder() {} // 0x0000000185A8D910-0x0000000185A8DB80
		static Thunder() {} // 0x0000000185A8D830-0x0000000185A8D910
	
		// Methods
		// [XID] // 0x0000000189AC13F0-0x0000000189AC1410
		public void SetupTaskWithJSONString(string jsonString) {} // 0x0000000185A8CA50-0x0000000185A8CE70
		internal static extern bool GetDiskFreeSpaceExA(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes); // 0x0000000185A8AB90-0x0000000185A8AD00
		internal static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes); // 0x0000000185A8AD00-0x0000000185A8AE70
		// [XID] // 0x00000001898F8680-0x00000001898F86A0
		public string GetTotalFreeSpace() => default; // 0x0000000185A8AE70-0x0000000185A8B210
		// [XID] // 0x0000000189BDEB00-0x0000000189BDEB20
		public string GetUnCompletedTasks() => default; // 0x0000000185A8B210-0x0000000185A8B420
		// [XID] // 0x00000001898E9750-0x00000001898E9770
		public void PauseTasks(string jsonString) {} // 0x0000000185A8C0C0-0x0000000185A8C2A0
		// [XID] // 0x00000001895F2960-0x00000001895F2980
		public void ResumeTasks(string jsonString) {} // 0x0000000185A8C9A0-0x0000000185A8CA50
		// [XID] // 0x0000000189B92820-0x0000000189B92840
		public void RemoveTasks(string jsonString) {} // 0x0000000185A8C380-0x0000000185A8C800
		// [XID] // 0x0000000189B48E40-0x0000000189B48E60
		private void RestartDownload() {} // 0x0000000185A8C8F0-0x0000000185A8C9A0
		// [XID] // 0x0000000189BA13A0-0x0000000189BA13C0
		public void CancelAllTasks() {} // 0x0000000185A8A9F0-0x0000000185A8AB90
		// [XID] // 0x0000000189BA8980-0x0000000189BA89A0
		public void PauseAllTasks() {} // 0x0000000185A8BFC0-0x0000000185A8C0C0
		// [XID] // 0x0000000189BAFE80-0x0000000189BAFEA0
		private void RecordDownloadTime() {} // 0x0000000185A8C2A0-0x0000000185A8C380
		// [XID] // 0x0000000189BB7550-0x0000000189BB7570
		private void InvalidateTimer() {} // 0x0000000185A8B420-0x0000000185A8B4F0
		// [XID] // 0x0000000189979820-0x0000000189979840
		public bool StartBackgroundDownload() => default; // 0x0000000185A8CE70-0x0000000185A8D0D0
		// [XID] // 0x0000000189BC67A0-0x0000000189BC67C0
		public void StartDownload(object param = null) {} // 0x0000000185A8D0D0-0x0000000185A8D1D0
		// [XID] // 0x0000000189BCE4C0-0x0000000189BCE4E0
		private void ResetTimestamp() {} // 0x0000000185A8C800-0x0000000185A8C8F0
		// [XID] // 0x0000000189BD5800-0x0000000189BD5820
		private void _StartDownload() {} // 0x0000000185A8D4E0-0x0000000185A8D830
		// [XID] // 0x0000000189B75930-0x0000000189B75950
		public void Notify(ThunderNotificationEvent evt, JSONNode param) {} // 0x0000000185A8B4F0-0x0000000185A8B790
		// [XID] // 0x000000018993D840-0x000000018993D860
		private string StringValueForEvent(ThunderNotificationEvent evt) => default; // 0x0000000185A8D330-0x0000000185A8D410
		// [XID] // 0x00000001895F14A0-0x00000001895F14C0
		private void StartProgressTimer() {} // 0x0000000185A8D1D0-0x0000000185A8D330
		// [XID] // 0x00000001895F9040-0x00000001895F9060
		private void OnProgressTimerEvent(object source, ElapsedEventArgs e) {} // 0x0000000185A8B790-0x0000000185A8BFC0
	}
}
