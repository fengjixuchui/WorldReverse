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
public class DropNode : IAutoAllocRecycle // TypeDefIndex: 15508
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _numInterval; // 0x18
	protected SimpleSafeUInt32 weightRawNum; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897B7530-0x00000001897B7550 */ get => default; /* [XID] */ /* 0x00000001897BF3F0-0x00000001897BF410 */ protected set {} } // 0x0000000182FAE850-0x0000000182FAE920 0x0000000182FAE170-0x0000000182FAE250
	public string numInterval { /* [XID] */ /* 0x00000001897C6B00-0x00000001897C6B20 */ get => default; /* [XID] */ /* 0x00000001897CE2A0-0x00000001897CE2C0 */ protected set {} } // 0x0000000182FAE0D0-0x0000000182FAE170 0x0000000182FAE660-0x0000000182FAE710
	public uint weight { /* [XID] */ /* 0x00000001897D5770-0x00000001897D5790 */ get => default; /* [XID] */ /* 0x00000001897DCEF0-0x00000001897DCF10 */ protected set {} } // 0x0000000182FAE920-0x0000000182FAE9F0 0x0000000182FADFF0-0x0000000182FAE0D0

	// Constructors
	public DropNode() {} // 0x0000000182FAEA90-0x0000000182FAEAF0

	// Methods
	// [XID] // 0x00000001897E4810-0x00000001897E4830
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182FADD50-0x0000000182FADFF0
	// [XID] // 0x00000001897EC440-0x00000001897EC460
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C9D */, bool useObjectPool = false /* Metadata: 0x00AF1CA1 */) => default; // 0x0000000182FAE250-0x0000000182FAE660
	[BlackList] // 0x00000001897F3D70-0x00000001897F3DB0
	// [XID] // 0x00000001897F3D70-0x00000001897F3DB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182FADBC0-0x0000000182FADC60
	[BlackList] // 0x00000001897FE060-0x00000001897FE0A0
	// [XID] // 0x00000001897FE060-0x00000001897FE0A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182FADC60-0x0000000182FADD50
	[BlackList] // 0x0000000189808820-0x0000000189808860
	// [XID] // 0x0000000189808820-0x0000000189808860
	public virtual void ReturnToObjectPool() {} // 0x0000000182FAE9F0-0x0000000182FAEA90
	[BlackList] // 0x0000000189812FA0-0x0000000189812FE0
	// [XID] // 0x0000000189812FA0-0x0000000189812FE0
	public virtual void OnPoolAllocated() {} // 0x0000000182FAE7B0-0x0000000182FAE850
	[BlackList] // 0x000000018981DA70-0x000000018981DAB0
	// [XID] // 0x000000018981DA70-0x000000018981DAB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182FAE710-0x0000000182FAE7B0
}

