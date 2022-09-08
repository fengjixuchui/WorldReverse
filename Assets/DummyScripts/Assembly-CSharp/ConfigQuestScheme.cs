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
public class ConfigQuestScheme : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18810
{
	// Fields
	private uint _subId; // 0x10
	private uint _mainId; // 0x14
	private int _order; // 0x18
	private uint _subIdSet; // 0x1C
	private bool _isMpBlock; // 0x20
	private uint descTextMapHash; // 0x24
	private uint stepDescTextMapHash; // 0x28
	private uint guideTipsTextMapHash; // 0x2C
	private QuestShowType _showType; // 0x30
	private BanGroupType _banType; // 0x34
	private LogicType _acceptCondComb; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private QuestCondEx[] _acceptCond; // 0x40
	private LogicType _finishCondComb; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private QuestContentEx[] _finishCond; // 0x50
	private LogicType _failCondComb; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private QuestContentEx[] _failCond; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private QuestGuideEx _guide; // 0x68
	private ShowQuestGuideType _showGuide; // 0x70
	private bool _finishParent; // 0x74
	private bool _failParent; // 0x75
	private QuestShowType _failParentShow; // 0x78
	private bool _isRewind; // 0x7C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private QuestExecEx[] _finishExec; // 0x80
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private QuestExecEx[] _failExec; // 0x88
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private QuestExecEx[] _beginExec; // 0x90
	private uint[] _exclusiveNpcList; // 0x98
	private uint[] _exclusivePlaceList; // 0xA0
	private uint[] _sharedNpcList; // 0xA8
	private uint _exclusiveNpcPriority; // 0xB0
	private uint[] _trialAvatarList; // 0xB8
	private string _versionBegin; // 0xC0
	private string _versionEnd; // 0xC8

