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
public class FlightDailyInfo : IAutoAllocRecycle // TypeDefIndex: 15114
{
	// Fields
	protected SimpleSafeUInt32 watcherRawNum; // 0x10

	// Properties
	public uint watcher { /* [XID] */ /* 0x00000001899449A0-0x00000001899449C0 */ get => default; /* [XID] */ /* 0x000000018994BF80-0x000000018994BFA0 */ protected set {} } // 0x0000000184B33E10-0x0000000184B33EE0 0x0000000184B33A70-0x0000000184B33B50

	// Constructors
	public FlightDailyInfo() {} // 0x0000000184B340C0-0x0000000184B34120

	// Methods
	// [XID] // 0x0000000189953610-0x0000000189953630
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B338C0-0x0000000184B33A70
	// [XID] // 0x000000018995ADB0-0x000000018995ADD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0134 */, bool useObjectPool = false /* Metadata: 0x00AF0138 */) => default; // 0x0000000184B33B50-0x0000000184B33E10
	[BlackList] // 0x0000000189962A10-0x0000000189962A50
	// [XID] // 0x0000000189962A10-0x0000000189962A50
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B33750-0x0000000184B337F0
	[BlackList] // 0x000000018996CE90-0x000000018996CED0
	// [XID] // 0x000000018996CE90-0x000000018996CED0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B337F0-0x0000000184B338C0
	[BlackList] // 0x00000001899779C0-0x0000000189977A00
	// [XID] // 0x00000001899779C0-0x0000000189977A00
	public virtual void ReturnToObjectPool() {} // 0x0000000184B34020-0x0000000184B340C0
	[BlackList] // 0x0000000189982240-0x0000000189982280
	// [XID] // 0x0000000189982240-0x0000000189982280
	public virtual void OnPoolAllocated() {} // 0x0000000184B33F80-0x0000000184B34020
	[BlackList] // 0x000000018998C890-0x000000018998C8D0
	// [XID] // 0x000000018998C890-0x000000018998C8D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B33EE0-0x0000000184B33F80
}

