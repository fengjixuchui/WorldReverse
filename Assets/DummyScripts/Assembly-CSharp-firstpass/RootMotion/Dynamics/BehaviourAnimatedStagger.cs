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
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	// [AddComponentMenu] // 0x00000001896C2760-0x00000001896C2790
	public class BehaviourAnimatedStagger : BehaviourBase // TypeDefIndex: 9860
	{
		// Fields
		// [Header] // 0x00000001896CB480-0x00000001896CB4B0
		public LayerMask groundLayers; // 0xF8
		public float animationBlendSpeed; // 0xFC
		public float animationMag; // 0x100
		public float momentumMag; // 0x104
		public float unbalancedMuscleWeightMlp; // 0x108
		public float unbalancedMuscleDamperAdd; // 0x10C
		public bool dropProps; // 0x110
		public float maxGetUpVelocity; // 0x114
		public float minHipHeight; // 0x118
		public SubBehaviourCOM centerOfMass; // 0x120
		// [Header] // 0x00000001896D42E0-0x00000001896D4310
		public FallParams defaults; // 0x128
		public FallParamsGroup[] groupOverrides; // 0x138
		// [Header] // 0x00000001896DD0B0-0x00000001896DD0E0
		public PuppetEvent onUngrounded; // 0x140
		public PuppetEvent onFallOver; // 0x158
		public PuppetEvent onRest; // 0x170
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 moveVector; // 0x188
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool isGrounded; // 0x194
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 forward; // 0x198
	
		// Nested types
		[Serializable]
		public struct FallParams // TypeDefIndex: 9861
		{
			// Fields
			public float startPinWeightMlp; // 0x00
			public float startMuscleWeightMlp; // 0x04
			public float losePinSpeed; // 0x08
		}
	
		[Serializable]
		public struct FallParamsGroup // TypeDefIndex: 9862
		{
			// Fields
			public Muscle.Group[] groups; // 0x00
			public FallParams fallParams; // 0x08
		}
	
		// Constructors
		public BehaviourAnimatedStagger() {} // 0x00000001876C1C40-0x00000001876C1D40
	
		// Methods
		// [XID] // 0x0000000189726D00-0x0000000189726D20
		protected override void OnInitiate() {} // 0x00000001876C1A20-0x00000001876C1AE0
		// [XID] // 0x0000000189703BC0-0x0000000189703BE0
		protected override void OnActivate() {} // 0x00000001876C1970-0x00000001876C1A20
		// [XID] // 0x000000018971B180-0x000000018971B1A0
		public override void OnReactivate() {} // 0x00000001876C1AE0-0x00000001876C1B80
		[DebuggerHidden] // 0x0000000189712B70-0x0000000189712BB0
		// [XID] // 0x0000000189712B70-0x0000000189712BB0
		private IEnumerator LoseBalance() => default; // 0x00000001876C1860-0x00000001876C1970
		// [XID] // 0x000000018971D330-0x000000018971D350
		private FallParams GetFallParams(Muscle.Group group) => default; // 0x00000001876C16B0-0x00000001876C1860
	}
}
