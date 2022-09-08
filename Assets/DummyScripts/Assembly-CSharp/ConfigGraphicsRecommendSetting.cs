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
public class ConfigGraphicsRecommendSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18173
{
	// Fields
	private string _performanceQuality; // 0x10
	private SimpleSafeFloat virtualJoystickRadiusRawNum; // 0x18
	private string _levelStreamingConfig; // 0x20
	private string _uiCacheConfig; // 0x28
	private LightLevel _lightOnLevel; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGraphicsRequirement[] _requirements; // 0x38
	private SimpleSafeFloat textureStreamingBudgetRawNum; // 0x40
	private SimpleSafeInt32 enableCutsceneTextureStreamingRawNum; // 0x44
	private SimpleSafeInt32 textureStreamingEnabledRawNum; // 0x48
	private SimpleSafeInt32 enableUICameraFullResolutionRawNum; // 0x4C
	private SimpleSafeInt32 preloadUISceneRawNum; // 0x50
	private SimpleSafeInt32 disableDoFRawNum; // 0x54
	private SimpleSafeInt32 enableSubpassRawNum; // 0x58
	private ConfigRenderResolution[] _renderResolutions; // 0x60
	private string _qualityLevel; // 0x68
	private SimpleSafeInt32 defaultVolatileGradeRawNum; // 0x70
	private SimpleSafeFloat avatarOutlineThreshRawNum; // 0x74
	private SimpleSafeFloat avatarShadowThreshRawNum; // 0x78
	private SimpleSafeFloat avatarMotionVectorThreshRawNum; // 0x7C
	private SimpleSafeFloat viewDistanceRatioRawNum; // 0x80
	private GrassQualityLevel _grassQuality; // 0x84
	private SimpleSafeInt32 crowdSpawnDistanceRawNum; // 0x88
	private SimpleSafeInt32 crowdDespawnDistanceRawNum; // 0x8C
	private string _entityLODConfig; // 0x90

