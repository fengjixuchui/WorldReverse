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
public class PlayerLevelLockExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15952
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 worldLevelRawNum; // 0x10
	protected SimpleSafeUInt32 unlockMainQuestIdRawNum; // 0x14
	protected SimpleSafeUInt32 unlockPlayerLevelRawNum; // 0x18
	protected SimpleSafeUInt32 playerLevelUpperLimitRawNum; // 0x1C
	protected uint _unlockDescTextMapHash; // 0x20

	// Properties
	public uint worldLevel { /* [XID] */ /* 0x00000001896AABB0-0x00000001896AABD0 */ get => default; /* [XID] */ /* 0x00000001896B1B30-0x00000001896B1B50 */ protected set {} } // 0x0000000181C2C4A0-0x0000000181C2C570 0x0000000181C2C3C0-0x0000000181C2C4A0
	public uint unlockMainQuestId { /* [XID] */ /* 0x00000001896B9590-0x00000001896B95B0 */ get => default; /* [XID] */ /* 0x00000001896C0900-0x00000001896C0920 */ protected set {} } // 0x0000000181C2CC70-0x0000000181C2CD40 0x0000000181C2BF40-0x0000000181C2C020
	public uint unlockPlayerLevel { /* [XID] */ /* 0x00000001896C80D0-0x00000001896C80F0 */ get => default; /* [XID] */ /* 0x00000001896CF9B0-0x00000001896CF9D0 */ protected set {} } // 0x0000000181C2C240-0x0000000181C2C310 0x0000000181C2CB90-0x0000000181C2CC70
	public uint playerLevelUpperLimit { /* [XID] */ /* 0x00000001896D6C20-0x00000001896D6C40 */ get => default; /* [XID] */ /* 0x00000001896DE3A0-0x00000001896DE3C0 */ protected set {} } // 0x0000000181C2C570-0x0000000181C2C640 0x0000000181C2B6F0-0x0000000181C2B7D0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unlockDescTextMapHash { /* [XID] */ /* 0x00000001896E57F0-0x00000001896E5810 */ get => default; /* [XID] */ /* 0x00000001896ECEC0-0x00000001896ECEE0 */ protected set {} } // 0x0000000181C2C1A0-0x0000000181C2C240 0x0000000181C2C310-0x0000000181C2C3C0
	public string unlockDesc { /* [XID] */ /* 0x00000001896F4760-0x00000001896F4780 */ get => default; } // 0x0000000181C2C020-0x0000000181C2C1A0 

	// Constructors
	public PlayerLevelLockExcelConfig() {} // 0x0000000181C2CF20-0x0000000181C2CF80

	// Methods
	// [IDTag] // 0x00000001896FBF50-0x00000001896FBF90
	// [XID] // 0x00000001896FBF50-0x00000001896FBF90
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181C2B7D0-0x0000000181C2BBA0
	// [IDTag] // 0x0000000189706340-0x0000000189706380
	// [XID] // 0x0000000189706340-0x0000000189706380
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C2BBA0-0x0000000181C2BF40
	// [XID] // 0x0000000189710E10-0x0000000189710E30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C15 */, bool useObjectPool = false /* Metadata: 0x00AF2C19 */) => default; // 0x0000000181C2C640-0x0000000181C2CB90
	[BlackList] // 0x0000000189718150-0x0000000189718190
	// [XID] // 0x0000000189718150-0x0000000189718190
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C2B540-0x0000000181C2B5E0
	[BlackList] // 0x00000001897227C0-0x0000000189722800
	// [XID] // 0x00000001897227C0-0x0000000189722800
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C2B5E0-0x0000000181C2B6F0
	[BlackList] // 0x000000018972CE20-0x000000018972CE60
	// [XID] // 0x000000018972CE20-0x000000018972CE60
	public virtual void ReturnToObjectPool() {} // 0x0000000181C2CE80-0x0000000181C2CF20
	[BlackList] // 0x0000000189737980-0x00000001897379C0
	// [XID] // 0x0000000189737980-0x00000001897379C0
	public virtual void OnPoolAllocated() {} // 0x0000000181C2CDE0-0x0000000181C2CE80
	[BlackList] // 0x0000000189741FC0-0x0000000189742000
	// [XID] // 0x0000000189741FC0-0x0000000189742000
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C2CD40-0x0000000181C2CDE0
}

