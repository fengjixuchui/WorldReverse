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
public class DailyTaskRewardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15483
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected DailyTaskDropConfig[] _dropVec; // 0x18

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189B5E780-0x0000000189B5E7A0 */ get => default; /* [XID] */ /* 0x0000000189B65CE0-0x0000000189B65D00 */ protected set {} } // 0x00000001855292F0-0x00000001855293C0 0x0000000185528A20-0x0000000185528B00
	public DailyTaskDropConfig[] dropVec { /* [XID] */ /* 0x0000000189B6D2E0-0x0000000189B6D300 */ get => default; /* [XID] */ /* 0x0000000189B749D0-0x0000000189B749F0 */ protected set {} } // 0x0000000185528980-0x0000000185528A20 0x0000000185529730-0x00000001855297E0

	// Constructors
	public DailyTaskRewardExcelConfig() {} // 0x00000001855299C0-0x0000000185529A20

	// Methods
	// [IDTag] // 0x0000000189B7BFD0-0x0000000189B7C010
	// [XID] // 0x0000000189B7BFD0-0x0000000189B7C010
	public virtual bool ParseFromLine(string line) => default; // 0x0000000185528C80-0x0000000185529000
	// [IDTag] // 0x0000000189B86A00-0x0000000189B86A40
	// [XID] // 0x0000000189B86A00-0x0000000189B86A40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000185529000-0x00000001855292F0
	// [XID] // 0x0000000189B90DB0-0x0000000189B90DD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1BFA */, bool useObjectPool = false /* Metadata: 0x00AF1BFE */) => default; // 0x00000001855293C0-0x0000000185529730
	[BlackList] // 0x0000000189B980E0-0x0000000189B98120
	// [XID] // 0x0000000189B980E0-0x0000000189B98120
	public virtual void AutoAllocTypeFields() {} // 0x0000000185528B00-0x0000000185528BA0
	[BlackList] // 0x0000000189BA28F0-0x0000000189BA2930
	// [XID] // 0x0000000189BA28F0-0x0000000189BA2930
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185528BA0-0x0000000185528C80
	[BlackList] // 0x0000000189BAC890-0x0000000189BAC8D0
	// [XID] // 0x0000000189BAC890-0x0000000189BAC8D0
	public virtual void ReturnToObjectPool() {} // 0x0000000185529920-0x00000001855299C0
	[BlackList] // 0x0000000189BB6E90-0x0000000189BB6ED0
	// [XID] // 0x0000000189BB6E90-0x0000000189BB6ED0
	public virtual void OnPoolAllocated() {} // 0x0000000185529880-0x0000000185529920
	[BlackList] // 0x0000000189BC1DB0-0x0000000189BC1DF0
	// [XID] // 0x0000000189BC1DB0-0x0000000189BC1DF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001855297E0-0x0000000185529880
}

