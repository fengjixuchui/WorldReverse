/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [AddComponentMenu] // 0x00000001898B4620-0x00000001898B46C0
	// [DocumentationSorting] // 0x00000001898B4620-0x00000001898B46C0
	// [RequireComponent] // 0x00000001898B4620-0x00000001898B46C0
	[SaveDuringPlay] // 0x00000001898B4620-0x00000001898B46C0
	public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 6804
	{
		// Fields
		[Space] // 0x00000001898C99A0-0x00000001898C99F0
		// [Tooltip] // 0x00000001898C99A0-0x00000001898C99F0
		public Heading m_Heading; // 0x90
		// [Tooltip] // 0x00000001898D4060-0x00000001898D4090
		public Recentering m_RecenterToTargetHeading; // 0x9C
		// [Tooltip] // 0x00000001898DD2C0-0x00000001898DD2F0
		public AxisState m_XAxis; // 0xB0
		// [FormerlySerializedAs] // 0x00000001898E6700-0x00000001898E6760
		[HideInInspector] // 0x00000001898E6700-0x00000001898E6760
		[SerializeField] // 0x00000001898E6700-0x00000001898E6760
		private float m_LegacyRadius; // 0xE0
		// [FormerlySerializedAs] // 0x00000001898F58D0-0x00000001898F5920
		[HideInInspector] // 0x00000001898F58D0-0x00000001898F5920
		[SerializeField] // 0x00000001898F58D0-0x00000001898F5920
		private float m_LegacyHeightOffset; // 0xE4
		// [FormerlySerializedAs] // 0x00000001899049A0-0x00000001899049F0
		[HideInInspector] // 0x00000001899049A0-0x00000001899049F0
		[SerializeField] // 0x00000001899049A0-0x00000001899049F0
		private float m_LegacyHeadingBias; // 0xE8
		[HideInInspector] // 0x00000001899121B0-0x00000001899121E0
		[NoSaveDuringPlay] // 0x00000001899121B0-0x00000001899121E0
		public bool m_HeadingIsSlave; // 0xEC
		internal UpdateHeadingDelegate HeadingUpdater; // 0xF0
		private float mLastHeadingAxisInputTime; // 0xF8
		private float mHeadingRecenteringVelocity; // 0xFC
		private Vector3 mLastTargetPosition; // 0x100
		private HeadingTracker mHeadingTracker; // 0x110
		private Rigidbody mTargetRigidBody; // 0x118
		private Quaternion mHeadingPrevFrame; // 0x128
		private Vector3 mOffsetPrevFrame; // 0x138
	
		// Properties
		private Transform PreviousTarget { /* [XID] */ /* 0x0000000189944F10-0x0000000189944F50 */ get; /* [XID] */ /* 0x000000018994F5B0-0x000000018994F5F0 */ set; } // 0x0000000186CC4BA0-0x0000000186CC4C00 0x0000000186CC4C00-0x0000000186CC4C70
	
		// Nested types
		[Serializable]
		// [DocumentationSorting] // 0x000000018997F2A0-0x000000018997F2C0
		public struct Heading // TypeDefIndex: 6805
		{
			// Fields
			// [Tooltip] // 0x0000000189986CB0-0x0000000189986CE0
			public HeadingDefinition m_HeadingDefinition; // 0x00
			// [Range] // 0x000000018998FFD0-0x0000000189990020
			// [Tooltip] // 0x000000018998FFD0-0x0000000189990020
			public int m_VelocityFilterStrength; // 0x04
			// [Range] // 0x000000018999C4D0-0x000000018999C530
			// [Tooltip] // 0x000000018999C4D0-0x000000018999C530
			public float m_HeadingBias; // 0x08
	
			// Nested types
			// [DocumentationSorting] // 0x00000001899A87C0-0x00000001899A87E0
			public enum HeadingDefinition // TypeDefIndex: 6806
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3
			}
	
			// Constructors
			public Heading(HeadingDefinition def, int filterStrength, float bias) {
				m_HeadingDefinition = default;
				m_VelocityFilterStrength = default;
				m_HeadingBias = default;
			} // 0x0000000186CD7510-0x0000000186CD7540
		}
	
		[Serializable]
		// [DocumentationSorting] // 0x00000001899B0020-0x00000001899B0040
		public struct Recentering // TypeDefIndex: 6807
		{
			// Fields
			// [Tooltip] // 0x00000001899B7380-0x00000001899B73B0
			public bool m_enabled; // 0x00
			// [Tooltip] // 0x00000001899C0580-0x00000001899C05B0
			public float m_RecenterWaitTime; // 0x04
			// [Tooltip] // 0x00000001899C93A0-0x00000001899C93D0
			public float m_RecenteringTime; // 0x08
			// [FormerlySerializedAs] // 0x00000001899D23C0-0x00000001899D2420
			[HideInInspector] // 0x00000001899D23C0-0x00000001899D2420
			[SerializeField] // 0x00000001899D23C0-0x00000001899D2420
			private int m_LegacyHeadingDefinition; // 0x0C
			// [FormerlySerializedAs] // 0x00000001899E1230-0x00000001899E1280
			[HideInInspector] // 0x00000001899E1230-0x00000001899E1280
			[SerializeField] // 0x00000001899E1230-0x00000001899E1280
			private int m_LegacyVelocityFilterStrength; // 0x10
	
			// Constructors
			public Recentering(bool enabled, float recenterWaitTime, float recenteringSpeed) {
				m_enabled = default;
				m_RecenterWaitTime = default;
				m_RecenteringTime = default;
				m_LegacyHeadingDefinition = default;
				m_LegacyVelocityFilterStrength = default;
			} // 0x0000000186CD78C0-0x0000000186CD79F0
	
			// Methods
			// [XID] // 0x00000001899F04E0-0x00000001899F0500
			public void Validate() {} // 0x0000000186CD7820-0x0000000186CD78C0
			// [XID] // 0x00000001899F7A10-0x00000001899F7A30
			internal bool LegacyUpgrade(ref Heading.HeadingDefinition heading, ref int velocityFilter) => default; // 0x0000000186CD7720-0x0000000186CD7820
		}
	
		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // TypeDefIndex: 6808; 0x0000000186CD7CE0-0x0000000186CD8100
	
		private class HeadingTracker // TypeDefIndex: 6809
		{
			// Fields
			private Item[] mHistory; // 0x10
			private int mTop; // 0x18
			private int mBottom; // 0x1C
			private int mCount; // 0x20
			private Vector3 mHeadingSum; // 0x24
			private float mWeightSum; // 0x30
			private float mWeightTime; // 0x34
			private Vector3 mLastGoodHeading; // 0x38
			private static float mDecayExponent; // 0x00
	
			// Properties
			public int FilterSize { /* [XID] */ /* 0x00000001899FF0D0-0x00000001899FF0F0 */ get => default; } // 0x0000000186CD73E0-0x0000000186CD7510 
	
			// Nested types
			private struct Item // TypeDefIndex: 6810
			{
				// Fields
				public Vector3 velocity; // 0x00
				public float weight; // 0x0C
				public float time; // 0x10
			}
	
			// Constructors
			public HeadingTracker() {} // Dummy constructor
			public HeadingTracker(int filterSize) {} // 0x0000000186CD72A0-0x0000000186CD73E0
	
			// Methods
			// [XID] // 0x0000000189A06970-0x0000000189A06990
			private void ClearHistory() {} // 0x0000000186CD6B50-0x0000000186CD6C30
			// [XID] // 0x0000000189A0DF80-0x0000000189A0DFA0
			private static float Decay(float time) => default; // 0x0000000186CD6DA0-0x0000000186CD6E90
			// [XID] // 0x0000000189A15570-0x0000000189A15590
			public void Add(Vector3 velocity) {} // 0x0000000186CD68E0-0x0000000186CD6B50
			// [XID] // 0x0000000189A1C820-0x0000000189A1C840
			private void PopBottom() {} // 0x0000000186CD7080-0x0000000186CD72A0
			// [XID] // 0x0000000189761DA0-0x0000000189761DC0
			public void DecayHistory() {} // 0x0000000186CD6C30-0x0000000186CD6DA0
			// [XID] // 0x0000000189A2B3B0-0x0000000189A2B3D0
			public Vector3 GetReliableHeading() => default; // 0x0000000186CD6E90-0x0000000186CD7080
		}
	
		// Constructors
		public CinemachineOrbitalTransposer() {} // 0x0000000186CC4860-0x0000000186CC4BA0
	
		// Methods
		// [XID] // 0x0000000189A1F630-0x0000000189A1F650
		protected override void OnValidate() {} // 0x0000000186CC40D0-0x0000000186CC4290
		// [XID] // 0x0000000189935DC0-0x0000000189935DE0
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis) => default; // 0x0000000186CC44D0-0x0000000186CC4860
		// [XID] // 0x000000018993DA50-0x000000018993DA70
		private void OnEnable() {} // 0x0000000186CC3C90-0x0000000186CC3DD0
		// [XID] // 0x0000000189A47800-0x0000000189A47820
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000186CC34D0-0x0000000186CC3C90
		// [XID] // 0x00000001899616E0-0x0000000189961700
		public override void OnPositionDragged(Vector3 delta) {} // 0x0000000186CC3DD0-0x0000000186CC40D0
		// [XID] // 0x0000000189968C50-0x0000000189968C70
		private static string GetFullName(GameObject current) => default; // 0x0000000186CC2CD0-0x0000000186CC2EF0
		// [XID] // 0x00000001899703E0-0x0000000189970400
		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation, float deltaTime) => default; // 0x0000000186CC2EF0-0x0000000186CC34D0
	}
}
