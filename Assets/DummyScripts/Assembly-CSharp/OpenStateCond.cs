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
public class OpenStateCond : IAutoAllocRecycle // TypeDefIndex: 15933
{
	// Fields
	protected OpenStateCondType _cond_type; // 0x10
	protected SimpleSafeUInt32 paramRawNum; // 0x14
	protected SimpleSafeUInt32 param2RawNum; // 0x18

	// Properties
	public OpenStateCondType cond_type { /* [XID] */ /* 0x000000018983E060-0x000000018983E080 */ get => default; /* [XID] */ /* 0x0000000189845870-0x0000000189845890 */ protected set {} } // 0x00000001851B8E70-0x00000001851B8F10 0x00000001851B91D0-0x00000001851B9280
	public uint param { /* [XID] */ /* 0x000000018984CE00-0x000000018984CE20 */ get => default; /* [XID] */ /* 0x0000000189853F60-0x0000000189853F80 */ protected set {} } // 0x00000001851B9A60-0x00000001851B9B30 0x00000001851B9980-0x00000001851B9A60
	public uint param2 { /* [XID] */ /* 0x000000018985B970-0x000000018985B990 */ get => default; /* [XID] */ /* 0x0000000189862F70-0x0000000189862F90 */ protected set {} } // 0x00000001851B9280-0x00000001851B9350 0x00000001851B9760-0x00000001851B9840

	// Constructors
	public OpenStateCond() {} // 0x00000001851B9BD0-0x00000001851B9C30

	// Methods
	// [XID] // 0x000000018986A3C0-0x000000018986A3E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001851B8F10-0x00000001851B91D0
	// [XID] // 0x00000001898717F0-0x0000000189871810
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B90 */, bool useObjectPool = false /* Metadata: 0x00AF2B94 */) => default; // 0x00000001851B9350-0x00000001851B9760
	[BlackList] // 0x0000000189879090-0x00000001898790D0
	// [XID] // 0x0000000189879090-0x00000001898790D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001851B8CE0-0x00000001851B8D80
	[BlackList] // 0x0000000189883210-0x0000000189883250
	// [XID] // 0x0000000189883210-0x0000000189883250
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851B8D80-0x00000001851B8E70
	[BlackList] // 0x000000018988D6E0-0x000000018988D720
	// [XID] // 0x000000018988D6E0-0x000000018988D720
	public virtual void ReturnToObjectPool() {} // 0x00000001851B9B30-0x00000001851B9BD0
	[BlackList] // 0x0000000189897CA0-0x0000000189897CE0
	// [XID] // 0x0000000189897CA0-0x0000000189897CE0
	public virtual void OnPoolAllocated() {} // 0x00000001851B98E0-0x00000001851B9980
	[BlackList] // 0x00000001898A2160-0x00000001898A21A0
	// [XID] // 0x00000001898A2160-0x00000001898A21A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851B9840-0x00000001851B98E0
}

