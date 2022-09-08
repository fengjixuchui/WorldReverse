/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class EnviroSky : MonoBehaviour // TypeDefIndex: 31496
	{
		// Fields
		private static EnviroSky _instance; // 0x00
		public const string DEFAULT_WEATHER_NAME = "BigWorld/Weather_ClearSky"; // Metadata: 0x00B1280C
		public const int DEFAULT_TRANS_TIME = -1; // Metadata: 0x00B12829
		public UpdateType updateType; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private EnviroSystemArguments _arguments; // 0x20
		public bool controlMainLight; // 0x40
		// [Tooltip] // 0x0000000189B27900-0x0000000189B27930
		public Transform CameraTrans; // 0x48
		// [Tooltip] // 0x0000000189B30460-0x0000000189B30490
		public Camera PlayerCamera; // 0x50
		// [Tooltip] // 0x0000000189B39510-0x0000000189B39540
		public string CameraTag; // 0x58
		// [Header] // 0x0000000189B425B0-0x0000000189B42610
		// [Header] // 0x0000000189B425B0-0x0000000189B42610
		public string defaultProfilePath; // 0x60
		// [Header] // 0x0000000189B4FEC0-0x0000000189B4FEF0
		public string profilePath; // 0x68
		private uint profileHandle; // 0x78
		private uint currProfileHandle; // 0x7C
		private LevelTimeManager _gameTime; // 0x80
		private float _curTimeOfDay24; // 0x88
		private float _targetTimeOfDay24; // 0x8C
		public bool isForceTimeOfDay; // 0x90
		public float forceTimeOfDay; // 0x94
		public EnviroWeather Weather; // 0x98
		public EnviroWeather Volume; // 0xA0
		// [Header] // 0x0000000189B63710-0x0000000189B63740
		public EnviroComponents Components; // 0xA8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		private EnviroLensFlare enviroLensFlare; // 0xB0
		private uint enviroLensFlareHandle; // 0xB8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public EnviroLightSettings lightSettings; // 0xC0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public EnviroSkySettings skySettings; // 0xC8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public EnviroCloudSettings cloudsSettings; // 0xD0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public EnviroFogSettings fogSettings; // 0xD8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public EnviroTransitionSettings transitionSettings; // 0xE0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public EnviroQualitySettings qualitySettings; // 0xE8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public EnviroCharacterLightSettings characterLightSettings; // 0xF0
		private uint characterLightSettingsHandle; // 0x100
		private EnviroLightSettings lastLightSettings; // 0x108
		private EnviroSkySettings lastSkySettings; // 0x110
		private EnviroCloudSettings lastCloudsSettings; // 0x118
		private EnviroFogSettings lastFogSettings; // 0x120
		private EnviroTransitionSettings lastTransitionSettings; // 0x128
		private EnviroLightSettings targetLightSettings; // 0x130
		private EnviroSkySettings targetSkySettings; // 0x138
		private EnviroFogSettings targetFogSettings; // 0x140
		private EnviroCloudSettings targetCloudsSettings; // 0x148
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Dictionary<int, EnviroWindZone> windZones; // 0x150
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		private SceneSurfaceMaterial curSurfaceMaterial; // 0x158
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float skySize; // 0x15C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool showSettings; // 0x160
		private float areaTransitionRatio; // 0x164
		private float lastAreaTransitionRatio; // 0x168
		private float areaTransitionTime; // 0x16C
		private float curAreaTransitionTime; // 0x170
		public float weatherTransitionRatio; // 0x174
		private float lastWeatherTransitionRatio; // 0x178
		private float weatherTransitionTime; // 0x17C
		private float curWeatherTransitionTime; // 0x180
		public float volumeTransitionRatio; // 0x184
		private float lastVolumeTransitionRatio; // 0x188
		private float volumeTransitionTime; // 0x18C
		private float curVolumeTransitionTime; // 0x190
		private int currentVolumePrio; // 0x194
		private float timeChangeRatio; // 0x198
		private float timeTransSpeedTime; // 0x19C
		private float curTimeTransSpeedTime; // 0x1A0
		public float effectChangeRatio; // 0x1A4
		private float _lastEffectChangeRatio; // 0x1A8
		private float _cloudShadowMultiplier; // 0x1AC
		public Light MainLight; // 0x1B0
		public Transform DirLightTransform; // 0x1B8
		private Transform AtmosphereTransform; // 0x1C0
		private Transform SunTransform; // 0x1C8
		private Transform MoonTransform; // 0x1D0
		private Transform AuroraTransform; // 0x1D8
		private Transform AvatarLightTransform; // 0x1E0
		private Quaternion _sunQuaternion; // 0x1E8
		private Quaternion _moonQuaternion; // 0x1F8
		private Quaternion _dirLightQuaternion; // 0x208
		private double lastRelfectionUpdate; // 0x218
		private float _curUpdateIntervalTime; // 0x220
		private Vector2 _cloudMoveDistance; // 0x224
		private float _updateDeltaTime; // 0x22C
		private Vector3 _prevCamPos; // 0x230
		private bool _forceUpdateRainOccTex; // 0x23C
		private static readonly float RAIN_THRESH; // 0x08
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool initialized; // 0x23D
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		private float _prevTimeOfDay24; // 0x240
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool needForceUpdateCubeMap; // 0x244
		private bool isInApplyProfile; // 0x245
		private static readonly float TIME_THRESH; // 0x0C
		private int _skyWorldUpDirID; // 0x248
		private int _skyCenterWorldPosID; // 0x24C
		private int _lightDirectionID; // 0x250
		private int _lightColorID; // 0x254
		private int _lightIntensityID; // 0x258
		private int _topFrontColorID; // 0x25C
		private int _topBackColorID; // 0x260
		private int _bottomFrontColorID; // 0x264
		private int _bottomBackColorID; // 0x268
		private int _skyFrontAndBackBlendFactorID; // 0x26C
		private int _skyGradientBlendFactorID; // 0x270
		private int _bottomColorHeightID; // 0x274
		private int _mainLightColorId; // 0x278
		private int _sceneFrontRimColorId; // 0x27C
		public int characterFrontRimColorId; // 0x280
		private int _characterFrontRimIntensityId; // 0x284
		public int characterBackRimColorId; // 0x288
		private int _characterBackRimIntensityId; // 0x28C
		private int _characterRimWidthId; // 0x290
		private int _characterAmbientLightOn; // 0x294
		private int _characterMainLightBrightness; // 0x298
		private int _characterAmbientBrightness; // 0x29C
		public int characterMainLightColorId; // 0x2A0
		private int _characterAmbientLightColorId; // 0x2A4
		private int _characterMainLightRatioId; // 0x2A8
		private int _characterAmbientLightRatioId; // 0x2AC
		private int _characterEnvLightIntensity; // 0x2B0
		private int _characterBodyShadowIntensity; // 0x2B4
		private int _characterSkinShadowIntensity; // 0x2B8
		public int characterColorToneId; // 0x2BC
		private int _characterPointLightPartialThreshold; // 0x2C0
		private int _characterPointLightPartialIntensity; // 0x2C4
		private int _characterPointLightWholeIntensity; // 0x2C8
		private int _horizonHaloColorID; // 0x2CC
		private int _horizonHaloIntensityID; // 0x2D0
		private int _horizonHaloBlendFactorID; // 0x2D4
		private int _horizonHaloHeightID; // 0x2D8
		private int _sunDirectionID; // 0x2DC
		private int _sunDiskColorID; // 0x2E0
		private int _sunDiskBrightnessID; // 0x2E4
		private int _sunDiskSharpnessID; // 0x2E8
		private int _sunHaloColorID; // 0x2EC
		private int _sunHaloBrightnessID; // 0x2F0
		private int _sunHaloSizeID; // 0x2F4
		private int _moonDirectionID; // 0x2F8
		private int _moonColorID; // 0x2FC
		private int _moonBrightnessID; // 0x300
		private int _moonSizeID; // 0x304
		private int _moonGlowBrightnessID; // 0x308
		private int _moonLunarPhaseID; // 0x30C
		private int _cloudElapsedTimeID; // 0x310
		private int _cloudDirectionID; // 0x314
		private int _cloudTilingID; // 0x318
		private int _cloudHeightID; // 0x31C
		private int _cloudCoverageID; // 0x320
		private int _cloudAgePercentID; // 0x324
		private int _cloudOpacityID; // 0x328
		private int _cloudSmoothnessID; // 0x32C
		private int _cloudLightFrontColorID; // 0x330
		private int _cloudLightBackColorID; // 0x334
		private int _cloudDarkFrontColorID; // 0x338
		private int _cloudDarkBackColorID; // 0x33C
		private int _cloudFrontAndBackBlendFactorID; // 0x340
		private int _cloudSunBrightenIntensityID; // 0x344
		private int _cloudLightingIntensityID; // 0x348
		private int _cloudRimLightRadiusID; // 0x34C
		private int _cloudWispsElapsedTimeID; // 0x350
		private int _cloudWispsCoverageID; // 0x354
		private int _cloudWispsOpacityID; // 0x358
		private int _cloudShadowTransformID; // 0x35C
		private int _cloudLayerShadowIntensity; // 0x360
		private int _cloudLayerShadowMultiplierID; // 0x364
		private int _cloudShadowTexID; // 0x368
		private int _cloudSpeedID; // 0x36C
		private int _rainNoiseTexID; // 0x370
		private int _rainCubeMapTexID; // 0x374
		private int _rainParams0ID; // 0x378
		private int _rainParams1ID; // 0x37C
		private int _starsScintillationID; // 0x380
		private int _starsBrightnessID; // 0x384
		private int _starsDensityID; // 0x388
		private int _galaxyFadeValueID; // 0x38C
		private int _galaxyBGColorID; // 0x390
		private int _galaxyLightColorID; // 0x394
		private int _galaxyDarkColorID; // 0x398
		private int _auroraElapsedTimeID; // 0x39C
		private int _auroraBrightnessID; // 0x3A0
		private int _ditherRandomSeedID; // 0x3A4
		private int _dungeonLightColorID; // 0x3A8
		private int _characterLightDirShaderID; // 0x3AC
		private int _MobileLODReflectionColorID; // 0x3B0
		private int _TransparentEnvironmentIntensityID; // 0x3B4
		private int _mainLightBrightnessID; // 0x3B8
		private int _TreeDiffuseRampScaleID; // 0x3BC
		private int _TreeDiffuseRampOffsetID; // 0x3C0
		private int _TreeShadowIntensityID; // 0x3C4
		private bool _hasNotifyEffectChange; // 0x3C8
		private bool _cloudShadowFadeOut; // 0x3C9
		private float _lightningTransitionRatio; // 0x3CC
		private int _emissionTimeStrengthID; // 0x3D0
		private int _skyColorIntensityForHeighFogID; // 0x3D4
		private const float CLOUD_SPEED_STRENGTH = 0.02f; // Metadata: 0x00B1282D
		private const float CLOUD_WISPS_SPEED_STRENGTH = 0.01f; // Metadata: 0x00B12831
		private float _cloudCurrentTimeOffset; // 0x3D8
		private float _cloudCurrentSpeed; // 0x3DC
		private float _cloudWispsCurrentTimeOffset; // 0x3E0
		private float _cloudWispsCurrentSpeed; // 0x3E4
		private UnityEngine.Material _cloudEmitterMat; // 0x3E8
		private UnityEngine.Material _cloudEmitter1Mat; // 0x3F0
		private UnityEngine.Material _cloudEmitter2Mat; // 0x3F8
		private EnviroCloudsEmitter _emitter; // 0x400
		private EnviroCloudsEmitter _emitter1; // 0x408
		private EnviroCloudsEmitter _emitter2; // 0x410
		private bool _atmosAndCloudEnable; // 0x418
		private bool _transCloudEmitterActive; // 0x419
		private bool _transCloudEmitter1Active; // 0x41A
		private bool _transCloudEmitter2Active; // 0x41B
		private bool _needUpdateClouds; // 0x41C
		private float overrideExpro; // 0x420
		private bool enableBloom; // 0x424
		private PostProcessProfile postProcessProfile; // 0x428
		private MHYBloom bloomSettings; // 0x430
		private float bloomUpdateTimer; // 0x438
		private float bloomUpdateTimeSpan; // 0x43C
		private AutoExposure autoExposureSettings; // 0x440
		private MHYColorGrading transitionColorgradingSettings; // 0x448
		private MHYScreenEffect screenEffectSettings; // 0x450
		public VCWeather vcWeather; // 0x488
		public LevelEntity levelEntity; // 0x490
		public bool useCTS; // 0x498
		private int forceUpdateCount; // 0x49C
		private bool _updateEnviro; // 0x4A0
		private bool _galaxyEnable; // 0x4A1
		private bool _switchDataRender; // 0x4A2
		private bool _updateWeather; // 0x4A3
		private string skillPresetPath; // 0x4A8
		private EnviroSkillPreset targetSkillPreset; // 0x4B0
		private uint targetSkillPresetHandle; // 0x4B8
		public System.Random ranSystem; // 0x4C0
		public ScreenEffectProfile screenEffectProfile; // 0x4C8
		public int currentScreenEffectIndex; // 0x4D0
		public float overrideIntensity; // 0x4D4
		public bool rewriteUpdateCharacterLightDir; // 0x4D8
		public MiHoYoGrassGlobalConfigurator mihoyoGrassConfig; // 0x4E0
		public bool forceInit; // 0x4E8
		private int effectUpdateInterval; // 0x4EC
		private Renderer sunRenderer; // 0x4F0
		private LensFlare sunLensFlare; // 0x4F8
		private EnviroWeatherPreset _cachedWeatherPreset; // 0x500
		private Dictionary<string, EnviroWeatherPreset> name2Preset; // 0x508
		private List<uint> name2PresetHandles; // 0x510
	
		// Properties
		public static EnviroSky Instance { /* [XID] */ /* 0x000000018962A4D0-0x000000018962A4F0 */ get => default; } // 0x00000001814C6480-0x00000001814C6550 
		public EnviroProfile profile { /* [XID] */ /* 0x000000018963C640-0x000000018963C680 */ get; /* [XID] */ /* 0x0000000189631C50-0x0000000189631C90 */ private set; } // 0x00000001814C6740-0x00000001814C67A0 0x00000001814BB3A0-0x00000001814BB400
		public float curTimeOfDay24 { /* [XID] */ /* 0x0000000189646D90-0x0000000189646DB0 */ get => default; } // 0x00000001814C65B0-0x00000001814C6660 
		public LevelTimeManager gameTime { /* [XID] */ /* 0x000000018964E550-0x000000018964E570 */ get => default; /* [XID] */ /* 0x0000000189655D80-0x0000000189655DA0 */ private set {} } // 0x00000001814C6660-0x00000001814C6740 0x00000001814BD1B0-0x00000001814BD260
		public EnviroCharacterLightSetting characterLightProfile { /* [XID] */ /* 0x0000000189677080-0x00000001896770C0 */ get; /* [XID] */ /* 0x000000018966C240-0x000000018966C280 */ private set; } // 0x00000001814C6550-0x00000001814C65B0 0x00000001814BF100-0x00000001814BF170
	
		// Events
		public event WeatherChanged OnWeatherChanged;
		public event WeatherEffectChanged OnWeatherEffectChanged;
		public event WeatherChangeFinish OnWeatherChangeFinish;
		public event VolumeChanged OnVolumeChanged;
		public event VolumeChangeFinish OnVolumeChangeFinish;
		public event WorldShiftOffsetChanged OnWorldShiftOffsetChanged;
	
		// Nested types
		[Serializable]
		public enum UpdateType // TypeDefIndex: 31497
		{
			Normal = 0,
			Never = 1,
			Always = 2
		}
	
		public delegate void WeatherChanged(EnviroWeatherPreset weatherType); // TypeDefIndex: 31498; 0x0000000181F6FAB0-0x0000000181F6FD10
	
		public delegate void WeatherEffectChanged(EnviroWeatherPreset to); // TypeDefIndex: 31499; 0x0000000181F6C280-0x0000000181F6C4E0
	
		public delegate void WeatherChangeFinish(EnviroWeatherPreset weatherType1, EnviroWeatherPreset weatherType2); // TypeDefIndex: 31500; 0x0000000181F8CF30-0x0000000181F8D1E0
	
		public delegate void VolumeChanged(EnviroWeatherPreset volumeType); // TypeDefIndex: 31501; 0x0000000181F7F430-0x0000000181F7F690
	
		public delegate void VolumeEffectChanged(EnviroWeatherPreset to); // TypeDefIndex: 31502; 0x0000000181F8C350-0x0000000181F8C5B0
	
		public delegate void VolumeChangeFinish(EnviroWeatherPreset volumeType1, EnviroWeatherPreset volumeType2); // TypeDefIndex: 31503; 0x0000000181F8BF10-0x0000000181F8C1C0
	
		public delegate void WorldShiftOffsetChanged(Vector3 offset); // TypeDefIndex: 31504; 0x0000000181F8CA40-0x0000000181F8CC60
	
		// Constructors
		public EnviroSky() {} // 0x00000001814C5A70-0x00000001814C5DC0
		static EnviroSky() {} // 0x00000001814C5A00-0x00000001814C5A70
	
		// Methods
		// [XID] // 0x000000018965D540-0x000000018965D560
		public void SetForceTimeOfDay(bool enable, float value) {} // 0x00000001814C3830-0x00000001814C3900
		// [XID] // 0x0000000189664C60-0x0000000189664C80
		private float GetTimeOfDay24() => default; // 0x00000001814C1030-0x00000001814C1320
		// [XID] // 0x0000000189681900-0x0000000189681920
		public SceneSurfaceMaterial GetCurSurfaceMaterial() => default; // 0x00000001814B46A0-0x00000001814B4740
		// [XID] // 0x00000001896E1FD0-0x00000001896E1FF0
		private void Awake() {} // 0x00000001814AA2F0-0x00000001814AA3C0
		// [XID] // 0x00000001896E94C0-0x00000001896E94E0
		private void Start() {} // 0x00000001814C4B60-0x00000001814C4C10
		// [XID] // 0x00000001896F0760-0x00000001896F0780
		private void OnDestroy() {} // 0x00000001814C07E0-0x00000001814C09D0
		// [XID] // 0x00000001896F7F00-0x00000001896F7F20
		public void Init() {} // 0x00000001814B7FB0-0x00000001814B84C0
		// [XID] // 0x00000001896FF900-0x00000001896FF920
		public void RefreshComponents() {} // 0x00000001814C2220-0x00000001814C2860
		// [XID] // 0x0000000189706E90-0x0000000189706EB0
		private void ResetFlare() {} // 0x00000001814BB400-0x00000001814BB6B0
		// [XID] // 0x000000018970E750-0x000000018970E770
		public void ResetDefaultProfile(string path) {} // 0x00000001814C3150-0x00000001814C3210
		// [XID] // 0x0000000189715BB0-0x0000000189715BD0
		public void AfterDefaultProfile() {} // 0x00000001814A9980-0x00000001814A9A70
		// [XID] // 0x000000018971D620-0x000000018971D640
		public void Release() {} // 0x00000001814C2930-0x00000001814C2B00
		// [XID] // 0x00000001897249D0-0x00000001897249F0
		public void ReInit() {} // 0x00000001814C1450-0x00000001814C1500
		// [XID] // 0x000000018972C220-0x000000018972C240
		public void Refresh() {} // 0x00000001814C2860-0x00000001814C2930
		// [XID] // 0x0000000189733890-0x00000001897338B0
		private void ResetPostprocess() {} // 0x00000001814AAF00-0x00000001814ABBD0
		// [XID] // 0x000000018973B020-0x000000018973B040
		private bool InitComponents() => default; // 0x00000001814B16E0-0x00000001814B1E80
		// [XID] // 0x0000000189742990-0x00000001897429B0
		private void InitSkyRenderingComponent() {} // 0x00000001814BEA30-0x00000001814BF100
		// [XID] // 0x000000018974A660-0x000000018974A680
		public void InitClouds() {} // 0x00000001814B7BA0-0x00000001814B7FB0
		// [XID] // 0x00000001897517B0-0x00000001897517D0
		private void InitPostProcessing() {} // 0x00000001814BCC30-0x00000001814BCE20
		// [XID] // 0x0000000189758D50-0x0000000189758D70
		private void InitWeather() {} // 0x00000001814B63F0-0x00000001814B64D0
		// [XID] // 0x0000000189760A30-0x0000000189760A50
		private void InitVolume() {} // 0x00000001814B9200-0x00000001814B92E0
		// [XID] // 0x0000000189767D10-0x0000000189767D30
		private void InitSkillEffect() {} // 0x00000001814B9160-0x00000001814B9200
		// [XID] // 0x000000018976F2A0-0x000000018976F2C0
		private void InitWind() {} // 0x00000001814BB190-0x00000001814BB3A0
		// [XID] // 0x0000000189776CC0-0x0000000189776CE0
		private void ResetDirectLightComponent() {} // 0x00000001814BA200-0x00000001814BA580
		// [XID] // 0x000000018977E390-0x000000018977E3B0
		public void RefreshCloudsEmitterAndMatVar() {} // 0x00000001814C17B0-0x00000001814C2220
		// [XID] // 0x0000000189785AA0-0x0000000189785AC0
		public void ForceUpdate(bool enable) {} // 0x00000001814B3BE0-0x00000001814B3CA0
		// [XID] // 0x000000018978D160-0x000000018978D180
		public bool CheckNeedUpdate() => default; // 0x00000001814AD000-0x00000001814AD0A0
		// [XID] // 0x0000000189794510-0x0000000189794530
		public bool IsForceUpdate() => default; // 0x00000001814B8570-0x00000001814B8620
		// [XID] // 0x000000018979C9A0-0x000000018979C9C0
		public bool IsForceStop() => default; // 0x00000001814B84C0-0x00000001814B8570
		// [XID] // 0x00000001897A3E40-0x00000001897A3E60
		public void Update() {} // 0x00000001814C55F0-0x00000001814C5940
		// [XID] // 0x00000001897AB360-0x00000001897AB380
		public void UpdateMHYWorldOffset(Vector3 offset) {} // 0x00000001814C4DF0-0x00000001814C5090
		// [XID] // 0x00000001897B31D0-0x00000001897B31F0
		private void UpdateDeltaTime() {} // 0x00000001814B7270-0x00000001814B73A0
		// [XID] // 0x00000001897BB0F0-0x00000001897BB110
		private void UpdateData() {} // 0x00000001814B2180-0x00000001814B2300
		// [XID] // 0x00000001897C2870-0x00000001897C2890
		private void UpdateRender() {} // 0x00000001814B41C0-0x00000001814B4410
		// [XID] // 0x00000001897CA0B0-0x00000001897CA0D0
		private void UpdateRenderPerFrame() {} // 0x00000001814BC020-0x00000001814BC0C0
		// [XID] // 0x00000001897D1790-0x00000001897D17B0
		private void UpdateTime() {} // 0x00000001814BCF50-0x00000001814BD1B0
		// [XID] // 0x00000001897D9530-0x00000001897D9550
		private void UpdateSunAndMoonPosition(float timeOfDay24) {} // 0x00000001814AE2E0-0x00000001814AF290
		// [XID] // 0x00000001897E0950-0x00000001897E0970
		private void UpdateProfile(float timeOfDay24) {} // 0x00000001814BC760-0x00000001814BC880
		// [XID] // 0x00000001897E8010-0x00000001897E8030
		private void UpdateSkyCapture(float timeOfDay24) {} // 0x00000001814BADE0-0x00000001814BAF10
		// [XID] // 0x00000001897EFC50-0x00000001897EFC70
		private void UpdateWeather(float timeOfDay24) {} // 0x00000001814A8DA0-0x00000001814A9980
		// [XID] // 0x00000001897F7440-0x00000001897F7460
		private void UpdateVolume(float timeOfDay24) {} // 0x00000001814AF290-0x00000001814AFE60
		// [XID] // 0x00000001897FEB40-0x00000001897FEB60
		private void UpdateSkill(float timeOfDay24) {} // 0x00000001814A8A80-0x00000001814A8BE0
		// [XID] // 0x0000000189806260-0x0000000189806280
		private void UpdateCharacterLight(float timeOfDay24) {} // 0x00000001814A8BE0-0x00000001814A8CA0
		// [XID] // 0x000000018980D930-0x000000018980D950
		private void UpdateTransition() {} // 0x00000001814BE0F0-0x00000001814BE360
		// [XID] // 0x00000001898150F0-0x0000000189815110
		private void UpdateLight() {} // 0x00000001814BA050-0x00000001814BA200
		// [XID] // 0x000000018981CB20-0x000000018981CB40
		private void UpdateSky() {} // 0x00000001814ABFE0-0x00000001814AC190
		// [XID] // 0x0000000189823FB0-0x0000000189823FD0
		private void UpdateClouds() {} // 0x00000001814B64D0-0x00000001814B70F0
		// [XID] // 0x000000018982B9F0-0x000000018982BA10
		public void ResetWeatherCloudTexture() {} // 0x00000001814C3380-0x00000001814C34F0
		// [XID] // 0x0000000189832FF0-0x0000000189833010
		private void UpdateFog() {} // 0x00000001814B1360-0x00000001814B16E0
		// [XID] // 0x000000018983A480-0x000000018983A4A0
		private void UpdateEffectSystems() {} // 0x00000001814C0C20-0x00000001814C1030
		// [XID] // 0x00000001898419F0-0x0000000189841A10
		public void UpdateWind() {} // 0x00000001814C5130-0x00000001814C55F0
		// [XID] // 0x0000000189848F30-0x0000000189848F50
		private void UpdateLightRender(float timeOfDay24) {} // 0x00000001814AC190-0x00000001814AC2A0
		// [XID] // 0x00000001898506F0-0x0000000189850710
		private void CalculateAmbientLight() {} // 0x00000001814BC550-0x00000001814BC760
		// [XID] // 0x0000000189857A40-0x0000000189857A60
		private void CalculateDirectLight(float timeOfDay24) {} // 0x00000001814BB6B0-0x00000001814BC020
		// [XID] // 0x000000018985EB70-0x000000018985EB90
		private void UpdateSnow() {} // 0x00000001814BC0C0-0x00000001814BC550
		// [XID] // 0x00000001898662F0-0x0000000189866310
		private void UpdateGlobalLight() {} // 0x00000001814BE360-0x00000001814BE510
		// [XID] // 0x000000018986DC20-0x000000018986DC40
		private void UpdatePostProcess() {} // 0x00000001814B73A0-0x00000001814B7BA0
		// [XID] // 0x0000000189874F10-0x0000000189874F30
		private void UpdateSkyRender() {} // 0x00000001814BF880-0x00000001814C05F0
		// [XID] // 0x000000018987CC20-0x000000018987CC40
		public void UpdateCharacterLightDir(Vector3 pos) {} // 0x00000001814C4C10-0x00000001814C4DF0
		// [XID] // 0x0000000189883BB0-0x0000000189883BD0
		private void UpdateFogRender() {} // 0x00000001814B57B0-0x00000001814B63F0
		// [XID] // 0x000000018988B290-0x000000018988B2B0
		private void UpdateCloudRender() {} // 0x00000001814B8620-0x00000001814B9160
		// [XID] // 0x0000000189892930-0x0000000189892950
		private void UpdateCharacterLightRender(EnviroCharacterLightSettings characterSetting) {} // 0x00000001814B92E0-0x00000001814B95A0
		// [XID] // 0x000000018989A070-0x000000018989A090
		private void UpdateScreenEffect() {} // 0x00000001814BA7C0-0x00000001814BADE0
		// [XID] // 0x00000001898A1310-0x00000001898A1330
		private float Remap(float value, float from1, float to1, float from2, float to2) => default; // 0x00000001814BCE20-0x00000001814BCF50
		// [XID] // 0x00000001898A8B00-0x00000001898A8B20
		public float GetEmissionRate(ParticleSystem system) => default; // 0x00000001814B4960-0x00000001814B4A90
		// [XID] // 0x00000001898B04B0-0x00000001898B04D0
		private void SetEmissionRate(EnviroWeatherPrefab prefab, float curRatio, int mode) {} // 0x00000001814B2580-0x00000001814B2A30
		// [XID] // 0x0000000189851A20-0x0000000189851A40
		private void UpdateEmissionColor(EnviroWeatherPrefab prefab) {} // 0x00000001814BF170-0x00000001814BF880
		// [XID] // 0x00000001898BF090-0x00000001898BF0B0
		public void CalculateNewWind(bool force = false /* Metadata: 0x00B127BF */) {} // 0x00000001814AC2A0-0x00000001814AC610
		// [XID] // 0x00000001898C6A20-0x00000001898C6A40
		public void SetWindStr(float str) {} // 0x00000001814C3F40-0x00000001814C40D0
		// [XID] // 0x00000001898CE010-0x00000001898CE030
		public void SetWindDir(float dir) {} // 0x00000001814C3E60-0x00000001814C3F40
		// [XID] // 0x00000001898D5AC0-0x00000001898D5AE0
		private void UpdateLensFlare() {} // 0x00000001814B2A30-0x00000001814B2B30
		// [XID] // 0x00000001898DD710-0x00000001898DD730
		private void DrawLensFlare() {} // 0x00000001814BAF10-0x00000001814BB190
		// [XID] // 0x00000001898E4F70-0x00000001898E4F90
		public void EnableLensFlare(bool enable) {} // 0x00000001814B0F70-0x00000001814B1110
		// [XID] // 0x00000001898EC820-0x00000001898EC840
		public void UpdateWeatherEffect() {} // 0x00000001814C5090-0x00000001814C5130
		// [XID] // 0x00000001898F4230-0x00000001898F4250
		private void UpdateRainOccluder() {} // 0x00000001814B1E80-0x00000001814B2180
		// [XID] // 0x00000001898FB980-0x00000001898FB9A0
		private void UpdateRainEffect() {} // 0x00000001814ABBD0-0x00000001814ABFE0
		// [XID] // 0x0000000189903390-0x00000001899033B0
		public void ResetWeatherRainEffectTexture() {} // 0x00000001814C34F0-0x00000001814C3620
		// [XID] // 0x000000018990A8C0-0x000000018990A8E0
		private void UpdateThunder() {} // 0x00000001814AFE60-0x00000001814B0420
		// [XID] // 0x0000000189912510-0x0000000189912530
		private void FireOneThunder(float minRange, float maxRange, float realMaxRange, float lightingAngle, bool isFar, string lightningPrefab, string cloudObj, string impactObj, EnviroThunderSettings preset) {} // 0x00000001814BD390-0x00000001814BDB10
		// [XID] // 0x0000000189919DF0-0x0000000189919E10
		public Vector3 ComputeLightningBornPos(float lightningHitOrNotRatio, float selectRange, float hitHeightRatio, float maxOffsetLen) => default; // 0x00000001814AD320-0x00000001814AE2E0
		// [XID] // 0x0000000189921660-0x0000000189921680
		private bool EnableLightning() => default; // 0x00000001814B70F0-0x00000001814B7270
		// [XID] // 0x0000000189928D80-0x0000000189928DA0
		public void FireStormEffect(Vector3 to, float height) {} // 0x00000001814B2CC0-0x00000001814B2F30
		// [XID] // 0x00000001899302B0-0x00000001899302D0
		private void PlayThunderEffect(Vector3 from, Vector3 to, string lightningPrefab, string cloudObj, string impactObj, bool isFar) {} // 0x00000001814B3E20-0x00000001814B41C0
		// [XID] // 0x0000000189937770-0x0000000189937790
		public void DrawRainbow() {} // 0x00000001814B0C50-0x00000001814B0DA0
		// [XID] // 0x000000018993F290-0x000000018993F2B0
		public void ShowRainbow() {} // 0x00000001814C4870-0x00000001814C4B60
		// [XID] // 0x0000000189946840-0x0000000189946860
		private void UpdateRainbow() {} // 0x00000001814B3CA0-0x00000001814B3E20
		// [XID] // 0x000000018994DF20-0x000000018994DF40
		private void CalculateNewGalaxy(bool isWeatherChange = false /* Metadata: 0x00B127C0 */) {} // 0x00000001814B2B30-0x00000001814B2CC0
		// [XID] // 0x0000000189955580-0x00000001899555A0
		private void EnableGalaxy(bool enable) {} // 0x00000001814AAE20-0x00000001814AAF00
		// [XID] // 0x000000018995D040-0x000000018995D060
		private void DrawGalaxy() {} // 0x00000001814BDB10-0x00000001814BDDE0
		// [XID] // 0x0000000189964700-0x0000000189964720
		private void ResetTransitionSetting(float transTime = -1f /* Metadata: 0x00B127C1 */, float ratio = 0f /* Metadata: 0x00B127C5 */) {} // 0x00000001814BA580-0x00000001814BA7C0
		// [XID] // 0x000000018996BE10-0x000000018996BE30
		private void ResetWeatherTransitionSetting(float transTime = -1f /* Metadata: 0x00B127C9 */, float ratio = 0f /* Metadata: 0x00B127CD */) {} // 0x00000001814B5320-0x00000001814B55F0
		// [XID] // 0x0000000189973900-0x0000000189973920
		private void ResetVolumeTransitionSetting(float transTime = -1f /* Metadata: 0x00B127D1 */, float ratio = 0f /* Metadata: 0x00B127D5 */) {} // 0x00000001814BDDE0-0x00000001814BE0F0
		// [XID] // 0x000000018997AF50-0x000000018997AF70
		public bool ChangeMainArea(string p, bool needTransition = true /* Metadata: 0x00B127D9 */) => default; // 0x00000001814AC880-0x00000001814ACA70
		// [XID] // 0x0000000189982A30-0x0000000189982A50
		public bool ApplyProfile(string newProfileName, float transTime = -1f /* Metadata: 0x00B127DA */, float ratio = 0f /* Metadata: 0x00B127DE */, bool forceLoad = false /* Metadata: 0x00B127E2 */) => default; // 0x00000001814A9A70-0x00000001814AA2F0
		// [XID] // 0x000000018998A250-0x000000018998A270
		public List<string> GetCurWeatherList() => default; // 0x00000001814B4740-0x00000001814B4960
		// [XID] // 0x0000000189991B40-0x0000000189991B60
		public string Climate2WeatherName(ClimateType type) => default; // 0x00000001814AD0A0-0x00000001814AD320
		// [XID] // 0x0000000189999830-0x0000000189999850
		private string GenClimateWeatherName(Climate2Weather climate) => default; // 0x00000001814B2300-0x00000001814B2580
		// [XID] // 0x00000001899A0F00-0x00000001899A0F20
		public bool ChangeWeather(string weatherPath, float transTime = -1f /* Metadata: 0x00B127E3 */, float ratio = 0f /* Metadata: 0x00B127E7 */) => default; // 0x00000001814ACC80-0x00000001814AD000
		// [XID] // 0x00000001899A8970-0x00000001899A8990
		private bool SetWeather(EnviroWeatherPreset preset, float transTime = -1f /* Metadata: 0x00B127EB */, float ratio = 0f /* Metadata: 0x00B127EF */) => default; // 0x00000001814AA480-0x00000001814AAE20
		// [XID] // 0x00000001899B0250-0x00000001899B0270
		public void WeatherRefresh() {} // 0x00000001814C5940-0x00000001814C5A00
		// [XID] // 0x00000001899B7500-0x00000001899B7520
		private bool IsValidWeatherEffect(EffectEnvPlatformType type) => default; // 0x00000001814AA3C0-0x00000001814AA480
		// [XID] // 0x00000001899BEFA0-0x00000001899BEFC0
		private EnviroWeatherPrefab CreateWeatherPrefabType(EnviroWeatherPreset preset) => default; // 0x00000001814A8600-0x00000001814A8A80
		// [XID] // 0x00000001899C6960-0x00000001899C6980
		private void RemoveWeatherPrefab(EnviroWeatherPrefab weatherPrefab) {} // 0x00000001814B55F0-0x00000001814B57B0
		// [XID] // 0x00000001899CDEE0-0x00000001899CDF00
		public virtual void NotifyWeatherChanged(EnviroWeatherPreset type) {} // 0x00000001814BE790-0x00000001814BE850
		// [XID] // 0x00000001899D5650-0x00000001899D5670
		public virtual void NotifyWeatherEffectChanged(EnviroWeatherPreset type2) {} // 0x00000001814BE850-0x00000001814BE910
		// [XID] // 0x00000001899DC9F0-0x00000001899DCA10
		public virtual void NotifyWeatherChangeFinish(EnviroWeatherPreset type1, EnviroWeatherPreset type2) {} // 0x00000001814BE6B0-0x00000001814BE790
		// [XID] // 0x00000001899E4670-0x00000001899E4690
		public bool ChangeVolume(string volumePath, float transTime = -1f /* Metadata: 0x00B127F3 */, float ratio = 0f /* Metadata: 0x00B127F7 */, int volPrio = 0 /* Metadata: 0x00B127FB */) => default; // 0x00000001814ACA70-0x00000001814ACC80
		// [XID] // 0x00000001899EB920-0x00000001899EB940
		private EnviroWeatherPreset GenerateVolumePreset(string presetPath) => default; // 0x00000001814BC880-0x00000001814BCC30
		// [XID] // 0x00000001899F3450-0x00000001899F3470
		private bool SetVolume(EnviroWeatherPreset preset, float transTime = -1f /* Metadata: 0x00B127FF */, float ratio = 1f /* Metadata: 0x00B12803 */) => default; // 0x00000001814B95A0-0x00000001814BA050
		// [XID] // 0x00000001899FAE10-0x00000001899FAE30
		public void ResetVolumeCloudTexture() {} // 0x00000001814C3210-0x00000001814C3380
		// [XID] // 0x0000000189A01FF0-0x0000000189A02010
		public bool RemoveVolume(string name, float transTime, float ratio) => default; // 0x00000001814C2C60-0x00000001814C2DF0
		// [XID] // 0x0000000189A09830-0x0000000189A09850
		public bool RealRemoveVolume(float transTime, float ratio) => default; // 0x00000001814C1500-0x00000001814C17B0
		// [XID] // 0x0000000189A10F90-0x0000000189A10FB0
		public virtual void NotifyVolumeChanged(EnviroWeatherPreset type) {} // 0x00000001814BE5F0-0x00000001814BE6B0
		// [XID] // 0x0000000189A18310-0x0000000189A18330
		public virtual void NotifyVolumeChangeFinish(EnviroWeatherPreset type1, EnviroWeatherPreset type2) {} // 0x00000001814BE510-0x00000001814BE5F0
		// [XID] // 0x0000000189A1F9F0-0x0000000189A1FA10
		public void SetSkillEffect(string path, float transTime) {} // 0x00000001814C3900-0x00000001814C3B90
		// [XID] // 0x0000000189A26DD0-0x0000000189A26DF0
		public void RemoveSkillEffect(string path, float transTime) {} // 0x00000001814C2B00-0x00000001814C2C60
		// [XID] // 0x0000000189A2E5E0-0x0000000189A2E600
		public void ResetByMultiPlatformConfig(EnviroPlatformProfile profile) {} // 0x00000001814C2FB0-0x00000001814C3150
		// [XID] // 0x0000000189A35F60-0x0000000189A35F80
		public bool ForceUpdateWeather(string startPath, string weatherPath, float normalizedRatio, WeatherControllerClipOverrideTransition weatherClipOverrideTransition = null) => default; // 0x00000001814B2F30-0x00000001814B3BE0
		// [XID] // 0x0000000189A3D560-0x0000000189A3D580
		public void EnableUpdate(bool enable) {} // 0x00000001814B12B0-0x00000001814B1360
		// [XID] // 0x0000000189A44C30-0x0000000189A44C50
		public void EnableUpdateWeather(bool enable) {} // 0x00000001814B1200-0x00000001814B12B0
		// [XID] // 0x0000000189A4C480-0x0000000189A4C4A0
		public Vector3 GetWindDirection() => default; // 0x00000001814B5110-0x00000001814B5230
		// [XID] // 0x0000000189A53BE0-0x0000000189A53C00
		public float GetWindSpeed() => default; // 0x00000001814B5230-0x00000001814B5320
		// [XID] // 0x0000000189A5B600-0x0000000189A5B620
		public float GetWindChangeRatio() => default; // 0x00000001814B5050-0x00000001814B5110
		// [XID] // 0x0000000189A62C50-0x0000000189A62C70
		public Vector3 GetSunLightDirection(float time, float sunAngle, float sunInclination, float sunInclinationOffset) => default; // 0x00000001814B4E10-0x00000001814B5050
		// [XID] // 0x0000000189A6A830-0x0000000189A6A850
		public Vector3 GetMoonLightDirection(float time, float moonAngle, float moonInclination, float moonInclinationOffset, float moonOrbitOffset) => default; // 0x00000001814B4A90-0x00000001814B4CF0
		// [XID] // 0x0000000189A71EC0-0x0000000189A71EE0
		public Vector4 GetBlendFactorForHeight(float height) => default; // 0x00000001814B44C0-0x00000001814B46A0
		// [XID] // 0x0000000189A79B20-0x0000000189A79B40
		public void OnHourPassed(int hour) {} // 0x00000001814C09D0-0x00000001814C0AE0
		// [XID] // 0x0000000189A80FC0-0x0000000189A80FE0
		public void OnDayNotify() {} // 0x00000001814C06B0-0x00000001814C07E0
		// [XID] // 0x0000000189A889D0-0x0000000189A889F0
		public void OnNightNotify() {} // 0x00000001814C0AE0-0x00000001814C0C20
		// [XID] // 0x0000000189A901D0-0x0000000189A901F0
		private EnviroWindZone GetWindZone(int id) => default; // 0x00000001814A8CA0-0x00000001814A8DA0
		// [XID] // 0x0000000189A979C0-0x0000000189A979E0
		public Dictionary<int, EnviroWindZone> GetAllWindZones() => default; // 0x00000001814B4410-0x00000001814B44C0
		// [IDTag] // 0x0000000189A9ED60-0x0000000189A9EDA0
		// [XID] // 0x0000000189A9ED60-0x0000000189A9EDA0
		public void SetWindZone(WindZone windZone) {} // 0x00000001814C40D0-0x00000001814C4330
		// [IDTag] // 0x0000000189AA9310-0x0000000189AA9350
		// [XID] // 0x0000000189AA9310-0x0000000189AA9350
		public void SetWindZone(int id, Vector3 pos, Vector3 direction, float strength) {} // 0x00000001814C46C0-0x00000001814C4870
		// [IDTag] // 0x0000000189AB3DF0-0x0000000189AB3E30
		// [XID] // 0x0000000189AB3DF0-0x0000000189AB3E30
		public void SetWindZone(int id, Vector3 pos, float radius, float strength) {} // 0x00000001814C4330-0x00000001814C44C0
		// [IDTag] // 0x0000000189ABE8B0-0x0000000189ABE8F0
		// [XID] // 0x0000000189ABE8B0-0x0000000189ABE8F0
		public void SetWindZone(int id, Vector3 pos, Vector3 direction, float angle, float radius, float strength) {} // 0x00000001814C44C0-0x00000001814C46C0
		// [IDTag] // 0x0000000189AC9010-0x0000000189AC9050
		// [XID] // 0x0000000189AC9010-0x0000000189AC9050
		public void RemoveWindZone(WindZone windZone) {} // 0x00000001814C2DF0-0x00000001814C2EC0
		// [IDTag] // 0x0000000189AD3C40-0x0000000189AD3C80
		// [XID] // 0x0000000189AD3C40-0x0000000189AD3C80
		public void RemoveWindZone(int id) {} // 0x00000001814C2EC0-0x00000001814C2FB0
		// [XID] // 0x0000000189ADE9B0-0x0000000189ADE9D0
		private void UpdateLastProfile(float timeOfDay24) {} // 0x00000001814B0DA0-0x00000001814B0EC0
		// [XID] // 0x0000000189AE6370-0x0000000189AE6390
		private void CloneCurrentProfile() {} // 0x00000001814BE910-0x00000001814BEA30
		// [IDTag] // 0x0000000189AEDAC0-0x0000000189AEDB00
		// [XID] // 0x0000000189AEDAC0-0x0000000189AEDB00
		public void DelightPlayer(bool enable, BaseEntity entity, Color main, Color ambient, Vector3? dir = default) {} // 0x00000001814B06C0-0x00000001814B0A70
		// [XID] // 0x0000000189AF82B0-0x0000000189AF82D0
		public void DelightModel(bool enable, BaseEntity entity, Color main, Color ambient, Vector3? dir = default) {} // 0x00000001814B0420-0x00000001814B06C0
		// [IDTag] // 0x0000000189AFF980-0x0000000189AFF9C0
		// [XID] // 0x0000000189AFF980-0x0000000189AFF9C0
		public void DelightPlayer(bool enable) {} // 0x00000001814B0A70-0x00000001814B0C50
		// [XID] // 0x0000000189B0A210-0x0000000189B0A230
		public bool SetCurrentScreenEffect(int index, float initial_intensity = 1f /* Metadata: 0x00B12807 */) => default; // 0x00000001814C3620-0x00000001814C3780
		// [XID] // 0x0000000189B11910-0x0000000189B11930
		public void SetEffectIntensity(float intensity) {} // 0x00000001814C3780-0x00000001814C3830
		// [XID] // 0x0000000189B18C40-0x0000000189B18C60
		public void EnableSceneUISetup(bool enable) {} // 0x00000001814B1110-0x00000001814B1200
		// [XID] // 0x0000000189B20310-0x0000000189B20330
		public void SetUISceneConfig(string settingPath) {} // 0x00000001814C3B90-0x00000001814C3E60
		// [XID] // 0x0000000189B278E0-0x0000000189B27900
		private void ResetPlayerColor(EnviroUISceneSetting uiSceneSetting, EnviroCharacterLightSettings characterSetting) {} // 0x00000001814BD260-0x00000001814BD390
		// [XID] // 0x0000000189B2EBF0-0x0000000189B2EC10
		public void OnCurSurfaceChanged(SceneSurfaceMaterial surfaceMaterial) {} // 0x00000001814C05F0-0x00000001814C06B0
		// [XID] // 0x0000000189B36470-0x0000000189B36490
		public void EnableBloom(bool enable) {} // 0x00000001814B0EC0-0x00000001814B0F70
		// [XID] // 0x0000000189B3DC30-0x0000000189B3DC50
		public void PostProcessExposure(float expo) {} // 0x00000001814C1320-0x00000001814C1450
		// [XID] // 0x0000000189B459B0-0x0000000189B459D0
		public float GetPostProcessExposure() => default; // 0x00000001814B4CF0-0x00000001814B4E10
		// [XID] // 0x0000000189B4CE30-0x0000000189B4CE50
		public bool ChangeCharacterLight(string characterLightPath, bool changeConfigPath = false /* Metadata: 0x00B1280B */) => default; // 0x00000001814AC610-0x00000001814AC880
	}
}
