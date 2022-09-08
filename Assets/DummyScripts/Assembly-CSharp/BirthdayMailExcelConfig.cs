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
public class BirthdayMailExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15797
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 mailIdRawNum; // 0x14
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x18
	protected string _effectiveDate; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BB56F0-0x0000000189BB5710 */ get => default; /* [XID] */ /* 0x0000000189BBCDE0-0x0000000189BBCE00 */ protected set {} } // 0x00000001846B92E0-0x00000001846B93B0 0x00000001846B8B40-0x00000001846B8C20
	public uint mailId { /* [XID] */ /* 0x0000000189BC4A40-0x0000000189BC4A60 */ get => default; /* [XID] */ /* 0x0000000189BCC500-0x0000000189BCC520 */ protected set {} } // 0x00000001846B8A70-0x00000001846B8B40 0x00000001846B9450-0x00000001846B9530
	public uint rewardId { /* [XID] */ /* 0x0000000189BD3B90-0x0000000189BD3BB0 */ get => default; /* [XID] */ /* 0x0000000189BDB480-0x0000000189BDB4A0 */ protected set {} } // 0x00000001846B90D0-0x00000001846B91A0 0x00000001846B80E0-0x00000001846B81C0
	public string effectiveDate { /* [XID] */ /* 0x00000001895E7D90-0x00000001895E7DB0 */ get => default; /* [XID] */ /* 0x00000001895EF6E0-0x00000001895EF700 */ protected set {} } // 0x00000001846B93B0-0x00000001846B9450 0x00000001846B89C0-0x00000001846B8A70

	// Constructors
	public BirthdayMailExcelConfig() {} // 0x00000001846B95D0-0x00000001846B9630

	// Methods
	// [IDTag] // 0x00000001895F7060-0x00000001895F70A0
	// [XID] // 0x00000001895F7060-0x00000001895F70A0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001846B8670-0x00000001846B89C0
	// [IDTag] // 0x0000000189601620-0x0000000189601660
	// [XID] // 0x0000000189601620-0x0000000189601660
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001846B8360-0x00000001846B8670
	// [XID] // 0x000000018960BEC0-0x000000018960BEE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF264D */, bool useObjectPool = false /* Metadata: 0x00AF2651 */) => default; // 0x00000001846B8C20-0x00000001846B90D0
	[BlackList] // 0x00000001896133E0-0x0000000189613420
	// [XID] // 0x00000001896133E0-0x0000000189613420
	public virtual void AutoAllocTypeFields() {} // 0x00000001846B81C0-0x00000001846B8260
	[BlackList] // 0x000000018961DC30-0x000000018961DC70
	// [XID] // 0x000000018961DC30-0x000000018961DC70
	public virtual void AutoRecycleTypeFields() {} // 0x00000001846B8260-0x00000001846B8360
	[BlackList] // 0x0000000189628250-0x0000000189628290
	// [XID] // 0x0000000189628250-0x0000000189628290
	public virtual void ReturnToObjectPool() {} // 0x00000001846B9530-0x00000001846B95D0
	[BlackList] // 0x0000000189632AA0-0x0000000189632AE0
	// [XID] // 0x0000000189632AA0-0x0000000189632AE0
	public virtual void OnPoolAllocated() {} // 0x00000001846B9240-0x00000001846B92E0
	[BlackList] // 0x000000018963D610-0x000000018963D650
	// [XID] // 0x000000018963D610-0x000000018963D650
	public virtual void OnBeforePoolRecycled() {} // 0x00000001846B91A0-0x00000001846B9240
}

