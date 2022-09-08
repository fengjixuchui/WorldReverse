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
public class ReliquaryPowerupExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16024
{
	// Fields
	protected SimpleSafeUInt32 powerupMultipleRawNum; // 0x10
	protected SimpleSafeUInt32 powerupWeightRawNum; // 0x14

	// Properties
	public uint powerupMultiple { /* [XID] */ /* 0x00000001899AC8B0-0x00000001899AC8D0 */ get => default; /* [XID] */ /* 0x00000001899B4080-0x00000001899B40A0 */ protected set {} } // 0x0000000183C32410-0x0000000183C324E0 0x0000000183C32330-0x0000000183C32410
	public uint powerupWeight { /* [XID] */ /* 0x00000001899BB4D0-0x00000001899BB4F0 */ get => default; /* [XID] */ /* 0x00000001899C30A0-0x00000001899C30C0 */ protected set {} } // 0x0000000183C32840-0x0000000183C32910 0x0000000183C32250-0x0000000183C32330

	// Constructors
	public ReliquaryPowerupExcelConfig() {} // 0x0000000183C32AF0-0x0000000183C32B50

	// Methods
	// [IDTag] // 0x00000001899CA480-0x00000001899CA4C0
	// [XID] // 0x00000001899CA480-0x00000001899CA4C0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183C31DC0-0x0000000183C32030
	// [IDTag] // 0x00000001899D4AF0-0x00000001899D4B30
	// [XID] // 0x00000001899D4AF0-0x00000001899D4B30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183C32030-0x0000000183C32250
	// [XID] // 0x00000001899DEF70-0x00000001899DEF90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E31 */, bool useObjectPool = false /* Metadata: 0x00AF2E35 */) => default; // 0x0000000183C324E0-0x0000000183C32840
	[BlackList] // 0x00000001899E6BB0-0x00000001899E6BF0
	// [XID] // 0x00000001899E6BB0-0x00000001899E6BF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C31C40-0x0000000183C31CE0
	[BlackList] // 0x00000001899F1070-0x00000001899F10B0
	// [XID] // 0x00000001899F1070-0x00000001899F10B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C31CE0-0x0000000183C31DC0
	[BlackList] // 0x00000001899FBBF0-0x00000001899FBC30
	// [XID] // 0x00000001899FBBF0-0x00000001899FBC30
	public virtual void ReturnToObjectPool() {} // 0x0000000183C32A50-0x0000000183C32AF0
	[BlackList] // 0x0000000189A06110-0x0000000189A06150
	// [XID] // 0x0000000189A06110-0x0000000189A06150
	public virtual void OnPoolAllocated() {} // 0x0000000183C329B0-0x0000000183C32A50
	[BlackList] // 0x0000000189A10330-0x0000000189A10370
	// [XID] // 0x0000000189A10330-0x0000000189A10370
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C32910-0x0000000183C329B0
}

