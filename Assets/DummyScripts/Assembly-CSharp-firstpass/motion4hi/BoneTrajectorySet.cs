/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace motion4hi
{
	public class BoneTrajectorySet // TypeDefIndex: 9400
	{
		// Fields
		public float _recordLength; // 0x10
		public Dictionary<BoneKey, List<TrajectoryPoint>> _queueDict; // 0x18
		public static HumanBodyBones[] _humanKeyBones; // 0x00
	
		// Nested types
		public struct BoneKey // TypeDefIndex: 9401
		{
			// Fields
			public string name; // 0x00
			public HumanBodyBones humanBone; // 0x08
		}
	
		public class BoneKeyComparer : IEqualityComparer<BoneKey> // TypeDefIndex: 9402
		{
			// Constructors
			public BoneKeyComparer() {} // 0x00000001853C6460-0x00000001853C64C0
	
			// Methods
			// [XID] // 0x0000000189669330-0x0000000189669350
			public bool Equals(BoneKey x, BoneKey y) => default; // 0x00000001853C6260-0x00000001853C6390
			// [XID] // 0x0000000189670E30-0x0000000189670E50
			public int GetHashCode(BoneKey obj) => default; // 0x00000001853C6390-0x00000001853C6460
		}
	
		// Constructors
		public BoneTrajectorySet() {} // 0x00000001853C6FA0-0x00000001853C7090
		static BoneTrajectorySet() {} // 0x00000001853C6F00-0x00000001853C6FA0
	
		// Methods
		// [XID] // 0x000000018965A050-0x000000018965A070
		public void RecordHumanoid(Animator animator) {} // 0x00000001853C64C0-0x00000001853C69E0
		// [XID] // 0x00000001899CE430-0x00000001899CE450
		public void Visualize() {} // 0x00000001853C69E0-0x00000001853C6F00
	}
}
