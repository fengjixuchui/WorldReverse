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
public class DungeonMapAreaExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15603
{
	// Fields
	protected SimpleSafeUInt32 dungeonIDRawNum; // 0x10
	protected SimpleSafeUInt32 areaIDRawNum; // 0x14

	// Properties
	public uint dungeonID { /* [XID] */ /* 0x000000018984B730-0x000000018984B750 */ get => default; /* [XID] */ /* 0x00000001898527E0-0x0000000189852800 */ protected set {} } // 0x00000001849FB990-0x00000001849FBA60 0x00000001849FB550-0x00000001849FB630
	public uint areaID { /* [XID] */ /* 0x000000018985A250-0x000000018985A270 */ get => default; /* [XID] */ /* 0x00000001898614B0-0x00000001898614D0 */ protected set {} } // 0x00000001849FB480-0x00000001849FB550 0x00000001849FB3A0-0x00000001849FB480

	// Constructors
	public DungeonMapAreaExcelConfig() {} // 0x00000001849FBC40-0x00000001849FBCA0

	// Methods
	// [IDTag] // 0x0000000189868C10-0x0000000189868C50
	// [XID] // 0x0000000189868C10-0x0000000189868C50
	public virtual bool ParseFromLine(string line) => default; // 0x00000001849FB130-0x00000001849FB3A0
	// [IDTag] // 0x0000000189872F70-0x0000000189872FB0
	// [XID] // 0x0000000189872F70-0x0000000189872FB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001849FAF10-0x00000001849FB130
	// [XID] // 0x000000018987DC00-0x000000018987DC20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF204C */, bool useObjectPool = false /* Metadata: 0x00AF2050 */) => default; // 0x00000001849FB630-0x00000001849FB990
	[BlackList] // 0x0000000189884B30-0x0000000189884B70
	// [XID] // 0x0000000189884B30-0x0000000189884B70
	public virtual void AutoAllocTypeFields() {} // 0x00000001849FAD90-0x00000001849FAE30
	[BlackList] // 0x000000018988F080-0x000000018988F0C0
	// [XID] // 0x000000018988F080-0x000000018988F0C0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001849FAE30-0x00000001849FAF10
	[BlackList] // 0x00000001898997F0-0x0000000189899830
	// [XID] // 0x00000001898997F0-0x0000000189899830
	public virtual void ReturnToObjectPool() {} // 0x00000001849FBBA0-0x00000001849FBC40
	[BlackList] // 0x00000001898A3C60-0x00000001898A3CA0
	// [XID] // 0x00000001898A3C60-0x00000001898A3CA0
	public virtual void OnPoolAllocated() {} // 0x00000001849FBB00-0x00000001849FBBA0
	[BlackList] // 0x00000001898AE3D0-0x00000001898AE410
	// [XID] // 0x00000001898AE3D0-0x00000001898AE410
	public virtual void OnBeforePoolRecycled() {} // 0x00000001849FBA60-0x00000001849FBB00
}

