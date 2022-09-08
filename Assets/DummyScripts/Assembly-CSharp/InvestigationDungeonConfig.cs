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
public class InvestigationDungeonConfig : IAutoAllocRecycle // TypeDefIndex: 15774
{
	// Fields
	protected SimpleSafeUInt32 entranceIdRawNum; // 0x10
	protected SimpleSafeUInt32 cityIdRawNum; // 0x14
	protected SimpleSafeUInt32[] _dungeonIdList; // 0x18

	// Properties
	public uint entranceId { /* [XID] */ /* 0x00000001899AF6B0-0x00000001899AF6D0 */ get => default; /* [XID] */ /* 0x00000001899B6B90-0x00000001899B6BB0 */ protected set {} } // 0x0000000180F12820-0x0000000180F128F0 0x0000000180F13A00-0x0000000180F13AE0
	public uint cityId { /* [XID] */ /* 0x00000001899BE6D0-0x00000001899BE6F0 */ get => default; /* [XID] */ /* 0x00000001899C5F30-0x00000001899C5F50 */ protected set {} } // 0x0000000180F13930-0x0000000180F13A00 0x0000000180F13440-0x0000000180F13520
	public SimpleSafeUInt32[] dungeonIdList { /* [XID] */ /* 0x00000001899CD6D0-0x00000001899CD6F0 */ get => default; /* [XID] */ /* 0x00000001899D4B70-0x00000001899D4B90 */ protected set {} } // 0x0000000180F13C20-0x0000000180F13CC0 0x0000000180F12A80-0x0000000180F12B30

	// Constructors
	public InvestigationDungeonConfig() {} // 0x0000000180F13D60-0x0000000180F13DC0

	// Methods
	// [IDTag] // 0x00000001899DC230-0x00000001899DC270
	// [XID] // 0x00000001899DC230-0x00000001899DC270
	public virtual bool ParseFromLine(string line) => default; // 0x0000000180F12F90-0x0000000180F13440
	// [IDTag] // 0x00000001899E6C90-0x00000001899E6CD0
	// [XID] // 0x00000001899E6C90-0x00000001899E6CD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000180F12B30-0x0000000180F12F90
	// [XID] // 0x00000001899F10D0-0x00000001899F10F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF25A6 */, bool useObjectPool = false /* Metadata: 0x00AF25AA */) => default; // 0x0000000180F13520-0x0000000180F13930
	[BlackList] // 0x00000001899F8930-0x00000001899F8970
	// [XID] // 0x00000001899F8930-0x00000001899F8970
	public virtual void AutoAllocTypeFields() {} // 0x0000000180F128F0-0x0000000180F12990
	[BlackList] // 0x0000000189A03030-0x0000000189A03070
	// [XID] // 0x0000000189A03030-0x0000000189A03070
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180F12990-0x0000000180F12A80
	[BlackList] // 0x0000000189A0D660-0x0000000189A0D6A0
	// [XID] // 0x0000000189A0D660-0x0000000189A0D6A0
	public virtual void ReturnToObjectPool() {} // 0x0000000180F13CC0-0x0000000180F13D60
	[BlackList] // 0x0000000189A17930-0x0000000189A17970
	// [XID] // 0x0000000189A17930-0x0000000189A17970
	public virtual void OnPoolAllocated() {} // 0x0000000180F13B80-0x0000000180F13C20
	[BlackList] // 0x0000000189A22050-0x0000000189A22090
	// [XID] // 0x0000000189A22050-0x0000000189A22090
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180F13AE0-0x0000000180F13B80
}

