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
public class ShopmallRecommendCond : IAutoAllocRecycle // TypeDefIndex: 16131
{
	// Fields
	protected ShopmallRecommendCondType _type; // 0x10
	protected SimpleSafeUInt32 param1RawNum; // 0x14
	protected SimpleSafeUInt32 param2RawNum; // 0x18

	// Properties
	public ShopmallRecommendCondType type { /* [XID] */ /* 0x000000018976E9C0-0x000000018976E9E0 */ get => default; /* [XID] */ /* 0x00000001897763A0-0x00000001897763C0 */ protected set {} } // 0x00000001843B2050-0x00000001843B20F0 0x00000001843B1D80-0x00000001843B1E30
	public uint param1 { /* [XID] */ /* 0x000000018977DAA0-0x000000018977DAC0 */ get => default; /* [XID] */ /* 0x0000000189785280-0x00000001897852A0 */ protected set {} } // 0x00000001843B1430-0x00000001843B1500 0x00000001843B17C0-0x00000001843B18A0
	public uint param2 { /* [XID] */ /* 0x000000018978C7D0-0x000000018978C7F0 */ get => default; /* [XID] */ /* 0x0000000189793C20-0x0000000189793C40 */ protected set {} } // 0x00000001843B18A0-0x00000001843B1970 0x00000001843B1E30-0x00000001843B1F10

	// Constructors
	public ShopmallRecommendCond() {} // 0x00000001843B2190-0x00000001843B21F0

	// Methods
	// [XID] // 0x000000018979BFD0-0x000000018979BFF0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843B1500-0x00000001843B17C0
	// [XID] // 0x00000001897A3480-0x00000001897A34A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3209 */, bool useObjectPool = false /* Metadata: 0x00AF320D */) => default; // 0x00000001843B1970-0x00000001843B1D80
	[BlackList] // 0x00000001897AAA00-0x00000001897AAA40
	// [XID] // 0x00000001897AAA00-0x00000001897AAA40
	public virtual void AutoAllocTypeFields() {} // 0x00000001843B12A0-0x00000001843B1340
	[BlackList] // 0x00000001897B5CB0-0x00000001897B5CF0
	// [XID] // 0x00000001897B5CB0-0x00000001897B5CF0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843B1340-0x00000001843B1430
	[BlackList] // 0x00000001897C09A0-0x00000001897C09E0
	// [XID] // 0x00000001897C09A0-0x00000001897C09E0
	public virtual void ReturnToObjectPool() {} // 0x00000001843B20F0-0x00000001843B2190
	[BlackList] // 0x00000001897CAF70-0x00000001897CAFB0
	// [XID] // 0x00000001897CAF70-0x00000001897CAFB0
	public virtual void OnPoolAllocated() {} // 0x00000001843B1FB0-0x00000001843B2050
	[BlackList] // 0x00000001897D5610-0x00000001897D5650
	// [XID] // 0x00000001897D5610-0x00000001897D5650
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843B1F10-0x00000001843B1FB0
}

