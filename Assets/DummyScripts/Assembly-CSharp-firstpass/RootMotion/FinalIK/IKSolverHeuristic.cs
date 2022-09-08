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

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverHeuristic : IKSolver // TypeDefIndex: 9846
	{
		// Fields
		public Transform target; // 0x60
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 fwdAxialFix; // 0x68
		public float tolerance; // 0x74
		public int maxIterations; // 0x78
		public float deltaRotationSpeed; // 0x7C
		public AnimationCurve weightStartCurve; // 0x80
		public AnimationCurve weightEndCurve; // 0x88
		public bool useRotationLimits; // 0x90
		public bool XY; // 0x91
		public Bone[] bones; // 0x98
		protected Vector3 lastLocalDirection; // 0xA0
		protected float chainLength; // 0xAC
	
		// Properties
		protected virtual int minBones { /* [XID] */ /* 0x00000001897FE710-0x00000001897FE730 */ get => default; } // 0x00000001868D16B0-0x00000001868D1750 
		protected virtual bool boneLengthCanBeZero { /* [XID] */ /* 0x0000000189805E10-0x0000000189805E30 */ get => default; } // 0x00000001868D1380-0x00000001868D1420 
		protected virtual bool allowCommonParent { /* [XID] */ /* 0x0000000189A9B060-0x0000000189A9B080 */ get => default; } // 0x00000001868D12E0-0x00000001868D1380 
		protected virtual Vector3 localDirection { /* [XID] */ /* 0x0000000189A92C40-0x0000000189A92C60 */ get => default; } // 0x00000001868D1420-0x00000001868D16B0 
		protected float positionOffset { /* [XID] */ /* 0x0000000189A816D0-0x0000000189A816F0 */ get => default; } // 0x00000001868D1750-0x00000001868D18C0 
	
		// Constructors
		public IKSolverHeuristic() {} // 0x00000001868D1230-0x00000001868D12E0
	
		// Methods
		// [XID] // 0x00000001896931E0-0x0000000189693200
		public bool SetChain(Transform[] hierarchy, Transform root) => default; // 0x00000001868D0A60-0x00000001868D0CD0
		// [XID] // 0x00000001897D1400-0x00000001897D1420
		public void AddBone(Transform bone) {} // 0x00000001868CEF60-0x00000001868CF180
		// [XID] // 0x0000000189BC45C0-0x0000000189BC45E0
		public override void StoreDefaultLocalState() {} // 0x00000001868D1120-0x00000001868D1230
		// [XID] // 0x00000001897E0680-0x00000001897E06A0
		public override void FixTransforms() {} // 0x00000001868CF180-0x00000001868CF2E0
		// [XID] // 0x0000000189BD3550-0x0000000189BD3570
		public override bool IsValid(ref string message) => default; // 0x00000001868D03D0-0x00000001868D0920
		// [XID] // 0x00000001897EFA50-0x00000001897EFA70
		public override Point[] GetPoints() => default; // 0x00000001868CF480-0x00000001868CF530
		// [XID] // 0x0000000189A03F20-0x0000000189A03F40
		public override Point GetPoint(Transform transform) => default; // 0x00000001868CF2E0-0x00000001868CF480
		// [XID] // 0x0000000189814C10-0x0000000189814C30
		protected override void OnInitiate() {} // 0x00000001868D0920-0x00000001868D09C0
		// [XID] // 0x0000000189AB8AE0-0x0000000189AB8B00
		protected override void OnUpdate() {} // 0x00000001868D09C0-0x00000001868D0A60
		// [XID] // 0x0000000189823C60-0x0000000189823C80
		protected void InitiateBones() {} // 0x00000001868CFAA0-0x00000001868D03D0
		// [XID] // 0x00000001899FC9B0-0x00000001899FC9D0
		protected Vector3 GetSingularityOffset() => default; // 0x00000001868CF530-0x00000001868CFAA0
		// [XID] // 0x0000000189841580-0x00000001898415A0
		private bool SingularityDetected() => default; // 0x00000001868D0CD0-0x00000001868D1120
	}
}
