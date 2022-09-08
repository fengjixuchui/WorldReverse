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
public class ActivityShopSheetCond : IAutoAllocRecycle // TypeDefIndex: 15191
{
	// Fields
	protected ActivityShopSheetCondType _type; // 0x10
	protected SimpleSafeUInt32[] _param; // 0x18

	// Properties
	public ActivityShopSheetCondType type { /* [XID] */ /* 0x0000000189901370-0x0000000189901390 */ get => default; /* [XID] */ /* 0x0000000189908B10-0x0000000189908B30 */ protected set {} } // 0x0000000185A62840-0x0000000185A628E0 0x0000000185A62650-0x0000000185A62700
	public SimpleSafeUInt32[] param { /* [XID] */ /* 0x0000000189910110-0x0000000189910130 */ get => default; /* [XID] */ /* 0x0000000189917CE0-0x0000000189917D00 */ protected set {} } // 0x0000000185A62990-0x0000000185A62A30 0x0000000185A628E0-0x0000000185A62990

	// Constructors
	public ActivityShopSheetCond() {} // 0x0000000185A62AD0-0x0000000185A62B30

	// Methods
	// [XID] // 0x000000018991F1E0-0x000000018991F200
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000185A61EE0-0x0000000185A622E0
	// [XID] // 0x0000000189926CE0-0x0000000189926D00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0363 */, bool useObjectPool = false /* Metadata: 0x00AF0367 */) => default; // 0x0000000185A622E0-0x0000000185A62650
	[BlackList] // 0x000000018992E410-0x000000018992E450
	// [XID] // 0x000000018992E410-0x000000018992E450
	public virtual void AutoAllocTypeFields() {} // 0x0000000185A61DA0-0x0000000185A61E40
	[BlackList] // 0x00000001899386F0-0x0000000189938730
	// [XID] // 0x00000001899386F0-0x0000000189938730
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185A61E40-0x0000000185A61EE0
	[BlackList] // 0x0000000189942DB0-0x0000000189942DF0
	// [XID] // 0x0000000189942DB0-0x0000000189942DF0
	public virtual void ReturnToObjectPool() {} // 0x0000000185A62A30-0x0000000185A62AD0
	[BlackList] // 0x000000018994D5F0-0x000000018994D630
	// [XID] // 0x000000018994D5F0-0x000000018994D630
	public virtual void OnPoolAllocated() {} // 0x0000000185A627A0-0x0000000185A62840
	[BlackList] // 0x0000000189957F00-0x0000000189957F40
	// [XID] // 0x0000000189957F00-0x0000000189957F40
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185A62700-0x0000000185A627A0
}

