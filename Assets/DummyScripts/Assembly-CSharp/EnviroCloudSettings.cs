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
public class EnviroCloudSettings // TypeDefIndex: 31475
{
	// Fields
	public string profileName; // 0x10
	[NonSerialized]
	public Config config; // 0x18
	public EnviroConfigFloat cloudTiling; // 0x80
	public EnviroConfigFloat cloudHeight; // 0xB0
	public EnviroConfigFloat cloudOpacity; // 0xE0
	public EnviroConfigColor cloudLightFrontColor; // 0x110
	public EnviroConfigColor cloudLightBackColor; // 0x130
	public EnviroConfigColor cloudDarkFrontColor; // 0x150
	public EnviroConfigColor cloudDarkBackColor; // 0x170
	public EnviroConfigFloat frontAndBackBlendFactor; // 0x190
	public EnviroConfigFloat cloudSunBrightenIntensity; // 0x1C0
	public EnviroConfigFloat cloudLightingIntensity; // 0x1F0
	public EnviroConfigFloat cloudRimLightRadius; // 0x220
	public EnviroConfigFloat cloudWispsCoverage; // 0x250
	public EnviroConfigFloat cloudWispsOpacity; // 0x280
	public bool cloudsEmitterToggle; // 0x2B0
	public bool cloudsEmitter1Toggle; // 0x2B1
	public bool cloudsEmitter2Toggle; // 0x2B2

	// Nested types
	public struct Config // TypeDefIndex: 31476
	{
		// Fields
		// [Header] // 0x0000000189919E10-0x0000000189919E40
		public float cloudTiling; // 0x00
		public float cloudHeight; // 0x04
		public float cloudOpacity; // 0x08
		public Color cloudLightFrontColor; // 0x0C
		public Color cloudLightBackColor; // 0x1C
		public Color cloudDarkFrontColor; // 0x2C
		public Color cloudDarkBackColor; // 0x3C
		public float frontAndBackBlendFactor; // 0x4C
		public float cloudSunBrightenIntensity; // 0x50
		public float cloudLightingIntensity; // 0x54
		public float cloudRimLightRadius; // 0x58
		public float cloudCoverage; // 0x5C
		public float cloudWispsCoverage; // 0x60
		public float cloudWispsOpacity; // 0x64
	}

	// Constructors
	public EnviroCloudSettings() {} // 0x0000000183693B80-0x00000001836942A0

	// Methods
	public void Clone(EnviroCloudSettings fromSettings) {} // 0x0000000183693450-0x0000000183693500
	public void Evaluate(float time) {} // 0x0000000183693500-0x00000001836938C0
	public void Lerp(EnviroCloudSettings targetSetting, float ratio) {} // 0x00000001836938C0-0x0000000183693B80
}

