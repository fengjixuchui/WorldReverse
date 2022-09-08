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
public class ConfigMainQuestBrief : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18812
{
	// Fields
	private uint _id; // 0x10
	private uint _series; // 0x14
	private QuestType _type; // 0x18
	private MainQuestTagType _mainQuestTag; // 0x1C
	private uint titleTextMapHash; // 0x20
	private uint descTextMapHash; // 0x24
	private uint _recommendLevel; // 0x28
	private uint[] _suggestTrackMainQuestList; // 0x30
	private uint[] _rewardIdList; // 0x38
	private QuestShowType _showType; // 0x40
	private uint _chapterId; // 0x44
	private uint _taskID; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigQuestScheme[] _subQuests; // 0x50

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899144A0-0x00000001899144C0 */ get => default; /* [XID] */ /* 0x000000018991BF80-0x000000018991BFA0 */ private set {} } // 0x0000000183161E00-0x0000000183161EA0 0x0000000183160890-0x0000000183160940
	public uint series { /* [XID] */ /* 0x0000000189923680-0x00000001899236A0 */ get => default; /* [XID] */ /* 0x000000018992ACE0-0x000000018992AD00 */ private set {} } // 0x000000018315FF10-0x000000018315FFB0 0x000000018315F180-0x000000018315F230
	public QuestType type { /* [XID] */ /* 0x0000000189932320-0x0000000189932340 */ get => default; /* [XID] */ /* 0x0000000189939CD0-0x0000000189939CF0 */ private set {} } // 0x0000000183161EA0-0x0000000183161F40 0x0000000183161000-0x00000001831610B0
	public MainQuestTagType mainQuestTag { /* [XID] */ /* 0x0000000189940EC0-0x0000000189940EE0 */ get => default; /* [XID] */ /* 0x00000001899489A0-0x00000001899489C0 */ private set {} } // 0x0000000183160EB0-0x0000000183160F50 0x0000000183160640-0x00000001831606F0
	public string title { /* [XID] */ /* 0x00000001899500F0-0x0000000189950110 */ get => default; } // 0x0000000183160D90-0x0000000183160EB0 
	public string desc { /* [XID] */ /* 0x0000000189957640-0x0000000189957660 */ get => default; } // 0x0000000183160520-0x0000000183160640 
	public uint recommendLevel { /* [XID] */ /* 0x000000018964B0A0-0x000000018964B0C0 */ get => default; /* [XID] */ /* 0x00000001899668F0-0x0000000189966910 */ private set {} } // 0x000000018315F230-0x000000018315F2D0 0x0000000183160CE0-0x0000000183160D90
	public uint[] suggestTrackMainQuestList { /* [XID] */ /* 0x00000001896692E0-0x0000000189669300 */ get => default; /* [XID] */ /* 0x00000001899758D0-0x00000001899758F0 */ private set {} } // 0x0000000183161160-0x0000000183161200 0x000000018315FFB0-0x0000000183160060
	public uint[] rewardIdList { /* [XID] */ /* 0x0000000189696C90-0x0000000189696CB0 */ get => default; /* [XID] */ /* 0x00000001899847B0-0x00000001899847D0 */ private set {} } // 0x0000000183160C40-0x0000000183160CE0 0x00000001831610B0-0x0000000183161160
	public QuestShowType showType { /* [XID] */ /* 0x000000018998C1F0-0x000000018998C210 */ get => default; /* [XID] */ /* 0x0000000189993F10-0x0000000189993F30 */ private set {} } // 0x0000000183160060-0x0000000183160100 0x000000018315F0D0-0x000000018315F180
	public uint chapterId { /* [XID] */ /* 0x00000001896E0450-0x00000001896E0470 */ get => default; /* [XID] */ /* 0x00000001899A2EB0-0x00000001899A2ED0 */ private set {} } // 0x000000018315FE70-0x000000018315FF10 0x000000018315F4B0-0x000000018315F560
	public uint taskID { /* [XID] */ /* 0x00000001896C9CF0-0x00000001896C9D10 */ get => default; /* [XID] */ /* 0x00000001899B2310-0x00000001899B2330 */ private set {} } // 0x0000000183160480-0x0000000183160520 0x000000018315F560-0x000000018315F610
	public ConfigQuestScheme[] subQuests { /* [XID] */ /* 0x00000001899B96D0-0x00000001899B96F0 */ get => default; /* [XID] */ /* 0x00000001899C10F0-0x00000001899C1110 */ private set {} } // 0x00000001831606F0-0x0000000183160790 0x0000000183160F50-0x0000000183161000

	// Constructors
	public ConfigMainQuestBrief() {} // 0x0000000183161FE0-0x0000000183162040

	// Methods
	// [XID] // 0x00000001899C8700-0x00000001899C8720
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183161AA0-0x0000000183161CC0
	// [XID] // 0x00000001899D0130-0x00000001899D0150
	public void InitEmpty() {} // 0x0000000183160790-0x0000000183160890
	[BlackList] // 0x00000001899D7590-0x00000001899D75D0
	// [XID] // 0x00000001899D7590-0x00000001899D75D0
	public bool FromJson(JSONNode node) => default; // 0x0000000183160100-0x0000000183160480
	// [XID] // 0x0000000189A35B00-0x0000000189A35B20
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018315E180-0x000000018315EC90
	// [XID] // 0x00000001898B4560-0x00000001898B4580
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD89 */, bool useObjectPool = false /* Metadata: 0x00AFAD8D */) => default; // 0x0000000183160940-0x0000000183160C40
	// [XID] // 0x00000001898CB050-0x00000001898CB070
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD8E */, bool useObjectPool = false /* Metadata: 0x00AFAD92 */) => default; // 0x000000018315F610-0x000000018315FE70
	[BlackList] // 0x00000001899F8370-0x00000001899F83B0
	// [XID] // 0x00000001899F8370-0x00000001899F83B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018315EC90-0x000000018315EF60
	// [XID] // 0x0000000189A02990-0x0000000189A029B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183161200-0x0000000183161AA0
	[BlackList] // 0x0000000189A0A100-0x0000000189A0A140
	// [XID] // 0x0000000189A0A100-0x0000000189A0A140
	public virtual void AutoAllocTypeFields() {} // 0x000000018315EF60-0x000000018315F000
	[BlackList] // 0x0000000189A14800-0x0000000189A14840
	// [XID] // 0x0000000189A14800-0x0000000189A14840
	public virtual void AutoRecycleTypeFields() {} // 0x000000018315F000-0x000000018315F0D0
	[BlackList] // 0x0000000189A1EA50-0x0000000189A1EA90
	// [XID] // 0x0000000189A1EA50-0x0000000189A1EA90
	public virtual void ReturnToObjectPool() {} // 0x0000000183161F40-0x0000000183161FE0
	[BlackList] // 0x0000000189A28EE0-0x0000000189A28F20
	// [XID] // 0x0000000189A28EE0-0x0000000189A28F20
	public virtual void OnPoolAllocated() {} // 0x0000000183161D60-0x0000000183161E00
	[BlackList] // 0x0000000189A333C0-0x0000000189A33400
	// [XID] // 0x0000000189A333C0-0x0000000189A33400
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183161CC0-0x0000000183161D60
	// [XID] // 0x0000000189A3DDD0-0x0000000189A3DDF0
	public ConfigMainQuestScheme ToScheme(ConfigMainQuestScheme config = null) => default; // 0x000000018315F2D0-0x000000018315F4B0
}

