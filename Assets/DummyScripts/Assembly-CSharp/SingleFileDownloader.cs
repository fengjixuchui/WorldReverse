/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SingleFileDownloader // TypeDefIndex: 11595
{
	// Fields
	public string url; // 0x10
	public string savePath; // 0x18
	private string _expectMd5; // 0x20
	private long _expectFileSize; // 0x28
	private int _partNum; // 0x30
	private long _fileTotalLength; // 0x38
	private Dictionary<int, string> _tempFileDict; // 0x40
	private int _partSuccessFlag; // 0x48
	private int _threadCompleteFlag; // 0x4C
	private Dictionary<int, ChunkInfo> _chunkDict; // 0x50
	private FileStream _tempFileStream; // 0x58
	private bool _stop; // 0x60
	private bool _pause; // 0x61
	public Queue<Error> errors; // 0x68
	public Status status; // 0x70
	private const int NET_BUFF_SIZE = 65536; // Metadata: 0x00AE9AB3
	private const long FILE_LEN_1MB = 1048576; // Metadata: 0x00AE9AB7
	private const long FILE_LEN_PART_2 = 1048576; // Metadata: 0x00AE9ABF
	private const long FILE_LEN_PART_4 = 10485760; // Metadata: 0x00AE9AC7

	// Properties
	public long fileTotalLength { /* [XID] */ /* 0x0000000189637DC0-0x0000000189637DE0 */ get => default; } // 0x000000018354C970-0x000000018354CA10 
	public float progress { /* [XID] */ /* 0x00000001898AB620-0x00000001898AB640 */ get => default; } // 0x000000018354ED00-0x000000018354EDD0 
	public bool pause { /* [XID] */ /* 0x0000000189646920-0x0000000189646940 */ get => default; /* [XID] */ /* 0x000000018964E0C0-0x000000018964E0E0 */ set {} } // 0x000000018354DF20-0x000000018354DFC0 0x000000018354C080-0x000000018354C130

	// Nested types
	public class ChunkInfo // TypeDefIndex: 11596
	{
		// Fields
		public int index; // 0x10
		public long totalLength; // 0x18
		public long downloadedLength; // 0x20

		// Constructors
		public ChunkInfo() {} // 0x000000018355A800-0x000000018355A860
	}

	public class DownloadResult // TypeDefIndex: 11597
	{
		// Fields
		public long size; // 0x10
		public string url; // 0x18
		public string savePath; // 0x20
		public bool success; // 0x28
		public string errMsg; // 0x30
		public int errCode; // 0x38
		public long time; // 0x40

		// Constructors
		public DownloadResult() {} // 0x000000018355B580-0x000000018355B5E0

		// Methods
		// [XID] // 0x00000001896E31A0-0x00000001896E31C0
		public void FillError(Queue<Error> errors) {} // 0x000000018355B330-0x000000018355B580
	}

	public class Error // TypeDefIndex: 11598
	{
		// Fields
		public int code; // 0x10
		public string msg; // 0x18

		// Constructors
		public Error() {} // Dummy constructor
		public Error(int code, string msg) {} // 0x000000018355B8E0-0x000000018355B960
	}

	private class ErrorComparer : IEqualityComparer<Error> // TypeDefIndex: 11599
	{
		// Constructors
		public ErrorComparer() {} // 0x000000018353C270-0x000000018353C2D0

		// Methods
		// [XID] // 0x00000001898BAD10-0x00000001898BAD30
		public bool Equals(Error x, Error y) => default; // 0x000000018353C000-0x000000018353C170
		// [XID] // 0x00000001898C1FE0-0x00000001898C2000
		public int GetHashCode(Error x) => default; // 0x000000018353C170-0x000000018353C270
	}

	private class Range // TypeDefIndex: 11600
	{
		// Fields
		public long start; // 0x10
		public long end; // 0x18

		// Properties
		public long size { /* [XID] */ /* 0x0000000189909000-0x0000000189909020 */ get => default; } // 0x000000018355B7D0-0x000000018355B880 

		// Constructors
		public Range() {} // 0x000000018355B880-0x000000018355B8E0
	}

	public enum Status // TypeDefIndex: 11601
	{
		Idle = 0,
		Downloading = 1,
		Combine = 2,
		Finish = 3,
		Failed = 4
	}

	// Constructors
	public SingleFileDownloader() {} // Dummy constructor
	public SingleFileDownloader(string url, string savePath, long fileSize = 0 /* Metadata: 0x00AE9A93 */, string md5 = "" /* Metadata: 0x00AE9A9B */) {} // 0x000000018354F100-0x000000018354F210

	// Methods
	// [XID] // 0x0000000189655950-0x0000000189655970
	public void StartDownload(Action<DownloadResult> completeAction = null) {} // 0x000000018354CB90-0x000000018354D260
	// [XID] // 0x00000001898CB100-0x00000001898CB120
	private bool FetchFileLengthWithRetry(int retryChance = 5 /* Metadata: 0x00AE9A9F */, int sleepMillSec = 3000 /* Metadata: 0x00AE9AA3 */) => default; // 0x000000018354EDD0-0x000000018354F020
	// [XID] // 0x00000001896646F0-0x0000000189664710
	private void FetchFileLength() {} // 0x000000018354EB40-0x000000018354ED00
	// [XID] // 0x000000018966BD50-0x000000018966BD70
	private List<Range> GetRanges(long totalLen, int partNum) => default; // 0x000000018354D5D0-0x000000018354D860
	// [XID] // 0x00000001899019D0-0x00000001899019F0
	private void DownloadFileChunkWithRetry(int index, Range range, int retryChance = 5 /* Metadata: 0x00AE9AA7 */, int sleepMillSec = 3000 /* Metadata: 0x00AE9AAB */) {} // 0x000000018354D860-0x000000018354DF20
	// [XID] // 0x000000018967B200-0x000000018967B220
	private long DownloadFileChunk(ChunkInfo chunk, Range range, string tempFilePath) => default; // 0x000000018354C280-0x000000018354C870
	// [XID] // 0x00000001898DA1B0-0x00000001898DA1D0
	private int GetPartNum(long fileLength) => default; // 0x000000018354CAE0-0x000000018354CB90
	// [XID] // 0x000000018968A700-0x000000018968A720
	private string GetTempFilePath(int index, string filePath) => default; // 0x000000018354DFC0-0x000000018354E0E0
	// [XID] // 0x00000001896923F0-0x0000000189692410
	private bool CheckAllThreadsComplete() => default; // 0x000000018354E480-0x000000018354E550
	// [XID] // 0x0000000189699810-0x0000000189699830
	private bool CheckDownloadSuccess() => default; // 0x000000018354CA10-0x000000018354CAE0
	// [XID] // 0x0000000189941B70-0x0000000189941B90
	private bool CombineTempFiles() => default; // 0x000000018354E550-0x000000018354EB40
	// [XID] // 0x00000001896A81F0-0x00000001896A8210
	private void Stop() {} // 0x000000018354BFE0-0x000000018354C080
	// [XID] // 0x00000001896AF5C0-0x00000001896AF5E0
	private void StopBecauseError(int errCode, string msg = "" /* Metadata: 0x00AE9AAF */) {} // 0x000000018354D4C0-0x000000018354D5D0
	// [XID] // 0x00000001896B6CA0-0x00000001896B6CC0
	public long GetTotalDownloadedLength() => default; // 0x000000018354D260-0x000000018354D4C0
	// [XID] // 0x000000018998A090-0x000000018998A0B0
	public void Close() {} // 0x000000018354F020-0x000000018354F100
	// [XID] // 0x00000001896C57D0-0x00000001896C57F0
	private bool DeleteFileIfExist(string filePath) => default; // 0x000000018354C870-0x000000018354C970
	// [XID] // 0x00000001896CCE40-0x00000001896CCE60
	private string MoveFileIfExist(string srcPath, string dstPath) => default; // 0x000000018354C130-0x000000018354C280
	// [XID] // 0x00000001896D4000-0x00000001896D4020
	private string CopyFileIfExist(string srcPath, string dstPath) => default; // 0x000000018354BE90-0x000000018354BFE0
	// [XID] // 0x00000001896DB980-0x00000001896DB9A0
	private int GetErrCodeFromException(Exception e) => default; // 0x000000018354E0E0-0x000000018354E480
}

