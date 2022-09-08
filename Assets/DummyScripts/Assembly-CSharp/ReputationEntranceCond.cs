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
public class ReputationEntranceCond : IAutoAllocRecycle // TypeDefIndex: 16043
{
	// Fields
	protected ReputationEntranceCondType _type; // 0x10
	protected SimpleSafeUInt32 param1RawNum; // 0x14
	protected SimpleSafeUInt32 param2RawNum; // 0x18

	// Properties
	public ReputationEntranceCondType type { /* [XID] */ /* 0x00000001898BE700-0x00000001898BE720 */ get => default; /* [XID] */ /* 0x00000001898C5EB0-0x00000001898C5ED0 */ protected set {} } // 0x0000000184741510-0x00000001847415B0 0x0000000184741240-0x00000001847412F0
	public uint param1 { /* [XID] */ /* 0x00000001898CD6A0-0x00000001898CD6C0 */ get => default; /* [XID] */ /* 0x00000001898D5170-0x00000001898D5190 */ protected set {} } // 0x00000001847408F0-0x00000001847409C0 0x0000000184740C80-0x0000000184740D60
	public uint param2 { /* [XID] */ /* 0x00000001898DC9F0-0x00000001898DCA10 */ get => default; /* [XID] */ /* 0x00000001898E4480-0x00000001898E44A0 */ protected set {} } // 0x0000000184740D60-0x0000000184740E30 0x00000001847412F0-0x00000001847413D0

	// Constructors
	public ReputationEntranceCond() {} // 0x0000000184741650-0x00000001847416B0

	// Methods
	// [XID] // 0x00000001898EBF10-0x00000001898EBF30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001847409C0-0x0000000184740C80
	// [XID] // 0x00000001898F3800-0x00000001898F3820
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2EBF */, bool useObjectPool = false /* Metadata: 0x00AF2EC3 */) => default; // 0x0000000184740E30-0x0000000184741240
	[BlackList] // 0x00000001898FAE60-0x00000001898FAEA0
	// [XID] // 0x00000001898FAE60-0x00000001898FAEA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184740760-0x0000000184740800
	[BlackList] // 0x0000000189905860-0x00000001899058A0
	// [XID] // 0x0000000189905860-0x00000001899058A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184740800-0x00000001847408F0
	[BlackList] // 0x000000018990FF90-0x000000018990FFD0
	// [XID] // 0x000000018990FF90-0x000000018990FFD0
	public virtual void ReturnToObjectPool() {} // 0x00000001847415B0-0x0000000184741650
	[BlackList] // 0x000000018991ABD0-0x000000018991AC10
	// [XID] // 0x000000018991ABD0-0x000000018991AC10
	public virtual void OnPoolAllocated() {} // 0x0000000184741470-0x0000000184741510
	[BlackList] // 0x00000001899252C0-0x0000000189925300
	// [XID] // 0x00000001899252C0-0x0000000189925300
	public virtual void OnBeforePoolRecycled() {} // 0x00000001847413D0-0x0000000184741470
}

