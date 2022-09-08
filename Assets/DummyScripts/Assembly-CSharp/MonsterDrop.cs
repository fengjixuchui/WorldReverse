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
public class MonsterDrop : IAutoAllocRecycle // TypeDefIndex: 15841
{
	// Fields
	protected SimpleSafeUInt32 dropIdRawNum; // 0x10
	protected SimpleSafeFloat hpPercentRawNum; // 0x14

	// Properties
	public uint dropId { /* [XID] */ /* 0x00000001896B9630-0x00000001896B9650 */ get => default; /* [XID] */ /* 0x00000001896C09C0-0x00000001896C09E0 */ protected set {} } // 0x00000001859525C0-0x0000000185952690 0x0000000185952A00-0x0000000185952AE0
	public float hpPercent { /* [XID] */ /* 0x00000001896C8130-0x00000001896C8150 */ get => default; /* [XID] */ /* 0x00000001896CFA30-0x00000001896CFA50 */ protected set {} } // 0x00000001859524E0-0x00000001859525C0 0x0000000185952AE0-0x0000000185952BC0

	// Constructors
	public MonsterDrop() {} // 0x0000000185952DA0-0x0000000185952E00

	// Methods
	// [XID] // 0x00000001896D6CA0-0x00000001896D6CC0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001859522C0-0x00000001859524E0
	// [XID] // 0x00000001896DE440-0x00000001896DE460
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2818 */, bool useObjectPool = false /* Metadata: 0x00AF281C */) => default; // 0x0000000185952690-0x0000000185952A00
	[BlackList] // 0x00000001896E5870-0x00000001896E58B0
	// [XID] // 0x00000001896E5870-0x00000001896E58B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185952120-0x00000001859521C0
	[BlackList] // 0x00000001896EFC60-0x00000001896EFCA0
	// [XID] // 0x00000001896EFC60-0x00000001896EFCA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001859521C0-0x00000001859522C0
	[BlackList] // 0x00000001896FA5F0-0x00000001896FA630
	// [XID] // 0x00000001896FA5F0-0x00000001896FA630
	public virtual void ReturnToObjectPool() {} // 0x0000000185952D00-0x0000000185952DA0
	[BlackList] // 0x0000000189704C90-0x0000000189704CD0
	// [XID] // 0x0000000189704C90-0x0000000189704CD0
	public virtual void OnPoolAllocated() {} // 0x0000000185952C60-0x0000000185952D00
	[BlackList] // 0x000000018970F6A0-0x000000018970F6E0
	// [XID] // 0x000000018970F6A0-0x000000018970F6E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185952BC0-0x0000000185952C60
}

