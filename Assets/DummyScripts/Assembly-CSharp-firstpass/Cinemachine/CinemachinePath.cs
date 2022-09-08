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

namespace Cinemachine
{
	// [AddComponentMenu] // 0x0000000189B0CD50-0x0000000189B0CDB0
	// [DocumentationSorting] // 0x0000000189B0CD50-0x0000000189B0CDB0
	[SaveDuringPlay] // 0x0000000189B0CD50-0x0000000189B0CDB0
	public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 6778
	{
		// Fields
		// [Tooltip] // 0x0000000189BA8A00-0x0000000189BA8A30
		public bool m_Looped; // 0x48
		// [Tooltip] // 0x0000000189BAFF40-0x0000000189BAFF70
		public Waypoint[] m_Waypoints; // 0x50
	
		// Properties
		public override float MinPos { /* [XID] */ /* 0x0000000189B8F8A0-0x0000000189B8F8C0 */ get => default; } // 0x0000000186CC7FB0-0x0000000186CC8060 
		public override float MaxPos { /* [XID] */ /* 0x0000000189B34960-0x0000000189B34980 */ get => default; } // 0x0000000186CC7ED0-0x0000000186CC7FB0 
		public override bool Looped { /* [XID] */ /* 0x000000018960DC50-0x000000018960DC70 */ get => default; } // 0x0000000186CC7E30-0x0000000186CC7ED0 
		public override int DistanceCacheSampleStepsPerSegment { /* [XID] */ /* 0x00000001896153D0-0x00000001896153F0 */ get => default; } // 0x0000000186CC7D90-0x0000000186CC7E30 
	
		// Nested types
		[Serializable]
		// [DocumentationSorting] // 0x0000000189B70B40-0x0000000189B70B60
		public struct Waypoint // TypeDefIndex: 6779
		{
			// Fields
			// [Tooltip] // 0x0000000189B78120-0x0000000189B78150
			public Vector3 position; // 0x00
			// [Tooltip] // 0x0000000189B80CB0-0x0000000189B80CE0
			public Vector3 tangent; // 0x0C
			// [Tooltip] // 0x0000000189625A60-0x0000000189625A90
			public float roll; // 0x18
		}
	
		// Constructors
		public CinemachinePath() {} // 0x0000000186CC7D00-0x0000000186CC7D90
	
		// Methods
		// [XID] // 0x000000018961CBE0-0x000000018961CC00
		private float GetBoundingIndices(float pos, out int indexA, out int indexB) {
			indexA = default;
			indexB = default;
			return default;
		} // 0x0000000186CC7A30-0x0000000186CC7C50
		// [XID] // 0x0000000189624060-0x0000000189624080
		public override Vector3 EvaluatePosition(float pos) => default; // 0x0000000186CC71E0-0x0000000186CC75C0
		// [XID] // 0x0000000189B5A5E0-0x0000000189B5A600
		public override Vector3 EvaluateTangent(float pos) => default; // 0x0000000186CC75C0-0x0000000186CC7A30
		// [XID] // 0x0000000189B61AE0-0x0000000189B61B00
		public override Quaternion EvaluateOrientation(float pos) => default; // 0x0000000186CC6DC0-0x0000000186CC71E0
		// [XID] // 0x0000000189642210-0x0000000189642230
		private void OnValidate() {} // 0x0000000186CC7C50-0x0000000186CC7D00
	}
}
