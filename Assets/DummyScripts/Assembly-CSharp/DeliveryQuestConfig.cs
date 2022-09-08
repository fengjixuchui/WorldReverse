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
public class DeliveryQuestConfig : IAutoAllocRecycle // TypeDefIndex: 15056
{
	// Fields
	protected SimpleSafeUInt32 parentQuestIdRawNum; // 0x10
	protected SimpleSafeUInt32 deliveryQuestIdRawNum; // 0x14
	protected SimpleSafeUInt32 startQuestIdRawNum; // 0x18
	protected SimpleSafeUInt32 talkQuestIdRawNum; // 0x1C
	protected SimpleSafeUInt32[] _watcherId; // 0x20
	protected SimpleSafeUInt32 itemIdRawNum; // 0x28

	// Properties
	public uint parentQuestId { /* [XID] */ /* 0x00000001899D7C50-0x00000001899D7C70 */ get => default; /* [XID] */ /* 0x00000001899DF170-0x00000001899DF190 */ protected set {} } // 0x0000000183A26DE0-0x0000000183A26EB0 0x0000000183A25800-0x0000000183A258E0
	public uint deliveryQuestId { /* [XID] */ /* 0x00000001899E6DD0-0x00000001899E6DF0 */ get => default; /* [XID] */ /* 0x00000001899EE260-0x00000001899EE280 */ protected set {} } // 0x0000000183A264C0-0x0000000183A26590 0x0000000183A26710-0x0000000183A267F0
	public uint startQuestId { /* [XID] */ /* 0x00000001899F5A90-0x00000001899F5AB0 */ get => default; /* [XID] */ /* 0x00000001899FD1F0-0x00000001899FD210 */ protected set {} } // 0x0000000183A26EB0-0x0000000183A26F80 0x0000000183A26590-0x0000000183A26670
	public uint talkQuestId { /* [XID] */ /* 0x0000000189A047B0-0x0000000189A047D0 */ get => default; /* [XID] */ /* 0x0000000189A0BEF0-0x0000000189A0BF10 */ protected set {} } // 0x0000000183A26310-0x0000000183A263E0 0x0000000183A25C30-0x0000000183A25D10
	public SimpleSafeUInt32[] watcherId { /* [XID] */ /* 0x0000000189A13860-0x0000000189A13880 */ get => default; /* [XID] */ /* 0x0000000189A1A990-0x0000000189A1A9B0 */ protected set {} } // 0x0000000183A26670-0x0000000183A26710 0x0000000183A25AB0-0x0000000183A25B60
	public uint itemId { /* [XID] */ /* 0x0000000189A22270-0x0000000189A22290 */ get => default; /* [XID] */ /* 0x0000000189A29640-0x0000000189A29660 */ protected set {} } // 0x0000000183A25B60-0x0000000183A25C30 0x0000000183A263E0-0x0000000183A264C0

	// Constructors
	public DeliveryQuestConfig() {} // 0x0000000183A27160-0x0000000183A271C0

	// Methods
	// [XID] // 0x0000000189A30B50-0x0000000189A30B70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183A25D10-0x0000000183A26310
	// [XID] // 0x0000000189A385F0-0x0000000189A38610
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF96 */, bool useObjectPool = false /* Metadata: 0x00AEFF9A */) => default; // 0x0000000183A267F0-0x0000000183A26DE0
	[BlackList] // 0x0000000189A3FD40-0x0000000189A3FD80
	// [XID] // 0x0000000189A3FD40-0x0000000189A3FD80
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A258E0-0x0000000183A25980
	[BlackList] // 0x0000000189A4A240-0x0000000189A4A280
	// [XID] // 0x0000000189A4A240-0x0000000189A4A280
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A25980-0x0000000183A25AB0
	[BlackList] // 0x0000000189A54B50-0x0000000189A54B90
	// [XID] // 0x0000000189A54B50-0x0000000189A54B90
	public virtual void ReturnToObjectPool() {} // 0x0000000183A270C0-0x0000000183A27160
	[BlackList] // 0x0000000189A5F510-0x0000000189A5F550
	// [XID] // 0x0000000189A5F510-0x0000000189A5F550
	public virtual void OnPoolAllocated() {} // 0x0000000183A27020-0x0000000183A270C0
	[BlackList] // 0x0000000189A6A070-0x0000000189A6A0B0
	// [XID] // 0x0000000189A6A070-0x0000000189A6A0B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A26F80-0x0000000183A27020
}

