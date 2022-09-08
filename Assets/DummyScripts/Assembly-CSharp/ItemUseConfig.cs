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
public class ItemUseConfig : IAutoAllocRecycle // TypeDefIndex: 15823
{
	// Fields
	protected ItemUseOp _useOp; // 0x10
	protected string[] _useParam; // 0x18

	// Properties
	public ItemUseOp useOp { /* [XID] */ /* 0x0000000189647B10-0x0000000189647B30 */ get => default; /* [XID] */ /* 0x000000018964F1C0-0x000000018964F1E0 */ protected set {} } // 0x0000000182E9C720-0x0000000182E9C7C0 0x0000000182E9CE60-0x0000000182E9CF10
	public string[] useParam { /* [XID] */ /* 0x0000000189656B30-0x0000000189656B50 */ get => default; /* [XID] */ /* 0x000000018965E210-0x000000018965E230 */ protected set {} } // 0x0000000182E9D100-0x0000000182E9D1A0 0x0000000182E9CF10-0x0000000182E9CFC0

	// Constructors
	public ItemUseConfig() {} // 0x0000000182E9D240-0x0000000182E9D2A0

	// Methods
	// [XID] // 0x0000000189665910-0x0000000189665930
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182E9C7C0-0x0000000182E9CAF0
	// [XID] // 0x000000018966D000-0x000000018966D020
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2777 */, bool useObjectPool = false /* Metadata: 0x00AF277B */) => default; // 0x0000000182E9CAF0-0x0000000182E9CE60
	[BlackList] // 0x0000000189674F10-0x0000000189674F50
	// [XID] // 0x0000000189674F10-0x0000000189674F50
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E9C5E0-0x0000000182E9C680
	[BlackList] // 0x000000018967F580-0x000000018967F5C0
	// [XID] // 0x000000018967F580-0x000000018967F5C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E9C680-0x0000000182E9C720
	[BlackList] // 0x000000018968A050-0x000000018968A090
	// [XID] // 0x000000018968A050-0x000000018968A090
	public virtual void ReturnToObjectPool() {} // 0x0000000182E9D1A0-0x0000000182E9D240
	[BlackList] // 0x0000000189694AE0-0x0000000189694B20
	// [XID] // 0x0000000189694AE0-0x0000000189694B20
	public virtual void OnPoolAllocated() {} // 0x0000000182E9D060-0x0000000182E9D100
	[BlackList] // 0x000000018969EFB0-0x000000018969EFF0
	// [XID] // 0x000000018969EFB0-0x000000018969EFF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E9CFC0-0x0000000182E9D060
}

