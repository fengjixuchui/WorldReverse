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

public class FilesDownloadManager // TypeDefIndex: 11554
{
	// Fields
	public Status status; // 0x10
	private Queue<FileDownloadInfo> waitFiles; // 0x18
	public Dictionary<string, FileDownloadInfo> downloadingFiles; // 0x20
	public Queue<string> completedFiles; // 0x28
	public List<FilesDownloadWebProcess> webProcessList; // 0x30
	public FilesDownloadIOProcess ioProcess; // 0x38
	public FilesDownloadVerifier verifier; // 0x40
	public FilesDownloadCacheBufferQueue ioCacheBufferQueue; // 0x48
	public FilesDownloadCacheBufferQueue webCacheBufferQueue; // 0x50
	public FilesDownloadResult result; // 0x58
	public readonly int PARALLEL_MAX_NUM; // 0x60
	public CompleteAction completeAction; // 0x68
	public SingleCompleteAction singleCompleteAction; // 0x70
	private bool _stop; // 0x78
	private readonly long _baseDownloadedLength; // 0x80
	private long _actualTotalLength; // 0x88
	private long _completedFileLength; // 0x90
	private long _writingFileLength; // 0x98
	private long _downloadSpeed; // 0xA0
	private FilesDownloadSpeedDetect _speedDetect; // 0xA8
	private bool _pause; // 0xB0

	// Properties
	public int completedFileNum { /* [XID] */ /* 0x00000001896032E0-0x0000000189603300 */ get => default; } // 0x0000000183610F80-0x0000000183611060 
	public long downloadedLength { /* [XID] */ /* 0x000000018960AC80-0x000000018960ACA0 */ get => default; } // 0x0000000183610A00-0x0000000183610AB0 
	public long downloadSpeed { /* [XID] */ /* 0x0000000189612230-0x0000000189612250 */ get => default; } // 0x0000000183610800-0x00000001836108B0 
	public bool pause { /* [XID] */ /* 0x0000000189619BD0-0x0000000189619BF0 */ get => default; /* [XID] */ /* 0x0000000189620FF0-0x0000000189621010 */ set {} } // 0x0000000183610580-0x0000000183610630 0x000000018360F8A0-0x000000018360F9E0

	// Nested types
	public enum Status // TypeDefIndex: 11555
	{
		Idle = 0,
		Downloading = 1,
		Finish = 2,
		Cancelled = 3,
		Failed = 4
	}

	public delegate void CompleteAction(FilesDownloadResult result); // TypeDefIndex: 11556; 0x00000001836243A0-0x0000000183624600

	public delegate void SingleCompleteAction(SingleFileDownloadResult singleResult, bool writeCacheFile); // TypeDefIndex: 11557; 0x0000000183603290-0x0000000183603540

	// Constructors
	public FilesDownloadManager() {} // Dummy constructor
	public FilesDownloadManager(List<FileDownloadInfo> files, long baseDownloadedLength, CompleteAction completion = null, SingleCompleteAction singleCompletion = null) {} // 0x0000000183611060-0x0000000183611450

	// Methods
	// [XID] // 0x00000001896287A0-0x00000001896287C0
	private void CreateCacheBufferQueue() {} // 0x0000000183610E90-0x0000000183610F80
	// [XID] // 0x0000000189630110-0x0000000189630130
	private void CreateProcess() {} // 0x000000018360F9E0-0x000000018360FB80
	// [XID] // 0x0000000189637DE0-0x0000000189637E00
	private bool IsLocalFileAlreadyPerfect(FileDownloadInfo downloadInfo) => default; // 0x0000000183610AB0-0x0000000183610C40
	// [XID] // 0x000000018963F030-0x000000018963F050
	private void StartDownload(object para) {} // 0x000000018360FF30-0x0000000183610580
	// [XID] // 0x0000000189646940-0x0000000189646960
	private void CheckCompletedFiles() {} // 0x000000018360F490-0x000000018360F8A0
	// [XID] // 0x000000018964E0E0-0x000000018964E100
	private SingleFileDownloadResult CreateSingleResult(FileDownloadInfo downloadInfo, bool success, Queue<FilesDownloadError> errors) => default; // 0x000000018360FDF0-0x000000018360FF30
	// [XID] // 0x0000000189655970-0x0000000189655990
	private void RunSingleCompleteCallback(FileDownloadInfo downloadInfo, SingleFileDownloadResult singleResult) {} // 0x000000018360FD00-0x000000018360FDF0
	// [XID] // 0x000000018965D140-0x000000018965D160
	private FilesDownloadWebProcess GetIdleWebProcess() => default; // 0x0000000183610C40-0x0000000183610D70
	// [XID] // 0x00000001897DBE60-0x00000001897DBE80
	private bool CheckAllFinish() => default; // 0x000000018360FB80-0x000000018360FD00
	// [XID] // 0x000000018966BD70-0x000000018966BD90
	public void StopDownload() {} // 0x0000000183610630-0x00000001836106E0
	// [XID] // 0x0000000189673B00-0x0000000189673B20
	private void StopAllProcess() {} // 0x00000001836106E0-0x0000000183610800
	// [XID] // 0x000000018967B220-0x000000018967B240
	public static string GetTempFilePath(string filePath, string md5) => default; // 0x00000001836108B0-0x0000000183610A00
	// [XID] // 0x0000000189682B40-0x0000000189682B60
	private static bool OnRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => default; // 0x000000018360F3C0-0x000000018360F490
	// [XID] // 0x000000018968A720-0x000000018968A740
	public static void PrepareServicePointManager() {} // 0x0000000183610D70-0x0000000183610E90
}

