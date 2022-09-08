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
public class MechanicusMapPointExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16227
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeFloat coordXRawNum; // 0x14
	protected SimpleSafeFloat coordYRawNum; // 0x18

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189A0D5A0-0x0000000189A0D5C0 */ get => default; /* [XID] */ /* 0x0000000189A14CE0-0x0000000189A14D00 */ protected set {} } // 0x00000001837AC6B0-0x00000001837AC780 0x00000001837ABCE0-0x00000001837ABDC0
	public float coordX { /* [XID] */ /* 0x0000000189A1BEF0-0x0000000189A1BF10 */ get => default; /* [XID] */ /* 0x0000000189A23760-0x0000000189A23780 */ protected set {} } // 0x00000001837ACBA0-0x00000001837ACC80 0x00000001837AC5D0-0x00000001837AC6B0
	public float coordY { /* [XID] */ /* 0x0000000189A2ABE0-0x0000000189A2AC00 */ get => default; /* [XID] */ /* 0x0000000189A32120-0x0000000189A32140 */ protected set {} } // 0x00000001837ACC80-0x00000001837ACD60 0x00000001837ABF70-0x00000001837AC050

	// Constructors
	public MechanicusMapPointExcelConfig() {} // 0x00000001837ACF40-0x00000001837ACFA0

	// Methods
	// [IDTag] // 0x0000000189A39AB0-0x0000000189A39AF0
	// [XID] // 0x0000000189A39AB0-0x0000000189A39AF0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001837AC2F0-0x00000001837AC5D0
	// [IDTag] // 0x0000000189A443F0-0x0000000189A44430
	// [XID] // 0x0000000189A443F0-0x0000000189A44430
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001837AC050-0x00000001837AC2F0
	// [XID] // 0x0000000189A4EB30-0x0000000189A4EB50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34E1 */, bool useObjectPool = false /* Metadata: 0x00AF34E5 */) => default; // 0x00000001837AC780-0x00000001837ACBA0
	[BlackList] // 0x0000000189A561A0-0x0000000189A561E0
	// [XID] // 0x0000000189A561A0-0x0000000189A561E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001837ABDC0-0x00000001837ABE60
	[BlackList] // 0x0000000189A60A80-0x0000000189A60AC0
	// [XID] // 0x0000000189A60A80-0x0000000189A60AC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837ABE60-0x00000001837ABF70
	[BlackList] // 0x0000000189A6B530-0x0000000189A6B570
	// [XID] // 0x0000000189A6B530-0x0000000189A6B570
	public virtual void ReturnToObjectPool() {} // 0x00000001837ACEA0-0x00000001837ACF40
	[BlackList] // 0x0000000189A75A90-0x0000000189A75AD0
	// [XID] // 0x0000000189A75A90-0x0000000189A75AD0
	public virtual void OnPoolAllocated() {} // 0x00000001837ACE00-0x00000001837ACEA0
	[BlackList] // 0x0000000189A80200-0x0000000189A80240
	// [XID] // 0x0000000189A80200-0x0000000189A80240
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837ACD60-0x00000001837ACE00
}

