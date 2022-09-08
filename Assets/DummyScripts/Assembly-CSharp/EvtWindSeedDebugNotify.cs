/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtWindSeedDebugNotify : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20182
{
	// Fields
	public WindSeedDebugNotifyType debugNotify; // 0x30

	// Nested types
	public enum WindSeedDebugNotifyType // TypeDefIndex: 20183
	{
		AddSignal = 0,
		SendSeedPos = 1,
		ConsumeSeed = 2,
		PrintAllSeedID = 3,
		ReceiveBullet = 4
	}

	// Constructors
	public EvtWindSeedDebugNotify() {} // 0x00000001828A0C60-0x00000001828A0CC0

	// Methods
	[BlackList] // 0x0000000189BC14A0-0x0000000189BC14E0
	// [XID] // 0x0000000189BC14A0-0x0000000189BC14E0
	public override void AutoAllocTypeFields() {} // 0x00000001828A0740-0x00000001828A07E0
	[BlackList] // 0x0000000189BCBD80-0x0000000189BCBDC0
	// [XID] // 0x0000000189BCBD80-0x0000000189BCBDC0
	public override void AutoRecycleTypeFields() {} // 0x00000001828A07E0-0x00000001828A0890
	[BlackList] // 0x0000000189BD61C0-0x0000000189BD6200
	// [XID] // 0x0000000189BD61C0-0x0000000189BD6200
	public override void ReturnToObjectPool() {} // 0x00000001828A0AE0-0x00000001828A0B80
	// [XID] // 0x00000001895E5F10-0x00000001895E5F30
	public void Init(WindSeedDebugNotifyType notify) {} // 0x00000001828A0960-0x00000001828A0A20
	// [XID] // 0x00000001895ED850-0x00000001895ED870
	public override string ToString() => default; // 0x00000001828A0B80-0x00000001828A0C60
}

