/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FilesDownloader // TypeDefIndex: 11569
{
	// Fields
	public Status status; // 0x10
	public Queue<FileDownloadInfo> waitFiles; // 0x18
	public List<SingleFileDownloader> downloadings; // 0x20
	public DownloadResult result; // 0x28
	public readonly int PARALLEL_MAX_NUM; // 0x30
	public CompleteAction completeAction; // 0x38
	public SingleCompleteAction singleCompleteAction; // 0x40
	private bool _stop; // 0x48
	private readonly long _baseDownloadedLength; // 0x50
	private long _actualTotalLength; // 0x58
	private long _completedFileLength; // 0x60
	private long _downloadSpeed; // 0x68
	private DownloadSpeedDetect _speedDetect; // 0x70
	private bool _pause; // 0x78

	// Properties
	public int completedFileNum { /* [XID] */ /* 0x00000001897E4E10-0x00000001897E4E30 */ get => default; } // 0x0000000181D76F40-0x0000000181D77020 
	public int incompletedFileNum { /* [XID] */ /* 0x00000001897ECA10-0x00000001897ECA30 */ get => default; } // 0x0000000181D75CC0-0x0000000181D75DB0 
	public int totalFileNum { /* [XID] */ /* 0x00000001897F4260-0x00000001897F4280 */ get => default; } // 0x0000000181D75920-0x0000000181D759E0 
	public long downloadedLength { /* [XID] */ /* 0x00000001897FBCC0-0x00000001897FBCE0 */ get => default; } // 0x0000000181D764D0-0x0000000181D766F0 
	public long downloadSpeed { /* [XID] */ /* 0x00000001898031B0-0x00000001898031D0 */ get => default; } // 0x0000000181D76430-0x0000000181D764D0 
	public bool pause { /* [XID] */ /* 0x000000018980A640-0x000000018980A660 */ get => default; /* [XID] */ /* 0x0000000189811D40-0x0000000189811D60 */ set {} } // 0x0000000181D76390-0x0000000181D76430 0x0000000181D75AB0-0x0000000181D75CC0

	// Nested types
	public class DownloadResult // TypeDefIndex: 11570
	{
		// Fields
		public List<SingleFileDownloader.DownloadResult> singleFileResults; // 0x10
		public long totalTime; // 0x18
		public string errMsg; // 0x20

		// Constructors
		public DownloadResult() {} // 0x0000000181D87FC0-0x0000000181D88070
	}

	public enum Status // TypeDefIndex: 11571
	{
		Idle = 0,
		Downloading = 1,
		Finish = 2,
		Cancelled = 3,
		Failed = 4
	}

	public delegate void CompleteAction(DownloadResult result); // TypeDefIndex: 11572; 0x0000000181D71360-0x0000000181D715C0

	public delegate void SingleCompleteAction(SingleFileDownloader.DownloadResult singleResult, bool writeCacheFile); // TypeDefIndex: 11573; 0x0000000181D70A80-0x0000000181D70D30

	// Constructors
	public FilesDownloader() {} // Dummy constructor
	public FilesDownloader(List<FileDownloadInfo> files, long baseDownloadedLength, CompleteAction completion = null, SingleCompleteAction singleCompletion = null) {} // 0x0000000181D77020-0x0000000181D773A0

	// Methods
	// [XID] // 0x00000001898199F0-0x0000000189819A10
	private void StartDownload(object para) {} // 0x0000000181D75FD0-0x0000000181D76390
	// [XID] // 0x00000001898766D0-0x00000001898766F0
	private void CreateSingleFileDownloadTask() {} // 0x0000000181D76C20-0x0000000181D76D30
	// [XID] // 0x00000001898286E0-0x0000000189828700
	private bool CheckAllFinish() => default; // 0x0000000181D75DB0-0x0000000181D75FD0
	// [XID] // 0x000000018982F9F0-0x000000018982FA10
	public void Close() {} // 0x0000000181D76D30-0x0000000181D76F40
	// [XID] // 0x00000001898372D0-0x00000001898372F0
	private static bool OnRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => default; // 0x0000000181D759E0-0x0000000181D75AB0
	// [XID] // 0x000000018983E830-0x000000018983E850
	public static void PrepareServicePointManager() {} // 0x0000000181D766F0-0x0000000181D76810
}

