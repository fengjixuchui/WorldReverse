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
public class EnviroWeatherEffects // TypeDefIndex: 31516
{
	// Fields
	public string prefabPath; // 0x10
	public Vector3 localPositionOffset; // 0x18
	public EffectEnvPlatformType platformType; // 0x24
	public List<int> enableSurfaces; // 0x28
	public List<EnviroConfigColor> effectColorGradients; // 0x30
	public Config config; // 0x38

	// Nested types
	public class Config // TypeDefIndex: 31517
	{
		// Fields
		public List<Color> effectColors; // 0x10

		// Constructors
		public Config() {} // 0x0000000183684AC0-0x0000000183684C50
	}

	// Constructors
	public EnviroWeatherEffects() {} // 0x00000001836A1D90-0x00000001836A1E60

	// Methods
	public void Evaluate(float time) {} // 0x00000001836A18E0-0x00000001836A1B50
	public void Lerp(EnviroWeatherEffects targetSetting, float ratio) {} // 0x00000001836A1B50-0x00000001836A1D90
}

