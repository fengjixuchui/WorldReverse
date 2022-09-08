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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AvatarExcelConfig : CreatureExcelConfig, IAutoAllocRecycle // TypeDefIndex: 14834
{
	// Fields
	protected AvatarUseType _useType; // 0xB8
	protected BodyType _bodyType; // 0xBC
	protected byte _scriptDataPathHashPre; // 0xC0
	protected uint _scriptDataPathHashSuffix; // 0xC4
	protected string _iconName; // 0xC8
	protected string _sideIconName; // 0xD0
	protected QualityType _qualityType; // 0xD8
	protected SimpleSafeFloat chargeEfficiencyRawNum; // 0xDC
	protected SimpleSafeFloat healAddRawNum; // 0xE0
	protected SimpleSafeFloat healedAddRawNum; // 0xE4
	protected byte _combatConfigHashPre; // 0xE8
	protected uint _combatConfigHashSuffix; // 0xEC
	protected bool _isRangeAttack; // 0xF0
	protected SimpleSafeUInt32 initialWeaponRawNum; // 0xF4
	protected WeaponType _weaponType; // 0xF8
	protected byte _manekinPathHashPre; // 0xFC
	protected uint _manekinPathHashSuffix; // 0x100
	protected string _imageName; // 0x108
	protected byte _gachaCardNameHashPre; // 0x110
	protected uint _gachaCardNameHashSuffix; // 0x114
	protected byte _gachaImageNameHashPre; // 0x118
	protected uint _gachaImageNameHashSuffix; // 0x11C
	protected byte _coopPicNameHashPre; // 0x120
	protected uint _coopPicNameHashSuffix; // 0x124
	protected string _cutsceneShow; // 0x128
	protected SimpleSafeUInt32 skillDepotIdRawNum; // 0x130
	protected SimpleSafeFloat staminaRecoverSpeedRawNum; // 0x134
	protected SimpleSafeUInt32[] _candSkillDepotIds; // 0x138
	protected byte _manekinJsonConfigHashPre; // 0x140
	protected uint _manekinJsonConfigHashSuffix; // 0x144
	protected SimpleSafeUInt32 manekinMotionConfigRawNum; // 0x148
	protected uint _descTextMapHash; // 0x14C
	protected AvatarIdentityType _avatarIdentityType; // 0x150
	protected SimpleSafeUInt32 avatarPromoteIdRawNum; // 0x154
	protected SimpleSafeUInt32[] _avatarPromoteRewardLevelList; // 0x158
	protected SimpleSafeUInt32[] _avatarPromoteRewardIdList; // 0x160
	protected SimpleSafeUInt32 featureTagGroupIDRawNum; // 0x168
	protected uint _infoDescTextMapHash; // 0x16C

	// Properties
	public string realName { /* [XID] */ /* 0x000000018980D050-0x000000018980D070 */ get => default; } // 0x00000001849D2F80-0x00000001849D3170 
	public AvatarUseType useType { /* [XID] */ /* 0x0000000189814810-0x0000000189814830 */ get => default; /* [XID] */ /* 0x000000018981C2C0-0x000000018981C2E0 */ protected set {} } // 0x00000001849CBF60-0x00000001849CC000 0x00000001849D7DB0-0x00000001849D7E60
	public BodyType bodyType { /* [XID] */ /* 0x00000001898237F0-0x0000000189823810 */ get => default; /* [XID] */ /* 0x000000018982B110-0x000000018982B130 */ protected set {} } // 0x00000001849D6D10-0x00000001849D6DB0 0x00000001849D7C50-0x00000001849D7D00
	public byte scriptDataPathHashPre { /* [XID] */ /* 0x0000000189832650-0x0000000189832670 */ get => default; /* [XID] */ /* 0x0000000189839CA0-0x0000000189839CC0 */ protected set {} } // 0x00000001849CBCC0-0x00000001849CBD70 0x00000001849D6AD0-0x00000001849D6B80
	public uint scriptDataPathHashSuffix { /* [XID] */ /* 0x0000000189841140-0x0000000189841160 */ get => default; /* [XID] */ /* 0x0000000189848620-0x0000000189848640 */ protected set {} } // 0x00000001849D6EC0-0x00000001849D6F60 0x00000001849CC000-0x00000001849CC0B0
	public ulong scriptDataPathHash { /* [XID] */ /* 0x000000018984FD80-0x000000018984FDA0 */ get => default; } // 0x00000001849D1F10-0x00000001849D1FE0 
	public string iconName { /* [XID] */ /* 0x0000000189857200-0x0000000189857220 */ get => default; /* [XID] */ /* 0x000000018985E330-0x000000018985E350 */ protected set {} } // 0x00000001849D7840-0x00000001849D78F0 0x00000001849D7D00-0x00000001849D7DB0
	public string sideIconName { /* [XID] */ /* 0x0000000189865CF0-0x0000000189865D10 */ get => default; /* [XID] */ /* 0x000000018986D270-0x000000018986D290 */ protected set {} } // 0x00000001849D7600-0x00000001849D76B0 0x00000001849D70B0-0x00000001849D7160
	public QualityType qualityType { /* [XID] */ /* 0x0000000189874720-0x0000000189874740 */ get => default; /* [XID] */ /* 0x000000018987C2E0-0x000000018987C300 */ protected set {} } // 0x00000001849CBC20-0x00000001849CBCC0 0x00000001849CC180-0x00000001849CC230
	public float chargeEfficiency { /* [XID] */ /* 0x00000001898833F0-0x0000000189883410 */ get => default; /* [XID] */ /* 0x000000018988AB50-0x000000018988AB70 */ protected set {} } // 0x00000001849D6C30-0x00000001849D6D10 0x00000001849D22C0-0x00000001849D23A0
	public float healAdd { /* [XID] */ /* 0x0000000189891FE0-0x0000000189892000 */ get => default; /* [XID] */ /* 0x00000001898999B0-0x00000001898999D0 */ protected set {} } // 0x00000001849D78F0-0x00000001849D79D0 0x00000001849D79D0-0x00000001849D7AB0
	public float healedAdd { /* [XID] */ /* 0x00000001898A0AF0-0x00000001898A0B10 */ get => default; /* [XID] */ /* 0x00000001898A81D0-0x00000001898A81F0 */ protected set {} } // 0x00000001849D7520-0x00000001849D7600 0x00000001849D68A0-0x00000001849D6980
	public byte combatConfigHashPre { /* [XID] */ /* 0x00000001898AFCD0-0x00000001898AFCF0 */ get => default; /* [XID] */ /* 0x00000001898B71F0-0x00000001898B7210 */ protected set {} } // 0x00000001849D6DB0-0x00000001849D6E60 0x00000001849D6A20-0x00000001849D6AD0
	public uint combatConfigHashSuffix { /* [XID] */ /* 0x00000001899A25F0-0x00000001899A2610 */ get => default; /* [XID] */ /* 0x00000001898C6130-0x00000001898C6150 */ protected set {} } // 0x00000001849D6F60-0x00000001849D7000 0x00000001849D1FE0-0x00000001849D2090
	public ulong combatConfigHash { /* [XID] */ /* 0x0000000189931870-0x0000000189931890 */ get => default; } // 0x00000001849CC3B0-0x00000001849CC480 
	public bool isRangeAttack { /* [XID] */ /* 0x00000001898D53F0-0x00000001898D5410 */ get => default; /* [XID] */ /* 0x00000001898DCD30-0x00000001898DCD50 */ protected set {} } // 0x00000001849D64F0-0x00000001849D65A0 0x00000001849D2210-0x00000001849D22C0
	public uint initialWeapon { /* [XID] */ /* 0x00000001898E4760-0x00000001898E4780 */ get => default; /* [XID] */ /* 0x00000001898EC150-0x00000001898EC170 */ protected set {} } // 0x00000001849D7AB0-0x00000001849D7B80 0x00000001849D65A0-0x00000001849D6680
	public WeaponType weaponType { /* [XID] */ /* 0x00000001898F39A0-0x00000001898F39C0 */ get => default; /* [XID] */ /* 0x00000001898FB0A0-0x00000001898FB0C0 */ protected set {} } // 0x00000001849D2E80-0x00000001849D2F20 0x00000001849D2680-0x00000001849D2730
	public byte manekinPathHashPre { /* [XID] */ /* 0x0000000189902BA0-0x0000000189902BC0 */ get => default; /* [XID] */ /* 0x000000018990A200-0x000000018990A220 */ protected set {} } // 0x00000001849D23A0-0x00000001849D2450 0x00000001849D7200-0x00000001849D72B0
	public uint manekinPathHashSuffix { /* [XID] */ /* 0x0000000189911BE0-0x0000000189911C00 */ get => default; /* [XID] */ /* 0x00000001899196E0-0x0000000189919700 */ protected set {} } // 0x00000001849D7160-0x00000001849D7200 0x00000001849CC300-0x00000001849CC3B0
	public ulong manekinPathHash { /* [XID] */ /* 0x0000000189920B70-0x0000000189920B90 */ get => default; } // 0x00000001849D7B80-0x00000001849D7C50 
	public string imageName { /* [XID] */ /* 0x0000000189928630-0x0000000189928650 */ get => default; /* [XID] */ /* 0x000000018992FAA0-0x000000018992FAC0 */ protected set {} } // 0x00000001849D2BC0-0x00000001849D2C70 0x00000001849CC8F0-0x00000001849CC9A0
	public byte gachaCardNameHashPre { /* [XID] */ /* 0x0000000189936FF0-0x0000000189937010 */ get => default; /* [XID] */ /* 0x000000018993EB90-0x000000018993EBB0 */ protected set {} } // 0x00000001849CC590-0x00000001849CC640 0x00000001849D7000-0x00000001849D70B0
	public uint gachaCardNameHashSuffix { /* [XID] */ /* 0x0000000189946220-0x0000000189946240 */ get => default; /* [XID] */ /* 0x000000018994D7B0-0x000000018994D7D0 */ protected set {} } // 0x00000001849D2500-0x00000001849D25A0 0x00000001849D1E60-0x00000001849D1F10
	public ulong gachaCardNameHash { /* [XID] */ /* 0x0000000189954E00-0x0000000189954E20 */ get => default; } // 0x00000001849CB6F0-0x00000001849CB7C0 
	public byte gachaImageNameHashPre { /* [XID] */ /* 0x000000018995C660-0x000000018995C680 */ get => default; /* [XID] */ /* 0x0000000189963FE0-0x0000000189964000 */ protected set {} } // 0x00000001849CB870-0x00000001849CB920 0x00000001849D7390-0x00000001849D7440
	public uint gachaImageNameHashSuffix { /* [XID] */ /* 0x000000018996B4D0-0x000000018996B4F0 */ get => default; /* [XID] */ /* 0x0000000189973030-0x0000000189973050 */ protected set {} } // 0x00000001849D7FE0-0x00000001849D8080 0x00000001849CC640-0x00000001849CC6F0
	public ulong gachaImageNameHash { /* [XID] */ /* 0x000000018997A950-0x000000018997A970 */ get => default; } // 0x00000001849CC230-0x00000001849CC300 
	public byte coopPicNameHashPre { /* [XID] */ /* 0x00000001899822E0-0x0000000189982300 */ get => default; /* [XID] */ /* 0x0000000189989AE0-0x0000000189989B00 */ protected set {} } // 0x00000001849CC7A0-0x00000001849CC850 0x00000001849D2A40-0x00000001849D2AF0
	public uint coopPicNameHashSuffix { /* [XID] */ /* 0x0000000189991330-0x0000000189991350 */ get => default; /* [XID] */ /* 0x0000000189998E70-0x0000000189998E90 */ protected set {} } // 0x00000001849D6760-0x00000001849D6800 0x00000001849D8130-0x00000001849D81E0
	public ulong coopPicNameHash { /* [XID] */ /* 0x00000001899A0670-0x00000001899A0690 */ get => default; } // 0x00000001849D28C0-0x00000001849D2990 
	public string cutsceneShow { /* [XID] */ /* 0x00000001899A8200-0x00000001899A8220 */ get => default; /* [XID] */ /* 0x00000001899AF970-0x00000001899AF990 */ protected set {} } // 0x00000001849CB7C0-0x00000001849CB870 0x00000001849D2450-0x00000001849D2500
	public uint skillDepotId { /* [XID] */ /* 0x0000000189718B00-0x0000000189718B20 */ get => default; /* [XID] */ /* 0x00000001899BE8F0-0x00000001899BE910 */ protected set {} } // 0x00000001849D2AF0-0x00000001849D2BC0 0x00000001849D7440-0x00000001849D7520
	public float staminaRecoverSpeed { /* [XID] */ /* 0x00000001899C6150-0x00000001899C6170 */ get => default; /* [XID] */ /* 0x00000001899CD890-0x00000001899CD8B0 */ protected set {} } // 0x00000001849D6680-0x00000001849D6760 0x00000001849D76B0-0x00000001849D7790
	public SimpleSafeUInt32[] candSkillDepotIds { /* [XID] */ /* 0x0000000189970180-0x00000001899701A0 */ get => default; /* [XID] */ /* 0x00000001899DC490-0x00000001899DC4B0 */ protected set {} } // 0x00000001849CBEB0-0x00000001849CBF60 0x00000001849CB640-0x00000001849CB6F0
	public byte manekinJsonConfigHashPre { /* [XID] */ /* 0x0000000189B1A0F0-0x0000000189B1A110 */ get => default; /* [XID] */ /* 0x00000001899EB0C0-0x00000001899EB0E0 */ protected set {} } // 0x00000001849D7E60-0x00000001849D7F10 0x00000001849D2990-0x00000001849D2A40
	public uint manekinJsonConfigHashSuffix { /* [XID] */ /* 0x00000001899F2D40-0x00000001899F2D60 */ get => default; /* [XID] */ /* 0x00000001899FA350-0x00000001899FA370 */ protected set {} } // 0x00000001849D6800-0x00000001849D68A0 0x00000001849D7790-0x00000001849D7840
	public ulong manekinJsonConfigHash { /* [XID] */ /* 0x0000000189B12CA0-0x0000000189B12CC0 */ get => default; } // 0x00000001849D7F10-0x00000001849D7FE0 
	public uint manekinMotionConfig { /* [XID] */ /* 0x0000000189A09190-0x0000000189A091B0 */ get => default; /* [XID] */ /* 0x0000000189A10630-0x0000000189A10650 */ protected set {} } // 0x00000001849D3220-0x00000001849D32F0 0x00000001849D72B0-0x00000001849D7390
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189A17C70-0x0000000189A17C90 */ get => default; /* [XID] */ /* 0x0000000189A1F230-0x0000000189A1F250 */ protected set {} } // 0x00000001849D6980-0x00000001849D6A20 0x00000001849CC480-0x00000001849CC530
	public string desc { /* [XID] */ /* 0x0000000189A26820-0x0000000189A26840 */ get => default; } // 0x00000001849D2C70-0x00000001849D2DF0 
	public AvatarIdentityType avatarIdentityType { /* [XID] */ /* 0x0000000189A2DB90-0x0000000189A2DBB0 */ get => default; /* [XID] */ /* 0x0000000189A35770-0x0000000189A35790 */ protected set {} } // 0x00000001849CBE10-0x00000001849CBEB0 0x00000001849CC6F0-0x00000001849CC7A0
	public uint avatarPromoteId { /* [XID] */ /* 0x0000000189A3CC20-0x0000000189A3CC40 */ get => default; /* [XID] */ /* 0x0000000189A44610-0x0000000189A44630 */ protected set {} } // 0x00000001849D1D90-0x00000001849D1E60 0x00000001849D25A0-0x00000001849D2680
	public SimpleSafeUInt32[] avatarPromoteRewardLevelList { /* [XID] */ /* 0x0000000189A4BC20-0x0000000189A4BC40 */ get => default; /* [XID] */ /* 0x0000000189A53320-0x0000000189A53340 */ protected set {} } // 0x00000001849D8080-0x00000001849D8130 0x00000001849D1CE0-0x00000001849D1D90
	public SimpleSafeUInt32[] avatarPromoteRewardIdList { /* [XID] */ /* 0x0000000189A5AAD0-0x0000000189A5AAF0 */ get => default; /* [XID] */ /* 0x0000000189A62230-0x0000000189A62250 */ protected set {} } // 0x00000001849D3170-0x00000001849D3220 0x00000001849D6B80-0x00000001849D6C30
	public uint featureTagGroupID { /* [XID] */ /* 0x0000000189A6A1B0-0x0000000189A6A1D0 */ get => default; /* [XID] */ /* 0x0000000189A71480-0x0000000189A714A0 */ protected set {} } // 0x00000001849CC0B0-0x00000001849CC180 0x00000001849D27E0-0x00000001849D28C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint infoDescTextMapHash { /* [XID] */ /* 0x0000000189A79080-0x0000000189A790A0 */ get => default; /* [XID] */ /* 0x0000000189A804E0-0x0000000189A80500 */ protected set {} } // 0x00000001849CC850-0x00000001849CC8F0 0x00000001849D2730-0x00000001849D27E0
	public string infoDesc { /* [XID] */ /* 0x0000000189A88200-0x0000000189A88220 */ get => default; } // 0x00000001849D2090-0x00000001849D2210 

	// Constructors
	public AvatarExcelConfig() {} // 0x00000001849D8280-0x00000001849D82E0

	// Methods
	// [IDTag] // 0x0000000189A8FAF0-0x0000000189A8FB30
	// [XID] // 0x0000000189A8FAF0-0x0000000189A8FB30
	public virtual bool ParseFromLine(string line) => default; // 0x00000001849CC9A0-0x00000001849CF4B0
	// [IDTag] // 0x0000000189A9A300-0x0000000189A9A340
	// [XID] // 0x0000000189A9A300-0x0000000189A9A340
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001849CF4B0-0x00000001849D1CE0
	// [XID] // 0x0000000189AA4680-0x0000000189AA46A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF701 */, bool useObjectPool = false /* Metadata: 0x00AEF705 */) => default; // 0x00000001849D32F0-0x00000001849D64F0
	[BlackList] // 0x0000000189AABD50-0x0000000189AABD90
	// [XID] // 0x0000000189AABD50-0x0000000189AABD90
	public override void AutoAllocTypeFields() {} // 0x00000001849CB920-0x00000001849CB9C0
	[BlackList] // 0x0000000189AB66A0-0x0000000189AB66E0
	// [XID] // 0x0000000189AB66A0-0x0000000189AB66E0
	public override void AutoRecycleTypeFields() {} // 0x00000001849CB9C0-0x00000001849CBC20
	[BlackList] // 0x0000000189AC0FB0-0x0000000189AC0FF0
	// [XID] // 0x0000000189AC0FB0-0x0000000189AC0FF0
	public override void ReturnToObjectPool() {} // 0x00000001849D81E0-0x00000001849D8280
}

