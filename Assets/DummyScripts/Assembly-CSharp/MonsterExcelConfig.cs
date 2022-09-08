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
public class MonsterExcelConfig : CreatureExcelConfig, IAutoAllocRecycle // TypeDefIndex: 15842
{
	// Fields
	protected string _monsterName; // 0xB8
	protected MonsterType _type; // 0xC0
	protected MonsterSecurityLevel _securityLevel; // 0xC4
	protected byte _scriptDataPathHashPre; // 0xC8
	protected uint _scriptDataPathHashSuffix; // 0xCC
	protected string _serverScript; // 0xD0
	protected byte _combatConfigHashPre; // 0xD8
	protected uint _combatConfigHashSuffix; // 0xDC
	protected SimpleSafeUInt32[] _affix; // 0xE0
	protected string _ai; // 0xE8
	protected bool _isAIHashCheck; // 0xF0
	protected SimpleSafeUInt32[] _equips; // 0xF8
	protected bool _canSwim; // 0x100
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected MonsterDrop[] _hpDrops; // 0x108
	protected SimpleSafeUInt32 killDropIdRawNum; // 0x110
	protected bool _isSceneReward; // 0x114
	protected VisionLevelType _visionLevel; // 0x118
	protected bool _isInvisibleReset; // 0x11C
	protected string _excludeWeathers; // 0x120
	protected SimpleSafeUInt32 featureTagGroupIDRawNum; // 0x128
	protected SimpleSafeUInt32 mpPropIDRawNum; // 0x12C
	protected string _skin; // 0x130
	protected SimpleSafeUInt32 describeIdRawNum; // 0x138
	protected bool _safetyCheck; // 0x13C
	protected SimpleSafeInt32 combatBGMLevelRawNum; // 0x140
	protected SimpleSafeInt32 entityBudgetLevelRawNum; // 0x144

