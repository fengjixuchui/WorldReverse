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
public class BoredActionPriorityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15287
{
	// Fields
	protected BoredActionType _action_type; // 0x10
	protected SimpleSafeUInt32 weightRawNum; // 0x14

	// Properties
	public BoredActionType action_type { /* [XID] */ /* 0x00000001898E2DC0-0x00000001898E2DE0 */ get => default; /* [XID] */ /* 0x00000001898EAA70-0x00000001898EAA90 */ protected set {} } // 0x0000000182EA1100-0x0000000182EA11A0 0x0000000182EA11A0-0x0000000182EA1250
	public uint weight { /* [XID] */ /* 0x00000001898F21D0-0x00000001898F21F0 */ get => default; /* [XID] */ /* 0x00000001898F99B0-0x00000001898F99D0 */ protected set {} } // 0x0000000182EA16F0-0x0000000182EA17C0 0x0000000182EA1020-0x0000000182EA1100

	// Constructors
	public BoredActionPriorityExcelConfig() {} // 0x0000000182EA1860-0x0000000182EA18C0

	// Methods
	// [IDTag] // 0x0000000189901330-0x0000000189901370
	// [XID] // 0x0000000189901330-0x0000000189901370
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182EA0D90-0x0000000182EA1020
	// [IDTag] // 0x000000018990B950-0x000000018990B990
	// [XID] // 0x000000018990B950-0x000000018990B990
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182EA0B50-0x0000000182EA0D90
	// [XID] // 0x0000000189916320-0x0000000189916340
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF066A */, bool useObjectPool = false /* Metadata: 0x00AF066E */) => default; // 0x0000000182EA1250-0x0000000182EA15B0
	[BlackList] // 0x000000018991DC50-0x000000018991DC90
	// [XID] // 0x000000018991DC50-0x000000018991DC90
	public virtual void AutoAllocTypeFields() {} // 0x0000000182EA09E0-0x0000000182EA0A80
	[BlackList] // 0x00000001899283F0-0x0000000189928430
	// [XID] // 0x00000001899283F0-0x0000000189928430
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182EA0A80-0x0000000182EA0B50
	[BlackList] // 0x0000000189932A40-0x0000000189932A80
	// [XID] // 0x0000000189932A40-0x0000000189932A80
	public virtual void ReturnToObjectPool() {} // 0x0000000182EA17C0-0x0000000182EA1860
	[BlackList] // 0x000000018993D210-0x000000018993D250
	// [XID] // 0x000000018993D210-0x000000018993D250
	public virtual void OnPoolAllocated() {} // 0x0000000182EA1650-0x0000000182EA16F0
	[BlackList] // 0x00000001899475C0-0x0000000189947600
	// [XID] // 0x00000001899475C0-0x0000000189947600
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182EA15B0-0x0000000182EA1650
}

