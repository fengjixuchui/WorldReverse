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
public class DropSubfieldEntry : IAutoAllocRecycle // TypeDefIndex: 15509
{
	// Fields
	protected string _name; // 0x10
	protected SimpleSafeUInt32 dropSubfieldIdRawNum; // 0x18

	// Properties
	public string name { /* [XID] */ /* 0x000000018982F520-0x000000018982F540 */ get => default; /* [XID] */ /* 0x0000000189836DD0-0x0000000189836DF0 */ protected set {} } // 0x00000001827ACA10-0x00000001827ACAB0 0x00000001827AC3D0-0x00000001827AC480
	public uint dropSubfieldId { /* [XID] */ /* 0x000000018983E220-0x000000018983E240 */ get => default; /* [XID] */ /* 0x00000001898459D0-0x00000001898459F0 */ protected set {} } // 0x00000001827AC0D0-0x00000001827AC1A0 0x00000001827AC7F0-0x00000001827AC8D0

	// Constructors
	public DropSubfieldEntry() {} // 0x00000001827ACB50-0x00000001827ACBB0

	// Methods
	// [XID] // 0x000000018984CFC0-0x000000018984CFE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001827AC1A0-0x00000001827AC3D0
	// [XID] // 0x0000000189854060-0x0000000189854080
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1CA2 */, bool useObjectPool = false /* Metadata: 0x00AF1CA6 */) => default; // 0x00000001827AC480-0x00000001827AC7F0
	[BlackList] // 0x000000018985BA70-0x000000018985BAB0
	// [XID] // 0x000000018985BA70-0x000000018985BAB0
	public virtual void AutoAllocTypeFields() {} // 0x00000001827ABF50-0x00000001827ABFF0
	[BlackList] // 0x0000000189865BF0-0x0000000189865C30
	// [XID] // 0x0000000189865BF0-0x0000000189865C30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001827ABFF0-0x00000001827AC0D0
	[BlackList] // 0x0000000189870060-0x00000001898700A0
	// [XID] // 0x0000000189870060-0x00000001898700A0
	public virtual void ReturnToObjectPool() {} // 0x00000001827ACAB0-0x00000001827ACB50
	[BlackList] // 0x000000018987AC90-0x000000018987ACD0
	// [XID] // 0x000000018987AC90-0x000000018987ACD0
	public virtual void OnPoolAllocated() {} // 0x00000001827AC970-0x00000001827ACA10
	[BlackList] // 0x0000000189884B90-0x0000000189884BD0
	// [XID] // 0x0000000189884B90-0x0000000189884BD0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001827AC8D0-0x00000001827AC970
}

