/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x000000018964FCA0-0x000000018964FD00
	// [RequireComponent] // 0x000000018964FCA0-0x000000018964FD00
	public class EnviroCloudsEmitter : MonoBehaviour // TypeDefIndex: 31458
	{
		// Fields
		public int atmosphereRadius; // 0x18
		public Vector2 materialSpriteTiles; // 0x1C
		// [Range] // 0x0000000189808F90-0x0000000189808FB0
		public float materialSpriteAspectRatio; // 0x24
		// [Range] // 0x0000000189666260-0x0000000189666280
		public float deltaCloudCoverageSpeed; // 0x28
		public List<EnviroCloudsLayer> particleLayers; // 0x30
		private ParticleSystem _particleSystem; // 0x38
		private ParticleSystemRenderer _renderer; // 0x40
		private int _maxParticleCount; // 0x48
		private int _particleCount; // 0x4C
		private ParticleSystem.Particle[] _particles; // 0x50
		private List<Vector4> _particleCustomData; // 0x58
		private float _materialSpriteTilesCount; // 0x60
		private float _lastCloudCoverage; // 0x64
		private const float PARTICLE_VELOCITY_STRENGTH = 5f; // Metadata: 0x00B12793
		private bool _enableEmitter; // 0x68
		private bool _haveInit; // 0x69
		private static readonly int ATLAS_TILES_PARAM_ID; // 0x00
	
		// Constructors
		public EnviroCloudsEmitter() {} // 0x00000001814A7D00-0x00000001814A7E00
		static EnviroCloudsEmitter() {} // 0x00000001814A7C90-0x00000001814A7D00
	
		// Methods
		// [XID] // 0x000000018966DA20-0x000000018966DA40
		private void Start() {} // 0x00000001814A7BF0-0x00000001814A7C90
		// [XID] // 0x0000000189675840-0x0000000189675860
		public void Init() {} // 0x00000001814A6B20-0x00000001814A6CB0
		// [XID] // 0x000000018967D150-0x000000018967D170
		private void InitReally() {} // 0x00000001814A73C0-0x00000001814A7680
		// [XID] // 0x0000000189684800-0x0000000189684820
		private void SetParticleSystem() {} // 0x00000001814A7230-0x00000001814A73C0
		// [XID] // 0x000000018968C370-0x000000018968C390
		private void SetParticleMaterial() {} // 0x00000001814A78D0-0x00000001814A7A40
		// [XID] // 0x0000000189693E20-0x0000000189693E40
		private void InitCloudParticles() {} // 0x00000001814A6CB0-0x00000001814A7230
		// [XID] // 0x000000018969B3D0-0x000000018969B3F0
		private void InitCloudParticlesCustomData(float lifetime = 0f /* Metadata: 0x00B1278F */) {} // 0x00000001814A67B0-0x00000001814A6A40
		// [XID] // 0x00000001896A2B30-0x00000001896A2B50
		private void PostLateUpdateAction() {} // 0x00000001814A7680-0x00000001814A78D0
		// [XID] // 0x00000001896A9FB0-0x00000001896A9FD0
		private void GetCloudParticles() {} // 0x00000001814A6580-0x00000001814A6700
		// [XID] // 0x00000001896B0D30-0x00000001896B0D50
		private void SetCloudParticles() {} // 0x00000001814A6A40-0x00000001814A6B20
		// [XID] // 0x00000001896B89F0-0x00000001896B8A10
		private void UpdateCloudParticles() {} // 0x00000001814A5CC0-0x00000001814A63F0
		// [XID] // 0x00000001896BFC10-0x00000001896BFC30
		private void OnDisable() {} // 0x00000001814A7A40-0x00000001814A7AE0
		// [XID] // 0x00000001896C74D0-0x00000001896C74F0
		private void OnEnable() {} // 0x00000001814A7AE0-0x00000001814A7BF0
		// [XID] // 0x00000001896CEC30-0x00000001896CEC50
		public void EnableEmitter(bool enable) {} // 0x00000001814A63F0-0x00000001814A6580
		// [XID] // 0x00000001896D6030-0x00000001896D6050
		public void ForceReInit() {} // 0x00000001814A6700-0x00000001814A67B0
	}
}
