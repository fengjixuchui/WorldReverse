/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine.Networking;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FilesDownloadJob_UWR : FilesDownloadJob_Base // TypeDefIndex: 11584
{
	// Fields
	private long _finishedLength; // 0x40
	private bool _pause; // 0x48
	private bool _stop; // 0x49
	private long _downloadSpeed; // 0x50
	public List<FileDownloadInfo> waitFiles; // 0x58
	public List<FileDownloadInfo> endedFiles; // 0x60
	public List<UnityWebRequest> downloadings; // 0x68
	public const int multipleCnt = 5; // Metadata: 0x00AE9A23
	private DownloadSpeedDetect _speedDetect; // 0x70
	public Queue<Error> errors; // 0x78

	// Properties
	public override long downloadedLength { /* [XID] */ /* 0x00000001895F2B90-0x00000001895F2BB0 */ get => default; } // 0x0000000181E59A70-0x0000000181E59C90 
	public override long downloadSpeed { /* [XID] */ /* 0x00000001899EB4B0-0x00000001899EB4D0 */ get => default; } // 0x0000000181E599D0-0x0000000181E59A70 
	public override bool pause { /* [XID] */ /* 0x0000000189609640-0x0000000189609660 */ get => default; /* [XID] */ /* 0x0000000189610E60-0x0000000189610E80 */ set {} } // 0x0000000181E59890-0x0000000181E59930 0x0000000181E593C0-0x0000000181E59470
	public override long md5VerifiedLength { /* [XID] */ /* 0x0000000189A01A00-0x0000000189A01A20 */ get => default; } // 0x0000000181E59C90-0x0000000181E59D30 
	public override long md5VerifySpeed { /* [XID] */ /* 0x0000000189A094D0-0x0000000189A094F0 */ get => default; } // 0x0000000181E5A5E0-0x0000000181E5A680 
	public override bool isVerifyingMd5 { /* [XID] */ /* 0x0000000189A109C0-0x0000000189A109E0 */ get => default; } // 0x0000000181E5A430-0x0000000181E5A4D0 

	// Nested types
	public enum ErrorCode // TypeDefIndex: 11585
	{
		AuthenticationOrDecryptionFailed = -9203,
		NotAValidMethodOrArgumentException = -9202,
		NotSupportedException = -9201,
		Cancelled = -9009,
		PermissionDenied = -9007,
		IOFailed = -9006,
		DiskFull = -9005,
		TimeOut = -9002,
		Unknown = -1,
		None = 0,
		InvalidSavePath = 1,
		InvalidUrl = 2,
		InvalidDownloadInfo = 3,
		UwrError = 4,
		VerifyMd5OrFileSizeFailed = 5,
		IOFailedInReceiveData = 6,
		IOFailedInCompleteContent = 7,
		NullBufferInReceiveData = 8,
		CreateTempFileFailed = 9
	}

	public class Error // TypeDefIndex: 11586
	{
		// Fields
		public int code; // 0x10
		public string msg; // 0x18

		// Constructors
		public Error() {} // Dummy constructor
		public Error(int code, string msg) {} // 0x0000000181E58A20-0x0000000181E58AA0
	}

	private class ErrorComparer : IEqualityComparer<Error> // TypeDefIndex: 11587
	{
		// Constructors
		public ErrorComparer() {} // 0x0000000181E79D50-0x0000000181E79DB0

		// Methods
		// [XID] // 0x0000000189A6BBC0-0x0000000189A6BBE0
		public bool Equals(Error x, Error y) => default; // 0x0000000181E79AE0-0x0000000181E79C50
		// [XID] // 0x0000000189A73380-0x0000000189A733A0
		public int GetHashCode(Error x) => default; // 0x0000000181E79C50-0x0000000181E79D50
	}

	// Constructors
	public FilesDownloadJob_UWR() {} // 0x0000000181E5AAA0-0x0000000181E5ABD0

	// Methods
	// [XID] // 0x0000000189636740-0x0000000189636760
	public override void StartDownload() {} // 0x0000000181E59590-0x0000000181E596B0
	[DebuggerHidden] // 0x0000000189A1F5F0-0x0000000189A1F630
	// [XID] // 0x0000000189A1F5F0-0x0000000189A1F630
	private IEnumerator DownloadTask() => default; // 0x0000000181E5A680-0x0000000181E5A790
	[DebuggerHidden] // 0x0000000189A29A60-0x0000000189A29AA0
	// [XID] // 0x0000000189A29A60-0x0000000189A29AA0
	private IEnumerator SingleDownloadTask() => default; // 0x0000000181E59780-0x0000000181E59890
	[DebuggerHidden] // 0x0000000189A33FA0-0x0000000189A33FE0
	// [XID] // 0x0000000189A33FA0-0x0000000189A33FE0
	private IEnumerator DownloadSingleFile(FileDownloadInfo info) => default; // 0x0000000181E59470-0x0000000181E59590
	// [XID] // 0x0000000189A3E990-0x0000000189A3E9B0
	public override void StopDownload() {} // 0x0000000181E59930-0x0000000181E599D0
	// [XID] // 0x0000000189A460A0-0x0000000189A460C0
	private void DidDownloadSingleFile(FileDownloadInfo info, bool success, int errCode, string errMsg) {} // 0x0000000181E59D30-0x0000000181E5A160
	// [XID] // 0x0000000189A4D7F0-0x0000000189A4D810
	private void DidDownloadAllFiles() {} // 0x0000000181E5A790-0x0000000181E5AAA0
	// [XID] // 0x0000000189A55070-0x0000000189A55090
	private void QueueError(int errCode, string msg = "" /* Metadata: 0x00AE9A1B */) {} // 0x0000000181E5A4D0-0x0000000181E5A5E0
	// [XID] // 0x0000000189A5C960-0x0000000189A5C980
	private void StopBecauseError(int errCode, string msg = "" /* Metadata: 0x00AE9A1F */) {} // 0x0000000181E596B0-0x0000000181E59780
	// [XID] // 0x0000000189A64250-0x0000000189A64270
	public Error MakeTotalErrorMsg(Queue<Error> errors) => default; // 0x0000000181E5A160-0x0000000181E5A430
}

