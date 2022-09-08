/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginScale : BaseMonoEffectPlugin // TypeDefIndex: 19734
	{
		// Fields
		// [Header] // 0x0000000189A2A5A0-0x0000000189A2A5D0
		public float scale; // 0x28
		// [Header] // 0x0000000189A33290-0x0000000189A332C0
		public bool scaleWithEnityViewSize; // 0x2C
		// [Header] // 0x0000000189A3C240-0x0000000189A3C270
		public bool scaleWithCameraScreenSize; // 0x2D
		public int originalWidthPixel; // 0x30
		public int originalHeightPixel; // 0x34
		// [Header] // 0x0000000189A45470-0x0000000189A454A0
		public bool transformRootScale; // 0x38
		private Vector3 _originalRootScale; // 0x3C
		public ParticalScaleObj[] scaledParticleSystems; // 0x48
		private ParticleSystem[] _allParticleSystems; // 0x50
		private ParticleSystem _mainParticleSystem; // 0x58
		private Vector3 _effectPos; // 0x60
		private Camera _camera; // 0x70
		private float _initialPerPixel; // 0x78
		private float _screenHeight; // 0x7C
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		private float _viewSizeScale; // 0x80
		private ParticleScaleValues[] _initialValus; // 0x88
	
		// Nested types
		[Serializable]
		public class ParticalScaleObj // TypeDefIndex: 19735
		{
			// Fields
			public ParticleSystem particle; // 0x10
			// [Range] // 0x0000000189B2BB80-0x0000000189B2BBA0
			public float SizeExp; // 0x18
			// [Range] // 0x0000000189B2BB80-0x0000000189B2BBA0
			public float EmitExp; // 0x1C
			public bool useAdapter; // 0x20
			public float normalOffset; // 0x24
	
			// Constructors
			public ParticalScaleObj() {} // 0x0000000183CB2C70-0x0000000183CB2CF0
		}
	
		private struct ParticleScaleValues // TypeDefIndex: 19736
		{
			// Fields
			public Vector3 localPosition; // 0x00
			public float gravity; // 0x0C
			public float startSizeConstant; // 0x10
			public float startSizeConstantMin; // 0x14
			public float startSizeConstantMax; // 0x18
			public float startSpeedConstant; // 0x1C
			public float startSpeedConstantMin; // 0x20
			public float startSpeedConstantMax; // 0x24
			public float radius; // 0x28
			public Vector3 box; // 0x2C
			public float emmisionRateOverTimeConstant; // 0x38
			public float emmisionRateOverTimeConstantMin; // 0x3C
			public float emmisionRateOverTimeConstantMax; // 0x40
			public float emmisionRateOverDistanceConstant; // 0x44
			public float emmisionRateOverDistanceConstantMin; // 0x48
			public float emmisionRateOverDistanceConstantMax; // 0x4C
			public short[] emmisionBurstMaxCount; // 0x50
			public short[] emmisionBurstMinCount; // 0x58
			public ParticalScaleObj scaleObj; // 0x60
			public ParticleSystemShapeType orginalType; // 0x68
			public Vector3 orginalScale; // 0x6C
			public float startSizeXConstant; // 0x78
			public float startSizeXConstantMin; // 0x7C
			public float startSizeXConstantMax; // 0x80
			public float startSizeYConstant; // 0x84
			public float startSizeYConstantMin; // 0x88
			public float startSizeYConstantMax; // 0x8C
			public float startSizeZConstant; // 0x90
			public float startSizeZConstantMin; // 0x94
			public float startSizeZConstantMax; // 0x98
		}
	
		// Constructors
		public MonoEffectPluginScale() {} // 0x0000000184E55C50-0x0000000184E55D40
	
		// Methods
		// [XID] // 0x0000000189A58A60-0x0000000189A58A80
		public override void Awaked() {} // 0x0000000184E52000-0x0000000184E52F00
		// [XID] // 0x0000000189A60500-0x0000000189A60520
		private void ScaleParticles(float scale) {} // 0x0000000184E53C80-0x0000000184E54DD0
		// [XID] // 0x0000000189A68130-0x0000000189A68150
		public override void Init() {} // 0x0000000184E552E0-0x0000000184E55680
		// [XID] // 0x0000000189A6F500-0x0000000189A6F520
		public override void Enabled() {} // 0x0000000184E54DD0-0x0000000184E54ED0
		// [XID] // 0x0000000189A76CC0-0x0000000189A76CE0
		private float GetSceenScale() => default; // 0x0000000184E54ED0-0x0000000184E55050
		// [XID] // 0x0000000189A7E6A0-0x0000000189A7E6C0
		private float GetPerPixelHeight() => default; // 0x0000000184E550B0-0x0000000184E552E0
		// [XID] // 0x0000000189A85FD0-0x0000000189A85FF0
		private float GetInitialScale() => default; // 0x0000000184E55680-0x0000000184E55880
		// [XID] // 0x0000000189A8D930-0x0000000189A8D950
		public override void Clear() {} // 0x0000000184E53B00-0x0000000184E53BE0
		// [XID] // 0x0000000189A94E30-0x0000000189A94E50
		public override void Disabled() {} // 0x0000000184E53BE0-0x0000000184E53C80
		// [XID] // 0x0000000189A9C770-0x0000000189A9C790
		private void ClearSkinnedSystem() {} // 0x0000000184E55880-0x0000000184E55B90
		// [XID] // 0x0000000189AA3E80-0x0000000189AA3EA0
		private void SetupSkinmesh(BaseEntity entity) {} // 0x0000000184E52F00-0x0000000184E53AA0
	}
}
