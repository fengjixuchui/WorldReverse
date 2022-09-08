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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class EffigyLimitingConditionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15081
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _descTextMapHash; // 0x14
	protected EffigyCondition _conditionType; // 0x18
	protected string _icon; // 0x20
	protected SimpleSafeUInt32 conditionParam1RawNum; // 0x28
	protected SimpleSafeUInt32 conditionParam2RawNum; // 0x2C
	protected SimpleSafeUInt32 exclusiveIdRawNum; // 0x30
	protected SimpleSafeInt32 scoreRawNum; // 0x34

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189829850-0x0000000189829870 */ get => default; /* [XID] */ /* 0x0000000189830DC0-0x0000000189830DE0 */ protected set {} } // 0x0000000184820020-0x00000001848200F0 0x000000018481F490-0x000000018481F570
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189838540-0x0000000189838560 */ get => default; /* [XID] */ /* 0x000000018983FBB0-0x000000018983FBD0 */ protected set {} } // 0x000000018481FD90-0x000000018481FE30 0x000000018481E370-0x000000018481E420
	public string desc { /* [XID] */ /* 0x0000000189847210-0x0000000189847230 */ get => default; } // 0x000000018481F190-0x000000018481F310 
	public EffigyCondition conditionType { /* [XID] */ /* 0x000000018984E8A0-0x000000018984E8C0 */ get => default; /* [XID] */ /* 0x00000001898558D0-0x00000001898558F0 */ protected set {} } // 0x000000018481F0F0-0x000000018481F190 0x000000018481F310-0x000000018481F3C0
	public string icon { /* [XID] */ /* 0x000000018985CD10-0x000000018985CD30 */ get => default; /* [XID] */ /* 0x00000001898646F0-0x0000000189864710 */ protected set {} } // 0x000000018481E010-0x000000018481E0B0 0x000000018481FE30-0x000000018481FEE0
	public uint conditionParam1 { /* [XID] */ /* 0x000000018986BCE0-0x000000018986BD00 */ get => default; /* [XID] */ /* 0x00000001898730B0-0x00000001898730D0 */ protected set {} } // 0x000000018481EE70-0x000000018481EF40 0x000000018481F010-0x000000018481F0F0
	public uint conditionParam2 { /* [XID] */ /* 0x000000018987AD90-0x000000018987ADB0 */ get => default; /* [XID] */ /* 0x0000000189881CA0-0x0000000189881CC0 */ protected set {} } // 0x000000018481EF40-0x000000018481F010 0x000000018481DE50-0x000000018481DF30
	public uint exclusiveId { /* [XID] */ /* 0x0000000189889460-0x0000000189889480 */ get => default; /* [XID] */ /* 0x0000000189890820-0x0000000189890840 */ protected set {} } // 0x000000018481E2A0-0x000000018481E370 0x000000018481FCB0-0x000000018481FD90
	public int score { /* [XID] */ /* 0x0000000189897D80-0x0000000189897DA0 */ get => default; /* [XID] */ /* 0x000000018989F120-0x000000018989F140 */ protected set {} } // 0x000000018481F3C0-0x000000018481F490 0x000000018481DF30-0x000000018481E010

	// Constructors
	public EffigyLimitingConditionExcelConfig() {} // 0x0000000184820190-0x00000001848201F0

	// Methods
	// [IDTag] // 0x00000001898A6CE0-0x00000001898A6D20
	// [XID] // 0x00000001898A6CE0-0x00000001898A6D20
	public virtual bool ParseFromLine(string line) => default; // 0x000000018481E940-0x000000018481EE70
	// [IDTag] // 0x00000001898B12E0-0x00000001898B1320
	// [XID] // 0x00000001898B12E0-0x00000001898B1320
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018481E420-0x000000018481E940
	// [XID] // 0x00000001898BBCB0-0x00000001898BBCD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0049 */, bool useObjectPool = false /* Metadata: 0x00AF004D */) => default; // 0x000000018481F570-0x000000018481FCB0
	[BlackList] // 0x00000001898C31A0-0x00000001898C31E0
	// [XID] // 0x00000001898C31A0-0x00000001898C31E0
	public virtual void AutoAllocTypeFields() {} // 0x000000018481E0B0-0x000000018481E150
	[BlackList] // 0x00000001898CD7C0-0x00000001898CD800
	// [XID] // 0x00000001898CD7C0-0x00000001898CD800
	public virtual void AutoRecycleTypeFields() {} // 0x000000018481E150-0x000000018481E2A0
	[BlackList] // 0x00000001898D8160-0x00000001898D81A0
	// [XID] // 0x00000001898D8160-0x00000001898D81A0
	public virtual void ReturnToObjectPool() {} // 0x00000001848200F0-0x0000000184820190
	[BlackList] // 0x00000001898E2DE0-0x00000001898E2E20
	// [XID] // 0x00000001898E2DE0-0x00000001898E2E20
	public virtual void OnPoolAllocated() {} // 0x000000018481FF80-0x0000000184820020
	[BlackList] // 0x00000001898ED920-0x00000001898ED960
	// [XID] // 0x00000001898ED920-0x00000001898ED960
	public virtual void OnBeforePoolRecycled() {} // 0x000000018481FEE0-0x000000018481FF80
}

