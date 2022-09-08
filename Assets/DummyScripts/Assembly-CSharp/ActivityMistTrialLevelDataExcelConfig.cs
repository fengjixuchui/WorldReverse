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
public class ActivityMistTrialLevelDataExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15137
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x14
	protected SimpleSafeUInt32 levelIdRawNum; // 0x18
	protected uint _levelTitleTextMapHash; // 0x1C
	protected uint _levelDescTextMapHash; // 0x20
	protected SimpleSafeUInt32[] _monsterPreviewIdList; // 0x28
	protected SimpleSafeUInt32 openDayRawNum; // 0x30
	protected SimpleSafeUInt32[] _challengeMissionWatcherList; // 0x38
	protected SimpleSafeUInt32[] _statisticsIdList; // 0x40
	protected byte _bgIconHashPre; // 0x48
	protected uint _bgIconHashSuffix; // 0x4C
	protected SimpleSafeUInt32 dungeonIdRawNum; // 0x50
	protected SimpleSafeUInt32[] _dungeonFactorIdList; // 0x58
	protected string[] _failTips; // 0x60

	// Properties
	public uint Id { /* [XID] */ /* 0x0000000189691F70-0x0000000189691F90 */ get => default; /* [XID] */ /* 0x0000000189699480-0x00000001896994A0 */ protected set {} } // 0x0000000181FF3BA0-0x0000000181FF3C70 0x0000000181FF5230-0x0000000181FF5310
	public uint scheduleId { /* [XID] */ /* 0x00000001896A08D0-0x00000001896A08F0 */ get => default; /* [XID] */ /* 0x00000001896A7EE0-0x00000001896A7F00 */ protected set {} } // 0x0000000181FF1240-0x0000000181FF1310 0x0000000181FF5150-0x0000000181FF5230
	public uint levelId { /* [XID] */ /* 0x00000001896AF2D0-0x00000001896AF2F0 */ get => default; /* [XID] */ /* 0x00000001896B6840-0x00000001896B6860 */ protected set {} } // 0x0000000181FF1490-0x0000000181FF1560 0x0000000181FF41E0-0x0000000181FF42C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint levelTitleTextMapHash { /* [XID] */ /* 0x00000001896BDAE0-0x00000001896BDB00 */ get => default; /* [XID] */ /* 0x00000001896C52D0-0x00000001896C52F0 */ protected set {} } // 0x0000000181FF56B0-0x0000000181FF5750 0x0000000181FF5310-0x0000000181FF53C0
	public string levelTitle { /* [XID] */ /* 0x00000001896CC8B0-0x00000001896CC8D0 */ get => default; } // 0x0000000181FF3F10-0x0000000181FF4090 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint levelDescTextMapHash { /* [XID] */ /* 0x00000001896D3B60-0x00000001896D3B80 */ get => default; /* [XID] */ /* 0x00000001896DB540-0x00000001896DB560 */ protected set {} } // 0x0000000181FF1310-0x0000000181FF13B0 0x0000000181FF4390-0x0000000181FF4440
	public string levelDesc { /* [XID] */ /* 0x00000001896E2CE0-0x00000001896E2D00 */ get => default; } // 0x0000000181FF5530-0x0000000181FF56B0 
	public SimpleSafeUInt32[] monsterPreviewIdList { /* [XID] */ /* 0x00000001896EA3A0-0x00000001896EA3C0 */ get => default; /* [XID] */ /* 0x00000001896F12E0-0x00000001896F1300 */ protected set {} } // 0x0000000181FF3DC0-0x0000000181FF3E60 0x0000000181FF3C70-0x0000000181FF3D20
	public uint openDay { /* [XID] */ /* 0x00000001896F8CA0-0x00000001896F8CC0 */ get => default; /* [XID] */ /* 0x00000001897004A0-0x00000001897004C0 */ protected set {} } // 0x0000000181FF5460-0x0000000181FF5530 0x0000000181FF13B0-0x0000000181FF1490
	public SimpleSafeUInt32[] challengeMissionWatcherList { /* [XID] */ /* 0x0000000189707D10-0x0000000189707D30 */ get => default; /* [XID] */ /* 0x000000018970F820-0x000000018970F840 */ protected set {} } // 0x0000000181FF53C0-0x0000000181FF5460 0x0000000181FF4130-0x0000000181FF41E0
	public SimpleSafeUInt32[] statisticsIdList { /* [XID] */ /* 0x0000000189716AA0-0x0000000189716AC0 */ get => default; /* [XID] */ /* 0x000000018971E4C0-0x000000018971E4E0 */ protected set {} } // 0x0000000181FF1890-0x0000000181FF1930 0x0000000181FF3E60-0x0000000181FF3F10
	public byte bgIconHashPre { /* [XID] */ /* 0x0000000189725AC0-0x0000000189725AE0 */ get => default; /* [XID] */ /* 0x000000018972D040-0x000000018972D060 */ protected set {} } // 0x0000000181FF17F0-0x0000000181FF1890 0x0000000181FF4F20-0x0000000181FF4FD0
	public uint bgIconHashSuffix { /* [XID] */ /* 0x0000000189734830-0x0000000189734850 */ get => default; /* [XID] */ /* 0x000000018973C1C0-0x000000018973C1E0 */ protected set {} } // 0x0000000181FF3D20-0x0000000181FF3DC0 0x0000000181FF1740-0x0000000181FF17F0
	public ulong bgIconHash { /* [XID] */ /* 0x0000000189743990-0x00000001897439B0 */ get => default; } // 0x0000000181FF42C0-0x0000000181FF4390 
	public uint dungeonId { /* [XID] */ /* 0x000000018974B4E0-0x000000018974B500 */ get => default; /* [XID] */ /* 0x00000001897526B0-0x00000001897526D0 */ protected set {} } // 0x0000000181FF4FD0-0x0000000181FF50A0 0x0000000181FF5890-0x0000000181FF5970
	public SimpleSafeUInt32[] dungeonFactorIdList { /* [XID] */ /* 0x0000000189759C00-0x0000000189759C20 */ get => default; /* [XID] */ /* 0x0000000189761850-0x0000000189761870 */ protected set {} } // 0x0000000181FF4090-0x0000000181FF4130 0x0000000181FF50A0-0x0000000181FF5150
	public string[] failTips { /* [XID] */ /* 0x0000000189768C60-0x0000000189768C80 */ get => default; /* [XID] */ /* 0x0000000189770310-0x0000000189770330 */ protected set {} } // 0x0000000181FF3B00-0x0000000181FF3BA0 0x0000000181FF1930-0x0000000181FF19E0

	// Constructors
	public ActivityMistTrialLevelDataExcelConfig() {} // 0x0000000181FF5A10-0x0000000181FF5A70

	// Methods
	// [IDTag] // 0x0000000189777A30-0x0000000189777A70
	// [XID] // 0x0000000189777A30-0x0000000189777A70
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181FF19E0-0x0000000181FF2A50
	// [IDTag] // 0x0000000189782560-0x00000001897825A0
	// [XID] // 0x0000000189782560-0x00000001897825A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181FF2A50-0x0000000181FF3B00
	// [XID] // 0x000000018978C890-0x000000018978C8B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF01E5 */, bool useObjectPool = false /* Metadata: 0x00AF01E9 */) => default; // 0x0000000181FF4440-0x0000000181FF4F20
	[BlackList] // 0x0000000189793D20-0x0000000189793D60
	// [XID] // 0x0000000189793D20-0x0000000189793D60
	public virtual void AutoAllocTypeFields() {} // 0x0000000181FF1560-0x0000000181FF1600
	[BlackList] // 0x000000018979F050-0x000000018979F090
	// [XID] // 0x000000018979F050-0x000000018979F090
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181FF1600-0x0000000181FF1740
	[BlackList] // 0x00000001897A9600-0x00000001897A9640
	// [XID] // 0x00000001897A9600-0x00000001897A9640
	public virtual void ReturnToObjectPool() {} // 0x0000000181FF5970-0x0000000181FF5A10
	[BlackList] // 0x00000001897B4510-0x00000001897B4550
	// [XID] // 0x00000001897B4510-0x00000001897B4550
	public virtual void OnPoolAllocated() {} // 0x0000000181FF57F0-0x0000000181FF5890
	[BlackList] // 0x00000001897BF490-0x00000001897BF4D0
	// [XID] // 0x00000001897BF490-0x00000001897BF4D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181FF5750-0x0000000181FF57F0
}

