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
public class HomeWorldSpecialFurnitureExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15708
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeUInt32 furnitureIDRawNum; // 0x14
	protected SimpleSafeUInt32 sceneIDRawNum; // 0x18
	protected SimpleSafeUInt32[] _gadgetID; // 0x20

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189A014F0-0x0000000189A01510 */ get => default; /* [XID] */ /* 0x0000000189A08DF0-0x0000000189A08E10 */ protected set {} } // 0x00000001817280A0-0x0000000181728170 0x0000000181727300-0x00000001817273E0
	public uint furnitureID { /* [XID] */ /* 0x0000000189A103B0-0x0000000189A103D0 */ get => default; /* [XID] */ /* 0x0000000189A17970-0x0000000189A17990 */ protected set {} } // 0x00000001817273E0-0x00000001817274B0 0x0000000181727220-0x0000000181727300
	public uint sceneID { /* [XID] */ /* 0x0000000189A1F050-0x0000000189A1F070 */ get => default; /* [XID] */ /* 0x0000000189A26640-0x0000000189A26660 */ protected set {} } // 0x0000000181727FD0-0x00000001817280A0 0x0000000181727650-0x0000000181727730
	public SimpleSafeUInt32[] gadgetID { /* [XID] */ /* 0x0000000189A2D9B0-0x0000000189A2D9D0 */ get => default; /* [XID] */ /* 0x0000000189A35590-0x0000000189A355B0 */ protected set {} } // 0x00000001817286D0-0x0000000181728770 0x0000000181728620-0x00000001817286D0

	// Constructors
	public HomeWorldSpecialFurnitureExcelConfig() {} // 0x0000000181728950-0x00000001817289B0

	// Methods
	// [IDTag] // 0x0000000189A3CA00-0x0000000189A3CA40
	// [XID] // 0x0000000189A3CA00-0x0000000189A3CA40
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181727730-0x0000000181727BA0
	// [IDTag] // 0x0000000189A47310-0x0000000189A47350
	// [XID] // 0x0000000189A47310-0x0000000189A47350
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181727BA0-0x0000000181727FD0
	// [XID] // 0x0000000189A51AB0-0x0000000189A51AD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23D2 */, bool useObjectPool = false /* Metadata: 0x00AF23D6 */) => default; // 0x0000000181728170-0x0000000181728620
	[BlackList] // 0x0000000189A592A0-0x0000000189A592E0
	// [XID] // 0x0000000189A592A0-0x0000000189A592E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001817274B0-0x0000000181727550
	[BlackList] // 0x0000000189A63DD0-0x0000000189A63E10
	// [XID] // 0x0000000189A63DD0-0x0000000189A63E10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181727550-0x0000000181727650
	[BlackList] // 0x0000000189A6E500-0x0000000189A6E540
	// [XID] // 0x0000000189A6E500-0x0000000189A6E540
	public virtual void ReturnToObjectPool() {} // 0x00000001817288B0-0x0000000181728950
	[BlackList] // 0x0000000189A78DC0-0x0000000189A78E00
	// [XID] // 0x0000000189A78DC0-0x0000000189A78E00
	public virtual void OnPoolAllocated() {} // 0x0000000181728810-0x00000001817288B0
	[BlackList] // 0x0000000189A83760-0x0000000189A837A0
	// [XID] // 0x0000000189A83760-0x0000000189A837A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181728770-0x0000000181728810
}

