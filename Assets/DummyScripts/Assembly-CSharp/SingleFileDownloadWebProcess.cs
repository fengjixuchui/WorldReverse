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

public class SingleFileDownloadWebProcess // TypeDefIndex: 11563
{
	// Fields
	protected bool _enable; // 0x10
	protected bool _stop; // 0x11
	protected bool _pause; // 0x12
	protected bool _done; // 0x13
	protected bool _failed; // 0x14
	public FileDownloadInfo downloadInfo; // 0x18
	public Queue<FilesDownloadError> errors; // 0x20
	public SingleFileDownloadResult result; // 0x28
	private Stopwatch _stopWatch; // 0x30
	public readonly FilesDownloadCacheBufferQueue webCacheBufferQueue; // 0x38
	public readonly FilesDownloadCacheBufferQueue ioCacheBufferQueue; // 0x40
	private long _fileTotalLength; // 0x48
	public Status status; // 0x50

	// Properties
	public long fileTotalLength { /* [XID] */ /* 0x0000000189728C60-0x0000000189728C80 */ get => default; } // 0x0000000182BF5EF0-0x0000000182BF5F90 

	// Nested types
	public enum Status // TypeDefIndex: 11564
	{
		Prepare = 0,
		FetchLength = 1,
		Downloading = 2,
		Finish = 3
	}

	// Constructors
	public SingleFileDownloadWebProcess() {} // Dummy constructor
	public SingleFileDownloadWebProcess(FileDownloadInfo downloadInfo, FilesDownloadCacheBufferQueue webCacheBufferQueue, FilesDownloadCacheBufferQueue ioCacheBufferQueue) {} // 0x0000000182BF6F40-0x0000000182BF7070

	// Methods
	// [XID] // 0x0000000189731F20-0x0000000189731F40
	public void Start() {} // 0x0000000182BF5420-0x0000000182BF54D0
	// [XID] // 0x0000000189737ED0-0x0000000189737EF0
	public bool IsStart() => default; // 0x0000000182BF6EA0-0x0000000182BF6F40
	// [XID] // 0x000000018973FA20-0x000000018973FA40
	public void Stop() {} // 0x0000000182BF4E70-0x0000000182BF5000
	// [XID] // 0x0000000189746F80-0x0000000189746FA0
	public bool IsStop() => default; // 0x0000000182BF6400-0x0000000182BF64A0
	// [XID] // 0x0000000189673E40-0x0000000189673E60
	protected void Done() {} // 0x0000000182BF6710-0x0000000182BF67D0
	// [XID] // 0x0000000189755E00-0x0000000189755E20
	public bool IsDone() => default; // 0x0000000182BF6360-0x0000000182BF6400
	// [XID] // 0x000000018975D120-0x000000018975D140
	protected void Failed() {} // 0x0000000182BF5000-0x0000000182BF51B0
	// [XID] // 0x00000001897648A0-0x00000001897648C0
	public bool IsFailed() => default; // 0x0000000182BF6670-0x0000000182BF6710
	// [XID] // 0x000000018976C360-0x000000018976C380
	public void SetPause(bool val) {} // 0x0000000182BF6BC0-0x0000000182BF6D90
	// [XID] // 0x0000000189773760-0x0000000189773780
	private void BeginRecordProcessTime() {} // 0x0000000182BF6880-0x0000000182BF6930
	// [XID] // 0x000000018977AF50-0x000000018977AF70
	private void EndRecordAndSaveProcessTime() {} // 0x0000000182BF54D0-0x0000000182BF55B0
	// [XID] // 0x0000000189782B00-0x0000000189782B20
	protected void EnqueueError(int errCode, string errMsg = "" /* Metadata: 0x00AE99A3 */) {} // 0x0000000182BF6D90-0x0000000182BF6EA0
	// [XID] // 0x0000000189789CF0-0x0000000189789D10
	protected void FailedBecauseError(int errCode, string errMsg = "" /* Metadata: 0x00AE99A7 */) {} // 0x0000000182BF4D90-0x0000000182BF4E70
	// [XID] // 0x00000001897914F0-0x0000000189791510
	protected void ClearError() {} // 0x0000000182BF67D0-0x0000000182BF6880
	// [XID] // 0x0000000189798C50-0x0000000189798C70
	private void MoveToNextStatus() {} // 0x0000000182BF5D40-0x0000000182BF5DE0
	// [XID] // 0x00000001897A0B10-0x00000001897A0B30
	public void ProcessOnce() {} // 0x0000000182BF5F90-0x0000000182BF6080
	// [XID] // 0x00000001897A8100-0x00000001897A8120
	private void Prepare() {} // 0x0000000182BF5DE0-0x0000000182BF5EF0
	// [XID] // 0x00000001895F9060-0x00000001895F9080
	private bool FetchFileLengthWithRetry(int retryChance = 5 /* Metadata: 0x00AE99AB */, int sleepMillSec = 3000 /* Metadata: 0x00AE99AF */) => default; // 0x0000000182BF6930-0x0000000182BF6BC0
	// [XID] // 0x00000001897B7970-0x00000001897B7990
	private void FetchFileLength() {} // 0x0000000182BF64A0-0x0000000182BF6670
	// [XID] // 0x00000001897BF940-0x00000001897BF960
	private void DownloadFileChunkWithRetry(int retryChance = 5 /* Metadata: 0x00AE99B3 */, int sleepMillSec = 3000 /* Metadata: 0x00AE99B7 */) {} // 0x0000000182BF6080-0x0000000182BF6360
	// [XID] // 0x000000018965D3C0-0x000000018965D3E0
	private long DownloadFileChunk() => default; // 0x0000000182BF55B0-0x0000000182BF5D40
	// [XID] // 0x00000001897CE680-0x00000001897CE6A0
	private FilesDownloadCacheBuffer BlockGetWebCacheBuffer() => default; // 0x0000000182BF51B0-0x0000000182BF5310
	// [XID] // 0x00000001896649D0-0x00000001896649F0
	private long ReadStartOffset() => default; // 0x0000000182BF5310-0x0000000182BF5420
}

