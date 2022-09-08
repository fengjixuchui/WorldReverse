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
public class NewActivityTimeGroupExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15903
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _groupIdList; // 0x18
	protected SimpleSafeUInt32[] _duration; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189972E30-0x0000000189972E50 */ get => default; /* [XID] */ /* 0x000000018997A710-0x000000018997A730 */ protected set {} } // 0x00000001820F6690-0x00000001820F6760 0x00000001820F5F10-0x00000001820F5FF0
	public SimpleSafeUInt32[] groupIdList { /* [XID] */ /* 0x00000001899820A0-0x00000001899820C0 */ get => default; /* [XID] */ /* 0x0000000189989920-0x0000000189989940 */ protected set {} } // 0x00000001820F64B0-0x00000001820F6550 0x00000001820F5FF0-0x00000001820F60A0
	public SimpleSafeUInt32[] duration { /* [XID] */ /* 0x0000000189991190-0x00000001899911B0 */ get => default; /* [XID] */ /* 0x0000000189998BF0-0x0000000189998C10 */ protected set {} } // 0x00000001820F50E0-0x00000001820F5180 0x00000001820F5E60-0x00000001820F5F10

	// Constructors
	public NewActivityTimeGroupExcelConfig() {} // 0x00000001820F6800-0x00000001820F6860

	// Methods
	// [IDTag] // 0x00000001899A04D0-0x00000001899A0510
	// [XID] // 0x00000001899A04D0-0x00000001899A0510
	public virtual bool ParseFromLine(string line) => default; // 0x00000001820F57D0-0x00000001820F5E60
	// [IDTag] // 0x00000001899AAF40-0x00000001899AAF80
	// [XID] // 0x00000001899AAF40-0x00000001899AAF80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001820F5180-0x00000001820F57D0
	// [XID] // 0x00000001899B5680-0x00000001899B56A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AB9 */, bool useObjectPool = false /* Metadata: 0x00AF2ABD */) => default; // 0x00000001820F60A0-0x00000001820F64B0
	[BlackList] // 0x00000001899BCDB0-0x00000001899BCDF0
	// [XID] // 0x00000001899BCDB0-0x00000001899BCDF0
	public virtual void AutoAllocTypeFields() {} // 0x00000001820F4F60-0x00000001820F5000
	[BlackList] // 0x00000001899C7650-0x00000001899C7690
	// [XID] // 0x00000001899C7650-0x00000001899C7690
	public virtual void AutoRecycleTypeFields() {} // 0x00000001820F5000-0x00000001820F50E0
	[BlackList] // 0x00000001899D1D00-0x00000001899D1D40
	// [XID] // 0x00000001899D1D00-0x00000001899D1D40
	public virtual void ReturnToObjectPool() {} // 0x00000001820F6760-0x00000001820F6800
	[BlackList] // 0x00000001899DC1B0-0x00000001899DC1F0
	// [XID] // 0x00000001899DC1B0-0x00000001899DC1F0
	public virtual void OnPoolAllocated() {} // 0x00000001820F65F0-0x00000001820F6690
	[BlackList] // 0x00000001899E6C30-0x00000001899E6C70
	// [XID] // 0x00000001899E6C30-0x00000001899E6C70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001820F6550-0x00000001820F65F0
}

