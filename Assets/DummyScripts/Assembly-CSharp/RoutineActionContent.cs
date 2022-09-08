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
public class RoutineActionContent : IAutoAllocRecycle // TypeDefIndex: 16082
{
	// Fields
	protected RoutineActionype _type; // 0x10
	protected SimpleSafeUInt32 param1RawNum; // 0x14
	protected SimpleSafeUInt32 param2RawNum; // 0x18

	// Properties
	public RoutineActionype type { /* [XID] */ /* 0x00000001899943F0-0x0000000189994410 */ get => default; /* [XID] */ /* 0x000000018999BBC0-0x000000018999BBE0 */ protected set {} } // 0x00000001840E6760-0x00000001840E6800 0x00000001840E6490-0x00000001840E6540
	public uint param1 { /* [XID] */ /* 0x00000001899A3390-0x00000001899A33B0 */ get => default; /* [XID] */ /* 0x00000001899AAEC0-0x00000001899AAEE0 */ protected set {} } // 0x00000001840E5B40-0x00000001840E5C10 0x00000001840E5ED0-0x00000001840E5FB0
	public uint param2 { /* [XID] */ /* 0x00000001899B2950-0x00000001899B2970 */ get => default; /* [XID] */ /* 0x00000001899B9B30-0x00000001899B9B50 */ protected set {} } // 0x00000001840E5FB0-0x00000001840E6080 0x00000001840E6540-0x00000001840E6620

	// Constructors
	public RoutineActionContent() {} // 0x00000001840E68A0-0x00000001840E6900

	// Methods
	// [XID] // 0x00000001899C1650-0x00000001899C1670
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001840E5C10-0x00000001840E5ED0
	// [XID] // 0x00000001899C8C00-0x00000001899C8C20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2FBC */, bool useObjectPool = false /* Metadata: 0x00AF2FC0 */) => default; // 0x00000001840E6080-0x00000001840E6490
	[BlackList] // 0x00000001899D05D0-0x00000001899D0610
	// [XID] // 0x00000001899D05D0-0x00000001899D0610
	public virtual void AutoAllocTypeFields() {} // 0x00000001840E59B0-0x00000001840E5A50
	[BlackList] // 0x00000001899DAA80-0x00000001899DAAC0
	// [XID] // 0x00000001899DAA80-0x00000001899DAAC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001840E5A50-0x00000001840E5B40
	[BlackList] // 0x00000001899E5620-0x00000001899E5660
	// [XID] // 0x00000001899E5620-0x00000001899E5660
	public virtual void ReturnToObjectPool() {} // 0x00000001840E6800-0x00000001840E68A0
	[BlackList] // 0x00000001899EF9B0-0x00000001899EF9F0
	// [XID] // 0x00000001899EF9B0-0x00000001899EF9F0
	public virtual void OnPoolAllocated() {} // 0x00000001840E66C0-0x00000001840E6760
	[BlackList] // 0x00000001899FA030-0x00000001899FA070
	// [XID] // 0x00000001899FA030-0x00000001899FA070
	public virtual void OnBeforePoolRecycled() {} // 0x00000001840E6620-0x00000001840E66C0
}

