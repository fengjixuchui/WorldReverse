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
public class ChannellerSlabChapterExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15041
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x14
	protected SimpleSafeUInt32 openDayRawNum; // 0x18
	protected uint _titleTextMapHash; // 0x1C
	protected SimpleSafeUInt32 preQuestRawNum; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AF61D0-0x0000000189AF61F0 */ get => default; /* [XID] */ /* 0x0000000189AFD810-0x0000000189AFD830 */ protected set {} } // 0x0000000184ABBB60-0x0000000184ABBC30 0x0000000184ABB0D0-0x0000000184ABB1B0
	public uint chapterId { /* [XID] */ /* 0x0000000189B04FC0-0x0000000189B04FE0 */ get => default; /* [XID] */ /* 0x0000000189B0C730-0x0000000189B0C750 */ protected set {} } // 0x0000000184ABAF20-0x0000000184ABAFF0 0x0000000184ABA620-0x0000000184ABA700
	public uint openDay { /* [XID] */ /* 0x0000000189B13B70-0x0000000189B13B90 */ get => default; /* [XID] */ /* 0x0000000189B1B380-0x0000000189B1B3A0 */ protected set {} } // 0x0000000184ABB950-0x0000000184ABBA20 0x0000000184ABA2F0-0x0000000184ABA3D0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189B229D0-0x0000000189B229F0 */ get => default; /* [XID] */ /* 0x0000000189B2A040-0x0000000189B2A060 */ protected set {} } // 0x0000000184ABA580-0x0000000184ABA620 0x0000000184ABA700-0x0000000184ABA7B0
	public string title { /* [XID] */ /* 0x0000000189B316D0-0x0000000189B316F0 */ get => default; } // 0x0000000184ABB700-0x0000000184ABB880 
	public uint preQuest { /* [XID] */ /* 0x0000000189B38AD0-0x0000000189B38AF0 */ get => default; /* [XID] */ /* 0x0000000189B404A0-0x0000000189B404C0 */ protected set {} } // 0x0000000184ABB880-0x0000000184ABB950 0x0000000184ABAFF0-0x0000000184ABB0D0

	// Constructors
	public ChannellerSlabChapterExcelConfig() {} // 0x0000000184ABBCD0-0x0000000184ABBD30

	// Methods
	// [IDTag] // 0x0000000189B47DE0-0x0000000189B47E20
	// [XID] // 0x0000000189B47DE0-0x0000000189B47E20
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184ABA7B0-0x0000000184ABAB80
	// [IDTag] // 0x0000000189B524E0-0x0000000189B52520
	// [XID] // 0x0000000189B524E0-0x0000000189B52520
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184ABAB80-0x0000000184ABAF20
	// [XID] // 0x0000000189B5CF70-0x0000000189B5CF90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF3C */, bool useObjectPool = false /* Metadata: 0x00AEFF40 */) => default; // 0x0000000184ABB1B0-0x0000000184ABB700
	[BlackList] // 0x0000000189B64670-0x0000000189B646B0
	// [XID] // 0x0000000189B64670-0x0000000189B646B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184ABA3D0-0x0000000184ABA470
	[BlackList] // 0x0000000189B6EA80-0x0000000189B6EAC0
	// [XID] // 0x0000000189B6EA80-0x0000000189B6EAC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184ABA470-0x0000000184ABA580
	[BlackList] // 0x0000000189B79160-0x0000000189B791A0
	// [XID] // 0x0000000189B79160-0x0000000189B791A0
	public virtual void ReturnToObjectPool() {} // 0x0000000184ABBC30-0x0000000184ABBCD0
	[BlackList] // 0x0000000189B83A40-0x0000000189B83A80
	// [XID] // 0x0000000189B83A40-0x0000000189B83A80
	public virtual void OnPoolAllocated() {} // 0x0000000184ABBAC0-0x0000000184ABBB60
	[BlackList] // 0x0000000189B8DC70-0x0000000189B8DCB0
	// [XID] // 0x0000000189B8DC70-0x0000000189B8DCB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184ABBA20-0x0000000184ABBAC0
}

