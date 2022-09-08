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
public class BaseDropIndexConfig : IAutoAllocRecycle // TypeDefIndex: 15510
{
	// Fields
	protected SimpleSafeUInt32 minLevelRawNum; // 0x10
	protected string _dropTag; // 0x18
	protected SimpleSafeUInt32 dropIdRawNum; // 0x20
	protected SimpleSafeUInt32 dropCountRawNum; // 0x24

	// Properties
	public uint minLevel { /* [XID] */ /* 0x00000001898965C0-0x00000001898965E0 */ get => default; /* [XID] */ /* 0x000000018989DB80-0x000000018989DBA0 */ protected set {} } // 0x0000000184C481C0-0x0000000184C48290 0x0000000184C48E70-0x0000000184C48F50
	public string dropTag { /* [XID] */ /* 0x00000001898A54C0-0x00000001898A54E0 */ get => default; /* [XID] */ /* 0x00000001898ACAA0-0x00000001898ACAC0 */ protected set {} } // 0x0000000184C48120-0x0000000184C481C0 0x0000000184C48680-0x0000000184C48730
	public uint dropId { /* [XID] */ /* 0x00000001898B3F20-0x00000001898B3F40 */ get => default; /* [XID] */ /* 0x00000001898BBBF0-0x00000001898BBC10 */ protected set {} } // 0x0000000184C48730-0x0000000184C48800 0x0000000184C48CB0-0x0000000184C48D90
	public uint dropCount { /* [XID] */ /* 0x00000001898C3100-0x00000001898C3120 */ get => default; /* [XID] */ /* 0x00000001898CAAE0-0x00000001898CAB00 */ protected set {} } // 0x0000000184C48290-0x0000000184C48360 0x0000000184C48D90-0x0000000184C48E70

	// Constructors
	public BaseDropIndexConfig() {} // 0x0000000184C49130-0x0000000184C49190

	// Methods
	// [XID] // 0x00000001898D2190-0x00000001898D21B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184C48360-0x0000000184C48680
	// [XID] // 0x00000001898D9A10-0x00000001898D9A30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1CA7 */, bool useObjectPool = false /* Metadata: 0x00AF1CAB */) => default; // 0x0000000184C48800-0x0000000184C48CB0
	[BlackList] // 0x00000001898E16D0-0x00000001898E1710
	// [XID] // 0x00000001898E16D0-0x00000001898E1710
	public virtual void AutoAllocTypeFields() {} // 0x0000000184C47F80-0x0000000184C48020
	[BlackList] // 0x00000001898EBFB0-0x00000001898EBFF0
	// [XID] // 0x00000001898EBFB0-0x00000001898EBFF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184C48020-0x0000000184C48120
	[BlackList] // 0x00000001898F6A00-0x00000001898F6A40
	// [XID] // 0x00000001898F6A00-0x00000001898F6A40
	public virtual void ReturnToObjectPool() {} // 0x0000000184C49090-0x0000000184C49130
	[BlackList] // 0x0000000189901270-0x00000001899012B0
	// [XID] // 0x0000000189901270-0x00000001899012B0
	public virtual void OnPoolAllocated() {} // 0x0000000184C48FF0-0x0000000184C49090
	[BlackList] // 0x000000018990B8B0-0x000000018990B8F0
	// [XID] // 0x000000018990B8B0-0x000000018990B8F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184C48F50-0x0000000184C48FF0
}

