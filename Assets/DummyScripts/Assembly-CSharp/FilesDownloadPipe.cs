/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FilesDownloadPipe // TypeDefIndex: 11593
{
	// Fields
	public Queue<FilesDownloadJob_Base> jobs; // 0x10
	public FilesDownloadJob_Base curJob; // 0x18
	public Action finishAction; // 0x20
	public Action<ExceptionInfo> failedAction; // 0x28
	public Status status; // 0x30
	private long _finishedJobDownloadedLength; // 0x38

	// Properties
	public long downloadedLength { /* [XID] */ /* 0x0000000189BB4750-0x0000000189BB4770 */ get => default; } // 0x00000001810C91D0-0x00000001810C92A0 
	public long downloadSpeed { /* [XID] */ /* 0x0000000189BBBD10-0x0000000189BBBD30 */ get => default; } // 0x00000001810C9110-0x00000001810C91D0 
	public long md5VerifiedLength { /* [XID] */ /* 0x0000000189BC3BB0-0x0000000189BC3BD0 */ get => default; } // 0x00000001810C92A0-0x00000001810C9360 
	public long md5VerifySpeed { /* [XID] */ /* 0x0000000189BCB380-0x0000000189BCB3A0 */ get => default; } // 0x00000001810C9730-0x00000001810C97F0 
	public bool isVerifyingMd5 { /* [XID] */ /* 0x0000000189837490-0x00000001898374B0 */ get => default; } // 0x00000001810C95A0-0x00000001810C9660 
	public bool pause { /* [XID] */ /* 0x000000018983E9D0-0x000000018983E9F0 */ get => default; /* [XID] */ /* 0x00000001895E69B0-0x00000001895E69D0 */ set {} } // 0x00000001810C8F90-0x00000001810C9050 0x00000001810C8C10-0x00000001810C8CE0

	// Nested types
	public enum Status // TypeDefIndex: 11594
	{
		Idle = 0,
		Downloading = 1,
		Finish = 2,
		Failed = 3
	}

	// Constructors
	public FilesDownloadPipe() {} // 0x00000001810C97F0-0x00000001810C9880

	// Methods
	// [XID] // 0x00000001895EE4F0-0x00000001895EE510
	public void Reset() {} // 0x00000001810C8D70-0x00000001810C8E40
	// [XID] // 0x00000001895F5C70-0x00000001895F5C90
	public void StartDownload() {} // 0x00000001810C8EE0-0x00000001810C8F90
	// [XID] // 0x00000001895FD170-0x00000001895FD190
	public void StopDownload() {} // 0x00000001810C9050-0x00000001810C9110
	// [XID] // 0x0000000189604B50-0x0000000189604B70
	public bool hasUsableJob() => default; // 0x00000001810C8B50-0x00000001810C8C10
	// [XID] // 0x000000018960C3E0-0x000000018960C400
	public void AddJob(FilesDownloadJob_Base job) {} // 0x00000001810C9660-0x00000001810C9730
	// [XID] // 0x000000018986C220-0x000000018986C240
	public FilesDownloadJob_Base GetNextJob() => default; // 0x00000001810C94D0-0x00000001810C95A0
	// [XID] // 0x0000000189864C90-0x0000000189864CB0
	private void StartNextJob() {} // 0x00000001810C9360-0x00000001810C94D0
}

