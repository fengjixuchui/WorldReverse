/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct ConfigShadowQualitySetting : IEmptyInitable, IHashable // TypeDefIndex: 18172
{
	// Fields
	private SimpleSafeInt32 shadowDistanceRawNum; // 0x00
	private ConfigShadowResolution _shadowResolution; // 0x04
	private SimpleSafeInt32 shadowCascadeSplitCountRawNum; // 0x08
	private SimpleSafeInt32 perObjShadowQualityRawNum; // 0x0C
	private bool _shadowBlend; // 0x10
	private bool _PerObjectPCF; // 0x11
	private bool _enableDynamicShadow; // 0x12

	// Properties
	public int shadowDistance { /* [XID] */ /* 0x000000018972CAE0-0x000000018972CB00 */ get => default; /* [XID] */ /* 0x0000000189734230-0x0000000189734250 */ private set {} } // 0x0000000183528D50-0x0000000183528E30 0x00000001835290E0-0x0000000183529650
	public ConfigShadowResolution shadowResolution { /* [XID] */ /* 0x000000018973BA70-0x000000018973BA90 */ get => default; /* [XID] */ /* 0x0000000189743470-0x0000000189743490 */ private set {} } // 0x0000000183529960-0x0000000183529A20 0x0000000183527850-0x0000000183527940
	public int shadowCascadeSplitCount { /* [XID] */ /* 0x000000018974B040-0x000000018974B060 */ get => default; /* [XID] */ /* 0x00000001897520F0-0x0000000189752110 */ private set {} } // 0x00000001835281E0-0x0000000183528570 0x0000000183529B10-0x0000000183529B20
	public int perObjShadowQuality { /* [XID] */ /* 0x0000000189759740-0x0000000189759760 */ get => default; /* [XID] */ /* 0x0000000189761370-0x0000000189761390 */ private set {} } // 0x0000000183528E30-0x0000000183528FE0 0x0000000183527940-0x00000001835279E0
	public bool shadowBlend { /* [XID] */ /* 0x00000001897686C0-0x00000001897686E0 */ get => default; /* [XID] */ /* 0x000000018976FD50-0x000000018976FD70 */ private set {} } // 0x00000001835287B0-0x0000000183528870 0x0000000183529A20-0x0000000183529B10
	public bool PerObjectPCF { /* [XID] */ /* 0x0000000189777510-0x0000000189777530 */ get => default; /* [XID] */ /* 0x000000018977EC40-0x000000018977EC60 */ private set {} } // 0x0000000183528700-0x00000001835287B0 0x0000000183529710-0x00000001835298B0
	public bool enableDynamicShadow { /* [XID] */ /* 0x0000000189786560-0x0000000189786580 */ get => default; /* [XID] */ /* 0x000000018978DC30-0x000000018978DC50 */ private set {} } // 0x0000000183527A90-0x0000000183527FE0 0x0000000183526D50-0x00000001835274B0

	// Methods
	// [IDTag] // 0x0000000189795200-0x0000000189795240
	// [XID] // 0x0000000189795200-0x0000000189795240
	public bool Equals(ConfigShadowQualitySetting otherVal) => default; // 0x0000000183528FE0-0x00000001835290E0
	// [IDTag] // 0x00000001897A0230-0x00000001897A0270
	// [XID] // 0x00000001897A0230-0x00000001897A0270
	public override bool Equals(object other) => default; // 0x0000000183528100-0x00000001835281E0
	// [XID] // 0x00000001897AA680-0x00000001897AA6A0
	public override int GetHashCode() => default; // 0x0000000183528650-0x0000000183528700
	// [XID] // 0x00000001897B2190-0x00000001897B21B0
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835298B0-0x0000000183529960
	// [XID] // 0x00000001897B9B90-0x00000001897B9BB0
	public void InitEmpty() {} // 0x0000000183528960-0x0000000183528C70
	[BlackList] // 0x00000001897C1BF0-0x00000001897C1C30
	// [XID] // 0x00000001897C1BF0-0x00000001897C1C30
	public bool FromJson(JSONNode node) => default; // 0x0000000183528570-0x0000000183528650
	// [XID] // 0x00000001897CC170-0x00000001897CC190
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001835274B0-0x0000000183527790
	// [XID] // 0x00000001897D3AC0-0x00000001897D3AE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DCB */, bool useObjectPool = false /* Metadata: 0x00AF8DCF */) => default; // 0x0000000183528C70-0x0000000183528D50
	// [XID] // 0x00000001897DB530-0x00000001897DB550
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DD0 */, bool useObjectPool = false /* Metadata: 0x00AF8DD4 */) => default; // 0x0000000183527FE0-0x0000000183528100
	[BlackList] // 0x00000001897E2C20-0x00000001897E2C60
	// [XID] // 0x00000001897E2C20-0x00000001897E2C60
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183527790-0x0000000183527850
	// [XID] // 0x00000001897ED6B0-0x00000001897ED6D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183529650-0x0000000183529710
}

