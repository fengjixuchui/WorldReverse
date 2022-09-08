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

public sealed class EvtHPChange : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20125
{
	// Fields
	public float hpChangeDelta; // 0x30
	public ChangHpReason changeHpReason; // 0x34

	// Constructors
	public EvtHPChange() {} // 0x0000000181D7AE20-0x0000000181D7AE80

	// Methods
	[BlackList] // 0x0000000189723930-0x0000000189723970
	// [XID] // 0x0000000189723930-0x0000000189723970
	public override void AutoAllocTypeFields() {} // 0x0000000181D7A8A0-0x0000000181D7A940
	[BlackList] // 0x000000018972E070-0x000000018972E0B0
	// [XID] // 0x000000018972E070-0x000000018972E0B0
	public override void AutoRecycleTypeFields() {} // 0x0000000181D7A940-0x0000000181D7A9F0
	[BlackList] // 0x0000000189738850-0x0000000189738890
	// [XID] // 0x0000000189738850-0x0000000189738890
	public override void ReturnToObjectPool() {} // 0x0000000181D7AC70-0x0000000181D7AD10
	// [XID] // 0x0000000189743240-0x0000000189743260
	public void Init(uint targetID, float deltaHPValue, ChangHpReason reason) {} // 0x0000000181D7AAC0-0x0000000181D7ABB0
	// [XID] // 0x000000018974AEA0-0x000000018974AEC0
	public override string ToString() => default; // 0x0000000181D7AD10-0x0000000181D7AE20
}

