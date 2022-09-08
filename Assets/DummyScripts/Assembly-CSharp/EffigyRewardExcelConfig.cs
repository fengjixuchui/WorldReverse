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
public class EffigyRewardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15079
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 scoreGradeRawNum; // 0x14
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189727360-0x0000000189727380 */ get => default; /* [XID] */ /* 0x000000018972E910-0x000000018972E930 */ protected set {} } // 0x00000001817DC610-0x00000001817DC6E0 0x00000001817DBF00-0x00000001817DBFE0
	public uint scoreGrade { /* [XID] */ /* 0x0000000189736080-0x00000001897360A0 */ get => default; /* [XID] */ /* 0x000000018973DD50-0x000000018973DD70 */ protected set {} } // 0x00000001817DBE30-0x00000001817DBF00 0x00000001817DC3F0-0x00000001817DC4D0
	public uint rewardID { /* [XID] */ /* 0x0000000189745190-0x00000001897451B0 */ get => default; /* [XID] */ /* 0x000000018974CC40-0x000000018974CC60 */ protected set {} } // 0x00000001817DBD60-0x00000001817DBE30 0x00000001817DBC80-0x00000001817DBD60

	// Constructors
	public EffigyRewardExcelConfig() {} // 0x00000001817DC780-0x00000001817DC7E0

	// Methods
	// [IDTag] // 0x0000000189754000-0x0000000189754040
	// [XID] // 0x0000000189754000-0x0000000189754040
	public virtual bool ParseFromLine(string line) => default; // 0x00000001817DB9A0-0x00000001817DBC80
	// [IDTag] // 0x000000018975E690-0x000000018975E6D0
	// [XID] // 0x000000018975E690-0x000000018975E6D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001817DB700-0x00000001817DB9A0
	// [XID] // 0x0000000189768CA0-0x0000000189768CC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF003A */, bool useObjectPool = false /* Metadata: 0x00AF003E */) => default; // 0x00000001817DBFE0-0x00000001817DC3F0
	[BlackList] // 0x0000000189770370-0x00000001897703B0
	// [XID] // 0x0000000189770370-0x00000001897703B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001817DB570-0x00000001817DB610
	[BlackList] // 0x000000018977A9A0-0x000000018977A9E0
	// [XID] // 0x000000018977A9A0-0x000000018977A9E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817DB610-0x00000001817DB700
	[BlackList] // 0x00000001897853E0-0x0000000189785420
	// [XID] // 0x00000001897853E0-0x0000000189785420
	public virtual void ReturnToObjectPool() {} // 0x00000001817DC6E0-0x00000001817DC780
	[BlackList] // 0x000000018978F840-0x000000018978F880
	// [XID] // 0x000000018978F840-0x000000018978F880
	public virtual void OnPoolAllocated() {} // 0x00000001817DC570-0x00000001817DC610
	[BlackList] // 0x0000000189799EF0-0x0000000189799F30
	// [XID] // 0x0000000189799EF0-0x0000000189799F30
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817DC4D0-0x00000001817DC570
}

