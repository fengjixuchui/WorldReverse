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
public class EnviroSkillPreset : ScriptableObject // TypeDefIndex: 31488
{
	// Fields
	public int priority; // 0x18
	[NonSerialized]
	public Config config; // 0x20
	// [Header] // 0x00000001899964F0-0x0000000189996550
	// [Tooltip] // 0x00000001899964F0-0x0000000189996550
	public EnviroConfigColor mainLightColor; // 0x28
	// [Tooltip] // 0x00000001895F1660-0x00000001895F1690
	public EnviroConfigColor ambientSkyColor; // 0x48
	// [Tooltip] // 0x00000001899AA150-0x00000001899AA180
	public EnviroConfigColor ambientEquatorColor; // 0x68
	// [Tooltip] // 0x00000001899B1B40-0x00000001899B1B70
	public EnviroConfigColor ambientGroundColor; // 0x88
	public EnviroConfigColor topFrontColor; // 0xA8
	public EnviroConfigColor topBackColor; // 0xC8
	public EnviroConfigColor bottomFrontColor; // 0xE8
	public EnviroConfigColor bottomBackColor; // 0x108
	public EnviroConfigColor cloudLightFrontColor; // 0x128
	public EnviroConfigColor cloudLightBackColor; // 0x148
	public EnviroConfigColor cloudDarkFrontColor; // 0x168
	public EnviroConfigColor cloudDarkBackColor; // 0x188
	public EnviroConfigFloat cloudCoverage; // 0x1A8
	// [Header] // 0x00000001899B8E60-0x00000001899B8EC0
	// [Tooltip] // 0x00000001899B8E60-0x00000001899B8EC0
	public EnviroConfigFloat fogDensity; // 0x1D8
	public EnviroConfigFloat fogSwitchDistance; // 0x208
	public EnviroConfigColor fogBottomColor; // 0x238
	public EnviroConfigColor fogTopColor; // 0x258
	public EnviroConfigColor fogColor; // 0x278
	public EnviroConfigColor farFogColor; // 0x298
	// [Tooltip] // 0x00000001898B04D0-0x00000001898B0500
	public EnviroConfigFloat linearFogEnd; // 0x2B8
	// [Tooltip] // 0x00000001898B04D0-0x00000001898B0500
	public EnviroConfigFloat linearHeightRange; // 0x2E8
	// [Tooltip] // 0x00000001899D3F40-0x00000001899D3F70
	public EnviroConfigFloat densityClamp; // 0x318
	// [Tooltip] // 0x00000001899DB4B0-0x00000001899DB4E0
	public bool hasLightning; // 0x348
	public EnviroThunderSettings thunderSettings; // 0x350

	// Nested types
	public class Config // TypeDefIndex: 31489
	{
		// Fields
		public Color mainLightColor; // 0x10
		public Color ambientSkyColor; // 0x20
		public Color ambientEquatorColor; // 0x30
		public Color ambientGroundColor; // 0x40
		public Color topFrontColor; // 0x50
		public Color topBackColor; // 0x60
		public Color bottomFrontColor; // 0x70
		public Color bottomBackColor; // 0x80
		public Color cloudLightFrontColor; // 0x90
		public Color cloudLightBackColor; // 0xA0
		public Color cloudDarkFrontColor; // 0xB0
		public Color cloudDarkBackColor; // 0xC0
		public float cloudCoverage; // 0xD0
		public float fogDensity; // 0xD4
		public Color fogTopColor; // 0xD8
		public Color fogBottomColor; // 0xE8
		public Color fogColor; // 0xF8
		public Color farFogColor; // 0x108
		public float linearFogEnd; // 0x118
		public float densityClamp; // 0x11C
		public float linearHeightRange; // 0x120
		public float fogSwitchDistance; // 0x124

		// Constructors
		public Config() {} // 0x0000000183684A60-0x0000000183684AC0
	}

	// Constructors
	public EnviroSkillPreset() {} // 0x000000018369D320-0x000000018369DD40

	// Methods
	public void Evaluate(float time, EnviroCloudSettings cloudSetting, EnviroFogSettings fogSetting) {} // 0x000000018369C540-0x000000018369D290
	public void EvaluateProfile(EnviroLightSettings lightSetting, EnviroSkySettings skySetting, EnviroCloudSettings cloudSetting, EnviroFogSettings fogSetting) {} // 0x000000018369BEE0-0x000000018369C540
	public void Lerp(EnviroSkillPreset targetSetting, float ratio) {} // 0x000000018369D290-0x000000018369D320
}

