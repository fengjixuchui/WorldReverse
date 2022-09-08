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
public class DungeonSerialConfig : IAutoAllocRecycle // TypeDefIndex: 15556
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 MaxTakeNumRawNum; // 0x14
	protected SimpleSafeUInt32 takeCostRawNum; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897A4F90-0x00000001897A4FB0 */ get => default; /* [XID] */ /* 0x00000001897AC520-0x00000001897AC540 */ protected set {} } // 0x00000001810FF350-0x00000001810FF420 0x00000001810FEC40-0x00000001810FED20
	public uint MaxTakeNum { /* [XID] */ /* 0x00000001897B44B0-0x00000001897B44D0 */ get => default; /* [XID] */ /* 0x00000001897BC250-0x00000001897BC270 */ protected set {} } // 0x00000001810FEA90-0x00000001810FEB60 0x00000001810FF130-0x00000001810FF210
	public uint takeCost { /* [XID] */ /* 0x00000001897C3910-0x00000001897C3930 */ get => default; /* [XID] */ /* 0x00000001897CB050-0x00000001897CB070 */ protected set {} } // 0x00000001810FE9C0-0x00000001810FEA90 0x00000001810FEB60-0x00000001810FEC40

	// Constructors
	public DungeonSerialConfig() {} // 0x00000001810FF4C0-0x00000001810FF520

	// Methods
	// [IDTag] // 0x00000001897D2750-0x00000001897D2790
	// [XID] // 0x00000001897D2750-0x00000001897D2790
	public virtual bool ParseFromLine(string line) => default; // 0x00000001810FE440-0x00000001810FE720
	// [IDTag] // 0x00000001897DCEB0-0x00000001897DCEF0
	// [XID] // 0x00000001897DCEB0-0x00000001897DCEF0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001810FE720-0x00000001810FE9C0
	// [XID] // 0x00000001897E7790-0x00000001897E77B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1EFD */, bool useObjectPool = false /* Metadata: 0x00AF1F01 */) => default; // 0x00000001810FED20-0x00000001810FF130
	[BlackList] // 0x00000001897EF390-0x00000001897EF3D0
	// [XID] // 0x00000001897EF390-0x00000001897EF3D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001810FE2B0-0x00000001810FE350
	[BlackList] // 0x00000001897F9E60-0x00000001897F9EA0
	// [XID] // 0x00000001897F9E60-0x00000001897F9EA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001810FE350-0x00000001810FE440
	[BlackList] // 0x0000000189804350-0x0000000189804390
	// [XID] // 0x0000000189804350-0x0000000189804390
	public virtual void ReturnToObjectPool() {} // 0x00000001810FF420-0x00000001810FF4C0
	[BlackList] // 0x000000018980E8F0-0x000000018980E930
	// [XID] // 0x000000018980E8F0-0x000000018980E930
	public virtual void OnPoolAllocated() {} // 0x00000001810FF2B0-0x00000001810FF350
	[BlackList] // 0x0000000189819450-0x0000000189819490
	// [XID] // 0x0000000189819450-0x0000000189819490
	public virtual void OnBeforePoolRecycled() {} // 0x00000001810FF210-0x00000001810FF2B0
}

