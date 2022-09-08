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
public class ConfigAISpacialProbeData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17466
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x14
	private SimpleSafeFloat cdMaxRawNum; // 0x18
	private SimpleSafeFloat cdMinRawNum; // 0x1C
	private SimpleSafeFloat terrainOffsetMinRawNum; // 0x20
	private SimpleSafeFloat terrainOffsetMaxRawNum; // 0x24
	private SimpleSafeFloat distanceFromBornRawNum; // 0x28
	private SimpleSafeFloat distanceFromCurrentMinRawNum; // 0x2C
	private SimpleSafeFloat distanceFromCurrentMaxRawNum; // 0x30
	private SimpleSafeInt32 probeNumberMinRawNum; // 0x34
	private SimpleSafeInt32 probeNumberMaxRawNum; // 0x38

	// Properties
	public int speedLevel { /* [XID] */ /* 0x00000001896FEDF0-0x00000001896FEE10 */ get => default; /* [XID] */ /* 0x0000000189706040-0x0000000189706060 */ private set {} } // 0x000000018578EC10-0x000000018578ECE0 0x000000018578EF70-0x000000018578F050
	public float turnSpeedOverride { /* [XID] */ /* 0x000000018970D8D0-0x000000018970D8F0 */ get => default; /* [XID] */ /* 0x0000000189714D50-0x0000000189714D70 */ private set {} } // 0x000000018578EDB0-0x000000018578EE90 0x000000018578F9C0-0x000000018578FAA0
	public float cdMax { /* [XID] */ /* 0x000000018971C820-0x000000018971C840 */ get => default; /* [XID] */ /* 0x0000000189723C70-0x0000000189723C90 */ private set {} } // 0x00000001857900C0-0x00000001857901A0 0x000000018578F720-0x000000018578F800
	public float cdMin { /* [XID] */ /* 0x000000018972B3B0-0x000000018972B3D0 */ get => default; /* [XID] */ /* 0x0000000189732BC0-0x0000000189732BE0 */ private set {} } // 0x000000018578FF00-0x000000018578FFE0 0x000000018578E8E0-0x000000018578E9C0
	public float terrainOffsetMin { /* [XID] */ /* 0x000000018973A2D0-0x000000018973A2F0 */ get => default; /* [XID] */ /* 0x0000000189741D60-0x0000000189741D80 */ private set {} } // 0x000000018578EE90-0x000000018578EF70 0x0000000185791670-0x0000000185791750
	public float terrainOffsetMax { /* [XID] */ /* 0x0000000189749760-0x0000000189749780 */ get => default; /* [XID] */ /* 0x0000000189750C20-0x0000000189750C40 */ private set {} } // 0x0000000185790800-0x00000001857908E0 0x000000018578D9B0-0x000000018578DA90
	public float distanceFromBorn { /* [XID] */ /* 0x0000000189758010-0x0000000189758030 */ get => default; /* [XID] */ /* 0x000000018975FB90-0x000000018975FBB0 */ private set {} } // 0x000000018578F800-0x000000018578F8E0 0x000000018578FFE0-0x00000001857900C0
	public float distanceFromCurrentMin { /* [XID] */ /* 0x0000000189767220-0x0000000189767240 */ get => default; /* [XID] */ /* 0x000000018976E6C0-0x000000018976E6E0 */ private set {} } // 0x000000018578F8E0-0x000000018578F9C0 0x0000000185791260-0x0000000185791340
	public float distanceFromCurrentMax { /* [XID] */ /* 0x0000000189776120-0x0000000189776140 */ get => default; /* [XID] */ /* 0x000000018977D780-0x000000018977D7A0 */ private set {} } // 0x000000018578FE20-0x000000018578FF00 0x00000001857908E0-0x00000001857909C0
	public int probeNumberMin { /* [XID] */ /* 0x0000000189785060-0x0000000189785080 */ get => default; /* [XID] */ /* 0x000000018978C570-0x000000018978C590 */ private set {} } // 0x00000001857901A0-0x0000000185790270 0x0000000185790270-0x0000000185790350
	public int probeNumberMax { /* [XID] */ /* 0x0000000189793A60-0x0000000189793A80 */ get => default; /* [XID] */ /* 0x000000018979BCD0-0x000000018979BCF0 */ private set {} } // 0x000000018578ECE0-0x000000018578EDB0 0x00000001857909C0-0x0000000185790AA0

	// Constructors
	public ConfigAISpacialProbeData() {} // 0x00000001857917F0-0x0000000185791960

	// Methods
	// [XID] // 0x00000001897A31A0-0x00000001897A31C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185791340-0x0000000185791530
	// [XID] // 0x00000001897AA7A0-0x00000001897AA7C0
	public void InitEmpty() {} // 0x0000000185790350-0x0000000185790500
	[BlackList] // 0x00000001897B2210-0x00000001897B2250
	// [XID] // 0x00000001897B2210-0x00000001897B2250
	public bool FromJson(JSONNode node) => default; // 0x000000018578FAA0-0x000000018578FE20
	// [XID] // 0x00000001897BD700-0x00000001897BD720
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018578DA90-0x000000018578E610
	// [XID] // 0x00000001897C4AE0-0x00000001897C4B00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F95 */, bool useObjectPool = false /* Metadata: 0x00AF6F99 */) => default; // 0x0000000185790500-0x0000000185790800
	// [XID] // 0x00000001897CC370-0x00000001897CC390
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F9A */, bool useObjectPool = false /* Metadata: 0x00AF6F9E */) => default; // 0x000000018578F050-0x000000018578F720
	[BlackList] // 0x00000001897D3CA0-0x00000001897D3CE0
	// [XID] // 0x00000001897D3CA0-0x00000001897D3CE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018578E610-0x000000018578E8E0
	// [XID] // 0x00000001897DE370-0x00000001897DE390
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185790AA0-0x0000000185791260
	[BlackList] // 0x00000001897E5DF0-0x00000001897E5E30
	// [XID] // 0x00000001897E5DF0-0x00000001897E5E30
	public virtual void AutoAllocTypeFields() {} // 0x000000018578E9C0-0x000000018578EA60
	[BlackList] // 0x00000001897F09A0-0x00000001897F09E0
	// [XID] // 0x00000001897F09A0-0x00000001897F09E0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018578EA60-0x000000018578EC10
	[BlackList] // 0x00000001897FB3B0-0x00000001897FB3F0
	// [XID] // 0x00000001897FB3B0-0x00000001897FB3F0
	public virtual void ReturnToObjectPool() {} // 0x0000000185791750-0x00000001857917F0
	[BlackList] // 0x00000001898054B0-0x00000001898054F0
	// [XID] // 0x00000001898054B0-0x00000001898054F0
	public virtual void OnPoolAllocated() {} // 0x00000001857915D0-0x0000000185791670
	[BlackList] // 0x000000018980FF30-0x000000018980FF70
	// [XID] // 0x000000018980FF30-0x000000018980FF70
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185791530-0x00000001857915D0
}

