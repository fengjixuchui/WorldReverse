/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FilesDownloadJob_Ultra : FilesDownloadJob_Base // TypeDefIndex: 11583
{
	// Fields
	public FilesDownloadManager downloader; // 0x40
	private string displayErrMsg_default; // 0x48
	private string displayErrMsg_notEnoughSpace; // 0x50

	// Properties
	public override long downloadedLength { /* [XID] */ /* 0x0000000189991730-0x0000000189991750 */ get => default; } // 0x000000018656A960-0x000000018656AA10 
	public override long downloadSpeed { /* [XID] */ /* 0x0000000189B9CD40-0x0000000189B9CD60 */ get => default; } // 0x000000018656A8B0-0x000000018656A960 
	public override bool pause { /* [XID] */ /* 0x00000001899A0AF0-0x00000001899A0B10 */ get => default; /* [XID] */ /* 0x0000000189BB8C20-0x0000000189BB8C40 */ set {} } // 0x000000018656A740-0x000000018656A800 0x000000018656A4F0-0x000000018656A5B0
	public override long md5VerifiedLength { /* [XID] */ /* 0x00000001899AFCD0-0x00000001899AFCF0 */ get => default; } // 0x000000018656AA10-0x000000018656AAB0 
	public override long md5VerifySpeed { /* [XID] */ /* 0x00000001899B7140-0x00000001899B7160 */ get => default; } // 0x000000018656B150-0x000000018656B1F0 
	public override bool isVerifyingMd5 { /* [XID] */ /* 0x00000001899BEBE0-0x00000001899BEC00 */ get => default; } // 0x000000018656B0B0-0x000000018656B150 

	// Constructors
	public FilesDownloadJob_Ultra() {} // 0x000000018656B3D0-0x000000018656B450

	// Methods
	// [XID] // 0x00000001899C66A0-0x00000001899C66C0
	public override void StartDownload() {} // 0x000000018656A5B0-0x000000018656A740
	// [XID] // 0x00000001899CDB60-0x00000001899CDB80
	public override void StopDownload() {} // 0x000000018656A800-0x000000018656A8B0
	// [XID] // 0x00000001895EB7B0-0x00000001895EB7D0
	private void DidDownloadSingleFile(SingleFileDownloadResult singleResult, bool writeCacheFile) {} // 0x000000018656AAB0-0x000000018656B0B0
	// [XID] // 0x0000000189BDECA0-0x0000000189BDECC0
	private void DidDownloadAllFiles(FilesDownloadResult result) {} // 0x000000018656B1F0-0x000000018656B3D0
}

