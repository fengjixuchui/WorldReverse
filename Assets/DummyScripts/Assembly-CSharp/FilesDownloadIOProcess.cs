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

public sealed class FilesDownloadIOProcess : FilesDownloadBaseProcess // TypeDefIndex: 11553
{
	// Fields
	private Dictionary<string, FileStream> _tempFileStreamDict; // 0x20
	public Queue<string> completedFiles; // 0x28

	// Constructors
	public FilesDownloadIOProcess() {} // Dummy constructor
	public FilesDownloadIOProcess(FilesDownloadCacheBufferQueue webCacheBufferQueue, FilesDownloadCacheBufferQueue ioCacheBufferQueue) {} // 0x00000001831752E0-0x00000001831753A0

	// Methods
	// [XID] // 0x0000000189BDFF00-0x0000000189BDFF20
	private long WriteCacheBufferToFile(FilesDownloadCacheBuffer cacheBuffer) => default; // 0x0000000183174FC0-0x00000001831751A0
	// [XID] // 0x00000001895ECCC0-0x00000001895ECCE0
	public long ProcessOnce() => default; // 0x0000000183174E80-0x0000000183174FC0
	// [XID] // 0x00000001895F4310-0x00000001895F4330
	private FileStream OpenTempFile(string savePath, string md5) => default; // 0x0000000183174D20-0x0000000183174E80
	// [XID] // 0x00000001895FBB20-0x00000001895FBB40
	private void CloseTempFile(string savePath) {} // 0x00000001831751A0-0x00000001831752E0
}

