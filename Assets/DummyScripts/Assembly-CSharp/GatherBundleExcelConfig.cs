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
public class GatherBundleExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15663
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _bundleName; // 0x18
	protected SimpleSafeUInt32 baseGadgetIdRawNum; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected PointInfo[] _points; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BAF860-0x0000000189BAF880 */ get => default; /* [XID] */ /* 0x0000000189BB6E70-0x0000000189BB6E90 */ protected set {} } // 0x000000018554A6A0-0x000000018554A770 0x0000000185549D10-0x0000000185549DF0
	public string bundleName { /* [XID] */ /* 0x0000000189BBE430-0x0000000189BBE450 */ get => default; /* [XID] */ /* 0x0000000189BC61A0-0x0000000189BC61C0 */ protected set {} } // 0x0000000185549DF0-0x0000000185549E90 0x0000000185549C60-0x0000000185549D10
	public uint baseGadgetId { /* [XID] */ /* 0x0000000189BCDD80-0x0000000189BCDDA0 */ get => default; /* [XID] */ /* 0x0000000189BD5270-0x0000000189BD5290 */ protected set {} } // 0x000000018554A3E0-0x000000018554A4B0 0x0000000185549300-0x00000001855493E0
	public PointInfo[] points { /* [XID] */ /* 0x0000000189BDCDE0-0x0000000189BDCE00 */ get => default; /* [XID] */ /* 0x00000001895E9650-0x00000001895E9670 */ protected set {} } // 0x000000018554A340-0x000000018554A3E0 0x000000018554A4B0-0x000000018554A560

	// Constructors
	public GatherBundleExcelConfig() {} // 0x000000018554A810-0x000000018554A870

	// Methods
	// [IDTag] // 0x00000001895F0E00-0x00000001895F0E40
	// [XID] // 0x00000001895F0E00-0x00000001895F0E40
	public virtual bool ParseFromLine(string line) => default; // 0x00000001855493E0-0x0000000185549870
	// [IDTag] // 0x00000001895FB5F0-0x00000001895FB630
	// [XID] // 0x00000001895FB5F0-0x00000001895FB630
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000185549870-0x0000000185549C60
	// [XID] // 0x0000000189605DD0-0x0000000189605DF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2233 */, bool useObjectPool = false /* Metadata: 0x00AF2237 */) => default; // 0x0000000185549E90-0x000000018554A340
	[BlackList] // 0x000000018960D640-0x000000018960D680
	// [XID] // 0x000000018960D640-0x000000018960D680
	public virtual void AutoAllocTypeFields() {} // 0x0000000185549170-0x0000000185549210
	[BlackList] // 0x00000001896179F0-0x0000000189617A30
	// [XID] // 0x00000001896179F0-0x0000000189617A30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185549210-0x0000000185549300
	[BlackList] // 0x0000000189622280-0x00000001896222C0
	// [XID] // 0x0000000189622280-0x00000001896222C0
	public virtual void ReturnToObjectPool() {} // 0x000000018554A770-0x000000018554A810
	[BlackList] // 0x000000018962C950-0x000000018962C990
	// [XID] // 0x000000018962C950-0x000000018962C990
	public virtual void OnPoolAllocated() {} // 0x000000018554A600-0x000000018554A6A0
	[BlackList] // 0x00000001896376E0-0x0000000189637720
	// [XID] // 0x00000001896376E0-0x0000000189637720
	public virtual void OnBeforePoolRecycled() {} // 0x000000018554A560-0x000000018554A600
}

