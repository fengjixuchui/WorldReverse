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
	// [AddComponentMenu] // 0x0000000189B99DF0-0x0000000189B99E60
	// [DocumentationSorting] // 0x0000000189B99DF0-0x0000000189B99E60
	[SaveDuringPlay] // 0x0000000189B99DF0-0x0000000189B99E60
	public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 6781
	{
		// Fields
		// [Tooltip] // 0x0000000189BA8A00-0x0000000189BA8A30
		public bool m_Looped; // 0x48
		// [Tooltip] // 0x0000000189BAFF40-0x0000000189BAFF70
		public Waypoint[] m_Waypoints; // 0x50
		private Waypoint[] m_ControlPoints1; // 0x58
		private Waypoint[] m_ControlPoints2; // 0x60
		private bool m_IsLoopedCache; // 0x68
	
		// Properties
		public override float MinPos { /* [XID] */ /* 0x0000000189649A20-0x0000000189649A40 */ get => default; } // 0x0000000186CC9CC0-0x0000000186CC9D70 
		public override float MaxPos { /* [XID] */ /* 0x00000001899917D0-0x00000001899917F0 */ get => default; } // 0x0000000186CC9BE0-0x0000000186CC9CC0 
		public override bool Looped { /* [XID] */ /* 0x0000000189BC68A0-0x0000000189BC68C0 */ get => default; } // 0x0000000186CC9B40-0x0000000186CC9BE0 
		public override int DistanceCacheSampleStepsPerSegment { /* [XID] */ /* 0x0000000189BCE4E0-0x0000000189BCE500 */ get => default; } // 0x0000000186CC9AA0-0x0000000186CC9B40 
	
		// Nested types
		[Serializable]
		// [DocumentationSorting] // 0x0000000189616AB0-0x0000000189616AD0
		public struct Waypoint // TypeDefIndex: 6782
		{
			// Fields
			// [Tooltip] // 0x0000000189B78120-0x0000000189B78150
			public Vector3 position; // 0x00
			// [Tooltip] // 0x0000000189625A60-0x0000000189625A90
			public float roll; // 0x0C
	
			// Properties
			internal Vector4 AsVector4 { /* [XID] */ /* 0x000000018962D240-0x000000018962D260 */ get => default; } // 0x0000000186CD8870-0x0000000186CD88A0 
	
			// Methods
			// [XID] // 0x0000000189634DC0-0x0000000189634DE0
			internal static Waypoint FromVector4(Vector4 v) => default; // 0x0000000186CD85F0-0x0000000186CD8870
		}
	
		// Constructors
		public CinemachineSmoothPath() {} // 0x0000000186CC9A10-0x0000000186CC9AA0
	
		// Methods
		// [XID] // 0x0000000189BD5890-0x0000000189BD58B0
		private void OnValidate() {} // 0x0000000186CC9540-0x0000000186CC95F0
		// [XID] // 0x0000000189BDD400-0x0000000189BDD420
		public override void InvalidateDistanceCache() {} // 0x0000000186CC9490-0x0000000186CC9540
		// [XID] // 0x00000001895E9DD0-0x00000001895E9DF0
		private void UpdateControlPoints() {} // 0x0000000186CC9650-0x0000000186CC9A10
		// [XID] // 0x0000000189658850-0x0000000189658870
		private float GetBoundingIndices(float pos, out int indexA, out int indexB) {
			indexA = default;
			indexB = default;
			return default;
		} // 0x0000000186CC92F0-0x0000000186CC9490
		// [XID] // 0x000000018965FE60-0x000000018965FE80
		public override Vector3 EvaluatePosition(float pos) => default; // 0x0000000186CC8BE0-0x0000000186CC8F30
		// [XID] // 0x0000000189667980-0x00000001896679A0
		public Vector3 EvaluatePositionOrigin(float pos) => default; // 0x0000000186CC8820-0x0000000186CC8BE0
		// [XID] // 0x000000018966F220-0x000000018966F240
		public override Vector3 EvaluateTangent(float pos) => default; // 0x0000000186CC8F30-0x0000000186CC92F0
		// [XID] // 0x00000001899D3A80-0x00000001899D3AA0
		public override Quaternion EvaluateOrientation(float pos) => default; // 0x0000000186CC83E0-0x0000000186CC8820
	}
}
