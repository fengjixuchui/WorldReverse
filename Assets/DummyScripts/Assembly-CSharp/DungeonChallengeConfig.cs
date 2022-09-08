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
public class DungeonChallengeConfig : IAutoAllocRecycle // TypeDefIndex: 15551
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _targetTextTemplateTextMapHash; // 0x14
	protected uint _subTargetTextTemplateTextMapHash; // 0x18
	protected uint _progressTextTemplateTextMapHash; // 0x1C
	protected uint _subProgressTextTemplateTextMapHash; // 0x20
	protected ChallengeType _challenge_type; // 0x24
	protected bool _isForwardTiming; // 0x28
	protected ChallengeRecordType _recordType; // 0x2C
	protected bool _noSuccessHint; // 0x30
	protected bool _noFailHint; // 0x31
	protected InterruptButtonType _interruptButtonType; // 0x34
	protected bool _isSuccessWhenNotSettled; // 0x38
	protected bool _isBlockTopTimer; // 0x39
	protected SubChallengeFadeOutType _subChallengeFadeOutRule; // 0x3C
	protected SimpleSafeFloat subChallengeFadeOutDelayTimeRawNum; // 0x40
	protected SubChallengeBannerType _subChallengeBannerRule; // 0x44
	protected SimpleSafeUInt32 activitySkillIDRawNum; // 0x48

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189994510-0x0000000189994530 */ get => default; /* [XID] */ /* 0x000000018999BCE0-0x000000018999BD00 */ protected set {} } // 0x0000000182CC1A50-0x0000000182CC1B20 0x0000000182CC0150-0x0000000182CC0230
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint targetTextTemplateTextMapHash { /* [XID] */ /* 0x00000001899A3550-0x00000001899A3570 */ get => default; /* [XID] */ /* 0x00000001899AB060-0x00000001899AB080 */ protected set {} } // 0x0000000182CC1BD0-0x0000000182CC1C70 0x0000000182CBFCA0-0x0000000182CBFD50
	public string targetTextTemplate { /* [XID] */ /* 0x00000001899B2AB0-0x00000001899B2AD0 */ get => default; } // 0x0000000182CBE520-0x0000000182CBE6A0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint subTargetTextTemplateTextMapHash { /* [XID] */ /* 0x00000001899B9C10-0x00000001899B9C30 */ get => default; /* [XID] */ /* 0x00000001899C1770-0x00000001899C1790 */ protected set {} } // 0x0000000182CBF9F0-0x0000000182CBFA90 0x0000000182CBDE60-0x0000000182CBDF10
	public string subTargetTextTemplate { /* [XID] */ /* 0x00000001899C8CE0-0x00000001899C8D00 */ get => default; } // 0x0000000182CC1610-0x0000000182CC1790 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint progressTextTemplateTextMapHash { /* [XID] */ /* 0x00000001899D06D0-0x00000001899D06F0 */ get => default; /* [XID] */ /* 0x00000001899D7BB0-0x00000001899D7BD0 */ protected set {} } // 0x0000000182CBE2F0-0x0000000182CBE390 0x0000000182CC1150-0x0000000182CC1200
	public string progressTextTemplate { /* [XID] */ /* 0x00000001899DF090-0x00000001899DF0B0 */ get => default; } // 0x0000000182CC1340-0x0000000182CC14C0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint subProgressTextTemplateTextMapHash { /* [XID] */ /* 0x00000001899E6D50-0x00000001899E6D70 */ get => default; /* [XID] */ /* 0x00000001899EE1E0-0x00000001899EE200 */ protected set {} } // 0x0000000182CBE1A0-0x0000000182CBE240 0x0000000182CC1C70-0x0000000182CC1D20
	public string subProgressTextTemplate { /* [XID] */ /* 0x00000001899F59F0-0x00000001899F5A10 */ get => default; } // 0x0000000182CBFFD0-0x0000000182CC0150 
	public ChallengeType challenge_type { /* [XID] */ /* 0x00000001899FD170-0x00000001899FD190 */ get => default; /* [XID] */ /* 0x0000000189A04630-0x0000000189A04650 */ protected set {} } // 0x0000000182CC10B0-0x0000000182CC1150 0x0000000182CBFA90-0x0000000182CBFB40
	public bool isForwardTiming { /* [XID] */ /* 0x0000000189A0BE70-0x0000000189A0BE90 */ get => default; /* [XID] */ /* 0x0000000189A13740-0x0000000189A13760 */ protected set {} } // 0x0000000182CBFD50-0x0000000182CBFDF0 0x0000000182CBE470-0x0000000182CBE520
	public ChallengeRecordType recordType { /* [XID] */ /* 0x0000000189A1A850-0x0000000189A1A870 */ get => default; /* [XID] */ /* 0x0000000189A220D0-0x0000000189A220F0 */ protected set {} } // 0x0000000182CC12A0-0x0000000182CC1340 0x0000000182CBE0F0-0x0000000182CBE1A0
	public bool noSuccessHint { /* [XID] */ /* 0x0000000189A29580-0x0000000189A295A0 */ get => default; /* [XID] */ /* 0x0000000189A30AD0-0x0000000189A30AF0 */ protected set {} } // 0x0000000182CBDCE0-0x0000000182CBDD80 0x0000000182CC1790-0x0000000182CC1840
	public bool noFailHint { /* [XID] */ /* 0x0000000189A38550-0x0000000189A38570 */ get => default; /* [XID] */ /* 0x0000000189A3FC60-0x0000000189A3FC80 */ protected set {} } // 0x0000000182CC1200-0x0000000182CC12A0 0x0000000182CBFB40-0x0000000182CBFBF0
	public InterruptButtonType interruptButtonType { /* [XID] */ /* 0x0000000189A47350-0x0000000189A47370 */ get => default; /* [XID] */ /* 0x0000000189A4EBF0-0x0000000189A4EC10 */ protected set {} } // 0x0000000182CC1010-0x0000000182CC10B0 0x0000000182CBE240-0x0000000182CBE2F0
	public bool isSuccessWhenNotSettled { /* [XID] */ /* 0x0000000189A56300-0x0000000189A56320 */ get => default; /* [XID] */ /* 0x0000000189A5DD20-0x0000000189A5DD40 */ protected set {} } // 0x0000000182CBFF30-0x0000000182CBFFD0 0x0000000182CBDC30-0x0000000182CBDCE0
	public bool isBlockTopTimer { /* [XID] */ /* 0x0000000189A65560-0x0000000189A65580 */ get => default; /* [XID] */ /* 0x0000000189A6CC60-0x0000000189A6CC80 */ protected set {} } // 0x0000000182CBFDF0-0x0000000182CBFE90 0x0000000182CC1B20-0x0000000182CC1BD0
	public SubChallengeFadeOutType subChallengeFadeOutRule { /* [XID] */ /* 0x0000000189A743F0-0x0000000189A74410 */ get => default; /* [XID] */ /* 0x0000000189A7BDE0-0x0000000189A7BE00 */ protected set {} } // 0x0000000182CBFE90-0x0000000182CBFF30 0x0000000182CC14C0-0x0000000182CC1570
	public float subChallengeFadeOutDelayTime { /* [XID] */ /* 0x0000000189A83800-0x0000000189A83820 */ get => default; /* [XID] */ /* 0x0000000189A8B000-0x0000000189A8B020 */ protected set {} } // 0x0000000182CBDD80-0x0000000182CBDE60 0x0000000182CC0230-0x0000000182CC0310
	public SubChallengeBannerType subChallengeBannerRule { /* [XID] */ /* 0x0000000189A92830-0x0000000189A92850 */ get => default; /* [XID] */ /* 0x0000000189A9A220-0x0000000189A9A240 */ protected set {} } // 0x0000000182CC1570-0x0000000182CC1610 0x0000000182CBFBF0-0x0000000182CBFCA0
	public uint activitySkillID { /* [XID] */ /* 0x0000000189AA12C0-0x0000000189AA12E0 */ get => default; /* [XID] */ /* 0x0000000189AA89A0-0x0000000189AA89C0 */ protected set {} } // 0x0000000182CC1840-0x0000000182CC1910 0x0000000182CBE390-0x0000000182CBE470

	// Constructors
	public DungeonChallengeConfig() {} // 0x0000000182CC1DC0-0x0000000182CC1E20

	// Methods
	// [IDTag] // 0x0000000189AB0520-0x0000000189AB0560
	// [XID] // 0x0000000189AB0520-0x0000000189AB0560
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182CBF060-0x0000000182CBF9F0
	// [IDTag] // 0x0000000189ABB270-0x0000000189ABB2B0
	// [XID] // 0x0000000189ABB270-0x0000000189ABB2B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182CBE6A0-0x0000000182CBF060
	// [XID] // 0x0000000189AC5B30-0x0000000189AC5B50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1EDA */, bool useObjectPool = false /* Metadata: 0x00AF1EDE */) => default; // 0x0000000182CC0310-0x0000000182CC1010
	[BlackList] // 0x0000000189ACD0C0-0x0000000189ACD100
	// [XID] // 0x0000000189ACD0C0-0x0000000189ACD100
	public virtual void AutoAllocTypeFields() {} // 0x0000000182CBDF10-0x0000000182CBDFB0
	[BlackList] // 0x0000000189AD7D60-0x0000000189AD7DA0
	// [XID] // 0x0000000189AD7D60-0x0000000189AD7DA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182CBDFB0-0x0000000182CBE0F0
	[BlackList] // 0x0000000189AE24A0-0x0000000189AE24E0
	// [XID] // 0x0000000189AE24A0-0x0000000189AE24E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182CC1D20-0x0000000182CC1DC0
	[BlackList] // 0x0000000189AECE20-0x0000000189AECE60
	// [XID] // 0x0000000189AECE20-0x0000000189AECE60
	public virtual void OnPoolAllocated() {} // 0x0000000182CC19B0-0x0000000182CC1A50
	[BlackList] // 0x0000000189AF7940-0x0000000189AF7980
	// [XID] // 0x0000000189AF7940-0x0000000189AF7980
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182CC1910-0x0000000182CC19B0
}

