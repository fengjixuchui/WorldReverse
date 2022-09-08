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
public class BlossomOpenExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15265
{
	// Fields
	protected SimpleSafeUInt32 cityIdRawNum; // 0x10
	protected SimpleSafeUInt32 openLevelRawNum; // 0x14

	// Properties
	public uint cityId { /* [XID] */ /* 0x00000001899BFF70-0x00000001899BFF90 */ get => default; /* [XID] */ /* 0x00000001899C7770-0x00000001899C7790 */ protected set {} } // 0x00000001853AA760-0x00000001853AA830 0x00000001853AA240-0x00000001853AA320
	public uint openLevel { /* [XID] */ /* 0x00000001899CEE40-0x00000001899CEE60 */ get => default; /* [XID] */ /* 0x00000001899D64B0-0x00000001899D64D0 */ protected set {} } // 0x00000001853A9CE0-0x00000001853A9DB0 0x00000001853AA680-0x00000001853AA760

	// Constructors
	public BlossomOpenExcelConfig() {} // 0x00000001853AAA10-0x00000001853AAA70

	// Methods
	// [IDTag] // 0x00000001899DD960-0x00000001899DD9A0
	// [XID] // 0x00000001899DD960-0x00000001899DD9A0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001853A9DB0-0x00000001853AA020
	// [IDTag] // 0x00000001899E8520-0x00000001899E8560
	// [XID] // 0x00000001899E8520-0x00000001899E8560
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001853AA020-0x00000001853AA240
	// [XID] // 0x00000001899F2BC0-0x00000001899F2BE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05B4 */, bool useObjectPool = false /* Metadata: 0x00AF05B8 */) => default; // 0x00000001853AA320-0x00000001853AA680
	[BlackList] // 0x00000001899FA190-0x00000001899FA1D0
	// [XID] // 0x00000001899FA190-0x00000001899FA1D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001853A9B60-0x00000001853A9C00
	[BlackList] // 0x0000000189A04690-0x0000000189A046D0
	// [XID] // 0x0000000189A04690-0x0000000189A046D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001853A9C00-0x00000001853A9CE0
	[BlackList] // 0x0000000189A0EC70-0x0000000189A0ECB0
	// [XID] // 0x0000000189A0EC70-0x0000000189A0ECB0
	public virtual void ReturnToObjectPool() {} // 0x00000001853AA970-0x00000001853AAA10
	[BlackList] // 0x0000000189A191F0-0x0000000189A19230
	// [XID] // 0x0000000189A191F0-0x0000000189A19230
	public virtual void OnPoolAllocated() {} // 0x00000001853AA8D0-0x00000001853AA970
	[BlackList] // 0x0000000189A238E0-0x0000000189A23920
	// [XID] // 0x0000000189A238E0-0x0000000189A23920
	public virtual void OnBeforePoolRecycled() {} // 0x00000001853AA830-0x00000001853AA8D0
}

