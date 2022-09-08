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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigCodexQuest : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17665
{
	// Fields
	private SimpleSafeUInt32 mainQuestIdRawNum; // 0x10
	private QuestType _questType; // 0x14
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCodexQuestText _mainQuestTitle; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCodexQuestText _mainQuestDesp; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCodexQuestText _chapterTitle; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCodexQuestText _chapterNum; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCodexQuestSubQuest[] _subQuests; // 0x38

	// Properties
	public uint mainQuestId { /* [XID] */ /* 0x0000000189725620-0x0000000189725640 */ get => default; /* [XID] */ /* 0x000000018972CBA0-0x000000018972CBC0 */ private set {} } // 0x00000001842DF3F0-0x00000001842DF4C0 0x00000001842DDEF0-0x00000001842DDFD0
	public QuestType questType { /* [XID] */ /* 0x0000000189734350-0x0000000189734370 */ get => default; /* [XID] */ /* 0x000000018973BC20-0x000000018973BC40 */ private set {} } // 0x00000001842DE650-0x00000001842DE6F0 0x00000001842DEE40-0x00000001842DEEF0
	public ConfigCodexQuestText mainQuestTitle { /* [XID] */ /* 0x00000001897434F0-0x0000000189743510 */ get => default; /* [XID] */ /* 0x000000018974B160-0x000000018974B180 */ private set {} } // 0x00000001842DEB10-0x00000001842DEBB0 0x00000001842DFE50-0x00000001842DFF00
	public ConfigCodexQuestText mainQuestDesp { /* [XID] */ /* 0x00000001897521B0-0x00000001897521D0 */ get => default; /* [XID] */ /* 0x0000000189759820-0x0000000189759840 */ private set {} } // 0x00000001842DEBB0-0x00000001842DEC50 0x00000001842DF4C0-0x00000001842DF570
	public ConfigCodexQuestText chapterTitle { /* [XID] */ /* 0x00000001897613D0-0x00000001897613F0 */ get => default; /* [XID] */ /* 0x0000000189768740-0x0000000189768760 */ private set {} } // 0x00000001842DEA70-0x00000001842DEB10 0x00000001842DF290-0x00000001842DF340
	public ConfigCodexQuestText chapterNum { /* [XID] */ /* 0x000000018976FE30-0x000000018976FE50 */ get => default; /* [XID] */ /* 0x0000000189777630-0x0000000189777650 */ private set {} } // 0x00000001842DEEF0-0x00000001842DEF90 0x00000001842DDE40-0x00000001842DDEF0
	public ConfigCodexQuestSubQuest[] subQuests { /* [XID] */ /* 0x000000018977ED20-0x000000018977ED40 */ get => default; /* [XID] */ /* 0x0000000189786700-0x0000000189786720 */ private set {} } // 0x00000001842DEC50-0x00000001842DECF0 0x00000001842DF340-0x00000001842DF3F0

	// Constructors
	public ConfigCodexQuest() {} // 0x00000001842DFFA0-0x00000001842E0000

	// Methods
	// [XID] // 0x000000018978DD50-0x000000018978DD70
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842DFB30-0x00000001842DFD10
	// [XID] // 0x00000001897953A0-0x00000001897953C0
	public void InitEmpty() {} // 0x00000001842DECF0-0x00000001842DEE40
	[BlackList] // 0x000000018979D730-0x000000018979D770
	// [XID] // 0x000000018979D730-0x000000018979D770
	public bool FromJson(JSONNode node) => default; // 0x00000001842DE6F0-0x00000001842DEA70
	// [XID] // 0x00000001897A78E0-0x00000001897A7900
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001842DD060-0x00000001842DD820
	// [XID] // 0x00000001897AF330-0x00000001897AF350
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76DF */, bool useObjectPool = false /* Metadata: 0x00AF76E3 */) => default; // 0x00000001842DEF90-0x00000001842DF290
	// [XID] // 0x00000001897B71D0-0x00000001897B71F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76E4 */, bool useObjectPool = false /* Metadata: 0x00AF76E8 */) => default; // 0x00000001842DDFD0-0x00000001842DE650
	[BlackList] // 0x00000001897BEFB0-0x00000001897BEFF0
	// [XID] // 0x00000001897BEFB0-0x00000001897BEFF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001842DD820-0x00000001842DDAF0
	// [XID] // 0x00000001897C9620-0x00000001897C9640
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842DF570-0x00000001842DFB30
	[BlackList] // 0x00000001897D0C10-0x00000001897D0C50
	// [XID] // 0x00000001897D0C10-0x00000001897D0C50
	public virtual void AutoAllocTypeFields() {} // 0x00000001842DDAF0-0x00000001842DDB90
	[BlackList] // 0x00000001897DB5F0-0x00000001897DB630
	// [XID] // 0x00000001897DB5F0-0x00000001897DB630
	public virtual void AutoRecycleTypeFields() {} // 0x00000001842DDB90-0x00000001842DDE40
	[BlackList] // 0x00000001897E5D50-0x00000001897E5D90
	// [XID] // 0x00000001897E5D50-0x00000001897E5D90
	public virtual void ReturnToObjectPool() {} // 0x00000001842DFF00-0x00000001842DFFA0
	[BlackList] // 0x00000001897F0900-0x00000001897F0940
	// [XID] // 0x00000001897F0900-0x00000001897F0940
	public virtual void OnPoolAllocated() {} // 0x00000001842DFDB0-0x00000001842DFE50
	[BlackList] // 0x00000001897FB310-0x00000001897FB350
	// [XID] // 0x00000001897FB310-0x00000001897FB350
	public virtual void OnBeforePoolRecycled() {} // 0x00000001842DFD10-0x00000001842DFDB0
}

