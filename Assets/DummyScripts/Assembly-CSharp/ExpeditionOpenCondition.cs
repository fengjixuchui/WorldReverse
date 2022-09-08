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
public class ExpeditionOpenCondition : IAutoAllocRecycle // TypeDefIndex: 15595
{
	// Fields
	protected ExpeditionOpenCondType _type; // 0x10
	protected SimpleSafeUInt32 paraRawNum; // 0x14

	// Properties
	public ExpeditionOpenCondType type { /* [XID] */ /* 0x00000001899FA130-0x00000001899FA150 */ get => default; /* [XID] */ /* 0x0000000189A01530-0x0000000189A01550 */ protected set {} } // 0x0000000181C4DA50-0x0000000181C4DAF0 0x0000000181C4D790-0x0000000181C4D840
	public uint para { /* [XID] */ /* 0x0000000189A08E90-0x0000000189A08EB0 */ get => default; /* [XID] */ /* 0x0000000189A103D0-0x0000000189A103F0 */ protected set {} } // 0x0000000181C4D840-0x0000000181C4D910 0x0000000181C4D110-0x0000000181C4D1F0

	// Constructors
	public ExpeditionOpenCondition() {} // 0x0000000181C4DB90-0x0000000181C4DBF0

	// Methods
	// [XID] // 0x0000000189A17990-0x0000000189A179B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C4D1F0-0x0000000181C4D430
	// [XID] // 0x0000000189A1F0B0-0x0000000189A1F0D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2015 */, bool useObjectPool = false /* Metadata: 0x00AF2019 */) => default; // 0x0000000181C4D430-0x0000000181C4D790
	[BlackList] // 0x0000000189A26660-0x0000000189A266A0
	// [XID] // 0x0000000189A26660-0x0000000189A266A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C4CFA0-0x0000000181C4D040
	[BlackList] // 0x0000000189A30A90-0x0000000189A30AD0
	// [XID] // 0x0000000189A30A90-0x0000000189A30AD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C4D040-0x0000000181C4D110
	[BlackList] // 0x0000000189A3B260-0x0000000189A3B2A0
	// [XID] // 0x0000000189A3B260-0x0000000189A3B2A0
	public virtual void ReturnToObjectPool() {} // 0x0000000181C4DAF0-0x0000000181C4DB90
	[BlackList] // 0x0000000189A45B60-0x0000000189A45BA0
	// [XID] // 0x0000000189A45B60-0x0000000189A45BA0
	public virtual void OnPoolAllocated() {} // 0x0000000181C4D9B0-0x0000000181C4DA50
	[BlackList] // 0x0000000189A50240-0x0000000189A50280
	// [XID] // 0x0000000189A50240-0x0000000189A50280
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C4D910-0x0000000181C4D9B0
}

