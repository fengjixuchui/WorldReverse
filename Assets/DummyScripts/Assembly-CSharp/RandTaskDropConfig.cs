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
public class RandTaskDropConfig : IAutoAllocRecycle // TypeDefIndex: 16000
{
	// Fields
	protected SimpleSafeUInt32 dropIdRawNum; // 0x10

	// Properties
	public uint dropId { /* [XID] */ /* 0x0000000189B4AC90-0x0000000189B4ACB0 */ get => default; /* [XID] */ /* 0x0000000189B522C0-0x0000000189B522E0 */ protected set {} } // 0x0000000181D672A0-0x0000000181D67370 0x0000000181D67630-0x0000000181D67710

	// Constructors
	public RandTaskDropConfig() {} // 0x0000000181D678F0-0x0000000181D67950

	// Methods
	// [XID] // 0x0000000189B59C80-0x0000000189B59CA0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181D670F0-0x0000000181D672A0
	// [XID] // 0x0000000189B61390-0x0000000189B613B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D63 */, bool useObjectPool = false /* Metadata: 0x00AF2D67 */) => default; // 0x0000000181D67370-0x0000000181D67630
	[BlackList] // 0x0000000189B68E00-0x0000000189B68E40
	// [XID] // 0x0000000189B68E00-0x0000000189B68E40
	public virtual void AutoAllocTypeFields() {} // 0x0000000181D66F80-0x0000000181D67020
	[BlackList] // 0x0000000189B73190-0x0000000189B731D0
	// [XID] // 0x0000000189B73190-0x0000000189B731D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181D67020-0x0000000181D670F0
	[BlackList] // 0x0000000189B7D660-0x0000000189B7D6A0
	// [XID] // 0x0000000189B7D660-0x0000000189B7D6A0
	public virtual void ReturnToObjectPool() {} // 0x0000000181D67850-0x0000000181D678F0
	[BlackList] // 0x0000000189B88000-0x0000000189B88040
	// [XID] // 0x0000000189B88000-0x0000000189B88040
	public virtual void OnPoolAllocated() {} // 0x0000000181D677B0-0x0000000181D67850
	[BlackList] // 0x0000000189B92160-0x0000000189B921A0
	// [XID] // 0x0000000189B92160-0x0000000189B921A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181D67710-0x0000000181D677B0
}

