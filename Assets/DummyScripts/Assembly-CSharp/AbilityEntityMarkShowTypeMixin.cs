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

public sealed class AbilityEntityMarkShowTypeMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14535
{
	// Fields
	private uint _lastSetAvatarId; // 0x70
	private EntityMarkType _tarType; // 0x74

	// Constructors
	public AbilityEntityMarkShowTypeMixin() {} // 0x0000000183E437A0-0x0000000183E43800

	// Methods
	// [XID] // 0x0000000189B82350-0x0000000189B82370
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183E43050-0x0000000183E431D0
	// [XID] // 0x0000000189B89BF0-0x0000000189B89C10
	public override void Clear() {} // 0x0000000183E43240-0x0000000183E432F0
	// [XID] // 0x0000000189B91180-0x0000000189B911A0
	public override void OnAdded(bool syncToServer) {} // 0x0000000183E42C90-0x0000000183E42D50
	// [XID] // 0x0000000189B983D0-0x0000000189B983F0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183E42F90-0x0000000183E43050
	// [XID] // 0x0000000189B9F920-0x0000000189B9F940
	private void TrySetEntityMark() {} // 0x0000000183E433B0-0x0000000183E43530
	// [XID] // 0x0000000189BA71B0-0x0000000189BA71D0
	private void TryResetEntityMark() {} // 0x0000000183E43590-0x0000000183E43680
	[BlackList] // 0x0000000189BAE2E0-0x0000000189BAE320
	// [XID] // 0x0000000189BAE2E0-0x0000000189BAE320
	public override void AutoAllocTypeFields() {} // 0x0000000183E42DE0-0x0000000183E42E80
	[BlackList] // 0x0000000189BB8860-0x0000000189BB88A0
	// [XID] // 0x0000000189BB8860-0x0000000189BB88A0
	public override void AutoRecycleTypeFields() {} // 0x0000000183E42E80-0x0000000183E42F30
	[BlackList] // 0x0000000189BC39B0-0x0000000189BC39F0
	// [XID] // 0x0000000189BC39B0-0x0000000189BC39F0
	public override void ReturnToObjectPool() {} // 0x0000000183E43700-0x0000000183E437A0
}

