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
public class HomeWorldLeastShopExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15726
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected SimpleSafeUInt32 poolIDRawNum; // 0x14
	protected SimpleSafeUInt32 countRawNum; // 0x18

	// Properties
	public uint level { /* [XID] */ /* 0x000000018996B3B0-0x000000018996B3D0 */ get => default; /* [XID] */ /* 0x0000000189972E70-0x0000000189972E90 */ protected set {} } // 0x0000000182858C40-0x0000000182858D10 0x0000000182858B60-0x0000000182858C40
	public uint poolID { /* [XID] */ /* 0x000000018997A770-0x000000018997A790 */ get => default; /* [XID] */ /* 0x00000001899820C0-0x00000001899820E0 */ protected set {} } // 0x0000000182858020-0x00000001828580F0 0x0000000182858D10-0x0000000182858DF0
	public uint count { /* [XID] */ /* 0x0000000189989960-0x0000000189989980 */ get => default; /* [XID] */ /* 0x00000001899911D0-0x00000001899911F0 */ protected set {} } // 0x0000000182858DF0-0x0000000182858EC0 0x0000000182858670-0x0000000182858750

	// Constructors
	public HomeWorldLeastShopExcelConfig() {} // 0x00000001828590A0-0x0000000182859100

	// Methods
	// [IDTag] // 0x0000000189998C70-0x0000000189998CB0
	// [XID] // 0x0000000189998C70-0x0000000189998CB0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001828580F0-0x00000001828583D0
	// [IDTag] // 0x00000001899A34B0-0x00000001899A34F0
	// [XID] // 0x00000001899A34B0-0x00000001899A34F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001828583D0-0x0000000182858670
	// [XID] // 0x00000001899ADEE0-0x00000001899ADF00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2459 */, bool useObjectPool = false /* Metadata: 0x00AF245D */) => default; // 0x0000000182858750-0x0000000182858B60
	[BlackList] // 0x00000001899B56C0-0x00000001899B5700
	// [XID] // 0x00000001899B56C0-0x00000001899B5700
	public virtual void AutoAllocTypeFields() {} // 0x0000000182857E90-0x0000000182857F30
	[BlackList] // 0x00000001899BFEF0-0x00000001899BFF30
	// [XID] // 0x00000001899BFEF0-0x00000001899BFF30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182857F30-0x0000000182858020
	[BlackList] // 0x00000001899CA5A0-0x00000001899CA5E0
	// [XID] // 0x00000001899CA5A0-0x00000001899CA5E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182859000-0x00000001828590A0
	[BlackList] // 0x00000001899D4B90-0x00000001899D4BD0
	// [XID] // 0x00000001899D4B90-0x00000001899D4BD0
	public virtual void OnPoolAllocated() {} // 0x0000000182858F60-0x0000000182859000
	[BlackList] // 0x00000001899DF030-0x00000001899DF070
	// [XID] // 0x00000001899DF030-0x00000001899DF070
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182858EC0-0x0000000182858F60
}

