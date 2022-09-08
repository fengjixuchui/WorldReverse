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

public sealed class AbilityAttachToElementTypeMixin : BaseAbilityAttachToMixin, IAutoAllocRecycle // TypeDefIndex: 14472
{
	// Fields
	private AttachToElementTypeMixin _config; // 0x78
	private LCAbilityElement _abilityElement; // 0x80

	// Properties
	protected override string modifierName { /* [XID] */ /* 0x000000018970B0D0-0x000000018970B0F0 */ get => default; } // 0x00000001817CAFC0-0x00000001817CB070 

	// Constructors
	public AbilityAttachToElementTypeMixin() {} // 0x00000001817CB110-0x00000001817CB170

	// Methods
	// [XID] // 0x00000001896FC330-0x00000001896FC350
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001817CA860-0x00000001817CA9D0
	// [XID] // 0x00000001897038A0-0x00000001897038C0
	public override void Clear() {} // 0x00000001817CA9D0-0x00000001817CAA80
	// [XID] // 0x0000000189712910-0x0000000189712930
	protected override void AddEventListener() {} // 0x00000001817CA6C0-0x00000001817CA800
	// [XID] // 0x000000018971A1D0-0x000000018971A1F0
	protected override void RemoveEventListener() {} // 0x00000001817CAAE0-0x00000001817CAC20
	// [XID] // 0x0000000189721500-0x0000000189721520
	protected override bool CheckCondition() => default; // 0x00000001817CAE80-0x00000001817CAFC0
	[BlackList] // 0x0000000189728B20-0x0000000189728B60
	// [XID] // 0x0000000189728B20-0x0000000189728B60
	public override void AutoAllocTypeFields() {} // 0x00000001817CA570-0x00000001817CA610
	[BlackList] // 0x0000000189733290-0x00000001897332D0
	// [XID] // 0x0000000189733290-0x00000001897332D0
	public override void AutoRecycleTypeFields() {} // 0x00000001817CA610-0x00000001817CA6C0
	[BlackList] // 0x000000018973E1E0-0x000000018973E220
	// [XID] // 0x000000018973E1E0-0x000000018973E220
	public override void ReturnToObjectPool() {} // 0x00000001817CB070-0x00000001817CB110
}

