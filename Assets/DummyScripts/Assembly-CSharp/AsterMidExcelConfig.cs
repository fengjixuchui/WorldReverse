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
public class AsterMidExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15015
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _camp_vec; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AA2CA0-0x0000000189AA2CC0 */ get => default; /* [XID] */ /* 0x0000000189AAA220-0x0000000189AAA240 */ protected set {} } // 0x00000001830388D0-0x00000001830389A0 0x00000001830382A0-0x0000000183038380
	public SimpleSafeUInt32[] camp_vec { /* [XID] */ /* 0x0000000189AB2080-0x0000000189AB20A0 */ get => default; /* [XID] */ /* 0x0000000189AB92F0-0x0000000189AB9310 */ protected set {} } // 0x00000001830386F0-0x0000000183038790 0x00000001830381F0-0x00000001830382A0

	// Constructors
	public AsterMidExcelConfig() {} // 0x0000000183038A40-0x0000000183038AA0

	// Methods
	// [IDTag] // 0x0000000189AC0EF0-0x0000000189AC0F30
	// [XID] // 0x0000000189AC0EF0-0x0000000189AC0F30
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183037DC0-0x00000001830381F0
	// [IDTag] // 0x0000000189ACB8D0-0x0000000189ACB910
	// [XID] // 0x0000000189ACB8D0-0x0000000189ACB910
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001830379D0-0x0000000183037DC0
	// [XID] // 0x0000000189AD6780-0x0000000189AD67A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE85 */, bool useObjectPool = false /* Metadata: 0x00AEFE89 */) => default; // 0x0000000183038380-0x00000001830386F0
	[BlackList] // 0x0000000189ADE0A0-0x0000000189ADE0E0
	// [XID] // 0x0000000189ADE0A0-0x0000000189ADE0E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183037850-0x00000001830378F0
	[BlackList] // 0x0000000189AE85F0-0x0000000189AE8630
	// [XID] // 0x0000000189AE85F0-0x0000000189AE8630
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830378F0-0x00000001830379D0
	[BlackList] // 0x0000000189AF33D0-0x0000000189AF3410
	// [XID] // 0x0000000189AF33D0-0x0000000189AF3410
	public virtual void ReturnToObjectPool() {} // 0x00000001830389A0-0x0000000183038A40
	[BlackList] // 0x0000000189AFD830-0x0000000189AFD870
	// [XID] // 0x0000000189AFD830-0x0000000189AFD870
	public virtual void OnPoolAllocated() {} // 0x0000000183038830-0x00000001830388D0
	[BlackList] // 0x0000000189B07F10-0x0000000189B07F50
	// [XID] // 0x0000000189B07F10-0x0000000189B07F50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183038790-0x0000000183038830
}

