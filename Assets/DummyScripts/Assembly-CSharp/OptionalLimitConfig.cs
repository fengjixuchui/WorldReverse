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
public class OptionalLimitConfig : IAutoAllocRecycle // TypeDefIndex: 15405
{
	// Fields
	protected bool _isUnlimited; // 0x10
	protected SimpleSafeUInt32 limitCountRawNum; // 0x14

	// Properties
	public bool isUnlimited { /* [XID] */ /* 0x0000000189AD7DE0-0x0000000189AD7E00 */ get => default; /* [XID] */ /* 0x0000000189ADF910-0x0000000189ADF930 */ protected set {} } // 0x0000000183B25890-0x0000000183B25930 0x0000000183B253D0-0x0000000183B25480
	public uint limitCount { /* [XID] */ /* 0x0000000189AE7030-0x0000000189AE7050 */ get => default; /* [XID] */ /* 0x0000000189AEEC40-0x0000000189AEEC60 */ protected set {} } // 0x0000000183B255A0-0x0000000183B25670 0x0000000183B25180-0x0000000183B25260

	// Constructors
	public OptionalLimitConfig() {} // 0x0000000183B25B10-0x0000000183B25B70

	// Methods
	// [XID] // 0x0000000189AF6190-0x0000000189AF61B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183B25480-0x0000000183B255A0
	// [XID] // 0x0000000189AFD7D0-0x0000000189AFD7F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1447 */, bool useObjectPool = false /* Metadata: 0x00AF144B */) => default; // 0x0000000183B25670-0x0000000183B25890
	[BlackList] // 0x0000000189B04E60-0x0000000189B04EA0
	// [XID] // 0x0000000189B04E60-0x0000000189B04EA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B25260-0x0000000183B25300
	[BlackList] // 0x0000000189B0F650-0x0000000189B0F690
	// [XID] // 0x0000000189B0F650-0x0000000189B0F690
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B25300-0x0000000183B253D0
	[BlackList] // 0x0000000189B198D0-0x0000000189B19910
	// [XID] // 0x0000000189B198D0-0x0000000189B19910
	public virtual void ReturnToObjectPool() {} // 0x0000000183B25A70-0x0000000183B25B10
	[BlackList] // 0x0000000189B241E0-0x0000000189B24220
	// [XID] // 0x0000000189B241E0-0x0000000189B24220
	public virtual void OnPoolAllocated() {} // 0x0000000183B259D0-0x0000000183B25A70
	[BlackList] // 0x0000000189B2E390-0x0000000189B2E3D0
	// [XID] // 0x0000000189B2E390-0x0000000189B2E3D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B25930-0x0000000183B259D0
}

