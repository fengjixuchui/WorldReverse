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
public class TowerStarReward : IAutoAllocRecycle // TypeDefIndex: 16192
{
	// Fields
	protected SimpleSafeUInt32 minStarCountRawNum; // 0x10
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x14

	// Properties
	public uint minStarCount { /* [XID] */ /* 0x00000001897F5210-0x00000001897F5230 */ get => default; /* [XID] */ /* 0x00000001897FCC20-0x00000001897FCC40 */ protected set {} } // 0x0000000181EC7F40-0x0000000181EC8010 0x0000000181EC8230-0x0000000181EC8310
	public uint rewardId { /* [XID] */ /* 0x0000000189804230-0x0000000189804250 */ get => default; /* [XID] */ /* 0x000000018980B660-0x000000018980B680 */ protected set {} } // 0x0000000181EC8670-0x0000000181EC8740 0x0000000181EC7CE0-0x0000000181EC7DC0

	// Constructors
	public TowerStarReward() {} // 0x0000000181EC8920-0x0000000181EC8980

	// Methods
	// [XID] // 0x0000000189812D40-0x0000000189812D60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181EC8010-0x0000000181EC8230
	// [XID] // 0x000000018981A9A0-0x000000018981A9C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33CA */, bool useObjectPool = false /* Metadata: 0x00AF33CE */) => default; // 0x0000000181EC8310-0x0000000181EC8670
	[BlackList] // 0x0000000189822130-0x0000000189822170
	// [XID] // 0x0000000189822130-0x0000000189822170
	public virtual void AutoAllocTypeFields() {} // 0x0000000181EC7DC0-0x0000000181EC7E60
	[BlackList] // 0x000000018982C730-0x000000018982C770
	// [XID] // 0x000000018982C730-0x000000018982C770
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181EC7E60-0x0000000181EC7F40
	[BlackList] // 0x0000000189836B90-0x0000000189836BD0
	// [XID] // 0x0000000189836B90-0x0000000189836BD0
	public virtual void ReturnToObjectPool() {} // 0x0000000181EC8880-0x0000000181EC8920
	[BlackList] // 0x0000000189840EE0-0x0000000189840F20
	// [XID] // 0x0000000189840EE0-0x0000000189840F20
	public virtual void OnPoolAllocated() {} // 0x0000000181EC87E0-0x0000000181EC8880
	[BlackList] // 0x000000018984B650-0x000000018984B690
	// [XID] // 0x000000018984B650-0x000000018984B690
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181EC8740-0x0000000181EC87E0
}

