/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public class EnviroLightSettings // TypeDefIndex: 31469
{
	// Fields
	public string profileName; // 0x10
	[NonSerialized]
	public Config config; // 0x18
	// [Tooltip] // 0x0000000189763750-0x0000000189763780
	public EnviroConfigColor mainLightColor; // 0x98
	public EnviroConfigFloat mainLightIntensity; // 0xB8
	// [Tooltip] // 0x000000018976C6C0-0x000000018976C6F0
	public EnviroConfigFloat shadowStrength; // 0xE8
	// [Tooltip] // 0x0000000189775370-0x00000001897753A0
	public bool adjustLightIfNoShadow; // 0x118
	// [Tooltip] // 0x000000018977E3B0-0x000000018977E3E0
	public float lightStrengthRatioNoShadow; // 0x11C
	// [Tooltip] // 0x00000001897874B0-0x00000001897874E0
	public AmbientMode ambientMode; // 0x120
	// [Tooltip] // 0x00000001895F1660-0x00000001895F1690
	public EnviroConfigColor ambientSkyColor; // 0x128
	// [Tooltip] // 0x00000001899AA150-0x00000001899AA180
	public EnviroConfigColor ambientEquatorColor; // 0x148
	// [Tooltip] // 0x00000001899B1B40-0x00000001899B1B70
	public EnviroConfigColor ambientGroundColor; // 0x168
	// [Tooltip] // 0x00000001897AB380-0x00000001897AB3B0
	public EnviroConfigFloat hbaoStrength; // 0x188
	// [Tooltip] // 0x00000001897B5040-0x00000001897B5070
	public EnviroConfigFloat hbaoMaximum; // 0x1B8
	public float lightClampThreshold; // 0x1E8
	public float baseSunDawnThreshold; // 0x1EC
	public float dayNightLerpSpeed; // 0x1F0
	// [Range] // 0x0000000189927470-0x0000000189927490
	public float transparentEnvironmentIntensity; // 0x1F4
	public Color moblieLODReflectionColor; // 0x1F8
	public EnviroConfigFloat postProcessThreshold; // 0x208
	public EnviroConfigFloat postProcessExposure; // 0x238
	public EnviroConfigFloat postProcessContrast; // 0x268
	public EnviroConfigFloat autoExposureMinEV; // 0x298
	public EnviroConfigFloat autoExposureMaxEV; // 0x2C8
	public EnviroConfigFloat autoExposureCompensation; // 0x2F8
	public bool colorgradingCustomized; // 0x328
	// [Tooltip] // 0x00000001897C5BD0-0x00000001897C5C00
	public Texture colorgradingForegroundLutTex; // 0x330
	// [Range] // 0x00000001897CD380-0x00000001897CD3A0
	public float colorgradingForegroundDistance; // 0x338
	// [Tooltip] // 0x00000001897D4A10-0x00000001897D4A40
	public Texture colorgradingBackgroundLutTex; // 0x340
	// [Range] // 0x00000001897CD380-0x00000001897CD3A0
	public float colorgradingBackgroundDistance; // 0x348
	// [Range] // 0x00000001897E3920-0x00000001897E3980
	// [Tooltip] // 0x00000001897E3920-0x00000001897E3980
	public float colorgradingFadePow; // 0x34C
	// [Tooltip] // 0x00000001897EE520-0x00000001897EE550
	public Texture colorgradingCharactorLutTex; // 0x350
	// [Tooltip] // 0x00000001897F5D00-0x00000001897F5D30
	public Texture snowHeight; // 0x358
	// [Tooltip] // 0x00000001897FEB60-0x00000001897FEB90
	public Texture snowAlbedo; // 0x360
	// [Tooltip] // 0x0000000189807AC0-0x0000000189807AF0
	public Vector4 snowDirAndPow; // 0x368
	public float snowHeightTilling; // 0x378
	public float snowDetailHeightTilling; // 0x37C
	// [Range] // 0x00000001898273A0-0x00000001898273C0
	public float snowRimIntensity; // 0x380
	// [Range] // 0x000000018981FD10-0x000000018981FD30
	public float snowParallaxFadeOutStart; // 0x384
	// [Range] // 0x000000018981FD10-0x000000018981FD30
	public float snowParallaxFadeOutEnd; // 0x388
	public Color snowTopColor; // 0x38C
	public Color snowBottomColor; // 0x39C
	// [Range] // 0x00000001898273A0-0x00000001898273C0
	public float snowGlitterPow; // 0x3AC
	// [Range] // 0x000000018982E5E0-0x000000018982E600
	public float snowGlitterScale; // 0x3B0
	// [Range] // 0x000000018982E5E0-0x000000018982E600
	public float snowGlitterMaskScale; // 0x3B4
	public float snowAltitudeMax; // 0x3B8
	public float snowAltitudeMin; // 0x3BC
	// [Range] // 0x000000018983D470-0x000000018983D490
	public float snowAltitudeOffsetMax; // 0x3C0
	// [Range] // 0x000000018983D470-0x000000018983D490
	public float snowAltitudeOffsetMin; // 0x3C4
	public EnviroConfigFloat treeDiffuseRampScale; // 0x3C8
	public EnviroConfigFloat treeDiffuseRampOffset; // 0x3F8
	public EnviroConfigFloat treeShadowIntensity; // 0x428
	public Color ColorSaturation; // 0x458
	public Color ColorContrast; // 0x468
	public Color ColorGamma; // 0x478
	public Color ColorGain; // 0x488
	public Color ColorOffset; // 0x498
	public Color ColorSaturationShadows; // 0x4A8
	public Color ColorContrastShadows; // 0x4B8
	public Color ColorGammaShadows; // 0x4C8
	public Color ColorGainShadows; // 0x4D8
	public Color ColorOffsetShadows; // 0x4E8
	public Color ColorSaturationMidtones; // 0x4F8
	public Color ColorContrastMidtones; // 0x508
	public Color ColorGammaMidtones; // 0x518
	public Color ColorGainMidtones; // 0x528
	public Color ColorOffsetMidtones; // 0x538
	public Color ColorSaturationHighlights; // 0x548
	public Color ColorContrastHighlights; // 0x558
	public Color ColorGammaHighlights; // 0x568
	public Color ColorGainHighlights; // 0x578
	public Color ColorOffsetHighlights; // 0x588
	public float ColorCorrectionShadowsMax; // 0x598
	public float ColorCorrectionHighlightsMin; // 0x59C

	// Nested types
	public struct Config // TypeDefIndex: 31470
	{
		// Fields
		public Color mainLightColor; // 0x00
		public float mainLightIntensity; // 0x10
		public float shadowStrength; // 0x14
		public bool adjustLightIfNoShadow; // 0x18
		public float lightStrengthRatioNoShadow; // 0x1C
		public Color ambientSkyColor; // 0x20
		public Color ambientEquatorColor; // 0x30
		public Color ambientGroundColor; // 0x40
		public float hbaoStrength; // 0x50
		public float hbaoMaximum; // 0x54
		public float postProcessThreshold; // 0x58
		public float postProcessExposure; // 0x5C
		public float postProcessContrast; // 0x60
		public float autoExposureMinEV; // 0x64
		public float autoExposureMaxEV; // 0x68
		public float autoExposureCompensation; // 0x6C
		public float treeDiffuseRampScale; // 0x70
		public float treeDiffuseRampOffset; // 0x74
		public float treeShadowIntensity; // 0x78
	}

	// Constructors
	public EnviroLightSettings() {} // 0x0000000183699480-0x000000018369A100

	// Methods
	public void Clone(EnviroLightSettings fromSettings) {} // 0x0000000183698BA0-0x0000000183698C70
	public void Evaluate(float time) {} // 0x0000000183698C70-0x00000001836990B0
	public void Lerp(EnviroLightSettings targetSetting, float ratio) {} // 0x00000001836990B0-0x0000000183699480
}

