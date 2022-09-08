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

public sealed class AbilityTDPlayMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14579
{
	// Fields
	public const string SGV_TDCanDoAttack = "SGV_TDCanDoAttack"; // Metadata: 0x00AEB81B
	public const string SGV_TDUpGrade_Special = "SGV_TDUpGrade_Special"; // Metadata: 0x00AEB830
	public const string SGV_TDLevel = "SGV_TDLevel"; // Metadata: 0x00AEB849
	public const string SGV_TDAttackDamage_A = "SGV_TDAttackDamage_A"; // Metadata: 0x00AEB858
	public const string SGV_TDAttackDamage_B = "SGV_TDAttackDamage_B"; // Metadata: 0x00AEB870
	public const string SGV_TDAttackSpeed_A = "SGV_TDAttackSpeed_A"; // Metadata: 0x00AEB888
	public const string SGV_TDAttackSpeed_B = "SGV_TDAttackSpeed_B"; // Metadata: 0x00AEB89F
	public const string SGV_TDAttackSpeed_C = "SGV_TDAttackSpeed_C"; // Metadata: 0x00AEB8B6
	public const string SGV_TDAttackRange_A = "SGV_TDAttackRange_A"; // Metadata: 0x00AEB8CD
	public const string SGV_TDAttackRange_B = "SGV_TDAttackRange_B"; // Metadata: 0x00AEB8E4
	public const string SGV_TDElementMastery = "SGV_TDElementMastery"; // Metadata: 0x00AEB8FB
	private TDPlayTowerType towerType; // 0x70
	private int towerLevel; // 0x74
	private int canAttack; // 0x78
	private int isSpecial; // 0x7C
	private float _baseAttackRange; // 0x80
	private float _attackRangeUP_A; // 0x84
	private float _attackRangeUP_B; // 0x88
	private float _baseAttackCD; // 0x8C
	private float _attackCD_A; // 0x90
	private float _attackCD_B; // 0x94
	private float _attackCD_C; // 0x98
	private float _elemMasteryUP; // 0x9C
	private float _damageUP_A; // 0xA0
	private float _damageUP_B; // 0xA4
	private float _nextAttackTime; // 0xA8
	private TDPlayMixin _config; // 0xB0
	private ConfigTDPlay _configTDPlay; // 0xB8
	private ConfigTDPlayTowerData _configTowerInfo; // 0xC0
	private VCPartController _partControl; // 0xC8
	private List<float> _bullets; // 0xD0
	private List<ActorAbilityPlugin.AbilityAttackTarget> _targets; // 0xD8

	// Properties
	public float attackRange { /* [XID] */ /* 0x000000018981F570-0x000000018981F590 */ get => default; } // 0x0000000182946F40-0x0000000182947090 
	public float attackCD { /* [XID] */ /* 0x0000000189826B30-0x0000000189826B50 */ get => default; } // 0x0000000182949400-0x00000001829495E0 
	public float attackValue { /* [XID] */ /* 0x000000018982E1E0-0x000000018982E200 */ get => default; } // 0x0000000182946660-0x0000000182946740 
	public float attackRatio { /* [XID] */ /* 0x00000001898358D0-0x00000001898358F0 */ get => default; } // 0x00000001829498C0-0x00000001829499F0 
	public float elemMastery { /* [XID] */ /* 0x000000018983CF80-0x000000018983CFA0 */ get => default; } // 0x00000001829491A0-0x00000001829492C0 

	// Constructors
	public AbilityTDPlayMixin() {} // 0x000000018294A050-0x000000018294A100

