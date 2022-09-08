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
public class SceneExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16088
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SceneType _type; // 0x14
	protected string _scriptData; // 0x18
	protected string _overrideDefaultProfile; // 0x20
	protected string _levelEntityConfig; // 0x28
	protected SimpleSafeUInt32 entityAppearSortedRawNum; // 0x30
	protected SimpleSafeUInt32[] _specifiedAvatarList; // 0x38
	protected SimpleSafeUInt32 maxSpecifiedAvatarNumRawNum; // 0x40
	protected string _comment; // 0x48

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AA5BC0-0x0000000189AA5BE0 */ get => default; /* [XID] */ /* 0x0000000189AAD200-0x0000000189AAD220 */ protected set {} } // 0x0000000183E7CDC0-0x0000000183E7CE90 0x0000000183E7C0E0-0x0000000183E7C1C0
	public SceneType type { /* [XID] */ /* 0x0000000189AAD9E0-0x0000000189AADA00 */ get => default; /* [XID] */ /* 0x0000000189ABC8E0-0x0000000189ABC900 */ protected set {} } // 0x0000000183E7CF40-0x0000000183E7CFE0 0x0000000183E7CA90-0x0000000183E7CB40
	public string scriptData { /* [XID] */ /* 0x0000000189AC41C0-0x0000000189AC41E0 */ get => default; /* [XID] */ /* 0x0000000189ACB710-0x0000000189ACB730 */ protected set {} } // 0x0000000183E7C040-0x0000000183E7C0E0 0x0000000183E7BC90-0x0000000183E7BD40
	public string overrideDefaultProfile { /* [XID] */ /* 0x0000000189AD3160-0x0000000189AD3180 */ get => default; /* [XID] */ /* 0x0000000189ADAB80-0x0000000189ADABA0 */ protected set {} } // 0x0000000183E7CBE0-0x0000000183E7CC80 0x0000000183E7AD80-0x0000000183E7AE30
	public string levelEntityConfig { /* [XID] */ /* 0x0000000189860470-0x0000000189860490 */ get => default; /* [XID] */ /* 0x0000000189AE9CB0-0x0000000189AE9CD0 */ protected set {} } // 0x0000000183E7CB40-0x0000000183E7CBE0 0x0000000183E7AA50-0x0000000183E7AB00
	public uint entityAppearSorted { /* [XID] */ /* 0x0000000189AF1A30-0x0000000189AF1A50 */ get => default; /* [XID] */ /* 0x0000000189AF91F0-0x0000000189AF9210 */ protected set {} } // 0x0000000183E7AB00-0x0000000183E7ABD0 0x0000000183E7C9B0-0x0000000183E7CA90
	public SimpleSafeUInt32[] specifiedAvatarList { /* [XID] */ /* 0x0000000189B00710-0x0000000189B00730 */ get => default; /* [XID] */ /* 0x0000000189B07D10-0x0000000189B07D30 */ protected set {} } // 0x0000000183E7A9B0-0x0000000183E7AA50 0x0000000183E7CE90-0x0000000183E7CF40
	public uint maxSpecifiedAvatarNum { /* [XID] */ /* 0x0000000189B0F570-0x0000000189B0F590 */ get => default; /* [XID] */ /* 0x0000000189B16830-0x0000000189B16850 */ protected set {} } // 0x0000000183E7BDF0-0x0000000183E7BEC0 0x0000000183E7BEC0-0x0000000183E7BFA0
	public string comment { /* [XID] */ /* 0x0000000189B1DF50-0x0000000189B1DF70 */ get => default; /* [XID] */ /* 0x0000000189B257C0-0x0000000189B257E0 */ protected set {} } // 0x0000000183E7BFA0-0x0000000183E7C040 0x0000000183E7BD40-0x0000000183E7BDF0

	// Constructors
	public SceneExcelConfig() {} // 0x0000000183E7D080-0x0000000183E7D0E0

	// Methods
	// [IDTag] // 0x0000000189B2CC70-0x0000000189B2CCB0
	// [XID] // 0x0000000189B2CC70-0x0000000189B2CCB0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183E7B560-0x0000000183E7BC90
	// [IDTag] // 0x0000000189B37270-0x0000000189B372B0
	// [XID] // 0x0000000189B37270-0x0000000189B372B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183E7AE30-0x0000000183E7B560
	// [XID] // 0x0000000189B41DD0-0x0000000189B41DF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2FEB */, bool useObjectPool = false /* Metadata: 0x00AF2FEF */) => default; // 0x0000000183E7C1C0-0x0000000183E7C9B0
	[BlackList] // 0x0000000189B49720-0x0000000189B49760
	// [XID] // 0x0000000189B49720-0x0000000189B49760
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E7ABD0-0x0000000183E7AC70
	[BlackList] // 0x0000000189B53BA0-0x0000000189B53BE0
	// [XID] // 0x0000000189B53BA0-0x0000000189B53BE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E7AC70-0x0000000183E7AD80
	[BlackList] // 0x0000000189B5E6C0-0x0000000189B5E700
	// [XID] // 0x0000000189B5E6C0-0x0000000189B5E700
	public virtual void ReturnToObjectPool() {} // 0x0000000183E7CFE0-0x0000000183E7D080
	[BlackList] // 0x0000000189B68DC0-0x0000000189B68E00
	// [XID] // 0x0000000189B68DC0-0x0000000189B68E00
	public virtual void OnPoolAllocated() {} // 0x0000000183E7CD20-0x0000000183E7CDC0
	[BlackList] // 0x0000000189B73130-0x0000000189B73170
	// [XID] // 0x0000000189B73130-0x0000000189B73170
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E7CC80-0x0000000183E7CD20
}

