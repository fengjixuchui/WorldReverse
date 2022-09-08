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
public class EntityMultiPlayerExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15332
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected EntityPropPerMpConfig[] _propPerVec; // 0x18
	protected SimpleSafeUInt32[] _endureNumVec; // 0x20
	protected SimpleSafeFloat[] _elementShieldPerVec; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189736040-0x0000000189736060 */ get => default; /* [XID] */ /* 0x000000018973DD10-0x000000018973DD30 */ protected set {} } // 0x0000000183EB72D0-0x0000000183EB73A0 0x0000000183EB6B60-0x0000000183EB6C40
	public EntityPropPerMpConfig[] propPerVec { /* [XID] */ /* 0x00000001897450F0-0x0000000189745110 */ get => default; /* [XID] */ /* 0x000000018974CBE0-0x000000018974CC00 */ protected set {} } // 0x0000000183EB59D0-0x0000000183EB5A70 0x0000000183EB5920-0x0000000183EB59D0
	public SimpleSafeUInt32[] endureNumVec { /* [XID] */ /* 0x00000001896F17F0-0x00000001896F1810 */ get => default; /* [XID] */ /* 0x000000018975B460-0x000000018975B480 */ protected set {} } // 0x0000000183EB5A70-0x0000000183EB5B10 0x0000000183EB6AB0-0x0000000183EB6B60
	public SimpleSafeFloat[] elementShieldPerVec { /* [XID] */ /* 0x0000000189762E70-0x0000000189762E90 */ get => default; /* [XID] */ /* 0x000000018976A4B0-0x000000018976A4D0 */ protected set {} } // 0x0000000183EB70F0-0x0000000183EB7190 0x0000000183EB73A0-0x0000000183EB7450

	// Constructors
	public EntityMultiPlayerExcelConfig() {} // 0x0000000183EB74F0-0x0000000183EB7550

	// Methods
	// [IDTag] // 0x0000000189771C50-0x0000000189771C90
	// [XID] // 0x0000000189771C50-0x0000000189771C90
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183EB5B10-0x0000000183EB6320
	// [IDTag] // 0x000000018977C240-0x000000018977C280
	// [XID] // 0x000000018977C240-0x000000018977C280
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183EB6320-0x0000000183EB6AB0
	// [XID] // 0x0000000189786A20-0x0000000189786A40
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07CC */, bool useObjectPool = false /* Metadata: 0x00AF07D0 */) => default; // 0x0000000183EB6C40-0x0000000183EB70F0
	[BlackList] // 0x000000018978E130-0x000000018978E170
	// [XID] // 0x000000018978E130-0x000000018978E170
	public virtual void AutoAllocTypeFields() {} // 0x0000000183EB57A0-0x0000000183EB5840
	[BlackList] // 0x0000000189798840-0x0000000189798880
	// [XID] // 0x0000000189798840-0x0000000189798880
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183EB5840-0x0000000183EB5920
	[BlackList] // 0x00000001897A3620-0x00000001897A3660
	// [XID] // 0x00000001897A3620-0x00000001897A3660
	public virtual void ReturnToObjectPool() {} // 0x0000000183EB7450-0x0000000183EB74F0
	[BlackList] // 0x00000001897ADC70-0x00000001897ADCB0
	// [XID] // 0x00000001897ADC70-0x00000001897ADCB0
	public virtual void OnPoolAllocated() {} // 0x0000000183EB7230-0x0000000183EB72D0
	[BlackList] // 0x00000001897B8A40-0x00000001897B8A80
	// [XID] // 0x00000001897B8A40-0x00000001897B8A80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183EB7190-0x0000000183EB7230
}

