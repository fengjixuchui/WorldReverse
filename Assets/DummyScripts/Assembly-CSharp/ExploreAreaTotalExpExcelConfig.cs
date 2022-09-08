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
public class ExploreAreaTotalExpExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15601
{
	// Fields
	protected SimpleSafeUInt32 areaIDRawNum; // 0x10
	protected SimpleSafeUInt32 totalExpRawNum; // 0x14

	// Properties
	public uint areaID { /* [XID] */ /* 0x0000000189758430-0x0000000189758450 */ get => default; /* [XID] */ /* 0x000000018975FE90-0x000000018975FEB0 */ protected set {} } // 0x0000000183072240-0x0000000183072310 0x0000000183072160-0x0000000183072240
	public uint totalExp { /* [XID] */ /* 0x00000001897674A0-0x00000001897674C0 */ get => default; /* [XID] */ /* 0x000000018976EA60-0x000000018976EA80 */ protected set {} } // 0x0000000183072890-0x0000000183072960 0x0000000183072670-0x0000000183072750

	// Constructors
	public ExploreAreaTotalExpExcelConfig() {} // 0x0000000183072A00-0x0000000183072A60

	// Methods
	// [IDTag] // 0x00000001897764E0-0x0000000189776520
	// [XID] // 0x00000001897764E0-0x0000000189776520
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183071CD0-0x0000000183071F40
	// [IDTag] // 0x0000000189780C00-0x0000000189780C40
	// [XID] // 0x0000000189780C00-0x0000000189780C40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183071F40-0x0000000183072160
	// [XID] // 0x000000018978B400-0x000000018978B420
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF203D */, bool useObjectPool = false /* Metadata: 0x00AF2041 */) => default; // 0x0000000183072310-0x0000000183072670
	[BlackList] // 0x0000000189792880-0x00000001897928C0
	// [XID] // 0x0000000189792880-0x00000001897928C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183071B50-0x0000000183071BF0
	[BlackList] // 0x000000018979DBF0-0x000000018979DC30
	// [XID] // 0x000000018979DBF0-0x000000018979DC30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183071BF0-0x0000000183071CD0
	[BlackList] // 0x00000001897A7B80-0x00000001897A7BC0
	// [XID] // 0x00000001897A7B80-0x00000001897A7BC0
	public virtual void ReturnToObjectPool() {} // 0x0000000183072960-0x0000000183072A00
	[BlackList] // 0x00000001897B26B0-0x00000001897B26F0
	// [XID] // 0x00000001897B26B0-0x00000001897B26F0
	public virtual void OnPoolAllocated() {} // 0x00000001830727F0-0x0000000183072890
	[BlackList] // 0x00000001897BDB60-0x00000001897BDBA0
	// [XID] // 0x00000001897BDB60-0x00000001897BDBA0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183072750-0x00000001830727F0
}

