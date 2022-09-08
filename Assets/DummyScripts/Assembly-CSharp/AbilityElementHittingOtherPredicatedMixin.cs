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

public sealed class AbilityElementHittingOtherPredicatedMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14524
{
	// Fields
	private ElementHittingOtherPredicatedMixin _config; // 0x70
	private ActorAbilityPlugin _abilityPlugin; // 0x78
	private BaseEntity _entity; // 0x80
	private uint[] _singleTargets; // 0x88
	private uint[] _targetProcessIds; // 0x90

	// Constructors
	public AbilityElementHittingOtherPredicatedMixin() {} // 0x0000000182FBC380-0x0000000182FBC430

	// Methods
	// [XID] // 0x000000018975CFA0-0x000000018975CFC0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182FBBBB0-0x0000000182FBBD40
	// [XID] // 0x00000001897647A0-0x00000001897647C0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182FBBEB0-0x0000000182FBBF90
	// [XID] // 0x000000018976C240-0x000000018976C260
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182FBC1D0-0x0000000182FBC2E0
	// [XID] // 0x00000001897735E0-0x0000000189773600
	private bool OnHittingOther(EvtHittingOther evt) => default; // 0x0000000182FBB690-0x0000000182FBBBB0
	// [XID] // 0x000000018977ADD0-0x000000018977ADF0
	private bool EvaluateAbilityPredicate(BaseEvent evt) => default; // 0x0000000182FBBD40-0x0000000182FBBEB0
	// [XID] // 0x00000001897829C0-0x00000001897829E0
	private bool HasMassiveEntityElement(BaseEntity entity, ElementType elementType) => default; // 0x0000000182FBBFF0-0x0000000182FBC0F0
	[BlackList] // 0x0000000189789BF0-0x0000000189789C30
	// [XID] // 0x0000000189789BF0-0x0000000189789C30
	public override void AutoAllocTypeFields() {} // 0x0000000182FBB4D0-0x0000000182FBB570
	[BlackList] // 0x0000000189794020-0x0000000189794060
	// [XID] // 0x0000000189794020-0x0000000189794060
	public override void AutoRecycleTypeFields() {} // 0x0000000182FBB570-0x0000000182FBB630
	[BlackList] // 0x000000018979F330-0x000000018979F370
	// [XID] // 0x000000018979F330-0x000000018979F370
	public override void ReturnToObjectPool() {} // 0x0000000182FBC2E0-0x0000000182FBC380
}

