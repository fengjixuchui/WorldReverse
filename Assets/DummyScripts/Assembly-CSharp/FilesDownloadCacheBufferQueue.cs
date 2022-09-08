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

public sealed class FilesDownloadCacheBufferQueue : Queue<FilesDownloadCacheBuffer> // TypeDefIndex: 11550
{
	// Constructors
	public FilesDownloadCacheBufferQueue() {} // Dummy constructor
	public FilesDownloadCacheBufferQueue(int initialBufferNum) {} // 0x00000001825E19E0-0x00000001825E1AA0

	// Methods
	// [XID] // 0x0000000189BBA220-0x0000000189BBA240
	public FilesDownloadCacheBuffer LockDequeueBuffer() => default; // 0x00000001825E1870-0x00000001825E19E0
	// [XID] // 0x0000000189A2CAE0-0x0000000189A2CB00
	public void LockEnqueueBuffer(FilesDownloadCacheBuffer buffer) {} // 0x00000001825E1750-0x00000001825E1870
}

