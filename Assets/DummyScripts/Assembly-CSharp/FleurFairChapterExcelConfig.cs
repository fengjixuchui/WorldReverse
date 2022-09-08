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
public class FleurFairChapterExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15100
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x14
	protected SimpleSafeUInt32 openDayRawNum; // 0x18
	protected uint _titleTextMapHash; // 0x1C
	protected uint _descTextMapHash; // 0x20
	protected SimpleSafeUInt32 mainQuestRawNum; // 0x24
	protected SimpleSafeUInt32 preQuestRawNum; // 0x28
	protected SimpleSafeUInt32[] _miniQuest; // 0x30
	protected string _icon; // 0x38

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189ABE110-0x0000000189ABE130 */ get => default; /* [XID] */ /* 0x0000000189AC5CD0-0x0000000189AC5CF0 */ protected set {} } // 0x0000000182B7D0B0-0x0000000182B7D180 0x0000000182B7C0B0-0x0000000182B7C190
	public uint chapterId { /* [XID] */ /* 0x0000000189ACD1A0-0x0000000189ACD1C0 */ get => default; /* [XID] */ /* 0x0000000189AD4F40-0x0000000189AD4F60 */ protected set {} } // 0x0000000182B7BCB0-0x0000000182B7BD80 0x0000000182B7ABA0-0x0000000182B7AC80
	public uint openDay { /* [XID] */ /* 0x0000000189ADC7E0-0x0000000189ADC800 */ get => default; /* [XID] */ /* 0x0000000189AE4130-0x0000000189AE4150 */ protected set {} } // 0x0000000182B7CEA0-0x0000000182B7CF70 0x0000000182B7A850-0x0000000182B7A930
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189AEB990-0x0000000189AEB9B0 */ get => default; /* [XID] */ /* 0x0000000189AF33B0-0x0000000189AF33D0 */ protected set {} } // 0x0000000182B7AB00-0x0000000182B7ABA0 0x0000000182B7AD30-0x0000000182B7ADE0
	public string title { /* [XID] */ /* 0x0000000189AFAC80-0x0000000189AFACA0 */ get => default; } // 0x0000000182B7CBA0-0x0000000182B7CD20 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189B021F0-0x0000000189B02210 */ get => default; /* [XID] */ /* 0x0000000189B095F0-0x0000000189B09610 */ protected set {} } // 0x0000000182B7CA20-0x0000000182B7CAC0 0x0000000182B7AC80-0x0000000182B7AD30
	public string desc { /* [XID] */ /* 0x0000000189B11190-0x0000000189B111B0 */ get => default; } // 0x0000000182B7BF30-0x0000000182B7C0B0 
	public uint mainQuest { /* [XID] */ /* 0x0000000189B183C0-0x0000000189B183E0 */ get => default; /* [XID] */ /* 0x0000000189B1FAA0-0x0000000189B1FAC0 */ protected set {} } // 0x0000000182B7BD80-0x0000000182B7BE50 0x0000000182B7CAC0-0x0000000182B7CBA0
	public uint preQuest { /* [XID] */ /* 0x0000000189B272A0-0x0000000189B272C0 */ get => default; /* [XID] */ /* 0x0000000189B2E430-0x0000000189B2E450 */ protected set {} } // 0x0000000182B7CD20-0x0000000182B7CDF0 0x0000000182B7BE50-0x0000000182B7BF30
	public SimpleSafeUInt32[] miniQuest { /* [XID] */ /* 0x0000000189B35920-0x0000000189B35940 */ get => default; /* [XID] */ /* 0x0000000189B3D0E0-0x0000000189B3D100 */ protected set {} } // 0x0000000182B7D180-0x0000000182B7D220 0x0000000182B7C970-0x0000000182B7CA20
	public string icon { /* [XID] */ /* 0x0000000189B44F30-0x0000000189B44F50 */ get => default; /* [XID] */ /* 0x0000000189B4C700-0x0000000189B4C720 */ protected set {} } // 0x0000000182B7A7B0-0x0000000182B7A850 0x0000000182B7CDF0-0x0000000182B7CEA0

	// Constructors
	public FleurFairChapterExcelConfig() {} // 0x0000000182B7D2C0-0x0000000182B7D320

	// Methods
	// [IDTag] // 0x0000000189B53D80-0x0000000189B53DC0
	// [XID] // 0x0000000189B53D80-0x0000000189B53DC0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182B7ADE0-0x0000000182B7B540
	// [IDTag] // 0x0000000189B5E7E0-0x0000000189B5E820
	// [XID] // 0x0000000189B5E7E0-0x0000000189B5E820
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182B7B540-0x0000000182B7BCB0
	// [XID] // 0x0000000189B68FC0-0x0000000189B68FE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF00D0 */, bool useObjectPool = false /* Metadata: 0x00AF00D4 */) => default; // 0x0000000182B7C190-0x0000000182B7C970
	[BlackList] // 0x0000000189B70400-0x0000000189B70440
	// [XID] // 0x0000000189B70400-0x0000000189B70440
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B7A930-0x0000000182B7A9D0
	[BlackList] // 0x0000000189B7A8F0-0x0000000189B7A930
	// [XID] // 0x0000000189B7A8F0-0x0000000189B7A930
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B7A9D0-0x0000000182B7AB00
	[BlackList] // 0x0000000189B85570-0x0000000189B855B0
	// [XID] // 0x0000000189B85570-0x0000000189B855B0
	public virtual void ReturnToObjectPool() {} // 0x0000000182B7D220-0x0000000182B7D2C0
	[BlackList] // 0x0000000189B8F410-0x0000000189B8F450
	// [XID] // 0x0000000189B8F410-0x0000000189B8F450
	public virtual void OnPoolAllocated() {} // 0x0000000182B7D010-0x0000000182B7D0B0
	[BlackList] // 0x0000000189B99820-0x0000000189B99860
	// [XID] // 0x0000000189B99820-0x0000000189B99860
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B7CF70-0x0000000182B7D010
}

