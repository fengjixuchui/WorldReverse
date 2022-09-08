/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	public abstract class BehaviourBase : MonoBehaviour // TypeDefIndex: 9864
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public PuppetMaster puppetMaster; // 0x18
		public BehaviourDelegate OnPreActivate; // 0x20
		public BehaviourDelegate OnPreInitiate; // 0x28
		public BehaviourDelegate OnPreFixedUpdate; // 0x30
		public BehaviourDelegate OnPreUpdate; // 0x38
		public BehaviourDelegate OnPreLateUpdate; // 0x40
		public BehaviourDelegate OnPreDeactivate; // 0x48
		public BehaviourDelegate OnPreFixTransforms; // 0x50
		public BehaviourDelegate OnPreRead; // 0x58
		public BehaviourDelegate OnPreWrite; // 0x60
		public HitDelegate OnPreMuscleHit; // 0x68
		public CollisionDelegate OnPreMuscleCollision; // 0x70
		public CollisionDelegate OnPreMuscleCollisionExit; // 0x78
		public BehaviourDelegate OnHierarchyChanged; // 0x80
		public BehaviourDelegate OnPostActivate; // 0x88
		public BehaviourDelegate OnPostInitiate; // 0x90
		public BehaviourDelegate OnPostFixedUpdate; // 0x98
		public BehaviourDelegate OnPostUpdate; // 0xA0
		public BehaviourDelegate OnPostLateUpdate; // 0xA8
		public BehaviourDelegate OnPostDeactivate; // 0xB0
		public BehaviourDelegate OnPostDrawGizmos; // 0xB8
		public BehaviourDelegate OnPostFixTransforms; // 0xC0
		public BehaviourDelegate OnPostRead; // 0xC8
		public BehaviourDelegate OnPostWrite; // 0xD0
		public HitDelegate OnPostMuscleHit; // 0xD8
		public CollisionDelegate OnPostMuscleCollision; // 0xE0
		public CollisionDelegate OnPostMuscleCollisionExit; // 0xE8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool deactivated; // 0xF0
		private bool initiated; // 0xF2
	
		// Properties
		public bool forceActive { get; /* [XID] */ /* 0x0000000189826E10-0x0000000189826E50 */ protected set; } // 0x00000001876C4900-0x00000001876C4960 0x00000001876C4960-0x00000001876C49D0
	
		// Nested types
		public delegate void BehaviourDelegate(); // TypeDefIndex: 9865; 0x00000001876C4AD0-0x00000001876C4C30
	
		public delegate void HitDelegate(MuscleHit hit); // TypeDefIndex: 9866; 0x00000001876D69C0-0x00000001876D6BF0
	
		public delegate void CollisionDelegate(MuscleCollision collision); // TypeDefIndex: 9867; 0x00000001876D5E00-0x00000001876D6030
	
		[Serializable]
		public struct PuppetEvent // TypeDefIndex: 9868
		{
			// Fields
			// [Tooltip] // 0x00000001898BD700-0x00000001898BD730
			public string switchToBehaviour; // 0x00
			// [Tooltip] // 0x00000001898C66A0-0x00000001898C66D0
			public AnimatorEvent[] animations; // 0x08
			// [Tooltip] // 0x00000001898CF7A0-0x00000001898CF7D0
			public UnityEvent unityEvent; // 0x10
			private const string empty = ""; // Metadata: 0x00AE6BB9
	
			// Properties
			public bool switchBehaviour { /* [XID] */ /* 0x0000000189972990-0x00000001899729B0 */ get => default; } // 0x00000001876E2D70-0x00000001876E2F10 
	
			// Methods
			// [XID] // 0x00000001898E0560-0x00000001898E0580
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true /* Metadata: 0x00AE6BB8 */) {} // 0x00000001876E2C30-0x00000001876E2D70
		}
	
		[Serializable]
		public class AnimatorEvent // TypeDefIndex: 9869
		{
			// Fields
			public string animationState; // 0x10
			public float crossfadeTime; // 0x18
			public int layer; // 0x1C
			public bool resetNormalizedTime; // 0x20
			private const string empty = ""; // Metadata: 0x00AE6BBD
	
			// Constructors
			public AnimatorEvent() {} // 0x00000001876C14E0-0x00000001876C1550
	
			// Methods
			// [IDTag] // 0x00000001898E7FE0-0x00000001898E8020
			// [XID] // 0x00000001898E7FE0-0x00000001898E8020
			public void Activate(Animator animator, Animation animation) {} // 0x00000001876C1220-0x00000001876C1360
			// [IDTag] // 0x00000001898F26A0-0x00000001898F26E0
			// [XID] // 0x00000001898F26A0-0x00000001898F26E0
			private void Activate(Animator animator) {} // 0x00000001876C1070-0x00000001876C1220
			// [IDTag] // 0x00000001898FCE50-0x00000001898FCE90
			// [XID] // 0x00000001898FCE50-0x00000001898FCE90
			private void Activate(Animation animation) {} // 0x00000001876C1360-0x00000001876C14E0
		}
	
		// Constructors
		protected BehaviourBase() {} // 0x00000001876C4890-0x00000001876C4900
	
		// Methods
		public abstract void OnReactivate();
		// [XID] // 0x0000000189781340-0x0000000189781360
		public virtual void Resurrect() {} // 0x00000001876C3E70-0x00000001876C3F10
		// [XID] // 0x0000000189788860-0x0000000189788880
		public virtual void Freeze() {} // 0x00000001876C2020-0x00000001876C20C0
		// [XID] // 0x000000018978FFD0-0x000000018978FFF0
		public virtual void Unfreeze() {} // 0x00000001876C46A0-0x00000001876C4740
		// [XID] // 0x00000001897977A0-0x00000001897977C0
		public virtual void KillStart() {} // 0x00000001876C2520-0x00000001876C25C0
		// [XID] // 0x000000018979F710-0x000000018979F730
		public virtual void KillEnd() {} // 0x00000001876C2480-0x00000001876C2520
		// [XID] // 0x00000001897A6BE0-0x00000001897A6C00
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget) {} // 0x00000001876C3920-0x00000001876C3A40
		// [XID] // 0x00000001897AE2E0-0x00000001897AE300
		public virtual void OnMuscleAdded(Muscle m) {} // 0x00000001876C2FE0-0x00000001876C30A0
		// [XID] // 0x0000000189BAEF60-0x0000000189BAEF80
		public virtual void OnMuscleRemoved(Muscle m) {} // 0x00000001876C36D0-0x00000001876C3790
		// [XID] // 0x00000001897BE200-0x00000001897BE220
		protected virtual void OnActivate() {} // 0x00000001876C2830-0x00000001876C28D0
		// [XID] // 0x00000001897C5930-0x00000001897C5950
		protected virtual void OnDeactivate() {} // 0x00000001876C28D0-0x00000001876C2970
		// [XID] // 0x00000001897CCFF0-0x00000001897CD010
		protected virtual void OnInitiate() {} // 0x00000001876C2EA0-0x00000001876C2F40
		// [XID] // 0x00000001897D4630-0x00000001897D4650
		protected virtual void OnFixedUpdate() {} // 0x00000001876C2E00-0x00000001876C2EA0
		// [XID] // 0x00000001897DBD50-0x00000001897DBD70
		protected virtual void OnUpdate() {} // 0x00000001876C3A40-0x00000001876C3AE0
		// [XID] // 0x000000018970BFD0-0x000000018970BFF0
		protected virtual void OnLateUpdate() {} // 0x00000001876C2F40-0x00000001876C2FE0
		// [XID] // 0x00000001897EAF60-0x00000001897EAF80
		protected virtual void OnDrawGizmosBehaviour() {} // 0x00000001876C2A50-0x00000001876C2AF0
		// [XID] // 0x00000001897F2BD0-0x00000001897F2BF0
		protected virtual void OnFixTransformsBehaviour() {} // 0x00000001876C2C70-0x00000001876C2D10
		// [XID] // 0x00000001897FA4F0-0x00000001897FA510
		protected virtual void OnReadBehaviour() {} // 0x00000001876C3790-0x00000001876C3830
		// [XID] // 0x0000000189801B10-0x0000000189801B30
		protected virtual void OnWriteBehaviour() {} // 0x00000001876C3AE0-0x00000001876C3B80
		// [XID] // 0x0000000189808F10-0x0000000189808F30
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit) {} // 0x00000001876C34C0-0x00000001876C3580
		// [XID] // 0x0000000189810810-0x0000000189810830
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision) {} // 0x00000001876C30A0-0x00000001876C3160
		// [XID] // 0x0000000189817F70-0x0000000189817F90
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision) {} // 0x00000001876C3160-0x00000001876C3220
		// [XID] // 0x0000000189831260-0x0000000189831280
		public void Initiate() {} // 0x00000001876C23A0-0x00000001876C2480
		// [XID] // 0x0000000189838AA0-0x0000000189838AC0
		public void OnFixTransforms() {} // 0x00000001876C2D10-0x00000001876C2E00
		// [XID] // 0x0000000189840020-0x0000000189840040
		public void OnRead() {} // 0x00000001876C3830-0x00000001876C3920
		// [XID] // 0x0000000189B7CD70-0x0000000189B7CD90
		public void OnWrite() {} // 0x00000001876C3B80-0x00000001876C3C70
		// [XID] // 0x000000018984EDE0-0x000000018984EE00
		public void OnMuscleHit(MuscleHit hit) {} // 0x00000001876C3580-0x00000001876C36D0
		// [XID] // 0x0000000189855ED0-0x0000000189855EF0
		public void OnMuscleCollision(MuscleCollision collision) {} // 0x00000001876C3370-0x00000001876C34C0
		// [XID] // 0x000000018985D180-0x000000018985D1A0
		public void OnMuscleCollisionExit(MuscleCollision collision) {} // 0x00000001876C3220-0x00000001876C3370
		// [XID] // 0x0000000189864BF0-0x0000000189864C10
		private void OnEnable() {} // 0x00000001876C2BC0-0x00000001876C2C70
		// [XID] // 0x000000018969A970-0x000000018969A990
		public void Activate() {} // 0x00000001876C1D40-0x00000001876C1ED0
		// [XID] // 0x00000001898736B0-0x00000001898736D0
		private void OnDisable() {} // 0x00000001876C2970-0x00000001876C2A50
		// [XID] // 0x000000018987B170-0x000000018987B190
		private void FixedUpdate() {} // 0x00000001876C1ED0-0x00000001876C2020
		// [XID] // 0x0000000189882260-0x0000000189882280
		private void Update() {} // 0x00000001876C4740-0x00000001876C4890
		// [XID] // 0x0000000189889890-0x00000001898898B0
		private void LateUpdate() {} // 0x00000001876C25C0-0x00000001876C2710
		// [XID] // 0x0000000189834380-0x00000001898343A0
		protected virtual void OnDrawGizmos() {} // 0x00000001876C2AF0-0x00000001876C2BC0
		// [XID] // 0x0000000189898380-0x00000001898983A0
		protected void RotateTargetToRootMuscle() {} // 0x00000001876C3F10-0x00000001876C4250
		// [XID] // 0x000000018989F630-0x000000018989F650
		protected void TranslateTargetToRootMuscle(float maintainY) {} // 0x00000001876C4250-0x00000001876C46A0
		// [XID] // 0x0000000189B27FD0-0x0000000189B27FF0
		protected void RemoveMusclesOfGroup(Muscle.Group group) {} // 0x00000001876C3C70-0x00000001876C3E70
		// [XID] // 0x00000001898AEB30-0x00000001898AEB50
		protected virtual void GroundTarget(LayerMask layers) {} // 0x00000001876C20C0-0x00000001876C23A0
		// [XID] // 0x00000001898B5DB0-0x00000001898B5DD0
		protected bool MusclesContainsGroup(Muscle.Group group) => default; // 0x00000001876C2710-0x00000001876C2830
	}
}
