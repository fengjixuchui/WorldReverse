/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AvatarSkillDepotExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15227
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 energySkillRawNum; // 0x14
	protected SimpleSafeUInt32 talentSkillRawNum; // 0x18
	protected SimpleSafeUInt32[] _skills; // 0x20
	protected SimpleSafeUInt32[] _subSkills; // 0x28
	protected SimpleSafeUInt32 attackModeSkillRawNum; // 0x30
	protected SimpleSafeUInt32 leaderTalentRawNum; // 0x34
	protected string[] _extraAbilities; // 0x38
	protected SimpleSafeUInt32[] _talents; // 0x40
	protected string _talentStarName; // 0x48
	protected SimpleSafeUInt32 coreProudSkillGroupIdRawNum; // 0x50
	protected SimpleSafeUInt32 coreProudAvatarPromoteLevelRawNum; // 0x54
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected ProudSkillOpenConfig[] _inherentProudSkillOpens; // 0x58
	protected string _skillDepotAbilityGroup; // 0x60

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898CF250-0x00000001898CF270 */ get => default; /* [XID] */ /* 0x00000001898D6AC0-0x00000001898D6AE0 */ protected set {} } // 0x0000000182E6ACE0-0x0000000182E6ADB0 0x0000000182E69A80-0x0000000182E69B60
	public uint energySkill { /* [XID] */ /* 0x000000018979F730-0x000000018979F750 */ get => default; /* [XID] */ /* 0x00000001898E5F80-0x00000001898E5FA0 */ protected set {} } // 0x0000000182E696B0-0x0000000182E69780 0x0000000182E69780-0x0000000182E69860
	public uint talentSkill { /* [XID] */ /* 0x00000001898ED8A0-0x00000001898ED8C0 */ get => default; /* [XID] */ /* 0x00000001898F5120-0x00000001898F5140 */ protected set {} } // 0x0000000182E6A6A0-0x0000000182E6A770 0x0000000182E6AFE0-0x0000000182E6B0C0
	public SimpleSafeUInt32[] skills { /* [XID] */ /* 0x000000018972EE90-0x000000018972EEB0 */ get => default; /* [XID] */ /* 0x0000000189904290-0x00000001899042B0 */ protected set {} } // 0x0000000182E69930-0x0000000182E699D0 0x0000000182E67580-0x0000000182E67630
	public SimpleSafeUInt32[] subSkills { /* [XID] */ /* 0x000000018975BB50-0x000000018975BB70 */ get => default; /* [XID] */ /* 0x0000000189913480-0x00000001899134A0 */ protected set {} } // 0x0000000182E6A8D0-0x0000000182E6A970 0x0000000182E6A820-0x0000000182E6A8D0
	public uint attackModeSkill { /* [XID] */ /* 0x0000000189772270-0x0000000189772290 */ get => default; /* [XID] */ /* 0x00000001899224A0-0x00000001899224C0 */ protected set {} } // 0x0000000182E67700-0x0000000182E677D0 0x0000000182E6AE60-0x0000000182E6AF40
	public uint leaderTalent { /* [XID] */ /* 0x0000000189929BE0-0x0000000189929C00 */ get => default; /* [XID] */ /* 0x0000000189931220-0x0000000189931240 */ protected set {} } // 0x0000000182E69860-0x0000000182E69930 0x0000000182E69530-0x0000000182E69610
	public string[] extraAbilities { /* [XID] */ /* 0x00000001896998F0-0x0000000189699910 */ get => default; /* [XID] */ /* 0x00000001899400C0-0x00000001899400E0 */ protected set {} } // 0x0000000182E67150-0x0000000182E671F0 0x0000000182E699D0-0x0000000182E69A80
	public SimpleSafeUInt32[] talents { /* [XID] */ /* 0x0000000189947600-0x0000000189947620 */ get => default; /* [XID] */ /* 0x000000018994EE60-0x000000018994EE80 */ protected set {} } // 0x0000000182E69610-0x0000000182E696B0 0x0000000182E677D0-0x0000000182E67880
	public string talentStarName { /* [XID] */ /* 0x0000000189956460-0x0000000189956480 */ get => default; /* [XID] */ /* 0x000000018995DE90-0x000000018995DEB0 */ protected set {} } // 0x0000000182E6AA50-0x0000000182E6AAF0 0x0000000182E6AAF0-0x0000000182E6ABA0
	public uint coreProudSkillGroupId { /* [XID] */ /* 0x00000001899656D0-0x00000001899656F0 */ get => default; /* [XID] */ /* 0x000000018996CDD0-0x000000018996CDF0 */ protected set {} } // 0x0000000182E67630-0x0000000182E67700 0x0000000182E67290-0x0000000182E67370
	public uint coreProudAvatarPromoteLevel { /* [XID] */ /* 0x0000000189974690-0x00000001899746B0 */ get => default; /* [XID] */ /* 0x000000018997BCA0-0x000000018997BCC0 */ protected set {} } // 0x0000000182E67880-0x0000000182E67950 0x0000000182E6A970-0x0000000182E6AA50
	public ProudSkillOpenConfig[] inherentProudSkillOpens { /* [XID] */ /* 0x0000000189983850-0x0000000189983870 */ get => default; /* [XID] */ /* 0x000000018998B0C0-0x000000018998B0E0 */ protected set {} } // 0x0000000182E671F0-0x0000000182E67290 0x0000000182E6ADB0-0x0000000182E6AE60
	public string skillDepotAbilityGroup { /* [XID] */ /* 0x0000000189992B90-0x0000000189992BB0 */ get => default; /* [XID] */ /* 0x000000018999A790-0x000000018999A7B0 */ protected set {} } // 0x0000000182E6AF40-0x0000000182E6AFE0 0x0000000182E6A770-0x0000000182E6A820

	// Constructors
	public AvatarSkillDepotExcelConfig() {} // 0x0000000182E6B160-0x0000000182E6B1C0

	// Methods
	// [IDTag] // 0x00000001899A1EB0-0x00000001899A1EF0
	// [XID] // 0x00000001899A1EB0-0x00000001899A1EF0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182E67950-0x0000000182E687C0
	// [IDTag] // 0x00000001899ACA10-0x00000001899ACA50
	// [XID] // 0x00000001899ACA10-0x00000001899ACA50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182E687C0-0x0000000182E69530
	// [XID] // 0x00000001899B6C90-0x00000001899B6CB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF045D */, bool useObjectPool = false /* Metadata: 0x00AF0461 */) => default; // 0x0000000182E69B60-0x0000000182E6A6A0
	[BlackList] // 0x00000001899BE750-0x00000001899BE790
	// [XID] // 0x00000001899BE750-0x00000001899BE790
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E67370-0x0000000182E67410
	[BlackList] // 0x00000001899C8D60-0x00000001899C8DA0
	// [XID] // 0x00000001899C8D60-0x00000001899C8DA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E67410-0x0000000182E67580
	[BlackList] // 0x00000001899D3590-0x00000001899D35D0
	// [XID] // 0x00000001899D3590-0x00000001899D35D0
	public virtual void ReturnToObjectPool() {} // 0x0000000182E6B0C0-0x0000000182E6B160
	[BlackList] // 0x00000001899DD9A0-0x00000001899DD9E0
	// [XID] // 0x00000001899DD9A0-0x00000001899DD9E0
	public virtual void OnPoolAllocated() {} // 0x0000000182E6AC40-0x0000000182E6ACE0
	[BlackList] // 0x00000001899E8560-0x00000001899E85A0
	// [XID] // 0x00000001899E8560-0x00000001899E85A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E6ABA0-0x0000000182E6AC40
}

