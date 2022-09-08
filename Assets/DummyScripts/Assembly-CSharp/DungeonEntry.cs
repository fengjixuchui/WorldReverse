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
public class DungeonEntry : SceneTransPoint, IAutoAllocRecycle // TypeDefIndex: 14976
{
	// Fields
	private SimpleSafeUInt32[] _dungeonIds; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DungeonQuestCondition _dungeonQuestConditionList; // 0x80
	private MoleMole.Config.Vector _size; // 0x88
	private SimpleSafeUInt32 worktopGroupIdRawNum; // 0x94
	private string _titleTextID; // 0x98
	private SimpleSafeInt32 showLevelRawNum; // 0xA0
	private SimpleSafeUInt32[] _dungeonRandomList; // 0xA8
	private DungeonEntryType _dungeonEntryType; // 0xB0
	private PointMapVisibility _mapVisibility; // 0xB4
	private bool _forbidSimpleUnlock; // 0xB8
	private bool _fireFieldEvent; // 0xB9
	private SimpleSafeUInt32[] _dungeonRosterList; // 0xC0
	private bool _removeEntityIfLocked; // 0xC8

	// Properties
	public override RealScenePointType pointType { /* [XID] */ /* 0x000000018961C740-0x000000018961C760 */ get => default; } // 0x000000018459DE50-0x000000018459DEF0 
	public SimpleSafeUInt32[] dungeonIds { /* [XID] */ /* 0x0000000189623BA0-0x0000000189623BC0 */ get => default; /* [XID] */ /* 0x000000018962B480-0x000000018962B4A0 */ private set {} } // 0x000000018459BEB0-0x000000018459BF50 0x000000018459E6B0-0x000000018459E760
	public DungeonQuestCondition dungeonQuestConditionList { /* [XID] */ /* 0x0000000189632BC0-0x0000000189632BE0 */ get => default; /* [XID] */ /* 0x000000018963A610-0x000000018963A630 */ private set {} } // 0x000000018459DEF0-0x000000018459DFA0 0x000000018459E300-0x000000018459E3B0
	public MoleMole.Config.Vector size { /* [XID] */ /* 0x0000000189641D80-0x0000000189641DA0 */ get => default; /* [XID] */ /* 0x00000001896495E0-0x0000000189649600 */ private set {} } // 0x000000018459F2C0-0x000000018459F3A0 0x000000018459D9A0-0x000000018459DA70
	public uint worktopGroupId { /* [XID] */ /* 0x0000000189650C70-0x0000000189650C90 */ get => default; /* [XID] */ /* 0x00000001896584D0-0x00000001896584F0 */ private set {} } // 0x000000018459CCA0-0x000000018459CD70 0x000000018459E5D0-0x000000018459E6B0
	public string titleTextID { /* [XID] */ /* 0x000000018965FA00-0x000000018965FA20 */ get => default; /* [XID] */ /* 0x00000001896674B0-0x00000001896674D0 */ private set {} } // 0x000000018459F160-0x000000018459F210 0x000000018459F6C0-0x000000018459F770
	public int showLevel { /* [XID] */ /* 0x000000018966ECC0-0x000000018966ECE0 */ get => default; /* [XID] */ /* 0x00000001896766C0-0x00000001896766E0 */ private set {} } // 0x000000018459BC20-0x000000018459BCF0 0x000000018459D4B0-0x000000018459D590
	public SimpleSafeUInt32[] dungeonRandomList { /* [XID] */ /* 0x000000018967DEA0-0x000000018967DEC0 */ get => default; /* [XID] */ /* 0x00000001896856A0-0x00000001896856C0 */ private set {} } // 0x000000018459DFA0-0x000000018459E050 0x000000018459CAC0-0x000000018459CB70
	public DungeonEntryType dungeonEntryType { /* [XID] */ /* 0x000000018968D080-0x000000018968D0A0 */ get => default; /* [XID] */ /* 0x0000000189694C80-0x0000000189694CA0 */ private set {} } // 0x000000018459D590-0x000000018459D630 0x000000018459A5E0-0x000000018459A690
	public PointMapVisibility mapVisibility { /* [XID] */ /* 0x000000018969C3E0-0x000000018969C400 */ get => default; /* [XID] */ /* 0x00000001896A3880-0x00000001896A38A0 */ private set {} } // 0x000000018459BB80-0x000000018459BC20 0x000000018459BF50-0x000000018459C000
	public bool forbidSimpleUnlock { /* [XID] */ /* 0x000000018998CCE0-0x000000018998CD00 */ get => default; /* [XID] */ /* 0x00000001896B1D50-0x00000001896B1D70 */ private set {} } // 0x000000018459CBF0-0x000000018459CCA0 0x000000018459C080-0x000000018459C130
	public bool fireFieldEvent { /* [XID] */ /* 0x00000001896B97F0-0x00000001896B9810 */ get => default; /* [XID] */ /* 0x00000001896C0B00-0x00000001896C0B20 */ private set {} } // 0x000000018459B8E0-0x000000018459B990 0x000000018459D400-0x000000018459D4B0
	public SimpleSafeUInt32[] dungeonRosterList { /* [XID] */ /* 0x00000001896C8230-0x00000001896C8250 */ get => default; /* [XID] */ /* 0x00000001896CFB90-0x00000001896CFBB0 */ private set {} } // 0x000000018459BD50-0x000000018459BE00 0x000000018459F610-0x000000018459F6C0
	public bool removeEntityIfLocked { /* [XID] */ /* 0x00000001896D6E20-0x00000001896D6E40 */ get => default; /* [XID] */ /* 0x00000001896DE600-0x00000001896DE620 */ private set {} } // 0x000000018459BE00-0x000000018459BEB0 0x000000018459F210-0x000000018459F2C0

