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

public abstract class FilesDownloadJob_Base // TypeDefIndex: 11578
{
	// Fields
	public List<FileDownloadInfo> downloadInfos; // 0x10
	public string cacheFilePath; // 0x18
	public string cacheRootDir; // 0x20
	public long baseDownloadedLength; // 0x28
	public Action finishAction; // 0x30
	public Action<ExceptionInfo> failedAction; // 0x38
	protected static bool _enableFinishNotification; // 0x00
	protected static bool _enableCellularDownload; // 0x01

	// Properties
	public abstract long downloadedLength { get; }
	public abstract long downloadSpeed { get; }
	public abstract bool pause { get; set; }
	public abstract long md5VerifiedLength { get; }
	public abstract long md5VerifySpeed { get; }
	public abstract bool isVerifyingMd5 { get; }
	public static bool enableFinishNotification { /* [XID] */ /* 0x00000001899A6DB0-0x00000001899A6DD0 */ get; /* [XID] */ /* 0x000000018988AF30-0x000000018988AF50 */ set; } // 0x00000001822DAE60-0x00000001822DAF30 0x00000001822DB000-0x00000001822DB0D0
	public static bool enableCellularDownload { /* [XID] */ /* 0x0000000189892300-0x0000000189892320 */ get; /* [XID] */ /* 0x0000000189899D70-0x0000000189899D90 */ set; } // 0x00000001822DAF30-0x00000001822DB000 0x00000001822DB0D0-0x00000001822DB1A0

	// Constructors
	protected FilesDownloadJob_Base() {} // 0x00000001822DB200-0x00000001822DB290
	static FilesDownloadJob_Base() {} // 0x00000001822DB1A0-0x00000001822DB200

	// Methods
	public abstract void StartDownload();
	public abstract void StopDownload();
}

