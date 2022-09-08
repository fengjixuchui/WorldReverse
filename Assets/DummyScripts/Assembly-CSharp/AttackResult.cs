/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AttackResult // TypeDefIndex: 20530
{
	// Fields
	public CombatProperty attackerCombatProperty; // 0x10
	public CombatProperty defenseCombatProperty; // 0x18
	public float damage; // 0x20
	public float damageShield; // 0x24
	public bool critical; // 0x28
	public uint criticalRand; // 0x2C
	public bool isResistText; // 0x30
	public bool muteElementHurt; // 0x31
	public string onHitEffectName; // 0x38
	public uint attackTimeStamp; // 0x40
	public TargetType? targetType; // 0x44
	public HitCollsion hitCollision; // 0x50
	public HitBoxType hitPosType; // 0x80
	public string animEventId; // 0x88
	public string attackTag; // 0x90
	public string attenuationTag; // 0x98
	public string attenuationGroup; // 0xA0
	public uint attenuationCount; // 0xA8
	public float elementdurabilityAttenuation; // 0xAC
	public AbilityIdentifier? abilityIdentifier; // 0xB0
	public bool useGadgetDamageAction; // 0xE8
	public uint gadgetDamageActionIdx; // 0xEC
	public bool canHitHead; // 0xF0
	public float elementReductionRate; // 0xF4
	public float elementAmplifyRate; // 0xF8
	public ElementReactionType elementAmplifyType; // 0xFC
	public ElementReactionType elementAddhurtType; // 0x100
	public ElementReactionType elementReactionType; // 0x104
	private ConfigAttackProperty _attackerAttackProperty; // 0x108
	public ModifiedAttackProperty modifiedAttackProperty; // 0x110
	private ElementType _origElementType; // 0x118
	private float _origElementDurability; // 0x11C
	public float endureDelta; // 0x120
	public EndureBreakLevel endureBreak; // 0x124
	public Vector3 resolvedDir; // 0x128
	public ConfigHitPattern attackerHitPattern; // 0x138
	public AttackHitEffectResult hitEffResult; // 0x140
	public bool attackerForceCameraShake; // 0x158
	public ConfigCameraShake attackerCameraShake; // 0x160
	public float bulletFlyTime; // 0x168
	public ConfigBulletWane bulletWane; // 0x170
	public int rejectState; // 0x178
	private static Dictionary<string, ElementReactionType> tagToElementEnumDic; // 0x00
	public static Dictionary<uint, uint> attackeeInvalidCount; // 0x08
	public Vector3 hitRetreatDir; // 0x17C
	private static Dictionary<int, uint> _attackResultRefCount; // 0x10

	// Properties
	public float damagePercentageWaneRatio { [XID] /* 0x00000001899D5CF0-0x00000001899D5D10 */ get; } // 0x0000000184EBFCF0-0x0000000184EBFEA0 
	public ConfigAttackProperty attackerAttackProperty { [XID] /* 0x00000001899DD120-0x00000001899DD140 */ private get; [XID] /* 0x00000001899E4D20-0x00000001899E4D40 */ set; } // 0x0000000184EBFEA0-0x0000000184EBFF50 0x0000000184EBC5F0-0x0000000184EBC6B0
	public float damagePercentage { [XID] /* 0x0000000189828810-0x0000000189828830 */ get; [XID] /* 0x0000000189A02730-0x0000000189A02750 */ set; } // 0x0000000184EC37F0-0x0000000184EC3920 0x0000000184EBE250-0x0000000184EBE340
	public float damagePercentageRatio { [XID] /* 0x0000000189A09EC0-0x0000000189A09EE0 */ get; [XID] /* 0x0000000189A11720-0x0000000189A11740 */ set; } // 0x0000000184EBDC70-0x0000000184EBDDA0 0x0000000184EBECE0-0x0000000184EBEDD0
	public float damageExtra { [XID] /* 0x0000000189636640-0x0000000189636660 */ get; [XID] /* 0x0000000189A20190-0x0000000189A201B0 */ set; } // 0x0000000184EBFAF0-0x0000000184EBFC20 0x0000000184EBF5E0-0x0000000184EBF6D0
	public float bonusCritical { [XID] /* 0x0000000189A27520-0x0000000189A27540 */ get; [XID] /* 0x0000000189A2ED40-0x0000000189A2ED60 */ set; } // 0x0000000184EBC270-0x0000000184EBC3A0 0x0000000184EBE050-0x0000000184EBE140
	public float bonusCriticalHurt { [XID] /* 0x0000000189A365F0-0x0000000189A36610 */ get; [XID] /* 0x0000000189A3DC10-0x0000000189A3DC30 */ set; } // 0x0000000184EBC9F0-0x0000000184EBCB20 0x0000000184EBC3A0-0x0000000184EBC490
	public ElementType elementType { [XID] /* 0x0000000189A4CA60-0x0000000189A4CA80 */ get; [XID] /* 0x000000018975A0E0-0x000000018975A100 */ set; } // 0x0000000184EBDDA0-0x0000000184EBDEC0 0x0000000184EBF790-0x0000000184EBF890
	public ElementType bakedElementType { [XID] /* 0x0000000189A63450-0x0000000189A63470 */ get; } // 0x0000000184EBEE80-0x0000000184EBEF20 
	public float elementRank { [XID] /* 0x0000000189959B10-0x0000000189959B30 */ get; } // 0x0000000184EBDEC0-0x0000000184EBDFA0 
	public float elementDurability { [XID] /* 0x0000000189A7A250-0x0000000189A7A270 */ get; } // 0x0000000184EBEF20-0x0000000184EBF120 
	public float bakedElementDurability { [XID] /* 0x0000000189A89170-0x0000000189A89190 */ get; } // 0x0000000184EBEC30-0x0000000184EBECE0 
	public bool overrideByWeapon { [XID] /* 0x0000000189A90950-0x0000000189A90970 */ get; } // 0x0000000184EBF890-0x0000000184EBF960 
	public bool ignoreAttackerProperty { [XID] /* 0x0000000189A981B0-0x0000000189A981D0 */ get; } // 0x0000000184EBF120-0x0000000184EBF1F0 
	public bool trueDamage { [XID] /* 0x0000000189A9F530-0x0000000189A9F550 */ get; [XID] /* 0x0000000189AA6D60-0x0000000189AA6D80 */ set; } // 0x0000000184EC14A0-0x0000000184EC15B0 0x0000000184EBC6B0-0x0000000184EBC7A0
	public StrikeType strikeType { [XID] /* 0x0000000189AAE490-0x0000000189AAE4B0 */ get; } // 0x0000000184EC04F0-0x0000000184EC05C0 
	public float enBreak { [XID] /* 0x000000018961CC80-0x000000018961CCA0 */ get; } // 0x0000000184EBE140-0x0000000184EBE250 
	public AttackType attackType { [XID] /* 0x0000000189ABD7F0-0x0000000189ABD810 */ get; } // 0x0000000184EBEB60-0x0000000184EBEC30 
	public bool ignoreLevelDiff { [XID] /* 0x0000000189AC5290-0x0000000189AC52B0 */ get; } // 0x0000000184EBC1A0-0x0000000184EBC270 

	// Nested types
	public struct HitCollsion // TypeDefIndex: 20531
	{
		// Fields
		public uint hitIndex; // 0x00
		public Collider hitCollider; // 0x08
		public Vector3 hitDir; // 0x10
		public Vector3 hitPoint; // 0x1C
		public float attackeeHitForceAngle; // 0x28
		public float attackeeHitEntityAngle; // 0x2C
	}

	public class ModifiedAttackProperty // TypeDefIndex: 20532
	{
		// Fields
		public float? damagePercentage; // 0x10
		public float? damagePercentageRatio; // 0x18
		public float? damageExtra; // 0x20
		public float? bonusCritical; // 0x28
		public float? bonusCriticalHurt; // 0x30
		public ElementType? elementType; // 0x38
		public bool? trueDamage; // 0x40

		// Constructors
		public ModifiedAttackProperty(); // 0x0000000184EBC140-0x0000000184EBC1A0

		// Methods
		[XID] // 0x0000000189B6CA00-0x0000000189B6CA20
		public void Reset(); // 0x0000000184EBC080-0x0000000184EBC140
	}

	public enum EndureBreakLevel : uint // TypeDefIndex: 20533
	{
		None = 0,
		OnlyShake = 1,
		Break = 2
	}

	public struct AttackHitEffectResult // TypeDefIndex: 20534
	{
		// Fields
		public HitLevel hitEffLevel; // 0x00
		public HitLevel originHitEffLevel; // 0x04
		public float retreatStrength; // 0x08
		public float airStrength; // 0x0C
		public float hitHaltTime; // 0x10
		public float hitHaltTimeScale; // 0x14
	}

	// Constructors
	public AttackResult(); // 0x0000000184EC3F10-0x0000000184EC40A0
	static AttackResult(); // 0x0000000184EC3E40-0x0000000184EC3F10

	// Methods
	[XID] // 0x0000000189606430-0x0000000189606450
	public void GetBeforeCalcHit(uint attackerID, ref float impusX, ref float impusY, ref HitLevel hLevel); // 0x0000000184EBFF50-0x0000000184EC04F0
	[XID] // 0x00000001899CE610-0x00000001899CE630
	private float GetAttackerPropertyDynimacFloat(DynamicFloat dynamicFloat); // 0x0000000184EBF2A0-0x0000000184EBF430
	[XID] // 0x00000001899EC1B0-0x00000001899EC1D0
	private bool CheckModifiedAttackProperty(); // 0x0000000184EBF6D0-0x0000000184EBF790
	[XID] // 0x00000001899F3C10-0x00000001899F3C30
	private void DestroyModifiedAttackProperty(); // 0x0000000184EBE340-0x0000000184EBE400
	[XID] // 0x0000000189A453B0-0x0000000189A453D0
	internal void SetOrigElementType(ElementType type); // 0x0000000184EBEDD0-0x0000000184EBEE80
	[XID] // 0x0000000189A5BD00-0x0000000189A5BD20
	public void BakeElementType(); // 0x0000000184EBDFA0-0x0000000184EBE050
	[XID] // 0x0000000189A72600-0x0000000189A72620
	internal void SetOrigElementDurability(float value); // 0x0000000184EBF1F0-0x0000000184EBF2A0
	[XID] // 0x0000000189A816F0-0x0000000189A81710
	public void BakeElementDurability(); // 0x0000000184EBC940-0x0000000184EBC9F0
	[XID] // 0x0000000189ACC760-0x0000000189ACC780
	public bool rejected(RejectEventType type = RejectEventType.RejectAll /* Metadata: 0x00AFDBA5 */); // 0x0000000184EBC880-0x0000000184EBC940
	[XID] // 0x0000000189AD4450-0x0000000189AD4470
	public override string ToString(); // 0x0000000184EC3920-0x0000000184EC3E40
	[XID] // 0x00000001897634C0-0x00000001897634E0
	public void Reset(); // 0x0000000184EBCB20-0x0000000184EBCD50
	[IDTag] // 0x0000000189AE3750-0x0000000189AE3790
	[XID] // 0x0000000189AE3750-0x0000000189AE3790
	public static AttackResult CreateAttackResult(MassiveEntityElementOpBatchNotify notify); // 0x0000000184EC0D20-0x0000000184EC0EB0
	[IDTag] // 0x0000000189AEE200-0x0000000189AEE240
	[XID] // 0x0000000189AEE200-0x0000000189AEE240
	public static AttackResult CreateAttackResult(ElementType sourceElementType, float attackElementDurability); // 0x0000000184EC0BB0-0x0000000184EC0D20
	[IDTag] // 0x0000000189AF8A60-0x0000000189AF8AA0
	[XID] // 0x0000000189AF8A60-0x0000000189AF8AA0
	public static AttackResult CreateAttackResult(AttackResult attackResultInfo); // 0x0000000184EC0EB0-0x0000000184EC14A0
	[IDTag] // 0x0000000189B02FB0-0x0000000189B02FF0
	[XID] // 0x0000000189B02FB0-0x0000000189B02FF0
	public static AttackResult CreateAttackResult(BaseEntity attacker, BaseEntity attackee, ConfigAttackInfo attackInfo, string animEventId, AbilityIdentifier? abilityIdentifier, uint? gadgetDamageActionIdx, Vector3 hitPoint, Vector3 hitForward, Collider hitCollider, TargetType? targetType = default); // 0x0000000184EC05C0-0x0000000184EC0BB0
	[XID] // 0x0000000189B0D690-0x0000000189B0D6B0
	public static void DeallocateAttackResult(AttackResult attackResult); // 0x0000000184EBF430-0x0000000184EBF5E0
	[XID] // 0x0000000189B14BB0-0x0000000189B14BD0
	private static void FillAttackResultByAttackInfo(AttackResult attackResult, BaseEntity attacker, ConfigAttackInfo attackInfo, TargetType? targetType = default); // 0x0000000184EBE400-0x0000000184EBE6E0
	[XID] // 0x0000000189B1C4D0-0x0000000189B1C4F0
	private static void InitTagToEnumDic(); // 0x0000000184EC33B0-0x0000000184EC37F0
	[XID] // 0x0000000189B23A40-0x0000000189B23A60
	public static ElementReactionType AttackTagToEnum(string str); // 0x0000000184EBF960-0x0000000184EBFAF0
	[XID] // 0x0000000189B2AD60-0x0000000189B2AD80
	public AttackResult FillProtoAttackResult(uint attackerID, uint defenseId, AttackResult protoAttackResult); // 0x0000000184EBD1B0-0x0000000184EBDC70
	[IDTag] // 0x0000000189B32280-0x0000000189B322C0
	[XID] // 0x0000000189B32280-0x0000000189B322C0
	private bool FillAttackResult(AttackResult protoAttackResult); // 0x0000000184EC1660-0x0000000184EC33B0
	[XID] // 0x0000000189B3C9C0-0x0000000189B3C9E0
	public void CheckInvalidAttack(uint criticalRand, BaseEntity attacker, BaseEntity attackee); // 0x0000000184EBFC20-0x0000000184EBFCF0
	[XID] // 0x0000000189B44730-0x0000000189B44750
	public static void ClearCheckInvalidAttack(); // 0x0000000184EBC7A0-0x0000000184EBC880
	[XID] // 0x0000000189B4BF20-0x0000000189B4BF40
	public void Reject(RejectEventType rejectType); // 0x0000000184EBC490-0x0000000184EBC580
	[IDTag] // 0x0000000189B534C0-0x0000000189B53500
	[XID] // 0x0000000189B534C0-0x0000000189B53500
	private void FillAttackResult(MassiveEntityElementOpBatchNotify notify); // 0x0000000184EC15B0-0x0000000184EC1660
	[XID] // 0x000000018963C360-0x000000018963C380
	public static void AddReferenceCount(AttackResult attackResult); // 0x0000000184EBCD50-0x0000000184EBD1B0
	[XID] // 0x0000000189B653A0-0x0000000189B653C0
	public static void MinusReferenceCount(AttackResult attackResult); // 0x0000000184EBE6E0-0x0000000184EBEB60
}