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
public class ActivitySalesmanRewardMatchConfig : IAutoAllocRecycle // TypeDefIndex: 15172
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x10
	protected RewardResourceType _ReoureceType; // 0x14
	protected uint _boxNameTextMapHash; // 0x18

	// Properties
	public uint rewardID { /* [XID] */ /* 0x0000000189AA8A40-0x0000000189AA8A60 */ get => default; /* [XID] */ /* 0x0000000189AB0600-0x0000000189AB0620 */ protected set {} } // 0x00000001831D06D0-0x00000001831D07A0 0x00000001831D05F0-0x00000001831D06D0
	public RewardResourceType ReoureceType { /* [XID] */ /* 0x0000000189AB7C80-0x0000000189AB7CA0 */ get => default; /* [XID] */ /* 0x0000000189ABF750-0x0000000189ABF770 */ protected set {} } // 0x00000001831D0C60-0x00000001831D0D00 0x00000001831D07A0-0x00000001831D0850
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint boxNameTextMapHash { /* [XID] */ /* 0x0000000189AC7120-0x0000000189AC7140 */ get => default; /* [XID] */ /* 0x0000000189ACE810-0x0000000189ACE830 */ protected set {} } // 0x00000001831D0D00-0x00000001831D0DA0 0x00000001831D0DA0-0x00000001831D0E50
	public string boxName { /* [XID] */ /* 0x0000000189AD6700-0x0000000189AD6720 */ get => default; } // 0x00000001831CFD40-0x00000001831CFEC0 

	// Constructors
	public ActivitySalesmanRewardMatchConfig() {} // 0x00000001831D1030-0x00000001831D1090

	// Methods
	// [IDTag] // 0x0000000189ADE000-0x0000000189ADE040
	// [XID] // 0x0000000189ADE000-0x0000000189ADE040
	public virtual bool ParseFromLine(string line) => default; // 0x00000001831D02F0-0x00000001831D05F0
	// [IDTag] // 0x0000000189AE8570-0x0000000189AE85B0
	// [XID] // 0x0000000189AE8570-0x0000000189AE85B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001831D0030-0x00000001831D02F0
	// [XID] // 0x0000000189AF3370-0x0000000189AF3390
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02D6 */, bool useObjectPool = false /* Metadata: 0x00AF02DA */) => default; // 0x00000001831D0850-0x00000001831D0C60
	[BlackList] // 0x0000000189AFAC20-0x0000000189AFAC60
	// [XID] // 0x0000000189AFAC20-0x0000000189AFAC60
	public virtual void AutoAllocTypeFields() {} // 0x00000001831CFEC0-0x00000001831CFF60
	[BlackList] // 0x0000000189B04F60-0x0000000189B04FA0
	// [XID] // 0x0000000189B04F60-0x0000000189B04FA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001831CFF60-0x00000001831D0030
	[BlackList] // 0x0000000189B0F7B0-0x0000000189B0F7F0
	// [XID] // 0x0000000189B0F7B0-0x0000000189B0F7F0
	public virtual void ReturnToObjectPool() {} // 0x00000001831D0F90-0x00000001831D1030
	[BlackList] // 0x0000000189B199F0-0x0000000189B19A30
	// [XID] // 0x0000000189B199F0-0x0000000189B19A30
	public virtual void OnPoolAllocated() {} // 0x00000001831D0EF0-0x00000001831D0F90
	[BlackList] // 0x0000000189B24280-0x0000000189B242C0
	// [XID] // 0x0000000189B24280-0x0000000189B242C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001831D0E50-0x00000001831D0EF0
}

