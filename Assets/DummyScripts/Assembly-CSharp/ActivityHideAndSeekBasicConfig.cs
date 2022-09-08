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
public class ActivityHideAndSeekBasicConfig : IAutoAllocRecycle // TypeDefIndex: 15123
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIDRawNum; // 0x14
	protected uint _titleTextMapHash; // 0x18
	protected uint _descTextMapHash; // 0x1C
	protected SimpleSafeUInt32 pushTipsIDRawNum; // 0x20
	protected SimpleSafeUInt32 rewardPreviewIDRawNum; // 0x24
	protected SimpleSafeUInt32 oneTimeRewardPreviewIDRawNum; // 0x28
	protected SimpleSafeUInt32 unlockQuestIDRawNum; // 0x2C
	protected SimpleSafeUInt32 matchIDRawNum; // 0x30
	protected SimpleSafeUInt32 draftIDRawNum; // 0x34
	protected SimpleSafeUInt32[] _scoreUnlockList; // 0x38
	protected SimpleSafeUInt32[] _watcherList; // 0x40
	protected SimpleSafeUInt32[] _skillList; // 0x48
	protected SimpleSafeUInt32[] _mapList; // 0x50
	protected SimpleSafeUInt32[] _chanllengeList; // 0x58
	protected SimpleSafeUInt32 scoreItemIDRawNum; // 0x60

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BB6F10-0x0000000189BB6F30 */ get => default; /* [XID] */ /* 0x0000000189BBE510-0x0000000189BBE530 */ protected set {} } // 0x0000000183E32880-0x0000000183E32950 0x0000000183E31280-0x0000000183E31360
	public uint activityID { /* [XID] */ /* 0x0000000189BC6240-0x0000000189BC6260 */ get => default; /* [XID] */ /* 0x0000000189BCDE40-0x0000000189BCDE60 */ protected set {} } // 0x0000000183E30B90-0x0000000183E30C60 0x0000000183E2E0B0-0x0000000183E2E190
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189BD5310-0x0000000189BD5330 */ get => default; /* [XID] */ /* 0x0000000189BDCE80-0x0000000189BDCEA0 */ protected set {} } // 0x0000000183E2E190-0x0000000183E2E230 0x0000000183E2E2E0-0x0000000183E2E390
	public string title { /* [XID] */ /* 0x00000001895E9790-0x00000001895E97B0 */ get => default; } // 0x0000000183E32410-0x0000000183E32590 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001895F0F20-0x00000001895F0F40 */ get => default; /* [XID] */ /* 0x00000001895F8970-0x00000001895F8990 */ protected set {} } // 0x0000000183E32200-0x0000000183E322A0 0x0000000183E2E230-0x0000000183E2E2E0
	public string desc { /* [XID] */ /* 0x00000001895FFDF0-0x00000001895FFE10 */ get => default; } // 0x0000000183E31100-0x0000000183E31280 
	public uint pushTipsID { /* [XID] */ /* 0x0000000189607500-0x0000000189607520 */ get => default; /* [XID] */ /* 0x000000018960EF20-0x000000018960EF40 */ protected set {} } // 0x0000000183E30D00-0x0000000183E30DD0 0x0000000183E2E390-0x0000000183E2E470
	public uint rewardPreviewID { /* [XID] */ /* 0x00000001896165C0-0x00000001896165E0 */ get => default; /* [XID] */ /* 0x000000018961DDF0-0x000000018961DE10 */ protected set {} } // 0x0000000183E32130-0x0000000183E32200 0x0000000183E32950-0x0000000183E32A30
	public uint oneTimeRewardPreviewID { /* [XID] */ /* 0x0000000189625290-0x00000001896252B0 */ get => default; /* [XID] */ /* 0x000000018962CA30-0x000000018962CA50 */ protected set {} } // 0x0000000183E322A0-0x0000000183E32370 0x0000000183E32660-0x0000000183E32740
	public uint unlockQuestID { /* [XID] */ /* 0x00000001896347B0-0x00000001896347D0 */ get => default; /* [XID] */ /* 0x000000018963BEE0-0x000000018963BF00 */ protected set {} } // 0x0000000183E30E80-0x0000000183E30F50 0x0000000183E30F50-0x0000000183E31030
	public uint matchID { /* [XID] */ /* 0x00000001896435C0-0x00000001896435E0 */ get => default; /* [XID] */ /* 0x000000018964ABE0-0x000000018964AC00 */ protected set {} } // 0x0000000183E32590-0x0000000183E32660 0x0000000183E30AB0-0x0000000183E30B90
	public uint draftID { /* [XID] */ /* 0x00000001896523A0-0x00000001896523C0 */ get => default; /* [XID] */ /* 0x0000000189659AD0-0x0000000189659AF0 */ protected set {} } // 0x0000000183E30930-0x0000000183E30A00 0x0000000183E2DFD0-0x0000000183E2E0B0
	public SimpleSafeUInt32[] scoreUnlockList { /* [XID] */ /* 0x0000000189661270-0x0000000189661290 */ get => default; /* [XID] */ /* 0x0000000189668D00-0x0000000189668D20 */ protected set {} } // 0x0000000183E2DF30-0x0000000183E2DFD0 0x0000000183E2DC60-0x0000000183E2DD10
	public SimpleSafeUInt32[] watcherList { /* [XID] */ /* 0x0000000189670830-0x0000000189670850 */ get => default; /* [XID] */ /* 0x0000000189678030-0x0000000189678050 */ protected set {} } // 0x0000000183E31360-0x0000000183E31400 0x0000000183E30A00-0x0000000183E30AB0
	public SimpleSafeUInt32[] skillList { /* [XID] */ /* 0x000000018967F720-0x000000018967F740 */ get => default; /* [XID] */ /* 0x0000000189686FB0-0x0000000189686FD0 */ protected set {} } // 0x0000000183E32370-0x0000000183E32410 0x0000000183E30DD0-0x0000000183E30E80
	public SimpleSafeUInt32[] mapList { /* [XID] */ /* 0x000000018968EDB0-0x000000018968EDD0 */ get => default; /* [XID] */ /* 0x0000000189696730-0x0000000189696750 */ protected set {} } // 0x0000000183E2DAE0-0x0000000183E2DB80 0x0000000183E31400-0x0000000183E314B0
	public SimpleSafeUInt32[] chanllengeList { /* [XID] */ /* 0x000000018969DDD0-0x000000018969DDF0 */ get => default; /* [XID] */ /* 0x00000001896A4DA0-0x00000001896A4DC0 */ protected set {} } // 0x0000000183E30C60-0x0000000183E30D00 0x0000000183E2E470-0x0000000183E2E520
	public uint scoreItemID { /* [XID] */ /* 0x00000001896AC650-0x00000001896AC670 */ get => default; /* [XID] */ /* 0x00000001896B38D0-0x00000001896B38F0 */ protected set {} } // 0x0000000183E31030-0x0000000183E31100 0x0000000183E2DB80-0x0000000183E2DC60

	// Constructors
	public ActivityHideAndSeekBasicConfig() {} // 0x0000000183E32AD0-0x0000000183E32B30

	// Methods
	// [IDTag] // 0x00000001896BAF90-0x00000001896BAFD0
	// [XID] // 0x00000001896BAF90-0x00000001896BAFD0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183E2E520-0x0000000183E2F6F0
	// [IDTag] // 0x00000001896C52F0-0x00000001896C5330
	// [XID] // 0x00000001896C52F0-0x00000001896C5330
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183E2F6F0-0x0000000183E30930
	// [XID] // 0x00000001896CFAF0-0x00000001896CFB10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0173 */, bool useObjectPool = false /* Metadata: 0x00AF0177 */) => default; // 0x0000000183E314B0-0x0000000183E32130
	[BlackList] // 0x00000001896D6D80-0x00000001896D6DC0
	// [XID] // 0x00000001896D6D80-0x00000001896D6DC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E2DD10-0x0000000183E2DDB0
	[BlackList] // 0x00000001896E1670-0x00000001896E16B0
	// [XID] // 0x00000001896E1670-0x00000001896E16B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E2DDB0-0x0000000183E2DF30
	[BlackList] // 0x00000001896EB9E0-0x00000001896EBA20
	// [XID] // 0x00000001896EB9E0-0x00000001896EBA20
	public virtual void ReturnToObjectPool() {} // 0x0000000183E32A30-0x0000000183E32AD0
	[BlackList] // 0x00000001896F6100-0x00000001896F6140
	// [XID] // 0x00000001896F6100-0x00000001896F6140
	public virtual void OnPoolAllocated() {} // 0x0000000183E327E0-0x0000000183E32880
	[BlackList] // 0x00000001897004C0-0x0000000189700500
	// [XID] // 0x00000001897004C0-0x0000000189700500
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E32740-0x0000000183E327E0
}

