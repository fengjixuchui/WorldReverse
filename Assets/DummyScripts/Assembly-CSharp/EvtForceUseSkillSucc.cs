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

public sealed class EvtForceUseSkillSucc : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20117
{
	// Fields
	public uint skillId; // 0x30
	public UseSkillType skillType; // 0x34

	// Constructors
	public EvtForceUseSkillSucc() {} // 0x00000001817C5A00-0x00000001817C5A60

	// Methods
	[BlackList] // 0x0000000189AA8180-0x0000000189AA81C0
	// [XID] // 0x0000000189AA8180-0x0000000189AA81C0
	public override void AutoAllocTypeFields() {} // 0x00000001817C54A0-0x00000001817C5540
	[BlackList] // 0x0000000189AB2D40-0x0000000189AB2D80
	// [XID] // 0x0000000189AB2D40-0x0000000189AB2D80
	public override void AutoRecycleTypeFields() {} // 0x00000001817C5540-0x00000001817C55F0
	[BlackList] // 0x0000000189ABD870-0x0000000189ABD8B0
	// [XID] // 0x0000000189ABD870-0x0000000189ABD8B0
	public override void ReturnToObjectPool() {} // 0x00000001817C5960-0x00000001817C5A00
	// [XID] // 0x0000000189AC8130-0x0000000189AC8150
	public void Init(uint targetID, uint skillId, UseSkillType skillType) {} // 0x00000001817C57B0-0x00000001817C58A0
	// [XID] // 0x0000000189ACF830-0x0000000189ACF850
	public override void CopyFrom(BaseEvent evt) {} // 0x00000001817C55F0-0x00000001817C56D0
}

