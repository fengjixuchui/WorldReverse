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

public sealed class AbilityBeingHitMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14490
{
	// Fields
	private BeingHitMixin config; // 0x70

	// Constructors
	public AbilityBeingHitMixin() {} // 0x00000001842FB6A0-0x00000001842FB700

	// Methods
	// [XID] // 0x00000001898358F0-0x0000000189835910
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001842FAD70-0x00000001842FAEB0
	// [XID] // 0x000000018983CFE0-0x000000018983D000
	public override void Clear() {} // 0x00000001842FAEB0-0x00000001842FAF60
	// [XID] // 0x0000000189844690-0x00000001898446B0
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001842FB500-0x00000001842FB600
	// [XID] // 0x000000018984BC10-0x000000018984BC30
	public override bool OnEventRemote(BaseEvent evt) => default; // 0x00000001842FB400-0x00000001842FB500
	// [XID] // 0x0000000189852AD0-0x0000000189852AF0
	private bool OnBeingHit(EvtBeingHit evt) => default; // 0x00000001842FAF60-0x00000001842FB260
	[BlackList] // 0x000000018985A6A0-0x000000018985A6E0
	// [XID] // 0x000000018985A6A0-0x000000018985A6E0
	public override void AutoAllocTypeFields() {} // 0x00000001842FAB40-0x00000001842FABE0
	[BlackList] // 0x00000001898649F0-0x0000000189864A30
	// [XID] // 0x00000001898649F0-0x0000000189864A30
	public override void AutoRecycleTypeFields() {} // 0x00000001842FABE0-0x00000001842FAC90
	[BlackList] // 0x000000018986EE60-0x000000018986EEA0
	// [XID] // 0x000000018986EE60-0x000000018986EEA0
	public override void ReturnToObjectPool() {} // 0x00000001842FB600-0x00000001842FB6A0
}

