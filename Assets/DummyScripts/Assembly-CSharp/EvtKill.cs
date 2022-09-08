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

public sealed class EvtKill : BaseEvent, IAutoAllocRecycle, IEvtWithOtherID, IEvtWithAttackTag // TypeDefIndex: 20131
{
	// Fields
	public uint killerID; // 0x30
	public string attackTag; // 0x38
	public DieStateFlag dieType; // 0x40

	// Constructors
	public EvtKill() {} // 0x0000000180FD10E0-0x0000000180FD1140

	// Methods
	[BlackList] // 0x0000000189842240-0x0000000189842280
	// [XID] // 0x0000000189842240-0x0000000189842280
	public override void AutoAllocTypeFields() {} // 0x0000000180FD09F0-0x0000000180FD0A90
	[BlackList] // 0x000000018984C7A0-0x000000018984C7E0
	// [XID] // 0x000000018984C7A0-0x000000018984C7E0
	public override void AutoRecycleTypeFields() {} // 0x0000000180FD0A90-0x0000000180FD0B40
	[BlackList] // 0x0000000189856800-0x0000000189856840
	// [XID] // 0x0000000189856800-0x0000000189856840
	public override void ReturnToObjectPool() {} // 0x0000000180FD0F20-0x0000000180FD0FC0
	// [XID] // 0x00000001896617E0-0x0000000189661800
	public void Init(uint targetID, uint killerID, string attackTag = null, DieStateFlag dieType = DieStateFlag.None /* Metadata: 0x00AFD27A */) {} // 0x0000000180FD0C10-0x0000000180FD0D20
	// [XID] // 0x0000000189821380-0x00000001898213A0
	public uint GetOtherID() => default; // 0x0000000180FD0D20-0x0000000180FD0DC0
	// [XID] // 0x000000018986F940-0x000000018986F960
	public string GetAttackTag() => default; // 0x0000000180FD0E80-0x0000000180FD0F20
	// [XID] // 0x0000000189876FD0-0x0000000189876FF0
	public override string ToString() => default; // 0x0000000180FD0FC0-0x0000000180FD10E0
}

