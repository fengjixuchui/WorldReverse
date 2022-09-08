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
public class ReminderIndexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16032
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _reminderID; // 0x18
	protected ReminderShowType _showType; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AC4220-0x0000000189AC4240 */ get => default; /* [XID] */ /* 0x0000000189ACB730-0x0000000189ACB750 */ protected set {} } // 0x00000001822C3050-0x00000001822C3120 0x00000001822C2A20-0x00000001822C2B00
	public SimpleSafeUInt32[] reminderID { /* [XID] */ /* 0x0000000189AD3180-0x0000000189AD31A0 */ get => default; /* [XID] */ /* 0x0000000189ADABA0-0x0000000189ADABC0 */ protected set {} } // 0x00000001822C1EB0-0x00000001822C1F50 0x00000001822C1F50-0x00000001822C2000
	public ReminderShowType showType { /* [XID] */ /* 0x0000000189AE2400-0x0000000189AE2420 */ get => default; /* [XID] */ /* 0x0000000189AE9CD0-0x0000000189AE9CF0 */ protected set {} } // 0x00000001822C2980-0x00000001822C2A20 0x00000001822C1E00-0x00000001822C1EB0

	// Constructors
	public ReminderIndexExcelConfig() {} // 0x00000001822C31C0-0x00000001822C3220

	// Methods
	// [IDTag] // 0x0000000189AF1A50-0x0000000189AF1A90
	// [XID] // 0x0000000189AF1A50-0x0000000189AF1A90
	public virtual bool ParseFromLine(string line) => default; // 0x00000001822C24A0-0x00000001822C2980
	// [IDTag] // 0x0000000189AFBCA0-0x0000000189AFBCE0
	// [XID] // 0x0000000189AFBCA0-0x0000000189AFBCE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001822C2000-0x00000001822C24A0
	// [XID] // 0x0000000189B066E0-0x0000000189B06700
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E64 */, bool useObjectPool = false /* Metadata: 0x00AF2E68 */) => default; // 0x00000001822C2B00-0x00000001822C2F10
	[BlackList] // 0x0000000189B0DD90-0x0000000189B0DDD0
	// [XID] // 0x0000000189B0DD90-0x0000000189B0DDD0
	public virtual void AutoAllocTypeFields() {} // 0x00000001822C1C80-0x00000001822C1D20
	[BlackList] // 0x0000000189B18200-0x0000000189B18240
	// [XID] // 0x0000000189B18200-0x0000000189B18240
	public virtual void AutoRecycleTypeFields() {} // 0x00000001822C1D20-0x00000001822C1E00
	[BlackList] // 0x0000000189B228F0-0x0000000189B22930
	// [XID] // 0x0000000189B228F0-0x0000000189B22930
	public virtual void ReturnToObjectPool() {} // 0x00000001822C3120-0x00000001822C31C0
	[BlackList] // 0x0000000189B2CCB0-0x0000000189B2CCF0
	// [XID] // 0x0000000189B2CCB0-0x0000000189B2CCF0
	public virtual void OnPoolAllocated() {} // 0x00000001822C2FB0-0x00000001822C3050
	[BlackList] // 0x0000000189B372D0-0x0000000189B37310
	// [XID] // 0x0000000189B372D0-0x0000000189B37310
	public virtual void OnBeforePoolRecycled() {} // 0x00000001822C2F10-0x00000001822C2FB0
}

