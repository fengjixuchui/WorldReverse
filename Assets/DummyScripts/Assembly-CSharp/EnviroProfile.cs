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
public class EnviroProfile : ScriptableObject // TypeDefIndex: 31482
{
	// Fields
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public string version; // 0x18
	public ClimateType defaultWeather; // 0x20
	public Climate2Weather[] climate2Weather; // 0x28
	public float[] oneDayTimeIntervals; // 0x30
	public float[] oneDayTargetTimes; // 0x38
	public bool enableAtmosphere; // 0x40
	public bool enableSunMoon; // 0x41
	public bool enableCloud; // 0x42
	public bool enableMainLight; // 0x43
	public bool enableLightmap; // 0x44
	public bool enableFakeWeather; // 0x45
	public bool enableCameraElevate; // 0x46
	public string characterLightPath; // 0x48
	public EnviroLightSettings lightSettings; // 0x50
	public EnviroSkySettings skySettings; // 0x58
	public EnviroCloudSettings cloudsSettings; // 0x60
	public EnviroFogSettings fogSettings; // 0x68
	public EnviroTransitionSettings transitionSettings; // 0x70
	public EnviroDungeonSettings dungeonSettings; // 0x78
	public EnviroQualitySettings qualitySettings; // 0x80
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public EnviroSettingsMode viewMode; // 0x88
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool showPlayerSetup; // 0x8C
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool showRenderingSetup; // 0x8D
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool showComponentsSetup; // 0x8E
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool showTimeUI; // 0x8F
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool showWeatherUI; // 0x90
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool showVolumeUI; // 0x91
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool showAudioUI; // 0x92
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool showEffectsUI; // 0x93
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool modified; // 0x94

	// Nested types
	public enum EnviroSettingsMode // TypeDefIndex: 31483
	{
		Lighting = 0,
		Sky = 1,
		Clouds = 2,
		Fog = 3,
		Transition = 4,
		Quality = 5,
		CharacterLight = 6
	}

	// Constructors
	public EnviroProfile() {} // 0x000000018369BBF0-0x000000018369BDA0

	// Methods
	public bool HasFixDayTime() => default; // 0x000000018369BB80-0x000000018369BBF0
}

