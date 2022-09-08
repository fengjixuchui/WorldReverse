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

public sealed class FilesDownloadWebProcess : FilesDownloadBaseProcess // TypeDefIndex: 11561
{
	// Fields
	private SingleFileDownloadWebProcess _singleWebProcess; // 0x20
	public FileDownloadInfo downloadInfo; // 0x28
	public SingleFileDownloadResult result; // 0x30
	private bool _stop; // 0x38
	public Queue<FilesDownloadError> errors; // 0x40
	private bool _completed; // 0x48
	private bool _idle; // 0x49

	// Properties
	public bool completed { /* [XID] */ /* 0x00000001896D4020-0x00000001896D4040 */ get => default; } // 0x00000001825816D0-0x0000000182581770 
	public bool idle { /* [XID] */ /* 0x00000001896DB9A0-0x00000001896DB9C0 */ get => default; /* [XID] */ /* 0x00000001897CD150-0x00000001897CD170 */ set {} } // 0x0000000182581480-0x0000000182581520 0x0000000182581520-0x00000001825815D0

	// Constructors
	public FilesDownloadWebProcess() {} // Dummy constructor
	public FilesDownloadWebProcess(FilesDownloadCacheBufferQueue webCacheBufferQueue, FilesDownloadCacheBufferQueue ioCacheBufferQueue) {} // 0x0000000182581D90-0x0000000182581E40

	// Methods
	// [XID] // 0x000000018972A820-0x000000018972A840
	public void CreateSingleFileDownload(FileDownloadInfo info) {} // 0x0000000182581BB0-0x0000000182581CD0
	// [XID] // 0x00000001896F16B0-0x00000001896F16D0
	public void Start() {} // 0x00000001825815D0-0x00000001825816D0
	// [XID] // 0x00000001896F9100-0x00000001896F9120
	public void Stop() {} // 0x00000001825813D0-0x0000000182581480
	// [XID] // 0x0000000189682D90-0x0000000189682DB0
	private void StopBecauseError(int errCode, string errMsg = "" /* Metadata: 0x00AE999F */) {} // 0x0000000182581940-0x0000000182581A50
	// [XID] // 0x0000000189AF67F0-0x0000000189AF6810
	public void SetPause(bool val) {} // 0x0000000182581CD0-0x0000000182581D90
	// [XID] // 0x000000018970FBF0-0x000000018970FC10
	public void ProcessOnce() {} // 0x0000000182581A50-0x0000000182581BB0
}

