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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class H5ActivityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15693
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 h5ActivityIdRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected uint _detailTextMapHash; // 0x18
	protected SimpleSafeUInt32 rewardPreviewRawNum; // 0x1C
	protected LogicType _condComb; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected H5ActivityCondConfig[] _condList; // 0x28

	// Properties
	public uint h5ActivityId { /* [XID] */ /* 0x0000000189AD6660-0x0000000189AD6680 */ get => default; /* [XID] */ /* 0x0000000189ADDEC0-0x0000000189ADDEE0 */ protected set {} } // 0x00000001839B6000-0x00000001839B60D0 0x00000001839B5DD0-0x00000001839B5EB0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189AE5A00-0x0000000189AE5A20 */ get => default; /* [XID] */ /* 0x0000000189AECE00-0x0000000189AECE20 */ protected set {} } // 0x00000001839B48C0-0x00000001839B4960 0x00000001839B5F50-0x00000001839B6000
	public string name { /* [XID] */ /* 0x0000000189AF4750-0x0000000189AF4770 */ get => default; } // 0x00000001839B62B0-0x00000001839B6430 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint detailTextMapHash { /* [XID] */ /* 0x0000000189AFBD60-0x0000000189AFBD80 */ get => default; /* [XID] */ /* 0x0000000189B03630-0x0000000189B03650 */ protected set {} } // 0x00000001839B5EB0-0x00000001839B5F50 0x00000001839B55A0-0x00000001839B5650
	public string detail { /* [XID] */ /* 0x0000000189B0AD80-0x0000000189B0ADA0 */ get => default; } // 0x00000001839B4740-0x00000001839B48C0 
	public uint rewardPreview { /* [XID] */ /* 0x0000000189B125E0-0x0000000189B12600 */ get => default; /* [XID] */ /* 0x0000000189B19890-0x0000000189B198B0 */ protected set {} } // 0x00000001839B54D0-0x00000001839B55A0 0x00000001839B5650-0x00000001839B5730
	public LogicType condComb { /* [XID] */ /* 0x0000000189B20F30-0x0000000189B20F50 */ get => default; /* [XID] */ /* 0x0000000189B28650-0x0000000189B28670 */ protected set {} } // 0x00000001839B60D0-0x00000001839B6170 0x00000001839B5D20-0x00000001839B5DD0
	public H5ActivityCondConfig[] condList { /* [XID] */ /* 0x0000000189B2FA10-0x0000000189B2FA30 */ get => default; /* [XID] */ /* 0x0000000189B373B0-0x0000000189B373D0 */ protected set {} } // 0x00000001839B4510-0x00000001839B45B0 0x00000001839B4960-0x00000001839B4A10

	// Constructors
	public H5ActivityExcelConfig() {} // 0x00000001839B64D0-0x00000001839B6530

	// Methods
	// [IDTag] // 0x0000000189B3EC00-0x0000000189B3EC40
	// [XID] // 0x0000000189B3EC00-0x0000000189B3EC40
	public virtual bool ParseFromLine(string line) => default; // 0x00000001839B4A10-0x00000001839B4FD0
	// [IDTag] // 0x0000000189B49820-0x0000000189B49860
	// [XID] // 0x0000000189B49820-0x0000000189B49860
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839B4FD0-0x00000001839B54D0
	// [XID] // 0x0000000189B53C80-0x0000000189B53CA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2340 */, bool useObjectPool = false /* Metadata: 0x00AF2344 */) => default; // 0x00000001839B5730-0x00000001839B5D20
	[BlackList] // 0x0000000189B5B530-0x0000000189B5B570
	// [XID] // 0x0000000189B5B530-0x0000000189B5B570
	public virtual void AutoAllocTypeFields() {} // 0x00000001839B45B0-0x00000001839B4650
	[BlackList] // 0x0000000189B65C20-0x0000000189B65C60
	// [XID] // 0x0000000189B65C20-0x0000000189B65C60
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839B4650-0x00000001839B4740
	[BlackList] // 0x0000000189B70300-0x0000000189B70340
	// [XID] // 0x0000000189B70300-0x0000000189B70340
	public virtual void ReturnToObjectPool() {} // 0x00000001839B6430-0x00000001839B64D0
	[BlackList] // 0x0000000189B7A790-0x0000000189B7A7D0
	// [XID] // 0x0000000189B7A790-0x0000000189B7A7D0
	public virtual void OnPoolAllocated() {} // 0x00000001839B6210-0x00000001839B62B0
	[BlackList] // 0x0000000189B85490-0x0000000189B854D0
	// [XID] // 0x0000000189B85490-0x0000000189B854D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839B6170-0x00000001839B6210
}

