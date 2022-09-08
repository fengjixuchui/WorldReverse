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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ConfigAISkill : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17501
{
	// Fields
	private string _name; // 0x10
	private ConfigAISkillType _skillType; // 0x18
	private ConfigAICombatSkillType _combatSkillType; // 0x1C
	private SimpleSafeInt32 priorityRawNum; // 0x20
	private bool _needLineOfSight; // 0x24
	private bool _faceTarget; // 0x25
	private bool _canUseIfTargetInactive; // 0x26
	private bool _enableSkillPrepare; // 0x27
	private SimpleSafeFloat skillPrepareTimeoutRawNum; // 0x28
	private SimpleSafeInt32 skillPrepareSpeedLevelRawNum; // 0x2C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISkillCastCondition _castCondition; // 0x30
	private SimpleSafeFloat cdRawNum; // 0x38
	private SimpleSafeFloat cdUpperRangeRawNum; // 0x3C
	private SimpleSafeFloat initialCDRawNum; // 0x40
	private SimpleSafeFloat initialCDUpperRangeRawNum; // 0x44
	private string _publicCDGroup; // 0x48
	private bool _ignoreGCD; // 0x50
	private bool _triggerGCD; // 0x51
	private bool _triggerCDOnStart; // 0x52
	private SimpleSafeInt32 skillGroupCDIDRawNum; // 0x54
	private string[] _stateIDs; // 0x58
	private SimpleSafeFloat skillQueryingTimeRawNum; // 0x60
	private SimpleSafeInt32 commandIDRawNum; // 0x64
	private string _flagTargetReachable; // 0x68
	private string _flagSelfOnTemplateCollider; // 0x70
	private string _flagSelfInZone; // 0x78
	private string _flagTargetInZone; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBuddySkillCondition _buddySkillCondition; // 0x88
	private NeuronName[] _nerveTrigger; // 0x90
	public static Action<ConfigAISkill, bool> postProcessData; // 0x00
	public static Action<ConfigAISkill> postInitEmpty; // 0x08
	[BlackList] // 0x0000000189B4D810-0x0000000189B4D840
	[JsonIgnore] // 0x0000000189B4D810-0x0000000189B4D840
	public uint skillID; // 0x98
	[BlackList] // 0x0000000189B2B220-0x0000000189B2B270
	[JsonIgnore] // 0x0000000189B2B220-0x0000000189B2B270
	// [PooledField] // 0x0000000189B2B220-0x0000000189B2B270
	public HashSet<byte> belongEliteSet; // 0xA0
	[BlackList] // 0x0000000189B58380-0x0000000189B583B0
	[JsonIgnore] // 0x0000000189B58380-0x0000000189B583B0
	public AIBitsFlag bitsFlagTargetReachable; // 0xA8
	[BlackList] // 0x0000000189B4D810-0x0000000189B4D840
	[JsonIgnore] // 0x0000000189B4D810-0x0000000189B4D840
	public AIBitsFlag bitsFlagSelfInZone; // 0xAA
	[BlackList] // 0x0000000189B4D810-0x0000000189B4D840
	[JsonIgnore] // 0x0000000189B4D810-0x0000000189B4D840
	public AIBitsFlag bitsFlagTargetInZone; // 0xAC
	[BlackList] // 0x0000000189B58380-0x0000000189B583B0
	[JsonIgnore] // 0x0000000189B58380-0x0000000189B583B0
	public AIBitsFlag bitsFlagSelfOnTemplateCollider; // 0xAE
	[BlackList] // 0x0000000189B625F0-0x0000000189B62640
	[JsonIgnore] // 0x0000000189B625F0-0x0000000189B62640
	// [PooledField] // 0x0000000189B625F0-0x0000000189B62640
	public List<int> iStateIDs; // 0xB0

	// Properties
	public string name { /* [XID] */ /* 0x0000000189B7E9E0-0x0000000189B7EA00 */ get => default; /* [XID] */ /* 0x0000000189B86680-0x0000000189B866A0 */ private set {} } // 0x0000000183208690-0x0000000183208730 0x0000000183204CD0-0x0000000183204D80
	public ConfigAISkillType skillType { /* [XID] */ /* 0x0000000189B8D790-0x0000000189B8D7B0 */ get => default; /* [XID] */ /* 0x0000000189B94D90-0x0000000189B94DB0 */ private set {} } // 0x0000000183202AB0-0x0000000183202B50 0x0000000183202950-0x0000000183202A00
	public ConfigAICombatSkillType combatSkillType { /* [XID] */ /* 0x0000000189B9C500-0x0000000189B9C520 */ get => default; /* [XID] */ /* 0x0000000189BA3AF0-0x0000000189BA3B10 */ private set {} } // 0x0000000183205D60-0x0000000183205E00 0x0000000183205F40-0x0000000183205FF0
	public int priority { /* [XID] */ /* 0x0000000189BAAF80-0x0000000189BAAFA0 */ get => default; /* [XID] */ /* 0x0000000189BB25D0-0x0000000189BB25F0 */ private set {} } // 0x0000000183205850-0x0000000183205920 0x0000000183203F40-0x0000000183204020
	public bool needLineOfSight { /* [XID] */ /* 0x0000000189B69510-0x0000000189B69530 */ get => default; /* [XID] */ /* 0x0000000189BC1900-0x0000000189BC1920 */ private set {} } // 0x0000000183206680-0x0000000183206720 0x00000001832041B0-0x0000000183204260
	public bool faceTarget { /* [XID] */ /* 0x0000000189BC8FC0-0x0000000189BC8FE0 */ get => default; /* [XID] */ /* 0x0000000189BD0870-0x0000000189BD0890 */ private set {} } // 0x0000000183202B50-0x0000000183202BF0 0x0000000183205010-0x00000001832050C0
	public bool canUseIfTargetInactive { /* [XID] */ /* 0x0000000189B77FB0-0x0000000189B77FD0 */ get => default; /* [XID] */ /* 0x0000000189BDF9A0-0x0000000189BDF9C0 */ private set {} } // 0x0000000183205920-0x00000001832059C0 0x0000000183202A00-0x0000000183202AB0
	public bool enableSkillPrepare { /* [XID] */ /* 0x00000001895EC4D0-0x00000001895EC4F0 */ get => default; /* [XID] */ /* 0x00000001895F3930-0x00000001895F3950 */ private set {} } // 0x00000001832065E0-0x0000000183206680 0x0000000183202800-0x00000001832028B0
	public float skillPrepareTimeout { /* [XID] */ /* 0x00000001895FB230-0x00000001895FB250 */ get => default; /* [XID] */ /* 0x0000000189602A10-0x0000000189602A30 */ private set {} } // 0x0000000183202BF0-0x0000000183202CD0 0x0000000183206290-0x0000000183206370
	public int skillPrepareSpeedLevel { /* [XID] */ /* 0x000000018964E260-0x000000018964E280 */ get => default; /* [XID] */ /* 0x0000000189611AE0-0x0000000189611B00 */ private set {} } // 0x0000000183205440-0x0000000183205510 0x0000000183203E60-0x0000000183203F40
	public ConfigAISkillCastCondition castCondition { /* [XID] */ /* 0x000000018992FF30-0x000000018992FF50 */ get => default; /* [XID] */ /* 0x00000001896209C0-0x00000001896209E0 */ private set {} } // 0x0000000183208270-0x0000000183208310 0x0000000183206530-0x00000001832065E0
	public float cd { /* [XID] */ /* 0x0000000189627ED0-0x0000000189627EF0 */ get => default; /* [XID] */ /* 0x000000018962F7E0-0x000000018962F800 */ private set {} } // 0x0000000183206450-0x0000000183206530 0x00000001832049E0-0x0000000183204AC0
	public float cdUpperRange { /* [XID] */ /* 0x0000000189672720-0x0000000189672740 */ get => default; /* [XID] */ /* 0x000000018963E880-0x000000018963E8A0 */ private set {} } // 0x00000001832060D0-0x00000001832061B0 0x0000000183204020-0x0000000183204100
	public float initialCD { /* [XID] */ /* 0x0000000189646020-0x0000000189646040 */ get => default; /* [XID] */ /* 0x000000018964D860-0x000000018964D880 */ private set {} } // 0x0000000183205C80-0x0000000183205D60 0x00000001832056A0-0x0000000183205780
	public float initialCDUpperRange { /* [XID] */ /* 0x0000000189655000-0x0000000189655020 */ get => default; /* [XID] */ /* 0x000000018965C880-0x000000018965C8A0 */ private set {} } // 0x0000000183205FF0-0x00000001832060D0 0x00000001832061B0-0x0000000183206290
	public string publicCDGroup { /* [XID] */ /* 0x0000000189663DE0-0x0000000189663E00 */ get => default; /* [XID] */ /* 0x000000018966B520-0x000000018966B540 */ private set {} } // 0x0000000183205EA0-0x0000000183205F40 0x0000000183204100-0x00000001832041B0
	public bool ignoreGCD { /* [XID] */ /* 0x0000000189673260-0x0000000189673280 */ get => default; /* [XID] */ /* 0x000000018967A980-0x000000018967A9A0 */ private set {} } // 0x00000001832083F0-0x0000000183208490 0x00000001832020B0-0x0000000183202160
	public bool triggerGCD { /* [XID] */ /* 0x0000000189682210-0x0000000189682230 */ get => default; /* [XID] */ /* 0x0000000189689C10-0x0000000189689C30 */ private set {} } // 0x0000000183204260-0x0000000183204300 0x0000000183204C20-0x0000000183204CD0
	public bool triggerCDOnStart { /* [XID] */ /* 0x00000001895EFD80-0x00000001895EFDA0 */ get => default; /* [XID] */ /* 0x0000000189699000-0x0000000189699020 */ private set {} } // 0x00000001832006C0-0x0000000183200760 0x00000001832055F0-0x00000001832056A0
	public int skillGroupCDID { /* [XID] */ /* 0x00000001897E7DB0-0x00000001897E7DD0 */ get => default; /* [XID] */ /* 0x00000001896A7AC0-0x00000001896A7AE0 */ private set {} } // 0x0000000183205780-0x0000000183205850 0x0000000183205510-0x00000001832055F0
	public string[] stateIDs { /* [XID] */ /* 0x00000001896AEE90-0x00000001896AEEB0 */ get => default; /* [XID] */ /* 0x00000001896B6500-0x00000001896B6520 */ private set {} } // 0x0000000183208490-0x0000000183208530 0x0000000183208530-0x00000001832085E0
	public float skillQueryingTime { /* [XID] */ /* 0x00000001896BD7E0-0x00000001896BD800 */ get => default; /* [XID] */ /* 0x00000001896C4F30-0x00000001896C4F50 */ private set {} } // 0x0000000183206370-0x0000000183206450 0x0000000183204700-0x00000001832047E0
	public int commandID { /* [XID] */ /* 0x000000018986F160-0x000000018986F180 */ get => default; /* [XID] */ /* 0x00000001896D3640-0x00000001896D3660 */ private set {} } // 0x0000000183206720-0x00000001832067F0 0x0000000183208310-0x00000001832083F0
	public string flagTargetReachable { /* [XID] */ /* 0x00000001896DB180-0x00000001896DB1A0 */ get => default; /* [XID] */ /* 0x00000001896E28A0-0x00000001896E28C0 */ private set {} } // 0x0000000183205E00-0x0000000183205EA0 0x00000001832067F0-0x00000001832068A0
	public string flagSelfOnTemplateCollider { /* [XID] */ /* 0x0000000189915050-0x0000000189915070 */ get => default; /* [XID] */ /* 0x00000001896F0FC0-0x00000001896F0FE0 */ private set {} } // 0x00000001832047E0-0x0000000183204880 0x0000000183204880-0x0000000183204930
	public string flagSelfInZone { /* [XID] */ /* 0x00000001896F8820-0x00000001896F8840 */ get => default; /* [XID] */ /* 0x0000000189700140-0x0000000189700160 */ private set {} } // 0x00000001832028B0-0x0000000183202950 0x00000001832068A0-0x0000000183206950
	public string flagTargetInZone { /* [XID] */ /* 0x0000000189707890-0x00000001897078B0 */ get => default; /* [XID] */ /* 0x000000018970F280-0x000000018970F2A0 */ private set {} } // 0x0000000183204930-0x00000001832049E0 0x0000000183203DB0-0x0000000183203E60
	public ConfigAIBuddySkillCondition buddySkillCondition { /* [XID] */ /* 0x00000001897166A0-0x00000001897166C0 */ get => default; /* [XID] */ /* 0x000000018971E0A0-0x000000018971E0C0 */ private set {} } // 0x0000000183206950-0x0000000183206A00 0x0000000183207BC0-0x0000000183207C70
	public NeuronName[] nerveTrigger { /* [XID] */ /* 0x0000000189725640-0x0000000189725660 */ get => default; /* [XID] */ /* 0x000000018972CBE0-0x000000018972CC00 */ private set {} } // 0x00000001832085E0-0x0000000183208690 0x00000001832059C0-0x0000000183205A70

	// Constructors
	public ConfigAISkill() {} // 0x00000001832089B0-0x0000000183208B40
	static ConfigAISkill() {} // 0x00000001832087D0-0x00000001832089B0

	// Methods
	// [XID] // 0x00000001897343D0-0x00000001897343F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183207C70-0x0000000183208060
	// [XID] // 0x000000018973BCA0-0x000000018973BCC0
	public void InitEmpty() {} // 0x0000000183204D80-0x0000000183205010
	[BlackList] // 0x00000001897435B0-0x00000001897435F0
	// [XID] // 0x00000001897435B0-0x00000001897435F0
	public bool FromJson(JSONNode node) => default; // 0x0000000183204300-0x0000000183204700
	// [XID] // 0x000000018974DF30-0x000000018974DF50
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183200760-0x00000001832020B0
	// [XID] // 0x00000001897556D0-0x00000001897556F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70DB */, bool useObjectPool = false /* Metadata: 0x00AF70DF */) => default; // 0x00000001832050C0-0x0000000183205440
	// [XID] // 0x000000018975C910-0x000000018975C930
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70E0 */, bool useObjectPool = false /* Metadata: 0x00AF70E4 */) => default; // 0x0000000183202CD0-0x0000000183203DB0
	[BlackList] // 0x0000000189764120-0x0000000189764160
	// [XID] // 0x0000000189764120-0x0000000189764160
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183202160-0x0000000183202430
	// [XID] // 0x000000018976E6A0-0x000000018976E6C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183206A00-0x0000000183207BC0
	[BlackList] // 0x00000001897760E0-0x0000000189776120
	// [XID] // 0x00000001897760E0-0x0000000189776120
	public virtual void OnPoolAllocated() {} // 0x00000001832081D0-0x0000000183208270
	[BlackList] // 0x0000000189780740-0x0000000189780780
	// [XID] // 0x0000000189780740-0x0000000189780780
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183208060-0x00000001832081D0
	// [XID] // 0x000000018978AF00-0x000000018978AF20
	private static void OnPostInitEmpty(ConfigAISkill data) {} // 0x0000000183204AC0-0x0000000183204C20
	// [XID] // 0x0000000189792480-0x00000001897924A0
	private static void OnPostProcessDataCallback(ConfigAISkill data, bool useObjectPool) {} // 0x0000000183205A70-0x0000000183205C80
	[BlackList] // 0x0000000189799A30-0x0000000189799A70
	// [XID] // 0x0000000189799A30-0x0000000189799A70
	public virtual void AutoAllocTypeFields() {} // 0x0000000183202430-0x0000000183202500
	[BlackList] // 0x00000001897A4A70-0x00000001897A4AB0
	// [XID] // 0x00000001897A4A70-0x00000001897A4AB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183202500-0x0000000183202800
	[BlackList] // 0x00000001897AF390-0x00000001897AF3D0
	// [XID] // 0x00000001897AF390-0x00000001897AF3D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183208730-0x00000001832087D0
}

