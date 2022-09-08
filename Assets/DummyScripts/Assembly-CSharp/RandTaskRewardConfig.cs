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
public class RandTaskRewardConfig : IAutoAllocRecycle // TypeDefIndex: 16001
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected RandTaskDropConfig[] _dropVec; // 0x18

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189BAB260-0x0000000189BAB280 */ get => default; /* [XID] */ /* 0x0000000189BB28D0-0x0000000189BB28F0 */ protected set {} } // 0x0000000182447B30-0x0000000182447C00 0x0000000182447260-0x0000000182447340
	public RandTaskDropConfig[] dropVec { /* [XID] */ /* 0x0000000189BB9C80-0x0000000189BB9CA0 */ get => default; /* [XID] */ /* 0x0000000189BC1CB0-0x0000000189BC1CD0 */ protected set {} } // 0x00000001824471C0-0x0000000182447260 0x0000000182447F70-0x0000000182448020

	// Constructors
	public RandTaskRewardConfig() {} // 0x0000000182448200-0x0000000182448260

	// Methods
	// [IDTag] // 0x0000000189BC9260-0x0000000189BC92A0
	// [XID] // 0x0000000189BC9260-0x0000000189BC92A0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001824477B0-0x0000000182447B30
	// [IDTag] // 0x0000000189BD3A90-0x0000000189BD3AD0
	// [XID] // 0x0000000189BD3A90-0x0000000189BD3AD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001824474C0-0x00000001824477B0
	// [XID] // 0x0000000189BDE3E0-0x0000000189BDE400
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D68 */, bool useObjectPool = false /* Metadata: 0x00AF2D6C */) => default; // 0x0000000182447C00-0x0000000182447F70
	[BlackList] // 0x00000001895EAF10-0x00000001895EAF50
	// [XID] // 0x00000001895EAF10-0x00000001895EAF50
	public virtual void AutoAllocTypeFields() {} // 0x0000000182447340-0x00000001824473E0
	[BlackList] // 0x00000001895F55F0-0x00000001895F5630
	// [XID] // 0x00000001895F55F0-0x00000001895F5630
	public virtual void AutoRecycleTypeFields() {} // 0x00000001824473E0-0x00000001824474C0
	[BlackList] // 0x00000001895FFB70-0x00000001895FFBB0
	// [XID] // 0x00000001895FFB70-0x00000001895FFBB0
	public virtual void ReturnToObjectPool() {} // 0x0000000182448160-0x0000000182448200
	[BlackList] // 0x000000018960A650-0x000000018960A690
	// [XID] // 0x000000018960A650-0x000000018960A690
	public virtual void OnPoolAllocated() {} // 0x00000001824480C0-0x0000000182448160
	[BlackList] // 0x0000000189614D00-0x0000000189614D40
	// [XID] // 0x0000000189614D00-0x0000000189614D40
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182448020-0x00000001824480C0
}

