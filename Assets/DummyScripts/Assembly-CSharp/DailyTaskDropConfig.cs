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
public class DailyTaskDropConfig : IAutoAllocRecycle // TypeDefIndex: 15482
{
	// Fields
	protected SimpleSafeUInt32 drop_idRawNum; // 0x10
	protected SimpleSafeUInt32 preview_reward_idRawNum; // 0x14

	// Properties
	public uint drop_id { /* [XID] */ /* 0x0000000189AEEC20-0x0000000189AEEC40 */ get => default; /* [XID] */ /* 0x0000000189AF6170-0x0000000189AF6190 */ protected set {} } // 0x00000001846E2B20-0x00000001846E2BF0 0x00000001846E3320-0x00000001846E3400
	public uint preview_reward_id { /* [XID] */ /* 0x0000000189AFD7B0-0x0000000189AFD7D0 */ get => default; /* [XID] */ /* 0x0000000189B04E40-0x0000000189B04E60 */ protected set {} } // 0x00000001846E3250-0x00000001846E3320 0x00000001846E2E10-0x00000001846E2EF0

	// Constructors
	public DailyTaskDropConfig() {} // 0x00000001846E35E0-0x00000001846E3640

	// Methods
	// [XID] // 0x0000000189B0C670-0x0000000189B0C690
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001846E2BF0-0x00000001846E2E10
	// [XID] // 0x0000000189B13B30-0x0000000189B13B50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1BF5 */, bool useObjectPool = false /* Metadata: 0x00AF1BF9 */) => default; // 0x00000001846E2EF0-0x00000001846E3250
	[BlackList] // 0x0000000189B1B240-0x0000000189B1B280
	// [XID] // 0x0000000189B1B240-0x0000000189B1B280
	public virtual void AutoAllocTypeFields() {} // 0x00000001846E29A0-0x00000001846E2A40
	[BlackList] // 0x0000000189B25900-0x0000000189B25940
	// [XID] // 0x0000000189B25900-0x0000000189B25940
	public virtual void AutoRecycleTypeFields() {} // 0x00000001846E2A40-0x00000001846E2B20
	[BlackList] // 0x0000000189B2FA70-0x0000000189B2FAB0
	// [XID] // 0x0000000189B2FA70-0x0000000189B2FAB0
	public virtual void ReturnToObjectPool() {} // 0x00000001846E3540-0x00000001846E35E0
	[BlackList] // 0x0000000189B3A430-0x0000000189B3A470
	// [XID] // 0x0000000189B3A430-0x0000000189B3A470
	public virtual void OnPoolAllocated() {} // 0x00000001846E34A0-0x00000001846E3540
	[BlackList] // 0x0000000189B44E50-0x0000000189B44E90
	// [XID] // 0x0000000189B44E50-0x0000000189B44E90
	public virtual void OnBeforePoolRecycled() {} // 0x00000001846E3400-0x00000001846E34A0
}

