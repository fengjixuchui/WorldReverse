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
public class HomeworldNPCExcelData : IAutoAllocRecycle // TypeDefIndex: 15710
{
	// Fields
	protected SimpleSafeUInt32 avatarIDRawNum; // 0x10
	protected SimpleSafeUInt32 IDRawNum; // 0x14
	protected SimpleSafeUInt32 furnitureIDRawNum; // 0x18
	protected SimpleSafeUInt32 npcIDRawNum; // 0x1C

	// Properties
	public uint avatarID { /* [XID] */ /* 0x0000000189B125C0-0x0000000189B125E0 */ get => default; /* [XID] */ /* 0x0000000189B19870-0x0000000189B19890 */ protected set {} } // 0x000000018468AF30-0x000000018468B000 0x000000018468B670-0x000000018468B750
	public uint ID { /* [XID] */ /* 0x0000000189B20F10-0x0000000189B20F30 */ get => default; /* [XID] */ /* 0x0000000189B28630-0x0000000189B28650 */ protected set {} } // 0x000000018468B750-0x000000018468B820 0x000000018468ABD0-0x000000018468ACB0
	public uint furnitureID { /* [XID] */ /* 0x0000000189B2F9F0-0x0000000189B2FA10 */ get => default; /* [XID] */ /* 0x0000000189B37390-0x0000000189B373B0 */ protected set {} } // 0x000000018468ACB0-0x000000018468AD80 0x000000018468AAF0-0x000000018468ABD0
	public uint npcID { /* [XID] */ /* 0x0000000189B3EBE0-0x0000000189B3EC00 */ get => default; /* [XID] */ /* 0x0000000189B46680-0x0000000189B466A0 */ protected set {} } // 0x000000018468B820-0x000000018468B8F0 0x000000018468BDA0-0x000000018468BE80

	// Constructors
	public HomeworldNPCExcelData() {} // 0x000000018468C060-0x000000018468C0C0

	// Methods
	// [IDTag] // 0x0000000189B4DC20-0x0000000189B4DC60
	// [XID] // 0x0000000189B4DC20-0x0000000189B4DC60
	public virtual bool ParseFromLine(string line) => default; // 0x000000018468B000-0x000000018468B350
	// [IDTag] // 0x0000000189B586B0-0x0000000189B586F0
	// [XID] // 0x0000000189B586B0-0x0000000189B586F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018468B350-0x000000018468B670
	// [XID] // 0x0000000189B629E0-0x0000000189B62A00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23E1 */, bool useObjectPool = false /* Metadata: 0x00AF23E5 */) => default; // 0x000000018468B8F0-0x000000018468BDA0
	[BlackList] // 0x0000000189B6A4D0-0x0000000189B6A510
	// [XID] // 0x0000000189B6A4D0-0x0000000189B6A510
	public virtual void AutoAllocTypeFields() {} // 0x000000018468AD80-0x000000018468AE20
	[BlackList] // 0x0000000189B74910-0x0000000189B74950
	// [XID] // 0x0000000189B74910-0x0000000189B74950
	public virtual void AutoRecycleTypeFields() {} // 0x000000018468AE20-0x000000018468AF30
	[BlackList] // 0x0000000189B7EE00-0x0000000189B7EE40
	// [XID] // 0x0000000189B7EE00-0x0000000189B7EE40
	public virtual void ReturnToObjectPool() {} // 0x000000018468BFC0-0x000000018468C060
	[BlackList] // 0x0000000189B89770-0x0000000189B897B0
	// [XID] // 0x0000000189B89770-0x0000000189B897B0
	public virtual void OnPoolAllocated() {} // 0x000000018468BF20-0x000000018468BFC0
	[BlackList] // 0x0000000189B93B30-0x0000000189B93B70
	// [XID] // 0x0000000189B93B30-0x0000000189B93B70
	public virtual void OnBeforePoolRecycled() {} // 0x000000018468BE80-0x000000018468BF20
}

