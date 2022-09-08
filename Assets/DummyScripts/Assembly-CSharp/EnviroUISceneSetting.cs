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
public class EnviroUISceneSetting : ScriptableObject // TypeDefIndex: 31508
{
	// Fields
	[NonSerialized]
	public Config config; // 0x18
	public string characterLightPath; // 0x70
	// [Tooltip] // 0x0000000189763750-0x0000000189763780
	public EnviroConfigColor mainLightColor; // 0x78
	public EnviroConfigFloat mainLightIntensity; // 0x98
	// [Tooltip] // 0x000000018976C6C0-0x000000018976C6F0
	public EnviroConfigFloat shadowStrength; // 0xC8
	// [Tooltip] // 0x00000001897874B0-0x00000001897874E0
	public AmbientMode ambientMode; // 0xF8
	// [Tooltip] // 0x00000001895F1660-0x00000001895F1690
	public EnviroConfigColor ambientSkyColor; // 0x100
	// [Tooltip] // 0x00000001899AA150-0x00000001899AA180
	public EnviroConfigColor ambientEquatorColor; // 0x120
	// [Tooltip] // 0x00000001899B1B40-0x00000001899B1B70
	public EnviroConfigColor ambientGroundColor; // 0x140
	public float lightClampThreshold; // 0x160
	public float baseSunDawnThreshold; // 0x164
	public EnviroConfigFloat postProcessThreshold; // 0x168
	public EnviroConfigFloat postProcessExposure; // 0x198
	public EnviroConfigFloat postProcessContrast; // 0x1C8

	// Nested types
	public struct Config // TypeDefIndex: 31509
	{
		// Fields
		public Color mainLightColor; // 0x00
		public float mainLightIntensity; // 0x10
		public float shadowStrength; // 0x14
		public Color ambientSkyColor; // 0x18
		public Color ambientEquatorColor; // 0x28
		public Color ambientGroundColor; // 0x38
		public float postProcessThreshold; // 0x48
		public float postProcessExposure; // 0x4C
		public float postProcessContrast; // 0x50
	}

	// Constructors
	public EnviroUISceneSetting() {} // 0x00000001836A1390-0x00000001836A17F0

	// Methods
	public void Evaluate(float time) {} // 0x00000001836A0DE0-0x00000001836A1140
	public void Lerp(EnviroLightSettings targetSetting, float ratio) {} // 0x00000001836A1140-0x00000001836A1390
}

