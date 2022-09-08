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
public class TowerSkipFloorExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16202
{
	// Fields
	protected SimpleSafeUInt32 prev_level_indexRawNum; // 0x10
	protected SimpleSafeUInt32 cur_level_indexRawNum; // 0x14

	// Properties
	public uint prev_level_index { /* [XID] */ /* 0x0000000189886500-0x0000000189886520 */ get => default; /* [XID] */ /* 0x000000018988D680-0x000000018988D6A0 */ protected set {} } // 0x0000000181A5A6F0-0x0000000181A5A7C0 0x0000000181A5A940-0x0000000181A5AA20
	public uint cur_level_index { /* [XID] */ /* 0x0000000189894DD0-0x0000000189894DF0 */ get => default; /* [XID] */ /* 0x000000018989C480-0x000000018989C4A0 */ protected set {} } // 0x0000000181A5AEB0-0x0000000181A5AF80 0x0000000181A5B420-0x0000000181A5B500

	// Constructors
	public TowerSkipFloorExcelConfig() {} // 0x0000000181A5B5A0-0x0000000181A5B600

	// Methods
	// [IDTag] // 0x00000001898A3AA0-0x00000001898A3AE0
	// [XID] // 0x00000001898A3AA0-0x00000001898A3AE0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181A5AC40-0x0000000181A5AEB0
	// [IDTag] // 0x00000001898AE270-0x00000001898AE2B0
	// [XID] // 0x00000001898AE270-0x00000001898AE2B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181A5AA20-0x0000000181A5AC40
	// [XID] // 0x00000001898B8A20-0x00000001898B8A40
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3406 */, bool useObjectPool = false /* Metadata: 0x00AF340A */) => default; // 0x0000000181A5AF80-0x0000000181A5B2E0
	[BlackList] // 0x00000001898C0000-0x00000001898C0040
	// [XID] // 0x00000001898C0000-0x00000001898C0040
	public virtual void AutoAllocTypeFields() {} // 0x0000000181A5A7C0-0x0000000181A5A860
	[BlackList] // 0x00000001898CA860-0x00000001898CA8A0
	// [XID] // 0x00000001898CA860-0x00000001898CA8A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181A5A860-0x0000000181A5A940
	[BlackList] // 0x00000001898D50F0-0x00000001898D5130
	// [XID] // 0x00000001898D50F0-0x00000001898D5130
	public virtual void ReturnToObjectPool() {} // 0x0000000181A5B500-0x0000000181A5B5A0
	[BlackList] // 0x00000001898DFE20-0x00000001898DFE60
	// [XID] // 0x00000001898DFE20-0x00000001898DFE60
	public virtual void OnPoolAllocated() {} // 0x0000000181A5B380-0x0000000181A5B420
	[BlackList] // 0x00000001898EA8D0-0x00000001898EA910
	// [XID] // 0x00000001898EA8D0-0x00000001898EA910
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181A5B2E0-0x0000000181A5B380
}

