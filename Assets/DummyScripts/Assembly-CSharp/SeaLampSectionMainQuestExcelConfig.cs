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
public class SeaLampSectionMainQuestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15183
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected SimpleSafeUInt32[] _questId; // 0x20
	protected uint _introTextMapHash; // 0x28
	protected SimpleSafeUInt32 openDayRawNum; // 0x2C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B37490-0x0000000189B374B0 */ get => default; /* [XID] */ /* 0x0000000189B3ED00-0x0000000189B3ED20 */ protected set {} } // 0x00000001835211D0-0x00000001835212A0 0x0000000183520700-0x00000001835207E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189B467C0-0x0000000189B467E0 */ get => default; /* [XID] */ /* 0x0000000189B4DD00-0x0000000189B4DD20 */ protected set {} } // 0x000000018351F540-0x000000018351F5E0 0x0000000183520F10-0x0000000183520FC0
	public string name { /* [XID] */ /* 0x0000000189B555B0-0x0000000189B555D0 */ get => default; } // 0x00000001835212A0-0x0000000183521420 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189B5CEB0-0x0000000189B5CED0 */ get => default; /* [XID] */ /* 0x0000000189B64570-0x0000000189B64590 */ protected set {} } // 0x0000000183520E70-0x0000000183520F10 0x000000018351F5E0-0x000000018351F690
	public string desc { /* [XID] */ /* 0x0000000189B6BA70-0x0000000189B6BA90 */ get => default; } // 0x0000000183520580-0x0000000183520700 
	public SimpleSafeUInt32[] questId { /* [XID] */ /* 0x0000000189B73350-0x0000000189B73370 */ get => default; /* [XID] */ /* 0x0000000189B7A890-0x0000000189B7A8B0 */ protected set {} } // 0x00000001835202B0-0x0000000183520350 0x00000001835204D0-0x0000000183520580
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint introTextMapHash { /* [XID] */ /* 0x0000000189B82090-0x0000000189B820B0 */ get => default; /* [XID] */ /* 0x0000000189B89850-0x0000000189B89870 */ protected set {} } // 0x00000001835207E0-0x0000000183520880 0x000000018351F220-0x000000018351F2D0
	public string intro { /* [XID] */ /* 0x0000000189B90E30-0x0000000189B90E50 */ get => default; } // 0x0000000183520350-0x00000001835204D0 
	public uint openDay { /* [XID] */ /* 0x0000000189B98160-0x0000000189B98180 */ get => default; /* [XID] */ /* 0x0000000189B9F610-0x0000000189B9F630 */ protected set {} } // 0x0000000183520FC0-0x0000000183521090 0x000000018351F2D0-0x000000018351F3B0

	// Constructors
	public SeaLampSectionMainQuestExcelConfig() {} // 0x00000001835214C0-0x0000000183521520

	// Methods
	// [IDTag] // 0x0000000189BA6DC0-0x0000000189BA6E00
	// [XID] // 0x0000000189BA6DC0-0x0000000189BA6E00
	public virtual bool ParseFromLine(string line) => default; // 0x000000018351F690-0x000000018351FCB0
	// [IDTag] // 0x0000000189BB1630-0x0000000189BB1670
	// [XID] // 0x0000000189BB1630-0x0000000189BB1670
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018351FCB0-0x00000001835202B0
	// [XID] // 0x0000000189BBB830-0x0000000189BBB850
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0326 */, bool useObjectPool = false /* Metadata: 0x00AF032A */) => default; // 0x0000000183520880-0x0000000183520E70
	[BlackList] // 0x0000000189BC3670-0x0000000189BC36B0
	// [XID] // 0x0000000189BC3670-0x0000000189BC36B0
	public virtual void AutoAllocTypeFields() {} // 0x000000018351F3B0-0x000000018351F450
	[BlackList] // 0x0000000189BCDE00-0x0000000189BCDE40
	// [XID] // 0x0000000189BCDE00-0x0000000189BCDE40
	public virtual void AutoRecycleTypeFields() {} // 0x000000018351F450-0x000000018351F540
	[BlackList] // 0x0000000189BD80D0-0x0000000189BD8110
	// [XID] // 0x0000000189BD80D0-0x0000000189BD8110
	public virtual void ReturnToObjectPool() {} // 0x0000000183521420-0x00000001835214C0
	[BlackList] // 0x00000001895E7E70-0x00000001895E7EB0
	// [XID] // 0x00000001895E7E70-0x00000001895E7EB0
	public virtual void OnPoolAllocated() {} // 0x0000000183521130-0x00000001835211D0
	[BlackList] // 0x00000001895F2510-0x00000001895F2550
	// [XID] // 0x00000001895F2510-0x00000001895F2550
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183521090-0x0000000183521130
}

