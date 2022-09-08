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

public sealed class EvtStageProgress : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20168
{
	// Fields
	public BaseLevel.LoadState state; // 0x30
	public float progress; // 0x34

	// Constructors
	public EvtStageProgress() {} // 0x0000000183607470-0x00000001836074D0

	// Methods
	[BlackList] // 0x00000001899A47B0-0x00000001899A47F0
	// [XID] // 0x00000001899A47B0-0x00000001899A47F0
	public override void AutoAllocTypeFields() {} // 0x0000000183606F20-0x0000000183606FC0
	[BlackList] // 0x00000001899AF0F0-0x00000001899AF130
	// [XID] // 0x00000001899AF0F0-0x00000001899AF130
	public override void AutoRecycleTypeFields() {} // 0x0000000183606FC0-0x0000000183607070
	[BlackList] // 0x00000001899B9560-0x00000001899B95A0
	// [XID] // 0x00000001899B9560-0x00000001899B95A0
	public override void ReturnToObjectPool() {} // 0x00000001836072E0-0x0000000183607380
	// [XID] // 0x00000001899C40C0-0x00000001899C40E0
	public void Init(BaseLevel.LoadState state, float progress) {} // 0x0000000183607140-0x0000000183607220
	// [XID] // 0x00000001899CB870-0x00000001899CB890
	public override string ToString() => default; // 0x0000000183607380-0x0000000183607470
}

