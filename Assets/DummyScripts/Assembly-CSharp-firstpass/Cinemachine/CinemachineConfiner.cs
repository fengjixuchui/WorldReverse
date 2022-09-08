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

namespace Cinemachine
{
	// [AddComponentMenu] // 0x00000001896E0510-0x00000001896E0590
	// [DocumentationSorting] // 0x00000001896E0510-0x00000001896E0590
	[ExecuteInEditMode] // 0x00000001896E0510-0x00000001896E0590
	[SaveDuringPlay] // 0x00000001896E0510-0x00000001896E0590
	public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 6765
	{
		// Fields
		// [Tooltip] // 0x00000001896F04A0-0x00000001896F04D0
		public Mode m_ConfineMode; // 0x28
		// [Tooltip] // 0x00000001896F93B0-0x00000001896F93E0
		public Collider m_BoundingVolume; // 0x30
		// [Tooltip] // 0x0000000189702590-0x00000001897025C0
		public Collider2D m_BoundingShape2D; // 0x38
		// [Tooltip] // 0x000000018970B530-0x000000018970B560
		public bool m_ConfineScreenEdges; // 0x40
		// [Range] // 0x0000000189714290-0x00000001897142F0
		// [Tooltip] // 0x0000000189714290-0x00000001897142F0
		public float m_Damping; // 0x44
		private List<List<Vector2>> m_pathCache; // 0x48
	
		// Properties
		public bool IsValid { /* [XID] */ /* 0x0000000189770850-0x0000000189770870 */ get => default; } // 0x0000000186EF08C0-0x0000000186EF0BB0 
	
		// Nested types
		public enum Mode // TypeDefIndex: 6766
		{
			Confine2D = 0,
			Confine3D = 1
		}
	
		private class VcamExtraState // TypeDefIndex: 6767
		{
			// Fields
			public Vector3 m_previousDisplacement; // 0x10
			public float confinerDisplacement; // 0x1C
	
			// Constructors
			public VcamExtraState() {} // 0x0000000186CD8520-0x0000000186CD8580
		}
	
		// Constructors
		public CinemachineConfiner() {} // 0x0000000186EF0850-0x0000000186EF08C0
	
		// Methods
		// [XID] // 0x00000001897204A0-0x00000001897204C0
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) => default; // 0x0000000186EEEF50-0x0000000186EEF030
		// [XID] // 0x0000000189761D80-0x0000000189761DA0
		private void OnValidate() {} // 0x0000000186EEFF00-0x0000000186EEFFE0
		// [XID] // 0x0000000189736810-0x0000000189736830
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000186EEFFE0-0x0000000186EF0400
		// [XID] // 0x000000018973E660-0x000000018973E680
		public void InvalidatePathCache() {} // 0x0000000186EEFE60-0x0000000186EEFF00
		// [XID] // 0x00000001897458D0-0x00000001897458F0
		private bool ValidatePathCache() => default; // 0x0000000186EF0400-0x0000000186EF0850
		// [XID] // 0x000000018974D390-0x000000018974D3B0
		private Vector3 ConfinePoint(Vector3 camPos) => default; // 0x0000000186EEF030-0x0000000186EEF680
		// [XID] // 0x0000000189754A40-0x0000000189754A60
		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) => default; // 0x0000000186EEF680-0x0000000186EEFE60
	}
}
