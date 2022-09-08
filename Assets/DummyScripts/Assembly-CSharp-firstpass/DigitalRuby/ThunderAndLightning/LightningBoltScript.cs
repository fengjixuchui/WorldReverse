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
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltScript : MonoBehaviour // TypeDefIndex: 9657
	{
		// Fields
		// [Header] // 0x0000000189924490-0x00000001899244F0
		// [Tooltip] // 0x0000000189924490-0x00000001899244F0
		public Camera mainCamera; // 0x18
		// [Tooltip] // 0x00000001899317A0-0x00000001899317D0
		public CameraMode CameraMode; // 0x20
		internal CameraMode calculatedCameraMode; // 0x24
		// [Tooltip] // 0x000000018993A9E0-0x000000018993AA10
		public bool UseWorldSpace; // 0x28
		// [Tooltip] // 0x0000000189943600-0x0000000189943630
		public bool CompensateForParentTransform; // 0x29
		// [Tooltip] // 0x000000018994C430-0x000000018994C460
		public LightningBoltQualitySetting QualitySetting; // 0x2C
		// [Range] // 0x0000000189955380-0x00000001899553E0
		// [Tooltip] // 0x0000000189955380-0x00000001899553E0
		public float SoftParticlesFactor; // 0x30
		// [Header] // 0x00000001899614B0-0x0000000189961510
		// [Tooltip] // 0x00000001899614B0-0x0000000189961510
		public int RenderQueue; // 0x34
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string SortLayerName; // 0x38
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int SortOrderInLayer; // 0x40
		// [Tooltip] // 0x000000018997D6C0-0x000000018997D6F0
		public UnityEngine.Material LightningMaterialMesh; // 0x48
		// [Tooltip] // 0x0000000189986B30-0x0000000189986B60
		public UnityEngine.Material LightningMaterialMeshNoGlow; // 0x50
		// [Tooltip] // 0x000000018998FE20-0x000000018998FE50
		public Texture2D LightningTexture; // 0x58
		// [Tooltip] // 0x00000001899993C0-0x00000001899993F0
		public Texture2D LightningGlowTexture; // 0x60
		// [Tooltip] // 0x00000001899A2480-0x00000001899A24B0
		public ParticleSystem LightningOriginParticleSystem; // 0x68
		// [Tooltip] // 0x00000001899AB760-0x00000001899AB790
		public ParticleSystem LightningDestinationParticleSystem; // 0x70
		// [Tooltip] // 0x00000001899B46D0-0x00000001899B4700
		public Color LightningTintMinColor; // 0x78
		// [Tooltip] // 0x00000001899BD440-0x00000001899BD470
		public Color LightningTintMaxColor; // 0x88
		// [Tooltip] // 0x00000001899C67C0-0x00000001899C67F0
		public Color GlowTintColor; // 0x98
		// [Tooltip] // 0x00000001899CF5B0-0x00000001899CF5E0
		public BlendMode SourceBlendMode; // 0xA8
		// [Tooltip] // 0x00000001899D8180-0x00000001899D81B0
		public BlendMode DestinationBlendMode; // 0xAC
		// [Header] // 0x00000001899E1000-0x00000001899E1060
		// [Tooltip] // 0x00000001899E1000-0x00000001899E1060
		public float JitterMultiplier; // 0xB0
		// [Tooltip] // 0x00000001899EE7D0-0x00000001899EE800
		public float Turbulence; // 0xB4
		// [Tooltip] // 0x00000001899F78C0-0x00000001899F78F0
		public Vector3 TurbulenceVelocity; // 0xB8
		private Texture2D lastLightningTexture; // 0xF8
		private Texture2D lastLightningGlowTexture; // 0x100
		private readonly List<LightningBolt> activeBolts; // 0x108
		private readonly LightningBoltParameters[] oneParameterArray; // 0x110
		private readonly List<LightningBolt> lightningBoltCache; // 0x118
		private readonly List<LightningBoltDependencies> dependenciesCache; // 0x120
		private LightningThreadState threadState; // 0x128
		private static int shaderId_MainTex; // 0x00
		private static int shaderId_GlowTex; // 0x04
		private static int shaderId_TintColor; // 0x08
		private static int shaderId_GlowTintColor; // 0x0C
		private static int shaderId_JitterMultiplier; // 0x10
		private static int shaderId_Turbulence; // 0x14
		private static int shaderId_TurbulenceVelocity; // 0x18
		private static int shaderId_SrcBlendMode; // 0x1C
		private static int shaderId_DstBlendMode; // 0x20
		private static int shaderId_InvFade; // 0x24
	
		// Properties
		public Action<LightningBoltParameters, Vector3, Vector3> LightningStartedCallback { /* [XID] */ /* 0x0000000189A3EBF0-0x0000000189A3EC30 */ get; set; } // 0x00000001860403E0-0x0000000186040440 0x0000000186040650-0x00000001860406C0
		public Action<LightningBoltParameters, Vector3, Vector3> LightningEndedCallback { /* [XID] */ /* 0x0000000189A50AC0-0x0000000189A50B00 */ get; set; } // 0x0000000186040380-0x00000001860403E0 0x00000001860405E0-0x0000000186040650
		public Action<Light> LightAddedCallback { /* [XID] */ /* 0x0000000189A62800-0x0000000189A62840 */ get; set; } // 0x00000001860402C0-0x0000000186040320 0x0000000186040500-0x0000000186040570
		public Action<Light> LightRemovedCallback { /* [XID] */ /* 0x0000000189A749E0-0x0000000189A74A20 */ get; set; } // 0x0000000186040320-0x0000000186040380 0x0000000186040570-0x00000001860405E0
		public bool HasActiveBolts { /* [XID] */ /* 0x00000001895FBF20-0x00000001895FBF40 */ get => default; } // 0x0000000186040200-0x00000001860402C0 
		internal UnityEngine.Material lightningMaterialMeshInternal { /* [XID] */ /* 0x0000000189ACA630-0x0000000189ACA670 */ get; /* [XID] */ /* 0x0000000189AD5650-0x0000000189AD5690 */ private set; } // 0x0000000186040440-0x00000001860404A0 0x00000001860406C0-0x0000000186040730
		internal UnityEngine.Material lightningMaterialMeshNoGlowInternal { /* [XID] */ /* 0x0000000189ADFFE0-0x0000000189AE0020 */ get; /* [XID] */ /* 0x0000000189AEA5F0-0x0000000189AEA630 */ private set; } // 0x00000001860404A0-0x0000000186040500 0x0000000186040730-0x00000001860407A0
	
		// Constructors
		public LightningBoltScript() {} // 0x0000000186040000-0x0000000186040200
		static LightningBoltScript() {} // 0x000000018603FFA0-0x0000000186040000
	
		// Methods
		// [XID] // 0x00000001896E5A10-0x00000001896E5A30
		public virtual void CreateLightningBolt(LightningBoltParameters p) {} // 0x000000018603CEB0-0x000000018603D000
		// [XID] // 0x00000001896E9EA0-0x00000001896E9EC0
		public void CreateLightningBolts(ICollection<LightningBoltParameters> parameters) {} // 0x000000018603D000-0x000000018603D110
		// [XID] // 0x00000001899D3F70-0x00000001899D3F90
		protected virtual void Awake() {} // 0x000000018603C590-0x000000018603C630
		// [XID] // 0x0000000189A007C0-0x0000000189A007E0
		protected virtual void Start() {} // 0x000000018603E950-0x000000018603EA60
		// [XID] // 0x0000000189B6AEA0-0x0000000189B6AEC0
		protected virtual void Update() {} // 0x000000018603FE20-0x000000018603FFA0
		// [XID] // 0x0000000189AB3BA0-0x0000000189AB3BC0
		protected virtual LightningBoltParameters OnCreateParameters() => default; // 0x000000018603D530-0x000000018603D600
		// [XID] // 0x00000001899C5180-0x00000001899C51A0
		protected LightningBoltParameters CreateParameters() => default; // 0x000000018603D110-0x000000018603D200
		// [XID] // 0x0000000189AC2F10-0x0000000189AC2F30
		protected virtual void PopulateParameters(LightningBoltParameters p) {} // 0x000000018603DCC0-0x000000018603DD70
		// [XID] // 0x0000000189AF4F40-0x0000000189AF4F60
		private Coroutine StartCoroutineWrapper(IEnumerator routine) => default; // 0x000000018603E880-0x000000018603E950
		// [XID] // 0x0000000189AAA510-0x0000000189AAA530
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1) {} // 0x000000018603DBE0-0x000000018603DCC0
		// [XID] // 0x0000000189701960-0x0000000189701980
		private LightningBoltDependencies CreateLightningBoltDependencies(ICollection<LightningBoltParameters> parameters) => default; // 0x000000018603CA50-0x000000018603CEB0
		// [XID] // 0x0000000189B0B3C0-0x0000000189B0B3E0
		private void ReturnLightningDependenciesToCache(LightningBoltDependencies d) {} // 0x000000018603DD70-0x000000018603DE80
		// [XID] // 0x0000000189B12C00-0x0000000189B12C20
		internal void OnLightAdded(Light l) {} // 0x000000018603D920-0x000000018603DA80
		// [XID] // 0x0000000189B1A050-0x0000000189B1A070
		internal void OnLightRemoved(Light l) {} // 0x000000018603DA80-0x000000018603DBE0
		// [XID] // 0x0000000189657FD0-0x0000000189657FF0
		internal void AddActiveBolt(LightningBolt bolt) {} // 0x000000018603C460-0x000000018603C590
		// [XID] // 0x0000000189B28D30-0x0000000189B28D50
		private void UpdateMainThreadActions() {} // 0x000000018603ECF0-0x000000018603EDA0
		// [XID] // 0x00000001899DB4E0-0x00000001899DB500
		private void UpdateShaderIds() {} // 0x000000018603F020-0x000000018603F270
		// [XID] // 0x0000000189B379A0-0x0000000189B379C0
		private void UpdateMaterialsForLastTexture() {} // 0x000000018603EDA0-0x000000018603F020
		// [XID] // 0x0000000189B3F340-0x0000000189B3F360
		private void UpdateTexture() {} // 0x000000018603FC60-0x000000018603FE20
		// [XID] // 0x0000000189B46C60-0x0000000189B46C80
		private void SetMaterialPerspective() {} // 0x000000018603E460-0x000000018603E750
		// [XID] // 0x00000001896FEA00-0x00000001896FEA20
		private void SetMaterialOrthographicXY() {} // 0x000000018603DE80-0x000000018603E170
		// [XID] // 0x00000001896BF5E0-0x00000001896BF600
		private void SetMaterialOrthographicXZ() {} // 0x000000018603E170-0x000000018603E460
		// [XID] // 0x0000000189B72540-0x0000000189B72560
		private void SetupMaterialCamera() {} // 0x000000018603E750-0x000000018603E880
		// [XID] // 0x0000000189AB9800-0x0000000189AB9820
		private void EnableKeyword(string keyword, bool enable, UnityEngine.Material m) {} // 0x000000018603D200-0x000000018603D310
		// [XID] // 0x0000000189B6BFF0-0x0000000189B6C010
		private void UpdateShaderParameters() {} // 0x000000018603F270-0x000000018603FC60
		// [XID] // 0x0000000189689370-0x0000000189689390
		private void CheckCompensateForParentTransform() {} // 0x000000018603C630-0x000000018603C8A0
		// [XID] // 0x0000000189B7AD20-0x0000000189B7AD40
		private void UpdateCamera() {} // 0x000000018603EBE0-0x000000018603ECF0
		// [XID] // 0x0000000189985FB0-0x0000000189985FD0
		private LightningBolt GetOrCreateLightningBolt() => default; // 0x000000018603D310-0x000000018603D480
		// [XID] // 0x0000000189664C20-0x0000000189664C40
		private void UpdateActiveBolts() {} // 0x000000018603EA60-0x000000018603EBE0
		// [XID] // 0x0000000189B91510-0x0000000189B91530
		private void OnApplicationQuit() {} // 0x000000018603D480-0x000000018603D530
		// [XID] // 0x0000000189B98760-0x0000000189B98780
		private void Cleanup() {} // 0x000000018603C8A0-0x000000018603CA50
		// [XID] // 0x0000000189B9FCA0-0x0000000189B9FCC0
		private void OnDestroy() {} // 0x000000018603D600-0x000000018603D880
		// [XID] // 0x0000000189BA74D0-0x0000000189BA74F0
		private void OnDisable() {} // 0x000000018603D880-0x000000018603D920
	}
}
