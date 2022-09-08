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
public class AsterStageExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15022
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x18
	protected uint _titleTextMapHash; // 0x1C
	protected uint _stageNameTextMapHash; // 0x20
	protected SimpleSafeUInt32 opendayRawNum; // 0x24
	protected SimpleSafeUInt32 openQuestIdRawNum; // 0x28
	protected uint _introTextMapHash; // 0x2C
	protected uint _storyTextMapHash; // 0x30
	protected SimpleSafeUInt32 unlockScoreRawNum; // 0x34
	protected SimpleSafeUInt32[] _questIdList; // 0x38
	protected SimpleSafeUInt32 rewardPreviewIdRawNum; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x000000018989F1A0-0x000000018989F1C0 */ get => default; /* [XID] */ /* 0x00000001898A6D40-0x00000001898A6D60 */ protected set {} } // 0x000000018512BC00-0x000000018512BCD0 0x000000018512A790-0x000000018512A870
	public uint activityId { /* [XID] */ /* 0x00000001898AE550-0x00000001898AE570 */ get => default; /* [XID] */ /* 0x00000001898B5A30-0x00000001898B5A50 */ protected set {} } // 0x000000018512B720-0x000000018512B7F0 0x000000018512A6B0-0x000000018512A790
	public uint chapterId { /* [XID] */ /* 0x00000001898BD440-0x00000001898BD460 */ get => default; /* [XID] */ /* 0x00000001898C4BE0-0x00000001898C4C00 */ protected set {} } // 0x0000000185129F80-0x000000018512A050 0x0000000185128C60-0x0000000185128D40
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x00000001898CC010-0x00000001898CC030 */ get => default; /* [XID] */ /* 0x00000001898D38B0-0x00000001898D38D0 */ protected set {} } // 0x0000000185128BC0-0x0000000185128C60 0x0000000185128D40-0x0000000185128DF0
	public string title { /* [XID] */ /* 0x00000001898DB0C0-0x00000001898DB0E0 */ get => default; } // 0x000000018512B4C0-0x000000018512B640 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint stageNameTextMapHash { /* [XID] */ /* 0x00000001898E2E20-0x00000001898E2E40 */ get => default; /* [XID] */ /* 0x00000001898EAAD0-0x00000001898EAAF0 */ protected set {} } // 0x000000018512A9C0-0x000000018512AA60 0x000000018512B7F0-0x000000018512B8A0
	public string stageName { /* [XID] */ /* 0x00000001898F2210-0x00000001898F2230 */ get => default; } // 0x00000001851285F0-0x0000000185128770 
	public uint openday { /* [XID] */ /* 0x00000001898F9A10-0x00000001898F9A30 */ get => default; /* [XID] */ /* 0x00000001899013B0-0x00000001899013D0 */ protected set {} } // 0x000000018512A5E0-0x000000018512A6B0 0x000000018512A420-0x000000018512A500
	public uint openQuestId { /* [XID] */ /* 0x0000000189908B70-0x0000000189908B90 */ get => default; /* [XID] */ /* 0x0000000189910130-0x0000000189910150 */ protected set {} } // 0x000000018512B9F0-0x000000018512BAC0 0x000000018512B640-0x000000018512B720
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint introTextMapHash { /* [XID] */ /* 0x0000000189917D20-0x0000000189917D40 */ get => default; /* [XID] */ /* 0x000000018991F260-0x000000018991F280 */ protected set {} } // 0x000000018512A870-0x000000018512A910 0x0000000185128770-0x0000000185128820
	public string intro { /* [XID] */ /* 0x0000000189926DE0-0x0000000189926E00 */ get => default; } // 0x000000018512A050-0x000000018512A1D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint storyTextMapHash { /* [XID] */ /* 0x000000018992E470-0x000000018992E490 */ get => default; /* [XID] */ /* 0x0000000189935790-0x00000001899357B0 */ protected set {} } // 0x000000018512B8A0-0x000000018512B940 0x000000018512A910-0x000000018512A9C0
	public string story { /* [XID] */ /* 0x000000018993D2F0-0x000000018993D310 */ get => default; } // 0x000000018512A2A0-0x000000018512A420 
	public uint unlockScore { /* [XID] */ /* 0x00000001899449E0-0x0000000189944A00 */ get => default; /* [XID] */ /* 0x000000018994BFC0-0x000000018994BFE0 */ protected set {} } // 0x0000000185128AF0-0x0000000185128BC0 0x0000000185128A10-0x0000000185128AF0
	public SimpleSafeUInt32[] questIdList { /* [XID] */ /* 0x0000000189953650-0x0000000189953670 */ get => default; /* [XID] */ /* 0x000000018995AE10-0x000000018995AE30 */ protected set {} } // 0x000000018512B420-0x000000018512B4C0 0x000000018512B940-0x000000018512B9F0
	public uint rewardPreviewId { /* [XID] */ /* 0x0000000189962AF0-0x0000000189962B10 */ get => default; /* [XID] */ /* 0x0000000189969DE0-0x0000000189969E00 */ protected set {} } // 0x000000018512A1D0-0x000000018512A2A0 0x000000018512A500-0x000000018512A5E0

	// Constructors
	public AsterStageExcelConfig() {} // 0x000000018512BD70-0x000000018512BDD0

	// Methods
	// [IDTag] // 0x0000000189971B80-0x0000000189971BC0
	// [XID] // 0x0000000189971B80-0x0000000189971BC0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000185128DF0-0x00000001851296B0
	// [IDTag] // 0x000000018997BCC0-0x000000018997BD00
	// [XID] // 0x000000018997BCC0-0x000000018997BD00
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001851296B0-0x0000000185129F80
	// [XID] // 0x0000000189986470-0x0000000189986490
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEB7 */, bool useObjectPool = false /* Metadata: 0x00AEFEBB */) => default; // 0x000000018512AA60-0x000000018512B420
	[BlackList] // 0x000000018998E0E0-0x000000018998E120
	// [XID] // 0x000000018998E0E0-0x000000018998E120
	public virtual void AutoAllocTypeFields() {} // 0x0000000185128820-0x00000001851288C0
	[BlackList] // 0x0000000189998D90-0x0000000189998DD0
	// [XID] // 0x0000000189998D90-0x0000000189998DD0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851288C0-0x0000000185128A10
	[BlackList] // 0x00000001899A3630-0x00000001899A3670
	// [XID] // 0x00000001899A3630-0x00000001899A3670
	public virtual void ReturnToObjectPool() {} // 0x000000018512BCD0-0x000000018512BD70
	[BlackList] // 0x00000001899ADFA0-0x00000001899ADFE0
	// [XID] // 0x00000001899ADFA0-0x00000001899ADFE0
	public virtual void OnPoolAllocated() {} // 0x000000018512BB60-0x000000018512BC00
	[BlackList] // 0x00000001899B84F0-0x00000001899B8530
	// [XID] // 0x00000001899B84F0-0x00000001899B8530
	public virtual void OnBeforePoolRecycled() {} // 0x000000018512BAC0-0x000000018512BB60
}

