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

public sealed class EvtBuffAdd : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20073
{
	// Fields
	public AbilityState abilityState; // 0x30
	public uint sourceID; // 0x38

	// Constructors
	public EvtBuffAdd() {} // 0x0000000181A7FC70-0x0000000181A7FD30

	// Methods
	[BlackList] // 0x00000001898BE080-0x00000001898BE0C0
	// [XID] // 0x00000001898BE080-0x00000001898BE0C0
	public override void AutoAllocTypeFields() {} // 0x0000000181A7F6F0-0x0000000181A7F790
	[BlackList] // 0x00000001898C8AE0-0x00000001898C8B20
	// [XID] // 0x00000001898C8AE0-0x00000001898C8B20
	public override void AutoRecycleTypeFields() {} // 0x0000000181A7F790-0x0000000181A7F840
	[BlackList] // 0x00000001898D3030-0x00000001898D3070
	// [XID] // 0x00000001898D3030-0x00000001898D3070
	public override void ReturnToObjectPool() {} // 0x0000000181A7FAC0-0x0000000181A7FB60
	// [XID] // 0x00000001898DDE80-0x00000001898DDEA0
	public void Init(uint targetID, uint sourceID, AbilityState abilityState) {} // 0x0000000181A7F910-0x0000000181A7FA00
	// [XID] // 0x00000001898E5760-0x00000001898E5780
	public override string ToString() => default; // 0x0000000181A7FB60-0x0000000181A7FC70
}