	// Properties
	public uint subId { /* [XID] */ /* 0x00000001899211B0-0x00000001899211D0 */ get => default; /* [XID] */ /* 0x0000000189AE6A40-0x0000000189AE6A60 */ private set {} } // 0x0000000182306F40-0x0000000182306FE0 0x00000001823073C0-0x0000000182307470
	public uint mainId { /* [XID] */ /* 0x0000000189AEE4E0-0x0000000189AEE500 */ get => default; /* [XID] */ /* 0x0000000189AF5A70-0x0000000189AF5A90 */ private set {} } // 0x0000000182307280-0x0000000182307320 0x0000000182306980-0x0000000182306A30
	public int order { /* [XID] */ /* 0x0000000189AFCF50-0x0000000189AFCF70 */ get => default; /* [XID] */ /* 0x0000000189B046E0-0x0000000189B04700 */ private set {} } // 0x0000000182303BD0-0x0000000182303C70 0x0000000182306550-0x0000000182306600
	public uint subIdSet { /* [XID] */ /* 0x0000000189B0BF70-0x0000000189B0BF90 */ get => default; /* [XID] */ /* 0x0000000189B135C0-0x0000000189B135E0 */ private set {} } // 0x0000000182303DC0-0x0000000182303E60 0x00000001823056C0-0x0000000182305770
	public bool isMpBlock { /* [XID] */ /* 0x0000000189B1AD20-0x0000000189B1AD40 */ get => default; /* [XID] */ /* 0x0000000189B22270-0x0000000189B22290 */ private set {} } // 0x0000000182307320-0x00000001823073C0 0x0000000182306180-0x0000000182306230
	public string desc { /* [XID] */ /* 0x0000000189B29840-0x0000000189B29860 */ get => default; } // 0x0000000182306380-0x00000001823064A0 
	public string stepDesc { /* [XID] */ /* 0x0000000189B30DD0-0x0000000189B30DF0 */ get => default; } // 0x0000000182305C50-0x0000000182305D70 
	public string guideTips { /* [XID] */ /* 0x0000000189B38490-0x0000000189B384B0 */ get => default; } // 0x0000000182306600-0x0000000182306720 
	public QuestShowType showType { /* [XID] */ /* 0x0000000189B3FEE0-0x0000000189B3FF00 */ get => default; /* [XID] */ /* 0x0000000189B47700-0x0000000189B47720 */ private set {} } // 0x0000000182305570-0x0000000182305610 0x0000000182303930-0x00000001823039E0
	public BanGroupType banType { /* [XID] */ /* 0x0000000189B4EE90-0x0000000189B4EEB0 */ get => default; /* [XID] */ /* 0x0000000189B56870-0x0000000189B56890 */ private set {} } // 0x0000000182309580-0x0000000182309620 0x00000001823060D0-0x0000000182306180
	public LogicType acceptCondComb { /* [XID] */ /* 0x0000000189B5E060-0x0000000189B5E080 */ get => default; /* [XID] */ /* 0x0000000189B655A0-0x0000000189B655C0 */ private set {} } // 0x00000001823039E0-0x0000000182303A80 0x0000000182306E90-0x0000000182306F40
	public QuestCondEx[] acceptCond { /* [XID] */ /* 0x0000000189B6CBE0-0x0000000189B6CC00 */ get => default; /* [XID] */ /* 0x0000000189B74390-0x0000000189B743B0 */ private set {} } // 0x0000000182303A80-0x0000000182303B20 0x0000000182307670-0x0000000182307720
	public LogicType finishCondComb { /* [XID] */ /* 0x0000000189B7B910-0x0000000189B7B930 */ get => default; /* [XID] */ /* 0x0000000189B832C0-0x0000000189B832E0 */ private set {} } // 0x0000000182308CE0-0x0000000182308D80 0x0000000182305610-0x00000001823056C0
	public QuestContentEx[] finishCond { /* [XID] */ /* 0x0000000189B8A770-0x0000000189B8A790 */ get => default; /* [XID] */ /* 0x0000000189B91D60-0x0000000189B91D80 */ private set {} } // 0x0000000182307090-0x0000000182307130 0x0000000182305820-0x00000001823058D0
	public LogicType failCondComb { /* [XID] */ /* 0x0000000189B992A0-0x0000000189B992C0 */ get => default; /* [XID] */ /* 0x0000000189BA0690-0x0000000189BA06B0 */ private set {} } // 0x0000000182308B90-0x0000000182308C30 0x0000000182307720-0x00000001823077D0
	public QuestContentEx[] failCond { /* [XID] */ /* 0x0000000189BA7EB0-0x0000000189BA7ED0 */ get => default; /* [XID] */ /* 0x0000000189BAF360-0x0000000189BAF380 */ private set {} } // 0x0000000182306230-0x00000001823062D0 0x0000000182305770-0x0000000182305820
	public QuestGuideEx guide { /* [XID] */ /* 0x0000000189BB6950-0x0000000189BB6970 */ get => default; /* [XID] */ /* 0x0000000189BBDFD0-0x0000000189BBDFF0 */ private set {} } // 0x0000000182308D80-0x0000000182308E20 0x0000000182306FE0-0x0000000182307090
	public ShowQuestGuideType showGuide { /* [XID] */ /* 0x0000000189BC5C80-0x0000000189BC5CA0 */ get => default; /* [XID] */ /* 0x0000000189BCD700-0x0000000189BCD720 */ private set {} } // 0x0000000182307470-0x0000000182307510 0x00000001823064A0-0x0000000182306550
	public bool finishParent { /* [XID] */ /* 0x0000000189BD4CB0-0x0000000189BD4CD0 */ get => default; /* [XID] */ /* 0x0000000189BDC6C0-0x0000000189BDC6E0 */ private set {} } // 0x0000000182307130-0x00000001823071D0 0x0000000182305F70-0x0000000182306020
	public bool failParent { /* [XID] */ /* 0x00000001895E9030-0x00000001895E9050 */ get => default; /* [XID] */ /* 0x00000001895F0840-0x00000001895F0860 */ private set {} } // 0x0000000182305D70-0x0000000182305E10 0x00000001823054C0-0x0000000182305570
	public QuestShowType failParentShow { /* [XID] */ /* 0x00000001895F81F0-0x00000001895F8210 */ get => default; /* [XID] */ /* 0x00000001895FF730-0x00000001895FF750 */ private set {} } // 0x0000000182306720-0x00000001823067C0 0x00000001823071D0-0x0000000182307280
	public bool isRewind { /* [XID] */ /* 0x0000000189606EE0-0x0000000189606F00 */ get => default; /* [XID] */ /* 0x000000018960E880-0x000000018960E8A0 */ private set {} } // 0x0000000182309430-0x00000001823094D0 0x0000000182305410-0x00000001823054C0
	public QuestExecEx[] finishExec { /* [XID] */ /* 0x0000000189615EC0-0x0000000189615EE0 */ get => default; /* [XID] */ /* 0x000000018961D7D0-0x000000018961D7F0 */ private set {} } // 0x00000001823017D0-0x0000000182301880 0x0000000182305360-0x0000000182305410
	public QuestExecEx[] failExec { /* [XID] */ /* 0x0000000189624BF0-0x0000000189624C10 */ get => default; /* [XID] */ /* 0x000000018962C3B0-0x000000018962C3D0 */ private set {} } // 0x0000000182306A30-0x0000000182306AE0 0x0000000182303E60-0x0000000182303F10
	public QuestExecEx[] beginExec { /* [XID] */ /* 0x0000000189633F30-0x0000000189633F50 */ get => default; /* [XID] */ /* 0x000000018963B6E0-0x000000018963B700 */ private set {} } // 0x0000000182308C30-0x0000000182308CE0 0x0000000182303B20-0x0000000182303BD0
	public uint[] exclusiveNpcList { /* [XID] */ /* 0x0000000189642F20-0x0000000189642F40 */ get => default; /* [XID] */ /* 0x000000018964A5E0-0x000000018964A600 */ private set {} } // 0x0000000182306020-0x00000001823060D0 0x0000000182309380-0x0000000182309430
	public uint[] exclusivePlaceList { /* [XID] */ /* 0x0000000189651E20-0x0000000189651E40 */ get => default; /* [XID] */ /* 0x0000000189659510-0x0000000189659530 */ private set {} } // 0x0000000182306AE0-0x0000000182306B90 0x00000001823052B0-0x0000000182305360
	public uint[] sharedNpcList { /* [XID] */ /* 0x0000000189660C70-0x0000000189660C90 */ get => default; /* [XID] */ /* 0x00000001896685A0-0x00000001896685C0 */ private set {} } // 0x0000000182303C70-0x0000000182303D20 0x0000000182305EC0-0x0000000182305F70
	public uint exclusiveNpcPriority { /* [XID] */ /* 0x0000000189670030-0x0000000189670050 */ get => default; /* [XID] */ /* 0x0000000189677990-0x00000001896779B0 */ private set {} } // 0x0000000182303D20-0x0000000182303DC0 0x0000000182309620-0x00000001823096D0
	public uint[] trialAvatarList { /* [XID] */ /* 0x000000018967EEA0-0x000000018967EEC0 */ get => default; /* [XID] */ /* 0x0000000189686810-0x0000000189686830 */ private set {} } // 0x00000001823075C0-0x0000000182307670 0x0000000182301880-0x0000000182301930
	public string versionBegin { /* [XID] */ /* 0x000000018968E5F0-0x000000018968E610 */ get => default; /* [XID] */ /* 0x0000000189695FD0-0x0000000189695FF0 */ private set {} } // 0x0000000182305E10-0x0000000182305EC0 0x00000001823094D0-0x0000000182309580
	public string versionEnd { /* [XID] */ /* 0x000000018969D6D0-0x000000018969D6F0 */ get => default; /* [XID] */ /* 0x00000001896A47A0-0x00000001896A47C0 */ private set {} } // 0x0000000182307510-0x00000001823075C0 0x00000001823062D0-0x0000000182306380

