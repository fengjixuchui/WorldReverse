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
	// [AddComponentMenu] // 0x000000018985C160-0x000000018985C1E0
	[DisallowMultipleComponent] // 0x000000018985C160-0x000000018985C1E0
	// [DocumentationSorting] // 0x000000018985C160-0x000000018985C1E0
	[ExecuteInEditMode] // 0x000000018985C160-0x000000018985C1E0
	public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 6773
	{
		// Fields
		[NoSaveDuringPlay] // 0x000000018986DA00-0x000000018986DA50
		// [Tooltip] // 0x000000018986DA00-0x000000018986DA50
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x0000000189879940-0x0000000189879980
		// [Tooltip] // 0x0000000189879940-0x0000000189879980
		public Transform m_Follow; // 0x80
		// [FormerlySerializedAs] // 0x0000000189885510-0x0000000189885570
		// [Tooltip] // 0x0000000189885510-0x0000000189885570
		public bool m_CommonLens; // 0x88
		// [FormerlySerializedAs] // 0x00000001898924C0-0x0000000189892530
		[LensSettingsProperty] // 0x00000001898924C0-0x0000000189892530
		// [Tooltip] // 0x00000001898924C0-0x0000000189892530
		public LensSettings m_Lens; // 0x8C
		// [Header] // 0x00000001898A2B60-0x00000001898A2BC0
		// [Tooltip] // 0x00000001898A2B60-0x00000001898A2BC0
		public AxisState m_YAxis; // 0xA8
		// [Tooltip] // 0x00000001898B03A0-0x00000001898B03D0
		public AxisState m_XAxis; // 0xD8
		// [Tooltip] // 0x00000001898B9540-0x00000001898B9570
		public CinemachineOrbitalTransposer.Heading m_Heading; // 0x108
		// [Tooltip] // 0x00000001898C2040-0x00000001898C2070
		public CinemachineOrbitalTransposer.Recentering m_RecenterToTargetHeading; // 0x114
		// [Header] // 0x00000001898CB180-0x00000001898CB1E0
		// [Tooltip] // 0x00000001898CB180-0x00000001898CB1E0
		public CinemachineTransposer.BindingMode m_BindingMode; // 0x128
		// [FormerlySerializedAs] // 0x00000001898D8850-0x00000001898D88D0
		// [Range] // 0x00000001898D8850-0x00000001898D88D0
		// [Tooltip] // 0x00000001898D8850-0x00000001898D88D0
		public float m_SplineCurvature; // 0x12C
		// [Tooltip] // 0x00000001898E9B90-0x00000001898E9BC0
		public Orbit[] m_Orbits; // 0x130
		// [FormerlySerializedAs] // 0x00000001898F27A0-0x00000001898F2800
		[HideInInspector] // 0x00000001898F27A0-0x00000001898F2800
		[SerializeField] // 0x00000001898F27A0-0x00000001898F2800
		private float m_LegacyHeadingBias; // 0x138
		private bool mUseLegacyRigDefinitions; // 0x13C
		private bool mIsDestroyed; // 0x13D
		private CameraState m_State; // 0x140
		[HideInInspector] // 0x0000000189901A10-0x0000000189901A50
		[NoSaveDuringPlay] // 0x0000000189901A10-0x0000000189901A50
		[SerializeField] // 0x0000000189901A10-0x0000000189901A50
		private CinemachineVirtualCamera[] m_Rigs; // 0x210
		private CinemachineOrbitalTransposer[] mOrbitals; // 0x218
		private CinemachineBlend mBlendA; // 0x220
		private CinemachineBlend mBlendB; // 0x228
		public static CreateRigDelegate CreateRigOverride; // 0x00
		public static DestroyRigDelegate DestroyRigOverride; // 0x08
		private Orbit[] m_CachedOrbits; // 0x230
		private float m_CachedTension; // 0x238
		private Vector4[] m_CachedKnots; // 0x240
		private Vector4[] m_CachedCtrl1; // 0x248
		private Vector4[] m_CachedCtrl2; // 0x250
	
		// Properties
		public static string[] RigNames { /* [XID] */ /* 0x000000018991E360-0x000000018991E380 */ get => default; } // 0x0000000186CBE7B0-0x0000000186CBE970 
		public override CameraState State { /* [XID] */ /* 0x0000000189B64B30-0x0000000189B64B50 */ get => default; } // 0x0000000186CBE970-0x0000000186CBEBD0 
		public override Transform LookAt { /* [XID] */ /* 0x000000018994ADB0-0x000000018994ADD0 */ get => default; /* [XID] */ /* 0x00000001898F9DA0-0x00000001898F9DC0 */ set {} } // 0x0000000186CBE700-0x0000000186CBE7B0 0x0000000186CBEC80-0x0000000186CBED30
		public override Transform Follow { /* [XID] */ /* 0x0000000189BB8240-0x0000000189BB8260 */ get => default; /* [XID] */ /* 0x0000000189B73850-0x0000000189B73870 */ set {} } // 0x0000000186CBE500-0x0000000186CBE5B0 0x0000000186CBEBD0-0x0000000186CBEC80
		public override ICinemachineCamera LiveChildOrSelf { /* [XID] */ /* 0x0000000189968C70-0x0000000189968C90 */ get => default; } // 0x0000000186CBE5B0-0x0000000186CBE700 
	
		// Nested types
		[Serializable]
		public struct Orbit // TypeDefIndex: 6774
		{
			// Fields
			public float m_Height; // 0x00
			public float m_Radius; // 0x04
	
			// Constructors
			public Orbit(float h, float r) {
				m_Height = default;
				m_Radius = default;
			} // 0x0000000186CD7540-0x0000000186CD75C0
		}
	
		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom); // TypeDefIndex: 6775; 0x0000000186CD6130-0x0000000186CD6420
	
		public delegate void DestroyRigDelegate(GameObject rig); // TypeDefIndex: 6776; 0x0000000186CD6600-0x0000000186CD6860
	
		// Constructors
		public CinemachineFreeLook() {} // 0x0000000186CBDF60-0x0000000186CBE500
	
		// Methods
		// [XID] // 0x000000018990F380-0x000000018990F3A0
		protected override void OnValidate() {} // 0x0000000186CBB400-0x0000000186CBB530
		// [XID] // 0x0000000189916C50-0x0000000189916C70
		public CinemachineVirtualCamera GetRig(int i) => default; // 0x0000000186CBA590-0x0000000186CBA680
		// [XID] // 0x0000000189925C70-0x0000000189925C90
		protected override void OnEnable() {} // 0x0000000186CBB050-0x0000000186CBB100
		// [XID] // 0x000000018992D080-0x000000018992D0A0
		protected override void OnDestroy() {} // 0x0000000186CBAE80-0x0000000186CBB050
		// [XID] // 0x0000000189934790-0x00000001899347B0
		private void OnTransformChildrenChanged() {} // 0x0000000186CBB100-0x0000000186CBB1A0
		// [XID] // 0x000000018993C2B0-0x000000018993C2D0
		private void Reset() {} // 0x0000000186CBC4D0-0x0000000186CBC570
		// [XID] // 0x0000000189970420-0x0000000189970440
		public override bool IsLiveChild(ICinemachineCamera vcam) => default; // 0x0000000186CBA720-0x0000000186CBA890
		// [XID] // 0x0000000189B89D70-0x0000000189B89D90
		public override void RemovePostPipelineStageHook(OnPostPipelineStageDelegate d) {} // 0x0000000186CBC350-0x0000000186CBC4D0
		// [XID] // 0x0000000189B91420-0x0000000189B91440
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186CBCFC0-0x0000000186CBD7A0
		// [XID] // 0x0000000189986CE0-0x0000000189986D00
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000186CBB1A0-0x0000000186CBB400
		// [XID] // 0x000000018998E730-0x000000018998E750
		private void InvalidateRigCache() {} // 0x0000000186CBA680-0x0000000186CBA720
		// [XID] // 0x0000000189996260-0x0000000189996280
		private void DestroyRigs() {} // 0x0000000186CB9DA0-0x0000000186CBA230
		// [XID] // 0x000000018999DD70-0x000000018999DD90
		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom) => default; // 0x0000000186CB9770-0x0000000186CB9DA0
		// [XID] // 0x00000001899A56A0-0x00000001899A56C0
		private void UpdateRigCache() {} // 0x0000000186CBD7A0-0x0000000186CBDF60
		// [XID] // 0x00000001898E0460-0x00000001898E0480
		private int LocateExistingRigs(string[] rigNames, bool forceOrbital) => default; // 0x0000000186CBA890-0x0000000186CBAE80
		// [XID] // 0x00000001899B4780-0x00000001899B47A0
		private void PushSettingsToRigs() {} // 0x0000000186CBBAA0-0x0000000186CBC350
		// [XID] // 0x00000001899BBD40-0x00000001899BBD60
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) => default; // 0x0000000186CB9340-0x0000000186CB9770
		// [XID] // 0x000000018971E7E0-0x000000018971E800
		private CameraState PullStateFromVirtualCamera(Vector3 worldUp) => default; // 0x0000000186CBB530-0x0000000186CBBAA0
		// [XID] // 0x00000001899CADF0-0x00000001899CAE10
		public Vector3 GetLocalPositionForCameraFromInput(float t) => default; // 0x0000000186CBA230-0x0000000186CBA590
		// [XID] // 0x00000001899D2420-0x00000001899D2440
		private void UpdateCachedSpline() {} // 0x0000000186CBC970-0x0000000186CBCFC0
	}
}
