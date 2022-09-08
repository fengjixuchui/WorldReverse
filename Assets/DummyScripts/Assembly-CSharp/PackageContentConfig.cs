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
public class PackageContentConfig : IAutoAllocRecycle // TypeDefIndex: 16144
{
	// Fields
	protected SimpleSafeUInt32 materialIdRawNum; // 0x10
	protected SimpleSafeUInt32 materialNumRawNum; // 0x14

	// Properties
	public uint materialId { /* [XID] */ /* 0x0000000189A5F250-0x0000000189A5F270 */ get => default; /* [XID] */ /* 0x0000000189A66AE0-0x0000000189A66B00 */ protected set {} } // 0x0000000183B95D00-0x0000000183B95DD0 0x0000000183B95C20-0x0000000183B95D00
	public uint materialNum { /* [XID] */ /* 0x0000000189A6E440-0x0000000189A6E460 */ get => default; /* [XID] */ /* 0x0000000189A75B10-0x0000000189A75B30 */ protected set {} } // 0x0000000183B95EB0-0x0000000183B95F80 0x0000000183B95DD0-0x0000000183B95EB0

	// Constructors
	public PackageContentConfig() {} // 0x0000000183B964C0-0x0000000183B96520

	// Methods
	// [XID] // 0x0000000189A7D730-0x0000000189A7D750
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183B95A00-0x0000000183B95C20
	// [XID] // 0x0000000189A84EC0-0x0000000189A84EE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3263 */, bool useObjectPool = false /* Metadata: 0x00AF3267 */) => default; // 0x0000000183B95F80-0x0000000183B962E0
	[BlackList] // 0x0000000189A8C810-0x0000000189A8C850
	// [XID] // 0x0000000189A8C810-0x0000000189A8C850
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B95880-0x0000000183B95920
	[BlackList] // 0x0000000189A96D80-0x0000000189A96DC0
	// [XID] // 0x0000000189A96D80-0x0000000189A96DC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B95920-0x0000000183B95A00
	[BlackList] // 0x0000000189AA10A0-0x0000000189AA10E0
	// [XID] // 0x0000000189AA10A0-0x0000000189AA10E0
	public virtual void ReturnToObjectPool() {} // 0x0000000183B96420-0x0000000183B964C0
	[BlackList] // 0x0000000189AABA10-0x0000000189AABA50
	// [XID] // 0x0000000189AABA10-0x0000000189AABA50
	public virtual void OnPoolAllocated() {} // 0x0000000183B96380-0x0000000183B96420
	[BlackList] // 0x0000000189AB63E0-0x0000000189AB6420
	// [XID] // 0x0000000189AB63E0-0x0000000189AB6420
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B962E0-0x0000000183B96380
}

