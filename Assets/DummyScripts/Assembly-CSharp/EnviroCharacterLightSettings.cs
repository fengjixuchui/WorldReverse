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
public class EnviroCharacterLightSettings // TypeDefIndex: 31453
{
	// Fields
	[NonSerialized]
	public Config config; // 0x10
	public EnviroConfigColor sceneFrontRimColor; // 0x88
	public EnviroConfigColor characterFrontRimColor; // 0xA8
	public EnviroConfigFloat characterFrontRimIntensity; // 0xC8
	public EnviroConfigColor characterBackRimColor; // 0xF8
	public EnviroConfigFloat characterBackRimIntensity; // 0x118
	public float characterRimWidth; // 0x148
	public EnviroConfigFloat characterMainLightBrightness; // 0x150
	public EnviroConfigFloat characterAmbientBrightness; // 0x180
	public EnviroConfigFloat characterMainLightRatio; // 0x1B0
	public EnviroConfigFloat characterAmbientLightRatio; // 0x1E0
	public EnviroConfigFloat characterMainLightBrightnessPS4; // 0x210
	public EnviroConfigFloat characterAmbientBrightnessPS4; // 0x240
	public EnviroConfigFloat characterMainLightRatioPS4; // 0x270
	public EnviroConfigFloat characterEnvLightIntensity; // 0x2A0
	public EnviroConfigFloat characterBodyShadowIntensity; // 0x2D0
	public EnviroConfigFloat characterSkinShadowIntensity; // 0x300
	public EnviroConfigFloat characterColorTone; // 0x330
	public EnviroConfigFloat characterPointLightPartialThreshold; // 0x360
	public EnviroConfigFloat characterPointLightPartialIntensity; // 0x390
	public EnviroConfigFloat characterPointLightWholeIntensity; // 0x3C0

	// Nested types
	public struct Config // TypeDefIndex: 31454
	{
		// Fields
		public Color sceneFrontRimColor; // 0x00
		public Color characterFrontRimColor; // 0x10
		public float characterFrontRimIntensity; // 0x20
		public Color characterBackRimColor; // 0x24
		public float characterBackRimIntensity; // 0x34
		public float characterRimWidth; // 0x38
		public float characterMainLightBrightness; // 0x3C
		public float characterAmbientBrightness; // 0x40
		public float characterMainLightRatio; // 0x44
		public float characterAmbientLightRatio; // 0x48
		public float characterMainLightBrightnessPS4; // 0x4C
		public float characterAmbientBrightnessPS4; // 0x50
		public float characterMainLightRatioPS4; // 0x54
		public float characterEnvLightIntensity; // 0x58
		public float characterBodyShadowIntensity; // 0x5C
		public float characterSkinShadowIntensity; // 0x60
		public float characterColorTone; // 0x64
		public float characterPointLightPartialThreshold; // 0x68
		public float characterPointLightPartialIntensity; // 0x6C
		public float characterPointLightWholeIntensity; // 0x70
	}

	// Constructors
	public EnviroCharacterLightSettings() {} // 0x0000000183692AF0-0x0000000183693450

	// Methods
	public void Evaluate(float time) {} // 0x00000001836923C0-0x00000001836927A0
	public void Lerp(EnviroCharacterLightSettings targetSetting, float ratio) {} // 0x00000001836927A0-0x0000000183692AF0
}

