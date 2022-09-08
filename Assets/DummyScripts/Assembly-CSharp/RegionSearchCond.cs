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
public class RegionSearchCond : IAutoAllocRecycle // TypeDefIndex: 15155
{
	// Fields
	protected RegionSearchCondType _type; // 0x10
	protected SimpleSafeInt32[] _param; // 0x18

	// Properties
	public RegionSearchCondType type { /* [XID] */ /* 0x000000018990A080-0x000000018990A0A0 */ get => default; /* [XID] */ /* 0x0000000189911980-0x00000001899119A0 */ protected set {} } // 0x000000018329E2A0-0x000000018329E340 0x000000018329E0B0-0x000000018329E160
	public SimpleSafeInt32[] param { /* [XID] */ /* 0x0000000189919560-0x0000000189919580 */ get => default; /* [XID] */ /* 0x0000000189920AB0-0x0000000189920AD0 */ protected set {} } // 0x000000018329E3F0-0x000000018329E490 0x000000018329E340-0x000000018329E3F0

	// Constructors
	public RegionSearchCond() {} // 0x000000018329E530-0x000000018329E590

	// Methods
	// [XID] // 0x00000001899284B0-0x00000001899284D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018329D9F0-0x000000018329DD40
	// [XID] // 0x000000018992F980-0x000000018992F9A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0256 */, bool useObjectPool = false /* Metadata: 0x00AF025A */) => default; // 0x000000018329DD40-0x000000018329E0B0
	[BlackList] // 0x0000000189936ED0-0x0000000189936F10
	// [XID] // 0x0000000189936ED0-0x0000000189936F10
	public virtual void AutoAllocTypeFields() {} // 0x000000018329D8B0-0x000000018329D950
	[BlackList] // 0x0000000189941580-0x00000001899415C0
	// [XID] // 0x0000000189941580-0x00000001899415C0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018329D950-0x000000018329D9F0
	[BlackList] // 0x000000018994BF20-0x000000018994BF60
	// [XID] // 0x000000018994BF20-0x000000018994BF60
	public virtual void ReturnToObjectPool() {} // 0x000000018329E490-0x000000018329E530
	[BlackList] // 0x00000001899564C0-0x0000000189956500
	// [XID] // 0x00000001899564C0-0x0000000189956500
	public virtual void OnPoolAllocated() {} // 0x000000018329E200-0x000000018329E2A0
	[BlackList] // 0x0000000189960EE0-0x0000000189960F20
	// [XID] // 0x0000000189960EE0-0x0000000189960F20
	public virtual void OnBeforePoolRecycled() {} // 0x000000018329E160-0x000000018329E200
}

