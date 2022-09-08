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
public class ConfigPlatformGrahpicsSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18179
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<VolatileType, ConfigGraphicsVolatileSetting> _volatileSettings; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigGraphicsRecommendSetting> _deviceSettings; // 0x18
	private SimpleSafeUInt32 targetFrameRateRawNum; // 0x20
	private AntialiasingMethod _antialiasingMethod; // 0x24
	private TAAQuality _taaQuality; // 0x28
	private SMAAQuality _smaaQuality; // 0x2C
	private VolatileType[] _candidateVolatile; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<OptionType, ConfigPostprocessEffectSetting> _postprocessEffectOptions; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<OptionType, ConfigParticleEffectSetting> _particleEffectOptions; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<OptionType, ConfigComprehensiveQualitySetting> _comprehensiveQualityOptions; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGraphicsSettingEntry[] _settingEntry; // 0x50
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigPerformanceSetting> _performanceSettings; // 0x58
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalToken _globalTokenSettings; // 0x60
	private Dictionary<ShadowQuality, ConfigShadowQualitySetting> _shadowQualitySettings; // 0x68
	private Dictionary<PerfCostRatioGrade, SimpleSafeFloat> _costRatioGrade; // 0x70
	private Dictionary<string, SimpleSafeInt32> _levelStreamingCostMap; // 0x78
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<FadeTintQualityLevel, ConfigTintFadeSetting> _fadeDistanceQualitySettings; // 0x80

	// Properties
	public Dictionary<VolatileType, ConfigGraphicsVolatileSetting> volatileSettings { /* [XID] */ /* 0x00000001897774F0-0x0000000189777510 */ get => default; /* [XID] */ /* 0x000000018977EC20-0x000000018977EC40 */ private set {} } // 0x0000000184594FF0-0x0000000184595090 0x0000000184594EA0-0x0000000184594F50
	public Dictionary<string, ConfigGraphicsRecommendSetting> deviceSettings { /* [XID] */ /* 0x0000000189A38DF0-0x0000000189A38E10 */ get => default; /* [XID] */ /* 0x000000018978DC10-0x000000018978DC30 */ private set {} } // 0x0000000184593C50-0x0000000184593CF0 0x0000000184593CF0-0x0000000184593DA0
	public uint targetFrameRate { /* [XID] */ /* 0x00000001897951E0-0x0000000189795200 */ get => default; /* [XID] */ /* 0x000000018979D5F0-0x000000018979D610 */ private set {} } // 0x00000001845962D0-0x00000001845963A0 0x0000000184593EF0-0x0000000184593FD0
	public AntialiasingMethod antialiasingMethod { /* [XID] */ /* 0x00000001897A48F0-0x00000001897A4910 */ get => default; /* [XID] */ /* 0x00000001897ABEC0-0x00000001897ABEE0 */ private set {} } // 0x0000000184596180-0x0000000184596220 0x0000000184596030-0x00000001845960E0
	public TAAQuality taaQuality { /* [XID] */ /* 0x00000001897B3E50-0x00000001897B3E70 */ get => default; /* [XID] */ /* 0x00000001897BBBF0-0x00000001897BBC10 */ private set {} } // 0x00000001845960E0-0x0000000184596180 0x0000000184595090-0x0000000184595140
	public SMAAQuality smaaQuality { /* [XID] */ /* 0x00000001897C33F0-0x00000001897C3410 */ get => default; /* [XID] */ /* 0x00000001897CABB0-0x00000001897CABD0 */ private set {} } // 0x0000000184594F50-0x0000000184594FF0 0x00000001845970F0-0x00000001845971A0
	public VolatileType[] candidateVolatile { /* [XID] */ /* 0x00000001897D2210-0x00000001897D2230 */ get => default; /* [XID] */ /* 0x00000001897DA090-0x00000001897DA0B0 */ private set {} } // 0x0000000184594120-0x00000001845941C0 0x0000000184595F80-0x0000000184596030
	public Dictionary<OptionType, ConfigPostprocessEffectSetting> postprocessEffectOptions { /* [XID] */ /* 0x00000001897E13A0-0x00000001897E13C0 */ get => default; /* [XID] */ /* 0x00000001897E8C30-0x00000001897E8C50 */ private set {} } // 0x0000000184593DA0-0x0000000184593E40 0x0000000184597040-0x00000001845970F0
	public Dictionary<OptionType, ConfigParticleEffectSetting> particleEffectOptions { /* [XID] */ /* 0x00000001899C1F30-0x00000001899C1F50 */ get => default; /* [XID] */ /* 0x00000001897F7F80-0x00000001897F7FA0 */ private set {} } // 0x00000001845956C0-0x0000000184595760 0x0000000184595140-0x00000001845951F0
	public Dictionary<OptionType, ConfigComprehensiveQualitySetting> comprehensiveQualityOptions { /* [XID] */ /* 0x00000001897FF610-0x00000001897FF630 */ get => default; /* [XID] */ /* 0x0000000189806D70-0x0000000189806D90 */ private set {} } // 0x0000000184593830-0x00000001845938D0 0x00000001845958B0-0x0000000184595960
	public ConfigGraphicsSettingEntry[] settingEntry { /* [XID] */ /* 0x0000000189BDA030-0x0000000189BDA050 */ get => default; /* [XID] */ /* 0x0000000189815B50-0x0000000189815B70 */ private set {} } // 0x0000000184595EE0-0x0000000184595F80 0x0000000184595800-0x00000001845958B0
	public Dictionary<string, ConfigPerformanceSetting> performanceSettings { /* [XID] */ /* 0x00000001898B02A0-0x00000001898B02C0 */ get => default; /* [XID] */ /* 0x0000000189824A80-0x0000000189824AA0 */ private set {} } // 0x0000000184595960-0x0000000184595A00 0x0000000184593E40-0x0000000184593EF0
	public ConfigGlobalToken globalTokenSettings { /* [XID] */ /* 0x000000018982C470-0x000000018982C490 */ get => default; /* [XID] */ /* 0x0000000189833960-0x0000000189833980 */ private set {} } // 0x0000000184595760-0x0000000184595800 0x0000000184596220-0x00000001845962D0
	public Dictionary<ShadowQuality, ConfigShadowQualitySetting> shadowQualitySettings { /* [XID] */ /* 0x000000018983AEC0-0x000000018983AEE0 */ get => default; /* [XID] */ /* 0x00000001898425C0-0x00000001898425E0 */ private set {} } // 0x00000001845941C0-0x0000000184594260 0x0000000184597580-0x0000000184597630
	public Dictionary<PerfCostRatioGrade, SimpleSafeFloat> costRatioGrade { /* [XID] */ /* 0x0000000189849910-0x0000000189849930 */ get => default; /* [XID] */ /* 0x0000000189851110-0x0000000189851130 */ private set {} } // 0x0000000184593FD0-0x0000000184594070 0x0000000184593BA0-0x0000000184593C50
	public Dictionary<string, SimpleSafeInt32> levelStreamingCostMap { /* [XID] */ /* 0x00000001898585E0-0x0000000189858600 */ get => default; /* [XID] */ /* 0x000000018985F650-0x000000018985F670 */ private set {} } // 0x00000001845951F0-0x0000000184595290 0x00000001845934B0-0x0000000184593560
	public Dictionary<FadeTintQualityLevel, ConfigTintFadeSetting> fadeDistanceQualitySettings { /* [XID] */ /* 0x0000000189866F30-0x0000000189866F50 */ get => default; /* [XID] */ /* 0x000000018986E730-0x000000018986E750 */ private set {} } // 0x0000000184594070-0x0000000184594120 0x0000000184595610-0x00000001845956C0

	// Constructors
	public ConfigPlatformGrahpicsSetting() {} // 0x00000001845976D0-0x0000000184597770

	// Methods
	// [XID] // 0x0000000189875B20-0x0000000189875B40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845971A0-0x0000000184597440
	// [XID] // 0x000000018987D760-0x000000018987D780
	public void InitEmpty() {} // 0x0000000184595A00-0x0000000184595BE0
	[BlackList] // 0x00000001898845B0-0x00000001898845F0
	// [XID] // 0x00000001898845B0-0x00000001898845F0
	public bool FromJson(JSONNode node) => default; // 0x0000000184595290-0x0000000184595610
	// [XID] // 0x00000001896F03A0-0x00000001896F03C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184592500-0x00000001845934B0
	// [XID] // 0x0000000189604D10-0x0000000189604D30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8E11 */, bool useObjectPool = false /* Metadata: 0x00AF8E15 */) => default; // 0x0000000184595BE0-0x0000000184595EE0
	// [XID] // 0x000000018989D5C0-0x000000018989D5E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8E16 */, bool useObjectPool = false /* Metadata: 0x00AF8E1A */) => default; // 0x0000000184594260-0x0000000184594EA0
	[BlackList] // 0x00000001898A4F00-0x00000001898A4F40
	// [XID] // 0x00000001898A4F00-0x00000001898A4F40
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184593560-0x0000000184593830
	// [XID] // 0x00000001898AF750-0x00000001898AF770
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845963A0-0x0000000184597040
	[BlackList] // 0x00000001898B6BD0-0x00000001898B6C10
	// [XID] // 0x00000001898B6BD0-0x00000001898B6C10
	public virtual void AutoAllocTypeFields() {} // 0x00000001845938D0-0x0000000184593970
	[BlackList] // 0x00000001898C13E0-0x00000001898C1420
	// [XID] // 0x00000001898C13E0-0x00000001898C1420
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184593970-0x0000000184593BA0
	[BlackList] // 0x00000001898CBAD0-0x00000001898CBB10
	// [XID] // 0x00000001898CBAD0-0x00000001898CBB10
	public virtual void ReturnToObjectPool() {} // 0x0000000184597630-0x00000001845976D0
	[BlackList] // 0x00000001898D6520-0x00000001898D6560
	// [XID] // 0x00000001898D6520-0x00000001898D6560
	public virtual void OnPoolAllocated() {} // 0x00000001845974E0-0x0000000184597580
	[BlackList] // 0x00000001898E1200-0x00000001898E1240
	// [XID] // 0x00000001898E1200-0x00000001898E1240
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184597440-0x00000001845974E0
}

