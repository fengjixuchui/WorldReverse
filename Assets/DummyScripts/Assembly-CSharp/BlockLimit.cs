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
public class BlockLimit : IAutoAllocRecycle // TypeDefIndex: 15659
{
	// Fields
	protected SimpleSafeUInt32 blockIdRawNum; // 0x10
	protected SimpleSafeUInt32 countRawNum; // 0x14

	// Properties
	public uint blockId { /* [XID] */ /* 0x00000001898DE700-0x00000001898DE720 */ get => default; /* [XID] */ /* 0x00000001898E5EE0-0x00000001898E5F00 */ protected set {} } // 0x00000001822644F0-0x00000001822645C0 0x0000000182263F90-0x0000000182264070
	public uint count { /* [XID] */ /* 0x00000001898ED7C0-0x00000001898ED7E0 */ get => default; /* [XID] */ /* 0x00000001898F5080-0x00000001898F50A0 */ protected set {} } // 0x0000000182264920-0x00000001822649F0 0x0000000182264410-0x00000001822644F0

	// Constructors
	public BlockLimit() {} // 0x0000000182264BD0-0x0000000182264C30

	// Methods
	// [XID] // 0x00000001898FC810-0x00000001898FC830
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001822641F0-0x0000000182264410
	// [XID] // 0x0000000189904210-0x0000000189904230
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF221A */, bool useObjectPool = false /* Metadata: 0x00AF221E */) => default; // 0x00000001822645C0-0x0000000182264920
	[BlackList] // 0x000000018990B870-0x000000018990B8B0
	// [XID] // 0x000000018990B870-0x000000018990B8B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182264070-0x0000000182264110
	[BlackList] // 0x0000000189916220-0x0000000189916260
	// [XID] // 0x0000000189916220-0x0000000189916260
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182264110-0x00000001822641F0
	[BlackList] // 0x00000001899209B0-0x00000001899209F0
	// [XID] // 0x00000001899209B0-0x00000001899209F0
	public virtual void ReturnToObjectPool() {} // 0x0000000182264B30-0x0000000182264BD0
	[BlackList] // 0x000000018992B360-0x000000018992B3A0
	// [XID] // 0x000000018992B360-0x000000018992B3A0
	public virtual void OnPoolAllocated() {} // 0x0000000182264A90-0x0000000182264B30
	[BlackList] // 0x0000000189935670-0x00000001899356B0
	// [XID] // 0x0000000189935670-0x00000001899356B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001822649F0-0x0000000182264A90
}

