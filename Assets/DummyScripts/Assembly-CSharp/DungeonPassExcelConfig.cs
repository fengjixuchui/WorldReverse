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
public class DungeonPassExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15549
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected LogicType _logicType; // 0x14
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected DungeonCondConfig[] _conds; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189891EA0-0x0000000189891EC0 */ get => default; /* [XID] */ /* 0x0000000189899830-0x0000000189899850 */ protected set {} } // 0x0000000182CC5710-0x0000000182CC57E0 0x0000000182CC4EF0-0x0000000182CC4FD0
	public LogicType logicType { /* [XID] */ /* 0x00000001898A08F0-0x00000001898A0910 */ get => default; /* [XID] */ /* 0x00000001898A7FD0-0x00000001898A7FF0 */ protected set {} } // 0x0000000182CC5530-0x0000000182CC55D0 0x0000000182CC5480-0x0000000182CC5530
	public DungeonCondConfig[] conds { /* [XID] */ /* 0x00000001898AFAB0-0x00000001898AFAD0 */ get => default; /* [XID] */ /* 0x00000001898B7050-0x00000001898B7070 */ protected set {} } // 0x0000000182CC53E0-0x0000000182CC5480 0x0000000182CC4E40-0x0000000182CC4EF0

	// Constructors
	public DungeonPassExcelConfig() {} // 0x0000000182CC5880-0x0000000182CC58E0

	// Methods
	// [IDTag] // 0x00000001898BE7E0-0x00000001898BE820
	// [XID] // 0x00000001898BE7E0-0x00000001898BE820
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182CC46A0-0x0000000182CC4AC0
	// [IDTag] // 0x00000001898C9200-0x00000001898C9240
	// [XID] // 0x00000001898C9200-0x00000001898C9240
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182CC4AC0-0x0000000182CC4E40
	// [XID] // 0x00000001898D37D0-0x00000001898D37F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1ECB */, bool useObjectPool = false /* Metadata: 0x00AF1ECF */) => default; // 0x0000000182CC4FD0-0x0000000182CC53E0
	[BlackList] // 0x00000001898DB020-0x00000001898DB060
	// [XID] // 0x00000001898DB020-0x00000001898DB060
	public virtual void AutoAllocTypeFields() {} // 0x0000000182CC4520-0x0000000182CC45C0
	[BlackList] // 0x00000001898E5F20-0x00000001898E5F60
	// [XID] // 0x00000001898E5F20-0x00000001898E5F60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182CC45C0-0x0000000182CC46A0
	[BlackList] // 0x00000001898F0980-0x00000001898F09C0
	// [XID] // 0x00000001898F0980-0x00000001898F09C0
	public virtual void ReturnToObjectPool() {} // 0x0000000182CC57E0-0x0000000182CC5880
	[BlackList] // 0x00000001898FAF20-0x00000001898FAF60
	// [XID] // 0x00000001898FAF20-0x00000001898FAF60
	public virtual void OnPoolAllocated() {} // 0x0000000182CC5670-0x0000000182CC5710
	[BlackList] // 0x00000001899059E0-0x0000000189905A20
	// [XID] // 0x00000001899059E0-0x0000000189905A20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182CC55D0-0x0000000182CC5670
}

