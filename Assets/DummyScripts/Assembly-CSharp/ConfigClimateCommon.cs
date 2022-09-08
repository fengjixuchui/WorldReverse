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
public class ConfigClimateCommon : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17650
{
	// Fields
	private SimpleSafeFloat lengthRawNum; // 0x10
	private SimpleSafeFloat thresholdRatioRawNum; // 0x14
	private Dictionary<JsonClimateType, SimpleSafeUInt32[]> _debuffs; // 0x18
	private Dictionary<JsonClimateType, SimpleSafeUInt32[]> _areaBuffs; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigClimateMisc _miscs; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigClimatePerform _perform; // 0x30
	private SimpleSafeFloat uiWarningRatioRawNum; // 0x38
	private SimpleSafeFloat uiLenWeakIntensityRawNum; // 0x3C
	private SimpleSafeFloat uiLenLerpSpeedRawNum; // 0x40

	// Properties
	public float length { /* [XID] */ /* 0x0000000189B33DE0-0x0000000189B33E00 */ get => default; /* [XID] */ /* 0x0000000189B3B710-0x0000000189B3B730 */ private set {} } // 0x0000000183352CD0-0x0000000183352DB0 0x0000000183352BF0-0x0000000183352CD0
	public float thresholdRatio { /* [XID] */ /* 0x0000000189B43110-0x0000000189B43130 */ get => default; /* [XID] */ /* 0x0000000189B4A950-0x0000000189B4A970 */ private set {} } // 0x0000000183353250-0x0000000183353330 0x0000000183353EA0-0x0000000183353F80
	public Dictionary<JsonClimateType, SimpleSafeUInt32[]> debuffs { /* [XID] */ /* 0x0000000189B52060-0x0000000189B52080 */ get => default; /* [XID] */ /* 0x0000000189B59980-0x0000000189B599A0 */ private set {} } // 0x0000000183352F40-0x0000000183352FE0 0x0000000183354410-0x00000001833544C0
	public Dictionary<JsonClimateType, SimpleSafeUInt32[]> areaBuffs { /* [XID] */ /* 0x0000000189B611B0-0x0000000189B611D0 */ get => default; /* [XID] */ /* 0x0000000189B68980-0x0000000189B689A0 */ private set {} } // 0x00000001833527D0-0x0000000183352870 0x0000000183352DB0-0x0000000183352E60
	public ConfigClimateMisc miscs { /* [XID] */ /* 0x0000000189B6FE80-0x0000000189B6FEA0 */ get => default; /* [XID] */ /* 0x0000000189B77330-0x0000000189B77350 */ private set {} } // 0x0000000183352000-0x00000001833520A0 0x00000001833542B0-0x0000000183354360
	public ConfigClimatePerform perform { /* [XID] */ /* 0x0000000189B7E960-0x0000000189B7E980 */ get => default; /* [XID] */ /* 0x0000000189B86620-0x0000000189B86640 */ private set {} } // 0x0000000183350E20-0x0000000183350EC0 0x0000000183354360-0x0000000183354410
	public float uiWarningRatio { /* [XID] */ /* 0x0000000189B8D750-0x0000000189B8D770 */ get => default; /* [XID] */ /* 0x0000000189B94D50-0x0000000189B94D70 */ private set {} } // 0x0000000183352E60-0x0000000183352F40 0x0000000183350EC0-0x0000000183350FA0
	public float uiLenWeakIntensity { /* [XID] */ /* 0x0000000189B9C480-0x0000000189B9C4A0 */ get => default; /* [XID] */ /* 0x0000000189BA3AB0-0x0000000189BA3AD0 */ private set {} } // 0x0000000183351F20-0x0000000183352000 0x0000000183353630-0x0000000183353710
	public float uiLenLerpSpeed { /* [XID] */ /* 0x0000000189BAAF40-0x0000000189BAAF60 */ get => default; /* [XID] */ /* 0x0000000189BB2550-0x0000000189BB2570 */ private set {} } // 0x0000000183353DC0-0x0000000183353EA0 0x0000000183352FE0-0x00000001833530C0

	// Constructors
	public ConfigClimateCommon() {} // 0x0000000183354560-0x0000000183354620

	// Methods
	// [XID] // 0x0000000189BB99A0-0x0000000189BB99C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183353F80-0x0000000183354170
	// [XID] // 0x0000000189BC18A0-0x0000000189BC18C0
	public void InitEmpty() {} // 0x00000001833530C0-0x0000000183353250
	[BlackList] // 0x0000000189BC8F20-0x0000000189BC8F60
	// [XID] // 0x0000000189BC8F20-0x0000000189BC8F60
	public bool FromJson(JSONNode node) => default; // 0x0000000183352870-0x0000000183352BF0
	// [XID] // 0x0000000189BD3710-0x0000000189BD3730
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183350FA0-0x0000000183351990
	// [XID] // 0x0000000189BDB020-0x0000000189BDB040
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF761B */, bool useObjectPool = false /* Metadata: 0x00AF761F */) => default; // 0x0000000183353330-0x0000000183353630
	// [XID] // 0x00000001895E7970-0x00000001895E7990
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7620 */, bool useObjectPool = false /* Metadata: 0x00AF7624 */) => default; // 0x00000001833520A0-0x00000001833527D0
	[BlackList] // 0x00000001895EF2A0-0x00000001895EF2E0
	// [XID] // 0x00000001895EF2A0-0x00000001895EF2E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183351990-0x0000000183351C60
	// [XID] // 0x00000001895F9A20-0x00000001895F9A40
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183353710-0x0000000183353DC0
	[BlackList] // 0x00000001896011A0-0x00000001896011E0
	// [XID] // 0x00000001896011A0-0x00000001896011E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183351C60-0x0000000183351D00
	[BlackList] // 0x000000018960BAC0-0x000000018960BB00
	// [XID] // 0x000000018960BAC0-0x000000018960BB00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183351D00-0x0000000183351F20
	[BlackList] // 0x00000001896160E0-0x0000000189616120
	// [XID] // 0x00000001896160E0-0x0000000189616120
	public virtual void ReturnToObjectPool() {} // 0x00000001833544C0-0x0000000183354560
	[BlackList] // 0x0000000189620960-0x00000001896209A0
	// [XID] // 0x0000000189620960-0x00000001896209A0
	public virtual void OnPoolAllocated() {} // 0x0000000183354210-0x00000001833542B0
	[BlackList] // 0x000000018962AFC0-0x000000018962B000
	// [XID] // 0x000000018962AFC0-0x000000018962B000
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183354170-0x0000000183354210
}

