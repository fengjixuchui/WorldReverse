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

namespace RootMotion.Dynamics
{
	[Serializable]
	public class Muscle // TypeDefIndex: 9888
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string name; // 0x10
		public ConfigurableJoint joint; // 0x18
		public Transform target; // 0x20
		public Props props; // 0x28
		public State state; // 0x30
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] parentIndexes; // 0x68
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] childIndexes; // 0x70
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool[] childFlags; // 0x78
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] kinshipDegrees; // 0x80
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public MuscleCollisionBroadcaster broadcaster; // 0x88
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public JointBreakBroadcaster jointBreakBroadcaster; // 0x90
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 positionOffset; // 0x98
		private JointDrive slerpDrive; // 0x10C
		private float lastJointDriveRotationWeight; // 0x118
		private float lastRotationDamper; // 0x11C
		private Vector3 defaultPosition; // 0x120
		private Vector3 defaultTargetLocalPosition; // 0x12C
		private Vector3 lastMappedPosition; // 0x138
		private Quaternion defaultLocalRotation; // 0x144
		private Quaternion localRotationConvert; // 0x154
		private Quaternion toParentSpace; // 0x164
		private Quaternion toJointSpaceInverse; // 0x174
		private Quaternion toJointSpaceDefault; // 0x184
		private Quaternion targetAnimatedRotation; // 0x194
		private Quaternion defaultRotation; // 0x1A4
		private Quaternion defaultTargetLocalRotation; // 0x1B4
		private Quaternion lastMappedRotation; // 0x1C4
		private Transform targetParent; // 0x1D8
		private Transform connectedBodyTransform; // 0x1E0
		private ConfigurableJointMotion angularXMotionDefault; // 0x1E8
		private ConfigurableJointMotion angularYMotionDefault; // 0x1EC
		private ConfigurableJointMotion angularZMotionDefault; // 0x1F0
		private bool directTargetParent; // 0x1F4
		private bool initiated; // 0x1F5
		private Collider[] _colliders; // 0x1F8
		private float lastReadTime; // 0x200
		private float lastWriteTime; // 0x204
		private bool[] disabledColliders; // 0x208
	
		// Properties
		public Transform transform { /* [XID] */ /* 0x0000000189BD4250-0x0000000189BD4290 */ get; /* [XID] */ /* 0x0000000189BDEBC0-0x0000000189BDEC00 */ private set; } // 0x00000001876DEE70-0x00000001876DEED0 0x00000001876DF2A0-0x00000001876DF310
		public Rigidbody rigidbody { /* [XID] */ /* 0x00000001895EE610-0x00000001895EE650 */ get; /* [XID] */ /* 0x00000001895F8F00-0x00000001895F8F40 */ private set; } // 0x00000001876DE920-0x00000001876DE980 0x00000001876DF040-0x00000001876DF0B0
		public Transform connectedBodyTarget { /* [XID] */ /* 0x0000000189603520-0x0000000189603560 */ get; /* [XID] */ /* 0x000000018960DD10-0x000000018960DD50 */ private set; } // 0x00000001876DE3C0-0x00000001876DE420 0x00000001876DEED0-0x00000001876DEF40
		public Vector3 targetAnimatedPosition { /* [XID] */ /* 0x0000000189618140-0x0000000189618180 */ get; /* [XID] */ /* 0x0000000189622950-0x0000000189622990 */ private set; } // 0x00000001876DEA00-0x00000001876DEA80 0x00000001876DF130-0x00000001876DF1B0
		public Collider[] colliders { /* [XID] */ /* 0x0000000189B82F40-0x0000000189B82F60 */ get => default; } // 0x00000001876DE310-0x00000001876DE3C0 
		public Vector3 targetVelocity { /* [XID] */ /* 0x0000000189634C60-0x0000000189634CA0 */ get; /* [XID] */ /* 0x000000018963F0D0-0x000000018963F110 */ private set; } // 0x00000001876DEDF0-0x00000001876DEE70 0x00000001876DF220-0x00000001876DF2A0
		public Vector3 targetAngularVelocity { get; /* [XID] */ /* 0x00000001896510E0-0x0000000189651120 */ private set; } // 0x00000001876DE980-0x00000001876DEA00 0x00000001876DF0B0-0x00000001876DF130
		public Vector3 mappedVelocity { /* [XID] */ /* 0x000000018965BB30-0x000000018965BB70 */ get; /* [XID] */ /* 0x0000000189665FA0-0x0000000189665FE0 */ private set; } // 0x00000001876DE650-0x00000001876DE6D0 0x00000001876DEFC0-0x00000001876DF040
		public Vector3 mappedAngularVelocity { /* [XID] */ /* 0x0000000189670CC0-0x0000000189670D00 */ get; /* [XID] */ /* 0x000000018967B400-0x000000018967B440 */ private set; } // 0x00000001876DE5D0-0x00000001876DE650 0x00000001876DEF40-0x00000001876DEFC0
		public Quaternion targetRotationRelative { /* [XID] */ /* 0x0000000189685BF0-0x0000000189685C30 */ get; /* [XID] */ /* 0x0000000189690C00-0x0000000189690C40 */ private set; } // 0x00000001876DED80-0x00000001876DEDF0 0x00000001876DF1B0-0x00000001876DF220
		private Quaternion localRotation { /* [XID] */ /* 0x0000000189736690-0x00000001897366B0 */ get => default; } // 0x00000001876DE420-0x00000001876DE5D0 
		private Quaternion parentRotation { /* [XID] */ /* 0x000000018973E460-0x000000018973E480 */ get => default; } // 0x00000001876DE6D0-0x00000001876DE920 
		private Quaternion targetParentRotation { /* [XID] */ /* 0x0000000189745730-0x0000000189745750 */ get => default; } // 0x00000001876DEC20-0x00000001876DED80 
		private Quaternion targetLocalRotation { /* [XID] */ /* 0x000000018974D230-0x000000018974D250 */ get => default; } // 0x00000001876DEA80-0x00000001876DEC20 
	
		// Nested types
		[Serializable]
		public enum Group // TypeDefIndex: 9889
		{
			Hips = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Hand = 4,
			Leg = 5,
			Foot = 6,
			Tail = 7,
			Prop = 8
		}
	
		[Serializable]
		public class Props // TypeDefIndex: 9890
		{
			// Fields
			// [Tooltip] // 0x000000018976AC40-0x000000018976AC70
			public Group group; // 0x10
			[HideInInspector] // 0x00000001897738F0-0x0000000189773960
			// [Range] // 0x00000001897738F0-0x0000000189773960
			// [Tooltip] // 0x00000001897738F0-0x0000000189773960
			public float mappingWeight; // 0x14
			[HideInInspector] // 0x0000000189782C20-0x0000000189782C90
			// [Range] // 0x0000000189782C20-0x0000000189782C90
			// [Tooltip] // 0x0000000189782C20-0x0000000189782C90
			public float pinWeight; // 0x18
			[HideInInspector] // 0x0000000189791650-0x00000001897916C0
			// [Range] // 0x0000000189791650-0x00000001897916C0
			// [Tooltip] // 0x0000000189791650-0x00000001897916C0
			public float muscleWeight; // 0x1C
			[HideInInspector] // 0x00000001897A0BF0-0x00000001897A0C50
			// [Range] // 0x00000001897A0BF0-0x00000001897A0C50
			// [Tooltip] // 0x00000001897A0BF0-0x00000001897A0C50
			public float muscleDamper; // 0x20
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float initMappingWeight; // 0x24
			// [Tooltip] // 0x00000001897B7A70-0x00000001897B7AA0
			public bool mapPosition; // 0x28
	
			// Constructors
			public Props() {} // 0x00000001876E2780-0x00000001876E2830
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips /* Metadata: 0x00AE6C05 */) {} // 0x00000001876E2830-0x00000001876E2C30
	
			// Methods
			// [XID] // 0x00000001897C0F90-0x00000001897C0FB0
			public void Clamp() {} // 0x00000001876E2620-0x00000001876E2780
		}
	
		public struct State // TypeDefIndex: 9891
		{
			// Fields
			public float mappingWeightMlp; // 0x00
			public float pinWeightMlp; // 0x04
			public float muscleWeightMlp; // 0x08
			public float maxForceMlp; // 0x0C
			public float muscleDamperMlp; // 0x10
			public float muscleDamperAdd; // 0x14
			public float immunity; // 0x18
			public float impulseMlp; // 0x1C
			public Vector3 velocity; // 0x20
			public Vector3 angularVelocity; // 0x2C
	
			// Properties
			public static State Default { /* [XID] */ /* 0x0000000189700FA0-0x0000000189700FC0 */ get => default; } // 0x00000001876E2F20-0x00000001876E3090 
	
			// Methods
			// [XID] // 0x00000001897CFF30-0x00000001897CFF50
			public void Clamp() {} // 0x00000001876E2F10-0x00000001876E2F20
		}
	
		// Constructors
		public Muscle() {} // 0x00000001876DE160-0x00000001876DE310
	
		// Methods
		// [XID] // 0x0000000189B0C980-0x0000000189B0C9A0
		public bool IsValid(bool log) => default; // 0x00000001876DC130-0x00000001876DC3C0
		// [XID] // 0x00000001896A2980-0x00000001896A29A0
		public virtual void Clear() {} // 0x00000001876DA280-0x00000001876DA370
		// [XID] // 0x00000001896EAA40-0x00000001896EAA60
		public virtual void Initiate(Muscle[] colleagues, bool isDyanmic) {} // 0x00000001876DAB60-0x00000001876DBF30
		// [XID] // 0x000000018991D350-0x000000018991D370
		public void UpdateColliders() {} // 0x00000001876DDD30-0x00000001876DDEF0
		// [XID] // 0x00000001896B8670-0x00000001896B8690
		public void DisableColliders() {} // 0x00000001876DA370-0x00000001876DA510
		// [XID] // 0x00000001896BF7B0-0x00000001896BF7D0
		public void EnableColliders() {} // 0x00000001876DA510-0x00000001876DA680
		// [XID] // 0x00000001897263F0-0x0000000189726410
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders) {} // 0x00000001876D9660-0x00000001876D98F0
		// [XID] // 0x00000001896CE820-0x00000001896CE840
		private void AddCompoundColliders(Transform t, ref Collider[] colliders) {} // 0x00000001876D98F0-0x00000001876D9A60
		// [XID] // 0x00000001896D5B90-0x00000001896D5BB0
		public void IgnoreCollisions(Muscle m, bool ignore) {} // 0x00000001876DA8C0-0x00000001876DAB60
		// [XID] // 0x00000001896863F0-0x0000000189686410
		public void IgnoreAngularLimits(bool ignore) {} // 0x00000001876DA780-0x00000001876DA8C0
		// [XID] // 0x00000001896E4A10-0x00000001896E4A30
		public void FixTargetTransforms() {} // 0x00000001876DA680-0x00000001876DA780
		// [XID] // 0x00000001896EBF70-0x00000001896EBF90
		public void Reset() {} // 0x00000001876DD620-0x00000001876DD960
		// [XID] // 0x00000001896F3660-0x00000001896F3680
		public void MoveToTarget() {} // 0x00000001876DC8F0-0x00000001876DCAB0
		// [XID] // 0x00000001896FACD0-0x00000001896FACF0
		public void Read() {} // 0x00000001876DD320-0x00000001876DD620
		// [XID] // 0x00000001899B15A0-0x00000001899B15C0
		public void ClearVelocities() {} // 0x00000001876D9F60-0x00000001876DA280
		// [XID] // 0x0000000189709C00-0x0000000189709C20
		public void UpdateAnchor(bool supportTranslationAnimation) {} // 0x00000001876DD960-0x00000001876DDD30
		// [XID] // 0x00000001899E5C70-0x00000001899E5C90
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged) {} // 0x00000001876DDEF0-0x00000001876DE160
		// [XID] // 0x0000000189718A60-0x0000000189718A80
		public void Map(float mappingWeightMaster) {} // 0x00000001876DC550-0x00000001876DC8F0
		// [XID] // 0x00000001899F4AC0-0x00000001899F4AE0
		public void CalculateMappedVelocity() {} // 0x00000001876D9C40-0x00000001876D9F60
		// [XID] // 0x0000000189742FA0-0x0000000189742FC0
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff) {} // 0x00000001876DCD70-0x00000001876DD320
		// [XID] // 0x0000000189AB1740-0x0000000189AB1760
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper) {} // 0x00000001876DCAB0-0x00000001876DCD70
		// [XID] // 0x0000000189754850-0x0000000189754870
		private Quaternion LocalToJointSpace(Quaternion localRotation) => default; // 0x00000001876DC3C0-0x00000001876DC550
		// [XID] // 0x0000000189702DF0-0x0000000189702E10
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point) => default; // 0x00000001876DBF30-0x00000001876DC130
		// [XID] // 0x0000000189ABEB20-0x0000000189ABEB40
		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass) => default; // 0x00000001876D9A60-0x00000001876D9C40
	}
}
