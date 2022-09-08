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
public class GadgetGuestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15647
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected GuestButtonShowType _showType; // 0x14

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A077D0-0x0000000189A077F0 */ get => default; /* [XID] */ /* 0x0000000189A0EC50-0x0000000189A0EC70 */ protected set {} } // 0x00000001839AC2E0-0x00000001839AC3B0 0x00000001839ABD60-0x00000001839ABE40
	public GuestButtonShowType showType { /* [XID] */ /* 0x0000000189A164A0-0x0000000189A164C0 */ get => default; /* [XID] */ /* 0x0000000189A1DA00-0x0000000189A1DA20 */ protected set {} } // 0x00000001839ABCC0-0x00000001839ABD60 0x00000001839AB740-0x00000001839AB7F0

	// Constructors
	public GadgetGuestExcelConfig() {} // 0x00000001839AC450-0x00000001839AC4B0

	// Methods
	// [IDTag] // 0x0000000189A24E50-0x0000000189A24E90
	// [XID] // 0x0000000189A24E50-0x0000000189A24E90
	public virtual bool ParseFromLine(string line) => default; // 0x00000001839ABA30-0x00000001839ABCC0
	// [IDTag] // 0x0000000189A2F450-0x0000000189A2F490
	// [XID] // 0x0000000189A2F450-0x0000000189A2F490
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839AB7F0-0x00000001839ABA30
	// [XID] // 0x0000000189A39BB0-0x0000000189A39BD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF219D */, bool useObjectPool = false /* Metadata: 0x00AF21A1 */) => default; // 0x00000001839ABE40-0x00000001839AC1A0
	[BlackList] // 0x0000000189A413F0-0x0000000189A41430
	// [XID] // 0x0000000189A413F0-0x0000000189A41430
	public virtual void AutoAllocTypeFields() {} // 0x00000001839AB5D0-0x00000001839AB670
	[BlackList] // 0x0000000189A4BA20-0x0000000189A4BA60
	// [XID] // 0x0000000189A4BA20-0x0000000189A4BA60
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839AB670-0x00000001839AB740
	[BlackList] // 0x0000000189A562C0-0x0000000189A56300
	// [XID] // 0x0000000189A562C0-0x0000000189A56300
	public virtual void ReturnToObjectPool() {} // 0x00000001839AC3B0-0x00000001839AC450
	[BlackList] // 0x0000000189A60C40-0x0000000189A60C80
	// [XID] // 0x0000000189A60C40-0x0000000189A60C80
	public virtual void OnPoolAllocated() {} // 0x00000001839AC240-0x00000001839AC2E0
	[BlackList] // 0x0000000189A6B6F0-0x0000000189A6B730
	// [XID] // 0x0000000189A6B6F0-0x0000000189A6B730
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839AC1A0-0x00000001839AC240
}

