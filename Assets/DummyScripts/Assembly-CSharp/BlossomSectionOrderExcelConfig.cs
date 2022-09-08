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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BlossomSectionOrderExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15273
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 cityIdRawNum; // 0x14
	protected SimpleSafeUInt32 sectionIdRawNum; // 0x18
	protected SimpleSafeUInt32 orderRawNum; // 0x1C

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899685E0-0x0000000189968600 */ get => default; /* [XID] */ /* 0x000000018996FAE0-0x000000018996FB00 */ protected set {} } // 0x0000000183D8F540-0x0000000183D8F610 0x0000000183D8ECD0-0x0000000183D8EDB0
	public uint cityId { /* [XID] */ /* 0x0000000189977920-0x0000000189977940 */ get => default; /* [XID] */ /* 0x000000018997EAE0-0x000000018997EB00 */ protected set {} } // 0x0000000183D8F330-0x0000000183D8F400 0x0000000183D8EB10-0x0000000183D8EBF0
	public uint sectionId { /* [XID] */ /* 0x0000000189986410-0x0000000189986430 */ get => default; /* [XID] */ /* 0x000000018998E0C0-0x000000018998E0E0 */ protected set {} } // 0x0000000183D8EDB0-0x0000000183D8EE80 0x0000000183D8EA30-0x0000000183D8EB10
	public uint order { /* [XID] */ /* 0x0000000189995B70-0x0000000189995B90 */ get => default; /* [XID] */ /* 0x000000018999D550-0x000000018999D570 */ protected set {} } // 0x0000000183D8E2F0-0x0000000183D8E3C0 0x0000000183D8EBF0-0x0000000183D8ECD0

	// Constructors
	public BlossomSectionOrderExcelConfig() {} // 0x0000000183D8F6B0-0x0000000183D8F710

	// Methods
	// [IDTag] // 0x00000001899A4E10-0x00000001899A4E50
	// [XID] // 0x00000001899A4E10-0x00000001899A4E50
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183D8E3C0-0x0000000183D8E710
	// [IDTag] // 0x00000001899AF7B0-0x00000001899AF7F0
	// [XID] // 0x00000001899AF7B0-0x00000001899AF7F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183D8E710-0x0000000183D8EA30
	// [XID] // 0x00000001899B9CF0-0x00000001899B9D10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05EB */, bool useObjectPool = false /* Metadata: 0x00AF05EF */) => default; // 0x0000000183D8EE80-0x0000000183D8F330
	[BlackList] // 0x00000001899C17D0-0x00000001899C1810
	// [XID] // 0x00000001899C17D0-0x00000001899C1810
	public virtual void AutoAllocTypeFields() {} // 0x0000000183D8E140-0x0000000183D8E1E0
	[BlackList] // 0x00000001899CBFE0-0x00000001899CC020
	// [XID] // 0x00000001899CBFE0-0x00000001899CC020
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183D8E1E0-0x0000000183D8E2F0
	[BlackList] // 0x00000001899D6470-0x00000001899D64B0
	// [XID] // 0x00000001899D6470-0x00000001899D64B0
	public virtual void ReturnToObjectPool() {} // 0x0000000183D8F610-0x0000000183D8F6B0
	[BlackList] // 0x00000001899E0A00-0x00000001899E0A40
	// [XID] // 0x00000001899E0A00-0x00000001899E0A40
	public virtual void OnPoolAllocated() {} // 0x0000000183D8F4A0-0x0000000183D8F540
	[BlackList] // 0x00000001899EAF60-0x00000001899EAFA0
	// [XID] // 0x00000001899EAF60-0x00000001899EAFA0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183D8F400-0x0000000183D8F4A0
}

