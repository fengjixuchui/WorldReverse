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
public class BlossomChestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15275
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 chest_gadget_idRawNum; // 0x14
	protected SimpleSafeUInt32 world_resinRawNum; // 0x18
	protected SimpleSafeUInt32 resinRawNum; // 0x1C
	protected BlossomRefreshType _refreshType; // 0x20
	protected BlossomChestShowType _clientShowType; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A78EE0-0x0000000189A78F00 */ get => default; /* [XID] */ /* 0x0000000189A80360-0x0000000189A80380 */ protected set {} } // 0x0000000182BF8A80-0x0000000182BF8B50 0x0000000182BF7CB0-0x0000000182BF7D90
	public uint chest_gadget_id { /* [XID] */ /* 0x0000000189A88100-0x0000000189A88120 */ get => default; /* [XID] */ /* 0x0000000189A8F9D0-0x0000000189A8F9F0 */ protected set {} } // 0x0000000182BF8530-0x0000000182BF8600 0x0000000182BF8600-0x0000000182BF86E0
	public uint world_resin { /* [XID] */ /* 0x0000000189A96FA0-0x0000000189A96FC0 */ get => default; /* [XID] */ /* 0x0000000189A9E3B0-0x0000000189A9E3D0 */ protected set {} } // 0x0000000182BF87C0-0x0000000182BF8890 0x0000000182BF8450-0x0000000182BF8530
	public uint resin { /* [XID] */ /* 0x0000000189AA5D60-0x0000000189AA5D80 */ get => default; /* [XID] */ /* 0x0000000189AAD3E0-0x0000000189AAD400 */ protected set {} } // 0x0000000182BF7D90-0x0000000182BF7E60 0x0000000182BF86E0-0x0000000182BF87C0
	public BlossomRefreshType refreshType { /* [XID] */ /* 0x0000000189AB4CF0-0x0000000189AB4D10 */ get => default; /* [XID] */ /* 0x0000000189ABCA00-0x0000000189ABCA20 */ protected set {} } // 0x0000000182BF7B60-0x0000000182BF7C00 0x0000000182BF7C00-0x0000000182BF7CB0
	public BlossomChestShowType clientShowType { /* [XID] */ /* 0x0000000189AC42E0-0x0000000189AC4300 */ get => default; /* [XID] */ /* 0x0000000189ACB870-0x0000000189ACB890 */ protected set {} } // 0x0000000182BF7220-0x0000000182BF72C0 0x0000000182BF8890-0x0000000182BF8940

	// Constructors
	public BlossomChestExcelConfig() {} // 0x0000000182BF8BF0-0x0000000182BF8C50

	// Methods
	// [IDTag] // 0x0000000189AD32A0-0x0000000189AD32E0
	// [XID] // 0x0000000189AD32A0-0x0000000189AD32E0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182BF72C0-0x0000000182BF7720
	// [IDTag] // 0x0000000189ADDFA0-0x0000000189ADDFE0
	// [XID] // 0x0000000189ADDFA0-0x0000000189ADDFE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182BF7720-0x0000000182BF7B60
	// [XID] // 0x0000000189AE8550-0x0000000189AE8570
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05FA */, bool useObjectPool = false /* Metadata: 0x00AF05FE */) => default; // 0x0000000182BF7E60-0x0000000182BF8450
	[BlackList] // 0x0000000189AF04D0-0x0000000189AF0510
	// [XID] // 0x0000000189AF04D0-0x0000000189AF0510
	public virtual void AutoAllocTypeFields() {} // 0x0000000182BF7070-0x0000000182BF7110
	[BlackList] // 0x0000000189AFAB80-0x0000000189AFABC0
	// [XID] // 0x0000000189AFAB80-0x0000000189AFABC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182BF7110-0x0000000182BF7220
	[BlackList] // 0x0000000189B04EE0-0x0000000189B04F20
	// [XID] // 0x0000000189B04EE0-0x0000000189B04F20
	public virtual void ReturnToObjectPool() {} // 0x0000000182BF8B50-0x0000000182BF8BF0
	[BlackList] // 0x0000000189B0F6D0-0x0000000189B0F710
	// [XID] // 0x0000000189B0F6D0-0x0000000189B0F710
	public virtual void OnPoolAllocated() {} // 0x0000000182BF89E0-0x0000000182BF8A80
	[BlackList] // 0x0000000189B19950-0x0000000189B19990
	// [XID] // 0x0000000189B19950-0x0000000189B19990
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182BF8940-0x0000000182BF89E0
}

