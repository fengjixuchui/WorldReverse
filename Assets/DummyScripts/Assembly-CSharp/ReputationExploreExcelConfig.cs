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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ReputationExploreExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16047
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 exploreIdRawNum; // 0x10
	protected SimpleSafeUInt32 cityIdRawNum; // 0x14
	protected SimpleSafeUInt32 exploreProgressRawNum; // 0x18
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x1C
	protected uint _conditionTextTextMapHash; // 0x20

	// Properties
	public uint exploreId { /* [XID] */ /* 0x0000000189B71BF0-0x0000000189B71C10 */ get => default; /* [XID] */ /* 0x0000000189B78F40-0x0000000189B78F60 */ protected set {} } // 0x0000000182AE5F00-0x0000000182AE5FD0 0x0000000182AE6850-0x0000000182AE6930
	public uint cityId { /* [XID] */ /* 0x0000000189B804D0-0x0000000189B804F0 */ get => default; /* [XID] */ /* 0x0000000189B87FE0-0x0000000189B88000 */ protected set {} } // 0x0000000182AE6B90-0x0000000182AE6C60 0x0000000182AE5FD0-0x0000000182AE60B0
	public uint exploreProgress { /* [XID] */ /* 0x0000000189B8F1F0-0x0000000189B8F210 */ get => default; /* [XID] */ /* 0x0000000189B966C0-0x0000000189B966E0 */ protected set {} } // 0x0000000182AE6160-0x0000000182AE6230 0x0000000182AE6930-0x0000000182AE6A10
	public uint rewardId { /* [XID] */ /* 0x0000000189B9DBA0-0x0000000189B9DBC0 */ get => default; /* [XID] */ /* 0x0000000189BA5590-0x0000000189BA55B0 */ protected set {} } // 0x0000000182AE6780-0x0000000182AE6850 0x0000000182AE5460-0x0000000182AE5540
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint conditionTextTextMapHash { /* [XID] */ /* 0x0000000189BAC770-0x0000000189BAC790 */ get => default; /* [XID] */ /* 0x0000000189BB4010-0x0000000189BB4030 */ protected set {} } // 0x0000000182AE5540-0x0000000182AE55E0 0x0000000182AE60B0-0x0000000182AE6160
	public string conditionText { /* [XID] */ /* 0x0000000189BBB6B0-0x0000000189BBB6D0 */ get => default; } // 0x0000000182AE6A10-0x0000000182AE6B90 

	// Constructors
	public ReputationExploreExcelConfig() {} // 0x0000000182AE6E40-0x0000000182AE6EA0

	// Methods
	// [IDTag] // 0x0000000189BC3510-0x0000000189BC3550
	// [XID] // 0x0000000189BC3510-0x0000000189BC3550
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182AE5790-0x0000000182AE5B60
	// [IDTag] // 0x0000000189BCDD20-0x0000000189BCDD60
	// [XID] // 0x0000000189BCDD20-0x0000000189BCDD60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182AE5B60-0x0000000182AE5F00
	// [XID] // 0x0000000189BD8070-0x0000000189BD8090
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2ED8 */, bool useObjectPool = false /* Metadata: 0x00AF2EDC */) => default; // 0x0000000182AE6230-0x0000000182AE6780
	[BlackList] // 0x0000000189BDFB80-0x0000000189BDFBC0
	// [XID] // 0x0000000189BDFB80-0x0000000189BDFBC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AE55E0-0x0000000182AE5680
	[BlackList] // 0x00000001895EF5E0-0x00000001895EF620
	// [XID] // 0x00000001895EF5E0-0x00000001895EF620
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AE5680-0x0000000182AE5790
	[BlackList] // 0x00000001895F9D00-0x00000001895F9D40
	// [XID] // 0x00000001895F9D00-0x00000001895F9D40
	public virtual void ReturnToObjectPool() {} // 0x0000000182AE6DA0-0x0000000182AE6E40
	[BlackList] // 0x0000000189604530-0x0000000189604570
	// [XID] // 0x0000000189604530-0x0000000189604570
	public virtual void OnPoolAllocated() {} // 0x0000000182AE6D00-0x0000000182AE6DA0
	[BlackList] // 0x000000018960ED40-0x000000018960ED80
	// [XID] // 0x000000018960ED40-0x000000018960ED80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182AE6C60-0x0000000182AE6D00
}

