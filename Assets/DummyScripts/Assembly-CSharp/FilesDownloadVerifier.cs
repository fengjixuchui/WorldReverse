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

public class FilesDownloadVerifier // TypeDefIndex: 11560
{
	// Fields
	public Queue<FilesDownloadError> errors; // 0x10

	// Constructors
	public FilesDownloadVerifier() {} // 0x0000000182E767A0-0x0000000182E76830

	// Methods
	// [XID] // 0x0000000189779A40-0x0000000189779A60
	public bool VerifyAndRenameTempFile(FileDownloadInfo downloadInfo) => default; // 0x0000000182E761B0-0x0000000182E762E0
	// [XID] // 0x0000000189781510-0x0000000189781530
	private bool VerifyFile(string tempFilePath, long expectFileSize, string expectMd5) => default; // 0x0000000182E75D70-0x0000000182E75F60
	// [XID] // 0x0000000189790090-0x00000001897900B0
	private bool RenameTempFile(string tempFilePath, string savePath) => default; // 0x0000000182E762E0-0x0000000182E76690
	// [XID] // 0x00000001896B6CC0-0x00000001896B6CE0
	private bool DeleteFileIfExist(string filePath) => default; // 0x0000000182E760B0-0x0000000182E761B0
	// [XID] // 0x00000001897AE570-0x00000001897AE590
	private string MoveFileIfExist(string srcPath, string dstPath) => default; // 0x0000000182E75F60-0x0000000182E760B0
	// [XID] // 0x00000001896C57F0-0x00000001896C5810
	private string CopyFileIfExist(string srcPath, string dstPath) => default; // 0x0000000182E75C20-0x0000000182E75D70
	// [XID] // 0x00000001897889E0-0x0000000189788A00
	protected void EnqueueError(int errCode, string errMsg = "" /* Metadata: 0x00AE999B */) {} // 0x0000000182E76690-0x0000000182E767A0
}

