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
public class BlossomReviseExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15277
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _grade; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BA6D80-0x0000000189BA6DA0 */ get => default; /* [XID] */ /* 0x0000000189BADF40-0x0000000189BADF60 */ protected set {} } // 0x00000001839B1740-0x00000001839B1810 0x00000001839B11B0-0x00000001839B1290
	public SimpleSafeUInt32[] grade { /* [XID] */ /* 0x0000000189BB5810-0x0000000189BB5830 */ get => default; /* [XID] */ /* 0x0000000189BBCEE0-0x0000000189BBCF00 */ protected set {} } // 0x00000001839B1110-0x00000001839B11B0 0x00000001839B0990-0x00000001839B0A40

	// Constructors
	public BlossomReviseExcelConfig() {} // 0x00000001839B18B0-0x00000001839B1910

	// Methods
	// [IDTag] // 0x0000000189BC4B20-0x0000000189BC4B60
	// [XID] // 0x0000000189BC4B20-0x0000000189BC4B60
	public virtual bool ParseFromLine(string line) => default; // 0x00000001839B0D80-0x00000001839B1110
	// [IDTag] // 0x0000000189BCF470-0x0000000189BCF4B0
	// [XID] // 0x0000000189BCF470-0x0000000189BCF4B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839B0A40-0x00000001839B0D80
	// [XID] // 0x0000000189BD9A60-0x0000000189BD9A80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0609 */, bool useObjectPool = false /* Metadata: 0x00AF060D */) => default; // 0x00000001839B1290-0x00000001839B1600
	[BlackList] // 0x00000001895E6510-0x00000001895E6550
	// [XID] // 0x00000001895E6510-0x00000001895E6550
	public virtual void AutoAllocTypeFields() {} // 0x00000001839B0810-0x00000001839B08B0
	[BlackList] // 0x00000001895F0EA0-0x00000001895F0EE0
	// [XID] // 0x00000001895F0EA0-0x00000001895F0EE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839B08B0-0x00000001839B0990
	[BlackList] // 0x00000001895FB670-0x00000001895FB6B0
	// [XID] // 0x00000001895FB670-0x00000001895FB6B0
	public virtual void ReturnToObjectPool() {} // 0x00000001839B1810-0x00000001839B18B0
	[BlackList] // 0x0000000189605E90-0x0000000189605ED0
	// [XID] // 0x0000000189605E90-0x0000000189605ED0
	public virtual void OnPoolAllocated() {} // 0x00000001839B16A0-0x00000001839B1740
	[BlackList] // 0x0000000189610770-0x00000001896107B0
	// [XID] // 0x0000000189610770-0x00000001896107B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839B1600-0x00000001839B16A0
}

