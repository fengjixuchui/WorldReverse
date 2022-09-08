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
public class LoadingTipsExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15786
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _tipsTitleTextMapHash; // 0x14
	protected uint _tipsDescTextMapHash; // 0x18
	protected string _stageID; // 0x20
	protected string _startTime; // 0x28
	protected string _endTime; // 0x30
	protected SimpleSafeUInt32 minLevelRawNum; // 0x38
	protected SimpleSafeUInt32 maxLevelRawNum; // 0x3C
	protected string _limitOpenState; // 0x40
	protected string _preMainQuestIds; // 0x48
	protected SimpleSafeUInt32 weightRawNum; // 0x50

	// Properties
	public uint id { /* [XID] */ /* 0x000000018965E250-0x000000018965E270 */ get => default; /* [XID] */ /* 0x0000000189665950-0x0000000189665970 */ protected set {} } // 0x00000001816B3B60-0x00000001816B3C30 0x00000001816B2830-0x00000001816B2910
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint tipsTitleTextMapHash { /* [XID] */ /* 0x000000018966D040-0x000000018966D060 */ get => default; /* [XID] */ /* 0x0000000189674F70-0x0000000189674F90 */ protected set {} } // 0x00000001816B32F0-0x00000001816B3390 0x00000001816B3660-0x00000001816B3710
	public string tipsTitle { /* [XID] */ /* 0x000000018967C760-0x000000018967C780 */ get => default; } // 0x00000001816B3710-0x00000001816B3890 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint tipsDescTextMapHash { /* [XID] */ /* 0x0000000189683E10-0x0000000189683E30 */ get => default; /* [XID] */ /* 0x000000018968BA10-0x000000018968BA30 */ protected set {} } // 0x00000001816B2790-0x00000001816B2830 0x00000001816B2910-0x00000001816B29C0
	public string tipsDesc { /* [XID] */ /* 0x0000000189693600-0x0000000189693620 */ get => default; } // 0x00000001816B34E0-0x00000001816B3660 
	public string stageID { /* [XID] */ /* 0x000000018969A8F0-0x000000018969A910 */ get => default; /* [XID] */ /* 0x00000001896A22A0-0x00000001896A22C0 */ protected set {} } // 0x00000001816B1490-0x00000001816B1530 0x00000001816B3890-0x00000001816B3940
	public string startTime { /* [XID] */ /* 0x00000001896A94E0-0x00000001896A9500 */ get => default; /* [XID] */ /* 0x00000001896B0630-0x00000001896B0650 */ protected set {} } // 0x00000001816B1600-0x00000001816B16A0 0x00000001816B2410-0x00000001816B24C0
	public string endTime { /* [XID] */ /* 0x00000001896B8090-0x00000001896B80B0 */ get => default; /* [XID] */ /* 0x00000001896BF130-0x00000001896BF150 */ protected set {} } // 0x00000001816B25A0-0x00000001816B2640 0x00000001816B1770-0x00000001816B1820
	public uint minLevel { /* [XID] */ /* 0x00000001896C6A10-0x00000001896C6A30 */ get => default; /* [XID] */ /* 0x00000001896CE130-0x00000001896CE150 */ protected set {} } // 0x00000001816B1530-0x00000001816B1600 0x00000001816B3940-0x00000001816B3A20
	public uint maxLevel { /* [XID] */ /* 0x00000001896D5660-0x00000001896D5680 */ get => default; /* [XID] */ /* 0x00000001896DCB20-0x00000001896DCB40 */ protected set {} } // 0x00000001816B16A0-0x00000001816B1770 0x00000001816B3D00-0x00000001816B3DE0
	public string limitOpenState { /* [XID] */ /* 0x00000001896E4490-0x00000001896E44B0 */ get => default; /* [XID] */ /* 0x00000001896EB8C0-0x00000001896EB8E0 */ protected set {} } // 0x00000001816B3440-0x00000001816B34E0 0x00000001816B3390-0x00000001816B3440
	public string preMainQuestIds { /* [XID] */ /* 0x00000001896F2D30-0x00000001896F2D50 */ get => default; /* [XID] */ /* 0x00000001896FA650-0x00000001896FA670 */ protected set {} } // 0x00000001816B26F0-0x00000001816B2790 0x00000001816B2640-0x00000001816B26F0
	public uint weight { /* [XID] */ /* 0x0000000189701CC0-0x0000000189701CE0 */ get => default; /* [XID] */ /* 0x00000001897095C0-0x00000001897095E0 */ protected set {} } // 0x00000001816B3C30-0x00000001816B3D00 0x00000001816B24C0-0x00000001816B25A0

	// Constructors
	public LoadingTipsExcelConfig() {} // 0x00000001816B3E80-0x00000001816B3EE0

	// Methods
	// [IDTag] // 0x0000000189710E50-0x0000000189710E90
	// [XID] // 0x0000000189710E50-0x0000000189710E90
	public virtual bool ParseFromLine(string line) => default; // 0x00000001816B1E20-0x00000001816B2410
	// [IDTag] // 0x000000018971B580-0x000000018971B5C0
	// [XID] // 0x000000018971B580-0x000000018971B5C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001816B1820-0x00000001816B1E20
	// [XID] // 0x00000001897259A0-0x00000001897259C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF25F7 */, bool useObjectPool = false /* Metadata: 0x00AF25FB */) => default; // 0x00000001816B29C0-0x00000001816B32F0
	[BlackList] // 0x000000018972CF00-0x000000018972CF40
	// [XID] // 0x000000018972CF00-0x000000018972CF40
	public virtual void AutoAllocTypeFields() {} // 0x00000001816B12D0-0x00000001816B1370
	[BlackList] // 0x0000000189737A20-0x0000000189737A60
	// [XID] // 0x0000000189737A20-0x0000000189737A60
	public virtual void AutoRecycleTypeFields() {} // 0x00000001816B1370-0x00000001816B1490
	[BlackList] // 0x0000000189742000-0x0000000189742040
	// [XID] // 0x0000000189742000-0x0000000189742040
	public virtual void ReturnToObjectPool() {} // 0x00000001816B3DE0-0x00000001816B3E80
	[BlackList] // 0x000000018974CAE0-0x000000018974CB20
	// [XID] // 0x000000018974CAE0-0x000000018974CB20
	public virtual void OnPoolAllocated() {} // 0x00000001816B3AC0-0x00000001816B3B60
	[BlackList] // 0x0000000189756F80-0x0000000189756FC0
	// [XID] // 0x0000000189756F80-0x0000000189756FC0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001816B3A20-0x00000001816B3AC0
}

