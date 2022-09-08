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
public class RoutineCondContent : IAutoAllocRecycle // TypeDefIndex: 16081
{
	// Fields
	protected RoutineCondType _type; // 0x10
	protected SimpleSafeUInt32 param1RawNum; // 0x14
	protected SimpleSafeUInt32 param2RawNum; // 0x18

	// Properties
	public RoutineCondType type { /* [XID] */ /* 0x000000018991C4E0-0x000000018991C500 */ get => default; /* [XID] */ /* 0x0000000189923C20-0x0000000189923C40 */ protected set {} } // 0x0000000181931260-0x0000000181931300 0x0000000181930F90-0x0000000181931040
	public uint param1 { /* [XID] */ /* 0x000000018992B280-0x000000018992B2A0 */ get => default; /* [XID] */ /* 0x0000000189932940-0x0000000189932960 */ protected set {} } // 0x0000000181930640-0x0000000181930710 0x00000001819309D0-0x0000000181930AB0
	public uint param2 { /* [XID] */ /* 0x000000018993A330-0x000000018993A350 */ get => default; /* [XID] */ /* 0x00000001899413E0-0x0000000189941400 */ protected set {} } // 0x0000000181930AB0-0x0000000181930B80 0x0000000181931040-0x0000000181931120

	// Constructors
	public RoutineCondContent() {} // 0x00000001819313A0-0x0000000181931400

	// Methods
	// [XID] // 0x0000000189948F80-0x0000000189948FA0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181930710-0x00000001819309D0
	// [XID] // 0x0000000189950730-0x0000000189950750
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2FB7 */, bool useObjectPool = false /* Metadata: 0x00AF2FBB */) => default; // 0x0000000181930B80-0x0000000181930F90
	[BlackList] // 0x0000000189957D40-0x0000000189957D80
	// [XID] // 0x0000000189957D40-0x0000000189957D80
	public virtual void AutoAllocTypeFields() {} // 0x00000001819304B0-0x0000000181930550
	[BlackList] // 0x0000000189962870-0x00000001899628B0
	// [XID] // 0x0000000189962870-0x00000001899628B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181930550-0x0000000181930640
	[BlackList] // 0x000000018996CC90-0x000000018996CCD0
	// [XID] // 0x000000018996CC90-0x000000018996CCD0
	public virtual void ReturnToObjectPool() {} // 0x0000000181931300-0x00000001819313A0
	[BlackList] // 0x0000000189977780-0x00000001899777C0
	// [XID] // 0x0000000189977780-0x00000001899777C0
	public virtual void OnPoolAllocated() {} // 0x00000001819311C0-0x0000000181931260
	[BlackList] // 0x0000000189982000-0x0000000189982040
	// [XID] // 0x0000000189982000-0x0000000189982040
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181931120-0x00000001819311C0
}

