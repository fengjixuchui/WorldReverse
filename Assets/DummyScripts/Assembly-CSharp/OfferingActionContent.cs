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
public class OfferingActionContent : IAutoAllocRecycle // TypeDefIndex: 15917
{
	// Fields
	protected OfferingActionType _actionType; // 0x10
	protected string _param; // 0x18

	// Properties
	public OfferingActionType actionType { /* [XID] */ /* 0x00000001899AC910-0x00000001899AC930 */ get => default; /* [XID] */ /* 0x00000001899B4100-0x00000001899B4120 */ protected set {} } // 0x000000018505FDA0-0x000000018505FE40 0x000000018505F740-0x000000018505F7F0
	public string param { /* [XID] */ /* 0x00000001899BB570-0x00000001899BB590 */ get => default; /* [XID] */ /* 0x00000001899C3140-0x00000001899C3160 */ protected set {} } // 0x0000000185060030-0x00000001850600D0 0x000000018505FF80-0x0000000185060030

	// Constructors
	public OfferingActionContent() {} // 0x0000000185060170-0x00000001850601D0

	// Methods
	// [XID] // 0x00000001899CA560-0x00000001899CA580
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018505F7F0-0x000000018505FA30
	// [XID] // 0x00000001899D1CE0-0x00000001899D1D00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B20 */, bool useObjectPool = false /* Metadata: 0x00AF2B24 */) => default; // 0x000000018505FA30-0x000000018505FDA0
	[BlackList] // 0x00000001899D9150-0x00000001899D9190
	// [XID] // 0x00000001899D9150-0x00000001899D9190
	public virtual void AutoAllocTypeFields() {} // 0x000000018505F600-0x000000018505F6A0
	[BlackList] // 0x00000001899E3A30-0x00000001899E3A70
	// [XID] // 0x00000001899E3A30-0x00000001899E3A70
	public virtual void AutoRecycleTypeFields() {} // 0x000000018505F6A0-0x000000018505F740
	[BlackList] // 0x00000001899EE0C0-0x00000001899EE100
	// [XID] // 0x00000001899EE0C0-0x00000001899EE100
	public virtual void ReturnToObjectPool() {} // 0x00000001850600D0-0x0000000185060170
	[BlackList] // 0x00000001899F88B0-0x00000001899F88F0
	// [XID] // 0x00000001899F88B0-0x00000001899F88F0
	public virtual void OnPoolAllocated() {} // 0x000000018505FEE0-0x000000018505FF80
	[BlackList] // 0x0000000189A02FB0-0x0000000189A02FF0
	// [XID] // 0x0000000189A02FB0-0x0000000189A02FF0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018505FE40-0x000000018505FEE0
}

