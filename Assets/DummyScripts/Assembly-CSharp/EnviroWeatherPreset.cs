/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public class EnviroWeatherPreset : ScriptableObject // TypeDefIndex: 31518
{
	// Fields
	public ConfigWeatherType type; // 0x18
	public WeatherPresetType presetType; // 0x1C
	public string version; // 0x20
	public int priority; // 0x28
	public bool notGenEnergy; // 0x2C
	[NonSerialized]
	public string path; // 0x30
	[NonSerialized]
	public Config config; // 0x38
	// [Header] // 0x00000001899964F0-0x0000000189996550
	// [Tooltip] // 0x00000001899964F0-0x0000000189996550
	public bool overrideLightVOL; // 0x280
	public EnviroConfigColor mainLightColor; // 0x288
	// [Tooltip] // 0x000000018976C6C0-0x000000018976C6F0
	public EnviroConfigFloat shadowStrength; // 0x2A8
	// [Tooltip] // 0x00000001895F1660-0x00000001895F1690
	public EnviroConfigColor ambientSkyColor; // 0x2D8
	// [Tooltip] // 0x00000001899AA150-0x00000001899AA180
	public EnviroConfigColor ambientEquatorColor; // 0x2F8
	// [Tooltip] // 0x00000001899B1B40-0x00000001899B1B70
	public EnviroConfigColor ambientGroundColor; // 0x318
	// [Header] // 0x0000000189608010-0x0000000189608040
	public bool overrideSkyVOL; // 0x338
	public bool changeSky; // 0x339
	public EnviroConfigColor topFrontColor; // 0x340
	public EnviroConfigColor topBackColor; // 0x360
	public EnviroConfigColor bottomFrontColor; // 0x380
	public EnviroConfigColor bottomBackColor; // 0x3A0
	// [Header] // 0x0000000189611030-0x0000000189611060
	public bool overrideParticleCloudVOL; // 0x3C0
	public bool enableParticleCloud; // 0x3C1
	public bool overrideCloudsVOL; // 0x3C2
	public EnviroConfigFloat cloudCoverage; // 0x3C8
	public EnviroConfigFloat cloudAgePercent; // 0x3F8
	// [Header] // 0x0000000189619FC0-0x0000000189619FF0
	public EnviroConfigFloat cloudSpeedStrength; // 0x428
	// [Header] // 0x0000000189622CD0-0x0000000189622D00
	public EnviroConfigFloat cloudWispsSpeedStrength; // 0x458
	public EnviroConfigFloat cloudMinSmoothness; // 0x488
	public EnviroConfigFloat cloudMaxSmoothness; // 0x4B8
	public EnviroConfigColor cloudLightFrontColor; // 0x4E8
	public EnviroConfigColor cloudLightBackColor; // 0x508
	public EnviroConfigColor cloudDarkFrontColor; // 0x528
	public EnviroConfigColor cloudDarkBackColor; // 0x548
	public bool enableCloudShadow; // 0x568
	public bool enableCloudShadowMoving; // 0x569
	public bool enableCloudShadowOriented; // 0x56A
	public EnviroConfigFloat cloudMoveRatio; // 0x570
	public EnviroConfigFloat cloudLayerShadowIntensity; // 0x5A0
	public Texture2D cloudShadowTexture; // 0x5D0
	public EnviroConfigFloat uvOffsetX; // 0x5D8
	public EnviroConfigFloat uvOffsetY; // 0x608
	public EnviroConfigFloat uvRepeatX; // 0x638
	public EnviroConfigFloat uvRepeatY; // 0x668
	// [Header] // 0x000000018962BAD0-0x000000018962BB00
	public bool enableSnowEffect; // 0x698
	// [Header] // 0x0000000189635030-0x0000000189635060
	public bool enableRainEffect; // 0x699
	public Texture2D rainNoiseTexture; // 0x6A0
	public Cubemap rainReflectionTexture; // 0x6A8
	public EnviroConfigFloat rainNoiseTilling; // 0x6B0
	public EnviroConfigFloat rainNoiseSpeed; // 0x6E0
	public EnviroConfigFloat rainNormalLerp; // 0x710
	public EnviroConfigFloat rainReflectionLerp; // 0x740
	public EnviroConfigFloat rainAlbedoScale; // 0x770
	public EnviroConfigFloat rainSpecularScale; // 0x7A0
	public EnviroConfigFloat rainTerrainWetnessRatio; // 0x7D0
	// [Header] // 0x0000000189862170-0x00000001898621A0
	public bool overrideFogVOL; // 0x800
	// [Tooltip] // 0x0000000189645760-0x0000000189645790
	public EnviroConfigFloat fogDensity; // 0x808
	public EnviroConfigColor fogBottomColor; // 0x838
	public EnviroConfigColor fogTopColor; // 0x858
	public EnviroConfigColor fogColor; // 0x878
	public EnviroConfigColor farFogColor; // 0x898
	// [Tooltip] // 0x00000001898B04D0-0x00000001898B0500
	public EnviroConfigFloat linearFogEnd; // 0x8B8
	// [Tooltip] // 0x00000001898B04D0-0x00000001898B0500
	public EnviroConfigFloat linearHeightRange; // 0x8E8
	public EnviroConfigFloat fogSwitchDistance; // 0x918
	// [Tooltip] // 0x00000001899D3F40-0x00000001899D3F70
	public EnviroConfigFloat densityClamp; // 0x948
	// [Tooltip] // 0x0000000189663350-0x0000000189663380
	public EnviroConfigFloat skyboxFogScale; // 0x978
	// [Tooltip] // 0x000000018966C210-0x000000018966C240
	public EnviroConfigFloat fogRampStart; // 0x9A8
	// [Tooltip] // 0x00000001896740B0-0x00000001896740E0
	public EnviroConfigFloat fogRampRange; // 0x9D8
	// [Tooltip] // 0x00000001898C9C50-0x00000001898C9C80
	public EnviroConfigFloat fogRampWrap; // 0xA08
	// [Tooltip] // 0x0000000189683000-0x0000000189683030
	public EnviroConfigFloat heightFogHorFadeStart; // 0xA38
	// [Tooltip] // 0x00000001898E3690-0x00000001898E36C0
	public EnviroConfigFloat heightFogHorFadeRange; // 0xA68
	// [Tooltip] // 0x00000001896927B0-0x00000001896927E0
	public EnviroConfigFloat heightFogVerFadeRange; // 0xA98
	// [Tooltip] // 0x0000000189699AE0-0x0000000189699B10
	public EnviroConfigFloat heightFogLinearColSkyColIntensity; // 0xAC8
	// [Tooltip] // 0x00000001896A1270-0x00000001896A12A0
	public EnviroConfigFloat heightFogFarColSkyColIntensity; // 0xAF8
	// [Tooltip] // 0x00000001896A86E0-0x00000001896A8710
	public EnviroConfigFloat heightFogColSkyColIntensity; // 0xB28
	// [Header] // 0x00000001896AF890-0x00000001896AF8C0
	public bool heightFog2ndOverride; // 0xB58
	public bool heightFog2ndEnable; // 0xB59
	public EnviroConfigColor heightFog2ndColor; // 0xB60
	public EnviroConfigFloat heightFog2ndDensity; // 0xB80
	public bool heightFog2ndUseAbsoluteHeight; // 0xBB0
	public EnviroConfigFloat heightFog2ndAbsoluteHeight; // 0xBB8
	public EnviroConfigFloat heightFog2ndHeight; // 0xBE8
	public EnviroConfigFloat heightFog2ndFallOff; // 0xC18
	public EnviroConfigFloat heightFog2ndNearFadeStart; // 0xC48
	public EnviroConfigFloat heightFog2ndNearFadeRange; // 0xC78
	public EnviroConfigFloat heightFog2ndFarFadeStart; // 0xCA8
	public EnviroConfigFloat heightFog2ndFarFadeRange; // 0xCD8
	// [Header] // 0x00000001896B89C0-0x00000001896B89F0
	public bool volumeFogOverride; // 0xD08
	public EnviroConfigFloat volumeFogDensityScale; // 0xD10
	public EnviroConfigFloat volumeFogScatterStrength; // 0xD40
	public EnviroConfigFloat volumeFogScatterAnisotropy; // 0xD70
	public EnviroConfigColor volumeFogScatteringColorFront; // 0xDA0
	public EnviroConfigColor volumeFogScatteringColorBack; // 0xDC0
	public EnviroConfigFloat volumeFogDefaultDensity; // 0xDE0
	public EnviroConfigFloat volumeFogDefaultStart; // 0xE10
	public EnviroConfigFloat volumeFogDefaultFalloff; // 0xE40
	// [Header] // 0x00000001896BFBE0-0x00000001896BFC10
	public bool godRayOverride; // 0xE70
	public EnviroConfigFloat godRayStrength; // 0xE78
	public EnviroConfigFloat godRayRange; // 0xEA8
	// [Header] // 0x00000001896C8840-0x00000001896C8870
	public bool overrideHeightFogSkyIntensity; // 0xED8
	public float effectChangeNotifyRatio; // 0xEDC
	public List<EnviroWeatherEffects> effectSystems; // 0xEE0
	// [Header] // 0x00000001896D1770-0x00000001896D17D0
	// [Tooltip] // 0x00000001896D1770-0x00000001896D17D0
	public bool overrideLensFlareVOL; // 0xEE8
	public bool useLensFlare; // 0xEE9
	// [Tooltip] // 0x00000001899DB4B0-0x00000001899DB4E0
	public bool hasLightning; // 0xEEA
	public EnviroThunderSettings thunderSettings; // 0xEF0
	// [Tooltip] // 0x000000018992BCD0-0x000000018992BD00
	public EnviroConfigFloat windMinStrength; // 0xEF8
	// [Tooltip] // 0x000000018992BCD0-0x000000018992BD00
	public EnviroConfigFloat windMaxStrength; // 0xF28
	public bool wetness; // 0xF58
	public string rainModifier; // 0xF60
	public bool cold; // 0xF68
	public bool hasRainbow; // 0xF69
	public string rainbowPrefab; // 0xF70
	// [Tooltip] // 0x000000018992BCD0-0x000000018992BD00
	public EnviroConfigFloat rainbowDurationTime; // 0xF78
	// [Tooltip] // 0x00000001896FC8E0-0x00000001896FC910
	public EnviroConfigFloat rainbowPercentage; // 0xFA8
	public bool hasGalaxy; // 0xFD8
	public float galaxyRatio; // 0xFDC
	// [Tooltip] // 0x000000018992BCD0-0x000000018992BD00
	public EnviroConfigFloat galaxyFadeValue; // 0xFE0
	public EnviroConfigColor galaxyLightColor; // 0x1010
	public EnviroConfigColor galaxyDarkColor; // 0x1030
	public EnviroConfigColor galaxyBGColor; // 0x1050
	public EnviroConfigColor dungeonLightColor; // 0x1070
	public EnviroCTSPreset ctsProfile; // 0x1090
	public bool overrideTransition; // 0x1098
	// [Tooltip] // 0x000000018972F210-0x000000018972F240
	public AnimationCurve lightTransitionSpeed; // 0x10A0
	// [Tooltip] // 0x0000000189714460-0x0000000189714490
	public AnimationCurve skyTransitionSpeed; // 0x10A8
	// [Tooltip] // 0x0000000189741460-0x0000000189741490
	public AnimationCurve cloudTransitionSpeed; // 0x10B0
	// [Tooltip] // 0x0000000189723370-0x00000001897233A0
	public AnimationCurve fogTransitionSpeed; // 0x10B8
	// [Tooltip] // 0x000000018975BDB0-0x000000018975BDE0
	public AnimationCurve effectTransitionSpeed; // 0x10C0
	// [Tooltip] // 0x000000018975BDB0-0x000000018975BDE0
	public float transitionTime; // 0x10C8

	// Nested types
	public struct Config // TypeDefIndex: 31519
	{
		// Fields
		public Color mainLightColor; // 0x00
		public float shadowStrength; // 0x10
		public Color ambientSkyColor; // 0x14
		public Color ambientEquatorColor; // 0x24
		public Color ambientGroundColor; // 0x34
		public Color topFrontColor; // 0x44
		public Color topBackColor; // 0x54
		public Color bottomFrontColor; // 0x64
		public Color bottomBackColor; // 0x74
		public float cloudMinSmoothness; // 0x84
		public float cloudMaxSmoothness; // 0x88
		public float cloudAgePercent; // 0x8C
		public float cloudCoverage; // 0x90
		public float cloudSpeedStrength; // 0x94
		public float cloudWispsSpeedStrength; // 0x98
		public Color cloudLightFrontColor; // 0x9C
		public Color cloudLightBackColor; // 0xAC
		public Color cloudDarkFrontColor; // 0xBC
		public Color cloudDarkBackColor; // 0xCC
		public float cloudMoveRatio; // 0xDC
		public float cloudLayerShadowIntensity; // 0xE0
		public float uvOffsetX; // 0xE4
		public float uvOffsetY; // 0xE8
		public float uvRepeatX; // 0xEC
		public float uvRepeatY; // 0xF0
		public float fogDensity; // 0xF4
		public Color fogTopColor; // 0xF8
		public Color fogBottomColor; // 0x108
		public Color fogColor; // 0x118
		public Color farFogColor; // 0x128
		public float linearFogEnd; // 0x138
		public float densityClamp; // 0x13C
		public float fogSwitchDistance; // 0x140
		public float linearHeightRange; // 0x144
		public float skyboxFogScale; // 0x148
		public float fogRampStart; // 0x14C
		public float fogRampRange; // 0x150
		public float fogRampWrap; // 0x154
		public float heightFogHorFadeStart; // 0x158
		public float heightFogHorFadeRange; // 0x15C
		public float heightFogVerFadeRange; // 0x160
		public Color heightFog2ndColor; // 0x164
		public float heightFog2ndDensity; // 0x174
		public float heightFog2ndFollowCamera; // 0x178
		public float heightFog2ndHeight; // 0x17C
		public float heightFog2ndFallOff; // 0x180
		public float heightFog2ndNearFadeStart; // 0x184
		public float heightFog2ndNearFadeRange; // 0x188
		public float heightFog2ndFarFadeStart; // 0x18C
		public float heightFog2ndFarFadeRange; // 0x190
		public float heightFogLinearColSkyColIntensity; // 0x194
		public float heightFogFarColSkyColIntensity; // 0x198
		public float heightFogColSkyColIntensity; // 0x19C
		public float volumeFogDensityScale; // 0x1A0
		public float volumeFogScatterStrength; // 0x1A4
		public float volumeFogScatterAnisotropy; // 0x1A8
		public Color volumeFogScatteringColorFront; // 0x1AC
		public Color volumeFogScatteringColorBack; // 0x1BC
		public float volumeFogDefaultDensity; // 0x1CC
		public float volumeFogDefaultStart; // 0x1D0
		public float volumeFogDefaultFalloff; // 0x1D4
		public float godRayStrength; // 0x1D8
		public float godRayRange; // 0x1DC
		public float windMinStrength; // 0x1E0
		public float windMaxStrength; // 0x1E4
		public float galaxyFadeValue; // 0x1E8
		public Color galaxyBGColor; // 0x1EC
		public Color galaxyLightColor; // 0x1FC
		public Color galaxyDarkColor; // 0x20C
		public Color dungeonLightColor; // 0x21C
		public float rainNoiseTilling; // 0x22C
		public float rainNoiseSpeed; // 0x230
		public float rainNormalLerp; // 0x234
		public float rainReflectionLerp; // 0x238
		public float rainAlbedoScale; // 0x23C
		public float rainSpecularScale; // 0x240
		public float rainTerrainWetnessRatio; // 0x244
	}

	// Constructors
	public EnviroWeatherPreset() {} // 0x00000001836A5EC0-0x00000001836A82F0

	// Methods
	public void Reset() {} // 0x00000001836A5DC0-0x00000001836A5EC0
	public void Evaluate(float time, EnviroLightSettings lightSetting, EnviroFogSettings fogSetting) {} // 0x00000001836A3750-0x00000001836A4C40
	public void EvaluateProfile(EnviroLightSettings lightSetting, EnviroSkySettings skySetting, EnviroCloudSettings cloudSetting, EnviroFogSettings fogSetting, bool changeLight = true /* Metadata: 0x00B1285D */, bool changeSky = true /* Metadata: 0x00B1285E */, bool changeClouds = true /* Metadata: 0x00B1285F */, bool changeFog = true /* Metadata: 0x00B12860 */) {} // 0x00000001836A2FA0-0x00000001836A3750
	public void Clone(EnviroWeatherPreset targetSetting) {} // 0x00000001836A1F10-0x00000001836A2050
	public EnviroWeatherPreset DeepClone(EnviroWeatherPreset cachedPreset = null) => default; // 0x00000001836A2050-0x00000001836A2FA0
	public void Lerp(EnviroWeatherPreset targetSetting, float lightRatio, float skyRatio, float cloudRatio, float fogRatio, float effectRatio) {} // 0x00000001836A4C40-0x00000001836A5DC0
}

