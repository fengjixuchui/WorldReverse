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
public class MpCrucibleRewardConfig : IAutoAllocRecycle // TypeDefIndex: 15862
{
	// Fields
	protected SimpleSafeUInt32 dropIDRawNum; // 0x10
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x14
	protected SimpleSafeUInt32 rewardPreviewRawNum; // 0x18

	// Properties
	public uint dropID { /* [XID] */ /* 0x00000001899F71F0-0x00000001899F7210 */ get => default; /* [XID] */ /* 0x00000001899FE890-0x00000001899FE8B0 */ protected set {} } // 0x0000000184A1CC70-0x0000000184A1CD40 0x0000000184A1C0D0-0x0000000184A1C1B0
	public uint rewardId { /* [XID] */ /* 0x0000000189A06170-0x0000000189A06190 */ get => default; /* [XID] */ /* 0x0000000189A0D640-0x0000000189A0D660 */ protected set {} } // 0x0000000184A1CBA0-0x0000000184A1CC70 0x0000000184A1BFF0-0x0000000184A1C0D0
	public uint rewardPreview { /* [XID] */ /* 0x0000000189A14DA0-0x0000000189A14DC0 */ get => default; /* [XID] */ /* 0x0000000189A1BFB0-0x0000000189A1BFD0 */ protected set {} } // 0x0000000184A1C5E0-0x0000000184A1C6B0 0x0000000184A1C6B0-0x0000000184A1C790

	// Constructors
	public MpCrucibleRewardConfig() {} // 0x0000000184A1CF20-0x0000000184A1CF80

	// Methods
	// [XID] // 0x0000000189A23800-0x0000000189A23820
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184A1C340-0x0000000184A1C5E0
	// [XID] // 0x0000000189A2AC80-0x0000000189A2ACA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28BA */, bool useObjectPool = false /* Metadata: 0x00AF28BE */) => default; // 0x0000000184A1C790-0x0000000184A1CBA0
	[BlackList] // 0x0000000189A321C0-0x0000000189A32200
	// [XID] // 0x0000000189A321C0-0x0000000189A32200
	public virtual void AutoAllocTypeFields() {} // 0x0000000184A1C1B0-0x0000000184A1C250
	[BlackList] // 0x0000000189A3C980-0x0000000189A3C9C0
	// [XID] // 0x0000000189A3C980-0x0000000189A3C9C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184A1C250-0x0000000184A1C340
	[BlackList] // 0x0000000189A472D0-0x0000000189A47310
	// [XID] // 0x0000000189A472D0-0x0000000189A47310
	public virtual void ReturnToObjectPool() {} // 0x0000000184A1CE80-0x0000000184A1CF20
	[BlackList] // 0x0000000189A51A30-0x0000000189A51A70
	// [XID] // 0x0000000189A51A30-0x0000000189A51A70
	public virtual void OnPoolAllocated() {} // 0x0000000184A1CDE0-0x0000000184A1CE80
	[BlackList] // 0x0000000189A5C440-0x0000000189A5C480
	// [XID] // 0x0000000189A5C440-0x0000000189A5C480
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184A1CD40-0x0000000184A1CDE0
}

