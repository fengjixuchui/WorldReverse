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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMainQuestScheme : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18811
{
	// Fields
	private uint _id; // 0x10
	private uint _series; // 0x14
	private QuestType _type; // 0x18
	private MainQuestTagType _mainQuestTag; // 0x1C
	private PlayMode _activeMode; // 0x20
	public uint titleTextMapHash; // 0x24
	public uint descTextMapHash; // 0x28
	private string _luaPath; // 0x30
	private uint _recommendLevel; // 0x38
	private bool _repeatable; // 0x3C
	private uint[] _suggestTrackMainQuestList; // 0x40
	private bool _suggestTrackOutOfOrder; // 0x48
	private uint[] _rewardIdList; // 0x50
	private QuestShowType _showType; // 0x58
	private uint _chapterId; // 0x5C
	private uint _taskID; // 0x60
	private bool _showRedPoint; // 0x64
	private uint _activityId; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigQuestScheme[] _subQuests; // 0x70
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigTalkScheme[] _talks; // 0x78
	private ulong[] _preloadLuaList; // 0x80
	private ulong[] _forcePreloadLuaList; // 0x88
	private Dictionary<uint, int[]> _freeStyleDic; // 0x90

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189678550-0x0000000189678570 */ get => default; /* [XID] */ /* 0x000000018973EFA0-0x000000018973EFC0 */ set {} } // 0x000000018460EFE0-0x000000018460F080 0x000000018460CDA0-0x000000018460CE50
	public uint series { /* [XID] */ /* 0x000000018967FDB0-0x000000018967FDD0 */ get => default; /* [XID] */ /* 0x000000018974DD90-0x000000018974DDB0 */ set {} } // 0x000000018460BE50-0x000000018460BEF0 0x000000018460AC40-0x000000018460ACF0
	public QuestType type { /* [XID] */ /* 0x0000000189755430-0x0000000189755450 */ get => default; /* [XID] */ /* 0x0000000189643A00-0x0000000189643A20 */ set {} } // 0x000000018460F120-0x000000018460F1C0 0x000000018460D9F0-0x000000018460DAA0
	public MainQuestTagType mainQuestTag { /* [XID] */ /* 0x0000000189763EC0-0x0000000189763EE0 */ get => default; /* [XID] */ /* 0x000000018976B720-0x000000018976B740 */ set {} } // 0x000000018460D660-0x000000018460D700 0x000000018460C990-0x000000018460CA40
	public PlayMode activeMode { /* [XID] */ /* 0x0000000189772CC0-0x0000000189772CE0 */ get => default; /* [XID] */ /* 0x000000018977A380-0x000000018977A3A0 */ private set {} } // 0x000000018460EBA0-0x000000018460EC40 0x000000018460CB90-0x000000018460CC40
	public string title { /* [XID] */ /* 0x0000000189781FC0-0x0000000189781FE0 */ get => default; } // 0x000000018460D540-0x000000018460D660 
	public string desc { /* [XID] */ /* 0x0000000189789360-0x0000000189789380 */ get => default; } // 0x000000018460C870-0x000000018460C990 
	public string luaPath { /* [XID] */ /* 0x00000001897909D0-0x00000001897909F0 */ get => default; /* [XID] */ /* 0x0000000189798380-0x00000001897983A0 */ private set {} } // 0x000000018460F080-0x000000018460F120 0x000000018460C520-0x000000018460C5D0
	public uint recommendLevel { /* [XID] */ /* 0x00000001897A0190-0x00000001897A01B0 */ get => default; /* [XID] */ /* 0x000000018968F2A0-0x000000018968F2C0 */ set {} } // 0x000000018460ADA0-0x000000018460AE40 0x000000018460D340-0x000000018460D3F0
	public bool repeatable { /* [XID] */ /* 0x00000001897AF170-0x00000001897AF190 */ get => default; /* [XID] */ /* 0x00000001897B6F10-0x00000001897B6F30 */ private set {} } // 0x000000018460DC00-0x000000018460DCA0 0x000000018460D890-0x000000018460D940
	public uint[] suggestTrackMainQuestList { /* [XID] */ /* 0x00000001897BEDF0-0x00000001897BEE10 */ get => default; /* [XID] */ /* 0x0000000189670D50-0x0000000189670D70 */ set {} } // 0x000000018460DCA0-0x000000018460DD40 0x000000018460BEF0-0x000000018460BFA0
	public bool suggestTrackOutOfOrder { /* [XID] */ /* 0x00000001897CDBE0-0x00000001897CDC00 */ get => default; /* [XID] */ /* 0x00000001897D50B0-0x00000001897D50D0 */ private set {} } // 0x000000018460D3F0-0x000000018460D490 0x000000018460C0F0-0x000000018460C1A0
	public uint[] rewardIdList { /* [XID] */ /* 0x00000001897DC8D0-0x00000001897DC8F0 */ get => default; /* [XID] */ /* 0x00000001896B3EF0-0x00000001896B3F10 */ set {} } // 0x000000018460D2A0-0x000000018460D340 0x000000018460DAA0-0x000000018460DB50
	public QuestShowType showType { /* [XID] */ /* 0x00000001897EBE60-0x00000001897EBE80 */ get => default; /* [XID] */ /* 0x00000001896D8C10-0x00000001896D8C30 */ set {} } // 0x000000018460C050-0x000000018460C0F0 0x000000018460AB90-0x000000018460AC40
	public uint chapterId { /* [XID] */ /* 0x00000001897FB170-0x00000001897FB190 */ get => default; /* [XID] */ /* 0x00000001898025C0-0x00000001898025E0 */ set {} } // 0x000000018460BDB0-0x000000018460BE50 0x000000018460AE40-0x000000018460AEF0
	public uint taskID { /* [XID] */ /* 0x0000000189A35AC0-0x0000000189A35AE0 */ get => default; /* [XID] */ /* 0x0000000189811220-0x0000000189811240 */ set {} } // 0x000000018460C680-0x000000018460C720 0x000000018460AEF0-0x000000018460AFA0
	public bool showRedPoint { /* [XID] */ /* 0x0000000189818CF0-0x0000000189818D10 */ get => default; /* [XID] */ /* 0x00000001898205B0-0x00000001898205D0 */ set {} } // 0x000000018460CE50-0x000000018460CEF0 0x000000018460D1F0-0x000000018460D2A0
	public uint activityId { /* [XID] */ /* 0x0000000189827C00-0x0000000189827C20 */ get => default; /* [XID] */ /* 0x000000018982EEC0-0x000000018982EEE0 */ set {} } // 0x000000018460D700-0x000000018460D7A0 0x000000018460CAE0-0x000000018460CB90
	public ConfigQuestScheme[] subQuests { /* [XID] */ /* 0x0000000189836790-0x00000001898367B0 */ get => default; /* [XID] */ /* 0x0000000189661740-0x0000000189661760 */ set {} } // 0x000000018460CA40-0x000000018460CAE0 0x000000018460D940-0x000000018460D9F0
	public ConfigTalkScheme[] talks { /* [XID] */ /* 0x0000000189845370-0x0000000189845390 */ get => default; /* [XID] */ /* 0x000000018984C840-0x000000018984C860 */ private set {} } // 0x000000018460C7D0-0x000000018460C870 0x000000018460EC40-0x000000018460ECF0
	public ulong[] preloadLuaList { /* [XID] */ /* 0x0000000189853980-0x00000001898539A0 */ get => default; /* [XID] */ /* 0x000000018985B450-0x000000018985B470 */ private set {} } // 0x000000018460C720-0x000000018460C7D0 0x000000018460DB50-0x000000018460DC00
	public ulong[] forcePreloadLuaList { /* [XID] */ /* 0x00000001898629F0-0x0000000189862A10 */ get => default; /* [XID] */ /* 0x0000000189869E00-0x0000000189869E20 */ private set {} } // 0x000000018460C5D0-0x000000018460C680 0x000000018460F1C0-0x000000018460F270
	public Dictionary<uint, int[]> freeStyleDic { /* [XID] */ /* 0x00000001898711F0-0x0000000189871210 */ get => default; /* [XID] */ /* 0x0000000189878B30-0x0000000189878B50 */ private set {} } // 0x000000018460ACF0-0x000000018460ADA0 0x000000018460BFA0-0x000000018460C050
	public uint defaultRewardID { /* [XID] */ /* 0x00000001898F63C0-0x00000001898F63E0 */ get => default; } // 0x000000018460D7A0-0x000000018460D890 

	// Constructors
	public ConfigMainQuestScheme() {} // 0x000000018460F310-0x000000018460F380

	// Methods
	// [XID] // 0x0000000189880160-0x0000000189880180
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018460ECF0-0x000000018460EEA0
	// [XID] // 0x0000000189887640-0x0000000189887660
	public void InitEmpty() {} // 0x000000018460CC40-0x000000018460CDA0
	[BlackList] // 0x000000018988E940-0x000000018988E980
	// [XID] // 0x000000018988E940-0x000000018988E980
	public bool FromJson(JSONNode node) => default; // 0x000000018460C1A0-0x000000018460C520
	// [XID] // 0x0000000189899190-0x00000001898991B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184609410-0x000000018460A710
	// [XID] // 0x00000001898A0350-0x00000001898A0370
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD7F */, bool useObjectPool = false /* Metadata: 0x00AFAD83 */) => default; // 0x000000018460CEF0-0x000000018460D1F0
	// [XID] // 0x00000001898A7AB0-0x00000001898A7AD0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD84 */, bool useObjectPool = false /* Metadata: 0x00AFAD88 */) => default; // 0x000000018460AFA0-0x000000018460BDB0
	[BlackList] // 0x00000001898AF670-0x00000001898AF6B0
	// [XID] // 0x00000001898AF670-0x00000001898AF6B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018460A710-0x000000018460A9E0
	// [XID] // 0x00000001898BA000-0x00000001898BA020
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018460DD40-0x000000018460EBA0
	[BlackList] // 0x00000001898C1300-0x00000001898C1340
	// [XID] // 0x00000001898C1300-0x00000001898C1340
	public virtual void AutoAllocTypeFields() {} // 0x000000018460A9E0-0x000000018460AA80
	[BlackList] // 0x00000001898CB9F0-0x00000001898CBA30
	// [XID] // 0x00000001898CB9F0-0x00000001898CBA30
	public virtual void AutoRecycleTypeFields() {} // 0x000000018460AA80-0x000000018460AB90
	[BlackList] // 0x00000001898D6340-0x00000001898D6380
	// [XID] // 0x00000001898D6340-0x00000001898D6380
	public virtual void ReturnToObjectPool() {} // 0x000000018460F270-0x000000018460F310
	[BlackList] // 0x00000001898E1060-0x00000001898E10A0
	// [XID] // 0x00000001898E1060-0x00000001898E10A0
	public virtual void OnPoolAllocated() {} // 0x000000018460EF40-0x000000018460EFE0
	[BlackList] // 0x00000001898EBA70-0x00000001898EBAB0
	// [XID] // 0x00000001898EBA70-0x00000001898EBAB0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018460EEA0-0x000000018460EF40
	// [XID] // 0x00000001898FDB80-0x00000001898FDBA0
	public void ToBrief() {} // 0x000000018460D490-0x000000018460D540
}

