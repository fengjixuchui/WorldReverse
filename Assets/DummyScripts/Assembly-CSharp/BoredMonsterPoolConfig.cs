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
public class BoredMonsterPoolConfig : IAutoAllocRecycle // TypeDefIndex: 15292
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 monster_idRawNum; // 0x14
	protected SimpleSafeUInt32 levelRawNum; // 0x18
	protected string _dropTag; // 0x20
	protected SimpleSafeUInt32[] _affixVec; // 0x28
	protected bool _isElite; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B29FA0-0x0000000189B29FC0 */ get => default; /* [XID] */ /* 0x0000000189B31670-0x0000000189B31690 */ protected set {} } // 0x0000000182954AD0-0x0000000182954BA0 0x0000000182953E00-0x0000000182953EE0
	public uint monster_id { /* [XID] */ /* 0x0000000189B38A70-0x0000000189B38A90 */ get => default; /* [XID] */ /* 0x0000000189B40400-0x0000000189B40420 */ protected set {} } // 0x00000001829547E0-0x00000001829548B0 0x00000001829548B0-0x0000000182954990
	public uint level { /* [XID] */ /* 0x0000000189B47CC0-0x0000000189B47CE0 */ get => default; /* [XID] */ /* 0x0000000189B4F5B0-0x0000000189B4F5D0 */ protected set {} } // 0x00000001829545C0-0x0000000182954690 0x00000001829544E0-0x00000001829545C0
	public string dropTag { /* [XID] */ /* 0x0000000189B56ED0-0x0000000189B56EF0 */ get => default; /* [XID] */ /* 0x0000000189B5E7C0-0x0000000189B5E7E0 */ protected set {} } // 0x0000000182952F60-0x0000000182953000 0x0000000182953C00-0x0000000182953CB0
	public SimpleSafeUInt32[] affixVec { /* [XID] */ /* 0x0000000189B65D20-0x0000000189B65D40 */ get => default; /* [XID] */ /* 0x0000000189B6D300-0x0000000189B6D320 */ protected set {} } // 0x0000000182954690-0x0000000182954730 0x0000000182953D50-0x0000000182953E00
	public bool isElite { /* [XID] */ /* 0x0000000189B74A10-0x0000000189B74A30 */ get => default; /* [XID] */ /* 0x0000000189B7C050-0x0000000189B7C070 */ protected set {} } // 0x0000000182953CB0-0x0000000182953D50 0x0000000182954730-0x00000001829547E0

	// Constructors
	public BoredMonsterPoolConfig() {} // 0x0000000182954C40-0x0000000182954CA0

	// Methods
	// [IDTag] // 0x0000000189B83960-0x0000000189B839A0
	// [XID] // 0x0000000189B83960-0x0000000189B839A0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001829535F0-0x0000000182953C00
	// [IDTag] // 0x0000000189B8DBF0-0x0000000189B8DC30
	// [XID] // 0x0000000189B8DBF0-0x0000000189B8DC30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182953000-0x00000001829535F0
	// [XID] // 0x0000000189B98120-0x0000000189B98140
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF068D */, bool useObjectPool = false /* Metadata: 0x00AF0691 */) => default; // 0x0000000182953EE0-0x00000001829544E0
	[BlackList] // 0x0000000189B9F5B0-0x0000000189B9F5F0
	// [XID] // 0x0000000189B9F5B0-0x0000000189B9F5F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182952DC0-0x0000000182952E60
	[BlackList] // 0x0000000189BA9D60-0x0000000189BA9DA0
	// [XID] // 0x0000000189BA9D60-0x0000000189BA9DA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182952E60-0x0000000182952F60
	[BlackList] // 0x0000000189BB4150-0x0000000189BB4190
	// [XID] // 0x0000000189BB4150-0x0000000189BB4190
	public virtual void ReturnToObjectPool() {} // 0x0000000182954BA0-0x0000000182954C40
	[BlackList] // 0x0000000189BBE450-0x0000000189BBE490
	// [XID] // 0x0000000189BBE450-0x0000000189BBE490
	public virtual void OnPoolAllocated() {} // 0x0000000182954A30-0x0000000182954AD0
	[BlackList] // 0x0000000189BC9320-0x0000000189BC9360
	// [XID] // 0x0000000189BC9320-0x0000000189BC9360
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182954990-0x0000000182954A30
}

