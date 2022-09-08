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
public class GuideTriggerExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15685
{
	// Fields
	protected string _guideName; // 0x10
	protected GuideTriggerType _type; // 0x18
	protected SimpleSafeUInt32 param1RawNum; // 0x1C
	protected OpenStateType _openState; // 0x20

	// Properties
	public string guideName { /* [XID] */ /* 0x00000001898936F0-0x0000000189893710 */ get => default; /* [XID] */ /* 0x000000018989AE10-0x000000018989AE30 */ protected set {} } // 0x0000000184012270-0x0000000184012310 0x0000000184012A00-0x0000000184012AB0
	public GuideTriggerType type { /* [XID] */ /* 0x00000001898A21E0-0x00000001898A2200 */ get => default; /* [XID] */ /* 0x00000001898A9930-0x00000001898A9950 */ protected set {} } // 0x0000000184012BF0-0x0000000184012C90 0x0000000184012950-0x0000000184012A00
	public uint param1 { /* [XID] */ /* 0x00000001898B1240-0x00000001898B1260 */ get => default; /* [XID] */ /* 0x00000001898B8B00-0x00000001898B8B20 */ protected set {} } // 0x0000000184011AD0-0x0000000184011BA0 0x0000000184012310-0x00000001840123F0
	public OpenStateType openState { /* [XID] */ /* 0x00000001898C0160-0x00000001898C0180 */ get => default; /* [XID] */ /* 0x00000001898C7AC0-0x00000001898C7AE0 */ protected set {} } // 0x0000000184011A30-0x0000000184011AD0 0x00000001840128A0-0x0000000184012950

	// Constructors
	public GuideTriggerExcelConfig() {} // 0x0000000184012D30-0x0000000184012D90

	// Methods
	// [IDTag] // 0x00000001898CF190-0x00000001898CF1D0
	// [XID] // 0x00000001898CF190-0x00000001898CF1D0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184011EF0-0x0000000184012270
	// [IDTag] // 0x00000001898D99B0-0x00000001898D99F0
	// [XID] // 0x00000001898D99B0-0x00000001898D99F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184011BA0-0x0000000184011EF0
	// [XID] // 0x00000001898E4540-0x00000001898E4560
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2307 */, bool useObjectPool = false /* Metadata: 0x00AF230B */) => default; // 0x00000001840123F0-0x00000001840128A0
	[BlackList] // 0x00000001898EBF70-0x00000001898EBFB0
	// [XID] // 0x00000001898EBF70-0x00000001898EBFB0
	public virtual void AutoAllocTypeFields() {} // 0x00000001840118B0-0x0000000184011950
	[BlackList] // 0x00000001898F6980-0x00000001898F69C0
	// [XID] // 0x00000001898F6980-0x00000001898F69C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184011950-0x0000000184011A30
	[BlackList] // 0x0000000189901230-0x0000000189901270
	// [XID] // 0x0000000189901230-0x0000000189901270
	public virtual void ReturnToObjectPool() {} // 0x0000000184012C90-0x0000000184012D30
	[BlackList] // 0x000000018990B830-0x000000018990B870
	// [XID] // 0x000000018990B830-0x000000018990B870
	public virtual void OnPoolAllocated() {} // 0x0000000184012B50-0x0000000184012BF0
	[BlackList] // 0x00000001899161E0-0x0000000189916220
	// [XID] // 0x00000001899161E0-0x0000000189916220
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184012AB0-0x0000000184012B50
}

