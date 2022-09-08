/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCAvatarCombat : LCCharacterCombat // TypeDefIndex: 11699
{
	// Fields
	private EntityTimer _targetAtteTimer; // 0x1B8
	private EntityTimer _targetFixTimer; // 0x1C0
	private AvatarSkillDepotExcelConfig _skillDepotConfig; // 0x1C8
	public bool toDoChargeSkill; // 0x1D0
	public const float COOLED_DOWN_TIME = -253f; // Metadata: 0x00AEA6F4
	private const int CHARGE_SKILL_INDEX = 4; // Metadata: 0x00AEA6F8
	private const int TALENT_SKILL_INDEX = 5; // Metadata: 0x00AEA6FC
	private SkillInfo[] _currSkills; // 0x1D8
	private Dictionary<uint, SafeFloat> _equipAffixCD; // 0x1E0
	private int _attackModeTriggerID; // 0x1E8
	private Dictionary<uint, SkillInfo> _skillInfoMap; // 0x1F0
	private List<Tuple<uint, float>> _affixToAdd; // 0x1F8
	private BaseShape2d _curLockTargetShape; // 0x200
	private SimpleSafeFloat[] _curLockTargetWeightParams; // 0x208
	private OverrideTargetingParams _lockTargetOverrideParams; // 0x210
	private const float ECCENTRICITY = 0.9f; // Metadata: 0x00AEA700
	private const float MAX_ECCENT_LENGTH = 10f; // Metadata: 0x00AEA704
	private const float ECCENTRICITY2 = 0.98f; // Metadata: 0x00AEA708
	private const float MAX_ECCENT_LENGTH2 = 5f; // Metadata: 0x00AEA70C
	private readonly List<HitBucketItem> meleeBuckets; // 0x218
	private readonly List<HitBucketItem> rangedBuckets; // 0x220
	private Dictionary<uint, List<uint>> _curSkillCDSlot; // 0x228

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896874A0-0x00000001896874C0 */ get => default; } // 0x0000000182F783C0-0x0000000182F78460 
	public AvatarSkillDepotExcelConfig skillDepotConfig { /* [XID] */ /* 0x0000000189A0F160-0x0000000189A0F180 */ get => default; } // 0x0000000182F72E40-0x0000000182F72EF0 
	public int attackModeTriggerID { /* [XID] */ /* 0x00000001899E5E00-0x00000001899E5E20 */ get => default; } // 0x0000000182F70080-0x0000000182F70120 
	public Dictionary<uint, SkillInfo> skillInfoMap { /* [XID] */ /* 0x0000000189A7F0E0-0x0000000189A7F100 */ get => default; } // 0x0000000182F741D0-0x0000000182F74280 

	// Nested types
	public class SkillInfo // TypeDefIndex: 11700
	{
		// Fields
		public uint skillID; // 0x10
		public AvatarSkillExcelConfig config; // 0x18
		public SafeFloat cdTimer; // 0x20
		public SafeInt32 currChargeCount; // 0x30
		public SafeFloat costStamina; // 0x40
		public bool canHold; // 0x50
		public bool canTrigger; // 0x51
		public bool useInAir; // 0x52
		public HashSet<int> canUseSkillStateWhiteList; // 0x58
		public MonitorType needMonitor; // 0x60
		public bool isLocked; // 0x64
		public bool ignoreCDMinusRatio; // 0x65
		public bool forceCanDoSkill; // 0x66
		public SafeFloat maxHoldTime; // 0x68
		public SafeFloat curHoldTime; // 0x78
		private SafeFloat _originCDTime; // 0x88
		private SafeFloat _cdDelta; // 0x98
		private SafeFloat _cdRatio; // 0xA8
		private SafeFloat _costElem; // 0xB8
		private SafeFloat _costElemDelta; // 0xC8
		private SafeFloat _costElemRatio; // 0xD8
		private SafeInt32 _maxChargeCount; // 0xE8
		private SafeInt32 _maxChargeCountDelta; // 0xF8
		public int skillIndex; // 0x108
		public int prority; // 0x10C
		private List<SafeFloat> _chargeTimes; // 0x110

		// Properties
		public float costElem { get; /* [XID] */ /* 0x00000001896BDE80-0x00000001896BDEC0 */ private set; } // 0x0000000182F6A7E0-0x0000000182F6A850 0x0000000182F6A850-0x0000000182F6A8C0
		public int maxChargeCount { /* [XID] */ /* 0x00000001896E1A20-0x00000001896E1A60 */ get; /* [XID] */ /* 0x00000001896D7280-0x00000001896D72C0 */ private set; } // 0x0000000182F69250-0x0000000182F692B0 0x0000000182F69740-0x0000000182F697B0
		public float CDRatio { /* [XID] */ /* 0x0000000189A719F0-0x0000000189A71A10 */ get => default; } // 0x0000000182F6A160-0x0000000182F6A2C0 

		// Constructors
		public SkillInfo() {} // Dummy constructor
		public SkillInfo(AvatarSkillExcelConfig config) {} // 0x0000000182F6A8C0-0x0000000182F6AE40

		// Methods
		// [XID] // 0x0000000189AA8F70-0x0000000189AA8F90
		public void ChangeCD(float addDelta, float addRatio) {} // 0x0000000182F694D0-0x0000000182F69640
		// [XID] // 0x0000000189AED530-0x0000000189AED550
		public void RefreshCostElem(float addDelta, float addRatio) {} // 0x0000000182F692B0-0x0000000182F694D0
		// [XID] // 0x0000000189B72380-0x0000000189B723A0
		public void RefreshMaxChargeCount(int addDelta) {} // 0x0000000182F69FC0-0x0000000182F6A160
		// [XID] // 0x00000001896FAC50-0x00000001896FAC70
		private void CheckCharge() {} // 0x0000000182F6A380-0x0000000182F6A7E0
		// [XID] // 0x0000000189A885E0-0x0000000189A88600
		public void UseSkill(float cdMultipler) {} // 0x0000000182F68F00-0x0000000182F69250
		// [XID] // 0x00000001897099A0-0x00000001897099C0
		public void RecoveryOneCharge() {} // 0x0000000182F69DA0-0x0000000182F69FC0
		// [XID] // 0x00000001899DE050-0x00000001899DE070
		public void ForceSync(AvatarDataItem.SafeAvatarSkillCDInfo serverData) {} // 0x0000000182F69880-0x0000000182F69DA0
		// [XID] // 0x0000000189718960-0x0000000189718980
		public void ForceSyncMaxChargeCount(uint maxChargeCount) {} // 0x0000000182F68DB0-0x0000000182F68F00
		// [XID] // 0x000000018999ACB0-0x000000018999ACD0
		public bool IsStateForceCanUseSkill(int stateID) => default; // 0x0000000182F697B0-0x0000000182F69880
		// [XID] // 0x0000000189727860-0x0000000189727880
		public void AddCanUseStateWhiteList(int stateID) {} // 0x0000000182F69640-0x0000000182F69740
		// [XID] // 0x000000018972ED70-0x000000018972ED90
		public void RemoveCanUseStateWhiteList(int stateID) {} // 0x0000000182F6A2C0-0x0000000182F6A380
	}

	[Serializable]
	public struct OverrideTargetingParams // TypeDefIndex: 11701
	{
		// Fields
		public float E; // 0x00
		public bool shouldForceSelectAttackTarget; // 0x04
	}

	public class HitBucketItem // TypeDefIndex: 11702
	{
		// Fields
		public float cooldown; // 0x10
		public float availableTick; // 0x14
		public uint userID; // 0x18

		// Constructors
		public HitBucketItem() {} // Dummy constructor
		public HitBucketItem(float cd) {} // 0x0000000182F68CB0-0x0000000182F68D30
	}

	// Constructors
	public LCAvatarCombat() {} // 0x0000000182F78230-0x0000000182F783C0

	// Methods
	// [XID] // 0x0000000189A16780-0x0000000189A167A0
	public override void PreInit() {} // 0x0000000182F77DD0-0x0000000182F780A0
	// [XID] // 0x0000000189A4C120-0x0000000189A4C140
	public override void OnEntityReady() {} // 0x0000000182F76620-0x0000000182F76850
	// [XID] // 0x0000000189A252F0-0x0000000189A25310
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000182F71050-0x0000000182F71150
	// [XID] // 0x0000000189A71A10-0x0000000189A71A30
	protected override bool ListenEvent(BaseEvent e) => default; // 0x0000000182F73B00-0x0000000182F73C90
	// [XID] // 0x0000000189A80CA0-0x0000000189A80CC0
	public override void Destroy() {} // 0x0000000182F6FDF0-0x0000000182F6FF90
	// [XID] // 0x0000000189A3B6D0-0x0000000189A3B6F0
	protected override void Tick(float inDeltaTime) {} // 0x0000000182F780A0-0x0000000182F78230
	// [XID] // 0x0000000189B4B2C0-0x0000000189B4B2E0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182F71150-0x0000000182F71230
	// [XID] // 0x0000000189A4A710-0x0000000189A4A730
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000182F76850-0x0000000182F76960
	// [XID] // 0x00000001897E37B0-0x00000001897E37D0
	private void RefreshEnergyProperty() {} // 0x0000000182F750E0-0x0000000182F75240
	// [XID] // 0x0000000189A59810-0x0000000189A59830
	protected override void RefreshCombatProperty() {} // 0x0000000182F76CC0-0x0000000182F77370
	// [XID] // 0x00000001898AD020-0x00000001898AD040
	public void ChangeSkillDepotId(uint skillDepotId, bool reloadTalents) {} // 0x0000000182F73460-0x0000000182F73690
	// [XID] // 0x0000000189720200-0x0000000189720220
	public void InitSkills(AvatarSkillDepotExcelConfig newConfig) {} // 0x0000000182F75530-0x0000000182F75AC0
	// [XID] // 0x0000000189A7F060-0x0000000189A7F080
	private uint GetSkillDepotId() => default; // 0x0000000182F743A0-0x0000000182F74690
	// [IDTag] // 0x0000000189A869E0-0x0000000189A86A20
	// [XID] // 0x0000000189A869E0-0x0000000189A86A20
	public void SetSkillIndex(SkillInfo skillInfo, int index, int priority) {} // 0x0000000182F70E40-0x0000000182F70F20
	// [IDTag] // 0x0000000189A91440-0x0000000189A91480
	// [XID] // 0x0000000189A91440-0x0000000189A91480
	public void SetSkillIndex(uint skillID, int index, int priority) {} // 0x0000000182F70F20-0x0000000182F71050
	// [XID] // 0x0000000189763530-0x0000000189763550
	public void RefreshCurSkill(int index) {} // 0x0000000182F6E980-0x0000000182F6ECF0
	// [XID] // 0x0000000189AA3020-0x0000000189AA3040
	public void UnlockSkill(uint skillID) {} // 0x0000000182F71840-0x0000000182F71A10
	// [XID] // 0x00000001898DB6F0-0x00000001898DB710
	public uint GetChargeSkillID() => default; // 0x0000000182F73A00-0x0000000182F73B00
	// [XID] // 0x00000001898E3320-0x00000001898E3340
	public SkillInfo GetChargeSkill() => default; // 0x0000000182F70A20-0x0000000182F70AF0
	// [XID] // 0x00000001898EAFA0-0x00000001898EAFC0
	public uint GetTalentSkillID() => default; // 0x0000000182F6E430-0x0000000182F6E530
	// [XID] // 0x0000000189AC1390-0x0000000189AC13B0
	public SkillInfo GetTalentSkill() => default; // 0x0000000182F731F0-0x0000000182F732C0
	// [XID] // 0x0000000189AC8CA0-0x0000000189AC8CC0
	public bool CanDoChargeSkill() => default; // 0x0000000182F6FA00-0x0000000182F6FAC0
	// [XID] // 0x0000000189AD0440-0x0000000189AD0460
	public void DoChargeSkill() {} // 0x0000000182F71CC0-0x0000000182F71D80
	// [XID] // 0x0000000189AD8110-0x0000000189AD8130
	public bool CanDoTalentSkill() => default; // 0x0000000182F721F0-0x0000000182F722B0
	// [XID] // 0x000000018992FEF0-0x000000018992FF10
	public void DoTalentSkill() {} // 0x0000000182F70AF0-0x0000000182F70BB0
	// [XID] // 0x0000000189937490-0x00000001899374B0
	public override void DoSkillSuccess(uint skillID) {} // 0x0000000182F70840-0x0000000182F70A20
	// [XID] // 0x0000000189AEF1F0-0x0000000189AEF210
	public override bool CanDoSkill(uint skillID) => default; // 0x0000000182F6FAC0-0x0000000182F6FC60
	// [XID] // 0x0000000189AF65A0-0x0000000189AF65C0
	public bool CanUseSkill(uint skillID) => default; // 0x0000000182F77700-0x0000000182F77B10
	// [XID] // 0x0000000189AFDBF0-0x0000000189AFDC10
	public bool EnergySkillAvailable() => default; // 0x0000000182F77CA0-0x0000000182F77DD0
	// [XID] // 0x0000000189973650-0x0000000189973670
	public bool IsEnergyMax() => default; // 0x0000000182F75AC0-0x0000000182F75C60
	// [XID] // 0x0000000189B0CA00-0x0000000189B0CA20
	public float GetEnergyRatio() => default; // 0x0000000182F73690-0x0000000182F73830
	// [XID] // 0x0000000189B13FC0-0x0000000189B13FE0
	public bool IsSkillInCD(uint skillID) => default; // 0x0000000182F6FC60-0x0000000182F6FDF0
	// [XID] // 0x00000001899B8BB0-0x00000001899B8BD0
	public bool IsSkillInRecovering(uint skillID) => default; // 0x0000000182F732C0-0x0000000182F73460
	// [XID] // 0x0000000189B22DF0-0x0000000189B22E10
	public void UpdateSkillCD(uint skillID, uint cd) {} // 0x0000000182F722B0-0x0000000182F72420
	// [XID] // 0x0000000189B2A480-0x0000000189B2A4A0
	private void InitEqupAffixCds() {} // 0x0000000182F76960-0x0000000182F76CC0
	// [XID] // 0x000000018992FF10-0x000000018992FF30
	public void UpdateEquipAffixCD(uint affixID, uint cd) {} // 0x0000000182F6ECF0-0x0000000182F6EE20
	// [XID] // 0x0000000189B34870-0x0000000189B34890
	private void TickEquipAffixCD(float deltaTime) {} // 0x0000000182F74A40-0x0000000182F74F30
	// [XID] // 0x0000000189B409D0-0x0000000189B409F0
	public bool IsInEquipAffixCD(uint affixID) => default; // 0x0000000182F6F1C0-0x0000000182F6F300
	// [XID] // 0x00000001899D6A70-0x00000001899D6A90
	public void SyncSkillState(uint skillID, AvatarDataItem.SafeAvatarSkillCDInfo skillState) {} // 0x0000000182F71230-0x0000000182F713A0
	// [XID] // 0x0000000189AEA680-0x0000000189AEA6A0
	private bool CanTickCD(SkillInfo info) => default; // 0x0000000182F76450-0x0000000182F76550
	// [XID] // 0x0000000189B571E0-0x0000000189B57200
	private void TickSkillCD(float deltaTime) {} // 0x0000000182F6E6A0-0x0000000182F6E980
	// [XID] // 0x0000000189B5EC00-0x0000000189B5EC20
	private void CheckCDTimer(uint depotID, SkillInfo info) {} // 0x0000000182F74F90-0x0000000182F750E0
	// [XID] // 0x0000000189B66240-0x0000000189B66260
	private bool OnSkillStart(uint skillID, float cdMultipler) => default; // 0x0000000182F75D10-0x0000000182F75F70
	// [XID] // 0x0000000189B6D7F0-0x0000000189B6D810
	public SkillInfo GetSkillInfoByIndex(uint index) => default; // 0x0000000182F6F300-0x0000000182F6F3F0
	// [XID] // 0x0000000189B74E10-0x0000000189B74E30
	public int GetSkillInfoCount() => default; // 0x0000000182F75C60-0x0000000182F75D10
	// [XID] // 0x0000000189A62840-0x0000000189A62860
	public SkillInfo GetDefaultSkillInfoByIndex(uint index) => default; // 0x0000000182F72EF0-0x0000000182F73060
	// [XID] // 0x00000001899643B0-0x00000001899643D0
	public SkillInfo GetSkillInfoByID(uint skillID) => default; // 0x0000000182F71D80-0x0000000182F72140
	// [XID] // 0x0000000189A6A600-0x0000000189A6A620
	public float GetSkillCDRatio(uint skillID) => default; // 0x0000000182F72550-0x0000000182F72670
	// [XID] // 0x000000018998B780-0x000000018998B7A0
	public int GetSkillMaxChargesCount(uint skillID) => default; // 0x0000000182F76300-0x0000000182F76450
	// [XID] // 0x0000000189A794F0-0x0000000189A79510
	public int GetSkillCurrentChargesCount(uint skillID) => default; // 0x0000000182F74000-0x0000000182F74150
	// [XID] // 0x0000000189BA1240-0x0000000189BA1260
	public void ChangeSkillCD(uint skillID, float delta, float ratio) {} // 0x0000000182F775D0-0x0000000182F77700
	// [XID] // 0x0000000189AB0B80-0x0000000189AB0BA0
	public void ChangeSkillCost(uint skillID, float delta, float ratio) {} // 0x0000000182F75240-0x0000000182F75370
	// [XID] // 0x0000000189BAFB80-0x0000000189BAFBA0
	public void ChangeSkillMaxChargesCount(uint skillID, int delta) {} // 0x0000000182F75370-0x0000000182F75530
	// [XID] // 0x0000000189B798C0-0x0000000189B798E0
	public void ChangeCurrentSkillCDTimer(uint skillID, float delta, float _cdRatio = 0f /* Metadata: 0x00AEA6F0 */) {} // 0x0000000182F71400-0x0000000182F71760
	// [IDTag] // 0x0000000189BBE8D0-0x0000000189BBE910
	// [XID] // 0x0000000189BBE8D0-0x0000000189BBE910
	public void ChangeEnergy(float value) {} // 0x0000000182F71A10-0x0000000182F71B00
	// [IDTag] // 0x0000000189BC9890-0x0000000189BC98D0
	// [XID] // 0x0000000189BC9890-0x0000000189BC98D0
	protected override void ChangeEnergy(ElementType type, float value, DataPropOp state) {} // 0x0000000182F71B00-0x0000000182F71CC0
	// [XID] // 0x0000000189BD4170-0x0000000189BD4190
	private void SetLockTargetConfig(string shapeName, SimpleSafeFloat[] lockWeightSkillParams = null) {} // 0x0000000182F75F70-0x0000000182F76100
	// [XID] // 0x0000000189BDBA90-0x0000000189BDBAB0
	public void OnAnimatorEventOverrideTargetingParams(OverrideTargetingParams parms) {} // 0x0000000182F76550-0x0000000182F76620
	// [XID] // 0x00000001895E8350-0x00000001895E8370
	public void ClearTarget(bool force) {} // 0x0000000182F73EB0-0x0000000182F74000
	// [XID] // 0x00000001895EFC40-0x00000001895EFC60
	public override void SelectAttackTarget(bool force) {} // 0x0000000182F72670-0x0000000182F72E40
	// [XID] // 0x00000001895F7630-0x00000001895F7650
	private Vector3 CalculateSelectTargetForward() => default; // 0x0000000182F6F4D0-0x0000000182F6F690
	// [XID] // 0x000000018992E990-0x000000018992E9B0
	private Vector3 CalculatePushForwardDirectionXZ() => default; // 0x0000000182F74690-0x0000000182F74A40
	// [XID] // 0x0000000189606310-0x0000000189606330
	private float GetScoreByEllipse(Vector3 from, Vector3 to, Vector3 mainDirection) => default; // 0x0000000182F77370-0x0000000182F775D0
	// [XID] // 0x000000018960DB70-0x000000018960DB90
	private float GetScoreByEllipsoid(BaseEntity from, BaseEntity to, Vector3 mainDirection, Vector3 mainUp, Vector3 mainRight) => default; // 0x0000000182F703B0-0x0000000182F707C0
	// [XID] // 0x00000001897457D0-0x00000001897457F0
	public SkillInfo AddSkillInfoByID(uint skillID, bool initSkill) => default; // 0x0000000182F77B10-0x0000000182F77CA0
	// [XID] // 0x0000000189B76700-0x0000000189B76720
	public bool RemoveSkillInfo(uint skillID) => default; // 0x0000000182F6F060-0x0000000182F6F1C0
	// [XID] // 0x0000000189623FE0-0x0000000189624000
	private void OnSkillAdd(uint skillId, SkillInfo info) {} // 0x0000000182F71760-0x0000000182F71840
	// [XID] // 0x000000018962B750-0x000000018962B770
	private void OnSkillRemoved(uint skillId, SkillInfo info) {} // 0x0000000182F6E5B0-0x0000000182F6E6A0
	// [IDTag] // 0x0000000189632F70-0x0000000189632FB0
	// [XID] // 0x0000000189632F70-0x0000000189632FB0
	private void OnAbilityStateChanged(AbilityState state, bool muteDisplayEffect) {} // 0x0000000182F6F730-0x0000000182F6F800
	// [IDTag] // 0x000000018963DAB0-0x000000018963DAF0
	// [XID] // 0x000000018963DAB0-0x000000018963DAF0
	private void OnAbilityStateChanged(AbilityState state) {} // 0x0000000182F6F800-0x0000000182F6FA00
	// [XID] // 0x0000000189648080-0x00000001896480A0
	public void SyncSkillMaxChargeCount(uint skillID, uint maxChargeCount) {} // 0x0000000182F701A0-0x0000000182F703B0
	// [XID] // 0x00000001898BEE20-0x00000001898BEE40
	private void InitHitBuckets() {} // 0x0000000182F6EE20-0x0000000182F6EF10
	// [XID] // 0x0000000189657120-0x0000000189657140
	public void ResetHitBuckets() {} // 0x0000000182F6FF90-0x0000000182F70080
	// [XID] // 0x00000001898FB420-0x00000001898FB440
	public void LoadHitBucketSetting(ConfigAvatarHitBucketSetting setting) {} // 0x0000000182F70BB0-0x0000000182F70E40
	// [XID] // 0x00000001898B18D0-0x00000001898B18F0
	public bool HasAvailableHitBucket(float currentTick, ConfigAICombatSkillType skillType) => default; // 0x0000000182F73830-0x0000000182F73A00
	// [XID] // 0x0000000189A40280-0x0000000189A402A0
	public bool AcquireHitBucket(ConfigAICombatSkillType skillType, uint attackerID) => default; // 0x0000000182F6EF10-0x0000000182F6F060
	// [XID] // 0x0000000189675570-0x0000000189675590
	public List<HitBucketItem> GetMeleeBuckets() => default; // 0x0000000182F74280-0x0000000182F74330
	// [XID] // 0x000000018967CC80-0x000000018967CCA0
	public List<HitBucketItem> GetRangedBuckets() => default; // 0x0000000182F72140-0x0000000182F721F0
	// [XID] // 0x00000001897279A0-0x00000001897279C0
	private void ClearSkillCDSlot() {} // 0x0000000182F76100-0x0000000182F76300
	// [XID] // 0x000000018968BED0-0x000000018968BEF0
	private void AddSkillCDSlot(AvatarSkillExcelConfig config) {} // 0x0000000182F73C90-0x0000000182F73E30
	// [XID] // 0x0000000189693A70-0x0000000189693A90
	private void RemoveSkillCDSlot(AvatarSkillExcelConfig config) {} // 0x0000000182F73060-0x0000000182F731F0
	// [XID] // 0x000000018969AE50-0x000000018969AE70
	public List<uint> GetSkillIdListByCDSlot(uint slot) => default; // 0x0000000182F6F3F0-0x0000000182F6F4D0
}