	// Properties
	public string monsterName { /* [XID] */ /* 0x0000000189728910-0x0000000189728930 */ get => default; /* [XID] */ /* 0x0000000189730080-0x00000001897300A0 */ protected set {} } // 0x0000000182140550-0x0000000182140600 0x00000001821403F0-0x00000001821404A0
	public MonsterType type { /* [XID] */ /* 0x0000000189737A00-0x0000000189737A20 */ get => default; /* [XID] */ /* 0x000000018973F4E0-0x000000018973F500 */ protected set {} } // 0x00000001821409C0-0x0000000182140A60 0x0000000182140290-0x0000000182140340
	public MonsterSecurityLevel securityLevel { /* [XID] */ /* 0x0000000189ADE680-0x0000000189ADE6A0 */ get => default; /* [XID] */ /* 0x000000018974E230-0x000000018974E250 */ protected set {} } // 0x000000018213FCC0-0x000000018213FD60 0x00000001821377A0-0x0000000182137850
	public byte scriptDataPathHashPre { /* [XID] */ /* 0x00000001897558B0-0x00000001897558D0 */ get => default; /* [XID] */ /* 0x000000018975CBD0-0x000000018975CBF0 */ protected set {} } // 0x0000000182137290-0x0000000182137340 0x000000018213FC10-0x000000018213FCC0
	public uint scriptDataPathHashSuffix { /* [XID] */ /* 0x00000001897643A0-0x00000001897643C0 */ get => default; /* [XID] */ /* 0x000000018976BCE0-0x000000018976BD00 */ protected set {} } // 0x000000018213FF20-0x000000018213FFC0 0x0000000182137620-0x00000001821376D0
	public ulong scriptDataPathHash { /* [XID] */ /* 0x00000001897732A0-0x00000001897732C0 */ get => default; } // 0x000000018213C590-0x000000018213C660 
	public string serverScript { /* [XID] */ /* 0x000000018977A860-0x000000018977A880 */ get => default; /* [XID] */ /* 0x00000001897824A0-0x00000001897824C0 */ protected set {} } // 0x000000018213C380-0x000000018213C430 0x000000018213C4E0-0x000000018213C590
	public byte combatConfigHashPre { /* [XID] */ /* 0x0000000189789780-0x00000001897897A0 */ get => default; /* [XID] */ /* 0x0000000189790EF0-0x0000000189790F10 */ protected set {} } // 0x000000018213FE10-0x000000018213FEC0 0x000000018213FB60-0x000000018213FC10
	public uint combatConfigHashSuffix { /* [XID] */ /* 0x0000000189798700-0x0000000189798720 */ get => default; /* [XID] */ /* 0x00000001897A0590-0x00000001897A05B0 */ protected set {} } // 0x0000000182140090-0x0000000182140130 0x000000018213C660-0x000000018213C710
	public ulong combatConfigHash { /* [XID] */ /* 0x00000001897A7B40-0x00000001897A7B60 */ get => default; } // 0x0000000182137850-0x0000000182137920 
	public SimpleSafeUInt32[] affix { /* [XID] */ /* 0x00000001897AF590-0x00000001897AF5B0 */ get => default; /* [XID] */ /* 0x00000001897B74D0-0x00000001897B74F0 */ protected set {} } // 0x000000018213CC40-0x000000018213CCF0 0x0000000182140910-0x00000001821409C0
	public string ai { /* [XID] */ /* 0x00000001897BF370-0x00000001897BF390 */ get => default; /* [XID] */ /* 0x00000001897C69C0-0x00000001897C69E0 */ protected set {} } // 0x0000000182140130-0x00000001821401E0 0x00000001821406B0-0x0000000182140760
	public bool isAIHashCheck { /* [XID] */ /* 0x00000001897CE1A0-0x00000001897CE1C0 */ get => default; /* [XID] */ /* 0x00000001897D56D0-0x00000001897D56F0 */ protected set {} } // 0x000000018213CCF0-0x000000018213CDA0 0x000000018213C430-0x000000018213C4E0
	public SimpleSafeUInt32[] equips { /* [XID] */ /* 0x000000018986AB10-0x000000018986AB30 */ get => default; /* [XID] */ /* 0x00000001897E4750-0x00000001897E4770 */ protected set {} } // 0x0000000182137A60-0x0000000182137B10 0x00000001821401E0-0x0000000182140290
	public bool canSwim { /* [XID] */ /* 0x00000001897EC300-0x00000001897EC320 */ get => default; /* [XID] */ /* 0x00000001897F3CB0-0x00000001897F3CD0 */ protected set {} } // 0x0000000182140600-0x00000001821406B0 0x00000001821404A0-0x0000000182140550
	public MonsterDrop[] hpDrops { /* [XID] */ /* 0x00000001897FB6D0-0x00000001897FB6F0 */ get => default; /* [XID] */ /* 0x0000000189802AE0-0x0000000189802B00 */ protected set {} } // 0x0000000182140A60-0x0000000182140B10 0x0000000182137570-0x0000000182137620
	public uint killDropId { /* [XID] */ /* 0x000000018980A110-0x000000018980A130 */ get => default; /* [XID] */ /* 0x0000000189811740-0x0000000189811760 */ protected set {} } // 0x00000001821371C0-0x0000000182137290 0x0000000182136D90-0x0000000182136E70
	public bool isSceneReward { /* [XID] */ /* 0x00000001898193B0-0x00000001898193D0 */ get => default; /* [XID] */ /* 0x0000000189820B90-0x0000000189820BB0 */ protected set {} } // 0x000000018213C2D0-0x000000018213C380 0x0000000182137B10-0x0000000182137BC0
	public VisionLevelType visionLevel { /* [XID] */ /* 0x0000000189828140-0x0000000189828160 */ get => default; /* [XID] */ /* 0x000000018982F3E0-0x000000018982F400 */ protected set {} } // 0x0000000182140B10-0x0000000182140BB0 0x0000000182140340-0x00000001821403F0
	public bool isInvisibleReset { /* [XID] */ /* 0x0000000189836CD0-0x0000000189836CF0 */ get => default; /* [XID] */ /* 0x000000018983E100-0x000000018983E120 */ protected set {} } // 0x000000018213C7E0-0x000000018213C890 0x000000018213FD60-0x000000018213FE10
	public string excludeWeathers { /* [XID] */ /* 0x00000001898458D0-0x00000001898458F0 */ get => default; /* [XID] */ /* 0x000000018984CE80-0x000000018984CEA0 */ protected set {} } // 0x000000018213CB00-0x000000018213CBB0 0x000000018213CE00-0x000000018213CEB0
	public uint featureTagGroupID { /* [XID] */ /* 0x0000000189853FA0-0x0000000189853FC0 */ get => default; /* [XID] */ /* 0x000000018985B9B0-0x000000018985B9D0 */ protected set {} } // 0x00000001821376D0-0x00000001821377A0 0x000000018213CA20-0x000000018213CB00
	public uint mpPropID { /* [XID] */ /* 0x00000001896E32A0-0x00000001896E32C0 */ get => default; /* [XID] */ /* 0x000000018986A400-0x000000018986A420 */ protected set {} } // 0x000000018213C710-0x000000018213C7E0 0x0000000182140760-0x0000000182140840
	public string skin { /* [XID] */ /* 0x0000000189871830-0x0000000189871850 */ get => default; /* [XID] */ /* 0x00000001898790F0-0x0000000189879110 */ protected set {} } // 0x000000018213C970-0x000000018213CA20 0x000000018213CEB0-0x000000018213CF60
	public uint describeId { /* [XID] */ /* 0x00000001898806A0-0x00000001898806C0 */ get => default; /* [XID] */ /* 0x0000000189887C40-0x0000000189887C60 */ protected set {} } // 0x0000000182140840-0x0000000182140910 0x000000018213C890-0x000000018213C970
	public bool safetyCheck { /* [XID] */ /* 0x000000018988EFC0-0x000000018988EFE0 */ get => default; /* [XID] */ /* 0x00000001898964C0-0x00000001898964E0 */ protected set {} } // 0x00000001821374C0-0x0000000182137570 0x0000000182136E70-0x0000000182136F20
	public int combatBGMLevel { /* [XID] */ /* 0x000000018989DAC0-0x000000018989DAE0 */ get => default; /* [XID] */ /* 0x00000001898A53A0-0x00000001898A53C0 */ protected set {} } // 0x000000018213FFC0-0x0000000182140090 0x00000001821373E0-0x00000001821374C0
	public int entityBudgetLevel { /* [XID] */ /* 0x00000001898AC9A0-0x00000001898AC9C0 */ get => default; /* [XID] */ /* 0x00000001898B3E60-0x00000001898B3E80 */ protected set {} } // 0x000000018213FA90-0x000000018213FB60 0x0000000182137980-0x0000000182137A60

