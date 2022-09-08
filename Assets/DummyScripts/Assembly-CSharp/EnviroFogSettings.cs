/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public class EnviroFogSettings // TypeDefIndex: 31473
{
	// Fields
	public string profileName; // 0x10
	[NonSerialized]
	public Config config; // 0x18
	// [Tooltip] // 0x000000018984C090-0x000000018984C0C0
	public FogMode Fogmode; // 0x120
	// [Header] // 0x0000000189854960-0x00000001898549C0
	// [Tooltip] // 0x0000000189854960-0x00000001898549C0
	public EnviroConfigFloat startDistance; // 0x128
	public EnviroConfigFloat endDistance; // 0x158
	// [Header] // 0x0000000189862170-0x00000001898621A0
	public EnviroConfigColor bottomColor; // 0x188
	// [Tooltip] // 0x000000018986AE10-0x000000018986AE40
	public EnviroConfigFloat bottomIntensity; // 0x1A8
	public EnviroConfigColor topColor; // 0x1D8
	// [Tooltip] // 0x0000000189873890-0x00000001898738C0
	public EnviroConfigFloat topIntensity; // 0x1F8
	// [Tooltip] // 0x000000018987CC40-0x000000018987CC70
	public EnviroConfigFloat linearFogPower; // 0x228
	// [Tooltip] // 0x00000001898B04D0-0x00000001898B0500
	public EnviroConfigFloat linearFogEnd; // 0x258
	// [Tooltip] // 0x00000001898B04D0-0x00000001898B0500
	public EnviroConfigFloat linearHeightRange; // 0x288
	public EnviroConfigColor fogColor; // 0x2B8
	public EnviroConfigColor farFogColor; // 0x2D8
	// [Range] // 0x0000000189895610-0x0000000189895660
	// [Tooltip] // 0x0000000189895610-0x0000000189895660
	public EnviroConfigFloat density; // 0x2F8
	public EnviroConfigFloat fogSwitchDistance; // 0x328
	// [Tooltip] // 0x00000001898B04D0-0x00000001898B0500
	public EnviroConfigFloat heightFogFallOff; // 0x358
	// [Tooltip] // 0x00000001898B04D0-0x00000001898B0500
	public EnviroConfigFloat bottomFogFallOff; // 0x388
	// [Tooltip] // 0x00000001898B04D0-0x00000001898B0500
	public EnviroConfigFloat fogHeight; // 0x3B8
	// [Tooltip] // 0x000000018966C210-0x000000018966C240
	public EnviroConfigFloat rampStart; // 0x3E8
	// [Tooltip] // 0x00000001896740B0-0x00000001896740E0
	public EnviroConfigFloat rampRange; // 0x418
	// [Tooltip] // 0x00000001898C9C50-0x00000001898C9C80
	public EnviroConfigFloat rampWrap; // 0x448
	// [Tooltip] // 0x00000001899D3F40-0x00000001899D3F70
	public EnviroConfigFloat densityClamp; // 0x478
	// [Tooltip] // 0x0000000189683000-0x0000000189683030
	public EnviroConfigFloat heightFogHorFadeStart; // 0x4A8
	// [Tooltip] // 0x00000001898E3690-0x00000001898E36C0
	public EnviroConfigFloat heightFogHorFadeRange; // 0x4D8
	// [Tooltip] // 0x00000001896927B0-0x00000001896927E0
	public EnviroConfigFloat heightFogVerFadeRange; // 0x508
	public bool heightFog2ndEnable; // 0x538
	public EnviroConfigColor heightFog2ndColor; // 0x540
	public EnviroConfigFloat heightFog2ndDensity; // 0x560
	public bool heightFog2ndUseAbsoluteHeight; // 0x590
	public EnviroConfigFloat heightFog2ndAbsoluteHeight; // 0x598
	public EnviroConfigFloat heightFog2ndHeight; // 0x5C8
	public EnviroConfigFloat heightFog2ndFallOff; // 0x5F8
	public EnviroConfigFloat heightFog2ndNearFadeStart; // 0x628
	public EnviroConfigFloat heightFog2ndNearFadeRange; // 0x658
	public EnviroConfigFloat heightFog2ndFarFadeStart; // 0x688
	public EnviroConfigFloat heightFog2ndFarFadeRange; // 0x6B8
	// [Tooltip] // 0x0000000189699AE0-0x0000000189699B10
	public EnviroConfigFloat heightFogLinearColSkyColIntensity; // 0x6E8
	// [Tooltip] // 0x00000001896A1270-0x00000001896A12A0
	public EnviroConfigFloat heightFogFarColSkyColIntensity; // 0x718
	// [Tooltip] // 0x00000001896A86E0-0x00000001896A8710
	public EnviroConfigFloat heightFogColSkyColIntensity; // 0x748
	// [Header] // 0x00000001896B89C0-0x00000001896B89F0
	public EnviroConfigFloat volumeFogDensityScale; // 0x778
	public EnviroConfigFloat volumeFogScatterStrength; // 0x7A8
	public EnviroConfigFloat volumeFogScatterAnisotropy; // 0x7D8
	public EnviroConfigColor volumeFogScatteringColorFront; // 0x808
	public EnviroConfigColor volumeFogScatteringColorBack; // 0x828
	public EnviroConfigFloat volumeFogDefaultDensity; // 0x848
	public EnviroConfigFloat volumeFogDefaultStart; // 0x878
	public EnviroConfigFloat volumeFogDefaultFalloff; // 0x8A8
	public EnviroConfigFloat godRayStrength; // 0x8D8
	public EnviroConfigFloat godRayRange; // 0x908

	// Nested types
	public struct Config // TypeDefIndex: 31474
	{
		// Fields
		public float startDistance; // 0x00
		public float endDistance; // 0x04
		public Color bottomColor; // 0x08
		public float bottomIntensity; // 0x18
		public Color topColor; // 0x1C
		public float topIntensity; // 0x2C
		public float linearFogPower; // 0x30
		public float linearFogEnd; // 0x34
		public float linearHeightRange; // 0x38
		public Color fogColor; // 0x3C
		public Color farFogColor; // 0x4C
		public float density; // 0x5C
		public float fogSwitchDistance; // 0x60
		public float heightFogFallOff; // 0x64
		public float bottomFogFallOff; // 0x68
		public float fogHeight; // 0x6C
		public float rampStart; // 0x70
		public float rampRange; // 0x74
		public float rampWrap; // 0x78
		public float densityClamp; // 0x7C
		public float heightFogHorFadeStart; // 0x80
		public float heightFogHorFadeRange; // 0x84
		public float heightFogVerFadeRange; // 0x88
		public Color heightFog2ndColor; // 0x8C
		public float heightFog2ndDensity; // 0x9C
		public float heightFog2ndFollowCamera; // 0xA0
		public float heightFog2ndHeight; // 0xA4
		public float heightFog2ndFallOff; // 0xA8
		public float heightFog2ndNearFadeStart; // 0xAC
		public float heightFog2ndNearFadeRange; // 0xB0
		public float heightFog2ndFarFadeStart; // 0xB4
		public float heightFog2ndFarFadeRange; // 0xB8
		public float heightFogLinearColSkyColIntensity; // 0xBC
		public float heightFogFarColSkyColIntensity; // 0xC0
		public float heightFogColSkyColIntensity; // 0xC4
		public float volumeFogDensityScale; // 0xC8
		public float volumeFogScatterStrength; // 0xCC
		public float volumeFogScatterAnisotropy; // 0xD0
		public Color volumeFogScatteringColorFront; // 0xD4
		public Color volumeFogScatteringColorBack; // 0xE4
		public float volumeFogDefaultDensity; // 0xF4
		public float volumeFogDefaultStart; // 0xF8
		public float volumeFogDefaultFalloff; // 0xFC
		public float godRayStrength; // 0x100
		public float godRayRange; // 0x104
	}

	// Constructors
	public EnviroFogSettings() {} // 0x00000001836972B0-0x0000000183698740

	// Methods
	public void Clone(EnviroFogSettings fromSettings) {} // 0x0000000183696000-0x00000001836960F0
	public void Evaluate(float time) {} // 0x00000001836960F0-0x0000000183696970
	public void Lerp(EnviroFogSettings targetSetting, float ratio, float current_ratio) {} // 0x0000000183696970-0x00000001836972B0
}

