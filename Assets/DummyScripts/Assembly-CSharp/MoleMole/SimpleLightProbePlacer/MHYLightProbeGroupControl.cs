/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.SimpleLightProbePlacer
{
	// [AddComponentMenu] // 0x00000001897961D0-0x0000000189796250
	// [RequireComponent] // 0x00000001897961D0-0x0000000189796250
	public class MHYLightProbeGroupControl : MonoBehaviour // TypeDefIndex: 31716
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_mergeDistance; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_usePointLights; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_pointLightRange; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_removeIfInCollider; // 0x24
		private int m_mergedProbes; // 0x28
		private int m_removedInCollider; // 0x2C
		private LightProbeGroup m_lightProbeGroup; // 0x30
	
		// Properties
		public float MergeDistance { /* [XID] */ /* 0x00000001897DC040-0x00000001897DC060 */ get => default; /* [XID] */ /* 0x00000001897E3870-0x00000001897E3890 */ set {} } // 0x0000000184EDF9E0-0x0000000184EDFA90 0x0000000184EDFDC0-0x0000000184EDFE70
		public int MergedProbes { /* [XID] */ /* 0x00000001897EB5C0-0x00000001897EB5E0 */ get => default; } // 0x0000000184EDFA90-0x0000000184EDFB30 
		public bool UsePointLights { /* [XID] */ /* 0x00000001897F2F00-0x00000001897F2F20 */ get => default; /* [XID] */ /* 0x00000001897FA790-0x00000001897FA7B0 */ set {} } // 0x0000000184EDFD20-0x0000000184EDFDC0 0x0000000184EDFFD0-0x0000000184EE0080
		public float PointLightRange { /* [XID] */ /* 0x0000000189801D90-0x0000000189801DB0 */ get => default; /* [XID] */ /* 0x00000001898091E0-0x0000000189809200 */ set {} } // 0x0000000184EDFB30-0x0000000184EDFBE0 0x0000000184EDFE70-0x0000000184EDFF20
		public bool RemoveIfInCollider { /* [XID] */ /* 0x0000000189810AE0-0x0000000189810B00 */ get => default; /* [XID] */ /* 0x0000000189818550-0x0000000189818570 */ set {} } // 0x0000000184EDFBE0-0x0000000184EDFC80 0x0000000184EDFF20-0x0000000184EDFFD0
		public int RemovedProbesInCollider { /* [XID] */ /* 0x000000018981FC70-0x000000018981FC90 */ get => default; } // 0x0000000184EDFC80-0x0000000184EDFD20 
		public LightProbeGroup LightProbeGroup { /* [XID] */ /* 0x0000000189827380-0x00000001898273A0 */ get => default; } // 0x0000000184EDF8E0-0x0000000184EDF9E0 
	
		// Constructors
		public MHYLightProbeGroupControl() {} // 0x0000000184EDF860-0x0000000184EDF8E0
	
		// Methods
		// [XID] // 0x000000018982E5A0-0x000000018982E5C0
		public void DeleteAll() {} // 0x0000000184EDE470-0x0000000184EDE540
		// [XID] // 0x0000000189835F10-0x0000000189835F30
		public void Create() {} // 0x0000000184EDE350-0x0000000184EDE470
		// [XID] // 0x000000018983D410-0x000000018983D430
		public void Merge() {} // 0x0000000184EDF050-0x0000000184EDF1E0
		// [XID] // 0x0000000189844C70-0x0000000189844C90
		private void ApplyPositions(List<Vector3> positions) {} // 0x0000000184EDDA00-0x0000000184EDDB60
		// [XID] // 0x000000018984C050-0x000000018984C070
		public static void UpdateTetrahedraOnProbes() {} // 0x0000000184EDF7D0-0x0000000184EDF860
		// [XID] // 0x0000000189853150-0x0000000189853170
		private static List<Vector3> CreatePositions() => default; // 0x0000000184EDE1C0-0x0000000184EDE350
		// [XID] // 0x000000018985AC80-0x000000018985ACA0
		private static List<Vector3> CreateAroundPointLights(float range) => default; // 0x0000000184EDDB60-0x0000000184EDDDB0
		// [XID] // 0x0000000189862110-0x0000000189862130
		private static List<Vector3> MergeClosestPositions(List<Vector3> positions, float distance, out int mergedCount) {
			mergedCount = default;
			return default;
		} // 0x0000000184EDE8F0-0x0000000184EDF050
		// [XID] // 0x00000001898695F0-0x0000000189869610
		private static List<Vector3> RemoveProbesInCollider(List<Vector3> positions, bool isRemove, out int removeNum) {
			removeNum = default;
			return default;
		} // 0x0000000184EDF1E0-0x0000000184EDF460
		// [XID] // 0x0000000189870830-0x0000000189870850
		public static List<Vector3> CreatePositionsAround(Transform transform, float range) => default; // 0x0000000184EDDDB0-0x0000000184EDE1C0
		// [XID] // 0x00000001898782C0-0x00000001898782E0
		private static bool IsInCollider(Collider collider, Vector3 pos) => default; // 0x0000000184EDE540-0x0000000184EDE8F0
	}
}
