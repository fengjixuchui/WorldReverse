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
public class ActivityShopOverallExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15189
{
	// Fields
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x10
	protected ShopType _shopType; // 0x14
	protected SimpleSafeUInt32[] _sheetList; // 0x18

	// Properties
	public uint scheduleId { /* [XID] */ /* 0x00000001898014E0-0x0000000189801500 */ get => default; /* [XID] */ /* 0x00000001898088E0-0x0000000189808900 */ protected set {} } // 0x0000000183D0A5E0-0x0000000183D0A6B0 0x0000000183D0B820-0x0000000183D0B900
	public ShopType shopType { /* [XID] */ /* 0x00000001898102F0-0x0000000189810310 */ get => default; /* [XID] */ /* 0x0000000189817960-0x0000000189817980 */ protected set {} } // 0x0000000183D0B220-0x0000000183D0B2C0 0x0000000183D0A830-0x0000000183D0A8E0
	public SimpleSafeUInt32[] sheetList { /* [XID] */ /* 0x000000018981F2E0-0x000000018981F300 */ get => default; /* [XID] */ /* 0x0000000189826790-0x00000001898267B0 */ protected set {} } // 0x0000000183D0B370-0x0000000183D0B410 0x0000000183D0B2C0-0x0000000183D0B370

	// Constructors
	public ActivityShopOverallExcelConfig() {} // 0x0000000183D0BAE0-0x0000000183D0BB40

	// Methods
	// [IDTag] // 0x000000018982DE20-0x000000018982DE60
	// [XID] // 0x000000018982DE20-0x000000018982DE60
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183D0AD60-0x0000000183D0B220
	// [IDTag] // 0x0000000189838500-0x0000000189838540
	// [XID] // 0x0000000189838500-0x0000000189838540
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183D0A8E0-0x0000000183D0AD60
	// [XID] // 0x0000000189842BE0-0x0000000189842C00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0354 */, bool useObjectPool = false /* Metadata: 0x00AF0358 */) => default; // 0x0000000183D0B410-0x0000000183D0B820
	[BlackList] // 0x0000000189849F90-0x0000000189849FD0
	// [XID] // 0x0000000189849F90-0x0000000189849FD0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183D0A6B0-0x0000000183D0A750
	[BlackList] // 0x0000000189854100-0x0000000189854140
	// [XID] // 0x0000000189854100-0x0000000189854140
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183D0A750-0x0000000183D0A830
	[BlackList] // 0x000000018985E230-0x000000018985E270
	// [XID] // 0x000000018985E230-0x000000018985E270
	public virtual void ReturnToObjectPool() {} // 0x0000000183D0BA40-0x0000000183D0BAE0
	[BlackList] // 0x0000000189868CD0-0x0000000189868D10
	// [XID] // 0x0000000189868CD0-0x0000000189868D10
	public virtual void OnPoolAllocated() {} // 0x0000000183D0B9A0-0x0000000183D0BA40
	[BlackList] // 0x0000000189873070-0x00000001898730B0
	// [XID] // 0x0000000189873070-0x00000001898730B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183D0B900-0x0000000183D0B9A0
}

