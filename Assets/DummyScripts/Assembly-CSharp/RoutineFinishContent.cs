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
public class RoutineFinishContent : IAutoAllocRecycle // TypeDefIndex: 16080
{
	// Fields
	protected RoutineFinishType _finishType; // 0x10
	protected SimpleSafeUInt32 param1RawNum; // 0x14
	protected SimpleSafeUInt32 param2RawNum; // 0x18
	protected SimpleSafeUInt32 progressRawNum; // 0x1C

	// Properties
	public RoutineFinishType finishType { /* [XID] */ /* 0x0000000189894DF0-0x0000000189894E10 */ get => default; /* [XID] */ /* 0x000000018989C4E0-0x000000018989C500 */ protected set {} } // 0x00000001819069E0-0x0000000181906A80 0x0000000181906F60-0x0000000181907010
	public uint param1 { /* [XID] */ /* 0x00000001898A3B00-0x00000001898A3B20 */ get => default; /* [XID] */ /* 0x00000001898AAE20-0x00000001898AAE40 */ protected set {} } // 0x0000000181906910-0x00000001819069E0 0x0000000181906DB0-0x0000000181906E90
	public uint param2 { /* [XID] */ /* 0x00000001898B2710-0x00000001898B2730 */ get => default; /* [XID] */ /* 0x00000001898BA4E0-0x00000001898BA500 */ protected set {} } // 0x0000000181906E90-0x0000000181906F60 0x00000001819075A0-0x0000000181907680
	public uint progress { /* [XID] */ /* 0x00000001898C17E0-0x00000001898C1800 */ get => default; /* [XID] */ /* 0x00000001898C90C0-0x00000001898C90E0 */ protected set {} } // 0x0000000181907680-0x0000000181907750 0x00000001819074C0-0x00000001819075A0

	// Constructors
	public RoutineFinishContent() {} // 0x0000000181907930-0x0000000181907990

	// Methods
	// [XID] // 0x00000001898D0900-0x00000001898D0920
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181906A80-0x0000000181906DB0
	// [XID] // 0x00000001898D7FE0-0x00000001898D8000
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2FB2 */, bool useObjectPool = false /* Metadata: 0x00AF2FB6 */) => default; // 0x0000000181907010-0x00000001819074C0
	[BlackList] // 0x00000001898DFE60-0x00000001898DFEA0
	// [XID] // 0x00000001898DFE60-0x00000001898DFEA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181906770-0x0000000181906810
	[BlackList] // 0x00000001898EA930-0x00000001898EA970
	// [XID] // 0x00000001898EA930-0x00000001898EA970
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181906810-0x0000000181906910
	[BlackList] // 0x00000001898F4FC0-0x00000001898F5000
	// [XID] // 0x00000001898F4FC0-0x00000001898F5000
	public virtual void ReturnToObjectPool() {} // 0x0000000181907890-0x0000000181907930
	[BlackList] // 0x00000001898FF850-0x00000001898FF890
	// [XID] // 0x00000001898FF850-0x00000001898FF890
	public virtual void OnPoolAllocated() {} // 0x00000001819077F0-0x0000000181907890
	[BlackList] // 0x0000000189909F60-0x0000000189909FA0
	// [XID] // 0x0000000189909F60-0x0000000189909FA0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181907750-0x00000001819077F0
}

