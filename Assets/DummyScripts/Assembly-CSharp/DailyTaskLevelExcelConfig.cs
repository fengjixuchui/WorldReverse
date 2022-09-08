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
public class DailyTaskLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15485
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeUInt32 minPlayerLevelRawNum; // 0x14
	protected SimpleSafeUInt32 maxPlayerLevelRawNum; // 0x18
	protected SimpleSafeUInt32 groupReviseLevelRawNum; // 0x1C
	protected SimpleSafeUInt32 scoreDropIdRawNum; // 0x20
	protected SimpleSafeUInt32 scorePreviewRewardIdRawNum; // 0x24

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189655460-0x0000000189655480 */ get => default; /* [XID] */ /* 0x000000018965CC00-0x000000018965CC20 */ protected set {} } // 0x0000000182E6E4B0-0x0000000182E6E580 0x0000000182E6D570-0x0000000182E6D650
	public uint minPlayerLevel { /* [XID] */ /* 0x0000000189664120-0x0000000189664140 */ get => default; /* [XID] */ /* 0x000000018966B780-0x000000018966B7A0 */ protected set {} } // 0x0000000182E6EF40-0x0000000182E6F010 0x0000000182E6E580-0x0000000182E6E660
	public uint maxPlayerLevel { /* [XID] */ /* 0x0000000189673540-0x0000000189673560 */ get => default; /* [XID] */ /* 0x000000018967AD80-0x000000018967ADA0 */ protected set {} } // 0x0000000182E6E300-0x0000000182E6E3D0 0x0000000182E6D820-0x0000000182E6D900
	public uint groupReviseLevel { /* [XID] */ /* 0x0000000189682610-0x0000000189682630 */ get => default; /* [XID] */ /* 0x000000018968A0D0-0x000000018968A0F0 */ protected set {} } // 0x0000000182E6E230-0x0000000182E6E300 0x0000000182E6EC50-0x0000000182E6ED30
	public uint scoreDropId { /* [XID] */ /* 0x0000000189691E70-0x0000000189691E90 */ get => default; /* [XID] */ /* 0x00000001896993A0-0x00000001896993C0 */ protected set {} } // 0x0000000182E6ED30-0x0000000182E6EE00 0x0000000182E6E3D0-0x0000000182E6E4B0
	public uint scorePreviewRewardId { /* [XID] */ /* 0x00000001896A0810-0x00000001896A0830 */ get => default; /* [XID] */ /* 0x00000001896A7E00-0x00000001896A7E20 */ protected set {} } // 0x0000000182E6D4A0-0x0000000182E6D570 0x0000000182E6D900-0x0000000182E6D9E0

	// Constructors
	public DailyTaskLevelExcelConfig() {} // 0x0000000182E6F0B0-0x0000000182E6F110

	// Methods
	// [IDTag] // 0x00000001896AF230-0x00000001896AF270
	// [XID] // 0x00000001896AF230-0x00000001896AF270
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182E6D9E0-0x0000000182E6DE20
	// [IDTag] // 0x00000001896B96F0-0x00000001896B9730
	// [XID] // 0x00000001896B96F0-0x00000001896B9730
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182E6DE20-0x0000000182E6E230
	// [XID] // 0x00000001896C3A80-0x00000001896C3AA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C09 */, bool useObjectPool = false /* Metadata: 0x00AF1C0D */) => default; // 0x0000000182E6E660-0x0000000182E6EC50
	[BlackList] // 0x00000001896CAF30-0x00000001896CAF70
	// [XID] // 0x00000001896CAF30-0x00000001896CAF70
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E6D650-0x0000000182E6D6F0
	[BlackList] // 0x00000001896D56E0-0x00000001896D5720
	// [XID] // 0x00000001896D56E0-0x00000001896D5720
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E6D6F0-0x0000000182E6D820
	[BlackList] // 0x00000001896DFEA0-0x00000001896DFEE0
	// [XID] // 0x00000001896DFEA0-0x00000001896DFEE0
	public virtual void ReturnToObjectPool() {} // 0x0000000182E6F010-0x0000000182E6F0B0
	[BlackList] // 0x00000001896EA300-0x00000001896EA340
	// [XID] // 0x00000001896EA300-0x00000001896EA340
	public virtual void OnPoolAllocated() {} // 0x0000000182E6EEA0-0x0000000182E6EF40
	[BlackList] // 0x00000001896F47E0-0x00000001896F4820
	// [XID] // 0x00000001896F47E0-0x00000001896F4820
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E6EE00-0x0000000182E6EEA0
}

