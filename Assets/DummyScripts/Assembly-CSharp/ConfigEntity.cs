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
public class ConfigEntity : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14930
{
	// Fields
	public bool fromPool; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEntityCommon _common; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigHeadControl _headControl; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEntityPoint _specialPoint; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCustomAttackShape _customAttackShape; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigModel _model; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigDither _dither; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalValue _globalValue; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEntityTags _entityTags; // 0x50

	// Properties
	public ConfigEntityCommon common { /* [XID] */ /* 0x000000018998B840-0x000000018998B860 */ get => default; /* [XID] */ /* 0x00000001896C0BA0-0x00000001896C0BC0 */ private set {} } // 0x00000001840A24A0-0x00000001840A2540 0x00000001840A0470-0x00000001840A0520
	public ConfigHeadControl headControl { /* [XID] */ /* 0x00000001896C8270-0x00000001896C8290 */ get => default; /* [XID] */ /* 0x00000001896CFC30-0x00000001896CFC50 */ private set {} } // 0x00000001840A2400-0x00000001840A24A0 0x00000001840A1400-0x00000001840A14B0
	public ConfigEntityPoint specialPoint { /* [XID] */ /* 0x00000001896D6E60-0x00000001896D6E80 */ get => default; /* [XID] */ /* 0x00000001896DE6A0-0x00000001896DE6C0 */ private set {} } // 0x00000001840A0BD0-0x00000001840A0C70 0x00000001840A0B20-0x00000001840A0BD0
	public ConfigCustomAttackShape customAttackShape { /* [XID] */ /* 0x00000001896E5A10-0x00000001896E5A30 */ get => default; /* [XID] */ /* 0x00000001896ED080-0x00000001896ED0A0 */ private set {} } // 0x000000018409FC10-0x000000018409FCB0 0x00000001840A08A0-0x00000001840A0950
	public ConfigModel model { /* [XID] */ /* 0x00000001896F48E0-0x00000001896F4900 */ get => default; /* [XID] */ /* 0x00000001896FC170-0x00000001896FC190 */ private set {} } // 0x000000018409FB70-0x000000018409FC10 0x000000018409F470-0x000000018409F520
	public ConfigDither dither { /* [XID] */ /* 0x00000001897D2DA0-0x00000001897D2DC0 */ get => default; /* [XID] */ /* 0x000000018970AD80-0x000000018970ADA0 */ private set {} } // 0x00000001840A18F0-0x00000001840A1990 0x00000001840A12A0-0x00000001840A1350
	public ConfigGlobalValue globalValue { /* [XID] */ /* 0x0000000189665FE0-0x0000000189666000 */ get => default; /* [XID] */ /* 0x0000000189719EB0-0x0000000189719ED0 */ private set {} } // 0x00000001840A1990-0x00000001840A1A30 0x00000001840A1350-0x00000001840A1400
	public ConfigEntityTags entityTags { /* [XID] */ /* 0x00000001897213D0-0x00000001897213F0 */ get => default; /* [XID] */ /* 0x00000001897289B0-0x00000001897289D0 */ private set {} } // 0x00000001840A16B0-0x00000001840A1750 0x000000018409FAC0-0x000000018409FB70

	// Constructors
	public ConfigEntity() {} // 0x00000001840A25E0-0x00000001840A2650

	// Methods
	// [XID] // 0x00000001897301E0-0x0000000189730200
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840A20A0-0x00000001840A22C0
	// [XID] // 0x0000000189737BA0-0x0000000189737BC0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001840A1750-0x00000001840A18F0
	// [XID] // 0x000000018973F6E0-0x000000018973F700
	public virtual ConfigEntity Clone(bool useObjectPool = false /* Metadata: 0x00AEFA65 */) => default; // 0x00000001840A11C0-0x00000001840A12A0
	// [XID] // 0x0000000189746A60-0x0000000189746A80
	public virtual int GetHashNum() => default; // 0x000000018409F9F0-0x000000018409FAC0
	// [XID] // 0x000000018974E3F0-0x000000018974E410
	public virtual void InitEmpty() {} // 0x00000001840A0C70-0x00000001840A0DD0
	[BlackList] // 0x0000000189755A70-0x0000000189755AB0
	// [XID] // 0x0000000189755A70-0x0000000189755AB0
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001840A0520-0x00000001840A08A0
	// [XID] // 0x000000018975FF70-0x000000018975FF90
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018409E930-0x000000018409F1A0
	[BlackList] // 0x0000000189767540-0x0000000189767580
	// [XID] // 0x0000000189767540-0x0000000189767580
	public static ConfigEntity ParseFromJson(JSONNode node) => default; // 0x00000001840A14B0-0x00000001840A16B0
	// [XID] // 0x0000000189771D50-0x0000000189771D70
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA66 */, bool useObjectPool = false /* Metadata: 0x00AEFA6A */) => default; // 0x00000001840A0EC0-0x00000001840A11C0
	// [XID] // 0x00000001897794A0-0x00000001897794C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA6B */, bool useObjectPool = false /* Metadata: 0x00AEFA6F */) => default; // 0x000000018409FCB0-0x00000001840A0470
	// [XID] // 0x0000000189780DA0-0x0000000189780DC0
	public static ConfigEntity ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA70 */, bool useObjectPool = false /* Metadata: 0x00AEFA74 */) => default; // 0x00000001840A0950-0x00000001840A0B20
	[BlackList] // 0x0000000189788300-0x0000000189788340
	// [XID] // 0x0000000189788300-0x0000000189788340
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018409F1A0-0x000000018409F470
	// [XID] // 0x0000000189792A00-0x0000000189792A20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840A1A30-0x00000001840A20A0
	[BlackList] // 0x0000000189799F70-0x0000000189799FB0
	// [XID] // 0x0000000189799F70-0x0000000189799FB0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001840A0DD0-0x00000001840A0EC0
	[BlackList] // 0x00000001897A50D0-0x00000001897A5110
	// [XID] // 0x00000001897A50D0-0x00000001897A5110
	public virtual void AutoAllocTypeFields() {} // 0x000000018409F520-0x000000018409F5C0
	[BlackList] // 0x00000001897AF7B0-0x00000001897AF7F0
	// [XID] // 0x00000001897AF7B0-0x00000001897AF7F0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018409F5C0-0x000000018409F9F0
	[BlackList] // 0x00000001897B9FF0-0x00000001897BA030
	// [XID] // 0x00000001897B9FF0-0x00000001897BA030
	public virtual void ReturnToObjectPool() {} // 0x00000001840A2540-0x00000001840A25E0
	[BlackList] // 0x00000001897C5080-0x00000001897C50C0
	// [XID] // 0x00000001897C5080-0x00000001897C50C0
	public virtual void OnPoolAllocated() {} // 0x00000001840A2360-0x00000001840A2400
	[BlackList] // 0x00000001897CF950-0x00000001897CF990
	// [XID] // 0x00000001897CF950-0x00000001897CF990
	public virtual void OnBeforePoolRecycled() {} // 0x00000001840A22C0-0x00000001840A2360
}