	// Properties
	public string performanceQuality { /* [XID] */ /* 0x00000001896319E0-0x0000000189631A00 */ get => default; /* [XID] */ /* 0x000000018980B2E0-0x000000018980B300 */ set {} } // 0x0000000182B45B00-0x0000000182B45BA0 0x0000000182B46160-0x0000000182B46210
	public float virtualJoystickRadius { /* [XID] */ /* 0x0000000189812A20-0x0000000189812A40 */ get => default; /* [XID] */ /* 0x000000018986D8A0-0x000000018986D8C0 */ set {} } // 0x0000000182B47760-0x0000000182B47840 0x0000000182B44DB0-0x0000000182B44E90
	public string levelStreamingConfig { /* [XID] */ /* 0x0000000189A86CE0-0x0000000189A86D00 */ get => default; /* [XID] */ /* 0x00000001898838D0-0x00000001898838F0 */ set {} } // 0x0000000182B44C70-0x0000000182B44D10 0x0000000182B44E90-0x0000000182B44F40
	public string uiCacheConfig { /* [XID] */ /* 0x00000001898308C0-0x00000001898308E0 */ get => default; /* [XID] */ /* 0x0000000189837E00-0x0000000189837E20 */ private set {} } // 0x0000000182B44780-0x0000000182B44820 0x0000000182B431E0-0x0000000182B43290
	public LightLevel lightOnLevel { /* [XID] */ /* 0x000000018983F5D0-0x000000018983F5F0 */ get => default; /* [XID] */ /* 0x000000018987C820-0x000000018987C840 */ set {} } // 0x0000000182B44D10-0x0000000182B44DB0 0x0000000182B45C80-0x0000000182B45D30
	public ConfigGraphicsRequirement[] requirements { /* [XID] */ /* 0x00000001896FDFA0-0x00000001896FDFC0 */ get => default; /* [XID] */ /* 0x00000001898553D0-0x00000001898553F0 */ private set {} } // 0x0000000182B435C0-0x0000000182B43660 0x0000000182B47330-0x0000000182B473E0
	public float textureStreamingBudget { /* [XID] */ /* 0x0000000189AA4C70-0x0000000189AA4C90 */ get => default; /* [XID] */ /* 0x0000000189601DD0-0x0000000189601DF0 */ set {} } // 0x0000000182B45FD0-0x0000000182B460B0 0x0000000182B45D30-0x0000000182B45E10
	public int enableCutsceneTextureStreaming { /* [XID] */ /* 0x000000018986B7C0-0x000000018986B7E0 */ get => default; /* [XID] */ /* 0x0000000189872AD0-0x0000000189872AF0 */ set {} } // 0x0000000182B44BA0-0x0000000182B44C70 0x0000000182B44600-0x0000000182B446E0
	public int textureStreamingEnabled { /* [XID] */ /* 0x000000018987A770-0x000000018987A790 */ get => default; /* [XID] */ /* 0x0000000189881900-0x0000000189881920 */ set {} } // 0x0000000182B43040-0x0000000182B43110 0x0000000182B450C0-0x0000000182B451A0
	public int enableUICameraFullResolution { /* [XID] */ /* 0x0000000189888F00-0x0000000189888F20 */ get => default; /* [XID] */ /* 0x0000000189890220-0x0000000189890240 */ set {} } // 0x0000000182B43440-0x0000000182B43510 0x0000000182B41160-0x0000000182B41240
	public int preloadUIScene { /* [XID] */ /* 0x000000018990A780-0x000000018990A7A0 */ get => default; /* [XID] */ /* 0x000000018989ECE0-0x000000018989ED00 */ set {} } // 0x0000000182B44FF0-0x0000000182B450C0 0x0000000182B47AB0-0x0000000182B47B90
	public int disableDoF { /* [XID] */ /* 0x0000000189919C10-0x0000000189919C30 */ get => default; /* [XID] */ /* 0x0000000189739600-0x0000000189739620 */ set {} } // 0x0000000182B43290-0x0000000182B43360 0x0000000182B45E10-0x0000000182B45EF0
	public int enableSubpass { /* [XID] */ /* 0x00000001898B5310-0x00000001898B5330 */ get => default; /* [XID] */ /* 0x00000001898BCDC0-0x00000001898BCDE0 */ set {} } // 0x0000000182B43110-0x0000000182B431E0 0x0000000182B41080-0x0000000182B41160
	public ConfigRenderResolution[] renderResolutions { /* [XID] */ /* 0x00000001898C4580-0x00000001898C45A0 */ get => default; /* [XID] */ /* 0x00000001897202C0-0x00000001897202E0 */ set {} } // 0x0000000182B446E0-0x0000000182B44780 0x0000000182B47280-0x0000000182B47330
	public string qualityLevel { /* [XID] */ /* 0x00000001898D3310-0x00000001898D3330 */ get => default; /* [XID] */ /* 0x0000000189690CC0-0x0000000189690CE0 */ set {} } // 0x0000000182B471E0-0x0000000182B47280 0x0000000182B47A00-0x0000000182B47AB0
	public int defaultVolatileGrade { /* [XID] */ /* 0x00000001898E2A80-0x00000001898E2AA0 */ get => default; /* [XID] */ /* 0x00000001898EA5B0-0x00000001898EA5D0 */ set {} } // 0x0000000182B45870-0x0000000182B45940 0x0000000182B45A20-0x0000000182B45B00
	public float avatarOutlineThresh { /* [XID] */ /* 0x0000000189BBD5A0-0x0000000189BBD5C0 */ get => default; /* [XID] */ /* 0x00000001896D2B30-0x00000001896D2B50 */ set {} } // 0x0000000182B47920-0x0000000182B47A00 0x0000000182B42E80-0x0000000182B42F60
	public float avatarShadowThresh { /* [XID] */ /* 0x0000000189900E90-0x0000000189900EB0 */ get => default; /* [XID] */ /* 0x0000000189908610-0x0000000189908630 */ set {} } // 0x0000000182B45EF0-0x0000000182B45FD0 0x0000000182B44450-0x0000000182B44530
	public float avatarMotionVectorThresh { /* [XID] */ /* 0x0000000189BDBD20-0x0000000189BDBD40 */ get => default; /* [XID] */ /* 0x0000000189917800-0x0000000189917820 */ set {} } // 0x0000000182B45940-0x0000000182B45A20 0x0000000182B45BA0-0x0000000182B45C80
	public float viewDistanceRatio { /* [XID] */ /* 0x000000018991EDE0-0x000000018991EE00 */ get => default; /* [XID] */ /* 0x00000001899267C0-0x00000001899267E0 */ private set {} } // 0x0000000182B473E0-0x0000000182B474C0 0x0000000182B43360-0x0000000182B43440
	public GrassQualityLevel grassQuality { /* [XID] */ /* 0x00000001895EFE70-0x00000001895EFE90 */ get => default; /* [XID] */ /* 0x00000001899351B0-0x00000001899351D0 */ set {} } // 0x0000000182B457D0-0x0000000182B45870 0x0000000182B460B0-0x0000000182B46160
	public int crowdSpawnDistance { /* [XID] */ /* 0x000000018993CD30-0x000000018993CD50 */ get => default; /* [XID] */ /* 0x00000001899443E0-0x0000000189944400 */ private set {} } // 0x0000000182B44530-0x0000000182B44600 0x0000000182B47840-0x0000000182B47920
	public int crowdDespawnDistance { /* [XID] */ /* 0x000000018994B9C0-0x000000018994B9E0 */ get => default; /* [XID] */ /* 0x0000000189953190-0x00000001899531B0 */ private set {} } // 0x0000000182B45400-0x0000000182B454D0 0x0000000182B42F60-0x0000000182B43040
	public string entityLODConfig { /* [XID] */ /* 0x000000018995A8B0-0x000000018995A8D0 */ get => default; /* [XID] */ /* 0x0000000189962370-0x0000000189962390 */ set {} } // 0x0000000182B44F40-0x0000000182B44FF0 0x0000000182B43510-0x0000000182B435C0

