/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityElementAdjustMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14523
{
	// Fields
	private ElementAdjustMixin _config; // 0x70
	private ActorModifier _actorModifier; // 0x78
	private float _intervalTimer; // 0x80
	private bool _isTrigged; // 0x84
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<ElementType> _elementKeys; // 0x88
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<float> _elementDamage; // 0x90

	// Constructors
	public AbilityElementAdjustMixin() {} // 0x000000018253D750-0x000000018253D7C0

	// Methods
	// [XID] // 0x00000001896C6E30-0x00000001896C6E50
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018253C510-0x000000018253C920
	// [XID] // 0x00000001896CE4C0-0x00000001896CE4E0
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018253C250-0x000000018253C350
	// [XID] // 0x00000001896D59B0-0x00000001896D59D0
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018253BE30-0x000000018253BF30
	// [XID] // 0x00000001896DCE90-0x00000001896DCEB0
	public override void Clear() {} // 0x000000018253CA90-0x000000018253CB90
	// [XID] // 0x00000001896E4850-0x00000001896E4870
	public override void OnAdded(bool syncToServer) {} // 0x000000018253B8A0-0x000000018253B980
	// [XID] // 0x00000001896EBCF0-0x00000001896EBD10
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018253C350-0x000000018253C420
	// [XID] // 0x00000001896F3370-0x00000001896F3390
	public override void Tick(float inDeltaTime) {} // 0x000000018253D5F0-0x000000018253D750
	// [XID] // 0x00000001896FAAF0-0x00000001896FAB10
	private static new EventID[] GetSelfOnEventRemoteIDsExcludingBase() => default; // 0x000000018253CB90-0x000000018253CC70
	// [XID] // 0x0000000189702140-0x0000000189702160
	public override bool OnEventRemote(BaseEvent evt) => default; // 0x000000018253D2D0-0x000000018253D3D0
	// [XID] // 0x0000000189709860-0x0000000189709880
	private static new EventID[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x000000018253CC70-0x000000018253CD50
	// [XID] // 0x00000001897112D0-0x00000001897112F0
	public override bool OnEventResolved(BaseEvent evt) => default; // 0x000000018253D3D0-0x000000018253D4D0
	// [XID] // 0x0000000189718800-0x0000000189718820
	private bool OnBeingHitResolved(EvtBeingHit evt) => default; // 0x000000018253B980-0x000000018253BB40
	// [XID] // 0x000000018971FF60-0x000000018971FF80
	private void ClearRedundantModifiers() {} // 0x000000018253CD50-0x000000018253CF80
	// [XID] // 0x00000001897276E0-0x0000000189727700
	private void ClearDamages() {} // 0x000000018253CFE0-0x000000018253D0F0
	// [XID] // 0x000000018972EB90-0x000000018972EBB0
	private void RemoveCuurentElementModifier(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB7AE */) {} // 0x000000018253C420-0x000000018253C510
	// [XID] // 0x0000000189736300-0x0000000189736320
	private void ApplyCurrentTopDmgElementModifier() {} // 0x000000018253BF30-0x000000018253C1F0
	[BlackList] // 0x000000018973E1A0-0x000000018973E1E0
	// [XID] // 0x000000018973E1A0-0x000000018973E1E0
	public override void AutoAllocTypeFields() {} // 0x000000018253BBD0-0x000000018253BCC0
	[BlackList] // 0x00000001897486B0-0x00000001897486F0
	// [XID] // 0x00000001897486B0-0x00000001897486F0
	public override void AutoRecycleTypeFields() {} // 0x000000018253BCC0-0x000000018253BDB0
	[BlackList] // 0x0000000189752AB0-0x0000000189752AF0
	// [XID] // 0x0000000189752AB0-0x0000000189752AF0
	public override void ReturnToObjectPool() {} // 0x000000018253D550-0x000000018253D5F0
}

