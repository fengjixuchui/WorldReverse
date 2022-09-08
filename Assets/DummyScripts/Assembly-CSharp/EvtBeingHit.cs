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

public sealed class EvtBeingHit : BaseEvent, IAutoAllocRecycle, IEvtWithOtherID, IEvtWithHitCollision, IEvtWithAttackResult // TypeDefIndex: 20069
{
	// Fields
	private uint _attackerID; // 0x30
	private AttackResult _attackResult; // 0x38

	// Constructors
	public EvtBeingHit() {} // 0x00000001822881F0-0x0000000182288250

	// Methods
	[BlackList] // 0x00000001897B9890-0x00000001897B98D0
	// [XID] // 0x00000001897B9890-0x00000001897B98D0
	public override void AutoAllocTypeFields() {} // 0x0000000182287250-0x00000001822872F0
	[BlackList] // 0x00000001897C4680-0x00000001897C46C0
	// [XID] // 0x00000001897C4680-0x00000001897C46C0
	public override void AutoRecycleTypeFields() {} // 0x00000001822872F0-0x00000001822873A0
	[BlackList] // 0x00000001897CEF80-0x00000001897CEFC0
	// [XID] // 0x00000001897CEF80-0x00000001897CEFC0
	public override void ReturnToObjectPool() {} // 0x0000000182288020-0x00000001822880C0
	// [XID] // 0x00000001897D9DF0-0x00000001897D9E10
	public void Init(uint targetID, uint attackerID, AttackResult attackResult) {} // 0x0000000182287610-0x0000000182287790
	// [XID] // 0x00000001897E1100-0x00000001897E1120
	public override void CopyFrom(BaseEvent evt) {} // 0x0000000182287410-0x0000000182287530
	// [XID] // 0x00000001897E8910-0x00000001897E8930
	public override void Clear() {} // 0x0000000182287AC0-0x0000000182287BB0
	// [XID] // 0x00000001897F04E0-0x00000001897F0500
	public uint GetOtherID() => default; // 0x0000000182287BB0-0x0000000182287C50
	// [XID] // 0x00000001897F7C50-0x00000001897F7C70
	public AttackResult.HitCollsion? GetHitCollision() => default; // 0x0000000182287790-0x0000000182287A60
	// [XID] // 0x00000001897FF2D0-0x00000001897FF2F0
	public AttackResult GetAttackResult() => default; // 0x0000000182287C50-0x0000000182287E20
	// [XID] // 0x0000000189806A90-0x0000000189806AB0
	public override string ToString() => default; // 0x00000001822880C0-0x00000001822881F0
	// [XID] // 0x000000018980E1D0-0x000000018980E1F0
	public override void PreHandle() {} // 0x0000000182287E80-0x0000000182287F60
}

