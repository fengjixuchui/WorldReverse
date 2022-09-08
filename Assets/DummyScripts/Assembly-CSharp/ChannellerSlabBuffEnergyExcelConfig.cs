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
public class ChannellerSlabBuffEnergyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15045
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 avatarLevelRawNum; // 0x14
	protected SimpleSafeUInt32 singleEnergyRawNum; // 0x18
	protected SimpleSafeUInt32 mpEnergyRawNum; // 0x1C

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898A0A50-0x00000001898A0A70 */ get => default; /* [XID] */ /* 0x00000001898A80D0-0x00000001898A80F0 */ protected set {} } // 0x00000001842520A0-0x0000000184252170 0x0000000184251900-0x00000001842519E0
	public uint avatarLevel { /* [XID] */ /* 0x00000001898AFC30-0x00000001898AFC50 */ get => default; /* [XID] */ /* 0x00000001898B7130-0x00000001898B7150 */ protected set {} } // 0x00000001842510E0-0x00000001842511B0 0x0000000184250CA0-0x0000000184250D80
	public uint singleEnergy { /* [XID] */ /* 0x00000001898BE8A0-0x00000001898BE8C0 */ get => default; /* [XID] */ /* 0x00000001898C6070-0x00000001898C6090 */ protected set {} } // 0x00000001842519E0-0x0000000184251AB0 0x0000000184251000-0x00000001842510E0
	public uint mpEnergy { /* [XID] */ /* 0x00000001898CD800-0x00000001898CD820 */ get => default; /* [XID] */ /* 0x00000001898D5370-0x00000001898D5390 */ protected set {} } // 0x0000000184250F30-0x0000000184251000 0x0000000184251820-0x0000000184251900

	// Constructors
	public ChannellerSlabBuffEnergyExcelConfig() {} // 0x0000000184252210-0x0000000184252270

	// Methods
	// [IDTag] // 0x00000001898DCC50-0x00000001898DCC90
	// [XID] // 0x00000001898DCC50-0x00000001898DCC90
	public virtual bool ParseFromLine(string line) => default; // 0x00000001842511B0-0x0000000184251500
	// [IDTag] // 0x00000001898E7AD0-0x00000001898E7B10
	// [XID] // 0x00000001898E7AD0-0x00000001898E7B10
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184251500-0x0000000184251820
	// [XID] // 0x00000001898F21F0-0x00000001898F2210
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF50 */, bool useObjectPool = false /* Metadata: 0x00AEFF54 */) => default; // 0x0000000184251AB0-0x0000000184251F60
	[BlackList] // 0x00000001898F99D0-0x00000001898F9A10
	// [XID] // 0x00000001898F99D0-0x00000001898F9A10
	public virtual void AutoAllocTypeFields() {} // 0x0000000184250D80-0x0000000184250E20
	[BlackList] // 0x0000000189904310-0x0000000189904350
	// [XID] // 0x0000000189904310-0x0000000189904350
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184250E20-0x0000000184250F30
	[BlackList] // 0x000000018990EC90-0x000000018990ECD0
	// [XID] // 0x000000018990EC90-0x000000018990ECD0
	public virtual void ReturnToObjectPool() {} // 0x0000000184252170-0x0000000184252210
	[BlackList] // 0x00000001899195C0-0x0000000189919600
	// [XID] // 0x00000001899195C0-0x0000000189919600
	public virtual void OnPoolAllocated() {} // 0x0000000184252000-0x00000001842520A0
	[BlackList] // 0x0000000189923E80-0x0000000189923EC0
	// [XID] // 0x0000000189923E80-0x0000000189923EC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184251F60-0x0000000184252000
}