	// Constructors
	public DungeonEntry() {} // 0x000000018459F810-0x000000018459F8D0

	// Methods
	// [XID] // 0x00000001896E59D0-0x00000001896E59F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018459F3A0-0x000000018459F610
	// [XID] // 0x00000001896ECFE0-0x00000001896ED000
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018459E410-0x000000018459E560
	// [XID] // 0x00000001896F48A0-0x00000001896F48C0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD28 */) => default; // 0x000000018459DD70-0x000000018459DE50
	// [XID] // 0x00000001896FC0D0-0x00000001896FC0F0
	public override int GetHashNum() => default; // 0x000000018459BAB0-0x000000018459BB80
	// [XID] // 0x00000001897036D0-0x00000001897036F0
	public override void InitEmpty() {} // 0x000000018459D630-0x000000018459D7D0
	[BlackList] // 0x000000018970AD00-0x000000018970AD40
	// [XID] // 0x000000018970AD00-0x000000018970AD40
	public override bool FromJson(JSONNode node) => default; // 0x000000018459CDF0-0x000000018459D170
	// [XID] // 0x0000000189715290-0x00000001897152B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018459A710-0x000000018459B380
	[BlackList] // 0x000000018971CD80-0x000000018971CDC0
	// [XID] // 0x000000018971CD80-0x000000018971CDC0
	public static new DungeonEntry ParseFromJson(JSONNode node) => default; // 0x000000018459E0B0-0x000000018459E300
	// [XID] // 0x00000001897273E0-0x0000000189727400
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD29 */, bool useObjectPool = false /* Metadata: 0x00AEFD2D */) => default; // 0x000000018459DA70-0x000000018459DD70
	// [XID] // 0x000000018972E950-0x000000018972E970
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD2E */, bool useObjectPool = false /* Metadata: 0x00AEFD32 */) => default; // 0x000000018459C130-0x000000018459CAC0
	// [XID] // 0x00000001897360C0-0x00000001897360E0
	public static new DungeonEntry ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD33 */, bool useObjectPool = false /* Metadata: 0x00AEFD37 */) => default; // 0x000000018459D170-0x000000018459D390
	[BlackList] // 0x000000018973DDB0-0x000000018973DDF0
	// [XID] // 0x000000018973DDB0-0x000000018973DDF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018459B380-0x000000018459B650
	// [XID] // 0x00000001897482E0-0x0000000189748300
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018459E760-0x000000018459F160
	[BlackList] // 0x000000018974FB90-0x000000018974FBD0
	// [XID] // 0x000000018974FB90-0x000000018974FBD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018459D8B0-0x000000018459D9A0
	[BlackList] // 0x0000000189759D00-0x0000000189759D40
	// [XID] // 0x0000000189759D00-0x0000000189759D40
	public override void AutoAllocTypeFields() {} // 0x000000018459B650-0x000000018459B6F0
	[BlackList] // 0x0000000189764580-0x00000001897645C0
	// [XID] // 0x0000000189764580-0x00000001897645C0
	public override void AutoRecycleTypeFields() {} // 0x000000018459B6F0-0x000000018459B8E0
	[BlackList] // 0x000000018976EB40-0x000000018976EB80
	// [XID] // 0x000000018976EB40-0x000000018976EB80
	public override void ReturnToObjectPool() {} // 0x000000018459F770-0x000000018459F810
}

