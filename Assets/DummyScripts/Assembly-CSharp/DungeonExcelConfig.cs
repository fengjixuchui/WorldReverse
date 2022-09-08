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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class DungeonExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14864
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected uint _displayNameTextMapHash; // 0x18
	protected uint _descTextMapHash; // 0x1C
	protected DungeonType _type; // 0x20
	protected bool _isDynamicLevel; // 0x24
	protected SimpleSafeUInt32 serialIdRawNum; // 0x28
	protected DungeonPlayType _playType; // 0x2C
	protected SimpleSafeUInt32 sceneIdRawNum; // 0x30
	protected SimpleSafeUInt32 eventIntervalRawNum; // 0x34
	protected InvolveType _involveType; // 0x38
	protected SimpleSafeUInt32 showLevelRawNum; // 0x3C
	protected SimpleSafeUInt32 avatarLimitTypeRawNum; // 0x40
	protected SimpleSafeUInt32 limitLevelRawNum; // 0x44
	protected SimpleSafeInt32 levelReviseRawNum; // 0x48
	protected SimpleSafeUInt32 prevDungeonIdRawNum; // 0x4C
	protected SimpleSafeUInt32 requireAvatarIdRawNum; // 0x50
	protected SimpleSafeUInt32 passCondRawNum; // 0x54
	protected SimpleSafeUInt32 passJumpDungeonRawNum; // 0x58
	protected SimpleSafeUInt32 reviveIntervalTimeRawNum; // 0x5C
	protected SimpleSafeUInt32 reviveMaxCountRawNum; // 0x60
	protected SimpleSafeUInt32 dayEnterCountRawNum; // 0x64
	protected IdCountConfig[] _enterCostItems; // 0x68
	protected SimpleSafeUInt32 firstPassRewardPreviewIDRawNum; // 0x70
	protected SimpleSafeUInt32 passRewardPreviewIDRawNum; // 0x74
	protected SimpleSafeUInt32 settleCountdownTimeRawNum; // 0x78
	protected SimpleSafeUInt32 failSettleCountdownTimeRawNum; // 0x7C
	protected SimpleSafeUInt32 quitSettleCountdownTimeRawNum; // 0x80
	protected SettleShowType[] _settleShows; // 0x88
	protected bool _forbiddenRestart; // 0x90
	protected SettleUIType _settleUIType; // 0x94
	protected SimpleSafeUInt32 statueCostIDRawNum; // 0x98
	protected SimpleSafeUInt32 statueCostCountRawNum; // 0x9C
	protected SimpleSafeUInt32 statueDropRawNum; // 0xA0
	protected ElementType[] _recommendElementTypes; // 0xA8
	protected Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> _levelConfigMap; // 0xB0
	protected SimpleSafeUInt32 cityIDRawNum; // 0xB8
	protected bool _dontShowPushTips; // 0xBC
	protected string _entryPicPath; // 0xC0
	protected DungeonStateType _stateType; // 0xC8

	// Properties
	public bool hasProgress { /* [XID] */ /* 0x000000018968BB30-0x000000018968BB50 */ get => default; } // 0x0000000183DB4F70-0x0000000183DB5020 
	public bool hasCountDown { /* [XID] */ /* 0x0000000189693740-0x0000000189693760 */ get => default; } // 0x0000000183DB8AD0-0x0000000183DB8B80 
	public string mappedDesc { /* [XID] */ /* 0x00000001896B81F0-0x00000001896B8210 */ get => default; } // 0x0000000183DB4250-0x0000000183DB4300 
	public uint id { /* [XID] */ /* 0x00000001896C6BB0-0x00000001896C6BD0 */ get => default; /* [XID] */ /* 0x00000001896CE270-0x00000001896CE290 */ protected set {} } // 0x0000000183DB8FF0-0x0000000183DB90C0 0x0000000183DB5B30-0x0000000183DB5C10
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001896D5820-0x00000001896D5840 */ get => default; /* [XID] */ /* 0x00000001896DCCC0-0x00000001896DCCE0 */ protected set {} } // 0x0000000183DAFFE0-0x0000000183DB0080 0x0000000183DB8050-0x0000000183DB8100
	public string name { /* [XID] */ /* 0x00000001896E4650-0x00000001896E4670 */ get => default; } // 0x0000000183DB9430-0x0000000183DB95B0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint displayNameTextMapHash { /* [XID] */ /* 0x00000001896EBA80-0x00000001896EBAA0 */ get => default; /* [XID] */ /* 0x00000001896F3090-0x00000001896F30B0 */ protected set {} } // 0x0000000183DB4300-0x0000000183DB43A0 0x0000000183DB4EC0-0x0000000183DB4F70
	public string displayName { /* [XID] */ /* 0x00000001896FA830-0x00000001896FA850 */ get => default; } // 0x0000000183DB8950-0x0000000183DB8AD0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189701EC0-0x0000000189701EE0 */ get => default; /* [XID] */ /* 0x0000000189709720-0x0000000189709740 */ protected set {} } // 0x0000000183DB7E20-0x0000000183DB7EC0 0x0000000183DB02E0-0x0000000183DB0390
	public string desc { /* [XID] */ /* 0x0000000189711050-0x0000000189711070 */ get => default; } // 0x0000000183DB5380-0x0000000183DB5500 
	public DungeonType type { /* [XID] */ /* 0x0000000189718450-0x0000000189718470 */ get => default; /* [XID] */ /* 0x000000018971FD70-0x000000018971FD90 */ protected set {} } // 0x0000000183DB9190-0x0000000183DB9230 0x0000000183DB88A0-0x0000000183DB8950
	public bool isDynamicLevel { /* [XID] */ /* 0x000000018974BB30-0x000000018974BB50 */ get => default; /* [XID] */ /* 0x000000018972E9B0-0x000000018972E9D0 */ protected set {} } // 0x0000000183DB4620-0x0000000183DB46C0 0x0000000183DB5500-0x0000000183DB55B0
	public uint serialId { /* [XID] */ /* 0x0000000189736120-0x0000000189736140 */ get => default; /* [XID] */ /* 0x000000018973DE90-0x000000018973DEB0 */ protected set {} } // 0x0000000183DB46C0-0x0000000183DB4790 0x0000000183DB0390-0x0000000183DB0470
	public DungeonPlayType playType { /* [XID] */ /* 0x00000001897452D0-0x00000001897452F0 */ get => default; /* [XID] */ /* 0x000000018974CDC0-0x000000018974CDE0 */ protected set {} } // 0x0000000183DB9390-0x0000000183DB9430 0x0000000183DAFF30-0x0000000183DAFFE0
	public uint sceneId { /* [XID] */ /* 0x0000000189754140-0x0000000189754160 */ get => default; /* [XID] */ /* 0x000000018975B540-0x000000018975B560 */ protected set {} } // 0x0000000183DB5EB0-0x0000000183DB5F80 0x0000000183DB8100-0x0000000183DB81E0
	public uint eventInterval { /* [XID] */ /* 0x0000000189763010-0x0000000189763030 */ get => default; /* [XID] */ /* 0x000000018976A610-0x000000018976A630 */ protected set {} } // 0x0000000183DB8380-0x0000000183DB8450 0x0000000183DB8450-0x0000000183DB8530
	public InvolveType involveType { /* [XID] */ /* 0x0000000189771D90-0x0000000189771DB0 */ get => default; /* [XID] */ /* 0x0000000189779540-0x0000000189779560 */ protected set {} } // 0x0000000183DB8730-0x0000000183DB87D0 0x0000000183DB8530-0x0000000183DB85E0
	public uint showLevel { /* [XID] */ /* 0x0000000189780E20-0x0000000189780E40 */ get => default; /* [XID] */ /* 0x0000000189788360-0x0000000189788380 */ protected set {} } // 0x0000000183DB0210-0x0000000183DB02E0 0x0000000183DB57E0-0x0000000183DB58C0
	public uint avatarLimitType { /* [XID] */ /* 0x000000018978F920-0x000000018978F940 */ get => default; /* [XID] */ /* 0x0000000189797110-0x0000000189797130 */ protected set {} } // 0x0000000183DB82B0-0x0000000183DB8380 0x0000000183DB4540-0x0000000183DB4620
	public uint limitLevel { /* [XID] */ /* 0x000000018979F170-0x000000018979F190 */ get => default; /* [XID] */ /* 0x00000001897A6800-0x00000001897A6820 */ protected set {} } // 0x0000000183DB8DE0-0x0000000183DB8EB0 0x0000000183DB5DD0-0x0000000183DB5EB0
	public int levelRevise { /* [XID] */ /* 0x00000001897ADE30-0x00000001897ADE50 */ get => default; /* [XID] */ /* 0x00000001897B5F10-0x00000001897B5F30 */ protected set {} } // 0x0000000183DB4790-0x0000000183DB4860 0x0000000183DB4C50-0x0000000183DB4D30
	public uint prevDungeonId { /* [XID] */ /* 0x00000001897BDD20-0x00000001897BDD40 */ get => default; /* [XID] */ /* 0x00000001897C50E0-0x00000001897C5100 */ protected set {} } // 0x0000000183DB4470-0x0000000183DB4540 0x0000000183DB4DE0-0x0000000183DB4EC0
	public uint requireAvatarId { /* [XID] */ /* 0x00000001897CC930-0x00000001897CC950 */ get => default; /* [XID] */ /* 0x00000001897D4100-0x00000001897D4120 */ protected set {} } // 0x0000000183DB40D0-0x0000000183DB41A0 0x0000000183DB5C10-0x0000000183DB5CF0
	public uint passCond { /* [XID] */ /* 0x00000001897DB9F0-0x00000001897DBA10 */ get => default; /* [XID] */ /* 0x00000001897E3300-0x00000001897E3320 */ protected set {} } // 0x0000000183DB43A0-0x0000000183DB4470 0x0000000183DB3D60-0x0000000183DB3E40
	public uint passJumpDungeon { /* [XID] */ /* 0x00000001897EAA60-0x00000001897EAA80 */ get => default; /* [XID] */ /* 0x00000001897F27D0-0x00000001897F27F0 */ protected set {} } // 0x0000000183DB06D0-0x0000000183DB07A0 0x0000000183DB5970-0x0000000183DB5A50
	public uint reviveIntervalTime { /* [XID] */ /* 0x00000001897F9FC0-0x00000001897F9FE0 */ get => default; /* [XID] */ /* 0x0000000189801580-0x00000001898015A0 */ protected set {} } // 0x0000000183DAF7F0-0x0000000183DAF8C0 0x0000000183DB0080-0x0000000183DB0160
	public uint reviveMaxCount { /* [XID] */ /* 0x0000000189808A20-0x0000000189808A40 */ get => default; /* [XID] */ /* 0x00000001898103F0-0x0000000189810410 */ protected set {} } // 0x0000000183DB87D0-0x0000000183DB88A0 0x0000000183DAFE50-0x0000000183DAFF30
	public uint dayEnterCount { /* [XID] */ /* 0x0000000189817B00-0x0000000189817B20 */ get => default; /* [XID] */ /* 0x000000018981F3A0-0x000000018981F3C0 */ protected set {} } // 0x0000000183DB3F20-0x0000000183DB3FF0 0x0000000183DB52A0-0x0000000183DB5380
	public IdCountConfig[] enterCostItems { /* [XID] */ /* 0x0000000189826890-0x00000001898268B0 */ get => default; /* [XID] */ /* 0x000000018982DFE0-0x000000018982E000 */ protected set {} } // 0x0000000183DB85E0-0x0000000183DB8680 0x0000000183DB4D30-0x0000000183DB4DE0
	public uint firstPassRewardPreviewID { /* [XID] */ /* 0x0000000189835670-0x0000000189835690 */ get => default; /* [XID] */ /* 0x000000018983CE10-0x000000018983CE30 */ protected set {} } // 0x0000000183DB81E0-0x0000000183DB82B0 0x0000000183DB0550-0x0000000183DB0630
	public uint passRewardPreviewID { /* [XID] */ /* 0x0000000189844480-0x00000001898444A0 */ get => default; /* [XID] */ /* 0x000000018984B910-0x000000018984B930 */ protected set {} } // 0x0000000183DAF4E0-0x0000000183DAF5B0 0x0000000183DB5A50-0x0000000183DB5B30
	public uint settleCountdownTime { /* [XID] */ /* 0x0000000189852960-0x0000000189852980 */ get => default; /* [XID] */ /* 0x000000018985A3D0-0x000000018985A3F0 */ protected set {} } // 0x0000000183DB49F0-0x0000000183DB4AC0 0x0000000183DB3E40-0x0000000183DB3F20
	public uint failSettleCountdownTime { /* [XID] */ /* 0x00000001898615F0-0x0000000189861610 */ get => default; /* [XID] */ /* 0x0000000189868DD0-0x0000000189868DF0 */ protected set {} } // 0x0000000183DB8B80-0x0000000183DB8C50 0x0000000183DB5CF0-0x0000000183DB5DD0
	public uint quitSettleCountdownTime { /* [XID] */ /* 0x0000000189870200-0x0000000189870220 */ get => default; /* [XID] */ /* 0x0000000189877850-0x0000000189877870 */ protected set {} } // 0x0000000183DB5020-0x0000000183DB50F0 0x0000000183DB4910-0x0000000183DB49F0
	public SettleShowType[] settleShows { /* [XID] */ /* 0x000000018987F140-0x000000018987F160 */ get => default; /* [XID] */ /* 0x0000000189886740-0x0000000189886760 */ protected set {} } // 0x0000000183DB95B0-0x0000000183DB9660 0x0000000183DB8D30-0x0000000183DB8DE0
	public bool forbiddenRestart { /* [XID] */ /* 0x000000018988D8E0-0x000000018988D900 */ get => default; /* [XID] */ /* 0x0000000189894FF0-0x0000000189895010 */ protected set {} } // 0x0000000183DB7C00-0x0000000183DB7CB0 0x0000000183DB58C0-0x0000000183DB5970
	public SettleUIType settleUIType { /* [XID] */ /* 0x000000018989C660-0x000000018989C680 */ get => default; /* [XID] */ /* 0x00000001898A3E00-0x00000001898A3E20 */ protected set {} } // 0x0000000183DB7CB0-0x0000000183DB7D50 0x0000000183DB8680-0x0000000183DB8730
	public uint statueCostID { /* [XID] */ /* 0x00000001898AB040-0x00000001898AB060 */ get => default; /* [XID] */ /* 0x00000001898B2950-0x00000001898B2970 */ protected set {} } // 0x0000000183DB51D0-0x0000000183DB52A0 0x0000000183DB50F0-0x0000000183DB51D0
	public uint statueCostCount { /* [XID] */ /* 0x00000001898BA7E0-0x00000001898BA800 */ get => default; /* [XID] */ /* 0x00000001898C1960-0x00000001898C1980 */ protected set {} } // 0x0000000183DB7D50-0x0000000183DB7E20 0x0000000183DB8C50-0x0000000183DB8D30
	public uint statueDrop { /* [XID] */ /* 0x00000001898C92E0-0x00000001898C9300 */ get => default; /* [XID] */ /* 0x00000001898D0B40-0x00000001898D0B60 */ protected set {} } // 0x0000000183DAF5B0-0x0000000183DAF680 0x0000000183DB0470-0x0000000183DB0550
	public ElementType[] recommendElementTypes { /* [XID] */ /* 0x00000001898D8260-0x00000001898D8280 */ get => default; /* [XID] */ /* 0x00000001898E00E0-0x00000001898E0100 */ protected set {} } // 0x0000000183DB4860-0x0000000183DB4910 0x0000000183DAFDA0-0x0000000183DAFE50
	public Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> levelConfigMap { /* [XID] */ /* 0x00000001898E7B90-0x00000001898E7BB0 */ get => default; /* [XID] */ /* 0x00000001898EF2A0-0x00000001898EF2C0 */ protected set {} } // 0x0000000183DB4BA0-0x0000000183DB4C50 0x0000000183DB0160-0x0000000183DB0210
	public uint cityID { /* [XID] */ /* 0x00000001898F6B20-0x00000001898F6B40 */ get => default; /* [XID] */ /* 0x00000001898FE240-0x00000001898FE260 */ protected set {} } // 0x0000000183DB90C0-0x0000000183DB9190 0x0000000183DB3FF0-0x0000000183DB40D0
	public bool dontShowPushTips { /* [XID] */ /* 0x0000000189905B00-0x0000000189905B20 */ get => default; /* [XID] */ /* 0x000000018990D3B0-0x000000018990D3D0 */ protected set {} } // 0x0000000183DB9230-0x0000000183DB92E0 0x0000000183DB41A0-0x0000000183DB4250
	public string entryPicPath { /* [XID] */ /* 0x0000000189914B20-0x0000000189914B40 */ get => default; /* [XID] */ /* 0x000000018991C860-0x000000018991C880 */ protected set {} } // 0x0000000183DAF740-0x0000000183DAF7F0 0x0000000183DB5730-0x0000000183DB57E0
	public DungeonStateType stateType { /* [XID] */ /* 0x0000000189923F60-0x0000000189923F80 */ get => default; /* [XID] */ /* 0x000000018992B4C0-0x000000018992B4E0 */ protected set {} } // 0x0000000183DB0630-0x0000000183DB06D0 0x0000000183DB92E0-0x0000000183DB9390

	// Constructors
	public DungeonExcelConfig() {} // 0x0000000183DB9700-0x0000000183DB9760

	// Methods
	// [XID] // 0x000000018969AAD0-0x000000018969AAF0
	public bool NeedShowSettleUI(bool success) => default; // 0x0000000183DB4AC0-0x0000000183DB4BA0
	// [XID] // 0x00000001896A2520-0x00000001896A2540
	public uint GetDungeonLevel() => default; // 0x0000000183DAFC60-0x0000000183DAFDA0
	// [XID] // 0x00000001896A9700-0x00000001896A9720
	public bool isOneoffDungeon() => default; // 0x0000000183DAF680-0x0000000183DAF740
	// [XID] // 0x00000001896B0810-0x00000001896B0830
	public int GetLevelRevise() => default; // 0x0000000183DB7EC0-0x0000000183DB8050
	// [XID] // 0x00000001896BF270-0x00000001896BF290
	public static int DungeonDisplayOrder(DungeonExcelConfig dungeon1, DungeonExcelConfig dungeon2) => default; // 0x0000000183DB55B0-0x0000000183DB5730
	// [IDTag] // 0x0000000189932C00-0x0000000189932C40
	// [XID] // 0x0000000189932C00-0x0000000189932C40
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183DB2170-0x0000000183DB3D60
	// [IDTag] // 0x000000018993D3D0-0x000000018993D410
	// [XID] // 0x000000018993D3D0-0x000000018993D410
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183DB07A0-0x0000000183DB2170
	// [XID] // 0x0000000189947720-0x0000000189947740
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF82F */, bool useObjectPool = false /* Metadata: 0x00AEF833 */) => default; // 0x0000000183DB5F80-0x0000000183DB7C00
	[BlackList] // 0x000000018994EFA0-0x000000018994EFE0
	// [XID] // 0x000000018994EFA0-0x000000018994EFE0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183DAF8C0-0x0000000183DAF960
	[BlackList] // 0x0000000189959650-0x0000000189959690
	// [XID] // 0x0000000189959650-0x0000000189959690
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183DAF960-0x0000000183DAFC60
	[BlackList] // 0x0000000189963FA0-0x0000000189963FE0
	// [XID] // 0x0000000189963FA0-0x0000000189963FE0
	public virtual void ReturnToObjectPool() {} // 0x0000000183DB9660-0x0000000183DB9700
	[BlackList] // 0x000000018996E3C0-0x000000018996E400
	// [XID] // 0x000000018996E3C0-0x000000018996E400
	public virtual void OnPoolAllocated() {} // 0x0000000183DB8F50-0x0000000183DB8FF0
	[BlackList] // 0x0000000189979470-0x00000001899794B0
	// [XID] // 0x0000000189979470-0x00000001899794B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183DB8EB0-0x0000000183DB8F50
}

