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
public class HuntingClueMonsterExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15750
{
	// Fields
	protected SimpleSafeUInt32 configIdRawNum; // 0x10
	protected SimpleSafeUInt32 monsterIdRawNum; // 0x14
	protected SimpleSafeUInt32 reviseLevelIdRawNum; // 0x18
	protected HuntingMonsterGroupType _groupType; // 0x1C
	protected SimpleSafeUInt32 monsterGroupIdRawNum; // 0x20
	protected SimpleSafeUInt32 levelRawNum; // 0x24
	protected bool _isClueMonster; // 0x28

	// Properties
	public uint configId { /* [XID] */ /* 0x0000000189AEEB40-0x0000000189AEEB60 */ get => default; /* [XID] */ /* 0x0000000189AF6110-0x0000000189AF6130 */ protected set {} } // 0x00000001854B1A30-0x00000001854B1B00 0x00000001854B2660-0x00000001854B2740
	public uint monsterId { /* [XID] */ /* 0x0000000189AFD710-0x0000000189AFD730 */ get => default; /* [XID] */ /* 0x0000000189B04DE0-0x0000000189B04E00 */ protected set {} } // 0x00000001854B1B00-0x00000001854B1BD0 0x00000001854B1950-0x00000001854B1A30
	public uint reviseLevelId { /* [XID] */ /* 0x0000000189B0C650-0x0000000189B0C670 */ get => default; /* [XID] */ /* 0x0000000189B13B10-0x0000000189B13B30 */ protected set {} } // 0x00000001854B0DB0-0x00000001854B0E80 0x00000001854B2920-0x00000001854B2A00
	public HuntingMonsterGroupType groupType { /* [XID] */ /* 0x0000000189B1B1E0-0x0000000189B1B200 */ get => default; /* [XID] */ /* 0x0000000189B22970-0x0000000189B22990 */ protected set {} } // 0x00000001854B24F0-0x00000001854B2590 0x00000001854B17F0-0x00000001854B18A0
	public uint monsterGroupId { /* [XID] */ /* 0x0000000189B29EE0-0x0000000189B29F00 */ get => default; /* [XID] */ /* 0x0000000189B315F0-0x0000000189B31610 */ protected set {} } // 0x00000001854B2590-0x00000001854B2660 0x00000001854B2410-0x00000001854B24F0
	public uint level { /* [XID] */ /* 0x0000000189B38A30-0x0000000189B38A50 */ get => default; /* [XID] */ /* 0x0000000189B40360-0x0000000189B40380 */ protected set {} } // 0x00000001854B2340-0x00000001854B2410 0x00000001854B2260-0x00000001854B2340
	public bool isClueMonster { /* [XID] */ /* 0x0000000189B47C40-0x0000000189B47C60 */ get => default; /* [XID] */ /* 0x0000000189B4F530-0x0000000189B4F550 */ protected set {} } // 0x00000001854B2740-0x00000001854B27E0 0x00000001854B18A0-0x00000001854B1950

	// Constructors
	public HuntingClueMonsterExcelConfig() {} // 0x00000001854B2AA0-0x00000001854B2B00

	// Methods
	// [IDTag] // 0x0000000189B56DF0-0x0000000189B56E30
	// [XID] // 0x0000000189B56DF0-0x0000000189B56E30
	public virtual bool ParseFromLine(string line) => default; // 0x00000001854B1330-0x00000001854B17F0
	// [IDTag] // 0x0000000189B613F0-0x0000000189B61430
	// [XID] // 0x0000000189B613F0-0x0000000189B61430
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001854B0E80-0x00000001854B1330
	// [XID] // 0x0000000189B6B9F0-0x0000000189B6BA10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2503 */, bool useObjectPool = false /* Metadata: 0x00AF2507 */) => default; // 0x00000001854B1BD0-0x00000001854B2260
	[BlackList] // 0x0000000189B73250-0x0000000189B73290
	// [XID] // 0x0000000189B73250-0x0000000189B73290
	public virtual void AutoAllocTypeFields() {} // 0x00000001854B0BE0-0x00000001854B0C80
	[BlackList] // 0x0000000189B7D720-0x0000000189B7D760
	// [XID] // 0x0000000189B7D720-0x0000000189B7D760
	public virtual void AutoRecycleTypeFields() {} // 0x00000001854B0C80-0x00000001854B0DB0
	[BlackList] // 0x0000000189B880C0-0x0000000189B88100
	// [XID] // 0x0000000189B880C0-0x0000000189B88100
	public virtual void ReturnToObjectPool() {} // 0x00000001854B2A00-0x00000001854B2AA0
	[BlackList] // 0x0000000189B92220-0x0000000189B92260
	// [XID] // 0x0000000189B92220-0x0000000189B92260
	public virtual void OnPoolAllocated() {} // 0x00000001854B2880-0x00000001854B2920
	[BlackList] // 0x0000000189B9C700-0x0000000189B9C740
	// [XID] // 0x0000000189B9C700-0x0000000189B9C740
	public virtual void OnBeforePoolRecycled() {} // 0x00000001854B27E0-0x00000001854B2880
}

