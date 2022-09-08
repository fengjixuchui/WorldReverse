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
public class BoredMonsterConfig : IAutoAllocRecycle // TypeDefIndex: 15289
{
	// Fields
	protected SimpleSafeUInt32 weightRawNum; // 0x10
	protected SimpleSafeUInt32 idRawNum; // 0x14

	// Properties
	public uint weight { /* [XID] */ /* 0x00000001899CEE20-0x00000001899CEE40 */ get => default; /* [XID] */ /* 0x00000001899D6450-0x00000001899D6470 */ protected set {} } // 0x0000000183146360-0x0000000183146430 0x0000000183145C30-0x0000000183145D10
	public uint id { /* [XID] */ /* 0x00000001899DD940-0x00000001899DD960 */ get => default; /* [XID] */ /* 0x00000001899E5780-0x00000001899E57A0 */ protected set {} } // 0x0000000183146290-0x0000000183146360 0x0000000183145D10-0x0000000183145DF0

	// Constructors
	public BoredMonsterConfig() {} // 0x00000001831464D0-0x0000000183146530

	// Methods
	// [XID] // 0x00000001899EC8F0-0x00000001899EC910
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183145A10-0x0000000183145C30
	// [XID] // 0x00000001899F4710-0x00000001899F4730
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0679 */, bool useObjectPool = false /* Metadata: 0x00AF067D */) => default; // 0x0000000183145DF0-0x0000000183146150
	[BlackList] // 0x00000001899FBCD0-0x00000001899FBD10
	// [XID] // 0x00000001899FBCD0-0x00000001899FBD10
	public virtual void AutoAllocTypeFields() {} // 0x0000000183145890-0x0000000183145930
	[BlackList] // 0x0000000189A061F0-0x0000000189A06230
	// [XID] // 0x0000000189A061F0-0x0000000189A06230
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183145930-0x0000000183145A10
	[BlackList] // 0x0000000189A10430-0x0000000189A10470
	// [XID] // 0x0000000189A10430-0x0000000189A10470
	public virtual void ReturnToObjectPool() {} // 0x0000000183146430-0x00000001831464D0
	[BlackList] // 0x0000000189A1A890-0x0000000189A1A8D0
	// [XID] // 0x0000000189A1A890-0x0000000189A1A8D0
	public virtual void OnPoolAllocated() {} // 0x00000001831461F0-0x0000000183146290
	[BlackList] // 0x0000000189A24E90-0x0000000189A24ED0
	// [XID] // 0x0000000189A24E90-0x0000000189A24ED0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183146150-0x00000001831461F0
}

