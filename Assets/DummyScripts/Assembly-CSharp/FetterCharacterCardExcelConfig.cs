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
public class FetterCharacterCardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15616
{
	// Fields
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x10
	protected SimpleSafeUInt32 fetterLevelRawNum; // 0x14
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x18

	// Properties
	public uint avatarId { /* [XID] */ /* 0x000000018997EA80-0x000000018997EAA0 */ get => default; /* [XID] */ /* 0x0000000189986390-0x00000001899863B0 */ protected set {} } // 0x0000000183E167E0-0x0000000183E168B0 0x0000000183E15FF0-0x0000000183E160D0
	public uint fetterLevel { /* [XID] */ /* 0x000000018998DFC0-0x000000018998DFE0 */ get => default; /* [XID] */ /* 0x0000000189995B30-0x0000000189995B50 */ protected set {} } // 0x0000000183E16E70-0x0000000183E16F40 0x0000000183E168B0-0x0000000183E16990
	public uint rewardId { /* [XID] */ /* 0x000000018999D470-0x000000018999D490 */ get => default; /* [XID] */ /* 0x00000001899A4D50-0x00000001899A4D70 */ protected set {} } // 0x0000000183E16DA0-0x0000000183E16E70 0x0000000183E15F10-0x0000000183E15FF0

	// Constructors
	public FetterCharacterCardExcelConfig() {} // 0x0000000183E17120-0x0000000183E17180

	// Methods
	// [IDTag] // 0x00000001899AC930-0x00000001899AC970
	// [XID] // 0x00000001899AC930-0x00000001899AC970
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183E16260-0x0000000183E16540
	// [IDTag] // 0x00000001899B6BF0-0x00000001899B6C30
	// [XID] // 0x00000001899B6BF0-0x00000001899B6C30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183E16540-0x0000000183E167E0
	// [XID] // 0x00000001899C1730-0x00000001899C1750
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20B5 */, bool useObjectPool = false /* Metadata: 0x00AF20B9 */) => default; // 0x0000000183E16990-0x0000000183E16DA0
	[BlackList] // 0x00000001899C8C80-0x00000001899C8CC0
	// [XID] // 0x00000001899C8C80-0x00000001899C8CC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E160D0-0x0000000183E16170
	[BlackList] // 0x00000001899D34F0-0x00000001899D3530
	// [XID] // 0x00000001899D34F0-0x00000001899D3530
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E16170-0x0000000183E16260
	[BlackList] // 0x00000001899DD900-0x00000001899DD940
	// [XID] // 0x00000001899DD900-0x00000001899DD940
	public virtual void ReturnToObjectPool() {} // 0x0000000183E17080-0x0000000183E17120
	[BlackList] // 0x00000001899E84A0-0x00000001899E84E0
	// [XID] // 0x00000001899E84A0-0x00000001899E84E0
	public virtual void OnPoolAllocated() {} // 0x0000000183E16FE0-0x0000000183E17080
	[BlackList] // 0x00000001899F2B40-0x00000001899F2B80
	// [XID] // 0x00000001899F2B40-0x00000001899F2B80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E16F40-0x0000000183E16FE0
}

