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

public sealed class AbilityDoActionByEnergyChangeMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14509
{
	// Fields
	private DoActionByEnergyChangeMixin config; // 0x70
	private bool _lastMax; // 0x78

	// Constructors
	public AbilityDoActionByEnergyChangeMixin() {} // 0x0000000185A6C1A0-0x0000000185A6C200

	// Methods
	// [XID] // 0x00000001897B7890-0x00000001897B78B0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000185A6B550-0x0000000185A6B690
	// [XID] // 0x00000001897BF7A0-0x00000001897BF7C0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000185A6B690-0x0000000185A6B770
	// [XID] // 0x00000001897C6EF0-0x00000001897C6F10
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000185A6BF20-0x0000000185A6C100
	// [XID] // 0x00000001897CE500-0x00000001897CE520
	private FightPropType CompareElementType(ElementType elementType, EvtChangeProp evt) => default; // 0x0000000185A6B7D0-0x0000000185A6B9B0
	// [XID] // 0x00000001897D5BB0-0x00000001897D5BD0
	public bool OnEvtChangeProp(EvtChangeProp evt) => default; // 0x0000000185A6BA90-0x0000000185A6BF20
	// [XID] // 0x00000001897DD330-0x00000001897DD350
	private bool CheckBallType(List<uint> paramList) => default; // 0x0000000185A6B290-0x0000000185A6B4F0
	[BlackList] // 0x00000001897E4BA0-0x00000001897E4BE0
	// [XID] // 0x00000001897E4BA0-0x00000001897E4BE0
	public override void AutoAllocTypeFields() {} // 0x0000000185A6B140-0x0000000185A6B1E0
	[BlackList] // 0x00000001897EF6C0-0x00000001897EF700
	// [XID] // 0x00000001897EF6C0-0x00000001897EF700
	public override void AutoRecycleTypeFields() {} // 0x0000000185A6B1E0-0x0000000185A6B290
	[BlackList] // 0x00000001897FA1B0-0x00000001897FA1F0
	// [XID] // 0x00000001897FA1B0-0x00000001897FA1F0
	public override void ReturnToObjectPool() {} // 0x0000000185A6C100-0x0000000185A6C1A0
}

