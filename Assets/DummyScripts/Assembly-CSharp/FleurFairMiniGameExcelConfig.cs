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
public class FleurFairMiniGameExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15102
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected FleurFairMiniGameType _miniGameType; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected SimpleSafeUInt32 galleryIdRawNum; // 0x1C
	protected SimpleSafeUInt32 configIdRawNum; // 0x20
	protected SimpleSafeUInt32 openDayRawNum; // 0x24
	protected SimpleSafeUInt32 questIdRawNum; // 0x28
	protected uint _rewardRankLowTextMapHash; // 0x2C
	protected uint _rewardRankMiddleTextMapHash; // 0x30
	protected uint _rewardRankHighTextMapHash; // 0x34
	protected SimpleSafeUInt32[] _watcherIdList; // 0x38
	protected SimpleSafeUInt32[] _avatarIdList; // 0x40
	protected SimpleSafeUInt32[] _avatarScore; // 0x48
	protected SimpleSafeUInt32[] _tipsIdList; // 0x50
	protected uint _tipsDescTextMapHash; // 0x58
	protected SimpleSafeFloat[] _pos; // 0x60

	// Properties
	public uint id { /* [XID] */ /* 0x000000018963BF20-0x000000018963BF40 */ get => default; /* [XID] */ /* 0x0000000189643620-0x0000000189643640 */ protected set {} } // 0x000000018254F3F0-0x000000018254F4C0 0x000000018254DB50-0x000000018254DC30
	public FleurFairMiniGameType miniGameType { /* [XID] */ /* 0x000000018964AC00-0x000000018964AC20 */ get => default; /* [XID] */ /* 0x00000001896523C0-0x00000001896523E0 */ protected set {} } // 0x000000018254F860-0x000000018254F900 0x000000018254F560-0x000000018254F610
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189659AF0-0x0000000189659B10 */ get => default; /* [XID] */ /* 0x0000000189661290-0x00000001896612B0 */ protected set {} } // 0x000000018254EA00-0x000000018254EAA0 0x000000018254ADC0-0x000000018254AE70
	public string desc { /* [XID] */ /* 0x0000000189668D20-0x0000000189668D40 */ get => default; } // 0x000000018254D860-0x000000018254D9E0 
	public uint galleryId { /* [XID] */ /* 0x0000000189670850-0x0000000189670870 */ get => default; /* [XID] */ /* 0x0000000189678050-0x0000000189678070 */ protected set {} } // 0x000000018254F610-0x000000018254F6E0 0x000000018254EAA0-0x000000018254EB80
	public uint configId { /* [XID] */ /* 0x000000018967F740-0x000000018967F760 */ get => default; /* [XID] */ /* 0x0000000189686FD0-0x0000000189686FF0 */ protected set {} } // 0x000000018254D9E0-0x000000018254DAB0 0x000000018254ED90-0x000000018254EE70
	public uint openDay { /* [XID] */ /* 0x000000018968EDD0-0x000000018968EDF0 */ get => default; /* [XID] */ /* 0x0000000189696750-0x0000000189696770 */ protected set {} } // 0x000000018254F090-0x000000018254F160 0x000000018254A8F0-0x000000018254A9D0
	public uint questId { /* [XID] */ /* 0x000000018969DDF0-0x000000018969DE10 */ get => default; /* [XID] */ /* 0x00000001896A4DC0-0x00000001896A4DE0 */ protected set {} } // 0x000000018254D120-0x000000018254D1F0 0x000000018254D550-0x000000018254D630
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint rewardRankLowTextMapHash { /* [XID] */ /* 0x00000001896AC670-0x00000001896AC690 */ get => default; /* [XID] */ /* 0x00000001896B38F0-0x00000001896B3910 */ protected set {} } // 0x000000018254F160-0x000000018254F200 0x000000018254EC30-0x000000018254ECE0
	public string rewardRankLow { /* [XID] */ /* 0x00000001896BAFD0-0x00000001896BAFF0 */ get => default; } // 0x000000018254D330-0x000000018254D4B0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint rewardRankMiddleTextMapHash { /* [XID] */ /* 0x00000001896C2140-0x00000001896C2160 */ get => default; /* [XID] */ /* 0x00000001896C9750-0x00000001896C9770 */ protected set {} } // 0x000000018254F4C0-0x000000018254F560 0x000000018254AC60-0x000000018254AD10
	public string rewardRankMiddle { /* [XID] */ /* 0x00000001896D0EC0-0x00000001896D0EE0 */ get => default; } // 0x000000018254D630-0x000000018254D7B0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint rewardRankHighTextMapHash { /* [XID] */ /* 0x00000001896D8630-0x00000001896D8650 */ get => default; /* [XID] */ /* 0x00000001896DFFE0-0x00000001896E0000 */ protected set {} } // 0x000000018254D1F0-0x000000018254D290 0x000000018254EB80-0x000000018254EC30
	public string rewardRankHigh { /* [XID] */ /* 0x00000001896E7200-0x00000001896E7220 */ get => default; } // 0x000000018254F6E0-0x000000018254F860 
	public SimpleSafeUInt32[] watcherIdList { /* [XID] */ /* 0x00000001896EE870-0x00000001896EE890 */ get => default; /* [XID] */ /* 0x00000001896F6140-0x00000001896F6160 */ protected set {} } // 0x000000018254EFF0-0x000000018254F090 0x000000018254ECE0-0x000000018254ED90
	public SimpleSafeUInt32[] avatarIdList { /* [XID] */ /* 0x00000001896FD930-0x00000001896FD950 */ get => default; /* [XID] */ /* 0x0000000189704DD0-0x0000000189704DF0 */ protected set {} } // 0x000000018254D290-0x000000018254D330 0x000000018254F200-0x000000018254F2B0
	public SimpleSafeUInt32[] avatarScore { /* [XID] */ /* 0x000000018970C4D0-0x000000018970C4F0 */ get => default; /* [XID] */ /* 0x0000000189713E40-0x0000000189713E60 */ protected set {} } // 0x000000018254E960-0x000000018254EA00 0x000000018254ABB0-0x000000018254AC60
	public SimpleSafeUInt32[] tipsIdList { /* [XID] */ /* 0x000000018971B6C0-0x000000018971B6E0 */ get => default; /* [XID] */ /* 0x0000000189722940-0x0000000189722960 */ protected set {} } // 0x000000018254A850-0x000000018254A8F0 0x000000018254D7B0-0x000000018254D860
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint tipsDescTextMapHash { /* [XID] */ /* 0x000000018972A0C0-0x000000018972A0E0 */ get => default; /* [XID] */ /* 0x0000000189731720-0x0000000189731740 */ protected set {} } // 0x000000018254DAB0-0x000000018254DB50 0x000000018254DC30-0x000000018254DCE0
	public string tipsDesc { /* [XID] */ /* 0x0000000189738F90-0x0000000189738FB0 */ get => default; } // 0x000000018254EE70-0x000000018254EFF0 
	public SimpleSafeFloat[] pos { /* [XID] */ /* 0x0000000189740D40-0x0000000189740D60 */ get => default; /* [XID] */ /* 0x0000000189748240-0x0000000189748260 */ protected set {} } // 0x000000018254D4B0-0x000000018254D550 0x000000018254AD10-0x000000018254ADC0

	// Constructors
	public FleurFairMiniGameExcelConfig() {} // 0x000000018254F9A0-0x000000018254FA00

	// Methods
	// [IDTag] // 0x000000018974FAD0-0x000000018974FB10
	// [XID] // 0x000000018974FAD0-0x000000018974FB10
	public virtual bool ParseFromLine(string line) => default; // 0x000000018254BFE0-0x000000018254D120
	// [IDTag] // 0x0000000189759C20-0x0000000189759C60
	// [XID] // 0x0000000189759C20-0x0000000189759C60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018254AE70-0x000000018254BFE0
	// [XID] // 0x0000000189764480-0x00000001897644A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF00DF */, bool useObjectPool = false /* Metadata: 0x00AF00E3 */) => default; // 0x000000018254DCE0-0x000000018254E960
	[BlackList] // 0x000000018976BE20-0x000000018976BE60
	// [XID] // 0x000000018976BE20-0x000000018976BE60
	public virtual void AutoAllocTypeFields() {} // 0x000000018254A9D0-0x000000018254AA70
	[BlackList] // 0x0000000189776580-0x00000001897765C0
	// [XID] // 0x0000000189776580-0x00000001897765C0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018254AA70-0x000000018254ABB0
	[BlackList] // 0x0000000189780CC0-0x0000000189780D00
	// [XID] // 0x0000000189780CC0-0x0000000189780D00
	public virtual void ReturnToObjectPool() {} // 0x000000018254F900-0x000000018254F9A0
	[BlackList] // 0x000000018978B4E0-0x000000018978B520
	// [XID] // 0x000000018978B4E0-0x000000018978B520
	public virtual void OnPoolAllocated() {} // 0x000000018254F350-0x000000018254F3F0
	[BlackList] // 0x0000000189795860-0x00000001897958A0
	// [XID] // 0x0000000189795860-0x00000001897958A0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018254F2B0-0x000000018254F350
}

