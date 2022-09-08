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
public class CombineUnlockConfig : IAutoAllocRecycle // TypeDefIndex: 15338
{
	// Fields
	protected CombineUnlockMethod _unlockMethod; // 0x10
	protected string[] _unlockParam; // 0x18

	// Properties
	public CombineUnlockMethod unlockMethod { /* [XID] */ /* 0x00000001898646B0-0x00000001898646D0 */ get => default; /* [XID] */ /* 0x000000018986BC60-0x000000018986BC80 */ protected set {} } // 0x00000001841658D0-0x0000000184165970 0x0000000184165D40-0x0000000184165DF0
	public string[] unlockParam { /* [XID] */ /* 0x0000000189872FF0-0x0000000189873010 */ get => default; /* [XID] */ /* 0x000000018987AD10-0x000000018987AD30 */ protected set {} } // 0x0000000184165CA0-0x0000000184165D40 0x00000001841656E0-0x0000000184165790

	// Constructors
	public CombineUnlockConfig() {} // 0x0000000184166340-0x00000001841663A0

	// Methods
	// [XID] // 0x0000000189881C60-0x0000000189881C80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184165970-0x0000000184165CA0
	// [XID] // 0x00000001898893E0-0x0000000189889400
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07F7 */, bool useObjectPool = false /* Metadata: 0x00AF07FB */) => default; // 0x0000000184165DF0-0x0000000184166160
	[BlackList] // 0x0000000189890780-0x00000001898907C0
	// [XID] // 0x0000000189890780-0x00000001898907C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184165790-0x0000000184165830
	[BlackList] // 0x000000018989AE70-0x000000018989AEB0
	// [XID] // 0x000000018989AE70-0x000000018989AEB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184165830-0x00000001841658D0
	[BlackList] // 0x00000001898A5520-0x00000001898A5560
	// [XID] // 0x00000001898A5520-0x00000001898A5560
	public virtual void ReturnToObjectPool() {} // 0x00000001841662A0-0x0000000184166340
	[BlackList] // 0x00000001898AFB50-0x00000001898AFB90
	// [XID] // 0x00000001898AFB50-0x00000001898AFB90
	public virtual void OnPoolAllocated() {} // 0x0000000184166200-0x00000001841662A0
	[BlackList] // 0x00000001898BA640-0x00000001898BA680
	// [XID] // 0x00000001898BA640-0x00000001898BA680
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184166160-0x0000000184166200
}

