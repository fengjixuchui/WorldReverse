/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class DownloadAliveKeeper // TypeDefIndex: 11608
{
	// Fields
	private const int NOTI_ID_DEFAULT = 10000; // Metadata: 0x00AEA366
	private const int NOTI_ID_DOWNLOAD_END = 10001; // Metadata: 0x00AEA36A
	private static bool _isOn; // 0x00
	private static string _upgradeProgressTitle; // 0x08
	private static string _downloadFinishContent; // 0x10
	private static string _downloadFailContent; // 0x18
	private static bool _needCheckKeepAliveWorking; // 0x20
	private static DateTime _timeWhenKeepAliveTurnedOn; // 0x28
	private static int _updateProgressCnt; // 0x38
	private static bool _lastTimeFailed; // 0x3C

	// Properties
	public static bool lastTimeFailed { /* [XID] */ /* 0x00000001899D21B0-0x00000001899D21D0 */ get; } // 0x0000000183AE0950-0x0000000183AE0A20 

	// Constructors
	static DownloadAliveKeeper() {} // 0x0000000183AE1770-0x0000000183AE17D0

	// Methods
	// [XID] // 0x00000001899D9900-0x00000001899D9920
	public static void KeepAliveTurnOn() {} // 0x0000000183ADFFF0-0x0000000183AE0320
	// [XID] // 0x000000018995FD70-0x000000018995FD90
	public static void KeepAliveTurnOff() {} // 0x0000000183AE0A20-0x0000000183AE0B80
	// [XID] // 0x0000000189967660-0x0000000189967680
	private static void CheckKeepAliveWorking() {} // 0x0000000183ADF4A0-0x0000000183ADF950
	// [XID] // 0x00000001899F0200-0x00000001899F0220
	public static void ShowNotfication(int id, string title, string content) {} // 0x0000000183ADF290-0x0000000183ADF4A0
	// [XID] // 0x00000001899F7780-0x00000001899F77A0
	public static void ShowDownloadEndNotification(int id, string title, string content) {} // 0x0000000183AE0620-0x0000000183AE0830
	// [XID] // 0x0000000189985370-0x0000000189985390
	public static void DeleteNotification(int id) {} // 0x0000000183ADF170-0x0000000183ADF290
	// [XID] // 0x0000000189A06720-0x0000000189A06740
	public static void UpdateProgress(long downloadedSize, long totalSize, long downloadSpeed, float progress) {} // 0x0000000183AE12C0-0x0000000183AE1770
	// [XID] // 0x000000018998CE40-0x000000018998CE60
	public static void OnInit() {} // 0x0000000183AE10D0-0x0000000183AE1160
	// [XID] // 0x0000000189994B80-0x0000000189994BA0
	public static void OnApplicationPause(bool pause) {} // 0x0000000183ADFF50-0x0000000183ADFFF0
	// [XID] // 0x0000000189A1C4B0-0x0000000189A1C4D0
	public static void OnDownloadFinish() {} // 0x0000000183ADFA40-0x0000000183ADFBD0
	// [XID] // 0x0000000189A23E50-0x0000000189A23E70
	public static void OnDownloadFailed() {} // 0x0000000183AE0490-0x0000000183AE0620
	// [XID] // 0x0000000189A2B140-0x0000000189A2B160
	public static void SetNecessaryText(string progressTitle, string finishContent, string failContent) {} // 0x0000000183AE0830-0x0000000183AE0950
	// [XID] // 0x0000000189A327D0-0x0000000189A327F0
	private static void StartTimingTask() {} // 0x0000000183AE0320-0x0000000183AE0490
	// [XID] // 0x0000000189A3A0F0-0x0000000189A3A110
	private static string GetNotificationTitle() => default; // 0x0000000183ADF950-0x0000000183ADFA40
	// [XID] // 0x0000000189A419C0-0x0000000189A419E0
	private static string GetLogFilePath() => default; // 0x0000000183AE1160-0x0000000183AE12C0
	// [XID] // 0x00000001899BA4A0-0x00000001899BA4C0
	private static void DeleteOtherDaysLogFile() {} // 0x0000000183ADFBD0-0x0000000183ADFF50
	// [XID] // 0x0000000189A50900-0x0000000189A50920
	private static void LogToFile(string content) {} // 0x0000000183AE0B80-0x0000000183AE0F50
}

