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
public class HuntingRefreshCond : IAutoAllocRecycle // TypeDefIndex: 15754
{
	// Fields
	protected HuntingRefreshCondType _condType; // 0x10
	protected SimpleSafeUInt32[] _param; // 0x18

	// Properties
	public HuntingRefreshCondType condType { /* [XID] */ /* 0x000000018973F540-0x000000018973F560 */ get => default; /* [XID] */ /* 0x00000001897468E0-0x0000000189746900 */ protected set {} } // 0x000000018416EEE0-0x000000018416EF80 0x000000018416E580-0x000000018416E630
	public SimpleSafeUInt32[] param { /* [XID] */ /* 0x000000018974E250-0x000000018974E270 */ get => default; /* [XID] */ /* 0x00000001897558D0-0x00000001897558F0 */ protected set {} } // 0x000000018416F170-0x000000018416F210 0x000000018416F0C0-0x000000018416F170

	// Constructors
	public HuntingRefreshCond() {} // 0x000000018416F2B0-0x000000018416F310

	// Methods
	// [XID] // 0x000000018975CBF0-0x000000018975CC10
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018416E770-0x000000018416EB70
	// [XID] // 0x00000001897643C0-0x00000001897643E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2521 */, bool useObjectPool = false /* Metadata: 0x00AF2525 */) => default; // 0x000000018416EB70-0x000000018416EEE0
	[BlackList] // 0x000000018976BD20-0x000000018976BD60
	// [XID] // 0x000000018976BD20-0x000000018976BD60
	public virtual void AutoAllocTypeFields() {} // 0x000000018416E630-0x000000018416E6D0
	[BlackList] // 0x0000000189776460-0x00000001897764A0
	// [XID] // 0x0000000189776460-0x00000001897764A0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018416E6D0-0x000000018416E770
	[BlackList] // 0x0000000189780B20-0x0000000189780B60
	// [XID] // 0x0000000189780B20-0x0000000189780B60
	public virtual void ReturnToObjectPool() {} // 0x000000018416F210-0x000000018416F2B0
	[BlackList] // 0x000000018978B3A0-0x000000018978B3E0
	// [XID] // 0x000000018978B3A0-0x000000018978B3E0
	public virtual void OnPoolAllocated() {} // 0x000000018416F020-0x000000018416F0C0
	[BlackList] // 0x00000001897957A0-0x00000001897957E0
	// [XID] // 0x00000001897957A0-0x00000001897957E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018416EF80-0x000000018416F020
}

