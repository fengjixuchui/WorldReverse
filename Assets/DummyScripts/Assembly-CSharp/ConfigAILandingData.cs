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
public class ConfigAILandingData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17478
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat landingAngleMaxRawNum; // 0x14
	private SimpleSafeFloat landingAngleMinRawNum; // 0x18
	private SimpleSafeFloat landingTerrainAltitudeRawNum; // 0x1C

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189737720-0x0000000189737740 */ get => default; /* [XID] */ /* 0x000000018973F220-0x000000018973F240 */ private set {} } // 0x0000000182A93440-0x0000000182A93510 0x0000000182A93510-0x0000000182A935F0
	public float landingAngleMax { /* [XID] */ /* 0x00000001897464C0-0x00000001897464E0 */ get => default; /* [XID] */ /* 0x000000018974DF50-0x000000018974DF70 */ private set {} } // 0x0000000182A92EC0-0x0000000182A92FA0 0x0000000182A93E80-0x0000000182A93F60
	public float landingAngleMin { /* [XID] */ /* 0x00000001897556F0-0x0000000189755710 */ get => default; /* [XID] */ /* 0x000000018975C930-0x000000018975C950 */ private set {} } // 0x0000000182A94470-0x0000000182A94550 0x0000000182A93940-0x0000000182A93A20
	public float landingTerrainAltitude { /* [XID] */ /* 0x0000000189764160-0x0000000189764180 */ get => default; /* [XID] */ /* 0x000000018976BA20-0x000000018976BA40 */ private set {} } // 0x0000000182A93DA0-0x0000000182A93E80 0x0000000182A94390-0x0000000182A94470

	// Constructors
	public ConfigAILandingData() {} // 0x0000000182A94C00-0x0000000182A94CF0

	// Methods
	// [XID] // 0x0000000189772E40-0x0000000189772E60
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A948E0-0x0000000182A94A20
	// [XID] // 0x000000018977A540-0x000000018977A560
	public void InitEmpty() {} // 0x0000000182A93F60-0x0000000182A94090
	[BlackList] // 0x0000000189782100-0x0000000189782140
	// [XID] // 0x0000000189782100-0x0000000189782140
	public bool FromJson(JSONNode node) => default; // 0x0000000182A93A20-0x0000000182A93DA0
	// [XID] // 0x000000018978C550-0x000000018978C570
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182A929B0-0x0000000182A92EC0
	// [XID] // 0x0000000189793A40-0x0000000189793A60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FFD */, bool useObjectPool = false /* Metadata: 0x00AF7001 */) => default; // 0x0000000182A94090-0x0000000182A94390
	// [XID] // 0x000000018979BCB0-0x000000018979BCD0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7002 */, bool useObjectPool = false /* Metadata: 0x00AF7006 */) => default; // 0x0000000182A935F0-0x0000000182A93940
	[BlackList] // 0x00000001897A3160-0x00000001897A31A0
	// [XID] // 0x00000001897A3160-0x00000001897A31A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A92FA0-0x0000000182A93270
	// [XID] // 0x00000001897AD8B0-0x00000001897AD8D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A94550-0x0000000182A948E0
	[BlackList] // 0x00000001897B59B0-0x00000001897B59F0
	// [XID] // 0x00000001897B59B0-0x00000001897B59F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182A93270-0x0000000182A93310
	[BlackList] // 0x00000001897C0780-0x00000001897C07C0
	// [XID] // 0x00000001897C0780-0x00000001897C07C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182A93310-0x0000000182A93440
	[BlackList] // 0x00000001897CAD30-0x00000001897CAD70
	// [XID] // 0x00000001897CAD30-0x00000001897CAD70
	public virtual void ReturnToObjectPool() {} // 0x0000000182A94B60-0x0000000182A94C00
	[BlackList] // 0x00000001897D53B0-0x00000001897D53F0
	// [XID] // 0x00000001897D53B0-0x00000001897D53F0
	public virtual void OnPoolAllocated() {} // 0x0000000182A94AC0-0x0000000182A94B60
	[BlackList] // 0x00000001897DFCB0-0x00000001897DFCF0
	// [XID] // 0x00000001897DFCB0-0x00000001897DFCF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182A94A20-0x0000000182A94AC0
}

