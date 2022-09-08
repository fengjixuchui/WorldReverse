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

public sealed class EvtPlayerDie : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20144
{
	// Properties
	public bool IsInBigWorld { /* [XID] */ /* 0x0000000189AF2A00-0x0000000189AF2A40 */ get; /* [XID] */ /* 0x0000000189AFCDB0-0x0000000189AFCDF0 */ private set; } // 0x00000001844E3A70-0x00000001844E3AD0 0x00000001844E3B30-0x00000001844E3B90
	public bool IsInMultiplayer { /* [XID] */ /* 0x0000000189B075F0-0x0000000189B07630 */ get; /* [XID] */ /* 0x0000000189B11E40-0x0000000189B11E80 */ private set; } // 0x00000001844E3CB0-0x00000001844E3D10 0x00000001844E3BF0-0x00000001844E3C50
	public PlayerDieType DieType { /* [XID] */ /* 0x0000000189B1C530-0x0000000189B1C570 */ get; /* [XID] */ /* 0x0000000189B26AF0-0x0000000189B26B30 */ private set; } // 0x00000001844E3AD0-0x00000001844E3B30 0x00000001844E3830-0x00000001844E3890

	// Constructors
	public EvtPlayerDie() {} // 0x00000001844E3FF0-0x00000001844E4050

	// Methods
	[BlackList] // 0x0000000189AD2B80-0x0000000189AD2BC0
	// [XID] // 0x0000000189AD2B80-0x0000000189AD2BC0
	public override void AutoAllocTypeFields() {} // 0x00000001844E3560-0x00000001844E3600
	[BlackList] // 0x0000000189ADD890-0x0000000189ADD8D0
	// [XID] // 0x0000000189ADD890-0x0000000189ADD8D0
	public override void AutoRecycleTypeFields() {} // 0x00000001844E3600-0x00000001844E3760
	[BlackList] // 0x0000000189AE7E90-0x0000000189AE7ED0
	// [XID] // 0x0000000189AE7E90-0x0000000189AE7ED0
	public override void ReturnToObjectPool() {} // 0x00000001844E3D10-0x00000001844E3DB0
	// [XID] // 0x0000000189B30CB0-0x0000000189B30CD0
	public void Init(PlayerDieType dieType, bool isInMultiplayer, bool isInBigWorld) {} // 0x00000001844E3890-0x00000001844E3A70
	// [XID] // 0x0000000189B38310-0x0000000189B38330
	public override string ToString() => default; // 0x00000001844E3DB0-0x00000001844E3FF0
}

