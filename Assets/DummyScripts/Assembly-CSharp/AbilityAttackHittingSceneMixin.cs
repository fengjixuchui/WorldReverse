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

public sealed class AbilityAttackHittingSceneMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14481
{
	// Fields
	private AttackHittingSceneMixin config; // 0x70

	// Constructors
	public AbilityAttackHittingSceneMixin() {} // 0x0000000182BD5D90-0x0000000182BD5DF0

	// Methods
	// [XID] // 0x0000000189B5D210-0x0000000189B5D230
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182BD5520-0x0000000182BD5660
	// [XID] // 0x0000000189B64970-0x0000000189B64990
	public override void Clear() {} // 0x0000000182BD5660-0x0000000182BD5710
	// [XID] // 0x0000000189B6BDE0-0x0000000189B6BE00
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182BD5710-0x0000000182BD57F0
	// [XID] // 0x0000000189B73690-0x0000000189B736B0
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182BD5BF0-0x0000000182BD5CF0
	// [XID] // 0x0000000189B7AB30-0x0000000189B7AB50
	private bool OnHittingScene(EvtHittingScene evt) => default; // 0x0000000182BD5990-0x0000000182BD5BF0
	[BlackList] // 0x0000000189B82390-0x0000000189B823D0
	// [XID] // 0x0000000189B82390-0x0000000189B823D0
	public override void AutoAllocTypeFields() {} // 0x0000000182BD5370-0x0000000182BD5410
	[BlackList] // 0x0000000189B8C510-0x0000000189B8C550
	// [XID] // 0x0000000189B8C510-0x0000000189B8C550
	public override void AutoRecycleTypeFields() {} // 0x0000000182BD5410-0x0000000182BD54C0
	[BlackList] // 0x0000000189B96BA0-0x0000000189B96BE0
	// [XID] // 0x0000000189B96BA0-0x0000000189B96BE0
	public override void ReturnToObjectPool() {} // 0x0000000182BD5CF0-0x0000000182BD5D90
}

