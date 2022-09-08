/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SdkInvokeTask : ThreadTask<SdkInvokeData> // TypeDefIndex: 26628
{
	// Fields
	private const string _taskName = "SdkInvokeTask"; // Metadata: 0x00B0C72B
	private Queue<SdkInvokeTaskCellBase> _waitQueue; // 0x48
	private List<SdkInvokeTaskCellBase> _finishList; // 0x50

	// Properties
	public override string taskName { /* [XID] */ /* 0x0000000189B4EBE0-0x0000000189B4EC00 */ get => default; } // 0x00000001817E5600-0x00000001817E56B0 

	// Constructors
	public SdkInvokeTask() {} // 0x00000001817E5540-0x00000001817E5600

	// Methods
	// [XID] // 0x0000000189B56440-0x0000000189B56460
	public override void Collect() {} // 0x00000001817E4B70-0x00000001817E4D50
	// [XID] // 0x0000000189B5DBF0-0x0000000189B5DC10
	public override void Execute() {} // 0x00000001817E4E80-0x00000001817E50F0
	// [XID] // 0x0000000189B65240-0x0000000189B65260
	public override void Flush() {} // 0x00000001817E50F0-0x00000001817E5350
	// [XID] // 0x0000000189B6C740-0x0000000189B6C760
	protected override void OnDestroy() {} // 0x00000001817E5460-0x00000001817E5540
	// [XID] // 0x0000000189B73ED0-0x0000000189B73EF0
	public void ClearOnDisconnect() {} // 0x00000001817E53B0-0x00000001817E5460
}

