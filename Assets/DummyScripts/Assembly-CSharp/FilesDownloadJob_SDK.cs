/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MiHoYoSDKJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FilesDownloadJob_SDK : FilesDownloadJob_Base // TypeDefIndex: 11580
{
	// Fields
	private long _downloadedLength; // 0x40
	private long _downloadSpeed; // 0x48
	private bool _pause; // 0x50
	private long _md5VerifiedLength; // 0x58
	private long _md5VerifySpeed; // 0x60

	// Properties
	public override long downloadedLength { /* [XID] */ /* 0x00000001898F3DE0-0x00000001898F3E00 */ get => default; } // 0x0000000181649770-0x0000000181649810 
	public override long downloadSpeed { /* [XID] */ /* 0x00000001898FB2F0-0x00000001898FB310 */ get => default; } // 0x00000001816496D0-0x0000000181649770 
	public override bool pause { /* [XID] */ /* 0x0000000189AB53A0-0x0000000189AB53C0 */ get => default; /* [XID] */ /* 0x000000018990A550-0x000000018990A570 */ set {} } // 0x0000000181649270-0x0000000181649310 0x0000000181648B30-0x0000000181648C90
	public override long md5VerifiedLength { /* [XID] */ /* 0x0000000189911EF0-0x0000000189911F10 */ get => default; } // 0x0000000181649960-0x0000000181649A00 
	public override long md5VerifySpeed { /* [XID] */ /* 0x0000000189919A00-0x0000000189919A20 */ get => default; } // 0x000000018164ABB0-0x000000018164AC50 
	public override bool isVerifyingMd5 { /* [XID] */ /* 0x0000000189B00E00-0x0000000189B00E20 */ get => default; } // 0x000000018164A8A0-0x000000018164A940 
	public static new bool enableFinishNotification { /* [XID] */ /* 0x0000000189928930-0x0000000189928950 */ get => default; /* [XID] */ /* 0x000000018992FDB0-0x000000018992FDD0 */ set {} } // 0x0000000181648820-0x00000001816488F0 0x000000018164A710-0x000000018164A8A0
	public static new bool enableCellularDownload { /* [XID] */ /* 0x00000001899372D0-0x00000001899372F0 */ get => default; /* [XID] */ /* 0x000000018993EE00-0x000000018993EE20 */ set {} } // 0x0000000181649600-0x00000001816496D0 0x000000018164AA70-0x000000018164ABB0

	// Nested types
	public enum ErrorCode // TypeDefIndex: 11581
	{
		AlreadyDownloaded = -9008,
		SavePathNotExistOrPermissionDenied = -9007,
		FileOperationError = -9006,
		DiskFull = -9005,
		Md5NotMatchFinally = -9004,
		Md5NotMatchOnce = -9003,
		RequestTimeout = -9002,
		NetConnectionInterrupt = -9001,
		Unknown = -9000,
		None = 0
	}

	public enum DownloadState // TypeDefIndex: 11582
	{
		Error = -1,
		Finish = 0
	}

	// Constructors
	public FilesDownloadJob_SDK() {} // 0x000000018164B100-0x000000018164B180

	// Methods
	// [XID] // 0x0000000189B33180-0x0000000189B331A0
	public override void StartDownload() {} // 0x0000000181648E50-0x0000000181649270
	// [XID] // 0x000000018994DBA0-0x000000018994DBC0
	public override void StopDownload() {} // 0x0000000181649310-0x0000000181649600
	// [XID] // 0x00000001899551A0-0x00000001899551C0
	private void RegisterCallback() {} // 0x000000018164A5C0-0x000000018164A710
	// [XID] // 0x000000018995C9C0-0x000000018995C9E0
	private void UnregisterCallback() {} // 0x0000000181649810-0x0000000181649960
	// [XID] // 0x0000000189964290-0x00000001899642B0
	public void OnDownloadNotification(string jsonString) {} // 0x000000018164A330-0x000000018164A5C0
	// [XID] // 0x000000018996B8B0-0x000000018996B8D0
	private void InDownloadingCallback(JSONObject json) {} // 0x00000001816488F0-0x0000000181648B30
	// [XID] // 0x0000000189973450-0x0000000189973470
	private void DidDownloadSingleFile(JSONObject json) {} // 0x0000000181649A00-0x000000018164A330
	// [XID] // 0x000000018997ACC0-0x000000018997ACE0
	private void DidDownloadAllFiles(JSONObject json) {} // 0x000000018164AC50-0x000000018164B100
	// [XID] // 0x0000000189982670-0x0000000189982690
	private static void SetNotficationContent(string title, string content) {} // 0x0000000181648C90-0x0000000181648E50
	// [XID] // 0x0000000189989E10-0x0000000189989E30
	private static ExceptionInfo GenUnexpectedExceptionInfo(string errMsg) => default; // 0x000000018164A940-0x000000018164AA70
}

