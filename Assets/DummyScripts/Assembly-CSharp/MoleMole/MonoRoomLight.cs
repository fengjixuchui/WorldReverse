/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using VLB;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoRoomLight : MonoSceneProp // TypeDefIndex: 31782
	{
		// Fields
		public const float DEFAULT_LIGHT_INTENSITY_MIN_VALUE = 0f; // Metadata: 0x00B136DD
		public const float DEFAULT_LIGHT_INTENSITY_MAX_VALUE = 5f; // Metadata: 0x00B136E1
		public const float DEFAULT_LIGHT_RANGE_MIN_VALUE = 0f; // Metadata: 0x00B136E5
		public const float DEFAULT_LIGHT_RANGE_MAX_VALUE = 5f; // Metadata: 0x00B136E9
		public const float DEFAULT_VOL_LIGHT_BEAM_ALPHA_MIN_VALUE = 0f; // Metadata: 0x00B136ED
		public const float DEFAULT_VOL_LIGHT_BEAM_ALPHA_MAX_VALUE = 10f; // Metadata: 0x00B136F1
		public bool followSunDir; // 0x18
		public bool followSunColor; // 0x19
		private Config config; // 0x20
		// [Range] // 0x0000000189840360-0x0000000189840380
		public float sunlightAngleOffset; // 0x28
		public EnviroConfigColor lightColor; // 0x30
		public EnviroConfigFloat lightIntensity; // 0x50
		public EnviroConfigFloat lightRange; // 0x80
		public EnviroConfigFloat volLightBeamAlphaInside; // 0xB0
		public EnviroConfigFloat volLightBeamAlphaOutside; // 0xE0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public LightBaseSetting[] lightBaseSettings; // 0x110
	
		// Nested types
		public class Config // TypeDefIndex: 31783
		{
			// Fields
			public Color lightColor; // 0x10
			public float lightIntensity; // 0x20
			public float lightRange; // 0x24
			public float volLightBeamAlphaInside; // 0x28
			public float volLightBeamAlphaOutside; // 0x2C
	
			// Constructors
			public Config() {} // 0x0000000181433020-0x0000000181433080
	
			// Methods
			// [XID] // 0x00000001898737F0-0x0000000189873810
			public object Clone() => default; // 0x0000000181432F70-0x0000000181433020
		}
	
		[Serializable]
		public class LightBaseSetting // TypeDefIndex: 31784
		{
			// Fields
			public Light light; // 0x10
			public float baseIntensity; // 0x18
			public float baseRange; // 0x1C
			public Transform transform; // 0x20
			public VolumetricLightBeam volumetricLightBeam; // 0x28
			public VolumetricDustParticles volumetricDustParticles; // 0x30
	
			// Constructors
			public LightBaseSetting() {} // 0x0000000181433770-0x00000001814337D0
	
			// Methods
			// [XID] // 0x000000018987B350-0x000000018987B370
			public void CacheComponentsFromLight() {} // 0x0000000181433510-0x0000000181433660
			// [XID] // 0x00000001898824F0-0x0000000189882510
			public void SyncParameterFromLight() {} // 0x0000000181433660-0x0000000181433770
		}
	
		// Constructors
		public MonoRoomLight() {} // 0x0000000181436600-0x00000001814368D0
	
		// Methods
		// [XID] // 0x000000018984F080-0x000000018984F0A0
		public override ScenePropType GetScenePropType() => default; // 0x0000000181435C30-0x0000000181435CD0
		// [XID] // 0x0000000189856160-0x0000000189856180
		public void CacheAllLightComponents() {} // 0x00000001814359E0-0x0000000181435AE0
		// [XID] // 0x000000018985D470-0x000000018985D490
		public void CacheComponentAndSyncParameterFromLight(int index) {} // 0x0000000181435AE0-0x0000000181435C30
		// [XID] // 0x0000000189864E50-0x0000000189864E70
		private void Envaluate(float time) {} // 0x0000000181435CD0-0x0000000181435F10
		// [XID] // 0x000000018986C470-0x000000018986C490
		public void Update() {} // 0x0000000181435F10-0x0000000181436600
	}
}
