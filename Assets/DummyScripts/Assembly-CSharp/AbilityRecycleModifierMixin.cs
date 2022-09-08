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

public sealed class AbilityRecycleModifierMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14557
{
	// Fields
	private RecycleModifierMixin _config; // 0x70
	private float _nextAddTime; // 0x78

	// Constructors
	public AbilityRecycleModifierMixin() {} // 0x0000000183816330-0x00000001838163A0

	// Methods
	// [XID] // 0x00000001896C9A50-0x00000001896C9A70
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183815C50-0x0000000183815D90
	// [XID] // 0x00000001896D1280-0x00000001896D12A0
	public override void OnAdded(bool syncToServer) {} // 0x0000000183815820-0x00000001838158F0
	// [XID] // 0x00000001896D8960-0x00000001896D8980
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183815B30-0x0000000183815C50
	// [XID] // 0x00000001896E01B0-0x00000001896E01D0
	public override void Clear() {} // 0x0000000183815E80-0x0000000183815F30
	// [XID] // 0x00000001896E74C0-0x00000001896E74E0
	public override void Tick(float inDeltaTime) {} // 0x0000000183816170-0x0000000183816330
	[BlackList] // 0x00000001896EEAA0-0x00000001896EEAE0
	// [XID] // 0x00000001896EEAA0-0x00000001896EEAE0
	public override void AutoAllocTypeFields() {} // 0x0000000183815980-0x0000000183815A20
	[BlackList] // 0x00000001896F8EE0-0x00000001896F8F20
	// [XID] // 0x00000001896F8EE0-0x00000001896F8F20
	public override void AutoRecycleTypeFields() {} // 0x0000000183815A20-0x0000000183815AD0
	[BlackList] // 0x0000000189703840-0x0000000189703880
	// [XID] // 0x0000000189703840-0x0000000189703880
	public override void ReturnToObjectPool() {} // 0x00000001838160D0-0x0000000183816170
}

