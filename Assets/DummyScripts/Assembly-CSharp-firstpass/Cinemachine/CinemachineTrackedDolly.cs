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
	// [AddComponentMenu] // 0x0000000189AAA950-0x0000000189AAA9F0
	// [DocumentationSorting] // 0x0000000189AAA950-0x0000000189AAA9F0
	// [RequireComponent] // 0x0000000189AAA950-0x0000000189AAA9F0
	[SaveDuringPlay] // 0x0000000189AAA950-0x0000000189AAA9F0
	public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 6813
	{
		// Fields
		// [Tooltip] // 0x0000000189ABFF00-0x0000000189ABFF30
		public CinemachinePathBase m_Path; // 0x20
		// [Tooltip] // 0x0000000189AC8EE0-0x0000000189AC8F10
		public float m_PathPosition; // 0x28
		// [Tooltip] // 0x0000000189AD22B0-0x0000000189AD22E0
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x2C
		// [Tooltip] // 0x0000000189ADB4D0-0x0000000189ADB500
		public Vector3 m_PathOffset; // 0x30
		// [Range] // 0x0000000189AE4780-0x0000000189AE47D0
		// [Tooltip] // 0x0000000189AE4780-0x0000000189AE47D0
		public float m_XDamping; // 0x3C
		// [Range] // 0x0000000189AF0B30-0x0000000189AF0B80
		// [Tooltip] // 0x0000000189AF0B30-0x0000000189AF0B80
		public float m_YDamping; // 0x40
		// [Range] // 0x0000000189AFC610-0x0000000189AFC660
		// [Tooltip] // 0x0000000189AFC610-0x0000000189AFC660
		public float m_ZDamping; // 0x44
		// [Tooltip] // 0x0000000189B08500-0x0000000189B08530
		public CameraUpMode m_CameraUp; // 0x48
		// [Range] // 0x0000000189B11880-0x0000000189B118D0
		// [Tooltip] // 0x0000000189B11880-0x0000000189B118D0
		public float m_PitchDamping; // 0x4C
		// [Range] // 0x00000001895F6050-0x00000001895F60A0
		// [Tooltip] // 0x00000001895F6050-0x00000001895F60A0
		public float m_YawDamping; // 0x50
		// [Range] // 0x0000000189B28E90-0x0000000189B28EF0
		// [Tooltip] // 0x0000000189B28E90-0x0000000189B28EF0
		public float m_RollDamping; // 0x54
		// [Tooltip] // 0x0000000189B34930-0x0000000189B34960
		public AutoDolly m_AutoDolly; // 0x58
		private float m_PreviousPathPosition; // 0x68
		private Quaternion m_PreviousOrientation; // 0x6C
		private Vector3 m_PreviousCameraPosition; // 0x7C
	
		// Properties
		public override bool IsValid { /* [XID] */ /* 0x0000000189A4A790-0x0000000189A4A7B0 */ get => default; } // 0x0000000186CD0890-0x0000000186CD0980 
		public override CinemachineCore.Stage Stage { /* [XID] */ /* 0x0000000189B96DC0-0x0000000189B96DE0 */ get => default; } // 0x0000000186CD0980-0x0000000186CD0A20 
		private Vector3 AngularDamping { /* [XID] */ /* 0x0000000189B634B0-0x0000000189B634D0 */ get => default; } // 0x0000000186CD0730-0x0000000186CD0890 
	
		// Nested types
		// [DocumentationSorting] // 0x0000000189B6ADB0-0x0000000189B6ADD0
		public enum CameraUpMode // TypeDefIndex: 6814
		{
			Default = 0,
			Path = 1,
			PathNoRoll = 2,
			FollowTarget = 3,
			FollowTargetNoRoll = 4
		}
	
		[Serializable]
		// [DocumentationSorting] // 0x0000000189B724C0-0x0000000189B724E0
		public struct AutoDolly // TypeDefIndex: 6815
		{
			// Fields
			// [Tooltip] // 0x0000000189B799E0-0x0000000189B79A10
			public bool m_Enabled; // 0x00
			// [Tooltip] // 0x0000000189B82920-0x0000000189B82950
			public float m_PositionOffset; // 0x04
			// [Tooltip] // 0x0000000189B8B120-0x0000000189B8B150
			public int m_SearchRadius; // 0x08
			// [FormerlySerializedAs] // 0x0000000189B942C0-0x0000000189B94320
			// [Tooltip] // 0x0000000189B942C0-0x0000000189B94320
			public int m_SearchResolution; // 0x0C
	
			// Constructors
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment) {
				m_Enabled = default;
				m_PositionOffset = default;
				m_SearchRadius = default;
				m_SearchResolution = default;
			} // 0x0000000186CB21C0-0x0000000186CB21D0
		}
	
		// Constructors
		public CinemachineTrackedDolly() {} // 0x0000000186CD0580-0x0000000186CD0730
	
		// Methods
		// [XID] // 0x0000000189B4CD70-0x0000000189B4CD90
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000186CCF710-0x0000000186CD0300
		// [XID] // 0x0000000189B543B0-0x0000000189B543D0
		public override void OnPositionDragged(Vector3 delta) {} // 0x0000000186CD0300-0x0000000186CD04F0
		// [XID] // 0x0000000189B5BFF0-0x0000000189B5C010
		private Quaternion GetTargetOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up) => default; // 0x0000000186CCF300-0x0000000186CCF710
	}
}
