/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace VLB
{
	[DisallowMultipleComponent] // 0x000000018970B2F0-0x000000018970B390
	[ExecuteInEditMode] // 0x000000018970B2F0-0x000000018970B390
	// [HelpURL] // 0x000000018970B2F0-0x000000018970B390
	// [RequireComponent] // 0x000000018970B2F0-0x000000018970B390
	public class VolumetricDustParticles : MonoBehaviour // TypeDefIndex: 10208
	{
		// Fields
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float alpha; // 0x18
		// [Range] // 0x0000000189728D20-0x0000000189728D40
		public float size; // 0x1C
		public Direction direction; // 0x20
		public float speed; // 0x24
		public float density; // 0x28
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float spawnMaxDistance; // 0x2C
		public bool cullingEnabled; // 0x30
		public float cullingMaxDistance; // 0x34
		public static bool isFeatureSupported; // 0x00
		private ParticleSystem m_Particles; // 0x40
		private ParticleSystemRenderer m_Renderer; // 0x48
		private static bool ms_NoMainCameraLogged; // 0x01
		private static Camera ms_MainCamera; // 0x08
		private VolumetricLightBeam m_Master; // 0x50
	
		// Properties
		public bool isCulled { get; /* [XID] */ /* 0x000000018974A110-0x000000018974A150 */ private set; } // 0x0000000186EB26C0-0x0000000186EB2720 0x0000000186EB2CB0-0x0000000186EB2D10
		public bool particlesAreInstantiated { /* [XID] */ /* 0x0000000189A7A530-0x0000000189A7A550 */ get => default; } // 0x0000000186EB29E0-0x0000000186EB2AB0 
		public int particlesCurrentCount { /* [XID] */ /* 0x000000018975BAB0-0x000000018975BAD0 */ get => default; } // 0x0000000186EB2AB0-0x0000000186EB2BA0 
		public int particlesMaxCount { /* [XID] */ /* 0x0000000189763440-0x0000000189763460 */ get => default; } // 0x0000000186EB2BA0-0x0000000186EB2CB0 
		public Camera mainCamera { /* [XID] */ /* 0x00000001897409E0-0x0000000189740A00 */ get => default; } // 0x0000000186EB2720-0x0000000186EB29E0 
	
		// Nested types
		public enum Direction // TypeDefIndex: 10209
		{
			Beam = 0,
			Random = 1
		}
	
		// Constructors
		public VolumetricDustParticles() {} // 0x0000000186EB2610-0x0000000186EB26C0
		static VolumetricDustParticles() {} // 0x0000000186EB2580-0x0000000186EB2610
	
		// Methods
		// [XID] // 0x00000001897721B0-0x00000001897721D0
		private void Start() {} // 0x0000000186EB2070-0x0000000186EB21E0
		// [XID] // 0x0000000189808D70-0x0000000189808D90
		private void InstantiateParticleSystem() {} // 0x0000000186EB1240-0x0000000186EB1460
		// [XID] // 0x00000001897812E0-0x0000000189781300
		private void OnEnable() {} // 0x0000000186EB1690-0x0000000186EB1730
		// [XID] // 0x0000000189788820-0x0000000189788840
		private void SetActiveAndPlay() {} // 0x0000000186EB1730-0x0000000186EB1860
		// [XID] // 0x000000018978FEC0-0x000000018978FEE0
		private void OnDisable() {} // 0x0000000186EB1590-0x0000000186EB1690
		// [XID] // 0x0000000189797730-0x0000000189797750
		private void OnDestroy() {} // 0x0000000186EB1460-0x0000000186EB1590
		// [XID] // 0x0000000189763300-0x0000000189763320
		private void Update() {} // 0x0000000186EB24C0-0x0000000186EB2580
		// [XID] // 0x00000001897A6B60-0x00000001897A6B80
		private void SetParticleProperties() {} // 0x0000000186EB1860-0x0000000186EB2070
		// [XID] // 0x000000018976AA90-0x000000018976AAB0
		private void UpdateCulling() {} // 0x0000000186EB21E0-0x0000000186EB24C0
	}
}
