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
public class ReliquaryLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16021
{
	// Fields
	protected SimpleSafeUInt32 rankRawNum; // 0x10
	protected SimpleSafeUInt32 levelRawNum; // 0x14
	protected SimpleSafeUInt32 expRawNum; // 0x18
	protected PropValConfig[] _addProps; // 0x20

	// Properties
	public uint rank { /* [XID] */ /* 0x00000001897F25F0-0x00000001897F2610 */ get => default; /* [XID] */ /* 0x00000001897F9D40-0x00000001897F9D60 */ protected set {} } // 0x000000018569E240-0x000000018569E310 0x000000018569E090-0x000000018569E170
	public uint level { /* [XID] */ /* 0x0000000189801280-0x00000001898012A0 */ get => default; /* [XID] */ /* 0x0000000189808660-0x0000000189808680 */ protected set {} } // 0x000000018569E170-0x000000018569E240 0x000000018569DFB0-0x000000018569E090
	public uint exp { /* [XID] */ /* 0x00000001898101B0-0x00000001898101D0 */ get => default; /* [XID] */ /* 0x0000000189817820-0x0000000189817840 */ protected set {} } // 0x000000018569E3B0-0x000000018569E480 0x000000018569DA20-0x000000018569DB00
	public PropValConfig[] addProps { /* [XID] */ /* 0x000000018981F180-0x000000018981F1A0 */ get => default; /* [XID] */ /* 0x0000000189826670-0x0000000189826690 */ protected set {} } // 0x000000018569E310-0x000000018569E3B0 0x000000018569D970-0x000000018569DA20

	// Constructors
	public ReliquaryLevelExcelConfig() {} // 0x000000018569E660-0x000000018569E6C0

	// Methods
	// [IDTag] // 0x000000018982DD80-0x000000018982DDC0
	// [XID] // 0x000000018982DD80-0x000000018982DDC0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018569D520-0x000000018569D970
	// [IDTag] // 0x0000000189838400-0x0000000189838440
	// [XID] // 0x0000000189838400-0x0000000189838440
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018569D150-0x000000018569D520
	// [XID] // 0x0000000189842AE0-0x0000000189842B00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E1D */, bool useObjectPool = false /* Metadata: 0x00AF2E21 */) => default; // 0x000000018569DB00-0x000000018569DFB0
	[BlackList] // 0x0000000189849E50-0x0000000189849E90
	// [XID] // 0x0000000189849E50-0x0000000189849E90
	public virtual void AutoAllocTypeFields() {} // 0x000000018569CFB0-0x000000018569D050
	[BlackList] // 0x0000000189853EE0-0x0000000189853F20
	// [XID] // 0x0000000189853EE0-0x0000000189853F20
	public virtual void AutoRecycleTypeFields() {} // 0x000000018569D050-0x000000018569D150
	[BlackList] // 0x000000018985E090-0x000000018985E0D0
	// [XID] // 0x000000018985E090-0x000000018985E0D0
	public virtual void ReturnToObjectPool() {} // 0x000000018569E5C0-0x000000018569E660
	[BlackList] // 0x0000000189868B10-0x0000000189868B50
	// [XID] // 0x0000000189868B10-0x0000000189868B50
	public virtual void OnPoolAllocated() {} // 0x000000018569E520-0x000000018569E5C0
	[BlackList] // 0x0000000189872E30-0x0000000189872E70
	// [XID] // 0x0000000189872E30-0x0000000189872E70
	public virtual void OnBeforePoolRecycled() {} // 0x000000018569E480-0x000000018569E520
}

