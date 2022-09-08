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

namespace VerletEngine
{
	// [AddComponentMenu] // 0x0000000189A21170-0x0000000189A211A0
	public class DynamicBoneRigidArray : MonoBehaviour // TypeDefIndex: 31426
	{
		// Fields
		public Transform[] m_RootList; // 0x18
		// [Header] // 0x0000000189A29E90-0x0000000189A29EC0
		public float m_UpdateRate; // 0x20
		public UpdateMode m_UpdateMode; // 0x24
		// [Header] // 0x0000000189A32C10-0x0000000189A32C60
		// [Range] // 0x0000000189A32C10-0x0000000189A32C60
		public float m_Damping; // 0x28
		public AnimationCurve m_DampingDistrib; // 0x30
		// [Header] // 0x0000000189A3EE20-0x0000000189A3EE50
		public bool m_KeepShape; // 0x38
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float m_Elasticity; // 0x3C
		public AnimationCurve m_ElasticityDistrib; // 0x40
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float m_Stiffness; // 0x48
		public AnimationCurve m_StiffnessDistrib; // 0x50
		// [Header] // 0x0000000189A56B90-0x0000000189A56BF0
		// [Range] // 0x0000000189A56B90-0x0000000189A56BF0
		public float m_Inert; // 0x58
		public AnimationCurve m_InertDistrib; // 0x60
		// [Header] // 0x0000000189A62C70-0x0000000189A62CA0
		public float m_EndLength; // 0x68
		public Vector3 m_EndOffset; // 0x6C
		// [Header] // 0x0000000189A6BF00-0x0000000189A6BF30
		public Vector3 m_Gravity; // 0x78
		public Vector3 m_Force; // 0x84
		// [Header] // 0x0000000189A74C60-0x0000000189A74C90
		public LayerMask colliderMask; // 0x90
		public int solveTimes; // 0x94
		public float m_Radius; // 0x98
		public AnimationCurve m_RadiusDistrib; // 0xA0
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float timeLerpRatio; // 0xA8
		public float m_RotateStepAngle; // 0xAC
		public bool m_AverageHorizonAngle; // 0xB0
		public float m_AverageThresholdAngle; // 0xB4
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float m_AverageLimitRatio; // 0xB8
		public bool m_ChildCompensate; // 0xBC
		public MainDirection m_RotateAxis; // 0xC0
		public bool m_RotatePositive; // 0xC4
		public bool m_CollideHorizonLine; // 0xC5
		public bool m_CollideParticle; // 0xC6
		public bool m_UpdateVerlet; // 0xC7
		public List<DynamicBoneColliderBaseMMD> m_Colliders; // 0xC8
		// [Header] // 0x0000000189A8D170-0x0000000189A8D1A0
		public List<Transform> m_Exclusions; // 0xD0
		public FreezeAxis m_FreezeAxis; // 0xD8
		// [Header] // 0x0000000189A946D0-0x0000000189A94700
		public bool m_DistantDisable; // 0xDC
		public Transform m_ReferenceObject; // 0xE0
		public float m_DistanceToObject; // 0xE8
		// [Header] // 0x0000000189A9D590-0x0000000189A9D5C0
		public int m_DeltaIndex; // 0xEC
		// [Range] // 0x0000000189AA66B0-0x0000000189AA66D0
		public float m_UpScale; // 0xF0
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float m_LowScale; // 0xF4
		// [Header] // 0x0000000189AB5680-0x0000000189AB56B0
		public DebugDrawOption m_DebugDraw; // 0xF8
		private float m_BoneTotalLength; // 0xFC
		private float m_Weight; // 0x100
		private bool m_DistantDisabled; // 0x104
		private float m_lastFrameRemainTime; // 0x108
		private const int MaxDbUpdateCountOneFrame = 3; // Metadata: 0x00B12733
		private Vector3 m_LocalGravity; // 0x10C
		private float m_ObjectScale; // 0x118
		private Vector3 m_ObjectMove; // 0x11C
		private Vector3 m_ObjectPrevPosition; // 0x128
		private List<VerletParticle> m_Particles; // 0x138
		private List<StaticHorizonLine> m_HorizonLines; // 0x140
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 31427
		{
			Normal = 0,
			AnimatePhysics = 1,
			UnscaledTime = 2
		}
	
