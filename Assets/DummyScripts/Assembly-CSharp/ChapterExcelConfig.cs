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
public class ChapterExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15966
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 beginQuestIdRawNum; // 0x14
	protected SimpleSafeUInt32 endQuestIdRawNum; // 0x18
	protected SimpleSafeUInt32 needPlayerLevelRawNum; // 0x1C
	protected SimpleSafeUInt32 activityIdRawNum; // 0x20
	protected string _needBeginTimeStr; // 0x28
	protected uint _chapterNumTextMapHash; // 0x30
	protected uint _chapterTitleTextMapHash; // 0x34
	protected string _chapterIcon; // 0x38
	protected byte _chapterImageHashPre; // 0x40
	protected uint _chapterImageHashSuffix; // 0x44
	protected uint _chapterImageTitleTextMapHash; // 0x48
	protected SimpleSafeUInt32 inActivityNeedPlayerLevelRawNum; // 0x4C
	protected string _chapterSerialNumberIcon; // 0x50

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189700360-0x0000000189700380 */ get => default; /* [XID] */ /* 0x0000000189707B30-0x0000000189707B50 */ protected set {} } // 0x00000001835E8370-0x00000001835E8440 0x00000001835E6820-0x00000001835E6900
	public uint beginQuestId { /* [XID] */ /* 0x000000018970F5A0-0x000000018970F5C0 */ get => default; /* [XID] */ /* 0x0000000189716940-0x0000000189716960 */ protected set {} } // 0x00000001835E5350-0x00000001835E5420 0x00000001835E7FD0-0x00000001835E80B0
	public uint endQuestId { /* [XID] */ /* 0x000000018971E380-0x000000018971E3A0 */ get => default; /* [XID] */ /* 0x0000000189725900-0x0000000189725920 */ protected set {} } // 0x00000001835E7870-0x00000001835E7940 0x00000001835E5270-0x00000001835E5350
	public uint needPlayerLevel { /* [XID] */ /* 0x000000018972CE00-0x000000018972CE20 */ get => default; /* [XID] */ /* 0x00000001897345D0-0x00000001897345F0 */ protected set {} } // 0x00000001835E7F00-0x00000001835E7FD0 0x00000001835E6B30-0x00000001835E6C10
	public uint activityId { /* [XID] */ /* 0x000000018973BFA0-0x000000018973BFC0 */ get => default; /* [XID] */ /* 0x0000000189743770-0x0000000189743790 */ protected set {} } // 0x00000001835E7B60-0x00000001835E7C30 0x00000001835E6740-0x00000001835E6820
	public string needBeginTimeStr { /* [XID] */ /* 0x000000018974B3C0-0x000000018974B3E0 */ get => default; /* [XID] */ /* 0x0000000189752550-0x0000000189752570 */ protected set {} } // 0x00000001835E7C30-0x00000001835E7CD0 0x00000001835E7CD0-0x00000001835E7D80
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint chapterNumTextMapHash { /* [XID] */ /* 0x0000000189759B00-0x0000000189759B20 */ get => default; /* [XID] */ /* 0x0000000189761770-0x0000000189761790 */ protected set {} } // 0x00000001835E8580-0x00000001835E8620 0x00000001835E7AB0-0x00000001835E7B60
	public string chapterNum { /* [XID] */ /* 0x0000000189768B40-0x0000000189768B60 */ get => default; } // 0x00000001835E6900-0x00000001835E6A80 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint chapterTitleTextMapHash { /* [XID] */ /* 0x0000000189770230-0x0000000189770250 */ get => default; /* [XID] */ /* 0x00000001897778F0-0x0000000189777910 */ protected set {} } // 0x00000001835E51D0-0x00000001835E5270 0x00000001835E6A80-0x00000001835E6B30
	public string chapterTitle { /* [XID] */ /* 0x000000018977EF60-0x000000018977EF80 */ get => default; } // 0x00000001835E6480-0x00000001835E6600 
	public string chapterIcon { /* [XID] */ /* 0x0000000189786960-0x0000000189786980 */ get => default; /* [XID] */ /* 0x000000018978DFB0-0x000000018978DFD0 */ protected set {} } // 0x00000001835E66A0-0x00000001835E6740 0x00000001835E76E0-0x00000001835E7790
	public byte chapterImageHashPre { /* [XID] */ /* 0x00000001897956A0-0x00000001897956C0 */ get => default; /* [XID] */ /* 0x000000018979DB10-0x000000018979DB30 */ protected set {} } // 0x00000001835E6600-0x00000001835E66A0 0x00000001835E54D0-0x00000001835E5580
	public uint chapterImageHashSuffix { /* [XID] */ /* 0x00000001897A4E90-0x00000001897A4EB0 */ get => default; /* [XID] */ /* 0x00000001897AC420-0x00000001897AC440 */ protected set {} } // 0x00000001835E84E0-0x00000001835E8580 0x00000001835E4F30-0x00000001835E4FE0
	public ulong chapterImageHash { /* [XID] */ /* 0x00000001897B4390-0x00000001897B43B0 */ get => default; } // 0x00000001835E79E0-0x00000001835E7AB0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint chapterImageTitleTextMapHash { /* [XID] */ /* 0x00000001897BC070-0x00000001897BC090 */ get => default; /* [XID] */ /* 0x00000001897C3850-0x00000001897C3870 */ protected set {} } // 0x00000001835E8440-0x00000001835E84E0 0x00000001835E7E50-0x00000001835E7F00
	public string chapterImageTitle { /* [XID] */ /* 0x00000001897CB010-0x00000001897CB030 */ get => default; } // 0x00000001835E80B0-0x00000001835E8230 
	public uint inActivityNeedPlayerLevel { /* [XID] */ /* 0x00000001897D26D0-0x00000001897D26F0 */ get => default; /* [XID] */ /* 0x00000001897DA450-0x00000001897DA470 */ protected set {} } // 0x00000001835E7D80-0x00000001835E7E50 0x00000001835E7790-0x00000001835E7870
	public string chapterSerialNumberIcon { /* [XID] */ /* 0x00000001897E1840-0x00000001897E1860 */ get => default; /* [XID] */ /* 0x00000001897E90B0-0x00000001897E90D0 */ protected set {} } // 0x00000001835E7940-0x00000001835E79E0 0x00000001835E5420-0x00000001835E54D0

	// Constructors
	public ChapterExcelConfig() {} // 0x00000001835E86C0-0x00000001835E8720

	// Methods
	// [IDTag] // 0x00000001897F0C60-0x00000001897F0CA0
	// [XID] // 0x00000001897F0C60-0x00000001897F0CA0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001835E5580-0x00000001835E5CF0
	// [IDTag] // 0x00000001897FB650-0x00000001897FB690
	// [XID] // 0x00000001897FB650-0x00000001897FB690
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001835E5CF0-0x00000001835E6480
	// [XID] // 0x0000000189805790-0x00000001898057B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C75 */, bool useObjectPool = false /* Metadata: 0x00AF2C79 */) => default; // 0x00000001835E6C10-0x00000001835E76E0
	[BlackList] // 0x000000018980CDD0-0x000000018980CE10
	// [XID] // 0x000000018980CDD0-0x000000018980CE10
	public virtual void AutoAllocTypeFields() {} // 0x00000001835E4FE0-0x00000001835E5080
	[BlackList] // 0x0000000189817840-0x0000000189817880
	// [XID] // 0x0000000189817840-0x0000000189817880
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835E5080-0x00000001835E51D0
	[BlackList] // 0x00000001898221D0-0x0000000189822210
	// [XID] // 0x00000001898221D0-0x0000000189822210
	public virtual void ReturnToObjectPool() {} // 0x00000001835E8620-0x00000001835E86C0
	[BlackList] // 0x000000018982C7F0-0x000000018982C830
	// [XID] // 0x000000018982C7F0-0x000000018982C830
	public virtual void OnPoolAllocated() {} // 0x00000001835E82D0-0x00000001835E8370
	[BlackList] // 0x0000000189836C30-0x0000000189836C70
	// [XID] // 0x0000000189836C30-0x0000000189836C70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835E8230-0x00000001835E82D0
}

