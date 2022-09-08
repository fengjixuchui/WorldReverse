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
public class PersonalLineActivityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15942
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected string _perfabPath; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x00000001896A6470-0x00000001896A6490 */ get => default; /* [XID] */ /* 0x00000001896ADA30-0x00000001896ADA50 */ protected set {} } // 0x00000001821723A0-0x0000000182172470 0x0000000182171B90-0x0000000182171C70
	public uint chapterId { /* [XID] */ /* 0x00000001896B5230-0x00000001896B5250 */ get => default; /* [XID] */ /* 0x00000001896BC400-0x00000001896BC420 */ protected set {} } // 0x0000000182171940-0x0000000182171A10 0x00000001821710A0-0x0000000182171180
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001896C3980-0x00000001896C39A0 */ get => default; /* [XID] */ /* 0x00000001896CADD0-0x00000001896CADF0 */ protected set {} } // 0x0000000182172120-0x00000001821721C0 0x0000000182171180-0x0000000182171230
	public string desc { /* [XID] */ /* 0x00000001896D2480-0x00000001896D24A0 */ get => default; } // 0x0000000182171A10-0x0000000182171B90 
	public string perfabPath { /* [XID] */ /* 0x00000001896D9EF0-0x00000001896D9F10 */ get => default; /* [XID] */ /* 0x00000001896E1510-0x00000001896E1530 */ protected set {} } // 0x00000001821721C0-0x0000000182172260 0x0000000182171230-0x00000001821712E0

	// Constructors
	public PersonalLineActivityExcelConfig() {} // 0x0000000182172510-0x0000000182172570

	// Methods
	// [IDTag] // 0x00000001896E87A0-0x00000001896E87E0
	// [XID] // 0x00000001896E87A0-0x00000001896E87E0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001821712E0-0x0000000182171630
	// [IDTag] // 0x00000001896F2CB0-0x00000001896F2CF0
	// [XID] // 0x00000001896F2CB0-0x00000001896F2CF0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182171630-0x0000000182171940
	// [XID] // 0x00000001896FD750-0x00000001896FD770
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BCA */, bool useObjectPool = false /* Metadata: 0x00AF2BCE */) => default; // 0x0000000182171C70-0x0000000182172120
	[BlackList] // 0x0000000189704BF0-0x0000000189704C30
	// [XID] // 0x0000000189704BF0-0x0000000189704C30
	public virtual void AutoAllocTypeFields() {} // 0x0000000182170F10-0x0000000182170FB0
	[BlackList] // 0x000000018970F5C0-0x000000018970F600
	// [XID] // 0x000000018970F5C0-0x000000018970F600
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182170FB0-0x00000001821710A0
	[BlackList] // 0x0000000189719D10-0x0000000189719D50
	// [XID] // 0x0000000189719D10-0x0000000189719D50
	public virtual void ReturnToObjectPool() {} // 0x0000000182172470-0x0000000182172510
	[BlackList] // 0x0000000189723F30-0x0000000189723F70
	// [XID] // 0x0000000189723F30-0x0000000189723F70
	public virtual void OnPoolAllocated() {} // 0x0000000182172300-0x00000001821723A0
	[BlackList] // 0x000000018972E7D0-0x000000018972E810
	// [XID] // 0x000000018972E7D0-0x000000018972E810
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182172260-0x0000000182172300
}

