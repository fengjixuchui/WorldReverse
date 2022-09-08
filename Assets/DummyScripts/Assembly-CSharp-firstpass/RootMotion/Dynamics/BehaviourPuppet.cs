/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using RootMotion;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	// [AddComponentMenu] // 0x0000000189A3EB70-0x0000000189A3EBD0
	// [HelpURL] // 0x0000000189A3EB70-0x0000000189A3EBD0
	public class BehaviourPuppet : BehaviourBase // TypeDefIndex: 9872
	{
		// Fields
		// [LargeHeader] // 0x0000000189A4C0D0-0x0000000189A4C100
		public MasterProps masterProps; // 0xF8
		// [Tooltip] // 0x0000000189A55290-0x0000000189A552C0
		public LayerMask groundLayers; // 0x100
		// [Tooltip] // 0x0000000189A5E330-0x0000000189A5E360
		public LayerMask collisionLayers; // 0x104
		// [Tooltip] // 0x0000000189A67510-0x0000000189A67540
		public float collisionThreshold; // 0x108
		public Weight collisionResistance; // 0x110
		// [Tooltip] // 0x0000000189A702A0-0x0000000189A702D0
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers; // 0x118
		// [Range] // 0x0000000189A79420-0x0000000189A79470
		// [Tooltip] // 0x0000000189A79420-0x0000000189A79470
		public int maxCollisions; // 0x120
		// [Range] // 0x0000000189A85630-0x0000000189A85680
		// [Tooltip] // 0x0000000189A85630-0x0000000189A85680
		public float regainPinSpeed; // 0x124
		// [Tooltip] // 0x0000000189A915C0-0x0000000189A915F0
		public float boostFalloff; // 0x128
		// [LargeHeader] // 0x0000000189A9A840-0x0000000189A9A8A0
		// [Tooltip] // 0x0000000189A9A840-0x0000000189A9A8A0
		public MuscleProps defaults; // 0x130
		// [Tooltip] // 0x0000000189AA6360-0x0000000189AA6390
		public MusclePropsGroup[] groupOverrides; // 0x168
		// [LargeHeader] // 0x0000000189AAF380-0x0000000189AAF400
		// [Range] // 0x0000000189AAF380-0x0000000189AAF400
		// [Tooltip] // 0x0000000189AAF380-0x0000000189AAF400
		public float knockOutDistance; // 0x170
		// [Range] // 0x0000000189ABFC80-0x0000000189ABFCD0
		// [Tooltip] // 0x0000000189ABFC80-0x0000000189ABFCD0
		public float unpinnedMuscleWeightMlp; // 0x174
		// [Tooltip] // 0x0000000189ACBE30-0x0000000189ACBE60
		public float maxRigidbodyVelocity; // 0x178
		// [Range] // 0x0000000189AD5600-0x0000000189AD5650
		// [Tooltip] // 0x0000000189AD5600-0x0000000189AD5650
		public float pinWeightThreshold; // 0x17C
		// [Tooltip] // 0x0000000189AE1630-0x0000000189AE1660
		public bool unpinnedMuscleKnockout; // 0x180
		// [Tooltip] // 0x0000000189AEA560-0x0000000189AEA590
		public bool dropProps; // 0x181
		// [LargeHeader] // 0x0000000189AF38D0-0x0000000189AF3930
		// [Tooltip] // 0x0000000189AF38D0-0x0000000189AF3930
		public bool canGetUp; // 0x182
		// [Tooltip] // 0x0000000189B00CD0-0x0000000189B00D00
		public float getUpDelay; // 0x184
		// [Tooltip] // 0x0000000189B09D40-0x0000000189B09D70
		public float blendToAnimationTime; // 0x188
		// [Tooltip] // 0x0000000189B12BD0-0x0000000189B12C00
		public float maxGetUpVelocity; // 0x18C
		// [Tooltip] // 0x0000000189B1B970-0x0000000189B1B9A0
		public float minGetUpDuration; // 0x190
		// [Tooltip] // 0x0000000189B24700-0x0000000189B24730
		public float getUpCollisionResistanceMlp; // 0x194
		// [Tooltip] // 0x0000000189B2D2B0-0x0000000189B2D2E0
		public float getUpRegainPinSpeedMlp; // 0x198
		// [Tooltip] // 0x0000000189B36160-0x0000000189B36190
		public float getUpKnockOutDistanceMlp; // 0x19C
		// [Tooltip] // 0x0000000189B3F2E0-0x0000000189B3F310
		public Vector3 getUpOffsetProne; // 0x1A0
		// [Tooltip] // 0x0000000189B48470-0x0000000189B484A0
		public Vector3 getUpOffsetSupine; // 0x1AC
		// [LargeHeader] // 0x0000000189B51540-0x0000000189B515A0
		// [Tooltip] // 0x0000000189B51540-0x0000000189B515A0
		public PuppetEvent onGetUpProne; // 0x1B8
		// [Tooltip] // 0x0000000189B5D470-0x0000000189B5D4A0
		public PuppetEvent onGetUpSupine; // 0x1D0
		// [Tooltip] // 0x0000000189B66380-0x0000000189B663B0
		public PuppetEvent onLoseBalance; // 0x1E8
		// [Tooltip] // 0x0000000189B6EF70-0x0000000189B6EFA0
		public PuppetEvent onLoseBalanceFromPuppet; // 0x200
		// [Tooltip] // 0x0000000189B77F20-0x0000000189B77F50
		public PuppetEvent onLoseBalanceFromGetUp; // 0x218
		// [Tooltip] // 0x0000000189B80AB0-0x0000000189B80AE0
		public PuppetEvent onRegainBalance; // 0x230
		public CollisionImpulseDelegate OnCollisionImpulse; // 0x248
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool canMoveTarget; // 0x254
		private float unpinnedTimer; // 0x258
		private float getUpTimer; // 0x25C
		private Vector3 hipsForward; // 0x260
		private Vector3 hipsUp; // 0x26C
		private float getupAnimationBlendWeight; // 0x278
		private float getupAnimationBlendWeightV; // 0x27C
		private bool getUpTargetFixed; // 0x280
		private NormalMode lastNormalMode; // 0x284
		private int collisions; // 0x288
		private bool eventsEnabled; // 0x28C
		private float lastKnockOutDistance; // 0x290
		private float knockOutDistanceSqr; // 0x294
		private bool getupDisabled; // 0x298
		private bool hasCollidedSinceGetUp; // 0x299
		private bool hasBoosted; // 0x29A
		private MuscleCollisionBroadcaster broadcaster; // 0x2A0
		private Vector3 getUpPosition; // 0x2A8
		private bool dropPropFlag; // 0x2B4
	
		// Properties
		public State state { /* [XID] */ /* 0x0000000189BAFDB0-0x0000000189BAFDF0 */ get; /* [XID] */ /* 0x0000000189BBA440-0x0000000189BBA480 */ private set; } // 0x00000001876CD7B0-0x00000001876CD810 0x00000001876CD810-0x00000001876CD880
	
		// Nested types
		[Serializable]
		public enum State // TypeDefIndex: 9873
		{
			Puppet = 0,
			Unpinned = 1,
			GetUp = 2
		}
	
		[Serializable]
		public enum NormalMode // TypeDefIndex: 9874
		{
			Active = 0,
			Unmapped = 1,
			Kinematic = 2
		}
	
		[Serializable]
		public class MasterProps // TypeDefIndex: 9875
		{
			// Fields
			public NormalMode normalMode; // 0x10
			public float mappingBlendSpeed; // 0x14
			public bool activateOnStaticCollisions; // 0x18
			public float activateOnImpulse; // 0x1C
	
			// Constructors
			public MasterProps() {} // 0x00000001876D8820-0x00000001876D8890
		}
	
		[Serializable]
		public struct MuscleProps // TypeDefIndex: 9876
		{
			// Fields
			// [Range] // 0x00000001897393E0-0x0000000189739430
			// [Tooltip] // 0x00000001897393E0-0x0000000189739430
			public float unpinParents; // 0x00
			// [Range] // 0x0000000189745750-0x00000001897457B0
			// [Tooltip] // 0x0000000189745750-0x00000001897457B0
			public float unpinChildren; // 0x04
			// [Range] // 0x0000000189751470-0x00000001897514C0
			// [Tooltip] // 0x0000000189751470-0x00000001897514C0
			public float unpinGroup; // 0x08
			// [Range] // 0x000000018975D200-0x000000018975D260
			// [Tooltip] // 0x000000018975D200-0x000000018975D260
			public float minMappingWeight; // 0x0C
			// [Range] // 0x0000000189769230-0x0000000189769290
			// [Tooltip] // 0x0000000189769230-0x0000000189769290
			public float maxMappingWeight; // 0x10
			// [Tooltip] // 0x0000000189774F80-0x0000000189774FB0
			public bool disableColliders; // 0x14
			// [Tooltip] // 0x000000018977DF50-0x000000018977DF80
			public float regainPinSpeed; // 0x18
			// [Tooltip] // 0x0000000189787060-0x0000000189787090
			public float collisionResistance; // 0x1C
			// [Tooltip] // 0x000000018978FFA0-0x000000018978FFD0
			public float knockOutDistance; // 0x20
			// [Tooltip] // 0x0000000189797770-0x00000001897977A0
			public PhysicMaterial puppetMaterial; // 0x28
			// [Tooltip] // 0x00000001897A0C50-0x00000001897A0C80
			public PhysicMaterial unpinnedMaterial; // 0x30
		}
	
		[Serializable]
		public struct MusclePropsGroup // TypeDefIndex: 9877
		{
			// Fields
			[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
			public string name; // 0x00
			// [Tooltip] // 0x00000001897B12C0-0x00000001897B12F0
			public Muscle.Group[] groups; // 0x08
			// [Tooltip] // 0x00000001897BA880-0x00000001897BA8B0
			public MuscleProps props; // 0x10
		}
	
		[Serializable]
		public struct CollisionResistanceMultiplier // TypeDefIndex: 9878
		{
			// Fields
			public LayerMask layers; // 0x00
			// [Tooltip] // 0x00000001897C3D10-0x00000001897C3D40
			public float multiplier; // 0x04
			// [Tooltip] // 0x00000001897CCFC0-0x00000001897CCFF0
			public float collisionThreshold; // 0x08
		}
	
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse); // TypeDefIndex: 9879; 0x00000001876D61F0-0x00000001876D6470
	
		// Constructors
		public BehaviourPuppet() {} // 0x00000001876CD5C0-0x00000001876CD7B0
	
		// Methods
		// [ContextMenu] // 0x0000000189B9B790-0x0000000189B9B7E0
		// [XID] // 0x0000000189B9B790-0x0000000189B9B7E0
		private void OpenUserManual() {} // 0x00000001876CB1B0-0x00000001876CB260
		// [ContextMenu] // 0x0000000189BA5D40-0x0000000189BA5D90
		// [XID] // 0x0000000189BA5D40-0x0000000189BA5D90
		private void OpenScriptReference() {} // 0x00000001876CB100-0x00000001876CB1B0
		// [XID] // 0x0000000189BC5150-0x0000000189BC5170
		public override void OnReactivate() {} // 0x00000001876CA7F0-0x00000001876CAA40
		// [XID] // 0x0000000189700A70-0x0000000189700A90
		public void Reset(Vector3 position, Quaternion rotation) {} // 0x00000001876CB260-0x00000001876CB370
		// [XID] // 0x0000000189B5A680-0x0000000189B5A6A0
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget) {} // 0x00000001876CAE80-0x00000001876CB100
		// [XID] // 0x000000018965D040-0x000000018965D060
		protected override void OnInitiate() {} // 0x00000001876C93A0-0x00000001876C9B20
		// [XID] // 0x00000001895E8430-0x00000001895E8450
		protected override void OnActivate() {} // 0x00000001876C83A0-0x00000001876C84F0
		// [XID] // 0x00000001895EFD20-0x00000001895EFD40
		public override void KillStart() {} // 0x00000001876C8180-0x00000001876C82A0
		// [XID] // 0x0000000189BC9830-0x0000000189BC9850
		public override void KillEnd() {} // 0x00000001876C80D0-0x00000001876C8180
		// [XID] // 0x0000000189BD0FF0-0x0000000189BD1010
		public override void Resurrect() {} // 0x00000001876CB370-0x00000001876CB4E0
		// [XID] // 0x00000001895ECBC0-0x00000001895ECBE0
		protected override void OnDeactivate() {} // 0x00000001876C84F0-0x00000001876C85D0
		// [XID] // 0x000000018966BCD0-0x000000018966BCF0
		protected override void OnFixedUpdate() {} // 0x00000001876C8990-0x00000001876C93A0
		// [XID] // 0x0000000189615470-0x0000000189615490
		protected override void OnLateUpdate() {} // 0x00000001876C9B20-0x00000001876C9E00
		// [XID] // 0x00000001895F8050-0x00000001895F8070
		private bool SetKinematic() => default; // 0x00000001876CB9B0-0x00000001876CBB80
		// [XID] // 0x0000000189B1AAC0-0x0000000189B1AAE0
		protected override void OnReadBehaviour() {} // 0x00000001876CAA40-0x00000001876CAE80
		// [XID] // 0x000000018962B930-0x000000018962B950
		private void BlendMuscleMapping(int muscleIndex, ref bool to) {} // 0x00000001876C62D0-0x00000001876C6610
		// [XID] // 0x000000018987FE40-0x000000018987FE60
		public override void OnMuscleAdded(Muscle m) {} // 0x00000001876C9E00-0x00000001876C9F10
		// [XID] // 0x0000000189887440-0x0000000189887460
		public override void OnMuscleRemoved(Muscle m) {} // 0x00000001876CA720-0x00000001876CA7F0
		// [XID] // 0x0000000189AE1D90-0x0000000189AE1DB0
		protected void MoveTarget(Vector3 position) {} // 0x00000001876C82A0-0x00000001876C83A0
		// [XID] // 0x0000000189649AE0-0x0000000189649B00
		protected void RotateTarget(Quaternion rotation) {} // 0x00000001876CB4E0-0x00000001876CB5D0
		// [XID] // 0x00000001896F3990-0x00000001896F39B0
		protected override void GroundTarget(LayerMask layers) {} // 0x00000001876C7C10-0x00000001876C7CD0
		// [XID] // 0x00000001897632A0-0x00000001897632C0
		private void OnDrawGizmosSelected() {} // 0x00000001876C85D0-0x00000001876C8990
		// [IDTag] // 0x000000018965FF00-0x000000018965FF40
		// [XID] // 0x000000018965FF00-0x000000018965FF40
		public void Boost(float immunity, float impulseMlp) {} // 0x00000001876C7050-0x00000001876C7180
		// [IDTag] // 0x000000018966A9B0-0x000000018966A9F0
		// [XID] // 0x000000018966A9B0-0x000000018966A9F0
		public void Boost(int muscleIndex, float immunity, float impulseMlp) {} // 0x00000001876C7180-0x00000001876C7280
		// [IDTag] // 0x0000000189675610-0x0000000189675650
		// [XID] // 0x0000000189675610-0x0000000189675650
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren) {} // 0x00000001876C6E70-0x00000001876C7050
		// [IDTag] // 0x000000018967FD70-0x000000018967FDB0
		// [XID] // 0x000000018967FD70-0x000000018967FDB0
		public void BoostImmunity(float immunity) {} // 0x00000001876C67A0-0x00000001876C68B0
		// [IDTag] // 0x000000018968A800-0x000000018968A840
		// [XID] // 0x000000018968A800-0x000000018968A840
		public void BoostImmunity(int muscleIndex, float immunity) {} // 0x00000001876C68B0-0x00000001876C6A50
		// [IDTag] // 0x0000000189695180-0x00000001896951C0
		// [XID] // 0x0000000189695180-0x00000001896951C0
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren) {} // 0x00000001876C6610-0x00000001876C67A0
		// [IDTag] // 0x000000018969F820-0x000000018969F860
		// [XID] // 0x000000018969F820-0x000000018969F860
		public void BoostImpulseMlp(float impulseMlp) {} // 0x00000001876C6A50-0x00000001876C6B50
		// [IDTag] // 0x00000001896A9C70-0x00000001896A9CB0
		// [XID] // 0x00000001896A9C70-0x00000001896A9CB0
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp) {} // 0x00000001876C6CE0-0x00000001876C6E70
		// [IDTag] // 0x00000001896B3EB0-0x00000001896B3EF0
		// [XID] // 0x00000001896B3EB0-0x00000001896B3EF0
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren) {} // 0x00000001876C6B50-0x00000001876C6CE0
		// [XID] // 0x00000001898788D0-0x00000001898788F0
		public void Unpin() {} // 0x00000001876CD4E0-0x00000001876CD5C0
		// [XID] // 0x0000000189A98110-0x0000000189A98130
		protected override void OnMuscleHitBehaviour(MuscleHit hit) {} // 0x00000001876CA480-0x00000001876CA720
		// [XID] // 0x0000000189982610-0x0000000189982630
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m) {} // 0x00000001876C9F10-0x00000001876CA480
		// [XID] // 0x00000001896D6500-0x00000001896D6520
		private float GetImpulse(MuscleCollision m, ref float layerThreshold) => default; // 0x00000001876C7710-0x00000001876C79E0
		// [XID] // 0x00000001896DBBC0-0x00000001896DBBE0
		private void UnPin(int muscleIndex, float unpin) {} // 0x00000001876CD2B0-0x00000001876CD4E0
		// [XID] // 0x0000000189728550-0x0000000189728570
		private void UnPinMuscle(int muscleIndex, float unpin) {} // 0x00000001876CCE60-0x00000001876CD2B0
		// [XID] // 0x00000001896EA7E0-0x00000001896EA800
		private bool Activate(Collision collision, float impulse) => default; // 0x00000001876C6170-0x00000001876C62D0
		// [XID] // 0x00000001896F1810-0x00000001896F1830
		public bool IsProne() => default; // 0x00000001876C7E70-0x00000001876C80D0
		// [IDTag] // 0x00000001896F9270-0x00000001896F92B0
		// [XID] // 0x00000001896F9270-0x00000001896F92B0
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren) => default; // 0x00000001876C74E0-0x00000001876C7710
		// [IDTag] // 0x0000000189703B80-0x0000000189703BC0
		// [XID] // 0x0000000189703B80-0x0000000189703BC0
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup) => default; // 0x00000001876C7280-0x00000001876C74E0
		// [XID] // 0x00000001896E5250-0x00000001896E5270
		private bool InGroup(Muscle.Group group1, Muscle.Group group2) => default; // 0x00000001876C7CD0-0x00000001876C7E70
		// [XID] // 0x0000000189715730-0x0000000189715750
		private MuscleProps GetProps(Muscle.Group group) => default; // 0x00000001876C79E0-0x00000001876C7C10
		// [XID] // 0x000000018971D310-0x000000018971D330
		public void SetState(State newState) {} // 0x00000001876CBB80-0x00000001876CC6F0
		// [IDTag] // 0x00000001897246B0-0x00000001897246F0
		// [XID] // 0x00000001897246B0-0x00000001897246F0
		public void SetColliders(bool unpinned) {} // 0x00000001876CB890-0x00000001876CB9B0
		// [IDTag] // 0x000000018972EE10-0x000000018972EE50
		// [XID] // 0x000000018972EE10-0x000000018972EE50
		private void SetColliders(Muscle m, bool unpinned) {} // 0x00000001876CB5D0-0x00000001876CB890
	}
}
