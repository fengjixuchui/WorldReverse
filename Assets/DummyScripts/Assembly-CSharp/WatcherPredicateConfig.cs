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
public class WatcherPredicateConfig : IAutoAllocRecycle // TypeDefIndex: 16261
{
	// Fields
	protected WatcherPredicateType _predicateType; // 0x10
	protected SimpleSafeUInt32[] _paramList; // 0x18

	// Properties
	public WatcherPredicateType predicateType { /* [XID] */ /* 0x00000001898F81B0-0x00000001898F81D0 */ get => default; /* [XID] */ /* 0x00000001898FF7D0-0x00000001898FF7F0 */ protected set {} } // 0x0000000185087690-0x0000000185087730 0x0000000185087BD0-0x0000000185087C80
	public SimpleSafeUInt32[] paramList { /* [XID] */ /* 0x0000000189906FB0-0x0000000189906FD0 */ get => default; /* [XID] */ /* 0x000000018990E9D0-0x000000018990E9F0 */ protected set {} } // 0x0000000185087730-0x00000001850877D0 0x0000000185087B20-0x0000000185087BD0

	// Constructors
	public WatcherPredicateConfig() {} // 0x00000001850881D0-0x0000000185088230

	// Methods
	// [XID] // 0x0000000189916040-0x0000000189916060
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001850877D0-0x0000000185087B20
	// [XID] // 0x000000018991DAF0-0x000000018991DB10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF35D9 */, bool useObjectPool = false /* Metadata: 0x00AF35DD */) => default; // 0x0000000185087C80-0x0000000185087FF0
	[BlackList] // 0x0000000189925240-0x0000000189925280
	// [XID] // 0x0000000189925240-0x0000000189925280
	public virtual void AutoAllocTypeFields() {} // 0x0000000185087550-0x00000001850875F0
	[BlackList] // 0x000000018992F820-0x000000018992F860
	// [XID] // 0x000000018992F820-0x000000018992F860
	public virtual void AutoRecycleTypeFields() {} // 0x00000001850875F0-0x0000000185087690
	[BlackList] // 0x000000018993A290-0x000000018993A2D0
	// [XID] // 0x000000018993A290-0x000000018993A2D0
	public virtual void ReturnToObjectPool() {} // 0x0000000185088130-0x00000001850881D0
	[BlackList] // 0x00000001899446E0-0x0000000189944720
	// [XID] // 0x00000001899446E0-0x0000000189944720
	public virtual void OnPoolAllocated() {} // 0x0000000185088090-0x0000000185088130
	[BlackList] // 0x000000018994ED00-0x000000018994ED40
	// [XID] // 0x000000018994ED00-0x000000018994ED40
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185087FF0-0x0000000185088090
}

