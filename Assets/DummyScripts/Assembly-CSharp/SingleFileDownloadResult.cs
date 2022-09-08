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

public class SingleFileDownloadResult // TypeDefIndex: 11562
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
	public SingleFileDownloadResult() {} // 0x000000018478B7D0-0x000000018478B830

	// Methods
	// [XID] // 0x0000000189721640-0x0000000189721660
	public void FillError(Queue<FilesDownloadError> errors) {} // 0x000000018478B580-0x000000018478B7D0
}

