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
	// [AddComponentMenu] // 0x0000000189BA14C0-0x0000000189BA1560
	// [DocumentationSorting] // 0x0000000189BA14C0-0x0000000189BA1560
	// [RequireComponent] // 0x0000000189BA14C0-0x0000000189BA1560
	[SaveDuringPlay] // 0x0000000189BA14C0-0x0000000189BA1560
	public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 6816
	{
		// Fields
		// [Tooltip] // 0x0000000189BB5FF0-0x0000000189BB6020
		public BindingMode m_BindingMode; // 0x20
		// [Tooltip] // 0x0000000189BBD6A0-0x0000000189BBD6D0
		public Vector3 m_FollowOffset; // 0x24
		private Vector3 m_CurrentForward; // 0x30
		private bool _offsetForward; // 0x3C
		// [Range] // 0x0000000189BC6850-0x0000000189BC68A0
		// [Tooltip] // 0x0000000189BC6850-0x0000000189BC68A0
		public float m_XDamping; // 0x40
		// [Range] // 0x0000000189BD12F0-0x0000000189BD1340
		// [Tooltip] // 0x0000000189BD12F0-0x0000000189BD1340
		public float m_YDamping; // 0x44
		// [Range] // 0x0000000189BDBDE0-0x0000000189BDBE30
		// [Tooltip] // 0x0000000189BDBDE0-0x0000000189BDBE30
		public float m_ZDamping; // 0x48
		// [Range] // 0x0000000189B11880-0x0000000189B118D0
		// [Tooltip] // 0x0000000189B11880-0x0000000189B118D0
		public float m_PitchDamping; // 0x4C
		// [Range] // 0x00000001895F6050-0x00000001895F60A0
		// [Tooltip] // 0x00000001895F6050-0x00000001895F60A0
		public float m_YawDamping; // 0x50
		// [Range] // 0x0000000189600390-0x00000001896003E0
		// [Tooltip] // 0x0000000189600390-0x00000001896003E0
		public float m_RollDamping; // 0x54
		private Vector3 m_PreviousTargetPosition; // 0x58
		private Quaternion m_PreviousReferenceOrientation; // 0x64
		private Quaternion m_targetOrientationOnAssign; // 0x74
		private Transform m_previousTarget; // 0x88
	
		// Properties
		protected Vector3 EffectiveOffset { /* [XID] */ /* 0x0000000189628BC0-0x0000000189628BE0 */ get => default; } // 0x0000000186CD2A20-0x0000000186CD2C10 
		public override bool IsValid { /* [XID] */ /* 0x0000000189977EB0-0x0000000189977ED0 */ get => default; } // 0x0000000186CD2C10-0x0000000186CD2D00 
		public override CinemachineCore.Stage Stage { /* [XID] */ /* 0x00000001896380F0-0x0000000189638110 */ get => default; } // 0x0000000186CD2D00-0x0000000186CD2DA0 
		protected Vector3 Damping { /* [XID] */ /* 0x000000018965D400-0x000000018965D420 */ get => default; } // 0x0000000186CD2910-0x0000000186CD2A20 
		protected Vector3 AngularDamping { /* [XID] */ /* 0x0000000189664A90-0x0000000189664AB0 */ get => default; } // 0x0000000186CD2790-0x0000000186CD2910 
	
		// Nested types
		// [DocumentationSorting] // 0x0000000189682DF0-0x0000000189682E10
		public enum BindingMode // TypeDefIndex: 6817
		{
			LockToTargetOnAssign = 0,
			LockToTargetWithWorldUp = 1,
			LockToTargetNoRoll = 2,
			LockToTarget = 3,
			WorldSpace = 4,
			SimpleFollowWithWorldUp = 5
		}
	
		// Constructors
		public CinemachineTransposer() {} // 0x0000000186CD2600-0x0000000186CD2790
	
		// Methods
		// [XID] // 0x00000001899613B0-0x00000001899613D0
		public void SetCurrentForward(Vector3 currentForward) {} // 0x0000000186CD1AE0-0x0000000186CD1BB0
		// [XID] // 0x0000000189612520-0x0000000189612540
		public Vector3 GetCurrentForward() => default; // 0x0000000186CD0C80-0x0000000186CD0D60
		// [XID] // 0x0000000189970060-0x0000000189970080
		public void SetOffsetForward(bool value) {} // 0x0000000186CD1BB0-0x0000000186CD1C60
		// [XID] // 0x00000001896212D0-0x00000001896212F0
		protected virtual void OnValidate() {} // 0x0000000186CD1A20-0x0000000186CD1AE0
		// [XID] // 0x000000018963F2F0-0x000000018963F310
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000186CD1490-0x0000000186CD1750
		// [XID] // 0x0000000189B9E1D0-0x0000000189B9E1F0
		public override void OnPositionDragged(Vector3 delta) {} // 0x0000000186CD1750-0x0000000186CD1A20
		// [XID] // 0x000000018964E400-0x000000018964E420
		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime) {} // 0x0000000186CD1250-0x0000000186CD1490
		// [XID] // 0x0000000189655CC0-0x0000000189655CE0
		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient) {
			outTargetPosition = default;
			outTargetOrient = default;
		} // 0x0000000186CD1C60-0x0000000186CD2380
		// [XID] // 0x0000000189A23E70-0x0000000189A23E90
		public Vector3 GeTargetCameraPosition(Vector3 worldUp) => default; // 0x0000000186CD0A20-0x0000000186CD0C80
		// [XID] // 0x0000000189673EF0-0x0000000189673F10
		public Quaternion GetReferenceOrientation(Vector3 worldUp) => default; // 0x0000000186CD0D60-0x0000000186CD1250
		// [XID] // 0x000000018967B660-0x000000018967B680
		private static Quaternion Uppify(Quaternion q, Vector3 up) => default; // 0x0000000186CD2410-0x0000000186CD2600
	}
}
