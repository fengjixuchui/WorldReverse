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
public class ExpeditionReward : IAutoAllocRecycle // TypeDefIndex: 15596
{
	// Fields
	protected SimpleSafeUInt32 htimeRawNum; // 0x10
	protected SimpleSafeUInt32 reward_drop_idRawNum; // 0x14
	protected SimpleSafeUInt32 rewardPreviewRawNum; // 0x18

	// Properties
	public uint htime { /* [XID] */ /* 0x0000000189A620B0-0x0000000189A620D0 */ get => default; /* [XID] */ /* 0x0000000189A69F90-0x0000000189A69FB0 */ protected set {} } // 0x00000001845703F0-0x00000001845704C0 0x00000001845704C0-0x00000001845705A0
	public uint reward_drop_id { /* [XID] */ /* 0x0000000189A71240-0x0000000189A71260 */ get => default; /* [XID] */ /* 0x0000000189A78E60-0x0000000189A78E80 */ protected set {} } // 0x0000000184570320-0x00000001845703F0 0x0000000184570240-0x0000000184570320
	public uint rewardPreview { /* [XID] */ /* 0x0000000189A80300-0x0000000189A80320 */ get => default; /* [XID] */ /* 0x0000000189A88080-0x0000000189A880A0 */ protected set {} } // 0x000000018456FC80-0x000000018456FD50 0x000000018456FD50-0x000000018456FE30

	// Constructors
	public ExpeditionReward() {} // 0x0000000184570780-0x00000001845707E0

	// Methods
	// [XID] // 0x0000000189A8F950-0x0000000189A8F970
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018456F9E0-0x000000018456FC80
	// [XID] // 0x0000000189A96F60-0x0000000189A96F80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF201A */, bool useObjectPool = false /* Metadata: 0x00AF201E */) => default; // 0x000000018456FE30-0x0000000184570240
	[BlackList] // 0x0000000189A9E2F0-0x0000000189A9E330
	// [XID] // 0x0000000189A9E2F0-0x0000000189A9E330
	public virtual void AutoAllocTypeFields() {} // 0x000000018456F850-0x000000018456F8F0
	[BlackList] // 0x0000000189AA8960-0x0000000189AA89A0
	// [XID] // 0x0000000189AA8960-0x0000000189AA89A0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018456F8F0-0x000000018456F9E0
	[BlackList] // 0x0000000189AB3560-0x0000000189AB35A0
	// [XID] // 0x0000000189AB3560-0x0000000189AB35A0
	public virtual void ReturnToObjectPool() {} // 0x00000001845706E0-0x0000000184570780
	[BlackList] // 0x0000000189ABE010-0x0000000189ABE050
	// [XID] // 0x0000000189ABE010-0x0000000189ABE050
	public virtual void OnPoolAllocated() {} // 0x0000000184570640-0x00000001845706E0
	[BlackList] // 0x0000000189AC8810-0x0000000189AC8850
	// [XID] // 0x0000000189AC8810-0x0000000189AC8850
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845705A0-0x0000000184570640
}

