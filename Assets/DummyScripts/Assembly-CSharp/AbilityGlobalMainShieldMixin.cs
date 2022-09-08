/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityGlobalMainShieldMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14541
{
	// Fields
	private GlobalMainShieldMixin _config; // 0x70
	private SimpleSafeFloat[] _elementDamageRatios; // 0x78
	private SimpleSafeFloat[] _elementDamageSufferRatios; // 0x80
	private float _maxShield; // 0x88
	private float _shield; // 0x8C
	private bool _alreadyRemoved; // 0x90
	private Vector3 _heightoffset; // 0x94
	private BaseEntity _currentAvatar; // 0xA0
	private ActorAbilityPlugin _currentAvatarAbility; // 0xA8
	private int _shieldEffectIndex; // 0xB0
	private string _shieldEffectName; // 0xB8

	// Properties
	public float shield { /* [XID] */ /* 0x00000001897735C0-0x00000001897735E0 */ get => default; } // 0x00000001830169F0-0x0000000183016AA0 

	// Constructors
	public AbilityGlobalMainShieldMixin() {} // 0x0000000183017720-0x00000001830177D0

	// Methods
	// [XID] // 0x000000018977ADB0-0x000000018977ADD0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183015420-0x00000001830156A0
	// [XID] // 0x00000001897829A0-0x00000001897829C0
	public override void Clear() {} // 0x0000000183015790-0x0000000183015840
	// [XID] // 0x0000000189789BD0-0x0000000189789BF0
	protected override void AddEventListener() {} // 0x00000001830149B0-0x0000000183014BA0
	// [XID] // 0x00000001897913F0-0x0000000189791410
	protected override void RemoveEventListener() {} // 0x00000001830167A0-0x0000000183016990
	// [XID] // 0x0000000189798B50-0x0000000189798B70
	public override void OnAdded(bool syncToServer) {} // 0x0000000183013FC0-0x0000000183014400
	// [XID] // 0x00000001897A0990-0x00000001897A09B0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183015290-0x0000000183015420
	// [XID] // 0x00000001897A7FC0-0x00000001897A7FE0
	public override void Tick(float inDeltaTime) {} // 0x0000000183017670-0x0000000183017720
	// [XID] // 0x00000001897AFAA0-0x00000001897AFAC0
	public override void OnPoolAllocated() {} // 0x00000001830174A0-0x0000000183017550
	// [XID] // 0x00000001897B7870-0x00000001897B7890
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000183015840-0x0000000183015910
	// [XID] // 0x00000001897BF780-0x00000001897BF7A0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000183016BF0-0x0000000183016DC0
	// [XID] // 0x00000001897C6ED0-0x00000001897C6EF0
	public bool OnBeingHit(EvtBeingHit evt, LCAbility avatarAbility) => default; // 0x0000000183015C80-0x00000001830161E0
	// [XID] // 0x00000001897CE4E0-0x00000001897CE500
	public string GetShieldType() => default; // 0x00000001830148D0-0x00000001830149B0
	// [XID] // 0x00000001897D5B90-0x00000001897D5BB0
	public float GetShieldDamage(BaseEntity entity, AttackResult attackResult) => default; // 0x0000000183017140-0x0000000183017420
	// [XID] // 0x00000001897DD310-0x00000001897DD330
	private bool OnAvatarChanged(EvtAvatarChanged evt) => default; // 0x0000000183014D50-0x0000000183014F20
	// [XID] // 0x00000001897E4B40-0x00000001897E4B60
	private bool OnAvatarRevive(EvtRevive evt) => default; // 0x0000000183016500-0x00000001830166D0
	// [XID] // 0x00000001897EC810-0x00000001897EC830
	private bool OnAvatarAppear(EvtAvatarAppear evt) => default; // 0x0000000183016E20-0x0000000183017000
	// [XID] // 0x00000001897F40E0-0x00000001897F4100
	private void ApplyToAvatar(BaseEntity avatar, bool syncToServer) {} // 0x00000001830161E0-0x0000000183016500
	// [XID] // 0x00000001897FBB40-0x00000001897FBB60
	private void UnapplyToAvatar(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB7E7 */) {} // 0x0000000183014490-0x0000000183014620
	// [XID] // 0x0000000189803010-0x0000000189803030
	private void CreateShieldEffect() {} // 0x0000000183015970-0x0000000183015C20
	// [XID] // 0x000000018980A4A0-0x000000018980A4C0
	private void TryCreateShieldEffect() {} // 0x00000001830166D0-0x00000001830167A0
	// [XID] // 0x0000000189811BC0-0x0000000189811BE0
	private void TryDestroyShieldEffect() {} // 0x0000000183014620-0x0000000183014730
	// [XID] // 0x00000001898198B0-0x00000001898198D0
	public override void HandleMixinInvokeEntry(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000183014F20-0x0000000183015210
	// [XID] // 0x0000000189820FB0-0x0000000189820FD0
	private void SyncToServer(float costShield) {} // 0x0000000183016AA0-0x0000000183016BF0
	// [XID] // 0x0000000189828560-0x0000000189828580
	public override void HandleRecoverData(RepeatedField<uint> data) {} // 0x0000000183014BA0-0x0000000183014CF0
	[BlackList] // 0x000000018982F7F0-0x000000018982F830
	// [XID] // 0x000000018982F7F0-0x000000018982F830
	public override void AutoAllocTypeFields() {} // 0x0000000183014730-0x00000001830147D0
	[BlackList] // 0x0000000189839DF0-0x0000000189839E30
	// [XID] // 0x0000000189839DF0-0x0000000189839E30
	public override void AutoRecycleTypeFields() {} // 0x00000001830147D0-0x00000001830148D0
	[BlackList] // 0x0000000189844650-0x0000000189844690
	// [XID] // 0x0000000189844650-0x0000000189844690
	public override void ReturnToObjectPool() {} // 0x00000001830175D0-0x0000000183017670
}

