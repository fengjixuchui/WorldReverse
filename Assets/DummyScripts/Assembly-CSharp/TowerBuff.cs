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
public class TowerBuff : IAutoAllocRecycle // TypeDefIndex: 16197
{
	// Fields
	protected SimpleSafeUInt32 towerBuffIdRawNum; // 0x10
	protected SimpleSafeUInt32 weightRawNum; // 0x14

	// Properties
	public uint towerBuffId { /* [XID] */ /* 0x0000000189B86820-0x0000000189B86840 */ get => default; /* [XID] */ /* 0x0000000189B8DA10-0x0000000189B8DA30 */ protected set {} } // 0x000000018423A730-0x000000018423A800 0x000000018423A440-0x000000018423A520
	public uint weight { /* [XID] */ /* 0x0000000189B94F70-0x0000000189B94F90 */ get => default; /* [XID] */ /* 0x0000000189B9C6C0-0x0000000189B9C6E0 */ protected set {} } // 0x000000018423A660-0x000000018423A730 0x000000018423A140-0x000000018423A220

	// Constructors
	public TowerBuff() {} // 0x000000018423A8A0-0x000000018423A900

	// Methods
	// [XID] // 0x0000000189BA3D30-0x0000000189BA3D50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018423A020-0x000000018423A140
	// [XID] // 0x0000000189BAB240-0x0000000189BAB260
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33E8 */, bool useObjectPool = false /* Metadata: 0x00AF33EC */) => default; // 0x000000018423A220-0x000000018423A440
	[BlackList] // 0x0000000189BB2850-0x0000000189BB2890
	// [XID] // 0x0000000189BB2850-0x0000000189BB2890
	public virtual void AutoAllocTypeFields() {} // 0x0000000184239EA0-0x0000000184239F40
	[BlackList] // 0x0000000189BBCCC0-0x0000000189BBCD00
	// [XID] // 0x0000000189BBCCC0-0x0000000189BBCD00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184239F40-0x000000018423A020
	[BlackList] // 0x0000000189BC77E0-0x0000000189BC7820
	// [XID] // 0x0000000189BC77E0-0x0000000189BC7820
	public virtual void ReturnToObjectPool() {} // 0x000000018423A800-0x000000018423A8A0
	[BlackList] // 0x0000000189BD2300-0x0000000189BD2340
	// [XID] // 0x0000000189BD2300-0x0000000189BD2340
	public virtual void OnPoolAllocated() {} // 0x000000018423A5C0-0x000000018423A660
	[BlackList] // 0x0000000189BDCD00-0x0000000189BDCD40
	// [XID] // 0x0000000189BDCD00-0x0000000189BDCD40
	public virtual void OnBeforePoolRecycled() {} // 0x000000018423A520-0x000000018423A5C0
}

