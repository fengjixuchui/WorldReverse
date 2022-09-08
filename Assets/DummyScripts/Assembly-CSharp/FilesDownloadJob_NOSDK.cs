/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FilesDownloadJob_NOSDK : FilesDownloadJob_Base // TypeDefIndex: 11579
{
	// Fields
	public FilesDownloader downloader; // 0x40
	private string displayErrMsg_default; // 0x48
	private string displayErrMsg_notEnoughSpace; // 0x50

	// Properties
	public override long downloadedLength { /* [XID] */ /* 0x00000001898A0F50-0x00000001898A0F70 */ get => default; } // 0x00000001828F6790-0x00000001828F6840 
	public override long downloadSpeed { /* [XID] */ /* 0x00000001898A84E0-0x00000001898A8500 */ get => default; } // 0x00000001828F66E0-0x00000001828F6790 
	public override bool pause { /* [XID] */ /* 0x00000001899DF920-0x00000001899DF940 */ get => default; /* [XID] */ /* 0x00000001898B74F0-0x00000001898B7510 */ set {} } // 0x00000001828F6570-0x00000001828F6630 0x00000001828F6320-0x00000001828F63E0
	public override long md5VerifiedLength { /* [XID] */ /* 0x00000001898BED20-0x00000001898BED40 */ get => default; } // 0x00000001828F6840-0x00000001828F68E0 
	public override long md5VerifySpeed { /* [XID] */ /* 0x00000001898C6580-0x00000001898C65A0 */ get => default; } // 0x00000001828F6F90-0x00000001828F7030 
	public override bool isVerifyingMd5 { /* [XID] */ /* 0x0000000189A03850-0x0000000189A03870 */ get => default; } // 0x00000001828F6EF0-0x00000001828F6F90 

	// Constructors
	public FilesDownloadJob_NOSDK() {} // 0x00000001828F7470-0x00000001828F74F0

	// Methods
	// [XID] // 0x0000000189A0AD90-0x0000000189A0ADB0
	public override void StartDownload() {} // 0x00000001828F63E0-0x00000001828F6570
	// [XID] // 0x00000001898DCFF0-0x00000001898DD010
	public override void StopDownload() {} // 0x00000001828F6630-0x00000001828F66E0
	// [XID] // 0x00000001898E4A60-0x00000001898E4A80
	private void DidDownloadSingleFile(SingleFileDownloader.DownloadResult singleResult, bool writeCacheFile) {} // 0x00000001828F68E0-0x00000001828F6EF0
	// [XID] // 0x00000001898EC390-0x00000001898EC3B0
	private void DidDownloadAllFiles(FilesDownloader.DownloadResult result) {} // 0x00000001828F7030-0x00000001828F7470
}