	// Constructors
	public ConfigQuestScheme() {} // 0x0000000182309770-0x00000001823097E0

	// Methods
	// [XID] // 0x00000001896ABF10-0x00000001896ABF30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182308E20-0x0000000182309240
	// [XID] // 0x00000001896B3170-0x00000001896B3190
	public void InitEmpty() {} // 0x00000001823067C0-0x0000000182306980
	[BlackList] // 0x00000001896BA8D0-0x00000001896BA910
	// [XID] // 0x00000001896BA8D0-0x00000001896BA910
	public bool FromJson(JSONNode node) => default; // 0x00000001823058D0-0x0000000182305C50
	// [XID] // 0x00000001896C4CB0-0x00000001896C4CD0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182301930-0x00000001823033E0
	// [XID] // 0x000000018990F160-0x000000018990F180
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD75 */, bool useObjectPool = false /* Metadata: 0x00AFAD79 */) => default; // 0x0000000182306B90-0x0000000182306E90
	// [XID] // 0x00000001896D3380-0x00000001896D33A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD7A */, bool useObjectPool = false /* Metadata: 0x00AFAD7E */) => default; // 0x0000000182303F10-0x00000001823052B0
	[BlackList] // 0x00000001896DAF00-0x00000001896DAF40
	// [XID] // 0x00000001896DAF00-0x00000001896DAF40
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001823033E0-0x00000001823036B0
	// [XID] // 0x00000001896E53B0-0x00000001896E53D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001823077D0-0x0000000182308B90
	[BlackList] // 0x00000001896EC980-0x00000001896EC9C0
	// [XID] // 0x00000001896EC980-0x00000001896EC9C0
	public virtual void AutoAllocTypeFields() {} // 0x00000001823036B0-0x0000000182303750
	[BlackList] // 0x00000001896F71B0-0x00000001896F71F0
	// [XID] // 0x00000001896F71B0-0x00000001896F71F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182303750-0x0000000182303930
	[BlackList] // 0x0000000189701740-0x0000000189701780
	// [XID] // 0x0000000189701740-0x0000000189701780
	public virtual void ReturnToObjectPool() {} // 0x00000001823096D0-0x0000000182309770
	[BlackList] // 0x000000018970BE90-0x000000018970BED0
	// [XID] // 0x000000018970BE90-0x000000018970BED0
	public virtual void OnPoolAllocated() {} // 0x00000001823092E0-0x0000000182309380
	[BlackList] // 0x0000000189716520-0x0000000189716560
	// [XID] // 0x0000000189716520-0x0000000189716560
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182309240-0x00000001823092E0
}

