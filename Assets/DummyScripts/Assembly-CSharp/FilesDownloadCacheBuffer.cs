/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FilesDownloadCacheBuffer // TypeDefIndex: 11549
{
	// Fields
	public const long CACHE_BUFFER_SIZE = 65536; // Metadata: 0x00AE997F
	public string filePath; // 0x10
	public string md5; // 0x18
	public long cacheOffset; // 0x20
	public long fileOffset; // 0x28
	public byte[] buffer; // 0x30
	public bool isMarkOver; // 0x38

	// Constructors
	public FilesDownloadCacheBuffer() {} // 0x0000000181274600-0x0000000181274690

	// Methods
	// [XID] // 0x0000000189BB2DF0-0x0000000189BB2E10
	public void Reset() {} // 0x0000000181274510-0x0000000181274600
}

