/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public class ThunderAndLightningScript : MonoBehaviour // TypeDefIndex: 9687
	{
		// Fields
		// [Tooltip] // 0x00000001899B8B80-0x00000001899B8BB0
		public LightningBoltPrefabScript LightningBoltScript; // 0x18
		// [Tooltip] // 0x00000001899C1DE0-0x00000001899C1E10
		public Camera Camera; // 0x20
		// [SingleLine] // 0x00000001899CAC60-0x00000001899CAC90
		public RangeOfFloats LightningIntervalTimeRange; // 0x28
		// [Range] // 0x00000001899D3B20-0x00000001899D3B70
		// [Tooltip] // 0x00000001899D3B20-0x00000001899D3B70
		public float LightningIntenseProbability; // 0x30
		// [Tooltip] // 0x00000001899DF7C0-0x00000001899DF7F0
		public AudioClip[] ThunderSoundsNormal; // 0x38
		// [Tooltip] // 0x00000001899E8B40-0x00000001899E8B70
		public AudioClip[] ThunderSoundsIntense; // 0x40
		// [Tooltip] // 0x00000001899F16B0-0x00000001899F16E0
		public bool LightningAlwaysVisible; // 0x48
		// [Range] // 0x00000001899FA940-0x00000001899FA9A0
		// [Tooltip] // 0x00000001899FA940-0x00000001899FA9A0
		public float CloudLightningChance; // 0x4C
		// [Tooltip] // 0x0000000189A068A0-0x0000000189A068D0
		public bool ModifySkyboxExposure; // 0x50
		// [Range] // 0x0000000189A0F2C0-0x0000000189A0F320
		// [Tooltip] // 0x0000000189A0F2C0-0x0000000189A0F320
		public float BaseLightRange; // 0x54
		// [Range] // 0x0000000189A1AF50-0x0000000189A1AFB0
		// [Tooltip] // 0x0000000189A1AF50-0x0000000189A1AFB0
		public float LightningYStart; // 0x58
		private float skyboxExposureOriginal; // 0x5C
		private float skyboxExposureStorm; // 0x60
		private float nextLightningTime; // 0x64
		private bool lightningInProgress; // 0x68
		private AudioSource audioSourceThunder; // 0x70
		private LightningBoltHandler lightningBoltHandler; // 0x78
		private UnityEngine.Material skyboxMaterial; // 0x80
		private AudioClip lastThunderSound; // 0x88
	
		// Properties
		public float SkyboxExposureOriginal { /* [XID] */ /* 0x0000000189A6A5E0-0x0000000189A6A600 */ get => default; } // 0x0000000186051280-0x0000000186051330 
		public bool EnableLightning { /* [XID] */ /* 0x0000000189A719B0-0x0000000189A719F0 */ get; /* [XID] */ /* 0x0000000189A7C490-0x0000000189A7C4D0 */ set; } // 0x0000000186051220-0x0000000186051280 0x0000000186051330-0x00000001860513A0
	
		// Nested types
		private class LightningBoltHandler // TypeDefIndex: 9688
		{
			// Fields
			private ThunderAndLightningScript script; // 0x10
			private readonly System.Random random; // 0x18
	
			// Constructors
			public LightningBoltHandler() {} // Dummy constructor
			public LightningBoltHandler(ThunderAndLightningScript script) {} // 0x0000000186038980-0x0000000186038A30
	
			// Methods
			// [XID] // 0x0000000189A6DAE0-0x0000000189A6DB00
			private void UpdateLighting() {} // 0x0000000186038730-0x00000001860388E0
			// [XID] // 0x0000000189A8E790-0x0000000189A8E7B0
			private void CalculateNextLightningTime() {} // 0x00000001860377B0-0x0000000186037940
			[DebuggerHidden] // 0x0000000189A95BD0-0x0000000189A95C10
			// [XID] // 0x0000000189A95BD0-0x0000000189A95C10
			public IEnumerator ProcessLightning(Vector3? _start, Vector3? _end, bool intense, bool visible) => default; // 0x0000000186037AB0-0x0000000186037C40
			// [XID] // 0x0000000189AA0250-0x0000000189AA0270
			private void Strike(Vector3? _start, Vector3? _end, bool intense, float intensity, Camera camera, Camera visibleInCamera) {} // 0x0000000186037C40-0x0000000186038730
			// [XID] // 0x0000000189AA7A70-0x0000000189AA7A90
			private void CheckForLightning() {} // 0x0000000186037940-0x0000000186037AB0
			// [XID] // 0x0000000189AB4FE0-0x0000000189AB5000
			public void Update() {} // 0x00000001860388E0-0x0000000186038980
		}
	
		// Constructors
		public ThunderAndLightningScript() {} // 0x0000000186051180-0x0000000186051220
	
		// Methods
		// [XID] // 0x00000001899E0180-0x00000001899E01A0
		private void Start() {} // 0x0000000186050D60-0x0000000186051080
		// [XID] // 0x0000000189A8FDD0-0x0000000189A8FDF0
		private void Update() {} // 0x0000000186051080-0x0000000186051180
		// [IDTag] // 0x0000000189A40240-0x0000000189A40280
		// [XID] // 0x0000000189A40240-0x0000000189A40280
		public void CallNormalLightning() {} // 0x0000000186050B60-0x0000000186050C40
		// [IDTag] // 0x0000000189A4A840-0x0000000189A4A880
		// [XID] // 0x0000000189A4A840-0x0000000189A4A880
		public void CallNormalLightning(Vector3? start, Vector3? end) {} // 0x0000000186050C40-0x0000000186050D60
		// [IDTag] // 0x0000000189A552C0-0x0000000189A55300
		// [XID] // 0x0000000189A552C0-0x0000000189A55300
		public void CallIntenseLightning() {} // 0x0000000186050A80-0x0000000186050B60
		// [IDTag] // 0x0000000189A5FB90-0x0000000189A5FBD0
		// [XID] // 0x0000000189A5FB90-0x0000000189A5FBD0
		public void CallIntenseLightning(Vector3? start, Vector3? end) {} // 0x0000000186050960-0x0000000186050A80
	}
}
