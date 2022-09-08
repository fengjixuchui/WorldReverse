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
public class MiracleRingDropExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15835
{
	// Fields
	protected MiracleTag _miracleTag; // 0x10
	protected SimpleSafeUInt32[] _dropId; // 0x18

	// Properties
	public MiracleTag miracleTag { /* [XID] */ /* 0x0000000189BA3D70-0x0000000189BA3D90 */ get => default; /* [XID] */ /* 0x0000000189BAB320-0x0000000189BAB340 */ protected set {} } // 0x0000000183B1B180-0x0000000183B1B220 0x0000000183B1BF10-0x0000000183B1BFC0
	public SimpleSafeUInt32[] dropId { /* [XID] */ /* 0x0000000189BB2910-0x0000000189BB2930 */ get => default; /* [XID] */ /* 0x0000000189BB9D40-0x0000000189BB9D60 */ protected set {} } // 0x0000000183B1B910-0x0000000183B1B9B0 0x0000000183B1BD20-0x0000000183B1BDD0

	// Constructors
	public MiracleRingDropExcelConfig() {} // 0x0000000183B1C060-0x0000000183B1C0C0

	// Methods
	// [IDTag] // 0x0000000189BC1CF0-0x0000000189BC1D30
	// [XID] // 0x0000000189BC1CF0-0x0000000189BC1D30
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183B1B220-0x0000000183B1B5C0
	// [IDTag] // 0x0000000189BCC480-0x0000000189BCC4C0
	// [XID] // 0x0000000189BCC480-0x0000000189BCC4C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183B1B5C0-0x0000000183B1B910
	// [XID] // 0x0000000189BD6780-0x0000000189BD67A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF27E5 */, bool useObjectPool = false /* Metadata: 0x00AF27E9 */) => default; // 0x0000000183B1B9B0-0x0000000183B1BD20
	[BlackList] // 0x0000000189BDE480-0x0000000189BDE4C0
	// [XID] // 0x0000000189BDE480-0x0000000189BDE4C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B1B040-0x0000000183B1B0E0
	[BlackList] // 0x00000001895EDDF0-0x00000001895EDE30
	// [XID] // 0x00000001895EDDF0-0x00000001895EDE30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B1B0E0-0x0000000183B1B180
	[BlackList] // 0x00000001895F8730-0x00000001895F8770
	// [XID] // 0x00000001895F8730-0x00000001895F8770
	public virtual void ReturnToObjectPool() {} // 0x0000000183B1BFC0-0x0000000183B1C060
	[BlackList] // 0x0000000189602D30-0x0000000189602D70
	// [XID] // 0x0000000189602D30-0x0000000189602D70
	public virtual void OnPoolAllocated() {} // 0x0000000183B1BE70-0x0000000183B1BF10
	[BlackList] // 0x000000018960D600-0x000000018960D640
	// [XID] // 0x000000018960D600-0x000000018960D640
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B1BDD0-0x0000000183B1BE70
}