		public enum FreezeAxis // TypeDefIndex: 31428
		{
			None = 0,
			X = 1,
			Y = 2,
			Z = 3
		}
	
		public enum DebugDrawOption // TypeDefIndex: 31429
		{
			None = 0,
			Selected = 1,
			Always = 2
		}
	
		// Constructors
		public DynamicBoneRigidArray() {} // 0x00000001852314F0-0x00000001852317A0
	
		// Methods
		private void Start() {} // 0x000000018522FAB0-0x000000018522FB10
		private void FixedUpdate() {} // 0x000000018522E020-0x000000018522E090
		private void Update() {} // 0x0000000185231480-0x00000001852314F0
		private void LateUpdate() {} // 0x000000018522E100-0x000000018522E1D0
		private void PreUpdate() {} // 0x000000018522E710-0x000000018522E780
		private void OnEnable() {} // 0x000000018522E570-0x000000018522E5D0
		private void OnDisable() {} // 0x000000018522E3B0-0x000000018522E410
		private void OnValidate() {} // 0x000000018522E5D0-0x000000018522E710
		private void DrawDebugInfo() {} // 0x000000018522DC00-0x000000018522E020
		private void OnDrawGizmosSelected() {} // 0x000000018522E410-0x000000018522E4F0
		private void OnDrawGizmos() {} // 0x000000018522E4F0-0x000000018522E570
		private bool NeedUpdateDynamicBone() => default; // 0x000000018522E330-0x000000018522E3B0
		private void CheckDistance() {} // 0x000000018522D970-0x000000018522DC00
		private void SetupParticles() {} // 0x000000018522F390-0x000000018522F5C0
		private void AddStaticHorizonLines() {} // 0x000000018522C8D0-0x000000018522CB30
		private void AppendAdditionalEndParticle(int parentIndex, float parentBoneLength) {} // 0x000000018522CB30-0x000000018522CF90
		private float UpdateBoneLength(ref VerletParticle p, float parentBoneLength) => default; // 0x000000018522FCE0-0x000000018522FF40
		private void RecursivelyAppendParticles(Transform b, int parentIndex, float parentBoneLength) {} // 0x000000018522E780-0x000000018522EC10
		private void UpdateParticleParameters() {} // 0x0000000185230840-0x0000000185230C10
		private void ResetBoneTransforms() {} // 0x000000018522EC10-0x000000018522EDE0
		private void ResetParticlesPosition() {} // 0x000000018522EDE0-0x000000018522F040
		private int CalDbUpdateCount(float dbTimeStep, float frameDeltaTime) => default; // 0x000000018522D870-0x000000018522D970
		private void UpdateStaticBoneCollision() {} // 0x0000000185230FC0-0x0000000185231480
		private void AverageHorizonNeigborAngles() {} // 0x000000018522D440-0x000000018522D870
		private void StoreLastBoneData() {} // 0x000000018522FB10-0x000000018522FCE0
		private void ResetTimeLerpedBoneData() {} // 0x000000018522F040-0x000000018522F2F0
		private void UpdateDynamicBones(float frameDeltaTime) {} // 0x000000018522FF40-0x00000001852301E0
		private void UpdateParticlesVerlet(float timeStep) {} // 0x0000000185230C90-0x0000000185230FC0
		private void UpdateOldConstraint(ref Plane movePlane, bool keepShape) {} // 0x00000001852301E0-0x0000000185230840
		private void UpdateParticlesConstraints() {} // 0x0000000185230C10-0x0000000185230C90
		private void SkipUpdateParticles() {} // 0x000000018522F5C0-0x000000018522FAB0
		private static Vector3 MirrorVector(Vector3 v, Vector3 axis) => default; // 0x000000018522E1D0-0x000000018522E330
		private void ApplyParticlesToTransforms() {} // 0x000000018522CF90-0x000000018522D440
		public void SetWeight(float w) {} // 0x000000018522F2F0-0x000000018522F390
		public float GetWeight() => default; // 0x000000018522E090-0x000000018522E100
	}
}
