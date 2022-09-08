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
public class ForgeUpdateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15625
{
	// Fields
	protected SimpleSafeUInt32 playerLevelRawNum; // 0x10
	protected SimpleSafeUInt32 forgeQueueNumRawNum; // 0x14

	// Properties
	public uint playerLevel { /* [XID] */ /* 0x00000001897D8EF0-0x00000001897D8F10 */ get => default; /* [XID] */ /* 0x00000001897E00D0-0x00000001897E00F0 */ protected set {} } // 0x0000000182902930-0x0000000182902A00 0x0000000182902060-0x0000000182902140
	public uint forgeQueueNum { /* [XID] */ /* 0x00000001897E7770-0x00000001897E7790 */ get => default; /* [XID] */ /* 0x00000001897EF370-0x00000001897EF390 */ protected set {} } // 0x0000000182901F90-0x0000000182902060 0x0000000182902A00-0x0000000182902AE0

	// Constructors
	public ForgeUpdateExcelConfig() {} // 0x0000000182902CC0-0x0000000182902D20

	// Methods
	// [IDTag] // 0x00000001897F69A0-0x00000001897F69E0
	// [XID] // 0x00000001897F69A0-0x00000001897F69E0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182902360-0x00000001829025D0
	// [IDTag] // 0x00000001898013C0-0x0000000189801400
	// [XID] // 0x00000001898013C0-0x0000000189801400
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182902140-0x0000000182902360
	// [XID] // 0x000000018980B740-0x000000018980B760
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20F3 */, bool useObjectPool = false /* Metadata: 0x00AF20F7 */) => default; // 0x00000001829025D0-0x0000000182902930
	[BlackList] // 0x0000000189812F20-0x0000000189812F60
	// [XID] // 0x0000000189812F20-0x0000000189812F60
	public virtual void AutoAllocTypeFields() {} // 0x0000000182901E10-0x0000000182901EB0
	[BlackList] // 0x000000018981D9D0-0x000000018981DA10
	// [XID] // 0x000000018981D9D0-0x000000018981DA10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182901EB0-0x0000000182901F90
	[BlackList] // 0x0000000189828260-0x00000001898282A0
	// [XID] // 0x0000000189828260-0x00000001898282A0
	public virtual void ReturnToObjectPool() {} // 0x0000000182902C20-0x0000000182902CC0
	[BlackList] // 0x00000001898324F0-0x0000000189832530
	// [XID] // 0x00000001898324F0-0x0000000189832530
	public virtual void OnPoolAllocated() {} // 0x0000000182902B80-0x0000000182902C20
	[BlackList] // 0x000000018983CBF0-0x000000018983CC30
	// [XID] // 0x000000018983CBF0-0x000000018983CC30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182902AE0-0x0000000182902B80
}

