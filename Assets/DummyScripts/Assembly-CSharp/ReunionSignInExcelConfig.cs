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
public class ReunionSignInExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16056
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 dayIndexRawNum; // 0x14
	protected SimpleSafeUInt32[] _rewardId; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A65480-0x0000000189A654A0 */ get => default; /* [XID] */ /* 0x0000000189A6CBA0-0x0000000189A6CBC0 */ protected set {} } // 0x00000001819AD160-0x00000001819AD230 0x00000001819AC9C0-0x00000001819ACAA0
	public uint dayIndex { /* [XID] */ /* 0x0000000189A742F0-0x0000000189A74310 */ get => default; /* [XID] */ /* 0x0000000189A7BCC0-0x0000000189A7BCE0 */ protected set {} } // 0x00000001819ACAA0-0x00000001819ACB70 0x00000001819AC8E0-0x00000001819AC9C0
	public SimpleSafeUInt32[] rewardId { /* [XID] */ /* 0x0000000189A83680-0x0000000189A836A0 */ get => default; /* [XID] */ /* 0x0000000189A8AF40-0x0000000189A8AF60 */ protected set {} } // 0x00000001819ACF80-0x00000001819AD020 0x00000001819ABEF0-0x00000001819ABFA0

	// Constructors
	public ReunionSignInExcelConfig() {} // 0x00000001819AD2D0-0x00000001819AD330

	// Methods
	// [IDTag] // 0x0000000189A926B0-0x0000000189A926F0
	// [XID] // 0x0000000189A926B0-0x0000000189A926F0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001819AC4E0-0x00000001819AC8E0
	// [IDTag] // 0x0000000189A9CD50-0x0000000189A9CD90
	// [XID] // 0x0000000189A9CD50-0x0000000189A9CD90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001819AC130-0x00000001819AC4E0
	// [XID] // 0x0000000189AA73C0-0x0000000189AA73E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F16 */, bool useObjectPool = false /* Metadata: 0x00AF2F1A */) => default; // 0x00000001819ACB70-0x00000001819ACF80
	[BlackList] // 0x0000000189AAEB00-0x0000000189AAEB40
	// [XID] // 0x0000000189AAEB00-0x0000000189AAEB40
	public virtual void AutoAllocTypeFields() {} // 0x00000001819ABFA0-0x00000001819AC040
	[BlackList] // 0x0000000189AB9150-0x0000000189AB9190
	// [XID] // 0x0000000189AB9150-0x0000000189AB9190
	public virtual void AutoRecycleTypeFields() {} // 0x00000001819AC040-0x00000001819AC130
	[BlackList] // 0x0000000189AC41E0-0x0000000189AC4220
	// [XID] // 0x0000000189AC41E0-0x0000000189AC4220
	public virtual void ReturnToObjectPool() {} // 0x00000001819AD230-0x00000001819AD2D0
	[BlackList] // 0x0000000189ACE770-0x0000000189ACE7B0
	// [XID] // 0x0000000189ACE770-0x0000000189ACE7B0
	public virtual void OnPoolAllocated() {} // 0x00000001819AD0C0-0x00000001819AD160
	[BlackList] // 0x0000000189AD9530-0x0000000189AD9570
	// [XID] // 0x0000000189AD9530-0x0000000189AD9570
	public virtual void OnBeforePoolRecycled() {} // 0x00000001819AD020-0x00000001819AD0C0
}

