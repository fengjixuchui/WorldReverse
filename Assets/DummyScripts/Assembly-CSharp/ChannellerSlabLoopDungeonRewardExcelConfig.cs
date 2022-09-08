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
public class ChannellerSlabLoopDungeonRewardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15048
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 scoreGradeRawNum; // 0x14
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AD6740-0x0000000189AD6760 */ get => default; /* [XID] */ /* 0x0000000189ADE060-0x0000000189ADE080 */ protected set {} } // 0x000000018197AED0-0x000000018197AFA0 0x000000018197A7C0-0x000000018197A8A0
	public uint scoreGrade { /* [XID] */ /* 0x0000000189AE5AC0-0x0000000189AE5AE0 */ get => default; /* [XID] */ /* 0x0000000189AECF60-0x0000000189AECF80 */ protected set {} } // 0x000000018197A6F0-0x000000018197A7C0 0x000000018197ACB0-0x000000018197AD90
	public uint rewardID { /* [XID] */ /* 0x0000000189AF4850-0x0000000189AF4870 */ get => default; /* [XID] */ /* 0x0000000189AFBEC0-0x0000000189AFBEE0 */ protected set {} } // 0x000000018197A620-0x000000018197A6F0 0x000000018197A540-0x000000018197A620

	// Constructors
	public ChannellerSlabLoopDungeonRewardExcelConfig() {} // 0x000000018197B040-0x000000018197B0A0

	// Methods
	// [IDTag] // 0x0000000189B037B0-0x0000000189B037F0
	// [XID] // 0x0000000189B037B0-0x0000000189B037F0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018197A260-0x000000018197A540
	// [IDTag] // 0x0000000189B0DF70-0x0000000189B0DFB0
	// [XID] // 0x0000000189B0DF70-0x0000000189B0DFB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181979FC0-0x000000018197A260
	// [XID] // 0x0000000189B183E0-0x0000000189B18400
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF5F */, bool useObjectPool = false /* Metadata: 0x00AEFF63 */) => default; // 0x000000018197A8A0-0x000000018197ACB0
	[BlackList] // 0x0000000189B1FAC0-0x0000000189B1FB00
	// [XID] // 0x0000000189B1FAC0-0x0000000189B1FB00
	public virtual void AutoAllocTypeFields() {} // 0x0000000181979E30-0x0000000181979ED0
	[BlackList] // 0x0000000189B2A000-0x0000000189B2A040
	// [XID] // 0x0000000189B2A000-0x0000000189B2A040
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181979ED0-0x0000000181979FC0
	[BlackList] // 0x0000000189B342A0-0x0000000189B342E0
	// [XID] // 0x0000000189B342A0-0x0000000189B342E0
	public virtual void ReturnToObjectPool() {} // 0x000000018197AFA0-0x000000018197B040
	[BlackList] // 0x0000000189B3ED80-0x0000000189B3EDC0
	// [XID] // 0x0000000189B3ED80-0x0000000189B3EDC0
	public virtual void OnPoolAllocated() {} // 0x000000018197AE30-0x000000018197AED0
	[BlackList] // 0x0000000189B498A0-0x0000000189B498E0
	// [XID] // 0x0000000189B498A0-0x0000000189B498E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018197AD90-0x000000018197AE30
}

