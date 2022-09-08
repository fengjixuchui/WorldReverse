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
public class ConfigComprehensiveQualitySetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18168
{
	// Fields
	private bool _localLightingShadow; // 0x10
	private SimpleSafeInt32 terrainBlendDistanceRawNum; // 0x14
	private SimpleSafeInt32 shaderLODDistanceRawNum; // 0x18
	private string _shaderQualityKeyword; // 0x20
	private string _levelStreamingConfig; // 0x28
	private string _enviroConfig; // 0x30
	private string _uiCacheConfig; // 0x38
	private SimpleSafeFloat lightViewDistanceRatioRawNum; // 0x40
	private GrassQualityLevel _grassQuality; // 0x44
	private LightLevel _lightOnLevel; // 0x48
	private string _entityLODConfig; // 0x50
	private bool _enableRemoteAvatarLOD; // 0x58
	private bool _enableDynamicLight; // 0x59
	private SimpleSafeFloat fadeTintDistanceRawNum; // 0x5C
	private SimpleSafeFloat fadeTintSizeRawNum; // 0x60
	private SimpleSafeFloat textureStreamingBudgetRawNum; // 0x64
	private FadeTintQualityLevel _fadeTintQuality; // 0x68
	private SimpleSafeFloat terrainDistanceRawNum; // 0x6C

	// Properties
	public bool localLightingShadow { /* [XID] */ /* 0x00000001898F33E0-0x00000001898F3400 */ get => default; /* [XID] */ /* 0x00000001898FAA00-0x00000001898FAA20 */ private set {} } // 0x0000000182AB3820-0x0000000182AB38C0 0x0000000182AB2AE0-0x0000000182AB2B90
	public int terrainBlendDistance { /* [XID] */ /* 0x0000000189902580-0x00000001899025A0 */ get => default; /* [XID] */ /* 0x0000000189909B40-0x0000000189909B60 */ private set {} } // 0x0000000182AB1A50-0x0000000182AB1B20 0x0000000182AB3EC0-0x0000000182AB3FA0
	public int shaderLODDistance { /* [XID] */ /* 0x0000000189911300-0x0000000189911320 */ get => default; /* [XID] */ /* 0x0000000189918EA0-0x0000000189918EC0 */ private set {} } // 0x0000000182AB38C0-0x0000000182AB3990 0x0000000182AB1020-0x0000000182AB1100
	public string shaderQualityKeyword { /* [XID] */ /* 0x0000000189920510-0x0000000189920530 */ get => default; /* [XID] */ /* 0x0000000189927DF0-0x0000000189927E10 */ private set {} } // 0x0000000182AB1250-0x0000000182AB12F0 0x0000000182AB1100-0x0000000182AB11B0
	public string levelStreamingConfig { /* [XID] */ /* 0x000000018992F4E0-0x000000018992F500 */ get => default; /* [XID] */ /* 0x0000000189936910-0x0000000189936930 */ private set {} } // 0x0000000182AB1910-0x0000000182AB19B0 0x0000000182AB1CA0-0x0000000182AB1D50
	public string enviroConfig { /* [XID] */ /* 0x000000018993E4B0-0x000000018993E4D0 */ get => default; /* [XID] */ /* 0x0000000189945B20-0x0000000189945B40 */ private set {} } // 0x0000000182AB0360-0x0000000182AB0400 0x0000000182AB21F0-0x0000000182AB22A0
	public string uiCacheConfig { /* [XID] */ /* 0x000000018994CF70-0x000000018994CF90 */ get => default; /* [XID] */ /* 0x0000000189954700-0x0000000189954720 */ private set {} } // 0x0000000182AB11B0-0x0000000182AB1250 0x0000000182AB0400-0x0000000182AB04B0
	public float lightViewDistanceRatio { /* [XID] */ /* 0x000000018995C020-0x000000018995C040 */ get => default; /* [XID] */ /* 0x0000000189963A40-0x0000000189963A60 */ private set {} } // 0x0000000182AB3D40-0x0000000182AB3E20 0x0000000182AB1F50-0x0000000182AB2030
	public GrassQualityLevel grassQuality { /* [XID] */ /* 0x000000018996AFD0-0x000000018996AFF0 */ get => default; /* [XID] */ /* 0x0000000189972A90-0x0000000189972AB0 */ private set {} } // 0x0000000182AB2720-0x0000000182AB27C0 0x0000000182AB2C70-0x0000000182AB2D20
	public LightLevel lightOnLevel { /* [XID] */ /* 0x000000018997A2F0-0x000000018997A310 */ get => default; /* [XID] */ /* 0x0000000189981AC0-0x0000000189981AE0 */ private set {} } // 0x0000000182AB1B20-0x0000000182AB1BC0 0x0000000182AB28A0-0x0000000182AB2950
	public string entityLODConfig { /* [XID] */ /* 0x0000000189838BC0-0x0000000189838BE0 */ get => default; /* [XID] */ /* 0x0000000189990C10-0x0000000189990C30 */ set {} } // 0x0000000182AB1E00-0x0000000182AB1EA0 0x0000000182AB04B0-0x0000000182AB0560
	public bool enableRemoteAvatarLOD { /* [XID] */ /* 0x0000000189998710-0x0000000189998730 */ get => default; /* [XID] */ /* 0x000000018999FF70-0x000000018999FF90 */ private set {} } // 0x0000000182AB19B0-0x0000000182AB1A50 0x0000000182AB1EA0-0x0000000182AB1F50
	public bool enableDynamicLight { /* [XID] */ /* 0x00000001899A7B40-0x00000001899A7B60 */ get => default; /* [XID] */ /* 0x00000001899AF350-0x00000001899AF370 */ private set {} } // 0x0000000182AB22A0-0x0000000182AB2340 0x0000000182AB1D50-0x0000000182AB1E00
	public float fadeTintDistance { /* [XID] */ /* 0x00000001899B67B0-0x00000001899B67D0 */ get => default; /* [XID] */ /* 0x00000001899BE350-0x00000001899BE370 */ private set {} } // 0x0000000182AB2340-0x0000000182AB2420 0x0000000182AB1BC0-0x0000000182AB1CA0
	public float fadeTintSize { /* [XID] */ /* 0x00000001899C5AD0-0x00000001899C5AF0 */ get => default; /* [XID] */ /* 0x00000001899CD130-0x00000001899CD150 */ private set {} } // 0x0000000182AB27C0-0x0000000182AB28A0 0x0000000182AB12F0-0x0000000182AB13D0
	public float textureStreamingBudget { /* [XID] */ /* 0x00000001899D4690-0x00000001899D46B0 */ get => default; /* [XID] */ /* 0x00000001899DBD70-0x00000001899DBD90 */ set {} } // 0x0000000182AB2B90-0x0000000182AB2C70 0x0000000182AB2950-0x0000000182AB2A30
	public FadeTintQualityLevel fadeTintQuality { /* [XID] */ /* 0x00000001899E37B0-0x00000001899E37D0 */ get => default; /* [XID] */ /* 0x00000001899EAB20-0x00000001899EAB40 */ private set {} } // 0x0000000182AB3E20-0x0000000182AB3EC0 0x0000000182AB2A30-0x0000000182AB2AE0
	public float terrainDistance { /* [XID] */ /* 0x00000001899F2720-0x00000001899F2740 */ get => default; /* [XID] */ /* 0x00000001899F9C70-0x00000001899F9C90 */ private set {} } // 0x0000000182AB1750-0x0000000182AB1830 0x0000000182AB1830-0x0000000182AB1910

