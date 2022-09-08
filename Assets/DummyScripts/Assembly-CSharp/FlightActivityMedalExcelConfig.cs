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
public class FlightActivityMedalExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15115
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _medal_icon; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected FlightDailyInfo[] _daily_info; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899A6770-0x00000001899A6790 */ get => default; /* [XID] */ /* 0x00000001899ADF40-0x00000001899ADF60 */ protected set {} } // 0x000000018551A900-0x000000018551A9D0 0x000000018551A180-0x000000018551A260
	public string medal_icon { /* [XID] */ /* 0x00000001899B5780-0x00000001899B57A0 */ get => default; /* [XID] */ /* 0x00000001899BCF50-0x00000001899BCF70 */ protected set {} } // 0x000000018551A720-0x000000018551A7C0 0x0000000185519960-0x0000000185519A10
	public FlightDailyInfo[] daily_info { /* [XID] */ /* 0x00000001899C4920-0x00000001899C4940 */ get => default; /* [XID] */ /* 0x00000001899CC080-0x00000001899CC0A0 */ protected set {} } // 0x000000018551A9D0-0x000000018551AA70 0x000000018551A670-0x000000018551A720

	// Constructors
	public FlightActivityMedalExcelConfig() {} // 0x000000018551AB10-0x000000018551AB70

	// Methods
	// [IDTag] // 0x00000001899D3630-0x00000001899D3670
	// [XID] // 0x00000001899D3630-0x00000001899D3670
	public virtual bool ParseFromLine(string line) => default; // 0x0000000185519A10-0x0000000185519E10
	// [IDTag] // 0x00000001899DDA40-0x00000001899DDA80
	// [XID] // 0x00000001899DDA40-0x00000001899DDA80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000185519E10-0x000000018551A180
	// [XID] // 0x00000001899E8600-0x00000001899E8620
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0139 */, bool useObjectPool = false /* Metadata: 0x00AF013D */) => default; // 0x000000018551A260-0x000000018551A670
	[BlackList] // 0x00000001899EFC50-0x00000001899EFC90
	// [XID] // 0x00000001899EFC50-0x00000001899EFC90
	public virtual void AutoAllocTypeFields() {} // 0x00000001855197E0-0x0000000185519880
	[BlackList] // 0x00000001899FA270-0x00000001899FA2B0
	// [XID] // 0x00000001899FA270-0x00000001899FA2B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185519880-0x0000000185519960
	[BlackList] // 0x0000000189A04750-0x0000000189A04790
	// [XID] // 0x0000000189A04750-0x0000000189A04790
	public virtual void ReturnToObjectPool() {} // 0x000000018551AA70-0x000000018551AB10
	[BlackList] // 0x0000000189A0ED50-0x0000000189A0ED90
	// [XID] // 0x0000000189A0ED50-0x0000000189A0ED90
	public virtual void OnPoolAllocated() {} // 0x000000018551A860-0x000000018551A900
	[BlackList] // 0x0000000189A192B0-0x0000000189A192F0
	// [XID] // 0x0000000189A192B0-0x0000000189A192F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018551A7C0-0x000000018551A860
}

