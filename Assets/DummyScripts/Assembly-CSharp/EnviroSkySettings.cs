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
public class EnviroSkySettings // TypeDefIndex: 31471
{
	// Fields
	public string profileName; // 0x10
	[NonSerialized]
	public Config config; // 0x18
	public EnviroConfigColor topFrontColor; // 0x130
	public EnviroConfigColor topBackColor; // 0x150
	public EnviroConfigColor bottomFrontColor; // 0x170
	public EnviroConfigColor bottomBackColor; // 0x190
	public EnviroConfigFloat frontAndBackBlendFactor; // 0x1B0
	public EnviroConfigFloat bottomColorHeight; // 0x1E0
	public EnviroConfigFloat seaLevelHeight; // 0x210
	public EnviroConfigColor horizonHaloColor; // 0x240
	public EnviroConfigFloat horizonHaloIntensity; // 0x260
	public EnviroConfigFloat horizonHaloHeight; // 0x290
	public EnviroConfigFloat sunAngle; // 0x2C0
	public EnviroConfigFloat sunInclination; // 0x2F0
	public EnviroConfigFloat sunInclinationOffset; // 0x320
	public EnviroConfigColor sunDiskColor; // 0x350
	public EnviroConfigFloat sunDiskBrightness; // 0x370
	public EnviroConfigFloat sunDiskSize; // 0x3A0
	public EnviroConfigFloat sunDiskSharpness; // 0x3D0
	public EnviroConfigColor sunHaloColor; // 0x400
	public EnviroConfigFloat sunHaloBrightness; // 0x420
	public EnviroConfigFloat sunHaloSize; // 0x450
	public bool moonSelfRotation; // 0x480
	public EnviroConfigFloat moonAngle; // 0x488
	public EnviroConfigFloat moonInclination; // 0x4B8
	public EnviroConfigFloat moonInclinationOffset; // 0x4E8
	public EnviroConfigFloat moonRotation; // 0x518
	public EnviroConfigFloat moonOrbitOffset; // 0x548
	public EnviroConfigColor moonColor; // 0x578
	public EnviroConfigFloat moonBrightness; // 0x598
	public EnviroConfigFloat moonSize; // 0x5C8
	public EnviroConfigFloat moonLunarPhase; // 0x5F8
	public EnviroConfigFloat moonGlowBrightness; // 0x628
	public EnviroConfigFloat starsScintillation; // 0x658
	public EnviroConfigFloat starsBrightness; // 0x688
	public EnviroConfigFloat starsDensity; // 0x6B8
	public EnviroConfigFloat auroraBrightness; // 0x6E8
	public EnviroConfigFloat auroraSpeed; // 0x718
	public bool skyLightEnable; // 0x748
	public EnviroConfigColor skyLightColor; // 0x750
	public EnviroConfigColor skyLightGroundColor; // 0x770
	public EnviroConfigFloat skyLightRatio; // 0x790
	public EnviroConfigFloat skyLightInstensity; // 0x7C0
	public EnviroConfigFloat ambientProbeGlobalMultiplier; // 0x7F0
	public bool useLensFlare; // 0x820
	public string lensFlareName; // 0x828

	// Nested types
	public struct Config // TypeDefIndex: 31472
	{
		// Fields
		public Color topFrontColor; // 0x00
		public Color topBackColor; // 0x10
		public Color bottomFrontColor; // 0x20
		public Color bottomBackColor; // 0x30
		public float frontAndBackBlendFactor; // 0x40
		public float bottomColorHeight; // 0x44
		public float seaLevelHeight; // 0x48
		public Color horizonHaloColor; // 0x4C
		public float horizonHaloIntensity; // 0x5C
		public float horizonHaloHeight; // 0x60
		public float sunAngle; // 0x64
		public float sunInclination; // 0x68
		public float sunInclinationOffset; // 0x6C
		public Color sunDiskColor; // 0x70
		public float sunDiskBrightness; // 0x80
		public float sunDiskSize; // 0x84
		public float sunDiskSharpness; // 0x88
		public Color sunHaloColor; // 0x8C
		public float sunHaloBrightness; // 0x9C
		public float sunHaloSize; // 0xA0
		public float moonAngle; // 0xA4
		public float moonInclination; // 0xA8
		public float moonInclinationOffset; // 0xAC
		public float moonRotation; // 0xB0
		public float moonOrbitOffset; // 0xB4
		public Color moonColor; // 0xB8
		public float moonBrightness; // 0xC8
		public float moonSize; // 0xCC
		public float moonLunarPhase; // 0xD0
		public float moonGlowBrightness; // 0xD4
		public float starsScintillation; // 0xD8
		public float starsBrightness; // 0xDC
		public float starsDensity; // 0xE0
		public float auroraBrightness; // 0xE4
		public float auroraSpeed; // 0xE8
		public Color skyLightColor; // 0xEC
		public Color skyLightGroundColor; // 0xFC
		public float skyLightRatio; // 0x10C
		public float skyLightInstensity; // 0x110
		public float ambientProbeGlobalMultiplier; // 0x114
	}

	// Constructors
	public EnviroSkySettings() {} // 0x000000018369EEC0-0x00000001836A00A0

	// Methods
	public void Clone(EnviroSkySettings fromSettings) {} // 0x000000018369DD40-0x000000018369DE30
	public void Evaluate(float time) {} // 0x000000018369DE30-0x000000018369E760
	public void Lerp(EnviroSkySettings targetSetting, float ratio) {} // 0x000000018369E760-0x000000018369EEC0
}

