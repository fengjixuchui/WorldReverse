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
public class OverflowTransformExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14882
{
	// Fields
	protected OverflowTransformType _transformType; // 0x10
	protected SimpleSafeUInt32 transformIdRawNum; // 0x14
	protected SimpleSafeUInt32 transformBaseCountRawNum; // 0x18
	protected IdCountConfig[] _transformResults; // 0x20
	protected ItemLimitType _transformItemLimitType; // 0x28

	// Properties
	public OverflowTransformType transformType { /* [XID] */ /* 0x0000000189780DC0-0x0000000189780DE0 */ get => default; /* [XID] */ /* 0x0000000189788340-0x0000000189788360 */ protected set {} } // 0x00000001843F6E70-0x00000001843F6F10 0x00000001843F79E0-0x00000001843F7A90
	public uint transformId { /* [XID] */ /* 0x000000018978F900-0x000000018978F920 */ get => default; /* [XID] */ /* 0x00000001897970F0-0x0000000189797110 */ protected set {} } // 0x00000001843F7910-0x00000001843F79E0 0x00000001843F6A70-0x00000001843F6B50
	public uint transformBaseCount { /* [XID] */ /* 0x000000018979F150-0x000000018979F170 */ get => default; /* [XID] */ /* 0x00000001897A67E0-0x00000001897A6800 */ protected set {} } // 0x00000001843F8200-0x00000001843F82D0 0x00000001843F7A90-0x00000001843F7B70
	public IdCountConfig[] transformResults { /* [XID] */ /* 0x00000001897ADE10-0x00000001897ADE30 */ get => default; /* [XID] */ /* 0x00000001897B5EF0-0x00000001897B5F10 */ protected set {} } // 0x00000001843F6F10-0x00000001843F6FB0 0x00000001843F82D0-0x00000001843F8380
	public ItemLimitType transformItemLimitType { /* [XID] */ /* 0x00000001897BDD00-0x00000001897BDD20 */ get => default; /* [XID] */ /* 0x00000001897C50C0-0x00000001897C50E0 */ protected set {} } // 0x00000001843F6DD0-0x00000001843F6E70 0x00000001843F8380-0x00000001843F8430

	// Constructors
	public OverflowTransformExcelConfig() {} // 0x00000001843F84D0-0x00000001843F8530

	// Methods
	// [XID] // 0x0000000189779500-0x0000000189779520
	public bool IsOverflow() => default; // 0x00000001843F6B50-0x00000001843F6DD0
	// [IDTag] // 0x00000001897CC8F0-0x00000001897CC930
	// [XID] // 0x00000001897CC8F0-0x00000001897CC930
	public virtual bool ParseFromLine(string line) => default; // 0x00000001843F6FB0-0x00000001843F74B0
	// [IDTag] // 0x00000001897D7280-0x00000001897D72C0
	// [XID] // 0x00000001897D7280-0x00000001897D72C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843F74B0-0x00000001843F7910
	// [XID] // 0x00000001897E1A80-0x00000001897E1AA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8D6 */, bool useObjectPool = false /* Metadata: 0x00AEF8DA */) => default; // 0x00000001843F7B70-0x00000001843F80C0
	[BlackList] // 0x00000001897E9250-0x00000001897E9290
	// [XID] // 0x00000001897E9250-0x00000001897E9290
	public virtual void AutoAllocTypeFields() {} // 0x00000001843F68E0-0x00000001843F6980
	[BlackList] // 0x00000001897F3F30-0x00000001897F3F70
	// [XID] // 0x00000001897F3F30-0x00000001897F3F70
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843F6980-0x00000001843F6A70
	[BlackList] // 0x00000001897FE1A0-0x00000001897FE1E0
	// [XID] // 0x00000001897FE1A0-0x00000001897FE1E0
	public virtual void ReturnToObjectPool() {} // 0x00000001843F8430-0x00000001843F84D0
	[BlackList] // 0x00000001898089E0-0x0000000189808A20
	// [XID] // 0x00000001898089E0-0x0000000189808A20
	public virtual void OnPoolAllocated() {} // 0x00000001843F8160-0x00000001843F8200
	[BlackList] // 0x0000000189813060-0x00000001898130A0
	// [XID] // 0x0000000189813060-0x00000001898130A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843F80C0-0x00000001843F8160
}

