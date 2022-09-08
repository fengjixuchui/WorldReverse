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
public class StrengthenBasePointExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16175
{
	// Fields
	protected SimpleSafeUInt32 dungeonIdRawNum; // 0x10
	protected StrengthenDungeonType _dungeonType; // 0x14

	// Properties
	public uint dungeonId { /* [XID] */ /* 0x000000018998AF60-0x000000018998AF80 */ get => default; /* [XID] */ /* 0x00000001899928B0-0x00000001899928D0 */ protected set {} } // 0x00000001832A1950-0x00000001832A1A20 0x00000001832A1B60-0x00000001832A1C40
	public StrengthenDungeonType dungeonType { /* [XID] */ /* 0x000000018999A630-0x000000018999A650 */ get => default; /* [XID] */ /* 0x00000001899A1CD0-0x00000001899A1CF0 */ protected set {} } // 0x00000001832A0FD0-0x00000001832A1070 0x00000001832A1540-0x00000001832A15F0

	// Constructors
	public StrengthenBasePointExcelConfig() {} // 0x00000001832A1CE0-0x00000001832A1D40

	// Methods
	// [IDTag] // 0x00000001899A95E0-0x00000001899A9620
	// [XID] // 0x00000001899A95E0-0x00000001899A9620
	public virtual bool ParseFromLine(string line) => default; // 0x00000001832A12B0-0x00000001832A1540
	// [IDTag] // 0x00000001899B4020-0x00000001899B4060
	// [XID] // 0x00000001899B4020-0x00000001899B4060
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001832A1070-0x00000001832A12B0
	// [XID] // 0x00000001899BE6B0-0x00000001899BE6D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3360 */, bool useObjectPool = false /* Metadata: 0x00AF3364 */) => default; // 0x00000001832A15F0-0x00000001832A1950
	[BlackList] // 0x00000001899C5EB0-0x00000001899C5EF0
	// [XID] // 0x00000001899C5EB0-0x00000001899C5EF0
	public virtual void AutoAllocTypeFields() {} // 0x00000001832A0E60-0x00000001832A0F00
	[BlackList] // 0x00000001899D0590-0x00000001899D05D0
	// [XID] // 0x00000001899D0590-0x00000001899D05D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832A0F00-0x00000001832A0FD0
	[BlackList] // 0x00000001899DAA40-0x00000001899DAA80
	// [XID] // 0x00000001899DAA40-0x00000001899DAA80
	public virtual void ReturnToObjectPool() {} // 0x00000001832A1C40-0x00000001832A1CE0
	[BlackList] // 0x00000001899E55C0-0x00000001899E5600
	// [XID] // 0x00000001899E55C0-0x00000001899E5600
	public virtual void OnPoolAllocated() {} // 0x00000001832A1AC0-0x00000001832A1B60
	[BlackList] // 0x00000001899EF910-0x00000001899EF950
	// [XID] // 0x00000001899EF910-0x00000001899EF950
	public virtual void OnBeforePoolRecycled() {} // 0x00000001832A1A20-0x00000001832A1AC0
}

