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
public class ForgeUnlockConfig : IAutoAllocRecycle // TypeDefIndex: 15620
{
	// Fields
	protected ForgeUnlockMethod _unlockMethod; // 0x10
	protected string[] _unlockParam; // 0x18

	// Properties
	public ForgeUnlockMethod unlockMethod { /* [XID] */ /* 0x0000000189A88060-0x0000000189A88080 */ get => default; /* [XID] */ /* 0x0000000189A8F930-0x0000000189A8F950 */ protected set {} } // 0x000000018294FC10-0x000000018294FCB0 0x0000000182950080-0x0000000182950130
	public string[] unlockParam { /* [XID] */ /* 0x0000000189A96F40-0x0000000189A96F60 */ get => default; /* [XID] */ /* 0x0000000189A9E2D0-0x0000000189A9E2F0 */ protected set {} } // 0x000000018294FFE0-0x0000000182950080 0x000000018294FA20-0x000000018294FAD0

	// Constructors
	public ForgeUnlockConfig() {} // 0x0000000182950680-0x00000001829506E0

	// Methods
	// [XID] // 0x0000000189AA5CC0-0x0000000189AA5CE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018294FCB0-0x000000018294FFE0
	// [XID] // 0x0000000189AAD300-0x0000000189AAD320
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20D0 */, bool useObjectPool = false /* Metadata: 0x00AF20D4 */) => default; // 0x0000000182950130-0x00000001829504A0
	[BlackList] // 0x0000000189AB4CB0-0x0000000189AB4CF0
	// [XID] // 0x0000000189AB4CB0-0x0000000189AB4CF0
	public virtual void AutoAllocTypeFields() {} // 0x000000018294FAD0-0x000000018294FB70
	[BlackList] // 0x0000000189ABF6D0-0x0000000189ABF710
	// [XID] // 0x0000000189ABF6D0-0x0000000189ABF710
	public virtual void AutoRecycleTypeFields() {} // 0x000000018294FB70-0x000000018294FC10
	[BlackList] // 0x0000000189ACA060-0x0000000189ACA0A0
	// [XID] // 0x0000000189ACA060-0x0000000189ACA0A0
	public virtual void ReturnToObjectPool() {} // 0x00000001829505E0-0x0000000182950680
	[BlackList] // 0x0000000189AD4E40-0x0000000189AD4E80
	// [XID] // 0x0000000189AD4E40-0x0000000189AD4E80
	public virtual void OnPoolAllocated() {} // 0x0000000182950540-0x00000001829505E0
	[BlackList] // 0x0000000189ADF8D0-0x0000000189ADF910
	// [XID] // 0x0000000189ADF8D0-0x0000000189ADF910
	public virtual void OnBeforePoolRecycled() {} // 0x00000001829504A0-0x0000000182950540
}

