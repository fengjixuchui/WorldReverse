/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.FinalIK
{
	[Serializable]
	public abstract class IKSolver // TypeDefIndex: 9839
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 IKPosition; // 0x10
		// [Range] // 0x0000000189676CF0-0x0000000189676D50
		// [Tooltip] // 0x0000000189676CF0-0x0000000189676D50
		public float IKPositionWeight; // 0x1C
		// [InspectorName] // 0x0000000189682C40-0x0000000189682C70
		public bool logInfo; // 0x20
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float useWeightForLimitSwing; // 0x24
		public UpdateDelegate OnPreInitiate; // 0x30
		public UpdateDelegate OnPostInitiate; // 0x38
		public UpdateDelegate OnPreUpdate; // 0x40
		public UpdateDelegate OnPostUpdate; // 0x48
		protected bool firstInitiation; // 0x50
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		protected Transform root; // 0x58
	
		// Properties
		public bool initiated { /* [XID] */ /* 0x00000001896E32C0-0x00000001896E3300 */ get; /* [XID] */ /* 0x00000001896ED5C0-0x00000001896ED600 */ private set; } // 0x00000001868D2C80-0x00000001868D2CE0 0x00000001868D2CE0-0x00000001868D2D40
	
		// Nested types
		[Serializable]
		public class Point // TypeDefIndex: 9840
		{
			// Fields
			public Transform transform; // 0x10
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float weight; // 0x18
			public Vector3 solverPosition; // 0x1C
			public Quaternion solverRotation; // 0x28
			public Vector3 defaultLocalPosition; // 0x38
			public Quaternion defaultLocalRotation; // 0x44
	
			// Constructors
			public Point() {} // 0x00000001868D8BB0-0x00000001868D8C50
	
			// Methods
			// [XID] // 0x000000018971D350-0x000000018971D370
			public void StoreDefaultLocalState() {} // 0x00000001868D8760-0x00000001868D8850
			// [XID] // 0x00000001897246F0-0x0000000189724710
			public void FixTransform() {} // 0x00000001868D8570-0x00000001868D8760
			// [XID] // 0x000000018972BEA0-0x000000018972BEC0
			public void UpdateSolverPosition() {} // 0x00000001868D8A00-0x00000001868D8AC0
			// [XID] // 0x00000001897334E0-0x0000000189733500
			public void UpdateSolverLocalPosition() {} // 0x00000001868D8850-0x00000001868D8910
			// [XID] // 0x000000018973AD50-0x000000018973AD70
			public void UpdateSolverState() {} // 0x00000001868D8AC0-0x00000001868D8BB0
			// [XID] // 0x00000001897424C0-0x00000001897424E0
			public void UpdateSolverLocalState() {} // 0x00000001868D8910-0x00000001868D8A00
		}
	
		[Serializable]
		public class Bone : Point // TypeDefIndex: 9841
		{
			// Fields
			public float length; // 0x58
			public float sqrMag; // 0x5C
			public Vector3 axis; // 0x60
			private RotationLimit _rotationLimit; // 0x70
			private bool isLimited; // 0x78
	
			// Properties
			public RotationLimit rotationLimit { /* [XID] */ /* 0x0000000189951980-0x00000001899519A0 */ get => default; /* [XID] */ /* 0x00000001897514C0-0x00000001897514E0 */ set {} } // 0x00000001868C46E0-0x00000001868C4830 0x00000001868C4830-0x00000001868C4910
	
			// Constructors
			public Bone() {} // 0x00000001868C4530-0x00000001868C4600
			public Bone(Transform transform) {} // 0x00000001868C4600-0x00000001868C46E0
			public Bone(Transform transform, float weight) {} // 0x00000001868C4440-0x00000001868C4530
	
			// Methods
			// [XID] // 0x0000000189998390-0x00000001899983B0
			public void Swing(Vector3 swingTarget, float weight = 1f /* Metadata: 0x00AE6B98 */) {} // 0x00000001868C40B0-0x00000001868C4440
			// [XID] // 0x0000000189760510-0x0000000189760530
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x00AE6B9C */) {} // 0x00000001868C3960-0x00000001868C3DA0
			// [XID] // 0x000000018983A9A0-0x000000018983A9C0
			public void Swing2D(Vector3 swingTarget, float weight = 1f /* Metadata: 0x00AE6BA0 */) {} // 0x00000001868C3DA0-0x00000001868C40B0
			// [XID] // 0x000000018975CD70-0x000000018975CD90
			public void SetToSolverPosition() {} // 0x00000001868C3890-0x00000001868C3960
		}
	
		[Serializable]
		public class Node : Point // TypeDefIndex: 9842
		{
			// Fields
			public float length; // 0x58
			public float effectorPositionWeight; // 0x5C
			public float effectorRotationWeight; // 0x60
			public Vector3 offset; // 0x64
	
			// Constructors
			public Node() {} // 0x00000001868D6FB0-0x00000001868D70F0
			public Node(Transform transform) {} // 0x00000001868D6EB0-0x00000001868D6F20
			public Node(Transform transform, float weight) {} // 0x00000001868D6F20-0x00000001868D6FB0
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 9843; 0x00000001868E3A90-0x00000001868E3BF0
	
		public delegate void IterationDelegate(int i); // TypeDefIndex: 9844; 0x00000001868D5B90-0x00000001868D5D20
	
		// Constructors
		protected IKSolver() {} // 0x00000001868D2C00-0x00000001868D2C80
	
		// Methods
		// [XID] // 0x0000000189BB7EA0-0x0000000189BB7EC0
		public bool IsValid() => default; // 0x00000001868D2040-0x00000001868D2140
		public abstract bool IsValid(ref string message);
		// [XID] // 0x00000001896AF6A0-0x00000001896AF6C0
		public void Initiate(Transform root) {} // 0x00000001868D1DF0-0x00000001868D2040
		// [XID] // 0x00000001896B6E90-0x00000001896B6EB0
		public void Update() {} // 0x00000001868D2AD0-0x00000001868D2C00
		// [XID] // 0x00000001896BDFE0-0x00000001896BE000
		public virtual Vector3 GetIKPosition() => default; // 0x00000001868D1B30-0x00000001868D1C10
		// [XID] // 0x00000001896C58D0-0x00000001896C58F0
		public void SetIKPosition(Vector3 position) {} // 0x00000001868D2A00-0x00000001868D2AD0
		// [XID] // 0x000000018997E120-0x000000018997E140
		public float GetIKPositionWeight() => default; // 0x00000001868D1A80-0x00000001868D1B30
		// [XID] // 0x000000018963D0B0-0x000000018963D0D0
		public void SetIKPositionWeight(float weight) {} // 0x00000001868D2910-0x00000001868D2A00
		// [XID] // 0x0000000189A93590-0x0000000189A935B0
		public Transform GetRoot() => default; // 0x00000001868D1C10-0x00000001868D1CB0
		public abstract Point[] GetPoints();
		public abstract Point GetPoint(Transform transform);
		public abstract void FixTransforms();
		public abstract void StoreDefaultLocalState();
		protected abstract void OnInitiate();
		protected abstract void OnUpdate();
		// [XID] // 0x00000001896F7BF0-0x00000001896F7C10
		protected void LogWarning(string message) {} // 0x00000001868D2140-0x00000001868D2200
		// [XID] // 0x00000001896FF650-0x00000001896FF670
		public static Transform ContainsDuplicateBone(Bone[] bones) => default; // 0x00000001868D18C0-0x00000001868D1A80
		// [XID] // 0x0000000189AFB900-0x0000000189AFB920
		public static bool HierarchyIsValid(Bone[] bones) => default; // 0x00000001868D1CB0-0x00000001868D1DF0
		// [XID] // 0x000000018970E2F0-0x000000018970E310
		protected static float PreSolveBones(ref Bone[] bones) => default; // 0x00000001868D2200-0x00000001868D2910
	}
}
