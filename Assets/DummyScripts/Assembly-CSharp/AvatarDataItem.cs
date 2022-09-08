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
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarDataItem : UniqueDataItem // TypeDefIndex: 21448
{
	// Fields
	public uint uid; // 0x40
	public SafeUInt32 configId; // 0x48
	public SafeUInt32 skillDepotId; // 0x58
	public uint trialId; // 0x68
	public bool isUpgradeable; // 0x6C
	public bool isAuthority; // 0x6D
	public uint moveReliableSeq; // 0x70
	public DualClientSequenceId clientSequenceId; // 0x74
	public bool isFocus; // 0x7C
	public AvatarType avatarType; // 0x80
	public uint flycloakId; // 0x84
	public HashSet<uint> pendingPromoteRewardList; // 0x88
	public uint sceneId; // 0x90
	public bool isAppearred; // 0x94
	public bool isClientFakeData; // 0x95
	public uint bornTime; // 0x98
	private Dictionary<SafeUInt32, SafeAvatarSkillCDInfo> _cacheSkillCDValueDic; // 0xA0
	private LifeState _state; // 0xA8
	private uint _entityId; // 0xAC
	private ulong _curEquipGuid; // 0xB0
	public List<ulong> equipGuidList; // 0xB8
	public SortedDictionary<SafeUInt32, AvatarTalentExcelConfig> avatarTalentDic; // 0xC0
	public List<ProudSkillExcelConfig> proudCombatSkillList; // 0xC8
	public List<ProudSkillExcelConfig> proudInheritSkillList; // 0xD0
	public ProudSkillExcelConfig proudCoreSkill; // 0xD8
	public List<BaseTalentConfig> teamResonanceTalentList; // 0xE0
	public List<BaseTalentConfig> weaponTalentList; // 0xE8
	public List<BaseTalentConfig> reliquaryTalentList; // 0xF0
	private Dictionary<SafeUInt32, SafeUInt32> _proudSkillLevelMap; // 0xF8
	private Dictionary<SafeUInt32, SafeUInt32> _proudSkillExtraLevelMap; // 0x100
	public AvatarExpeditionInfo expeditionInfo; // 0x108
	private AvatarFetterInfo _avatarFetterInfo; // 0x110
	public List<Tuple<uint, string, string>> newAvatarAllAbilities; // 0x118
	public MoveSyncTask initSyncTask; // 0x120
	private Dictionary<SafeUInt32, SafeUInt32> _equipAffixCDs; // 0x1E0
	private float _satiationZeroTimestamp; // 0x1E8
	private AbilitySyncStateInfo _abilitySyncInfo; // 0x1F0
	private Dictionary<uint, ServerBuffInfo> _sBuffDict; // 0x1F8
	private static Dictionary<uint, uint> avatarIdToFetterIdDic; // 0x00
	private uint _fetterDataInfoId; // 0x200

	// Properties
	public bool isTrial { /* [XID] */ /* 0x0000000189992060-0x0000000189992080 */ get => default; } // 0x000000018380BFD0-0x000000018380C080 
	public bool isMirror { /* [XID] */ /* 0x0000000189B927A0-0x0000000189B927C0 */ get => default; } // 0x000000018380C510-0x000000018380C5C0 
	public AvatarFetterInfo avatarFetterInfo { /* [XID] */ /* 0x0000000189B74F90-0x0000000189B74FB0 */ get => default; } // 0x00000001838148D0-0x0000000183814980 
	public override uint entityId { /* [XID] */ /* 0x00000001899BF650-0x00000001899BF670 */ get => default; /* [XID] */ /* 0x00000001899C6FF0-0x00000001899C7010 */ set {} } // 0x0000000183808DC0-0x0000000183808E60 0x00000001838080E0-0x0000000183808190
	public LifeState state { /* [XID] */ /* 0x00000001899CE490-0x00000001899CE4B0 */ get => default; /* [XID] */ /* 0x00000001898FE7C0-0x00000001898FE7E0 */ private set {} } // 0x0000000183807E50-0x0000000183807EF0 0x0000000183802DD0-0x0000000183802E80
	public ulong curEquipGuid { /* [XID] */ /* 0x00000001899DD000-0x00000001899DD020 */ get => default; } // 0x0000000183815270-0x0000000183815320 
	public uint cost { /* [XID] */ /* 0x00000001899E4BC0-0x00000001899E4BE0 */ get => default; } // 0x000000018380E6A0-0x000000018380E740 
	public uint weaponCost { /* [XID] */ /* 0x00000001899EC0D0-0x00000001899EC0F0 */ get => default; } // 0x0000000183814DC0-0x0000000183814EF0 
	public List<ReliquarySetInfo> relicSetList { /* [XID] */ /* 0x00000001899F3AD0-0x00000001899F3AF0 */ get => default; } // 0x000000018380CC90-0x000000018380CE60 
	public ElementType elementType { /* [XID] */ /* 0x0000000189A9DAB0-0x0000000189A9DAD0 */ get => default; } // 0x0000000183807EF0-0x0000000183808030 
	public bool canChangeElementType { /* [XID] */ /* 0x0000000189AA5400-0x0000000189AA5420 */ get => default; } // 0x00000001838137D0-0x00000001838138E0 
	public ElementType defaultElementType { /* [XID] */ /* 0x0000000189AACC80-0x0000000189AACCA0 */ get => default; } // 0x00000001838045E0-0x0000000183804740 
	public uint avatarPromoteId { /* [XID] */ /* 0x0000000189AB4510-0x0000000189AB4530 */ get => default; } // 0x0000000183808CC0-0x0000000183808DC0 
	public Dictionary<SafeUInt32, SafeUInt32> EquipAffixCDs { /* [XID] */ /* 0x0000000189928AD0-0x0000000189928AF0 */ get => default; /* [XID] */ /* 0x0000000189BA36B0-0x0000000189BA36D0 */ set {} } // 0x0000000183804D70-0x0000000183804E20 0x000000018380C5C0-0x000000018380C670
	public bool isFullHP { /* [XID] */ /* 0x0000000189617250-0x0000000189617270 */ get => default; } // 0x000000018380C440-0x000000018380C510 
	public float hpRatio { /* [XID] */ /* 0x000000018961EE40-0x000000018961EE60 */ get => default; } // 0x0000000183804140-0x0000000183804280 
	public float satiationZeroTimestamp { /* [XID] */ /* 0x00000001896261C0-0x00000001896261E0 */ set {} } // 0x0000000183807DA0-0x0000000183807E50
	public float satiationZeroSecond { /* [XID] */ /* 0x000000018962DBD0-0x000000018962DBF0 */ get => default; } // 0x000000018380EE90-0x000000018380F010 
	public float satiationShowValue { /* [XID] */ /* 0x0000000189635790-0x00000001896357B0 */ get => default; } // 0x0000000183808AE0-0x0000000183808BF0 
	public AbilitySyncStateInfo abilitySyncInfo { /* [XID] */ /* 0x000000018963CE70-0x000000018963CE90 */ get => default; /* [XID] */ /* 0x0000000189644430-0x0000000189644450 */ set {} } // 0x000000018380A080-0x000000018380A130 0x000000018380C9C0-0x000000018380CAD0
	public uint fetterDataInfoId { /* [XID] */ /* 0x00000001896C1680-0x00000001896C16A0 */ get => default; } // 0x0000000183811500-0x0000000183811B90 

	// Nested types
	public struct SafeAvatarSkillCDInfo // TypeDefIndex: 21449
	{
		// Fields
		public SafeUInt32 MaxChargeCount; // 0x00
		public SafeUInt32 PassCdTime; // 0x10
		public SafeUInt32[] FullCdTimeList; // 0x20

		// Constructors
		public SafeAvatarSkillCDInfo(AvatarSkillInfo info) {
			MaxChargeCount = default;
			PassCdTime = default;
			FullCdTimeList = default;
		} // 0x0000000183E7E210-0x0000000183E7E3A0
	}

	public class ServerBuffInfo // TypeDefIndex: 21450
	{
		// Fields
		public uint uid; // 0x10
		public uint instancedModifierID; // 0x14
		public BaseServerBuffConfig config; // 0x18
		public ServerBuffType buffType; // 0x20
		public List<uint> doneOnAddedActionList; // 0x28
		public bool isOnaddedActionAllow; // 0x30

		// Constructors
		public ServerBuffInfo() {} // Dummy constructor
		public ServerBuffInfo(ServerBuff sBuff) {} // 0x0000000183E7E900-0x0000000183E7ED80

		// Methods
		// [XID] // 0x00000001896E9980-0x00000001896E99A0
		public override string ToString() => default; // 0x0000000183E7E410-0x0000000183E7E900
	}

	// Constructors
	public AvatarDataItem() {} // 0x0000000183815380-0x0000000183815610
	static AvatarDataItem() {} // 0x0000000183815320-0x0000000183815380

	// Methods
	// [XID] // 0x00000001899A14D0-0x00000001899A14F0
	public bool IsExploring() => default; // 0x0000000183811F70-0x0000000183812030
	// [XID] // 0x00000001899B0890-0x00000001899B08B0
	public void ConvertMotionInfoToSyncTask(MotionInfo motion, uint time, uint reliableSeq) {} // 0x0000000183812E80-0x00000001838137D0
	// [XID] // 0x00000001899B7C30-0x00000001899B7C50
	private MotionState TranslateFromIceMotion(MotionState motion) => default; // 0x000000018380EC50-0x000000018380ED30
	// [XID] // 0x00000001899FB3B0-0x00000001899FB3D0
	public Dictionary<FightPropType, float> GetRelicFightProp() => default; // 0x0000000183806190-0x0000000183806820
	// [XID] // 0x0000000189A025D0-0x0000000189A025F0
	private float GetPropValue(FightPropType type, Dictionary<FightPropType, float> propDict) => default; // 0x0000000183814980-0x0000000183814A80
	// [XID] // 0x0000000189A09D60-0x0000000189A09D80
	private void SetEntityId(uint newId) {} // 0x00000001838077A0-0x0000000183807980
	// [XID] // 0x0000000189A115A0-0x0000000189A115C0
	private void SetLifeState(LifeState newState) {} // 0x0000000183812030-0x00000001838121E0
	// [XID] // 0x0000000189A189B0-0x0000000189A189D0
	public void UpdateAvaterFetter(AvatarFetterInfo fetterInfo) {} // 0x000000018380B670-0x000000018380B8D0
	// [XID] // 0x0000000189A20030-0x0000000189A20050
	public void UpdateByShowAvatarInfo(ShowAvatarInfo showAvatarInfo) {} // 0x00000001838104D0-0x0000000183810980
	// [XID] // 0x0000000189A273C0-0x0000000189A273E0
	public void ClearFakeEquipList() {} // 0x000000018380CAD0-0x000000018380CC90
	// [IDTag] // 0x0000000189A2EC00-0x0000000189A2EC40
	// [XID] // 0x0000000189A2EC00-0x0000000189A2EC40
	private void CreateFakeWeaponItem(uint itemId, Weapon weapon, out Item item) {
		item = default;
	} // 0x0000000183803B20-0x0000000183803F50
	// [IDTag] // 0x0000000189A392F0-0x0000000189A39330
	// [XID] // 0x0000000189A392F0-0x0000000189A39330
	private void CreateFakeWeaponItem(uint itemId, SceneWeaponInfo weapon, out Item item) {
		item = default;
	} // 0x0000000183803740-0x0000000183803B20
	// [XID] // 0x0000000189A43CD0-0x0000000189A43CF0
	private void CreateFakeReliquaryItem(uint itemId, Reliquary reliquary, out Item item) {
		item = default;
	} // 0x0000000183805D80-0x0000000183806190
	// [XID] // 0x0000000189A4B140-0x0000000189A4B160
	public void UpdateByAvatarInfo(AvatarInfo avatarInfo, SceneAvatarInfo sceneAvatarInfo = null) {} // 0x0000000183811B90-0x0000000183811F70
	// [XID] // 0x0000000189A52820-0x0000000189A52840
	protected override void UpdateNormalProp(PropType type, double value, double lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF7E1 */) {} // 0x000000018380A340-0x000000018380A700
	// [XID] // 0x0000000189A5A1C0-0x0000000189A5A1E0
	protected override void ClearFightProps() {} // 0x0000000183814730-0x00000001838148D0
	// [XID] // 0x0000000189A619F0-0x0000000189A61A10
	protected override void UpdateFightProp(FightPropType type, float value, float lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF7E5 */) {} // 0x0000000183808460-0x00000001838087C0
	// [XID] // 0x0000000189A69950-0x0000000189A69970
	private void UpdateFightPropForBackground(FightPropType type, float value, float lastValue, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AFF7E9 */) {} // 0x00000001838129C0-0x0000000183812B70
	// [XID] // 0x0000000189A70BE0-0x0000000189A70C00
	public override void HandleFightPropChange(FightPropType type, EntityFightPropChangeReasonNotify notify) {} // 0x00000001838047A0-0x0000000183804D70
	// [XID] // 0x0000000189A78540-0x0000000189A78560
	public void UpdateSkillCDs(MapField<uint, AvatarSkillInfo> skillCDMap) {} // 0x0000000183802AE0-0x0000000183802DD0
	// [XID] // 0x0000000189A7FAD0-0x0000000189A7FAF0
	private void UpdateEntitySkillCDs() {} // 0x0000000183810F30-0x0000000183811400
	// [XID] // 0x0000000189A87820-0x0000000189A87840
	public override void RefreshAllProps() {} // 0x0000000183808030-0x00000001838080E0
	// [XID] // 0x0000000189A8EFD0-0x0000000189A8EFF0
	public void UpdateSkillMaxChargeCount(uint skillID, uint maxChargeCount) {} // 0x0000000183812B70-0x0000000183812E80
	// [XID] // 0x0000000189A96580-0x0000000189A965A0
	public void ChangeSkillDepot(uint skillDepotId, RepeatedField<uint> newTalentList, MapField<uint, uint> skillLevelMap, RepeatedField<uint> proudSkillList, uint coreProudSkillLevel, MapField<uint, uint> extraSkillLevelMap) {} // 0x000000018380D110-0x000000018380D500
	// [XID] // 0x0000000189ABC200-0x0000000189ABC220
	public string getAvatarRealName() => default; // 0x0000000183811400-0x0000000183811500
	// [XID] // 0x0000000189AC3AE0-0x0000000189AC3B00
	public void SetCurEquip(ulong guid) {} // 0x0000000183810AB0-0x0000000183810B80
	// [XID] // 0x000000018979C650-0x000000018979C670
	public BagItem GetBagItemByEquipType(EquipType equipType) => default; // 0x000000018380A130-0x000000018380A2C0
	// [XID] // 0x0000000189AD2AA0-0x0000000189AD2AC0
	public ulong GetGuidByEquipType(EquipType equipType) => default; // 0x0000000183804E20-0x0000000183804EF0
	// [XID] // 0x0000000189ADA460-0x0000000189ADA480
	public EquipType GetEquipTypeByGuid(ulong guid) => default; // 0x000000018380A700-0x000000018380A940
	// [XID] // 0x0000000189AE1D70-0x0000000189AE1D90
	private EquipDataItem GetDataItemByEquipType(EquipType equipType) => default; // 0x000000018380E510-0x000000018380E6A0
	// [XID] // 0x0000000189B840D0-0x0000000189B840F0
	public BagItem GetBagItemByGuid(ulong equipGuid) => default; // 0x000000018380B460-0x000000018380B670
	// [XID] // 0x0000000189AF13B0-0x0000000189AF13D0
	public void ChangeEquip(EquipType equipType, SceneWeaponInfo weaponInfo, SceneReliquaryInfo reliquaryInfo) {} // 0x0000000183802890-0x0000000183802AE0
	// [XID] // 0x0000000189AF8990-0x0000000189AF89B0
	private bool RealChangeEquip(EquipType equipType, SceneWeaponInfo weaponInfo, SceneReliquaryInfo reliquaryInfo, ref ulong prevEquipGuid, ref ulong equipGuid) => default; // 0x00000001838121E0-0x00000001838127D0
	// [XID] // 0x0000000189AFFEF0-0x0000000189AFFF10
	private bool RealChangeEquipByItem(EquipType equipType, WeaponItem weaponInfo, ReliquaryItem reliquaryInfo, ref ulong prevEquipGuid, ref ulong equipGuid) => default; // 0x0000000183804EF0-0x0000000183805310
	// [XID] // 0x0000000189B07490-0x0000000189B074B0
	public void TakeoffEquip(EquipType equipType) {} // 0x00000001838087C0-0x00000001838089D0
	// [XID] // 0x0000000189B0EC50-0x0000000189B0EC70
	private void RemoveEquip(ulong equipGuid) {} // 0x0000000183808BF0-0x0000000183808CC0
	// [XID] // 0x0000000189B16010-0x0000000189B16030
	private void RemoveAllEquip() {} // 0x000000018380BCD0-0x000000018380BD90
	// [XID] // 0x0000000189B1D690-0x0000000189B1D6B0
	public void RefreshAllEquipDatas(SceneAvatarInfo avatar) {} // 0x0000000183808190-0x0000000183808460
	// [XID] // 0x0000000189B25080-0x0000000189B250A0
	private void RefreshAllEquipSimpleDatas(RepeatedField<ulong> equipGuids) {} // 0x000000018380CE60-0x000000018380D110
	// [XID] // 0x0000000189B2C530-0x0000000189B2C550
	public void UnlockAvatarTalent(uint talentID) {} // 0x000000018380BD90-0x000000018380BFD0
	// [XID] // 0x0000000189B33A80-0x0000000189B33AA0
	public void UpdateAvatarTalentList(RepeatedField<uint> newTalentList) {} // 0x0000000183802E80-0x00000001838030B0
	// [XID] // 0x0000000189B3B350-0x0000000189B3B370
	public void UpdateProudSkillList(MapField<uint, uint> combatSkillMap, RepeatedField<uint> inheritSkillList, uint depotId, uint coreSkillLevel, MapField<uint, uint> extraSkillLevelMap) {} // 0x0000000183806C50-0x00000001838075B0
	// [XID] // 0x0000000189B42B90-0x0000000189B42BB0
	public void UpdateProudCombatSkillLevel(uint skillId, uint oldLevel, uint newLevel) {} // 0x000000018380D800-0x000000018380DBD0
	// [XID] // 0x0000000189B4A5F0-0x0000000189B4A610
	public void AddProudSkillList(RepeatedField<uint> skillList) {} // 0x000000018380FC50-0x000000018380FF70
	// [XID] // 0x0000000189B51D80-0x0000000189B51DA0
	public void UpdateProudSkillExtraLevel(uint proudType, uint proudIndex, uint level) {} // 0x0000000183809C20-0x000000018380A080
	// [XID] // 0x0000000189B595A0-0x0000000189B595C0
	private ProudSkillExcelConfig GetProudSkillConfig(uint groupId) => default; // 0x0000000183814A80-0x0000000183814D00
	// [XID] // 0x0000000189B60E10-0x0000000189B60E30
	public uint GetSkillExtraLevel(uint groupId) => default; // 0x000000018380A940-0x000000018380AAE0
	// [XID] // 0x0000000189B68570-0x0000000189B68590
	public void RefreshFullTeamResonance(ScopeList<uint> teamResonanceIdList) {} // 0x0000000183803230-0x0000000183803740
	// [XID] // 0x0000000189B6F900-0x0000000189B6F920
	public void UpdateTeamResonanceChange(RepeatedField<uint> addTeamResonanceIdList, RepeatedField<uint> delTeamResonanceIdList) {} // 0x000000018380DBD0-0x000000018380E510
	// [XID] // 0x0000000189B76EF0-0x0000000189B76F10
	private int TeamResonanceDataComparer(BaseTalentConfig a, BaseTalentConfig b) => default; // 0x00000001838127D0-0x00000001838129C0
	// [XID] // 0x0000000189B7E440-0x0000000189B7E460
	public void UpdateEquipTalentList(bool refreshTalents = false /* Metadata: 0x00AFF7ED */) {} // 0x0000000183805450-0x0000000183805980
	// [XID] // 0x0000000189B86050-0x0000000189B86070
	private List<BaseTalentConfig> FindWeaponTalents(uint weaponID, Dictionary<uint, uint> weaponAffixLevelMap) => default; // 0x000000018380F010-0x000000018380F320
	// [XID] // 0x0000000189B8D110-0x0000000189B8D130
	private List<BaseTalentConfig> FindReliquaryTalents(List<uint> reliquaryIds) => default; // 0x000000018380FF70-0x00000001838104D0
	// [XID] // 0x0000000189B948D0-0x0000000189B948F0
	private int EquipAffixDataComparer(BaseTalentConfig a, BaseTalentConfig b) => default; // 0x0000000183803F50-0x0000000183804140
	// [XID] // 0x0000000189BAAA80-0x0000000189BAAAA0
	private void UpdateEquipAffixCDs(RepeatedMessageField<AvatarEquipAffixInfo> equipAffixList) {} // 0x00000001838075B0-0x00000001838077A0
	// [XID] // 0x0000000189BB1FF0-0x0000000189BB2010
	private void RefreshEntityTalents() {} // 0x000000018380ED30-0x000000018380EE90
	// [XID] // 0x0000000189BB93E0-0x0000000189BB9400
	public List<BaseTalentConfig> GetAvatarTalents(BaseEntity entity, List<BaseTalentConfig> talents = null) => default; // 0x0000000183804280-0x00000001838045E0
	// [XID] // 0x00000001896D2AB0-0x00000001896D2AD0
	public List<BaseTalentConfig> GetProudTalents(BaseEntity entity, List<BaseTalentConfig> talents = null) => default; // 0x00000001838138E0-0x0000000183813F00
	// [XID] // 0x00000001896FF690-0x00000001896FF6B0
	public List<BaseTalentConfig> GetTeamResonanceTalents(BaseEntity entity, List<BaseTalentConfig> talents = null) => default; // 0x0000000183805980-0x0000000183805C80
	// [XID] // 0x0000000189BD0190-0x0000000189BD01B0
	public List<BaseTalentConfig> GetWeaponTalents(BaseEntity entity, List<BaseTalentConfig> talents = null) => default; // 0x000000018380C080-0x000000018380C380
	// [XID] // 0x000000018970E3D0-0x000000018970E3F0
	public List<BaseTalentConfig> GetReliquaryTalents(BaseEntity entity, List<BaseTalentConfig> talents = null) => default; // 0x000000018380D500-0x000000018380D800
	// [XID] // 0x00000001896BCB40-0x00000001896BCB60
	public List<BaseTalentConfig> GetAllTalents(BaseEntity entity) => default; // 0x0000000183810980-0x0000000183810AB0
	// [XID] // 0x00000001895EBF50-0x00000001895EBF70
	public void RefreshEntityOnPreEntityReady() {} // 0x0000000183814D00-0x0000000183814DC0
	// [XID] // 0x00000001895F3330-0x00000001895F3350
	public void RefreshEntityOnPostEntityReady() {} // 0x0000000183810BF0-0x0000000183810F30
	// [IDTag] // 0x00000001895FAC30-0x00000001895FAC70
	// [XID] // 0x00000001895FAC30-0x00000001895FAC70
	public void RefreshLifeState() {} // 0x0000000183809B60-0x0000000183809C20
	// [XID] // 0x00000001896052B0-0x00000001896052D0
	public string GetIcon() => default; // 0x0000000183805C80-0x0000000183805D80
	// [IDTag] // 0x000000018960CCE0-0x000000018960CD20
	// [XID] // 0x000000018960CCE0-0x000000018960CD20
	public void RefreshLifeState(LifeState st, uint sourceId = 0 /* Metadata: 0x00AFF7EE */, PlayerDieType dieType = PlayerDieType.PlayerDieNone /* Metadata: 0x00AFF7F2 */) {} // 0x00000001838090F0-0x0000000183809B60
	// [XID] // 0x000000018964BC30-0x000000018964BC50
	private void CheckAbilityNeedSyncFromServer() {} // 0x000000018380EAD0-0x000000018380EC50
	// [XID] // 0x00000001896532A0-0x00000001896532C0
	private void RefreshAbilitySyncStateInfo() {} // 0x000000018380B270-0x000000018380B460
	// [XID] // 0x000000018965AB30-0x000000018965AB50
	public void UpdateAbilityControlBlock(AbilityControlBlock abilityBlock) {} // 0x000000018380AAE0-0x000000018380B270
	// [XID] // 0x0000000189661FC0-0x0000000189661FE0
	private static BaseServerBuffConfig GetSBuffConfig(uint serverBuffId, ServerBuffType serverBuffType) => default; // 0x00000001838089D0-0x0000000183808AE0
	// [XID] // 0x0000000189669BA0-0x0000000189669BC0
	public bool IsOnAddedActionAllow(uint sbuffUid, uint localID) => default; // 0x000000018380F540-0x000000018380F710
	// [XID] // 0x00000001896717E0-0x0000000189671800
	public void RefreshServerBuffs(RepeatedMessageField<ServerBuff> sBuffList) {} // 0x000000018380C670-0x000000018380C9C0
	// [XID] // 0x0000000189678FD0-0x0000000189678FF0
	public void HandleRefreshServerBuffs() {} // 0x000000018380E740-0x000000018380EAD0
	// [XID] // 0x00000001896806F0-0x0000000189680710
	private void RefreshModifiersByServerBuff() {} // 0x000000018380B8D0-0x000000018380BCD0
	// [XID] // 0x0000000189688280-0x00000001896882A0
	public void AddServerBuffs(RepeatedMessageField<ServerBuff> sBuffList) {} // 0x0000000183814EF0-0x0000000183815270
	// [XID] // 0x000000018968FB60-0x000000018968FB80
	public void RemoveServerBuffs(RepeatedMessageField<ServerBuff> sBuffList) {} // 0x000000018380F710-0x000000018380FC50
	// [XID] // 0x000000018994C4C0-0x000000018994C4E0
	public void OnDetachServerBuffModifier(ActorModifier modifier) {} // 0x0000000183806820-0x0000000183806C50
	// [XID] // 0x000000018969EA50-0x000000018969EA70
	private string LogEntity(BaseEntity entity) => default; // 0x000000018380F320-0x000000018380F540
	// [IDTag] // 0x00000001896A5B80-0x00000001896A5BC0
	// [XID] // 0x00000001896A5B80-0x00000001896A5BC0
	private static string LogServerBuffs(RepeatedMessageField<ServerBuff> sBuffs) => default; // 0x0000000183814150-0x0000000183814730
	// [IDTag] // 0x00000001896AFE10-0x00000001896AFE50
	// [XID] // 0x00000001896AFE10-0x00000001896AFE50
	private static string LogServerBuffs(Dictionary<uint, ServerBuffInfo> sBuffs) => default; // 0x0000000183813F00-0x0000000183814150
	// [XID] // 0x00000001896BA430-0x00000001896BA450
	public void UpdateFlyCloak(uint wearingFlycloakId) {} // 0x00000001838030B0-0x0000000183803230
	// [XID] // 0x00000001896C8DC0-0x00000001896C8DE0
	private void UpdateAvatarPromoteReward(RepeatedField<uint> list) {} // 0x0000000183805310-0x0000000183805450
	// [XID] // 0x00000001896D0760-0x00000001896D0780
	private void UpdateEquipListByTrialEquips(RepeatedMessageField<Item> trialEquips) {} // 0x0000000183808E60-0x0000000183809080
	// [XID] // 0x00000001896D7C90-0x00000001896D7CB0
	public void AddTrialEquipsByItem(Item item, EquipType equipType) {} // 0x0000000183807980-0x0000000183807DA0
}

