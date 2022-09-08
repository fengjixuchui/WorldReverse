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
public class ExpeditionDifficultyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15085
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 needHoursRawNum; // 0x14
	protected SimpleSafeUInt32 minPlayerRawNum; // 0x18
	protected SimpleSafeUInt32 maxPlayerRawNum; // 0x1C
	protected SimpleSafeUInt32 minRefreshCountRawNum; // 0x20
	protected SimpleSafeUInt32 maxRefreshCountRawNum; // 0x24
	protected SimpleSafeFloat coefRawNum; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189ADF9B0-0x0000000189ADF9D0 */ get => default; /* [XID] */ /* 0x0000000189AE7050-0x0000000189AE7070 */ protected set {} } // 0x0000000184996710-0x00000001849967E0 0x0000000184995BD0-0x0000000184995CB0
	public uint needHours { /* [XID] */ /* 0x0000000189AEEC60-0x0000000189AEEC80 */ get => default; /* [XID] */ /* 0x0000000189AF61B0-0x0000000189AF61D0 */ protected set {} } // 0x0000000184994CA0-0x0000000184994D70 0x00000001849964F0-0x00000001849965D0
	public uint minPlayer { /* [XID] */ /* 0x0000000189AFD7F0-0x0000000189AFD810 */ get => default; /* [XID] */ /* 0x0000000189B04FA0-0x0000000189B04FC0 */ protected set {} } // 0x0000000184995860-0x0000000184995930 0x0000000184995930-0x0000000184995A10
	public uint maxPlayer { /* [XID] */ /* 0x0000000189B0C710-0x0000000189B0C730 */ get => default; /* [XID] */ /* 0x0000000189B13B50-0x0000000189B13B70 */ protected set {} } // 0x0000000184995D80-0x0000000184995E50 0x0000000184995780-0x0000000184995860
	public uint minRefreshCount { /* [XID] */ /* 0x0000000189B1B360-0x0000000189B1B380 */ get => default; /* [XID] */ /* 0x0000000189B229B0-0x0000000189B229D0 */ protected set {} } // 0x0000000184995CB0-0x0000000184995D80 0x00000001849948E0-0x00000001849949C0
	public uint maxRefreshCount { /* [XID] */ /* 0x0000000189B29FE0-0x0000000189B2A000 */ get => default; /* [XID] */ /* 0x0000000189B316B0-0x0000000189B316D0 */ protected set {} } // 0x00000001849956B0-0x0000000184995780 0x00000001849949C0-0x0000000184994AA0
	public float coef { /* [XID] */ /* 0x0000000189B38AB0-0x0000000189B38AD0 */ get => default; /* [XID] */ /* 0x0000000189B40480-0x0000000189B404A0 */ protected set {} } // 0x0000000184995AF0-0x0000000184995BD0 0x0000000184995A10-0x0000000184995AF0

	// Constructors
	public ExpeditionDifficultyExcelConfig() {} // 0x0000000184996880-0x00000001849968E0

	// Methods
	// [IDTag] // 0x0000000189B47D60-0x0000000189B47DA0
	// [XID] // 0x0000000189B47D60-0x0000000189B47DA0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184995200-0x00000001849956B0
	// [IDTag] // 0x0000000189B52460-0x0000000189B524A0
	// [XID] // 0x0000000189B52460-0x0000000189B524A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184994D70-0x0000000184995200
	// [XID] // 0x0000000189B5CF10-0x0000000189B5CF30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0067 */, bool useObjectPool = false /* Metadata: 0x00AF006B */) => default; // 0x0000000184995E50-0x00000001849964F0
	[BlackList] // 0x0000000189B64630-0x0000000189B64670
	// [XID] // 0x0000000189B64630-0x0000000189B64670
	public virtual void AutoAllocTypeFields() {} // 0x0000000184994AA0-0x0000000184994B40
	[BlackList] // 0x0000000189B6EA40-0x0000000189B6EA80
	// [XID] // 0x0000000189B6EA40-0x0000000189B6EA80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184994B40-0x0000000184994CA0
	[BlackList] // 0x0000000189B79100-0x0000000189B79140
	// [XID] // 0x0000000189B79100-0x0000000189B79140
	public virtual void ReturnToObjectPool() {} // 0x00000001849967E0-0x0000000184996880
	[BlackList] // 0x0000000189B83A00-0x0000000189B83A40
	// [XID] // 0x0000000189B83A00-0x0000000189B83A40
	public virtual void OnPoolAllocated() {} // 0x0000000184996670-0x0000000184996710
	[BlackList] // 0x0000000189B8DC30-0x0000000189B8DC70
	// [XID] // 0x0000000189B8DC30-0x0000000189B8DC70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001849965D0-0x0000000184996670
}

