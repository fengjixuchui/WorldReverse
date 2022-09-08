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
	// [AddComponentMenu] // 0x0000000189980AB0-0x0000000189980B10
	// [HelpURL] // 0x0000000189980AB0-0x0000000189980B10
	public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 9850
	{
		// Fields
		// [Range] // 0x0000000189994A40-0x0000000189994A60
		public float twistLimit; // 0x50
		// [Range] // 0x0000000189994A40-0x0000000189994A60
		public float twistLimitWorld; // 0x54
		// [Range] // 0x0000000189B2BB80-0x0000000189B2BBA0
		public int smoothIterations; // 0x58
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		public LimitPoint[] points; // 0x60
		[HideInInspector] // 0x00000001896ACE20-0x00000001896ACE50
		[SerializeField] // 0x00000001896ACE20-0x00000001896ACE50
		public Vector3[] P; // 0x68
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		public ReachCone[] reachCones; // 0x70
	
		// Nested types
		[Serializable]
		public class ReachCone // TypeDefIndex: 9851
		{
			// Fields
			public Vector3[] tetrahedron; // 0x10
			public float volume; // 0x18
			public Vector3 S; // 0x1C
			public Vector3 B; // 0x28
	
			// Properties
			public Vector3 o { /* [XID] */ /* 0x0000000189A3EBD0-0x0000000189A3EBF0 */ get => default; } // 0x00000001868DAE70-0x00000001868DAF70 
			public Vector3 a { /* [XID] */ /* 0x00000001898F90D0-0x00000001898F90F0 */ get => default; } // 0x00000001868DAAC0-0x00000001868DABC0 
			public Vector3 b { /* [XID] */ /* 0x0000000189AFFFD0-0x0000000189AFFFF0 */ get => default; } // 0x00000001868DABC0-0x00000001868DACC0 
			public Vector3 c { /* [XID] */ /* 0x00000001897D1730-0x00000001897D1750 */ get => default; } // 0x00000001868DACC0-0x00000001868DADC0 
			public bool isValid { /* [XID] */ /* 0x0000000189A4C900-0x0000000189A4C920 */ get => default; } // 0x00000001868DADC0-0x00000001868DAE70 
	
			// Constructors
			public ReachCone() {} // Dummy constructor
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c) {} // 0x00000001868DA8D0-0x00000001868DAAC0
	
			// Methods
			// [XID] // 0x0000000189A643B0-0x0000000189A643D0
			public void Calculate() {} // 0x00000001868DA630-0x00000001868DA8D0
		}
	
		[Serializable]
		public class LimitPoint // TypeDefIndex: 9852
		{
			// Fields
			public Vector3 point; // 0x10
			public float tangentWeight; // 0x1C
	
			// Constructors
			public LimitPoint() {} // 0x00000001868D6A10-0x00000001868D6AC0
		}
	
		// Constructors
		public RotationLimitPolygonal() {} // 0x00000001868DEC60-0x00000001868DED00
	
		// Methods
		// [ContextMenu] // 0x00000001899C3770-0x00000001899C37C0
		// [XID] // 0x00000001899C3770-0x00000001899C37C0
		private void OpenUserManual() {} // 0x00000001868DD500-0x00000001868DD5B0
		// [ContextMenu] // 0x00000001899CDBE0-0x00000001899CDC30
		// [XID] // 0x00000001899CDBE0-0x00000001899CDC30
		private void OpenScriptReference() {} // 0x00000001868DD450-0x00000001868DD500
		// [ContextMenu] // 0x00000001899D8130-0x00000001899D8180
		// [XID] // 0x00000001899D8130-0x00000001899D8180
		private void SupportGroup() {} // 0x00000001868DE8F0-0x00000001868DE9A0
		// [ContextMenu] // 0x00000001899E2840-0x00000001899E2890
		// [XID] // 0x00000001899E2840-0x00000001899E2890
		private void ASThread() {} // 0x00000001868DC2B0-0x00000001868DC360
		// [XID] // 0x0000000189AD5EC0-0x0000000189AD5EE0
		public void SetLimitPoints(LimitPoint[] points) {} // 0x00000001868DDD30-0x00000001868DDE10
		// [XID] // 0x00000001899C6F70-0x00000001899C6F90
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x00000001868DCD60-0x00000001868DD010
		// [XID] // 0x00000001899FC220-0x00000001899FC240
		private void Start() {} // 0x00000001868DE5C0-0x00000001868DE8F0
		// [XID] // 0x0000000189A03740-0x0000000189A03760
		public void ResetToDefault() {} // 0x00000001868DD800-0x00000001868DDD30
		// [XID] // 0x0000000189A0AC90-0x0000000189A0ACB0
		public void BuildReachCones() {} // 0x00000001868DC360-0x00000001868DC930
		// [XID] // 0x0000000189A12530-0x0000000189A12550
		private Vector3[] SmoothPoints() => default; // 0x00000001868DDE10-0x00000001868DE5C0
		// [XID] // 0x0000000189A19920-0x0000000189A19940
		private float GetScalar(int k) => default; // 0x00000001868DCC50-0x00000001868DCD60
		// [XID] // 0x0000000189A20F40-0x0000000189A20F60
		private Vector3 PointToTangentPlane(Vector3 p, float r) => default; // 0x00000001868DD5B0-0x00000001868DD800
		// [XID] // 0x0000000189A28260-0x0000000189A28280
		private Vector3 TangentPointToSphere(Vector3 q, float r) => default; // 0x00000001868DE9A0-0x00000001868DEC60
		// [XID] // 0x0000000189A93450-0x0000000189A93470
		private Quaternion LimitSwing(Quaternion rotation) => default; // 0x00000001868DD010-0x00000001868DD450
		// [XID] // 0x0000000189B0ED30-0x0000000189B0ED50
		private int GetReachCone(Vector3 L) => default; // 0x00000001868DC930-0x00000001868DCC50
	}
}
