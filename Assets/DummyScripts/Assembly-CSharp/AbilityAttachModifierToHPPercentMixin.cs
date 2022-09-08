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

public sealed class AbilityAttachModifierToHPPercentMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14464
{
	// Fields
	private AttachModifierToHPPercentMixin config; // 0x70
	private int _stepCount; // 0x78
	private int _modiferCount; // 0x7C
	private LCBaseCombat _lcCombat; // 0x80

	// Constructors
	public AbilityAttachModifierToHPPercentMixin() {} // 0x00000001835C01C0-0x00000001835C0230

	// Methods
	// [XID] // 0x00000001898DB390-0x00000001898DB3B0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001835BEFF0-0x00000001835BF2C0
	// [XID] // 0x00000001898E3040-0x00000001898E3060
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001835BEE30-0x00000001835BEF30
	// [XID] // 0x00000001898EACF0-0x00000001898EAD10
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001835BECD0-0x00000001835BEDD0
	// [XID] // 0x00000001898F24E0-0x00000001898F2500
	private void ClearRedundantModifiers(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB75F */) {} // 0x00000001835BF490-0x00000001835BF660
	// [XID] // 0x00000001898F9C60-0x00000001898F9C80
	private void CheckNeedAddModifiers() {} // 0x00000001835BF2C0-0x00000001835BF370
	// [XID] // 0x00000001899016A0-0x00000001899016C0
	private string GetCurStepModiferName() => default; // 0x00000001835BE690-0x00000001835BE920
	// [XID] // 0x0000000189908DD0-0x0000000189908DF0
	public override void Clear() {} // 0x00000001835BF3E0-0x00000001835BF490
	// [XID] // 0x00000001899102F0-0x0000000189910310
	protected override void AddEventListener() {} // 0x00000001835BEAE0-0x00000001835BECD0
	// [XID] // 0x0000000189917EA0-0x0000000189917EC0
	protected override void RemoveEventListener() {} // 0x00000001835BF6C0-0x00000001835BF830
	// [XID] // 0x000000018991F4F0-0x000000018991F510
	public override void OnAdded(bool syncToServer) {} // 0x00000001835BE530-0x00000001835BE600
	// [XID] // 0x0000000189927040-0x0000000189927060
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001835BEF30-0x00000001835BEFF0
	// [XID] // 0x000000018992E790-0x000000018992E7B0
	private void OnHPChanged(LCBaseCombat lcCombat) {} // 0x00000001835BF830-0x00000001835BF8E0
	// [XID] // 0x0000000189935A60-0x0000000189935A80
	private void UpdateModifier() {} // 0x00000001835BF940-0x00000001835BFB60
	// [XID] // 0x000000018993D700-0x000000018993D720
	private void TryApplyModifier(string modiferName) {} // 0x00000001835BFBF0-0x00000001835BFD50
	// [XID] // 0x0000000189944BB0-0x0000000189944BD0
	public override string ToString() => default; // 0x00000001835C0020-0x00000001835C01C0
	[BlackList] // 0x000000018994C180-0x000000018994C1C0
	// [XID] // 0x000000018994C180-0x000000018994C1C0
	public override void AutoAllocTypeFields() {} // 0x00000001835BE920-0x00000001835BE9C0
	[BlackList] // 0x00000001899566E0-0x0000000189956720
	// [XID] // 0x00000001899566E0-0x0000000189956720
	public override void AutoRecycleTypeFields() {} // 0x00000001835BE9C0-0x00000001835BEA70
	[BlackList] // 0x0000000189961190-0x00000001899611D0
	// [XID] // 0x0000000189961190-0x00000001899611D0
	public override void ReturnToObjectPool() {} // 0x00000001835BFF80-0x00000001835C0020
}

