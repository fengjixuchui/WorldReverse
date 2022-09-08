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
using RootMotion;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	// [AddComponentMenu] // 0x0000000189A6EB20-0x0000000189A6EB80
	// [HelpURL] // 0x0000000189A6EB20-0x0000000189A6EB80
	public class PuppetMaster : MonoBehaviour // TypeDefIndex: 9900
	{
		// Fields
		// [Tooltip] // 0x0000000189A7C460-0x0000000189A7C490
		public PuppetMasterHumanoidConfig humanoidConfig; // 0x18
		public Transform targetRoot; // 0x20
		private bool dynamicCreation; // 0x28
		public bool simpleMode; // 0x29
		public float exposionForceMultiplier; // 0x2C
		public float rootVelocityChange; // 0x30
		public float ragdollMaxDelayTime; // 0x34
		private float upwardOffset; // 0x38
		// [LargeHeader] // 0x0000000189A855D0-0x0000000189A85630
		// [Tooltip] // 0x0000000189A855D0-0x0000000189A85630
		public State state; // 0x3C
		// [ContextMenuItem] // 0x0000000189A92DC0-0x0000000189A92E40
		// [Tooltip] // 0x0000000189A92DC0-0x0000000189A92E40
		public StateSettings stateSettings; // 0x40
		// [Tooltip] // 0x0000000189AA18B0-0x0000000189AA18E0
		public Mode mode; // 0x54
		// [Tooltip] // 0x0000000189AAA6D0-0x0000000189AAA700
		public float blendTime; // 0x58
		// [Tooltip] // 0x0000000189AB3B70-0x0000000189AB3BA0
		public bool fixTargetTransforms; // 0x5C
		// [Tooltip] // 0x0000000189ABCDE0-0x0000000189ABCE10
		public int solverIterationCount; // 0x60
		// [Tooltip] // 0x0000000189AC6190-0x0000000189AC61C0
		public bool visualizeTargetPose; // 0x64
		// [LargeHeader] // 0x0000000189ACEDB0-0x0000000189ACEE30
		// [Range] // 0x0000000189ACEDB0-0x0000000189ACEE30
		// [Tooltip] // 0x0000000189ACEDB0-0x0000000189ACEE30
		public float mappingWeight; // 0x68
		// [Range] // 0x0000000189ADFF80-0x0000000189ADFFE0
		// [Tooltip] // 0x0000000189ADFF80-0x0000000189ADFFE0
		public float pinWeight; // 0x6C
		// [Range] // 0x0000000189AEBDF0-0x0000000189AEBE50
		// [Tooltip] // 0x0000000189AEBDF0-0x0000000189AEBE50
		public float muscleWeight; // 0x70
		// [LargeHeader] // 0x0000000189AF7FB0-0x0000000189AF8010
		// [Tooltip] // 0x0000000189AF7FB0-0x0000000189AF8010
		public float muscleSpring; // 0x74
		// [Tooltip] // 0x0000000189B05490-0x0000000189B054C0
		public float muscleDamper; // 0x78
		// [Range] // 0x0000000189B0E4F0-0x0000000189B0E540
		// [Tooltip] // 0x0000000189B0E4F0-0x0000000189B0E540
		public float pinPow; // 0x7C
		// [Range] // 0x0000000189B1A000-0x0000000189B1A050
		// [Tooltip] // 0x0000000189B1A000-0x0000000189B1A050
		public float pinDistanceFalloff; // 0x80
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool updateJointAnchors; // 0x84
		// [Tooltip] // 0x0000000189B2D280-0x0000000189B2D2B0
		public bool supportTranslationAnimation; // 0x85
		// [Tooltip] // 0x0000000189B36130-0x0000000189B36160
		public bool angularLimits; // 0x86
		// [Tooltip] // 0x0000000189B3F2B0-0x0000000189B3F2E0
		public bool internalCollisions; // 0x87
		// [LargeHeader] // 0x0000000189B48410-0x0000000189B48470
		// [Tooltip] // 0x0000000189B48410-0x0000000189B48470
		public Muscle[] muscles; // 0x88
		public UpdateDelegate OnPostInitiate; // 0x90
		public UpdateDelegate OnRead; // 0x98
		public UpdateDelegate OnWrite; // 0xA0
		public UpdateDelegate OnPostLateUpdate; // 0xA8
		public UpdateDelegate OnFixTransforms; // 0xB0
		public UpdateDelegate OnHierarchyChanged; // 0xB8
		public MuscleDelegate OnMuscleRemoved; // 0xC0
		private Animator _targetAnimator; // 0xC8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<SolverManager> solvers; // 0xE8
		private bool internalCollisionsEnabled; // 0xF0
		private bool angularLimitsEnabled; // 0xF1
		private bool fixedFrame; // 0xF2
		private int lastSolverIterationCount; // 0xF4
		private bool isLegacy; // 0xF8
		private bool animatorDisabled; // 0xF9
		private bool interpolated; // 0xFA
		private bool freezeFlag; // 0xFB
		private bool hasBeenDisabled; // 0xFC
		private bool hierarchyIsFlat; // 0xFD
		private bool teleport; // 0xFE
		private Vector3 teleportPosition; // 0x100
		private Quaternion teleportRotation; // 0x10C
		private bool teleportMoveToTarget; // 0x11C
		private Mode activeMode; // 0x120
		private Mode lastMode; // 0x124
		private float mappingBlend; // 0x128
		public UpdateDelegate OnFreeze; // 0x130
		public UpdateDelegate OnUnfreeze; // 0x138
		public UpdateDelegate OnDeath; // 0x140
		public UpdateDelegate OnResurrection; // 0x148
		private State activeState; // 0x150
		private State lastState; // 0x154
		private bool angularLimitsEnabledOnKill; // 0x158
		private bool internalCollisionsEnabledOnKill; // 0x159
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool storeTargetMappedState; // 0x15A
		private Transform[] targetChildren; // 0x160
		private Vector3[] targetMappedPositions; // 0x168
		private Quaternion[] targetMappedRotations; // 0x170
		private Vector3[] targetSampledPositions; // 0x178
		private Quaternion[] targetSampledRotations; // 0x180
		private bool targetMappedStateStored; // 0x188
		private bool targetMappedStateSampled; // 0x189
		private bool sampleTargetMappedState; // 0x18A
		private bool hasProp; // 0x18B
	
		// Properties
		public Animator targetAnimator { /* [XID] */ /* 0x00000001895EB6B0-0x00000001895EB6D0 */ get => default; /* [XID] */ /* 0x00000001895F2A80-0x00000001895F2AA0 */ set {} } // 0x00000001877969D0-0x0000000187796BA0 0x0000000187797040-0x00000001877970F0
		public Animation targetAnimation { /* [XID] */ /* 0x00000001895FA360-0x00000001895FA3A0 */ get; /* [XID] */ /* 0x0000000189604B90-0x0000000189604BD0 */ private set; } // 0x0000000187796970-0x00000001877969D0 0x0000000187796FD0-0x0000000187797040
		public BehaviourBase[] behaviours { /* [XID] */ /* 0x000000018960F3F0-0x000000018960F430 */ get; private set; } // 0x00000001877962E0-0x0000000187796340 0x0000000187796E10-0x0000000187796E80
		public bool isActive { /* [XID] */ /* 0x000000018973D1D0-0x000000018973D1F0 */ get => default; } // 0x0000000187796480-0x00000001877965A0 
		public bool initiated { /* [XID] */ /* 0x0000000189628980-0x00000001896289C0 */ get; /* [XID] */ /* 0x0000000189633230-0x0000000189633270 */ private set; } // 0x0000000187796420-0x0000000187796480 0x0000000187796E80-0x0000000187796EF0
		public UpdateMode updateMode { /* [XID] */ /* 0x0000000189976DF0-0x0000000189976E10 */ get => default; } // 0x0000000187796D50-0x0000000187796E10 
		public bool controlsAnimator { /* [XID] */ /* 0x0000000189645240-0x0000000189645260 */ get => default; } // 0x0000000187796340-0x0000000187796420 
		public bool isBlending { /* [XID] */ /* 0x0000000189B1D750-0x0000000189B1D770 */ get => default; } // 0x0000000187796650-0x0000000187796750 
		private AnimatorUpdateMode targetUpdateMode { /* [XID] */ /* 0x0000000189BC4F00-0x0000000189BC4F20 */ get => default; } // 0x0000000187796BA0-0x0000000187796D50 
		public bool isSwitchingMode { /* [XID] */ /* 0x0000000189784200-0x0000000189784240 */ get; /* [XID] */ /* 0x000000018978E6A0-0x000000018978E6E0 */ private set; } // 0x0000000187796860-0x00000001877968C0 0x0000000187796F60-0x0000000187796FD0
		public bool isSwitchingState { /* [XID] */ /* 0x00000001898D2790-0x00000001898D27B0 */ get => default; } // 0x00000001877968C0-0x0000000187796970 
		public bool isKilling { /* [XID] */ /* 0x00000001898DA010-0x00000001898DA050 */ get; /* [XID] */ /* 0x00000001898E4AE0-0x00000001898E4B20 */ private set; } // 0x0000000187796800-0x0000000187796860 0x0000000187796EF0-0x0000000187796F60
		public bool isAlive { /* [XID] */ /* 0x00000001898EF730-0x00000001898EF750 */ get => default; } // 0x00000001877965A0-0x0000000187796650 
		public bool isFrozen { /* [XID] */ /* 0x00000001898F7050-0x00000001898F7070 */ get => default; } // 0x0000000187796750-0x0000000187796800 
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 9901
		{
			Active = 0,
			Kinematic = 1,
			Disabled = 2
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 9902; 0x00000001877A20B0-0x00000001877A2210
	
		public delegate void MuscleDelegate(Muscle muscle); // TypeDefIndex: 9903; 0x000000018777D5B0-0x000000018777D810
	
		[Serializable]
		public enum UpdateMode // TypeDefIndex: 9904
		{
			Normal = 0,
			AnimatePhysics = 1,
			FixedUpdate = 2
		}
	
		[Serializable]
		public enum State // TypeDefIndex: 9905
		{
			Alive = 0,
			Dead = 1,
			Frozen = 2
		}
	
		[Serializable]
		public struct StateSettings // TypeDefIndex: 9906
		{
			// Fields
			// [Tooltip] // 0x00000001899F5F80-0x00000001899F5FB0
			public float killDuration; // 0x00
			// [Tooltip] // 0x00000001899FEF40-0x00000001899FEF70
			public float deadMuscleWeight; // 0x04
			// [Tooltip] // 0x0000000189A07CC0-0x0000000189A07CF0
			public float deadMuscleDamper; // 0x08
			// [Tooltip] // 0x0000000189A10B00-0x0000000189A10B30
			public float maxFreezeSqrVelocity; // 0x0C
			// [Tooltip] // 0x0000000189A198F0-0x0000000189A19920
			public bool freezePermanently; // 0x10
			// [Tooltip] // 0x0000000189A22930-0x0000000189A22960
			public bool enableAngularLimitsOnKill; // 0x11
			// [Tooltip] // 0x0000000189A2B280-0x0000000189A2B2B0
			public bool enableInternalCollisionsOnKill; // 0x12
	
			// Properties
			public static StateSettings Default { /* [XID] */ /* 0x00000001899F2740-0x00000001899F2760 */ get => default; } // 0x000000018779AE60-0x000000018779AFF0 
	
			// Constructors
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f /* Metadata: 0x00AE6CC0 */, float deadMuscleDamper = 2f /* Metadata: 0x00AE6CC4 */, float maxFreezeSqrVelocity = 0.02f /* Metadata: 0x00AE6CC8 */, bool freezePermanently = false /* Metadata: 0x00AE6CCC */, bool enableAngularLimitsOnKill = true /* Metadata: 0x00AE6CCD */, bool enableInternalCollisionsOnKill = true /* Metadata: 0x00AE6CCE */) : this() {
				this.killDuration = default;
				this.deadMuscleWeight = default;
				this.deadMuscleDamper = default;
				this.maxFreezeSqrVelocity = default;
				this.freezePermanently = default;
				this.enableAngularLimitsOnKill = default;
				this.enableInternalCollisionsOnKill = default;
			} // 0x000000018779AE30-0x000000018779AE60
		}
	
		// Constructors
		public PuppetMaster() {} // 0x0000000187796130-0x00000001877962E0
	
		// Methods
		// [ContextMenu] // 0x0000000189B986D0-0x0000000189B98720
		// [XID] // 0x0000000189B986D0-0x0000000189B98720
		private void OpenUserManualSetup() {} // 0x000000018778D040-0x000000018778D0F0
		// [ContextMenu] // 0x0000000189BA43C0-0x0000000189BA4410
		// [XID] // 0x0000000189BA43C0-0x0000000189BA4410
		private void OpenUserManualComponent() {} // 0x000000018778CEE0-0x000000018778CF90
		// [ContextMenu] // 0x0000000189BAFD60-0x0000000189BAFDB0
		// [XID] // 0x0000000189BAFD60-0x0000000189BAFDB0
		private void OpenUserManualPerformance() {} // 0x000000018778CF90-0x000000018778D040
		// [ContextMenu] // 0x0000000189BBBE10-0x0000000189BBBE60
		// [XID] // 0x0000000189BBBE10-0x0000000189BBBE60
		private void OpenScriptReference() {} // 0x000000018778CD80-0x000000018778CE30
		// [ContextMenu] // 0x0000000189BC6710-0x0000000189BC6760
		// [XID] // 0x0000000189BC6710-0x0000000189BC6760
		private void OpenSetupTutorial() {} // 0x000000018778CE30-0x000000018778CEE0
		// [ContextMenu] // 0x0000000189BD29A0-0x0000000189BD29F0
		// [XID] // 0x0000000189BD29A0-0x0000000189BD29F0
		private void OpenComponentTutorial() {} // 0x000000018778CCD0-0x000000018778CD80
		// [XID] // 0x00000001896EE1D0-0x00000001896EE1F0
		private void ResetStateSettings() {} // 0x0000000187791600-0x00000001877916B0
		// [XID] // 0x00000001896540D0-0x00000001896540F0
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget) {} // 0x0000000187794FB0-0x00000001877950D0
		// [XID] // 0x000000018965BB10-0x000000018965BB30
		private void OnDisable() {} // 0x000000018778C2A0-0x000000018778C420
		// [XID] // 0x0000000189662E60-0x0000000189662E80
		private void OnEnable() {} // 0x000000018778C420-0x000000018778C7B0
		// [XID] // 0x000000018966A990-0x000000018966A9B0
		private void Awake() {} // 0x00000001877854B0-0x0000000187785570
		// [XID] // 0x00000001896726B0-0x00000001896726D0
		private void Start() {} // 0x0000000187794520-0x00000001877945C0
		// [XID] // 0x0000000189679F00-0x0000000189679F20
		public Transform FindTargetRootRecursive(Transform t) => default; // 0x0000000187786FF0-0x00000001877872B0
		// [XID] // 0x0000000189A0FFD0-0x0000000189A0FFF0
		public void Initiate(bool isDyanmic) {} // 0x000000018778A2A0-0x000000018778A8C0
		// [XID] // 0x000000018976C1E0-0x000000018976C200
		public void AddVeocityOnRoot(Vector3 velocity) {} // 0x0000000187784360-0x00000001877845D0
		// [XID] // 0x0000000189676AD0-0x0000000189676AF0
		private void ActivateBehaviour(BehaviourBase behaviour) {} // 0x0000000187782880-0x0000000187782A20
		// [XID] // 0x0000000189748830-0x0000000189748850
		private void OnDestroy() {} // 0x000000018778C150-0x000000018778C2A0
		// [XID] // 0x000000018969F800-0x000000018969F820
		private bool IsInterpolated() => default; // 0x000000018778AD00-0x000000018778AE60
		// [XID] // 0x000000018967E320-0x000000018967E340
		protected virtual void FixedUpdate() {} // 0x0000000187788180-0x0000000187788890
		// [XID] // 0x00000001897886A0-0x00000001897886C0
		protected virtual void Update() {} // 0x0000000187795A00-0x0000000187795B50
		// [XID] // 0x00000001896B5780-0x00000001896B57A0
		protected virtual void LateUpdate() {} // 0x000000018778BE60-0x000000018778BF40
		// [XID] // 0x00000001899681E0-0x0000000189968200
		protected virtual void OnLateUpdate() {} // 0x000000018778C960-0x000000018778CCD0
		// [XID] // 0x00000001896C4040-0x00000001896C4060
		public void MoveToTarget() {} // 0x000000018778BF40-0x000000018778C150
		// [XID] // 0x0000000189AC0F50-0x0000000189AC0F70
		private void Read() {} // 0x000000018778D0F0-0x000000018778DBC0
		// [XID] // 0x0000000189685AB0-0x0000000189685AD0
		private void FixTargetTransforms() {} // 0x0000000187787F60-0x0000000187788180
		// [XID] // 0x00000001896E1C60-0x00000001896E1C80
		private void VisualizeTargetPose() {} // 0x0000000187795D40-0x0000000187796130
		// [XID] // 0x00000001896E9200-0x00000001896E9220
		private void VisualizeHierarchy(Transform t, Color color) {} // 0x0000000187795B50-0x0000000187795D40
		// [XID] // 0x00000001896F0270-0x00000001896F0290
		private void SetInternalCollisions(bool collide) {} // 0x0000000187791C90-0x0000000187791E20
		// [XID] // 0x000000018967EB40-0x000000018967EB60
		private void SetAngularLimits(bool limited) {} // 0x0000000187791950-0x0000000187791AA0
		// [XID] // 0x00000001896FF630-0x00000001896FF650
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, Muscle.Props muscleProps = null, bool forceTreeHierarchy = false /* Metadata: 0x00AE6C47 */, bool forceLayers = true /* Metadata: 0x00AE6C48 */) {} // 0x0000000187783400-0x0000000187783E50
		// [XID] // 0x0000000189706A00-0x0000000189706A20
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false /* Metadata: 0x00AE6C49 */, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever /* Metadata: 0x00AE6C4A */) {} // 0x000000018778EF80-0x00000001877909B0
		// [XID] // 0x00000001897086E0-0x0000000189708700
		public void RemoveMuscleRecursiveOnBreak(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false /* Metadata: 0x00AE6C4E */, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever /* Metadata: 0x00AE6C4F */) {} // 0x000000018778DBC0-0x000000018778EF80
		// [XID] // 0x0000000189715710-0x0000000189715730
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint) {} // 0x00000001877914F0-0x0000000187791600
		// [XID] // 0x00000001896D7260-0x00000001896D7280
		public void SetMuscles(Muscle[] newMuscles) {} // 0x0000000187792B90-0x0000000187792C90
		// [XID] // 0x00000001896ED3F0-0x00000001896ED410
		public void DisableMuscleRecursive(ConfigurableJoint joint) {} // 0x00000001877863F0-0x00000001877864F0
		// [XID] // 0x0000000189703A40-0x0000000189703A60
		public void EnableMuscleRecursive(ConfigurableJoint joint) {} // 0x00000001877869A0-0x0000000187786AA0
		// [ContextMenu] // 0x0000000189733490-0x00000001897334E0
		// [XID] // 0x0000000189733490-0x00000001897334E0
		public void FlattenHierarchy() {} // 0x0000000187788890-0x0000000187788A20
		// [ContextMenu] // 0x000000018973FBE0-0x000000018973FC30
		// [XID] // 0x000000018973FBE0-0x000000018973FC30
		public void TreeHierarchy() {} // 0x00000001877950D0-0x00000001877952E0
		// [ContextMenu] // 0x000000018974BA00-0x000000018974BA50
		// [XID] // 0x000000018974BA00-0x000000018974BA50
		public void FixMusclePositions() {} // 0x00000001877872B0-0x0000000187787490
		// [XID] // 0x0000000189757580-0x00000001897575A0
		public void FixMuscleRotations() {} // 0x0000000187787490-0x0000000187787670
		// [XID] // 0x000000018975EDD0-0x000000018975EDF0
		public void AddExplosionForce(Vector3 pos, float radius) {} // 0x0000000187782F40-0x0000000187783140
		// [XID] // 0x000000018982D4C0-0x000000018982D4E0
		private void AddIndexesRecursive(int index, ref int[] indexes) {} // 0x0000000187783140-0x0000000187783400
		// [XID] // 0x0000000189B9FA80-0x0000000189B9FAA0
		private bool HierarchyIsFlat() => default; // 0x0000000187789EF0-0x000000018778A080
		// [XID] // 0x0000000189774F60-0x0000000189774F80
		private void DisconnectJoint(ConfigurableJoint joint) {} // 0x0000000187786870-0x00000001877869A0
		// [XID] // 0x000000018977C800-0x000000018977C820
		private void KillJoint(ConfigurableJoint joint) {} // 0x000000018778B900-0x000000018778BA60
		// [XID] // 0x0000000189798D30-0x0000000189798D50
		public void DisableImmediately() {} // 0x0000000187786270-0x00000001877863F0
		// [XID] // 0x00000001897A0BD0-0x00000001897A0BF0
		protected virtual void SwitchModes() {} // 0x0000000187794B60-0x0000000187794DD0
		// [XID] // 0x00000001897A8270-0x00000001897A8290
		private void DisabledToKinematic() {} // 0x0000000187786600-0x0000000187786870
		[DebuggerHidden] // 0x00000001897AFD90-0x00000001897AFDD0
		// [XID] // 0x00000001897AFD90-0x00000001897AFDD0
		private IEnumerator DisabledToActive() => default; // 0x00000001877864F0-0x0000000187786600
		// [XID] // 0x0000000189642190-0x00000001896421B0
		private void KinematicToDisabled() {} // 0x000000018778BCE0-0x000000018778BE60
		[DebuggerHidden] // 0x00000001897C2600-0x00000001897C2640
		// [XID] // 0x00000001897C2600-0x00000001897C2640
		private IEnumerator KinematicToActive() => default; // 0x000000018778BBD0-0x000000018778BCE0
		[DebuggerHidden] // 0x00000001897CCF80-0x00000001897CCFC0
		// [XID] // 0x00000001897CCF80-0x00000001897CCFC0
		private IEnumerator ActiveToDisabled() => default; // 0x0000000187782D20-0x0000000187782E30
		[DebuggerHidden] // 0x00000001897D77B0-0x00000001897D77F0
		// [XID] // 0x00000001897D77B0-0x00000001897D77F0
		private IEnumerator ActiveToKinematic() => default; // 0x0000000187782E30-0x0000000187782F40
		// [XID] // 0x0000000189B6BEE0-0x0000000189B6BF00
		private void UpdateInternalCollisions() {} // 0x0000000187795880-0x0000000187795A00
		// [IDTag] // 0x00000001897E9710-0x00000001897E9750
		// [XID] // 0x00000001897E9710-0x00000001897E9750
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f /* Metadata: 0x00AE6C53 */, float mappingWeight = 1f /* Metadata: 0x00AE6C57 */, float muscleDamper = 1f /* Metadata: 0x00AE6C5B */) {} // 0x0000000187792400-0x00000001877925A0
		// [IDTag] // 0x00000001897F4340-0x00000001897F4380
		// [XID] // 0x00000001897F4340-0x00000001897F4380
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f /* Metadata: 0x00AE6C5F */, float mappingWeight = 1f /* Metadata: 0x00AE6C63 */, float muscleDamper = 1f /* Metadata: 0x00AE6C67 */) {} // 0x0000000187792700-0x0000000187792860
		// [IDTag] // 0x00000001897FE6D0-0x00000001897FE710
		// [XID] // 0x00000001897FE6D0-0x00000001897FE710
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f /* Metadata: 0x00AE6C6B */, float mappingWeight = 1f /* Metadata: 0x00AE6C6F */, float muscleDamper = 1f /* Metadata: 0x00AE6C73 */) {} // 0x00000001877925A0-0x0000000187792700
		// [IDTag] // 0x0000000189808ED0-0x0000000189808F10
		// [XID] // 0x0000000189808ED0-0x0000000189808F10
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f /* Metadata: 0x00AE6C77 */, float mappingWeight = 1f /* Metadata: 0x00AE6C7B */, float muscleDamper = 1f /* Metadata: 0x00AE6C7F */) {} // 0x0000000187791E20-0x0000000187792030
		// [IDTag] // 0x00000001898134A0-0x00000001898134E0
		// [XID] // 0x00000001898134A0-0x00000001898134E0
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f /* Metadata: 0x00AE6C83 */, float mappingWeight = 1f /* Metadata: 0x00AE6C87 */, float muscleDamper = 1f /* Metadata: 0x00AE6C8B */) {} // 0x0000000187792030-0x00000001877922A0
		// [IDTag] // 0x000000018981DFD0-0x000000018981E010
		// [XID] // 0x000000018981DFD0-0x000000018981E010
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f /* Metadata: 0x00AE6C8F */, float mappingWeight = 1f /* Metadata: 0x00AE6C93 */, float muscleDamper = 1f /* Metadata: 0x00AE6C97 */) {} // 0x00000001877922A0-0x0000000187792400
		// [IDTag] // 0x00000001898287D0-0x0000000189828810
		// [XID] // 0x00000001898287D0-0x0000000189828810
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper) {} // 0x0000000187792860-0x0000000187792B90
		// [IDTag] // 0x0000000189832B10-0x0000000189832B50
		// [XID] // 0x0000000189832B10-0x0000000189832B50
		public Muscle GetMuscle(Transform target) => default; // 0x0000000187789C00-0x0000000187789CF0
		// [IDTag] // 0x000000018983D1E0-0x000000018983D220
		// [XID] // 0x000000018983D1E0-0x000000018983D220
		public Muscle GetMuscle(Rigidbody rigidbody) => default; // 0x0000000187789B10-0x0000000187789C00
		// [IDTag] // 0x0000000189847690-0x00000001898476D0
		// [XID] // 0x0000000189847690-0x00000001898476D0
		public Muscle GetMuscle(ConfigurableJoint joint) => default; // 0x0000000187789CF0-0x0000000187789DE0
		// [XID] // 0x0000000189851A80-0x0000000189851AA0
		public bool ContainsJoint(ConfigurableJoint joint) => default; // 0x0000000187785F10-0x0000000187786070
		// [IDTag] // 0x00000001898592A0-0x00000001898592E0
		// [XID] // 0x00000001898592A0-0x00000001898592E0
		public int GetMuscleIndex(HumanBodyBones humanBodyBone) => default; // 0x0000000187789860-0x0000000187789B10
		// [IDTag] // 0x00000001898637B0-0x00000001898637F0
		// [XID] // 0x00000001898637B0-0x00000001898637F0
		public int GetMuscleIndex(Transform target) => default; // 0x0000000187789320-0x00000001877895C0
		// [IDTag] // 0x000000018986D780-0x000000018986D7C0
		// [XID] // 0x000000018986D780-0x000000018986D7C0
		public int GetMuscleIndex(Rigidbody rigidbody) => default; // 0x0000000187789080-0x0000000187789320
		// [IDTag] // 0x0000000189877D80-0x0000000189877DC0
		// [XID] // 0x0000000189877D80-0x0000000189877DC0
		public int GetMuscleIndex(ConfigurableJoint joint) => default; // 0x00000001877895C0-0x0000000187789860
		// [IDTag] // 0x0000000189882220-0x0000000189882260
		// [XID] // 0x0000000189882220-0x0000000189882260
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer) => default; // 0x00000001877941A0-0x0000000187794320
		// [IDTag] // 0x000000018988C8C0-0x000000018988C900
		// [XID] // 0x000000018988C8C0-0x000000018988C900
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer) => default; // 0x0000000187794320-0x0000000187794520
		// [XID] // 0x0000000189794180-0x00000001897941A0
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer) {} // 0x0000000187793680-0x00000001877941A0
		// [XID] // 0x000000018976EE30-0x000000018976EE50
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer, int ragdollLayer) {} // 0x00000001877909B0-0x0000000187790F90
		// [XID] // 0x00000001898A5AD0-0x00000001898A5AF0
		public void SetUpMuscles(Transform setUpTo) {} // 0x0000000187792C90-0x0000000187793680
		// [XID] // 0x00000001897C9C40-0x00000001897C9C60
		public void InitializeBinding(Transform setUpTo) {} // 0x000000018778A080-0x000000018778A2A0
		// [XID] // 0x00000001898B4520-0x00000001898B4540
		public void Clear() {} // 0x0000000187785CA0-0x0000000187785F10
		// [XID] // 0x00000001897AAE60-0x00000001897AAE80
		private static Muscle.Group FindGroup(Animator animator, Transform t) => default; // 0x0000000187786AA0-0x0000000187786FF0
		// [XID] // 0x000000018977DE90-0x000000018977DEB0
		private void RemoveUnnecessaryBones() {} // 0x0000000187790F90-0x00000001877914F0
		// [XID] // 0x00000001898CB030-0x00000001898CB050
		private static bool IsClothCollider(Collider collider, Cloth[] cloths) => default; // 0x000000018778A8C0-0x000000018778AD00
		// [IDTag] // 0x00000001898FE870-0x00000001898FE8B0
		// [XID] // 0x00000001898FE870-0x00000001898FE8B0
		public void Kill() {} // 0x000000018778BB30-0x000000018778BBD0
		// [IDTag] // 0x0000000189908F70-0x0000000189908FB0
		// [XID] // 0x0000000189908F70-0x0000000189908FB0
		public void Kill(StateSettings stateSettings) {} // 0x000000018778BA60-0x000000018778BB30
		// [IDTag] // 0x0000000189913940-0x0000000189913980
		// [XID] // 0x0000000189913940-0x0000000189913980
		public void Freeze() {} // 0x0000000187788AF0-0x0000000187788B90
		// [IDTag] // 0x000000018991E190-0x000000018991E1D0
		// [XID] // 0x000000018991E190-0x000000018991E1D0
		public void Freeze(StateSettings stateSettings) {} // 0x0000000187788A20-0x0000000187788AF0
		// [XID] // 0x0000000189928A70-0x0000000189928A90
		public void Resurrect() {} // 0x00000001877916B0-0x0000000187791750
		// [XID] // 0x000000018992FE50-0x000000018992FE70
		protected virtual void SwitchStates() {} // 0x0000000187794DD0-0x0000000187794FB0
		[DebuggerHidden] // 0x0000000189937430-0x0000000189937470
		// [XID] // 0x0000000189937430-0x0000000189937470
		private IEnumerator AliveToDead(bool freeze) => default; // 0x00000001877845D0-0x00000001877846F0
		// [XID] // 0x0000000189941AF0-0x0000000189941B10
		private void OnFreezeFlag() {} // 0x000000018778C7B0-0x000000018778C960
		// [XID] // 0x00000001896381C0-0x00000001896381E0
		private void DeadToAlive() {} // 0x0000000187786070-0x00000001877861D0
		// [XID] // 0x000000018997A310-0x000000018997A330
		private void SetAnimationEnabled(bool to) {} // 0x0000000187791AA0-0x0000000187791C90
		// [XID] // 0x00000001899585D0-0x00000001899585F0
		private void DeadToFrozen() {} // 0x00000001877861D0-0x0000000187786270
		// [XID] // 0x00000001896FD2D0-0x00000001896FD2F0
		private void FrozenToAlive() {} // 0x0000000187788B90-0x0000000187788E40
		// [XID] // 0x00000001899E37D0-0x00000001899E37F0
		private void FrozenToDead() {} // 0x0000000187788E40-0x0000000187788F10
		// [XID] // 0x0000000189885140-0x0000000189885160
		private void ActivateRagdoll(bool kinematic = false /* Metadata: 0x00AE6C9B */) {} // 0x0000000187782A20-0x0000000187782D20
		// [XID] // 0x00000001896B9B80-0x00000001896B9BA0
		private bool CanFreeze() => default; // 0x0000000187785570-0x00000001877856D0
		// [XID] // 0x00000001896864D0-0x00000001896864F0
		public void SampleTargetMappedState() {} // 0x0000000187791750-0x0000000187791950
		// [XID] // 0x00000001898D49F0-0x00000001898D4A10
		public void FixTargetToSampledState(float weight) {} // 0x0000000187787670-0x0000000187787F60
		// [XID] // 0x000000018966F120-0x000000018966F140
		public void StoreTargetMappedState() {} // 0x00000001877945C0-0x0000000187794B60
		// [XID] // 0x00000001899949E0-0x0000000189994A00
		private void UpdateHierarchies() {} // 0x0000000187795550-0x0000000187795880
		// [XID] // 0x000000018968E290-0x000000018968E2B0
		private bool HasProp() => default; // 0x0000000187789DE0-0x0000000187789EF0
		// [XID] // 0x0000000189988E20-0x0000000189988E40
		private void UpdateBroadcasterMuscleIndexes() {} // 0x00000001877952E0-0x0000000187795550
		// [XID] // 0x0000000189B91B00-0x0000000189B91B20
		private void AssignParentAndChildIndexes() {} // 0x0000000187784F40-0x00000001877854B0
		// [XID] // 0x00000001897125F0-0x0000000189712610
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes) {} // 0x0000000187784160-0x0000000187784360
		// [XID] // 0x000000018999E570-0x000000018999E590
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags) {} // 0x0000000187783E50-0x0000000187784160
		// [XID] // 0x00000001899A5F90-0x00000001899A5FB0
		private void AssignKinshipDegrees() {} // 0x00000001877846F0-0x0000000187784920
		// [XID] // 0x00000001899873D0-0x00000001899873F0
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index) {} // 0x0000000187784920-0x0000000187784B60
		// [XID] // 0x000000018998EFC0-0x000000018998EFE0
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index) {} // 0x0000000187784B60-0x0000000187784F40
		// [XID] // 0x00000001899D8110-0x00000001899D8130
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint) => default; // 0x0000000187788F10-0x0000000187789080
		// [XID] // 0x00000001899DF7A0-0x00000001899DF7C0
		public bool IsValid(bool log) => default; // 0x000000018778AE60-0x000000018778B900
		// [XID] // 0x0000000189AD53C0-0x0000000189AD53E0
		private bool CheckMassVariation(float threshold, bool log) => default; // 0x0000000187785830-0x0000000187785CA0
		// [XID] // 0x00000001899EE790-0x00000001899EE7B0
		private bool CheckIfInitiated() => default; // 0x00000001877856D0-0x0000000187785830
	}
}
