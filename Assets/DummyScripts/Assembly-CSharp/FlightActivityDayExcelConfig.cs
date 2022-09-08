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
public class FlightActivityDayExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15117
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeFloat[] _pos; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AA7560-0x0000000189AA7580 */ get => default; /* [XID] */ /* 0x0000000189AAEC20-0x0000000189AAEC40 */ protected set {} } // 0x0000000184E67A10-0x0000000184E67AE0 0x0000000184E67480-0x0000000184E67560
	public SimpleSafeFloat[] pos { /* [XID] */ /* 0x0000000189AB6600-0x0000000189AB6620 */ get => default; /* [XID] */ /* 0x0000000189ABE0D0-0x0000000189ABE0F0 */ protected set {} } // 0x0000000184E673E0-0x0000000184E67480 0x0000000184E66B10-0x0000000184E66BC0

	// Constructors
	public FlightActivityDayExcelConfig() {} // 0x0000000184E67B80-0x0000000184E67BE0

	// Methods
	// [IDTag] // 0x0000000189AC5C50-0x0000000189AC5C90
	// [XID] // 0x0000000189AC5C50-0x0000000189AC5C90
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184E66FB0-0x0000000184E673E0
	// [IDTag] // 0x0000000189AD0030-0x0000000189AD0070
	// [XID] // 0x0000000189AD0030-0x0000000189AD0070
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184E66BC0-0x0000000184E66FB0
	// [XID] // 0x0000000189ADAE20-0x0000000189ADAE40
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0148 */, bool useObjectPool = false /* Metadata: 0x00AF014C */) => default; // 0x0000000184E67560-0x0000000184E678D0
	[BlackList] // 0x0000000189AE2580-0x0000000189AE25C0
	// [XID] // 0x0000000189AE2580-0x0000000189AE25C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184E66990-0x0000000184E66A30
	[BlackList] // 0x0000000189AECEE0-0x0000000189AECF20
	// [XID] // 0x0000000189AECEE0-0x0000000189AECF20
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184E66A30-0x0000000184E66B10
	[BlackList] // 0x0000000189AF7A20-0x0000000189AF7A60
	// [XID] // 0x0000000189AF7A20-0x0000000189AF7A60
	public virtual void ReturnToObjectPool() {} // 0x0000000184E67AE0-0x0000000184E67B80
	[BlackList] // 0x0000000189B021B0-0x0000000189B021F0
	// [XID] // 0x0000000189B021B0-0x0000000189B021F0
	public virtual void OnPoolAllocated() {} // 0x0000000184E67970-0x0000000184E67A10
	[BlackList] // 0x0000000189B0C6D0-0x0000000189B0C710
	// [XID] // 0x0000000189B0C6D0-0x0000000189B0C710
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184E678D0-0x0000000184E67970
}

