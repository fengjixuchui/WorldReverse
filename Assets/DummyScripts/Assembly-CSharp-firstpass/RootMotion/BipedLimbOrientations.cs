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

namespace RootMotion
{
	[Serializable]
	public class BipedLimbOrientations // TypeDefIndex: 9934
	{
		// Fields
		public LimbOrientation leftArm; // 0x10
		public LimbOrientation rightArm; // 0x18
		public LimbOrientation leftLeg; // 0x20
		public LimbOrientation rightLeg; // 0x28
	
		// Properties
		public static BipedLimbOrientations UMA { /* [XID] */ /* 0x00000001898FB390-0x00000001898FB3B0 */ get => default; } // 0x0000000187337710-0x0000000187337B50 
		public static BipedLimbOrientations MaxBiped { /* [XID] */ /* 0x00000001899E8A60-0x00000001899E8A80 */ get => default; } // 0x00000001873372D0-0x0000000187337710 
	
		// Nested types
		[Serializable]
		public class LimbOrientation // TypeDefIndex: 9935
		{
			// Fields
			public Vector3 upperBoneForwardAxis; // 0x10
			public Vector3 lowerBoneForwardAxis; // 0x1C
			public Vector3 lastBoneLeftAxis; // 0x28
	
			// Constructors
			public LimbOrientation() {} // Dummy constructor
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis) {} // 0x0000000187345630-0x00000001873456E0
		}
	
		// Constructors
		public BipedLimbOrientations() {} // Dummy constructor
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg) {} // 0x0000000187337240-0x00000001873372D0
	}
}
