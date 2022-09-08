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
	[CreateAssetMenu] // 0x0000000189B8C810-0x0000000189B8C870
	public class PuppetMasterHumanoidConfig : ScriptableObject // TypeDefIndex: 9913
	{
		// Fields
		// [LargeHeader] // 0x0000000189B96EA0-0x0000000189B96ED0
		public PuppetMaster.State state; // 0x18
		public PuppetMaster.StateSettings stateSettings; // 0x1C
		public PuppetMaster.Mode mode; // 0x30
		public float blendTime; // 0x34
		public bool fixTargetTransforms; // 0x38
		public int solverIterationCount; // 0x3C
		public bool visualizeTargetPose; // 0x40
		// [LargeHeader] // 0x0000000189B9E310-0x0000000189B9E360
		// [Range] // 0x0000000189B9E310-0x0000000189B9E360
		public float mappingWeight; // 0x44
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float pinWeight; // 0x48
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float muscleWeight; // 0x4C
		// [LargeHeader] // 0x0000000189BB7450-0x0000000189BB7480
		public float muscleSpring; // 0x50
		public float muscleDamper; // 0x54
		// [Range] // 0x0000000189BBEB50-0x0000000189BBEB70
		public float pinPow; // 0x58
		// [Range] // 0x0000000189BC66F0-0x0000000189BC6710
		public float pinDistanceFalloff; // 0x5C
		public bool updateJointAnchors; // 0x60
		public bool supportTranslationAnimation; // 0x61
		public bool angularLimits; // 0x62
		public bool internalCollisions; // 0x63
		// [LargeHeader] // 0x0000000189BCE410-0x0000000189BCE440
		public HumanoidMuscle[] muscles; // 0x68
	
		// Nested types
		[Serializable]
		public class HumanoidMuscle // TypeDefIndex: 9914
		{
			// Fields
			[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
			[SerializeField] // 0x00000001898EE050-0x00000001898EE080
			public string name; // 0x10
			public HumanBodyBones bone; // 0x18
			public Muscle.Props props; // 0x20
	
			// Constructors
			public HumanoidMuscle() {} // 0x000000018777D390-0x000000018777D490
		}
	
		// Constructors
		public PuppetMasterHumanoidConfig() {} // 0x000000018777FF10-0x0000000187780000
	
		// Methods
		// [XID] // 0x000000018980D500-0x000000018980D520
		public void ApplyTo(PuppetMaster p) {} // 0x000000018777F8D0-0x000000018777FD40
		// [XID] // 0x0000000189BDD2F0-0x0000000189BDD310
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster) => default; // 0x000000018777FD40-0x000000018777FF10
	}
}
