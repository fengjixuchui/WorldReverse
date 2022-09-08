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
public class RewardItemConfig : IAutoAllocRecycle // TypeDefIndex: 14912
{
	// Fields
	protected SimpleSafeUInt32 itemIdRawNum; // 0x10
	protected SimpleSafeUInt32 itemCountRawNum; // 0x14

	// Properties
	public uint itemId { /* [XID] */ /* 0x0000000189BD81D0-0x0000000189BD81F0 */ get => default; /* [XID] */ /* 0x0000000189BDFD00-0x0000000189BDFD20 */ protected set {} } // 0x00000001837BFB00-0x00000001837BFBD0 0x00000001837C0020-0x00000001837C0100
	public uint itemCount { /* [XID] */ /* 0x00000001895EC8D0-0x00000001895EC8F0 */ get => default; /* [XID] */ /* 0x00000001895F3EB0-0x00000001895F3ED0 */ protected set {} } // 0x00000001837C0460-0x00000001837C0530 0x00000001837BFF40-0x00000001837C0020

	// Constructors
	public RewardItemConfig(uint itemId, uint itemCount) {} // 0x00000001837C0770-0x00000001837C0810
	public RewardItemConfig() {} // 0x00000001837C0710-0x00000001837C0770

	// Methods
	// [XID] // 0x0000000189BD0C30-0x0000000189BD0C50
	public static int SortOrder(RewardItemConfig item1, RewardItemConfig item2) => default; // 0x00000001837BFDF0-0x00000001837BFF40
	// [XID] // 0x00000001895FB730-0x00000001895FB750
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001837BFBD0-0x00000001837BFDF0
	// [XID] // 0x0000000189602EF0-0x0000000189602F10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9B5 */, bool useObjectPool = false /* Metadata: 0x00AEF9B9 */) => default; // 0x00000001837C0100-0x00000001837C0460
	[BlackList] // 0x000000018960A850-0x000000018960A890
	// [XID] // 0x000000018960A850-0x000000018960A890
	public virtual void AutoAllocTypeFields() {} // 0x00000001837BF980-0x00000001837BFA20
	[BlackList] // 0x0000000189614FE0-0x0000000189615020
	// [XID] // 0x0000000189614FE0-0x0000000189615020
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837BFA20-0x00000001837BFB00
	[BlackList] // 0x000000018961F840-0x000000018961F880
	// [XID] // 0x000000018961F840-0x000000018961F880
	public virtual void ReturnToObjectPool() {} // 0x00000001837C0670-0x00000001837C0710
	[BlackList] // 0x0000000189629DB0-0x0000000189629DF0
	// [XID] // 0x0000000189629DB0-0x0000000189629DF0
	public virtual void OnPoolAllocated() {} // 0x00000001837C05D0-0x00000001837C0670
	[BlackList] // 0x00000001896347F0-0x0000000189634830
	// [XID] // 0x00000001896347F0-0x0000000189634830
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837C0530-0x00000001837C05D0
}

