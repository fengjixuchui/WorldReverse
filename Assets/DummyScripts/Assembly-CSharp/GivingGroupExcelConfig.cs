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
public class GivingGroupExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15673
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32[] _ItemIds; // 0x18
	protected SimpleSafeUInt32 finishTalkIdRawNum; // 0x20
	protected SimpleSafeUInt32 mistakeTalkIdRawNum; // 0x24

	// Properties
	public uint Id { /* [XID] */ /* 0x00000001899A8060-0x00000001899A8080 */ get => default; /* [XID] */ /* 0x00000001899AF6F0-0x00000001899AF710 */ protected set {} } // 0x00000001838989C0-0x0000000183898A90 0x00000001838990F0-0x00000001838991D0
	public SimpleSafeUInt32[] ItemIds { /* [XID] */ /* 0x00000001899B6BD0-0x00000001899B6BF0 */ get => default; /* [XID] */ /* 0x00000001899BE710-0x00000001899BE730 */ protected set {} } // 0x0000000183897C70-0x0000000183897D10 0x00000001838993E0-0x0000000183899490
	public uint finishTalkId { /* [XID] */ /* 0x00000001899C5F70-0x00000001899C5F90 */ get => default; /* [XID] */ /* 0x00000001899CD730-0x00000001899CD750 */ protected set {} } // 0x00000001838991D0-0x00000001838992A0 0x0000000183898B60-0x0000000183898C40
	public uint mistakeTalkId { /* [XID] */ /* 0x00000001899D4BD0-0x00000001899D4BF0 */ get => default; /* [XID] */ /* 0x00000001899DC270-0x00000001899DC290 */ protected set {} } // 0x0000000183898A90-0x0000000183898B60 0x0000000183897EB0-0x0000000183897F90

	// Constructors
	public GivingGroupExcelConfig() {} // 0x0000000183899530-0x0000000183899660

	// Methods
	// [IDTag] // 0x00000001899E3A70-0x00000001899E3AB0
	// [XID] // 0x00000001899E3A70-0x00000001899E3AB0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183897F90-0x00000001838984C0
	// [IDTag] // 0x00000001899EE140-0x00000001899EE180
	// [XID] // 0x00000001899EE140-0x00000001899EE180
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001838984C0-0x00000001838989C0
	// [XID] // 0x00000001899F8990-0x00000001899F89B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF229C */, bool useObjectPool = false /* Metadata: 0x00AF22A0 */) => default; // 0x0000000183898C40-0x00000001838990F0
	[BlackList] // 0x00000001899FFF00-0x00000001899FFF40
	// [XID] // 0x00000001899FFF00-0x00000001899FFF40
	public virtual void AutoAllocTypeFields() {} // 0x0000000183897D10-0x0000000183897DB0
	[BlackList] // 0x0000000189A0A5C0-0x0000000189A0A600
	// [XID] // 0x0000000189A0A5C0-0x0000000189A0A600
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183897DB0-0x0000000183897EB0
	[BlackList] // 0x0000000189A14E00-0x0000000189A14E40
	// [XID] // 0x0000000189A14E00-0x0000000189A14E40
	public virtual void ReturnToObjectPool() {} // 0x0000000183899490-0x0000000183899530
	[BlackList] // 0x0000000189A1F070-0x0000000189A1F0B0
	// [XID] // 0x0000000189A1F070-0x0000000189A1F0B0
	public virtual void OnPoolAllocated() {} // 0x0000000183899340-0x00000001838993E0
	[BlackList] // 0x0000000189A29500-0x0000000189A29540
	// [XID] // 0x0000000189A29500-0x0000000189A29540
	public virtual void OnBeforePoolRecycled() {} // 0x00000001838992A0-0x0000000183899340
}