	// Constructors
	public ConfigComprehensiveQualitySetting() {} // 0x0000000182AB4040-0x0000000182AB4190

	// Methods
	// [XID] // 0x0000000189A01030-0x0000000189A01050
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AB3990-0x0000000182AB3C00
	// [XID] // 0x0000000189A089D0-0x0000000189A089F0
	public void InitEmpty() {} // 0x0000000182AB2030-0x0000000182AB21F0
	[BlackList] // 0x0000000189A0FF30-0x0000000189A0FF70
	// [XID] // 0x0000000189A0FF30-0x0000000189A0FF70
	public bool FromJson(JSONNode node) => default; // 0x0000000182AB13D0-0x0000000182AB1750
	// [XID] // 0x0000000189A1A3F0-0x0000000189A1A410
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182AAEE00-0x0000000182AAFE60
	// [XID] // 0x0000000189A21AD0-0x0000000189A21AF0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DA3 */, bool useObjectPool = false /* Metadata: 0x00AF8DA7 */) => default; // 0x0000000182AB2420-0x0000000182AB2720
	// [XID] // 0x00000001896CCFE0-0x00000001896CD000
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DA8 */, bool useObjectPool = false /* Metadata: 0x00AF8DAC */) => default; // 0x0000000182AB0560-0x0000000182AB1020
	[BlackList] // 0x0000000189A30650-0x0000000189A30690
	// [XID] // 0x0000000189A30650-0x0000000189A30690
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AAFE60-0x0000000182AB0130
	// [XID] // 0x0000000189A3ADA0-0x0000000189A3ADC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AB2D20-0x0000000182AB3820
	[BlackList] // 0x0000000189A42610-0x0000000189A42650
	// [XID] // 0x0000000189A42610-0x0000000189A42650
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AB0130-0x0000000182AB01D0
	[BlackList] // 0x0000000189A4CCA0-0x0000000189A4CCE0
	// [XID] // 0x0000000189A4CCA0-0x0000000189A4CCE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AB01D0-0x0000000182AB0360
	[BlackList] // 0x0000000189A57450-0x0000000189A57490
	// [XID] // 0x0000000189A57450-0x0000000189A57490
	public virtual void ReturnToObjectPool() {} // 0x0000000182AB3FA0-0x0000000182AB4040
	[BlackList] // 0x0000000189A61CB0-0x0000000189A61CF0
	// [XID] // 0x0000000189A61CB0-0x0000000189A61CF0
	public virtual void OnPoolAllocated() {} // 0x0000000182AB3CA0-0x0000000182AB3D40
	[BlackList] // 0x0000000189A6C6E0-0x0000000189A6C720
	// [XID] // 0x0000000189A6C6E0-0x0000000189A6C720
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182AB3C00-0x0000000182AB3CA0
}

