/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UniRx;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCAbilityState : LCBase // TypeDefIndex: 11679
{
	// Fields
	private int _freezeMassRatioIx; // 0x130
	private int _freezeSpeedRatioIx; // 0x134
	private int _petrifactionMassRatioIx; // 0x138
	private int _petrifactionSpeedRatioIx; // 0x13C
	private int _paralyzeSpeedRatioIx; // 0x140
	public Action<AbilityState, bool> onAbilityStateAdd; // 0x148
	public Action<AbilityState> onAbilityStateRemove; // 0x150
	public Action<AbilityState> onAbilityStateImmune; // 0x158
	private int _abilityStateChangedFrameCount; // 0x160
	private List<Tuple<bool, AbilityState, uint>> _abilityStateChanged; // 0x168
	public Action<List<Tuple<bool, AbilityState, uint>>> onAbilityStateChangedPost; // 0x170
	private LCAbility _selfLCAbility; // 0x178
	public AbilityState abilityState; // 0x180
	private List<AbilityStateEntry> _abilityStatePushCount; // 0x188
	private List<AbilityStateEntry> _abilityStateImmuneCount; // 0x190
	private int _immuneCount; // 0x198
	private const float PARALYZE_ANI_DEFENCE_DEFENCE_DOWN = -0.2f; // Metadata: 0x00AEA6B3
	private static Dictionary<int, string> ABILITY_EFFECT_MAP; // 0x00
	private List<Tuple<AbilityState, int>?> _abilityStateEffectIxLs; // 0x1A0
	private int _maxSpeedPropertyIx; // 0x1A8
	private int _paralyzeAniDefenceStackIx; // 0x1AC
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private Dictionary<EncryptedString, FixedSafeFloatStack> _properties; // 0x1B0
	private Dictionary<EncryptedString, Action> _propertyChangedCallbacks; // 0x1B8
	private Dictionary<EncryptedString, ConfigAbilityPropertyEntry> _createdAbilityDefinedProperties; // 0x1C0
	private LCAbility _levelAbilityCom; // 0x1C8
	private bool _canShakeOff; // 0x1D0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018998CC20-0x000000018998CC40 */ get => default; } // 0x0000000181A2EF60-0x0000000181A2F000 

	// Nested types
	private class AbilityStateEntry // TypeDefIndex: 11680
	{
		// Fields
		public AbilityState state; // 0x10
		public int count; // 0x18

		// Constructors
		public AbilityStateEntry() {} // 0x0000000181A19AC0-0x0000000181A19B20
	}

	// Constructors
	public LCAbilityState() {} // 0x0000000181A2EED0-0x0000000181A2EF60
	static LCAbilityState() {} // 0x0000000181A2EDB0-0x0000000181A2EED0

	// Methods
	// [XID] // 0x0000000189BC0580-0x0000000189BC05A0
	public override void PreInit() {} // 0x0000000181A2E770-0x0000000181A2EB20
	// [XID] // 0x0000000189B6C030-0x0000000189B6C050
	public override bool IsValid() => default; // 0x0000000181A2BA90-0x0000000181A2BB70
	// [XID] // 0x00000001899A3A60-0x00000001899A3A80
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181A2EB20-0x0000000181A2EDB0
	// [XID] // 0x0000000189B1D180-0x0000000189B1D1A0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181A284E0-0x0000000181A288D0
	// [XID] // 0x00000001899EE840-0x00000001899EE860
	public void ClearProperties() {} // 0x0000000181A2DCF0-0x0000000181A2DDB0
	// [XID] // 0x00000001899BA170-0x00000001899BA190
	public override void Destroy() {} // 0x0000000181A28930-0x0000000181A28D90
	// [XID] // 0x00000001898312B0-0x00000001898312D0
	private AbilityStateEntry GetStateEntry(List<AbilityStateEntry> ls, AbilityState state, bool createIfNotFound = false /* Metadata: 0x00AEA6AE */) => default; // 0x0000000181A27630-0x0000000181A277C0
	// [XID] // 0x000000018971D370-0x000000018971D390
	public bool AddAbilityState(ActorAbility instancedAbility, AbilityState state, bool muteDisplayEffect) => default; // 0x0000000181A2C730-0x0000000181A2C9B0
	// [XID] // 0x00000001899D0C60-0x00000001899D0C80
	public bool AddAbilityStateTest(AbilityState state, bool muteDisplayEffect) => default; // 0x0000000181A2A920-0x0000000181A2AB40
	// [XID] // 0x00000001899D7FF0-0x00000001899D8010
	public static bool CheckCasterAndTargetLevelDifference(ActorAbility instancedAbility, AbilityState state, BaseEntity target) => default; // 0x0000000181A2AC40-0x0000000181A2AF20
	// [XID] // 0x00000001899DF600-0x00000001899DF620
	public void RemoveAbilityState(AbilityState state) {} // 0x0000000181A29D80-0x0000000181A2A0E0
	// [XID] // 0x0000000189790050-0x0000000189790070
	public void SetAbilityStateImmune(AbilityState state, bool immune) {} // 0x0000000181A2DB60-0x0000000181A2DC80
	// [XID] // 0x00000001899EE5B0-0x00000001899EE5D0
	public void HandleAbilityStateChangedPost() {} // 0x0000000181A27020-0x0000000181A27170
	// [XID] // 0x00000001899F5EA0-0x00000001899F5EC0
	private void ClearStateEffects() {} // 0x0000000181A28110-0x0000000181A28430
	// [XID] // 0x00000001899FD510-0x00000001899FD530
	public void AbilityApplyAbilityStateEffect_Verbatim(AbilityState state, bool muteDisplayEffect) {} // 0x0000000181A2D090-0x0000000181A2D950
	// [XID] // 0x0000000189A04C60-0x0000000189A04C80
	public override void OnEnable() {} // 0x0000000181A2E2C0-0x0000000181A2E5D0
	// [XID] // 0x00000001898D1060-0x00000001898D1080
	public override void OnDisable() {} // 0x0000000181A2E080-0x0000000181A2E2C0
	// [XID] // 0x0000000189A13C50-0x0000000189A13C70
	public void AbilityApplyAbilityStateEffect_Authority(AbilityState state) {} // 0x0000000181A2E5D0-0x0000000181A2E690
	// [XID] // 0x00000001897EE250-0x00000001897EE270
	public void AbilityRemoveAbilityStateEffect_Verbatim(AbilityState state) {} // 0x0000000181A29440-0x0000000181A29D80
	// [XID] // 0x00000001897C1050-0x00000001897C1070
	private void OnStateCanNotMove(AbilityState abilityState, bool isApply) {} // 0x0000000181A27170-0x0000000181A27470
	// [XID] // 0x0000000189A29A40-0x0000000189A29A60
	public void AbilityRemoveAbilityStateEffect_Authority(AbilityState state) {} // 0x0000000181A27BE0-0x0000000181A27C90
	// [XID] // 0x0000000189A30F00-0x0000000189A30F20
	public void AbilityRemoveModifierOnImmune(AbilityState state) {} // 0x0000000181A2B210-0x0000000181A2B2E0
	// [XID] // 0x0000000189A38B90-0x0000000189A38BB0
	public void SetImmuneDebuff(bool immune) {} // 0x0000000181A2AB40-0x0000000181A2AC40
	// [XID] // 0x0000000189835C90-0x0000000189835CB0
	public bool IsImmuneAbilityState(AbilityState state) => default; // 0x0000000181A27550-0x0000000181A27630
	// [XID] // 0x0000000189A477E0-0x0000000189A47800
	public void OnAbilityStateAdd(AbilityState state, bool muteDisplayEffect) {} // 0x0000000181A2CA80-0x0000000181A2CC20
	// [XID] // 0x0000000189A4EFD0-0x0000000189A4EFF0
	public void OnAbilityStateRemove(AbilityState state) {} // 0x0000000181A2B910-0x0000000181A2BA90
	// [XID] // 0x00000001897D78F0-0x00000001897D7910
	private void RemoveAllDebuffModifiers() {} // 0x0000000181A2C9B0-0x0000000181A2CA80
	// [XID] // 0x0000000189804890-0x00000001898048B0
	private void RemoveModifierByState(AbilityState controlState) {} // 0x0000000181A2E690-0x0000000181A2E770
	// [XID] // 0x0000000189A65A00-0x0000000189A65A20
	public Dictionary<EncryptedString, FixedSafeFloatStack> GetProperties() => default; // 0x0000000181A28430-0x0000000181A284E0
	// [XID] // 0x0000000189A6D110-0x0000000189A6D130
	public void AddRawPropertyChangedCallback(string propertyKey, Action<SafeFloat, int, SafeFloat, int> callback) {} // 0x0000000181A2BB70-0x0000000181A2BD90
	// [XID] // 0x0000000189A747E0-0x0000000189A74800
	public void RemoveRawPropertyChangedCallback(string propertyKey, Action<SafeFloat, int, SafeFloat, int> callback) {} // 0x0000000181A2A660-0x0000000181A2A870
	// [XID] // 0x00000001897A8410-0x00000001897A8430
	public void RegisterPropertyChangedCallback(string propertyKey, Action callback) {} // 0x0000000181A27870-0x0000000181A27BE0
	// [XID] // 0x0000000189A199A0-0x0000000189A199C0
	public void UnregisterPropertyChangedCallback(string propertyKey, Action callback) {} // 0x0000000181A2C430-0x0000000181A2C620
	// [XID] // 0x0000000189A8B670-0x0000000189A8B690
	public void ClearPropertyChangedCallback(string propertyKey) {} // 0x0000000181A28000-0x0000000181A28110
	// [XID] // 0x0000000189A92CA0-0x0000000189A92CC0
	public float GetProperty(EncryptedString propertyKey) => default; // 0x0000000181A2A140-0x0000000181A2A660
	// [XID] // 0x000000018985A9D0-0x000000018985A9F0
	public void TryCreateStackForAbilityDefinedProperty(string propertyKey, ConfigAbilityPropertyEntry entry) {} // 0x0000000181A2D950-0x0000000181A2DB60
	// [XID] // 0x0000000189AA1720-0x0000000189AA1740
	public void TryCreateStackForProperty(string propertyKey) {} // 0x0000000181A2CC20-0x0000000181A2D090
	// [XID] // 0x0000000189AA8E30-0x0000000189AA8E50
	public int PushProperty(string propertyKey, float value, FixedStackTag tag = FixedStackTag.NoTag /* Metadata: 0x00AEA6AF */) => default; // 0x0000000181A27C90-0x0000000181A28000
	// [XID] // 0x0000000189AB0A70-0x0000000189AB0A90
	public void PopProperty(string propertyKey, int stackIx) {} // 0x0000000181A2B350-0x0000000181A2B910
	// [XID] // 0x0000000189AB8060-0x0000000189AB8080
	public float GetPropertyByStackIndex(EncryptedString propertyKey, int stackIx) => default; // 0x0000000181A2BE50-0x0000000181A2C0D0
	// [XID] // 0x0000000189852D30-0x0000000189852D50
	public void SetPropertyByStackIndex(string propertyKey, int stackIx, float value) {} // 0x0000000181A2AF20-0x0000000181A2B210
	// [XID] // 0x000000018980BDB0-0x000000018980BDD0
	private void AbilityTriggerAbilityStateAbility(List<Tuple<bool, AbilityState, uint>> abilityStatesChanged) {} // 0x0000000181A2C0D0-0x0000000181A2C430
	// [XID] // 0x0000000189ACEC90-0x0000000189ACECB0
	public bool IsStateRestricted() => default; // 0x0000000181A2C620-0x0000000181A2C730
	// [XID] // 0x0000000189AD6C10-0x0000000189AD6C30
	public void SetCanShakeOff(bool canShakeOff) {} // 0x0000000181A2DDB0-0x0000000181A2DE60
	// [XID] // 0x0000000189ADE460-0x0000000189ADE480
	public bool IsStateCanShakeOff() => default; // 0x0000000181A2DE60-0x0000000181A2DF60
	// [XID] // 0x0000000189AE5F20-0x0000000189AE5F40
	public bool IsStateFreeze() => default; // 0x0000000181A2A870-0x0000000181A2A920
	// [XID] // 0x0000000189AED330-0x0000000189AED350
	public bool IsStatePetrifaction() => default; // 0x0000000181A277C0-0x0000000181A27870
	// [XID] // 0x0000000189AF4DA0-0x0000000189AF4DC0
	public bool IsStateRock() => default; // 0x0000000181A2DFD0-0x0000000181A2E080
	[Preserve] // 0x0000000189AFC340-0x0000000189AFC380
	// [XID] // 0x0000000189AFC340-0x0000000189AFC380
	public override string Dump() => default; // 0x0000000181A28D90-0x0000000181A29440
}

