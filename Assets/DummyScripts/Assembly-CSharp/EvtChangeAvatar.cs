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

public sealed class EvtChangeAvatar : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20081
{
	// Fields
	public uint entityId; // 0x30
	public VisionType changeAvatarType; // 0x34
	public bool isAuthority; // 0x38
	public uint userId; // 0x3C
	public uint chargeSkillID; // 0x40

	// Constructors
	public EvtChangeAvatar() {} // 0x00000001814D0AC0-0x00000001814D0B20

	// Methods
	[BlackList] // 0x0000000189A9B160-0x0000000189A9B1A0
	// [XID] // 0x0000000189A9B160-0x0000000189A9B1A0
	public override void AutoAllocTypeFields() {} // 0x00000001814D0520-0x00000001814D05C0
	[BlackList] // 0x0000000189AA5560-0x0000000189AA55A0
	// [XID] // 0x0000000189AA5560-0x0000000189AA55A0
	public override void AutoRecycleTypeFields() {} // 0x00000001814D05C0-0x00000001814D0670
	[BlackList] // 0x0000000189AAFD70-0x0000000189AAFDB0
	// [XID] // 0x0000000189AAFD70-0x0000000189AAFDB0
	public override void ReturnToObjectPool() {} // 0x00000001814D0920-0x00000001814D09C0
	// [XID] // 0x0000000189ABA8E0-0x0000000189ABA900
	public void Init(uint entityId, bool isAuthority, uint userId, uint chargeSkillID = 0 /* Metadata: 0x00AFD232 */, VisionType changeAvatarType = VisionType.VisionNone /* Metadata: 0x00AFD236 */) {} // 0x00000001814D0740-0x00000001814D0860
	// [XID] // 0x0000000189AC21B0-0x0000000189AC21D0
	public override string ToString() => default; // 0x00000001814D09C0-0x00000001814D0AC0
}

