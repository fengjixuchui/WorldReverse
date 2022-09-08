/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace VerletEngine
{
	// [AddComponentMenu] // 0x00000001897F5D30-0x00000001897F5D60
	public class DynamicBoneArray : MonoBehaviour // TypeDefIndex: 31409
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string dynamicBoneArrayGuid; // 0x18
		// [Tooltip] // 0x0000000189806280-0x00000001898062B0
		public Transform[] m_RootList; // 0x20
		// [Header] // 0x000000018980F370-0x000000018980F3D0
		// [Tooltip] // 0x000000018980F370-0x000000018980F3D0
		public float m_UpdateRate; // 0x28
		public UpdateMode m_UpdateMode; // 0x2C
		// [Header] // 0x000000018981CB40-0x000000018981CBC0
		// [Range] // 0x000000018981CB40-0x000000018981CBC0
		// [Tooltip] // 0x000000018981CB40-0x000000018981CBC0
		public float m_Damping; // 0x30
		public AnimationCurve m_DampingDistrib; // 0x38
		// [Header] // 0x000000018982CF30-0x000000018982CF60
		public bool m_KeepShape; // 0x40
		public bool m_KeepLength; // 0x41
		// [Range] // 0x0000000189835F50-0x0000000189835FA0
		// [Tooltip] // 0x0000000189835F50-0x0000000189835FA0
		public float m_Elasticity; // 0x44
		public AnimationCurve m_ElasticityDistrib; // 0x48
		// [Range] // 0x0000000189841A10-0x0000000189841A60
		// [Tooltip] // 0x0000000189841A10-0x0000000189841A60
		public float m_Stiffness; // 0x50
		public AnimationCurve m_StiffnessDistrib; // 0x58
		// [Header] // 0x000000018984D8E0-0x000000018984D960
		// [Range] // 0x000000018984D8E0-0x000000018984D960
		// [Tooltip] // 0x000000018984D8E0-0x000000018984D960
		public float m_Inert; // 0x60
		public AnimationCurve m_InertDistrib; // 0x68
		// [Header] // 0x000000018985D4D0-0x000000018985D530
		// [Tooltip] // 0x000000018985D4D0-0x000000018985D530
		public float m_EndLength; // 0x70
		// [Tooltip] // 0x000000018986AE40-0x000000018986AE70
		public Vector3 m_EndOffset; // 0x74
		// [Header] // 0x00000001898738C0-0x0000000189873920
		// [Tooltip] // 0x00000001898738C0-0x0000000189873920
		public Vector3 m_Gravity; // 0x80
		// [Tooltip] // 0x0000000189881000-0x0000000189881030
		public Vector3 m_Force; // 0x8C
		// [Header] // 0x0000000189889C00-0x0000000189889C30
		public Transform m_dragTowards; // 0x98
		public float m_dragForceScale; // 0xA0
		private List<Vector3> m_dragForce; // 0xA8
		private EnableType _needInitTrans; // 0xB0
		public List<OverrideParam> m_OverrideParam; // 0xB8
		private OverrideParam _defaultParam; // 0xC0
		private OverrideParam _windParam; // 0xC8
		private OverrideParam _curParam; // 0xD0
		private OverrideParam _targetParam; // 0xD8
		public float m_OverrideBlendTime; // 0xE0
		private float _blendWeight; // 0xE4
		public DynamicBoneWindForce m_AdditiveWindForce; // 0xE8
		// [Header] // 0x0000000189892950-0x00000001898929B0
		// [Tooltip] // 0x0000000189892950-0x00000001898929B0
		public float m_Radius; // 0xF0
		public AnimationCurve m_RadiusDistrib; // 0xF8
		// [Tooltip] // 0x000000018989F9A0-0x000000018989F9D0
		public List<DynamicBoneColliderBaseMMD> m_Colliders; // 0x100
		// [Header] // 0x00000001898A8B20-0x00000001898A8B80
		// [Tooltip] // 0x00000001898A8B20-0x00000001898A8B80
		public List<Transform> m_Exclusions; // 0x108
		// [Tooltip] // 0x00000001898B61A0-0x00000001898B61D0
		public FreezeAxis m_FreezeAxis; // 0x110
		// [Tooltip] // 0x00000001898BF0B0-0x00000001898BF0E0
		public Transform m_FreezeTransformRef; // 0x118
		private Vector3 m_FreezeTransformAxis; // 0x120
		// [Header] // 0x00000001898C83D0-0x00000001898C8430
		// [Tooltip] // 0x00000001898C83D0-0x00000001898C8430
		public bool m_DistantDisable; // 0x12C
		public Transform m_ReferenceObject; // 0x130
		public float m_DistanceToObject; // 0x138
		// [Header] // 0x00000001898D5AE0-0x00000001898D5B10
		public DebugDrawOption m_DebugDraw; // 0x13C
		// [Header] // 0x00000001898D5AE0-0x00000001898D5B10
		public string m_watchParticleName; // 0x140
		// [Header] // 0x00000001898D5AE0-0x00000001898D5B10
		public bool m_useDebugWind; // 0x148
		// [Header] // 0x00000001898D5AE0-0x00000001898D5B10
		public Vector4 m_debugWind; // 0x14C
		private const float FUTURE_POSE_TIME = 2f; // Metadata: 0x00B12698
		private float m_lastFrameRemainTime; // 0x15C
		private const int MaxDbUpdateCountOneFrame = 3; // Metadata: 0x00B1269C
		private float m_lastFrameDeltaTime; // 0x160
		private Vector3 m_LocalGravity; // 0x164
		private float m_ObjectScale; // 0x170
		[NonSerialized]
		public Vector3 cachedLossyScale; // 0x174
		private Vector3 m_ObjectMove; // 0x180
		private Vector3 m_ObjectPrevPosition; // 0x18C
		private List<float> m_BoneTotalLengthList; // 0x198
		private float m_Weight; // 0x1A0
		private bool m_DistantDisabled; // 0x1A4
		private List<VerletParticle> m_Particles; // 0x1A8
		private Vector3 m_posOffset; // 0x1B0
		private ThreadTask_DynamicBoneArrayDoubleBuffer _threadTask; // 0x1C0
		private bool bRootIsValid; // 0x1C8
		private VCDynamicBoneController _vcController; // 0x1D0
		private bool _movementInfluenceDisabled; // 0x1D8
		private bool hasSetupParticle; // 0x1D9
		[NonSerialized]
		public bool bMultiThread; // 0x1DA
		public static bool bResetBoneInUpdate; // 0x00
		private int _lerpCount; // 0x1DC
		private int _enableFrameCount; // 0x1E0
		private Transform _rootTransform; // 0x1E8
		private static bool bJobType; // 0x01
		private DynamicBoneArrayData _dynamicBoneArrayData; // 0x1F0
		private UnityThreadPendingChange_DynamicBoneArray _pendingChange; // 0x1F8
	
		// Properties
		public List<VerletParticle> verletParticles { get => default; } // 0x000000018522C870-0x000000018522C8D0 
		public Transform rootTransform { get => default; } // 0x000000018522C810-0x000000018522C870 
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 31410
		{
			Normal = 0,
			AnimatePhysics = 1,
			UnscaledTime = 2,
			OncePerFrame = 3,
			OncePerFixedUpdate = 4
		}
	
		private enum EnableType // TypeDefIndex: 31411
		{
			Invalid = 0,
			FuturePose = 1,
			Entity = 2,
			Disable = 3,
			Lerp = 4
		}
	
		[Serializable]
		public class OverrideParam // TypeDefIndex: 31412
		{
			// Fields
			public List<string> stateList; // 0x10
			[NonSerialized]
			public List<int> hash; // 0x18
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float damping; // 0x20
			public AnimationCurve dampingDistrib; // 0x28
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float elasticity; // 0x30
			public AnimationCurve elasticityDistrib; // 0x38
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float stiffness; // 0x40
			public AnimationCurve stiffnessDistrib; // 0x48
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float inert; // 0x50
			public AnimationCurve inertDistrib; // 0x58
			public bool disable; // 0x60
	
			// Constructors
			public OverrideParam() {} // 0x0000000185235240-0x0000000185235320
		}
	
		public enum FreezeAxis // TypeDefIndex: 31413
		{
			None = 0,
			X = 1,
			Y = 2,
			Z = 3
		}
	
		public enum DebugDrawOption // TypeDefIndex: 31414
		{
			None = 0,
			Selected = 1,
			Always = 2
		}
	
		// Constructors
		public DynamicBoneArray() {} // 0x000000018522C400-0x000000018522C810
		static DynamicBoneArray() {} // 0x000000018522C390-0x000000018522C400
	
		// Methods
		public void InitVCController(VCDynamicBoneController vc) {} // 0x00000001852251B0-0x0000000185225220
		public bool ShouldTick() => default; // 0x0000000185228640-0x0000000185228740
		private void Start() {} // 0x0000000185228740-0x0000000185228830
		private void Init(bool bRestart) {} // 0x0000000185225BF0-0x0000000185225D60
		private void FixedUpdate() {} // 0x0000000185224DE0-0x0000000185224E90
		private void Update() {} // 0x000000018522C270-0x000000018522C390
		public void InternalLateUpdate_UnityThread() {} // 0x0000000185225E20-0x0000000185225EB0
		// [ContextMenu] // 0x00000001898F5A70-0x00000001898F5AA0
		private void ToggleMultiThread() {} // 0x0000000185228DD0-0x0000000185228EF0
		// [ContextMenu] // 0x00000001898FEA30-0x00000001898FEA60
		private void ToggleResetBoneInUpdate() {} // 0x0000000185228EF0-0x0000000185229000
		private void LateUpdate() {} // 0x00000001852261C0-0x0000000185226240
		private void PreUpdate() {} // 0x0000000185226AE0-0x0000000185226D50
		private void UpdateInitTrans() {} // 0x00000001852297E0-0x0000000185229970
		private void OnEnable() {} // 0x0000000185226A20-0x0000000185226A90
		private void ResetOnEnable() {} // 0x00000001852273A0-0x00000001852274E0
		private void SetFuturePose(float duration) {} // 0x0000000185227840-0x0000000185227CB0
		private void OnDisable() {} // 0x0000000185226970-0x0000000185226A20
		private void OnDestroy() {} // 0x0000000185226910-0x0000000185226970
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator DelayRestart() => default; // 0x0000000185223F50-0x0000000185224020
		private void ResetBindPose() {} // 0x0000000185227130-0x00000001852271D0
		private void OnValidate() {} // 0x0000000185226A90-0x0000000185226AE0
		private void DrawDebugInfo() {} // 0x00000001852240E0-0x0000000185224D90
		private void DrawString(string text, Vector3 worldPos, Color? colour = default) {} // 0x0000000185224D90-0x0000000185224DE0
		private bool NeedUpdateDynamicBone() => default; // 0x0000000185226890-0x0000000185226910
		private void CheckDistance() {} // 0x0000000185223040-0x00000001852232D0
		private void SetupOverrideParam() {} // 0x0000000185227DD0-0x0000000185228290
		private void SetupParticles() {} // 0x0000000185228290-0x0000000185228640
		// [ContextMenu] // 0x000000018990F480-0x000000018990F4B0
		private void InitWindforceBones() {} // 0x0000000185225220-0x0000000185225BF0
		private float AddNewParticle(int parentIndex, float parentBoneLength, int rootIndex, Transform boneTransform) => default; // 0x0000000185221F50-0x0000000185222550
		private void AppendAdditionalEndParticle(int parentIndex, float parentBoneLength, int rootIndex) {} // 0x0000000185222550-0x00000001852225F0
		private float UpdateBoneLength(ref VerletParticle p, float parentBoneLength, int rootIndex) => default; // 0x0000000185229000-0x0000000185229140
		private void RecursivelyAppendParticles(Transform b, int parentIndex, float parentBoneLength, int rootIndex) {} // 0x0000000185226D50-0x0000000185227130
		private void UpdateParticleParameters() {} // 0x000000018522AB10-0x000000018522B060
		public void UpdateParticleParameters(int stateID) {} // 0x000000018522A970-0x000000018522AB10
		private void InternalUpdateParticleParameters() {} // 0x0000000185225EB0-0x0000000185225FB0
		private void CacheLastParameters() {} // 0x0000000185222E20-0x0000000185222F40
		private void LerpParticleParameters() {} // 0x0000000185226240-0x0000000185226730
		private bool IsWindForce() => default; // 0x00000001852260B0-0x00000001852261C0
		private void UpdateWindForce() {} // 0x000000018522C1D0-0x000000018522C270
		private void ResetBoneTransforms() {} // 0x00000001852271D0-0x00000001852273A0
		private void ResetParticlesPosition() {} // 0x00000001852274E0-0x0000000185227840
		private int CalDbUpdateCount(float dbTimeStep, float frameDeltaTime) => default; // 0x0000000185222F40-0x0000000185223040
		private void UpdateDynamicBones(float frameDeltaTime) {} // 0x0000000185229310-0x0000000185229670
		private Vector3 GetWindForceSource() => default; // 0x0000000185225060-0x00000001852251B0
		private void UpdateParticlesVerlet(float timeStep, float lastTimeStep = -1f /* Metadata: 0x00B12690 */) {} // 0x000000018522BAB0-0x000000018522C1D0
		private void UpdateFreezeTransformNormal() {} // 0x0000000185229670-0x00000001852297E0
		private void UpdateOldConstraint(ref Plane movePlane, bool keepShape) {} // 0x000000018522A0C0-0x000000018522A970
		private void UpdateParticlesConstraints() {} // 0x000000018522B0E0-0x000000018522B160
		private static Vector3 MirrorVector(Vector3 v, Vector3 axis) => default; // 0x0000000185226730-0x0000000185226890
		private void ApplyParticlesToTransforms() {} // 0x0000000185222900-0x0000000185222E20
		public void SetWeight(float w) {} // 0x0000000185227D30-0x0000000185227DD0
		public float GetWeight() => default; // 0x0000000185224FF0-0x0000000185225060
		public void SetMovementInfluence(bool shouldInfluence) {} // 0x0000000185227CB0-0x0000000185227D30
		private void UpdateOldConstraint_ComputeThread(ref Plane movePlane, bool keepShape) {} // 0x0000000185229970-0x000000018522A0C0
		private void UpdateParticlesConstraints_ComputeThread() {} // 0x000000018522B060-0x000000018522B0E0
		private void UpdateDynamicBones_ComputeThread(float frameDeltaTime) {} // 0x0000000185229140-0x0000000185229310
		private void SyncAnimatedBoneTransform_ComputeThread(ref ThreadData_DynamicBoneArray inComputeThreadBuff) {} // 0x0000000185228830-0x0000000185228DD0
		public void InternalLateUpdate_ComputeThread(ref ThreadData_DynamicBoneArray inComputeThreadBuff, float dt) {} // 0x0000000185225D60-0x0000000185225E20
		private void UpdateParticlesVerlet_ComputeThread(float timeStep, float lastTimeStep = -1f /* Metadata: 0x00B12694 */) {} // 0x000000018522B160-0x000000018522BAB0
		private static Transform GetAttachPoint(Transform inRoot, string pointName) => default; // 0x0000000185224E90-0x0000000185224FF0
		private void CreateComputeThreadTask() {} // 0x0000000185223C40-0x0000000185223F50
		private void DestroyComputeThreadTask() {} // 0x0000000185224020-0x00000001852240E0
		private void IntitializeUnityThreadPendingChange() {} // 0x0000000185225FB0-0x00000001852260B0
		public UnityThreadPendingChange_DynamicBoneArray CollectBoneChangeInUnityThread() => default; // 0x00000001852237B0-0x0000000185223C40
		public UnityThreadPendingChange_DynamicBoneArray CollectBoneChangeInUnityThread(UnityThreadPendingChange_DynamicBoneArray inPendingChange) => default; // 0x00000001852232D0-0x00000001852237B0
		public void ApplyParticlesToTransformsByComputeThreadResult(ref ThreadData_DynamicBoneArray inResult) {} // 0x00000001852225F0-0x0000000185222900
	}
}
