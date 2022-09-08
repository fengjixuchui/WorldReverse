/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAbilityStart : BaseEvent, IAutoAllocRecycle, IEvtWithHitCollision // TypeDefIndex: 20042
{
	// Fields
	public string abilityName; // 0x30
	public uint otherID; // 0x38
	public uint triggerID; // 0x3C
	public AttackResult.HitCollsion? hitCollision; // 0x40
	public Dictionary<string, float> abilitySpecials; // 0x78
	public BaseEvent TriggerEvent; // 0x80

	// Constructors
	public EvtAbilityStart() {} // 0x00000001817E60F0-0x00000001817E6160

	// Methods
	[BlackList] // 0x00000001898EB910-0x00000001898EB950
	// [XID] // 0x00000001898EB910-0x00000001898EB950
	public override void AutoAllocTypeFields() {} // 0x00000001817E5720-0x00000001817E57C0
	[BlackList] // 0x00000001898F6240-0x00000001898F6280
	// [XID] // 0x00000001898F6240-0x00000001898F6280
	public override void AutoRecycleTypeFields() {} // 0x00000001817E57C0-0x00000001817E58D0
	[BlackList] // 0x0000000189900BB0-0x0000000189900BF0
	// [XID] // 0x0000000189900BB0-0x0000000189900BF0
	public override void ReturnToObjectPool() {} // 0x00000001817E5DF0-0x00000001817E5E90
	// [XID] // 0x000000018990B0D0-0x000000018990B0F0
	public override void Init(uint casterID) {} // 0x00000001817E59A0-0x00000001817E5A70
	// [XID] // 0x0000000189912D00-0x0000000189912D20
	public override void Clear() {} // 0x00000001817E5BC0-0x00000001817E5CD0
	// [XID] // 0x000000018991A610-0x000000018991A630
	public override string ToString() => default; // 0x00000001817E5E90-0x00000001817E60F0
	// [XID] // 0x0000000189921DE0-0x0000000189921E00
	public AttackResult.HitCollsion? GetHitCollision() => default; // 0x00000001817E5A70-0x00000001817E5BC0
}

