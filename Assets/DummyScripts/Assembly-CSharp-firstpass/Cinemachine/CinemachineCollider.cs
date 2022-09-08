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
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [AddComponentMenu] // 0x0000000189BD7010-0x0000000189BD7090
	// [DocumentationSorting] // 0x0000000189BD7010-0x0000000189BD7090
	[ExecuteInEditMode] // 0x0000000189BD7010-0x0000000189BD7090
	[SaveDuringPlay] // 0x0000000189BD7010-0x0000000189BD7090
	public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 6762
	{
		// Fields
		// [Header] // 0x00000001895ECF00-0x00000001895ECF60
		// [Tooltip] // 0x00000001895ECF00-0x00000001895ECF60
		public LayerMask m_CollideAgainst; // 0x28
		[TagField] // 0x00000001895FA520-0x00000001895FA560
		// [Tooltip] // 0x00000001895FA520-0x00000001895FA560
		public string m_IgnoreTag; // 0x30
		// [Tooltip] // 0x0000000189606630-0x0000000189606660
		public float m_MinimumDistanceFromTarget; // 0x38
		// [FormerlySerializedAs] // 0x000000018960F510-0x000000018960F580
		[Space] // 0x000000018960F510-0x000000018960F580
		// [Tooltip] // 0x000000018960F510-0x000000018960F580
		public bool m_AvoidObstacles; // 0x3C
		// [FormerlySerializedAs] // 0x000000018961FDB0-0x000000018961FE10
		// [Tooltip] // 0x000000018961FDB0-0x000000018961FE10
		public float m_DistanceLimit; // 0x40
		// [Tooltip] // 0x000000018962D260-0x000000018962D290
		public float m_CameraRadius; // 0x44
		// [Tooltip] // 0x00000001896367C0-0x00000001896367F0
		public ResolutionStrategy m_Strategy; // 0x48
		// [Range] // 0x000000018963F310-0x000000018963F370
		// [Tooltip] // 0x000000018963F310-0x000000018963F370
		public int m_MaximumEffort; // 0x4C
		// [FormerlySerializedAs] // 0x000000018964B180-0x000000018964B200
		// [Range] // 0x000000018964B180-0x000000018964B200
		// [Tooltip] // 0x000000018964B180-0x000000018964B200
		public float m_Damping; // 0x50
		// [Header] // 0x000000018965BCD0-0x000000018965BD30
		// [Tooltip] // 0x000000018965BCD0-0x000000018965BD30
		public float m_OptimalTargetDistance; // 0x54
		private const float PrecisionSlush = 0.001f; // Metadata: 0x00ADDE0B
		private RaycastHit[] m_CornerBuffer; // 0x58
		private const float AngleThreshold = 0.1f; // Metadata: 0x00ADDE0F
		private Collider[] mColliderBuffer; // 0x60
		private SphereCollider mCameraCollider; // 0x68
		private GameObject mCameraColliderGameObject; // 0x70
	
		// Properties
		public List<List<Vector3>> DebugPaths { /* [XID] */ /* 0x0000000189687620-0x0000000189687640 */ get => default; } // 0x0000000186EEB850-0x0000000186EEBA40 
	
		// Nested types
		public enum ResolutionStrategy // TypeDefIndex: 6763
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2
		}
	
		private class VcamExtraState // TypeDefIndex: 6764
		{
			// Fields
			public Vector3 m_previousDisplacement; // 0x10
			public float colliderDisplacement; // 0x1C
			public bool targetObscured; // 0x20
			public List<Vector3> debugResolutionPath; // 0x28
	
			// Constructors
			public VcamExtraState() {} // 0x0000000186EF8FE0-0x0000000186EF9040
	
			// Methods
			// [XID] // 0x00000001897EE100-0x00000001897EE120
			public void AddPointToDebugPath(Vector3 p) {} // 0x0000000186EF8F20-0x0000000186EF8FE0
		}
	
		// Constructors
		public CinemachineCollider() {} // 0x0000000186EEB730-0x0000000186EEB850
	
		// Methods
		// [XID] // 0x00000001896693D0-0x00000001896693F0
		public bool IsTargetObscured(ICinemachineCamera vcam) => default; // 0x0000000186EE9340-0x0000000186EE9410
		// [XID] // 0x0000000189A25330-0x0000000189A25350
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) => default; // 0x0000000186EE7860-0x0000000186EE7940
		// [XID] // 0x00000001896786B0-0x00000001896786D0
		private void OnValidate() {} // 0x0000000186EE94C0-0x0000000186EE95F0
		// [XID] // 0x000000018967FEF0-0x000000018967FF10
		protected override void OnDestroy() {} // 0x0000000186EE9410-0x0000000186EE94C0
		// [XID] // 0x000000018968F3F0-0x000000018968F410
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000186EE95F0-0x0000000186EE9CB0
		// [XID] // 0x0000000189696E90-0x0000000189696EB0
		private Vector3 PreserveLignOfSight(ref CameraState state, ref VcamExtraState extra) => default; // 0x0000000186EE9CB0-0x0000000186EEA460
		// [XID] // 0x000000018969E450-0x000000018969E470
		private bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength) {
			hitInfo = default;
			return default;
		} // 0x0000000186EEADB0-0x0000000186EEB140
		// [XID] // 0x00000001896A5420-0x00000001896A5440
		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra) => default; // 0x0000000186EEA460-0x0000000186EEADB0
		// [XID] // 0x00000001896ACCE0-0x00000001896ACD00
		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) => default; // 0x0000000186EE89B0-0x0000000186EE9340
		// [XID] // 0x00000001896B40C0-0x00000001896B40E0
		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) => default; // 0x0000000186EE8610-0x0000000186EE89B0
		// [XID] // 0x00000001896BB5E0-0x00000001896BB600
		private float ClampRayToBounds(Ray ray, float distance, Bounds bounds) => default; // 0x0000000186EE7C80-0x0000000186EE8500
		// [XID] // 0x00000001896C28B0-0x00000001896C28D0
		private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos) => default; // 0x0000000186EEB140-0x0000000186EEB6D0
		// [XID] // 0x00000001896C9E60-0x00000001896C9E80
		private void CleanupCameraCollider() {} // 0x0000000186EE8500-0x0000000186EE8610
		// [XID] // 0x00000001896D1660-0x00000001896D1680
		private bool CheckForTargetObstructions(CameraState state) => default; // 0x0000000186EE7940-0x0000000186EE7C80
	}
}