	// Constructors
	public ConfigGraphicsRecommendSetting() {} // 0x0000000182B47C30-0x0000000182B47E00

	// Methods
	// [XID] // 0x0000000189969840-0x0000000189969860
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B474C0-0x0000000182B47620
	// [XID] // 0x0000000189971580-0x00000001899715A0
	public void InitEmpty() {} // 0x0000000182B451A0-0x0000000182B45400
	[BlackList] // 0x0000000189978F70-0x0000000189978FB0
	// [XID] // 0x0000000189978F70-0x0000000189978FB0
	public bool FromJson(JSONNode node) => default; // 0x0000000182B44820-0x0000000182B44BA0
	// [XID] // 0x0000000189B8FAA0-0x0000000189B8FAC0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182B41240-0x0000000182B428E0
	// [XID] // 0x000000018998AC20-0x000000018998AC40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DD5 */, bool useObjectPool = false /* Metadata: 0x00AF8DD9 */) => default; // 0x0000000182B454D0-0x0000000182B457D0
	// [XID] // 0x00000001899924F0-0x0000000189992510
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DDA */, bool useObjectPool = false /* Metadata: 0x00AF8DDE */) => default; // 0x0000000182B43660-0x0000000182B44450
	[BlackList] // 0x000000018999A270-0x000000018999A2B0
	// [XID] // 0x000000018999A270-0x000000018999A2B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B428E0-0x0000000182B42BB0
	// [XID] // 0x00000001899A49F0-0x00000001899A4A10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B46210-0x0000000182B471E0
	[BlackList] // 0x00000001899AC430-0x00000001899AC470
	// [XID] // 0x00000001899AC430-0x00000001899AC470
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B42BB0-0x0000000182B42C50
	[BlackList] // 0x00000001899B6770-0x00000001899B67B0
	// [XID] // 0x00000001899B6770-0x00000001899B67B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B42C50-0x0000000182B42E80
	[BlackList] // 0x00000001899C1230-0x00000001899C1270
	// [XID] // 0x00000001899C1230-0x00000001899C1270
	public virtual void ReturnToObjectPool() {} // 0x0000000182B47B90-0x0000000182B47C30
	[BlackList] // 0x00000001899CBB60-0x00000001899CBBA0
	// [XID] // 0x00000001899CBB60-0x00000001899CBBA0
	public virtual void OnPoolAllocated() {} // 0x0000000182B476C0-0x0000000182B47760
	[BlackList] // 0x00000001899D5FF0-0x00000001899D6030
	// [XID] // 0x00000001899D5FF0-0x00000001899D6030
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B47620-0x0000000182B476C0
}

