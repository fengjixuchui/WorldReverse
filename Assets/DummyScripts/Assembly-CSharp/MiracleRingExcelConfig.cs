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
public class MiracleRingExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15833
{
	// Fields
	protected SimpleSafeUInt32 itemIdRawNum; // 0x10
	protected SimpleSafeUInt32 miracleValueRawNum; // 0x14
	protected MiracleTag[] _miracleTag; // 0x18

	// Properties
	public uint itemId { /* [XID] */ /* 0x0000000189AA2AA0-0x0000000189AA2AC0 */ get => default; /* [XID] */ /* 0x0000000189AAA160-0x0000000189AAA180 */ protected set {} } // 0x0000000182E11B80-0x0000000182E11C50 0x0000000182E12400-0x0000000182E124E0
	public uint miracleValue { /* [XID] */ /* 0x0000000189AB1F00-0x0000000189AB1F20 */ get => default; /* [XID] */ /* 0x0000000189AB91B0-0x0000000189AB91D0 */ protected set {} } // 0x0000000182E124E0-0x0000000182E125B0 0x0000000182E125B0-0x0000000182E12690
	public MiracleTag[] miracleTag { /* [XID] */ /* 0x0000000189AC0D90-0x0000000189AC0DB0 */ get => default; /* [XID] */ /* 0x0000000189AC87D0-0x0000000189AC87F0 */ protected set {} } // 0x0000000182E11AE0-0x0000000182E11B80 0x0000000182E12BE0-0x0000000182E12C90

	// Constructors
	public MiracleRingExcelConfig() {} // 0x0000000182E12D30-0x0000000182E12D90

	// Methods
	// [IDTag] // 0x0000000189ACFF10-0x0000000189ACFF50
	// [XID] // 0x0000000189ACFF10-0x0000000189ACFF50
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182E11C50-0x0000000182E12050
	// [IDTag] // 0x0000000189ADAC40-0x0000000189ADAC80
	// [XID] // 0x0000000189ADAC40-0x0000000189ADAC80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182E12050-0x0000000182E12400
	// [XID] // 0x0000000189AE5980-0x0000000189AE59A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF27D6 */, bool useObjectPool = false /* Metadata: 0x00AF27DA */) => default; // 0x0000000182E12690-0x0000000182E12AA0
	[BlackList] // 0x0000000189AECD60-0x0000000189AECDA0
	// [XID] // 0x0000000189AECD60-0x0000000189AECDA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E11950-0x0000000182E119F0
	[BlackList] // 0x0000000189AF78C0-0x0000000189AF7900
	// [XID] // 0x0000000189AF78C0-0x0000000189AF7900
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E119F0-0x0000000182E11AE0
	[BlackList] // 0x0000000189B02070-0x0000000189B020B0
	// [XID] // 0x0000000189B02070-0x0000000189B020B0
	public virtual void ReturnToObjectPool() {} // 0x0000000182E12C90-0x0000000182E12D30
	[BlackList] // 0x0000000189B0C610-0x0000000189B0C650
	// [XID] // 0x0000000189B0C610-0x0000000189B0C650
	public virtual void OnPoolAllocated() {} // 0x0000000182E12B40-0x0000000182E12BE0
	[BlackList] // 0x0000000189B168B0-0x0000000189B168F0
	// [XID] // 0x0000000189B168B0-0x0000000189B168F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E12AA0-0x0000000182E12B40
}

