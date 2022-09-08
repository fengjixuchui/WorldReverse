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
public class MatchCond : IAutoAllocRecycle // TypeDefIndex: 15803
{
	// Fields
	protected MatchLimitType _type; // 0x10
	protected SimpleSafeInt32 paramRawNum; // 0x14

	// Properties
	public MatchLimitType type { /* [XID] */ /* 0x00000001896E8820-0x00000001896E8840 */ get => default; /* [XID] */ /* 0x00000001896EFCA0-0x00000001896EFCC0 */ protected set {} } // 0x00000001814DCE50-0x00000001814DCEF0 0x00000001814DCC60-0x00000001814DCD10
	public int param { /* [XID] */ /* 0x00000001896F7670-0x00000001896F7690 */ get => default; /* [XID] */ /* 0x00000001896FF0B0-0x00000001896FF0D0 */ protected set {} } // 0x00000001814DCFD0-0x00000001814DD0A0 0x00000001814DCEF0-0x00000001814DCFD0

	// Constructors
	public MatchCond() {} // 0x00000001814DD140-0x00000001814DD1A0

	// Methods
	// [XID] // 0x0000000189706380-0x00000001897063A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001814DC6C0-0x00000001814DC900
	// [XID] // 0x000000018970DC30-0x000000018970DC50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF266C */, bool useObjectPool = false /* Metadata: 0x00AF2670 */) => default; // 0x00000001814DC900-0x00000001814DCC60
	[BlackList] // 0x00000001897150B0-0x00000001897150F0
	// [XID] // 0x00000001897150B0-0x00000001897150F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001814DC550-0x00000001814DC5F0
	[BlackList] // 0x000000018971FB70-0x000000018971FBB0
	// [XID] // 0x000000018971FB70-0x000000018971FBB0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001814DC5F0-0x00000001814DC6C0
	[BlackList] // 0x0000000189729F40-0x0000000189729F80
	// [XID] // 0x0000000189729F40-0x0000000189729F80
	public virtual void ReturnToObjectPool() {} // 0x00000001814DD0A0-0x00000001814DD140
	[BlackList] // 0x0000000189734690-0x00000001897346D0
	// [XID] // 0x0000000189734690-0x00000001897346D0
	public virtual void OnPoolAllocated() {} // 0x00000001814DCDB0-0x00000001814DCE50
	[BlackList] // 0x000000018973F500-0x000000018973F540
	// [XID] // 0x000000018973F500-0x000000018973F540
	public virtual void OnBeforePoolRecycled() {} // 0x00000001814DCD10-0x00000001814DCDB0
}

