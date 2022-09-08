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
public class NewActivityScoreLimitExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15899
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIDRawNum; // 0x14
	protected SimpleSafeUInt32 limitValueRawNum; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189725920-0x0000000189725940 */ get => default; /* [XID] */ /* 0x000000018972CE60-0x000000018972CE80 */ protected set {} } // 0x0000000181CA1870-0x0000000181CA1940 0x0000000181CA1240-0x0000000181CA1320
	public uint activityID { /* [XID] */ /* 0x00000001897345F0-0x0000000189734610 */ get => default; /* [XID] */ /* 0x000000018973BFC0-0x000000018973BFE0 */ protected set {} } // 0x0000000181CA0FC0-0x0000000181CA1090 0x0000000181CA0960-0x0000000181CA0A40
	public uint limitValue { /* [XID] */ /* 0x0000000189743790-0x00000001897437B0 */ get => default; /* [XID] */ /* 0x000000018974B3E0-0x000000018974B400 */ protected set {} } // 0x0000000181CA1170-0x0000000181CA1240 0x0000000181CA1090-0x0000000181CA1170

	// Constructors
	public NewActivityScoreLimitExcelConfig() {} // 0x0000000181CA19E0-0x0000000181CA1A40

	// Methods
	// [IDTag] // 0x0000000189752570-0x00000001897525B0
	// [XID] // 0x0000000189752570-0x00000001897525B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181CA0CE0-0x0000000181CA0FC0
	// [IDTag] // 0x000000018975CB90-0x000000018975CBD0
	// [XID] // 0x000000018975CB90-0x000000018975CBD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181CA0A40-0x0000000181CA0CE0
	// [XID] // 0x0000000189767460-0x0000000189767480
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A9B */, bool useObjectPool = false /* Metadata: 0x00AF2A9F */) => default; // 0x0000000181CA1320-0x0000000181CA1730
	[BlackList] // 0x000000018976EA00-0x000000018976EA40
	// [XID] // 0x000000018976EA00-0x000000018976EA40
	public virtual void AutoAllocTypeFields() {} // 0x0000000181CA07D0-0x0000000181CA0870
	[BlackList] // 0x0000000189779300-0x0000000189779340
	// [XID] // 0x0000000189779300-0x0000000189779340
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181CA0870-0x0000000181CA0960
	[BlackList] // 0x0000000189783BB0-0x0000000189783BF0
	// [XID] // 0x0000000189783BB0-0x0000000189783BF0
	public virtual void ReturnToObjectPool() {} // 0x0000000181CA1940-0x0000000181CA19E0
	[BlackList] // 0x000000018978DFF0-0x000000018978E030
	// [XID] // 0x000000018978DFF0-0x000000018978E030
	public virtual void OnPoolAllocated() {} // 0x0000000181CA17D0-0x0000000181CA1870
	[BlackList] // 0x00000001897986C0-0x0000000189798700
	// [XID] // 0x00000001897986C0-0x0000000189798700
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181CA1730-0x0000000181CA17D0
}

