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

public class DownloadBadBundleChecker // TypeDefIndex: 11610
{
	// Fields
	public int totalFileNum; // 0x10
	public int checkedFileNum; // 0x14
	public string checkingFile; // 0x18
	public Action<bool> OnFinish; // 0x20
	public Action OnCancel; // 0x28
	private bool _stop; // 0x30
	private bool _checking; // 0x31

	// Properties
	public bool checking { /* [XID] */ /* 0x0000000189A3EC90-0x0000000189A3ECB0 */ get => default; } // 0x0000000181554F20-0x0000000181554FC0 

	// Constructors
	public DownloadBadBundleChecker() {} // 0x0000000181555C50-0x0000000181555CB0

	// Methods
	// [XID] // 0x0000000189A463A0-0x0000000189A463C0
	public void StartCheckTask() {} // 0x0000000181555820-0x0000000181555C50
	// [XID] // 0x0000000189AC4690-0x0000000189AC46B0
	public void StopCheckTask() {} // 0x0000000181555780-0x0000000181555820
	// [XID] // 0x0000000189ACBD10-0x0000000189ACBD30
	private bool ScanAllBundles(DownloadVersionMap resPersistVersion, DownloadVersionMap dataPersistVersion, DownloadVersionMap silencePersistVersion, DownloadVersionMap resStreamingVersion, DownloadVersionMap dataStreamingVersion, DownloadVersionMap silenceStreamingVersion) => default; // 0x0000000181554A30-0x0000000181554F20
	// [XID] // 0x0000000189AD36D0-0x0000000189AD36F0
	private List<string> FindBadFiles(DownloadVersionMap persistVersion, DownloadVersionMap streamingVersion) => default; // 0x0000000181554FC0-0x0000000181555780
}