	// Constructors
	public MonsterExcelConfig() {} // 0x0000000182140C50-0x0000000182140CB0

	// Methods
	// [IDTag] // 0x00000001898BBAF0-0x00000001898BBB30
	// [XID] // 0x00000001898BBAF0-0x00000001898BBB30
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182139DE0-0x000000018213C2D0
	// [IDTag] // 0x00000001898C5F30-0x00000001898C5F70
	// [XID] // 0x00000001898C5F30-0x00000001898C5F70
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182137BC0-0x0000000182139DE0
	// [XID] // 0x00000001898D09A0-0x00000001898D09C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF281D */, bool useObjectPool = false /* Metadata: 0x00AF2821 */) => default; // 0x000000018213CF60-0x000000018213FA90
	[BlackList] // 0x00000001898D8040-0x00000001898D8080
	// [XID] // 0x00000001898D8040-0x00000001898D8080
	public override void AutoAllocTypeFields() {} // 0x0000000182136F20-0x0000000182136FC0
	[BlackList] // 0x00000001898E2C80-0x00000001898E2CC0
	// [XID] // 0x00000001898E2C80-0x00000001898E2CC0
	public override void AutoRecycleTypeFields() {} // 0x0000000182136FC0-0x00000001821371C0
	[BlackList] // 0x00000001898ED780-0x00000001898ED7C0
	// [XID] // 0x00000001898ED780-0x00000001898ED7C0
	public override void ReturnToObjectPool() {} // 0x0000000182140BB0-0x0000000182140C50
}

