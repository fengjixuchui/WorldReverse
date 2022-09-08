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

public sealed class AbilityVelocityForceMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14598
{
	// Fields
	private VelocityForceMixin config; // 0x70
	private CharacterEntity _self; // 0x78
	private VCBaseMove _moveComp; // 0x80
	private MoveVelocityForcePlugin _velocityPlugin; // 0x88

	// Constructors
	public AbilityVelocityForceMixin() {} // 0x0000000182375030-0x0000000182375090

	// Methods
	// [XID] // 0x0000000189AB68B0-0x0000000189AB68D0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001823748C0-0x0000000182374B00
	// [XID] // 0x0000000189ABE3A0-0x0000000189ABE3C0
	public override void Clear() {} // 0x0000000182374BF0-0x0000000182374CB0
	// [XID] // 0x0000000189AC5EF0-0x0000000189AC5F10
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182374680-0x0000000182374770
	// [XID] // 0x0000000189ACD3C0-0x0000000189ACD3E0
	public override void OnAdded(bool syncToServer) {} // 0x0000000182374390-0x0000000182374490
	// [XID] // 0x0000000189AD51E0-0x0000000189AD5200
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001823747D0-0x00000001823748C0
	// [XID] // 0x0000000189ADCB90-0x0000000189ADCBB0
	public override void Tick(float inDeltaTime) {} // 0x0000000182374F80-0x0000000182375030
	[BlackList] // 0x0000000189AE43E0-0x0000000189AE4420
	// [XID] // 0x0000000189AE43E0-0x0000000189AE4420
	public override void AutoAllocTypeFields() {} // 0x0000000182374520-0x00000001823745C0
	[BlackList] // 0x0000000189AEF090-0x0000000189AEF0D0
	// [XID] // 0x0000000189AEF090-0x0000000189AEF0D0
	public override void AutoRecycleTypeFields() {} // 0x00000001823745C0-0x0000000182374680
	[BlackList] // 0x0000000189AF9680-0x0000000189AF96C0
	// [XID] // 0x0000000189AF9680-0x0000000189AF96C0
	public override void ReturnToObjectPool() {} // 0x0000000182374EE0-0x0000000182374F80
}

