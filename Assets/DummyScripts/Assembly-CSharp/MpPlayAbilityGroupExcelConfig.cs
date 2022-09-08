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
public class MpPlayAbilityGroupExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15879
{
	// Fields
	protected SimpleSafeUInt32 indexRawNum; // 0x10
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x14

	// Properties
	public uint index { /* [XID] */ /* 0x0000000189AFBD20-0x0000000189AFBD40 */ get => default; /* [XID] */ /* 0x0000000189B035B0-0x0000000189B035D0 */ protected set {} } // 0x00000001845713C0-0x0000000184571490 0x00000001845717F0-0x00000001845718D0
	public uint avatarId { /* [XID] */ /* 0x0000000189B0AD40-0x0000000189B0AD60 */ get => default; /* [XID] */ /* 0x0000000189B12540-0x0000000189B12560 */ protected set {} } // 0x00000001845712F0-0x00000001845713C0 0x0000000184570C00-0x0000000184570CE0

	// Constructors
	public MpPlayAbilityGroupExcelConfig() {} // 0x0000000184571AB0-0x0000000184571B10

	// Methods
	// [IDTag] // 0x0000000189B19810-0x0000000189B19850
	// [XID] // 0x0000000189B19810-0x0000000189B19850
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184570E60-0x00000001845710D0
	// [IDTag] // 0x0000000189B24160-0x0000000189B241A0
	// [XID] // 0x0000000189B24160-0x0000000189B241A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001845710D0-0x00000001845712F0
	// [XID] // 0x0000000189B2E310-0x0000000189B2E330
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2937 */, bool useObjectPool = false /* Metadata: 0x00AF293B */) => default; // 0x0000000184571490-0x00000001845717F0
	[BlackList] // 0x0000000189B35760-0x0000000189B357A0
	// [XID] // 0x0000000189B35760-0x0000000189B357A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184570CE0-0x0000000184570D80
	[BlackList] // 0x0000000189B40320-0x0000000189B40360
	// [XID] // 0x0000000189B40320-0x0000000189B40360
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184570D80-0x0000000184570E60
	[BlackList] // 0x0000000189B4AD10-0x0000000189B4AD50
	// [XID] // 0x0000000189B4AD10-0x0000000189B4AD50
	public virtual void ReturnToObjectPool() {} // 0x0000000184571A10-0x0000000184571AB0
	[BlackList] // 0x0000000189B55450-0x0000000189B55490
	// [XID] // 0x0000000189B55450-0x0000000189B55490
	public virtual void OnPoolAllocated() {} // 0x0000000184571970-0x0000000184571A10
	[BlackList] // 0x0000000189B5FFE0-0x0000000189B60020
	// [XID] // 0x0000000189B5FFE0-0x0000000189B60020
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845718D0-0x0000000184571970
}

