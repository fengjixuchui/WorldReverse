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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class FixedBool : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14786
{
	// Fields
	private bool _value; // 0x10

	// Properties
	public bool value { /* [XID] */ /* 0x0000000189B8DD10-0x0000000189B8DD30 */ get => default; /* [XID] */ /* 0x0000000189B95210-0x0000000189B95230 */ set {} } // 0x0000000182C02800-0x0000000182C028A0 0x0000000182C02750-0x0000000182C02800

	// Constructors
	public FixedBool() {} // 0x0000000182C02DF0-0x0000000182C02E50

	// Methods
	// [XID] // 0x0000000189B77A10-0x0000000189B77A30
	public bool FromJson(JSONNode node) => default; // 0x0000000182C028A0-0x0000000182C029A0
	// [XID] // 0x000000018986AC40-0x000000018986AC60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF5A1 */, bool useObjectPool = false /* Metadata: 0x00AEF5A5 */) => default; // 0x0000000182C02A40-0x0000000182C02B60
	// [XID] // 0x0000000189B86C20-0x0000000189B86C40
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C02520-0x0000000182C02610
	// [XID] // 0x0000000189B9C880-0x0000000189B9C8A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C02B60-0x0000000182C02C10
	// [XID] // 0x0000000189BA3FB0-0x0000000189BA3FD0
	public void InitEmpty() {} // 0x0000000182C029A0-0x0000000182C02A40
	[BlackList] // 0x0000000189BAB4E0-0x0000000189BAB520
	// [XID] // 0x0000000189BAB4E0-0x0000000189BAB520
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C02610-0x0000000182C026B0
	[BlackList] // 0x0000000189BB5950-0x0000000189BB5990
	// [XID] // 0x0000000189BB5950-0x0000000189BB5990
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C026B0-0x0000000182C02750
	[BlackList] // 0x0000000189BBFF90-0x0000000189BBFFD0
	// [XID] // 0x0000000189BBFF90-0x0000000189BBFFD0
	public virtual void ReturnToObjectPool() {} // 0x0000000182C02D50-0x0000000182C02DF0
	[BlackList] // 0x0000000189BCAFB0-0x0000000189BCAFF0
	// [XID] // 0x0000000189BCAFB0-0x0000000189BCAFF0
	public virtual void OnPoolAllocated() {} // 0x0000000182C02CB0-0x0000000182C02D50
	[BlackList] // 0x0000000189BD53B0-0x0000000189BD53F0
	// [XID] // 0x0000000189BD53B0-0x0000000189BD53F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C02C10-0x0000000182C02CB0
}

