/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigEffectPool : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17919
{
	// Fields
	private SimpleSafeUInt32 particleSystemBudgetSizeRawNum; // 0x10
	private SimpleSafeUInt32 effectpoolBudgetSizeRawNum; // 0x14
	private SimpleSafeFloat releaseForBudgetTimeThresholdRawNum; // 0x18
	private SimpleSafeFloat releaseBudgetTimeThresholdPerFrameRawNum; // 0x1C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigEffectPoolItem> _poolItems; // 0x20

	// Properties
	public uint particleSystemBudgetSize { /* [XID] */ /* 0x00000001898F65E0-0x00000001898F6600 */ get => default; /* [XID] */ /* 0x00000001898FDD00-0x00000001898FDD20 */ private set {} } // 0x0000000181206B50-0x0000000181206C20 0x0000000181207E30-0x0000000181207F10
	public uint effectpoolBudgetSize { /* [XID] */ /* 0x0000000189AB9A90-0x0000000189AB9AB0 */ get => default; /* [XID] */ /* 0x000000018990CDB0-0x000000018990CDD0 */ private set {} } // 0x0000000181207520-0x00000001812075F0 0x0000000181207D50-0x0000000181207E30
	public float releaseForBudgetTimeThreshold { /* [XID] */ /* 0x00000001899145E0-0x0000000189914600 */ get => default; /* [XID] */ /* 0x000000018991C100-0x000000018991C120 */ private set {} } // 0x0000000181206880-0x0000000181206960 0x00000001812075F0-0x00000001812076D0
	public float releaseBudgetTimeThresholdPerFrame { /* [XID] */ /* 0x00000001899237A0-0x00000001899237C0 */ get => default; /* [XID] */ /* 0x000000018992AE60-0x000000018992AE80 */ private set {} } // 0x00000001812070C0-0x00000001812071A0 0x0000000181207BC0-0x0000000181207CA0
	public Dictionary<string, ConfigEffectPoolItem> poolItems { /* [XID] */ /* 0x00000001899324A0-0x00000001899324C0 */ get => default; /* [XID] */ /* 0x0000000189939EF0-0x0000000189939F10 */ private set {} } // 0x0000000181207B20-0x0000000181207BC0 0x0000000181207CA0-0x0000000181207D50

	// Constructors
	public ConfigEffectPool() {} // 0x00000001812086C0-0x0000000181208720

	// Methods
	// [XID] // 0x00000001899410E0-0x0000000189941100
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181208380-0x00000001812084E0
	// [XID] // 0x0000000189948BA0-0x0000000189948BC0
	public void InitEmpty() {} // 0x00000001812076D0-0x0000000181207820
	[BlackList] // 0x0000000189950330-0x0000000189950370
	// [XID] // 0x0000000189950330-0x0000000189950370
	public bool FromJson(JSONNode node) => default; // 0x00000001812071A0-0x0000000181207520
	// [XID] // 0x0000000189AAF480-0x0000000189AAF4A0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181205F70-0x00000001812065B0
	// [XID] // 0x0000000189962490-0x00000001899624B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF81FF */, bool useObjectPool = false /* Metadata: 0x00AF8203 */) => default; // 0x0000000181207820-0x0000000181207B20
	// [XID] // 0x0000000189969940-0x0000000189969960
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8204 */, bool useObjectPool = false /* Metadata: 0x00AF8208 */) => default; // 0x0000000181206C20-0x00000001812070C0
	[BlackList] // 0x00000001899716A0-0x00000001899716E0
	// [XID] // 0x00000001899716A0-0x00000001899716E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001812065B0-0x0000000181206880
	// [XID] // 0x000000018997B9A0-0x000000018997B9C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181207F10-0x0000000181208380
	[BlackList] // 0x0000000189983510-0x0000000189983550
	// [XID] // 0x0000000189983510-0x0000000189983550
	public virtual void AutoAllocTypeFields() {} // 0x0000000181206960-0x0000000181206A00
	[BlackList] // 0x000000018998DC20-0x000000018998DC60
	// [XID] // 0x000000018998DC20-0x000000018998DC60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181206A00-0x0000000181206B50
	[BlackList] // 0x00000001899987B0-0x00000001899987F0
	// [XID] // 0x00000001899987B0-0x00000001899987F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181208620-0x00000001812086C0
	[BlackList] // 0x00000001899A2FF0-0x00000001899A3030
	// [XID] // 0x00000001899A2FF0-0x00000001899A3030
	public virtual void OnPoolAllocated() {} // 0x0000000181208580-0x0000000181208620
	[BlackList] // 0x00000001899ADA00-0x00000001899ADA40
	// [XID] // 0x00000001899ADA00-0x00000001899ADA40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001812084E0-0x0000000181208580
}

