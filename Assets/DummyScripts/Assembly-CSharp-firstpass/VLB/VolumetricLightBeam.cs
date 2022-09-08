/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace VLB
{
	[DisallowMultipleComponent] // 0x00000001897B63F0-0x00000001897B6460
	[ExecuteInEditMode] // 0x00000001897B63F0-0x00000001897B6460
	// [HelpURL] // 0x00000001897B63F0-0x00000001897B6460
	[SelectionBase] // 0x00000001897B63F0-0x00000001897B6460
	public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 10210
	{
		// Fields
		public bool colorFromLight; // 0x18
		public ColorMode colorMode; // 0x1C
		// [ColorUsage] // 0x00000001897C7150-0x00000001897C71D0
		// [FormerlySerializedAs] // 0x00000001897C7150-0x00000001897C71D0
		public Color color; // 0x20
		public Gradient colorGradient; // 0x30
		// [Range] // 0x0000000189B49D30-0x0000000189B49D50
		public float alphaInside; // 0x38
		// [FormerlySerializedAs] // 0x00000001897DAAA0-0x00000001897DAAF0
		// [Range] // 0x00000001897DAAA0-0x00000001897DAAF0
		public float alphaOutside; // 0x3C
		// [FormerlySerializedAs] // 0x00000001897E6750-0x00000001897E6780
		public bool spotAngleFromLight; // 0x40
		// [Range] // 0x00000001897EF9A0-0x00000001897EF9C0
		public float spotAngle; // 0x44
		// [FormerlySerializedAs] // 0x00000001897F7080-0x00000001897F70B0
		public float coneRadiusStart; // 0x48
		public int geomSides; // 0x4C
		public bool geomCap; // 0x50
		public bool fadeEndFromLight; // 0x51
		public AttenuationEquation attenuationEquation; // 0x54
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float attenuationCustomBlending; // 0x58
		public float fadeStart; // 0x5C
		public float fadeEnd; // 0x60
		public float depthBlendDistance; // 0x64
		public float cameraClippingDistance; // 0x68
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float glareFrontal; // 0x6C
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float glareBehind; // 0x70
		[Obsolete] // 0x0000000189816640-0x0000000189816670
		public float boostDistanceInside; // 0x74
		[Obsolete] // 0x000000018981F7B0-0x000000018981F7E0
		public float fresnelPowInside; // 0x78
		// [FormerlySerializedAs] // 0x00000001898287A0-0x00000001898287D0
		public float fresnelPow; // 0x7C
		public bool noiseEnabled; // 0x80
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float noiseIntensity; // 0x84
		public bool noiseScaleUseGlobal; // 0x88
		// [Range] // 0x0000000189838A40-0x0000000189838A60
		public float noiseScaleLocal; // 0x8C
		public bool noiseVelocityUseGlobal; // 0x90
		public Vector3 noiseVelocityLocal; // 0x94
		public BlendMode srcBlendMode; // 0xA0
		public BlendMode dstBlendMode; // 0xA4
		public BlendOp blendOP; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int pluginVersion; // 0xAC
		// [FormerlySerializedAs] // 0x00000001898475C0-0x0000000189847610
		[SerializeField] // 0x00000001898475C0-0x0000000189847610
		private bool _TrackChangesDuringPlaytime; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _SortingLayerID; // 0xB4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _SortingOrder; // 0xB8
		private BeamGeometry m_BeamGeom; // 0xC0
		private Coroutine m_CoPlaytimeUpdate; // 0xC8
		private Light _CachedLight; // 0xD0
	
		// Properties
		public float coneAngle { /* [XID] */ /* 0x00000001898619D0-0x00000001898619F0 */ get => default; } // 0x0000000186EB4410-0x0000000186EB4530 
		public float coneRadiusEnd { /* [XID] */ /* 0x00000001898692D0-0x00000001898692F0 */ get => default; } // 0x0000000186EB4620-0x0000000186EB4720 
		public float coneVolume { /* [XID] */ /* 0x0000000189835A10-0x0000000189835A30 */ get => default; } // 0x0000000186EB4720-0x0000000186EB4810 
		public float coneApexOffsetZ { /* [XID] */ /* 0x0000000189877CE0-0x0000000189877D00 */ get => default; } // 0x0000000186EB4530-0x0000000186EB4620 
		public float attenuationLerpLinearQuad { /* [XID] */ /* 0x000000018987F530-0x000000018987F550 */ get => default; } // 0x0000000186EB4110-0x0000000186EB41E0 
		public int sortingLayerID { /* [XID] */ /* 0x0000000189A9D320-0x0000000189A9D340 */ get => default; /* [XID] */ /* 0x0000000189A1ADF0-0x0000000189A1AE10 */ set {} } // 0x0000000186EB4D40-0x0000000186EB4DE0 0x0000000186EB4FE0-0x0000000186EB50F0
		public string sortingLayerName { /* [XID] */ /* 0x0000000189A8CD60-0x0000000189A8CD80 */ get => default; /* [XID] */ /* 0x000000018989CAE0-0x000000018989CB00 */ set {} } // 0x0000000186EB4DE0-0x0000000186EB4E90 0x0000000186EB50F0-0x0000000186EB51B0
		public int sortingOrder { /* [XID] */ /* 0x000000018992BCB0-0x000000018992BCD0 */ get => default; /* [XID] */ /* 0x00000001898AB500-0x00000001898AB520 */ set {} } // 0x0000000186EB4E90-0x0000000186EB4F30 0x0000000186EB51B0-0x0000000186EB52C0
		public bool trackChangesDuringPlaytime { /* [XID] */ /* 0x00000001898B2D80-0x00000001898B2DA0 */ get => default; /* [XID] */ /* 0x0000000189B0E310-0x0000000189B0E330 */ set {} } // 0x0000000186EB4F30-0x0000000186EB4FE0 0x0000000186EB52C0-0x0000000186EB5380
		public bool isCurrentlyTrackingChanges { /* [XID] */ /* 0x00000001898C1E30-0x00000001898C1E50 */ get => default; } // 0x0000000186EB48E0-0x0000000186EB4990 
		public bool hasGeometry { /* [XID] */ /* 0x000000018998FC80-0x000000018998FCA0 */ get => default; } // 0x0000000186EB4810-0x0000000186EB48E0 
		public Bounds bounds { /* [XID] */ /* 0x00000001898D1020-0x00000001898D1040 */ get => default; } // 0x0000000186EB41E0-0x0000000186EB4410 
		public string meshStats { /* [XID] */ /* 0x00000001898E7FC0-0x00000001898E7FE0 */ get => default; } // 0x0000000186EB4AF0-0x0000000186EB4D40 
		private Light lightSpotAttached { /* [XID] */ /* 0x0000000189BA7170-0x0000000189BA7190 */ get => default; } // 0x0000000186EB4990-0x0000000186EB4AF0 
	
		// Constructors
		public VolumetricLightBeam() {} // 0x0000000186EB3F60-0x0000000186EB4110
	
		// Methods
		// [XID] // 0x00000001897E35E0-0x00000001897E3600
		public void SetClippingPlane(Plane planeWS) {} // 0x0000000186EB3B00-0x0000000186EB3C20
		// [XID] // 0x00000001898E0540-0x00000001898E0560
		public void SetClippingPlaneOff() {} // 0x0000000186EB3A10-0x0000000186EB3B00
		// [XID] // 0x00000001898F7030-0x00000001898F7050
		public float GetInsideBeamFactor(Vector3 posWS) => default; // 0x0000000186EB3450-0x0000000186EB36E0
		[Obsolete] // 0x00000001898FE7E0-0x00000001898FE830
		// [XID] // 0x00000001898FE7E0-0x00000001898FE830
		public void Generate() {} // 0x0000000186EB33B0-0x0000000186EB3450
		// [XID] // 0x000000018990A630-0x000000018990A650
		public void GenerateGeometry() {} // 0x0000000186EB3180-0x0000000186EB33B0
		// [XID] // 0x00000001896E2860-0x00000001896E2880
		public void UpdateAfterManualPropertyChange() {} // 0x0000000186EB3DA0-0x0000000186EB3EA0
		// [XID] // 0x000000018979F470-0x000000018979F490
		private void Start() {} // 0x0000000186EB3D00-0x0000000186EB3DA0
		// [XID] // 0x0000000189920FF0-0x0000000189921010
		private void OnEnable() {} // 0x0000000186EB3910-0x0000000186EB3A10
		// [XID] // 0x0000000189B91C80-0x0000000189B91CA0
		private void OnDisable() {} // 0x0000000186EB3810-0x0000000186EB3910
		// [XID] // 0x000000018992FE30-0x000000018992FE50
		private void StartPlaytimeUpdateIfNeeded() {} // 0x0000000186EB3C20-0x0000000186EB3D00
		[DebuggerHidden] // 0x0000000189937390-0x00000001899373D0
		// [XID] // 0x0000000189937390-0x00000001899373D0
		private IEnumerator CoPlaytimeUpdate() => default; // 0x0000000186EB3070-0x0000000186EB3180
		// [XID] // 0x000000018977BDE0-0x000000018977BE00
		private void OnDestroy() {} // 0x0000000186EB36E0-0x0000000186EB3810
		// [XID] // 0x00000001896566B0-0x00000001896566D0
		private void AssignPropertiesFromSpotLight(Light lightSpot) {} // 0x0000000186EB2D10-0x0000000186EB2E60
		// [XID] // 0x0000000189950E70-0x0000000189950E90
		private void ClampProperties() {} // 0x0000000186EB2E60-0x0000000186EB3070
		// [XID] // 0x0000000189958590-0x00000001899585B0
		private void ValidateProperties() {} // 0x0000000186EB3EA0-0x0000000186EB3F60
	}
}
