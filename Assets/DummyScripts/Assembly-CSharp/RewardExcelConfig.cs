/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class RewardExcelConfig : OutputControlConfig, IAutoAllocRecycle // TypeDefIndex: 14909
{
	// Fields
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x28
	protected SimpleSafeUInt32 hcoinRawNum; // 0x2C
	protected SimpleSafeUInt32 scoinRawNum; // 0x30
	protected SimpleSafeUInt32 playerExpRawNum; // 0x34
	protected SimpleSafeUInt32 avatarExpRawNum; // 0x38
	protected SimpleSafeUInt32 fetterExpRawNum; // 0x3C
	protected SimpleSafeUInt32 resinRawNum; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected RewardItemConfig[] _rewardItemList; // 0x48

	// Properties
	public uint rewardId { /* [XID] */ /* 0x00000001899F1270-0x00000001899F1290 */ get => default; /* [XID] */ /* 0x00000001899F8B10-0x00000001899F8B30 */ protected set {} } // 0x0000000182BFB380-0x0000000182BFB450 0x0000000182BF94A0-0x0000000182BF9580
	public uint hcoin { /* [XID] */ /* 0x0000000189A00060-0x0000000189A00080 */ get => default; /* [XID] */ /* 0x0000000189A07850-0x0000000189A07870 */ protected set {} } // 0x0000000182BFB4B0-0x0000000182BFB580 0x0000000182BFB740-0x0000000182BFB820
	public uint scoin { /* [XID] */ /* 0x0000000189A0EDF0-0x0000000189A0EE10 */ get => default; /* [XID] */ /* 0x0000000189A16500-0x0000000189A16520 */ protected set {} } // 0x0000000182BFA770-0x0000000182BFA840 0x0000000182BFB580-0x0000000182BFB660
	public uint playerExp { /* [XID] */ /* 0x0000000189A1DAA0-0x0000000189A1DAC0 */ get => default; /* [XID] */ /* 0x0000000189A24FB0-0x0000000189A24FD0 */ protected set {} } // 0x0000000182BFAAA0-0x0000000182BFAB70 0x0000000182BFA5B0-0x0000000182BFA690
	public uint avatarExp { /* [XID] */ /* 0x0000000189A2C550-0x0000000189A2C570 */ get => default; /* [XID] */ /* 0x0000000189A33C40-0x0000000189A33C60 */ protected set {} } // 0x0000000182BFB820-0x0000000182BFB8F0 0x0000000182BFBC50-0x0000000182BFBD30
	public uint fetterExp { /* [XID] */ /* 0x0000000189A3B3A0-0x0000000189A3B3C0 */ get => default; /* [XID] */ /* 0x0000000189A42E70-0x0000000189A42E90 */ protected set {} } // 0x0000000182BFA840-0x0000000182BFA910 0x0000000182BFA690-0x0000000182BFA770
	public uint resin { /* [XID] */ /* 0x0000000189A4A300-0x0000000189A4A320 */ get => default; /* [XID] */ /* 0x0000000189A51CB0-0x0000000189A51CD0 */ protected set {} } // 0x0000000182BFAB70-0x0000000182BFAC40 0x0000000182BFB660-0x0000000182BFB740
	public RewardItemConfig[] rewardItemList { /* [XID] */ /* 0x0000000189A59420-0x0000000189A59440 */ get => default; /* [XID] */ /* 0x0000000189A60DE0-0x0000000189A60E00 */ protected set {} } // 0x0000000182BFA910-0x0000000182BFA9B0 0x0000000182BF9820-0x0000000182BF98D0

	// Constructors
	public RewardExcelConfig() {} // 0x0000000182BFBDD0-0x0000000182BFBE30

	// Methods
	// [XID] // 0x00000001899E9A60-0x00000001899E9A80
	public void ToItems(List<BagItem> itemParams) {} // 0x0000000182BFB8F0-0x0000000182BFBC50
	// [IDTag] // 0x0000000189A68A10-0x0000000189A68A50
	// [XID] // 0x0000000189A68A10-0x0000000189A68A50
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182BF9F10-0x0000000182BFA5B0
	// [IDTag] // 0x0000000189A72F00-0x0000000189A72F40
	// [XID] // 0x0000000189A72F00-0x0000000189A72F40
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182BF9930-0x0000000182BF9F10
	// [XID] // 0x0000000189A7D8B0-0x0000000189A7D8D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9A1 */, bool useObjectPool = false /* Metadata: 0x00AEF9A5 */) => default; // 0x0000000182BFAC40-0x0000000182BFB380
	[BlackList] // 0x0000000189A85100-0x0000000189A85140
	// [XID] // 0x0000000189A85100-0x0000000189A85140
	public override void AutoAllocTypeFields() {} // 0x0000000182BF9580-0x0000000182BF9620
	[BlackList] // 0x0000000189A8FA90-0x0000000189A8FAD0
	// [XID] // 0x0000000189A8FA90-0x0000000189A8FAD0
	public override void AutoRecycleTypeFields() {} // 0x0000000182BF9620-0x0000000182BF9780
	[BlackList] // 0x0000000189A9A2A0-0x0000000189A9A2E0
	// [XID] // 0x0000000189A9A2A0-0x0000000189A9A2E0
	public override void ReturnToObjectPool() {} // 0x0000000182BFBD30-0x0000000182BFBDD0
}

