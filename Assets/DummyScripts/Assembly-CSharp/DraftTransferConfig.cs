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
public class DraftTransferConfig : IAutoAllocRecycle // TypeDefIndex: 15497
{
	// Fields
	protected SimpleSafeUInt32 group_idRawNum; // 0x10
	protected SimpleSafeUInt32 config_idRawNum; // 0x14

	// Properties
	public uint group_id { /* [XID] */ /* 0x000000018999D4B0-0x000000018999D4D0 */ get => default; /* [XID] */ /* 0x00000001899A4D90-0x00000001899A4DB0 */ protected set {} } // 0x00000001817173B0-0x0000000181717480 0x0000000181716D60-0x0000000181716E40
	public uint config_id { /* [XID] */ /* 0x00000001899AC990-0x00000001899AC9B0 */ get => default; /* [XID] */ /* 0x00000001899B41A0-0x00000001899B41C0 */ protected set {} } // 0x00000001817171A0-0x0000000181717270 0x0000000181716A60-0x0000000181716B40

	// Constructors
	public DraftTransferConfig() {} // 0x0000000181717520-0x0000000181717580

	// Methods
	// [XID] // 0x00000001899BB630-0x00000001899BB650
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181716B40-0x0000000181716D60
	// [XID] // 0x00000001899C3260-0x00000001899C3280
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C5E */, bool useObjectPool = false /* Metadata: 0x00AF1C62 */) => default; // 0x0000000181716E40-0x00000001817171A0
	[BlackList] // 0x00000001899CA640-0x00000001899CA680
	// [XID] // 0x00000001899CA640-0x00000001899CA680
	public virtual void AutoAllocTypeFields() {} // 0x00000001817168E0-0x0000000181716980
	[BlackList] // 0x00000001899D4C10-0x00000001899D4C50
	// [XID] // 0x00000001899D4C10-0x00000001899D4C50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181716980-0x0000000181716A60
	[BlackList] // 0x00000001899DF0B0-0x00000001899DF0F0
	// [XID] // 0x00000001899DF0B0-0x00000001899DF0F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181717480-0x0000000181717520
	[BlackList] // 0x00000001899E9900-0x00000001899E9940
	// [XID] // 0x00000001899E9900-0x00000001899E9940
	public virtual void OnPoolAllocated() {} // 0x0000000181717310-0x00000001817173B0
	[BlackList] // 0x00000001899F4690-0x00000001899F46D0
	// [XID] // 0x00000001899F4690-0x00000001899F46D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181717270-0x0000000181717310
}

