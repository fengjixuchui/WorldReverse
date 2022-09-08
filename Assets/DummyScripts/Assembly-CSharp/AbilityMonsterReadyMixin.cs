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

public sealed class AbilityMonsterReadyMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14551
{
	// Fields
	private MonsterReadyMixin _config; // 0x70

	// Constructors
	public AbilityMonsterReadyMixin() {} // 0x0000000182FD68D0-0x0000000182FD6940

	// Methods
	// [XID] // 0x0000000189AF4C20-0x0000000189AF4C40
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182FD5ED0-0x0000000182FD6090
	// [XID] // 0x0000000189AFC1A0-0x0000000189AFC1C0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000182FD61A0-0x0000000182FD6280
	// [XID] // 0x0000000189B03B10-0x0000000189B03B30
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000182FD6470-0x0000000182FD6690
	// [XID] // 0x0000000189B0B180-0x0000000189B0B1A0
	protected override void AddEventListener() {} // 0x0000000182FD5C10-0x0000000182FD5D40
	// [XID] // 0x0000000189B12A30-0x0000000189B12A50
	protected override void RemoveEventListener() {} // 0x0000000182FD62E0-0x0000000182FD6410
	// [XID] // 0x0000000189B19C80-0x0000000189B19CA0
	public override void OnAdded(bool syncToServer) {} // 0x0000000182FD5970-0x0000000182FD5A30
	// [XID] // 0x0000000189B212B0-0x0000000189B212D0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182FD5E20-0x0000000182FD5ED0
	// [XID] // 0x0000000189B28B20-0x0000000189B28B40
	public override void Clear() {} // 0x0000000182FD6100-0x0000000182FD61A0
	[BlackList] // 0x0000000189B2FF10-0x0000000189B2FF50
	// [XID] // 0x0000000189B2FF10-0x0000000189B2FF50
	public override void AutoAllocTypeFields() {} // 0x0000000182FD5AC0-0x0000000182FD5B60
	[BlackList] // 0x0000000189B3A820-0x0000000189B3A860
	// [XID] // 0x0000000189B3A820-0x0000000189B3A860
	public override void AutoRecycleTypeFields() {} // 0x0000000182FD5B60-0x0000000182FD5C10
	[BlackList] // 0x0000000189B45240-0x0000000189B45280
	// [XID] // 0x0000000189B45240-0x0000000189B45280
	public override void ReturnToObjectPool() {} // 0x0000000182FD6830-0x0000000182FD68D0
}

