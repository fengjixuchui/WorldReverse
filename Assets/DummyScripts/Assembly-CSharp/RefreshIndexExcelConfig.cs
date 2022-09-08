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
public class RefreshIndexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16011
{
	// Fields
	protected SimpleSafeUInt32 priorityRawNum; // 0x10
	protected RefreshIndexType _type; // 0x14
	protected MonsterRarityType _rarity; // 0x18
	protected string _name; // 0x20
	protected SimpleSafeUInt32 refreshIdRawNum; // 0x28

	// Properties
	public uint priority { /* [XID] */ /* 0x00000001898C9100-0x00000001898C9120 */ get => default; /* [XID] */ /* 0x00000001898D0940-0x00000001898D0960 */ protected set {} } // 0x0000000183E497F0-0x0000000183E498C0 0x0000000183E48F60-0x0000000183E49040
	public RefreshIndexType type { /* [XID] */ /* 0x00000001898D8020-0x00000001898D8040 */ get => default; /* [XID] */ /* 0x00000001898DFEC0-0x00000001898DFEE0 */ protected set {} } // 0x0000000183E49C00-0x0000000183E49CA0 0x0000000183E49970-0x0000000183E49A20
	public MonsterRarityType rarity { /* [XID] */ /* 0x00000001898E7950-0x00000001898E7970 */ get => default; /* [XID] */ /* 0x00000001898EEFE0-0x00000001898EF000 */ protected set {} } // 0x0000000183E49A20-0x0000000183E49AC0 0x0000000183E498C0-0x0000000183E49970
	public string name { /* [XID] */ /* 0x00000001898F68C0-0x00000001898F68E0 */ get => default; /* [XID] */ /* 0x00000001898FE080-0x00000001898FE0A0 */ protected set {} } // 0x0000000183E49CA0-0x0000000183E49D40 0x0000000183E491F0-0x0000000183E492A0
	public uint refreshId { /* [XID] */ /* 0x00000001899058A0-0x00000001899058C0 */ get => default; /* [XID] */ /* 0x000000018990D1D0-0x000000018990D1F0 */ protected set {} } // 0x0000000183E49120-0x0000000183E491F0 0x0000000183E49040-0x0000000183E49120

	// Constructors
	public RefreshIndexExcelConfig() {} // 0x0000000183E49DE0-0x0000000183E49E40

	// Methods
	// [IDTag] // 0x0000000189914900-0x0000000189914940
	// [XID] // 0x0000000189914900-0x0000000189914940
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183E487B0-0x0000000183E48BA0
	// [IDTag] // 0x000000018991F0E0-0x000000018991F120
	// [XID] // 0x000000018991F0E0-0x000000018991F120
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183E48BA0-0x0000000183E48F60
	// [XID] // 0x0000000189929BA0-0x0000000189929BC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2DAD */, bool useObjectPool = false /* Metadata: 0x00AF2DB1 */) => default; // 0x0000000183E492A0-0x0000000183E497F0
	[BlackList] // 0x0000000189931120-0x0000000189931160
	// [XID] // 0x0000000189931120-0x0000000189931160
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E48620-0x0000000183E486C0
	[BlackList] // 0x000000018993BAF0-0x000000018993BB30
	// [XID] // 0x000000018993BAF0-0x000000018993BB30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E486C0-0x0000000183E487B0
	[BlackList] // 0x0000000189945F80-0x0000000189945FC0
	// [XID] // 0x0000000189945F80-0x0000000189945FC0
	public virtual void ReturnToObjectPool() {} // 0x0000000183E49D40-0x0000000183E49DE0
	[BlackList] // 0x0000000189950750-0x0000000189950790
	// [XID] // 0x0000000189950750-0x0000000189950790
	public virtual void OnPoolAllocated() {} // 0x0000000183E49B60-0x0000000183E49C00
	[BlackList] // 0x000000018995ACB0-0x000000018995ACF0
	// [XID] // 0x000000018995ACB0-0x000000018995ACF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E49AC0-0x0000000183E49B60
}

