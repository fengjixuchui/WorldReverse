/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine.Networking;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FileDownloadHandler : DownloadHandlerScript // TypeDefIndex: 11591
{
	// Fields
	public FileDownloadInfo downloadInfo; // 0x18
	private string _tempFilePath; // 0x20
	private FileStream _tempFileStream; // 0x28
	public long downloadedLength; // 0x30
	public string errMsg; // 0x38
	public int errCode; // 0x40

	// Constructors
	public FileDownloadHandler() {} // 0x0000000181416AB0-0x0000000181416B60

	// Methods
	// [XID] // 0x0000000189B45580-0x0000000189B455A0
	public bool Init(FileDownloadInfo info) => default; // 0x0000000181415E40-0x0000000181415FE0
	// [XID] // 0x0000000189B4CAB0-0x0000000189B4CAD0
	protected override bool ReceiveData(byte[] data, int dataLength) => default; // 0x0000000181416830-0x0000000181416AB0
	// [XID] // 0x0000000189B54200-0x0000000189B54220
	protected override void CompleteContent() {} // 0x00000001814157B0-0x0000000181415C00
	// [XID] // 0x0000000189B5BC80-0x0000000189B5BCA0
	protected override void ReceiveContentLength(int contentLength) {} // 0x0000000181416710-0x0000000181416830
	// [XID] // 0x0000000189B63100-0x0000000189B63120
	public void Abort() {} // 0x0000000181416530-0x00000001814165D0
	// [XID] // 0x0000000189B6AA10-0x0000000189B6AA30
	public void CloseTempFile() {} // 0x0000000181416640-0x0000000181416710
	// [XID] // 0x0000000189B72220-0x0000000189B72240
	private bool CombineTempFiles(string tempFilePath, string savePath) => default; // 0x0000000181416300-0x0000000181416530
	// [XID] // 0x0000000189B79610-0x0000000189B79630
	private bool DeleteFileIfExist(string filePath) => default; // 0x0000000181415D50-0x0000000181415E40
	// [XID] // 0x0000000189B809B0-0x0000000189B809D0
	private string MoveFileIfExist(string srcPath, string dstPath) => default; // 0x0000000181415C00-0x0000000181415D50
	// [XID] // 0x0000000189B88600-0x0000000189B88620
	private string GetFileMd5(string filePath) => default; // 0x00000001814160D0-0x0000000181416300
}

