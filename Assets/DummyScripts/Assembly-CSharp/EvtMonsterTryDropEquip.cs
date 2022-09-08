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

public sealed class EvtMonsterTryDropEquip : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20133
{
	// Fields
	public bool dropAll; // 0x30
	public string[] equipParts; // 0x38

	// Constructors
	public EvtMonsterTryDropEquip() {} // 0x0000000182C33D70-0x0000000182C33DD0

	// Methods
	[BlackList] // 0x00000001898AC160-0x00000001898AC1A0
	// [XID] // 0x00000001898AC160-0x00000001898AC1A0
	public override void AutoAllocTypeFields() {} // 0x0000000182C33820-0x0000000182C338C0
	[BlackList] // 0x00000001898B6890-0x00000001898B68D0
	// [XID] // 0x00000001898B6890-0x00000001898B68D0
	public override void AutoRecycleTypeFields() {} // 0x0000000182C338C0-0x0000000182C33970
	[BlackList] // 0x00000001898C1200-0x00000001898C1240
	// [XID] // 0x00000001898C1200-0x00000001898C1240
	public override void ReturnToObjectPool() {} // 0x0000000182C33BF0-0x0000000182C33C90
	// [XID] // 0x00000001898CB8F0-0x00000001898CB910
	public void Init(uint targetID, bool dropAll, string[] equipParts) {} // 0x0000000182C33A40-0x0000000182C33B30
	// [XID] // 0x00000001898D2FD0-0x00000001898D2FF0
	public override string ToString() => default; // 0x0000000182C33C90-0x0000000182C33D70
}