	// Methods
	// [XID] // 0x0000000189844630-0x0000000189844650
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001829476F0-0x0000000182947A30
	// [XID] // 0x000000018984BBF0-0x000000018984BC10
	public override void Clear() {} // 0x0000000182948540-0x0000000182948600
	// [XID] // 0x0000000189852AB0-0x0000000189852AD0
	private void ReInitValues() {} // 0x00000001829462D0-0x00000001829463A0
	// [XID] // 0x000000018985A680-0x000000018985A6A0
	public override void OnAdded(bool syncToServer) {} // 0x0000000182946090-0x0000000182946170
	// [XID] // 0x0000000189861770-0x0000000189861790
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182947090-0x00000001829471A0
	// [XID] // 0x0000000189869070-0x0000000189869090
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182946550-0x0000000182946660
	// [XID] // 0x0000000189870350-0x0000000189870370
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182947400-0x0000000182947540
	// [XID] // 0x0000000189877A80-0x0000000189877AA0
	private uint GetBulletID() => default; // 0x0000000182947250-0x0000000182947400
	// [XID] // 0x000000018987F2D0-0x000000018987F2F0
	public override void Tick(float inDeltaTime) {} // 0x0000000182949C10-0x000000018294A050
	// [XID] // 0x00000001898868E0-0x0000000189886900
	private void RefreshGlobalValues() {} // 0x0000000182948BF0-0x00000001829491A0
	// [XID] // 0x000000018988DA90-0x000000018988DAB0
	private void RefreshTowerBuff() {} // 0x0000000182946740-0x0000000182946A40
	// [XID] // 0x0000000189895160-0x0000000189895180
	private void RefreshSpecial() {} // 0x0000000182946E70-0x0000000182946F40
	// [XID] // 0x000000018989C810-0x000000018989C830
	private void TowerInfoSynced() {} // 0x0000000182947B90-0x0000000182947C30
	// [XID] // 0x00000001898A40A0-0x00000001898A40C0
	private void ArmLoading(float delay) {} // 0x0000000182946170-0x0000000182946240
	// [XID] // 0x00000001898AB220-0x00000001898AB240
	private int Targeting() => default; // 0x0000000182947D20-0x0000000182948540
	// [XID] // 0x00000001898B2B80-0x00000001898B2BA0
	private bool IsContansTarget(BaseEntity entity) => default; // 0x0000000182947540-0x00000001829476F0
	// [XID] // 0x00000001898BAA40-0x00000001898BAA60
	private void TargetCountChanged(int num) {} // 0x0000000182947A30-0x0000000182947B90
	// [XID] // 0x00000001898C1C10-0x00000001898C1C30
	private void TowerTriggerBullet(ActorAbilityPlugin.AbilityAttackTarget outTarget) {} // 0x0000000182948600-0x0000000182948BF0
	// [XID] // 0x00000001898C95C0-0x00000001898C95E0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001829492C0-0x00000001829493A0
	// [XID] // 0x00000001898D0E80-0x00000001898D0EA0
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001829499F0-0x0000000182949AF0
	// [XID] // 0x00000001898D8420-0x00000001898D8440
	public override void HandleMixinInvokeEntry(UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001829471A0-0x0000000182947250
	// [XID] // 0x00000001898E02C0-0x00000001898E02E0
	private bool OnEvtServerGlobalValueChange(uint keyHash, float value) => default; // 0x0000000182946A40-0x0000000182946E10
	[BlackList] // 0x00000001898E7DE0-0x00000001898E7E20
	// [XID] // 0x00000001898E7DE0-0x00000001898E7E20
	public override void AutoAllocTypeFields() {} // 0x00000001829463A0-0x0000000182946440
	[BlackList] // 0x00000001898F24A0-0x00000001898F24E0
	// [XID] // 0x00000001898F24A0-0x00000001898F24E0
	public override void AutoRecycleTypeFields() {} // 0x0000000182946440-0x0000000182946550
	[BlackList] // 0x00000001898FCB80-0x00000001898FCBC0
	// [XID] // 0x00000001898FCB80-0x00000001898FCBC0
	public override void ReturnToObjectPool() {} // 0x0000000182949B70-0x0000000182949C10
}

