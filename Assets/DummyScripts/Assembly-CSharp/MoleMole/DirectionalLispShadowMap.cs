/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x000000018971F190-0x000000018971F200
	// [RequireComponent] // 0x000000018971F190-0x000000018971F200
	public class DirectionalLispShadowMap : MonoBehaviour // TypeDefIndex: 26528
	{
		// Fields
		private static readonly string swithcer_ShaderVarName; // 0x00
		private static readonly string worldToShadow_ShaderVarName; // 0x08
		private static readonly string worldToShadowMap_ShaderVarName; // 0x10
		private static readonly string shadeRangeOffsetParams_ShaderVarName; // 0x18
		// [Header] // 0x000000018972DDB0-0x000000018972DDE0
		public bool UseUnityLikeShadow; // 0x18
		public int ShadowMapSize; // 0x1C
		public bool UseSphereBound; // 0x20
		private Camera _tempCam; // 0x28
		private Vector3 _sphereCenter; // 0x30
		private float _sphereRadius; // 0x3C
		// [Tooltip] // 0x00000001897370A0-0x00000001897370D0
		public float maxDist; // 0x40
		// [Tooltip] // 0x00000001897403F0-0x0000000189740420
		public float maxDistDown; // 0x44
		// [Tooltip] // 0x0000000189749200-0x0000000189749230
		public float maxHeight; // 0x48
		public ProjectionType projectionType; // 0x4C
		// [Tooltip] // 0x0000000189751B50-0x0000000189751B80
		public int updateRate; // 0x50
		// [Tooltip] // 0x000000018975A910-0x000000018975A940
		public float updateAngleThreshold; // 0x54
		// [Tooltip] // 0x0000000189763AD0-0x0000000189763B00
		public float updateMoveThreshold; // 0x58
		private int updateCount; // 0x5C
		// [Tooltip] // 0x000000018976CA90-0x000000018976CAC0
		public bool useBackFaceCast; // 0x60
		// [Range] // 0x00000001897757D0-0x0000000189775820
		// [Tooltip] // 0x00000001897757D0-0x0000000189775820
		public float shadeRangeOffset; // 0x64
		public float shadeRangeOffsetMaxDistance; // 0x68
		public float shadeRangeOffsetFadingRange; // 0x6C
		// [Header] // 0x0000000189781BA0-0x0000000189781BD0
		public LayerMask terrainLayer; // 0x70
		// [Tooltip] // 0x000000018978A680-0x000000018978A6B0
		public float detailDist; // 0x74
		// [Tooltip] // 0x00000001897934A0-0x00000001897934D0
		public float minNearPlaneWidth; // 0x78
		// [Tooltip] // 0x000000018979CED0-0x000000018979CF00
		public float nearPlaneOffset; // 0x7C
		public ShadowPerspectiveDirType shadowPerspectiveDirType; // 0x80
		private float minFarCoverRatio; // 0x84
		// [Range] // 0x00000001897A5EA0-0x00000001897A5EF0
		// [Tooltip] // 0x00000001897A5EA0-0x00000001897A5EF0
		public float maxFarCoverRatio; // 0x88
		// [Header] // 0x00000001897B1B30-0x00000001897B1B60
		private static readonly float N_CLAMP; // 0x20
		// [Range] // 0x00000001897BB590-0x00000001897BB5B0
		public float perspectiveFactor; // 0x8C
		// [Range] // 0x0000000189666260-0x0000000189666280
		public float perspectiveOffset; // 0x90
		public bool useFocalDistance; // 0x94
		public float focalDistance; // 0x98
		private Light _light; // 0xA0
		private Camera cam; // 0xA8
		// [Header] // 0x00000001897CA5E0-0x00000001897CA610
		private Matrix4x4 lightView; // 0xB0
		private Matrix4x4 lightProj; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float lightProjN; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float actualProjN; // 0x134
		private float lightProjF; // 0x138
		private Matrix4x4 worldToShadow; // 0x13C
		private Matrix4x4 worldToShadowMap; // 0x17C
		private Vector3[] LVS; // 0x1C0
		private Vector3[] detailLVS; // 0x1C8
		private Vector3[] B; // 0x1D0
		private Bounds B_ls; // 0x1D8
		private Vector4[] LVSHitPoints; // 0x1F0
		private Vector4[] LVSHitPoints_ls; // 0x1F8
		private Vector3 lightProjViewDir; // 0x200
		// [Header] // 0x0000000189AD9AF0-0x0000000189AD9B20
		public bool drawDebug; // 0x20C
		public bool useScaleToFit; // 0x20D
		public bool drawCameraFrustum; // 0x20E
		public bool drawLVS; // 0x20F
		public bool drawDetailLVS; // 0x210
		public bool drawB; // 0x211
		public bool drawLightFrustum; // 0x212
		public bool drawLightPerpViewDir; // 0x213
		public bool drawHitPoints; // 0x214
		public bool drawBoundSpehere; // 0x215
		// [Range] // 0x000000018982E5E0-0x000000018982E600
		public float hitPointSize; // 0x218
		public Vector4 test; // 0x21C
		private Vector3 z0_debug; // 0x22C
		private Vector3 z1_debug; // 0x238
		private Vector3 lastCamMove_ls; // 0x244
		private Quaternion lastCamRot_ls; // 0x250
		private Vector3[] corners_CalcLVS; // 0x260
		public bool isDrawTowLightFrustum; // 0x268
	
		// Properties
		private Matrix4x4 lightSpace { /* [XID] */ /* 0x00000001897F1B30-0x00000001897F1B50 */ get => default; } // 0x0000000184D95460-0x0000000184D95690 
	
		// Nested types
		public enum ProjectionType // TypeDefIndex: 26529
		{
			Ortho = 0,
			Original = 1,
			Optimized = 2
		}
	
		public enum ShadowPerspectiveDirType // TypeDefIndex: 26530
		{
			AlongCameraView = 0,
			AlongMidOfHintPoints = 1
		}
	
		// Constructors
		public DirectionalLispShadowMap() {} // 0x0000000184D96590-0x0000000184D96880
		static DirectionalLispShadowMap() {} // 0x0000000184D964C0-0x0000000184D96590
	
		// Methods
		// [XID] // 0x00000001897F93A0-0x00000001897F93C0
		private void OnEnable() {} // 0x0000000184D95770-0x0000000184D95810
		// [XID] // 0x0000000189800900-0x0000000189800920
		private void OnDisable() {} // 0x0000000184D95690-0x0000000184D95770
		// [XID] // 0x0000000189807ED0-0x0000000189807EF0
		private void Start() {} // 0x0000000184D96040-0x0000000184D96420
		// [XID] // 0x000000018980F810-0x000000018980F830
		private void Update() {} // 0x0000000184D96420-0x0000000184D964C0
		// [XID] // 0x0000000189816EC0-0x0000000189816EE0
		private void LateUpdate() {} // 0x0000000184D93A10-0x0000000184D93B40
		// [XID] // 0x000000018981E750-0x000000018981E770
		private bool CheckCameraTransformChangeForUpdate() => default; // 0x0000000184D95CC0-0x0000000184D96040
		// [XID] // 0x0000000189825CD0-0x0000000189825CF0
		private bool _CompareAngle(float angle, float threshold) => default; // 0x0000000184D92760-0x0000000184D92850
		// [XID] // 0x000000018982D3A0-0x000000018982D3C0
		private void SetShaderSwicher() {} // 0x0000000184D90500-0x0000000184D905F0
		// [XID] // 0x0000000189834AE0-0x0000000189834B00
		private void UpdateLightMatrix() {} // 0x0000000184D93470-0x0000000184D93640
		// [XID] // 0x000000018983C190-0x000000018983C1B0
		private void ApplyLightMatrix() {} // 0x0000000184D92CF0-0x0000000184D930A0
		// [XID] // 0x0000000189843760-0x0000000189843780
		private Vector3 GetLightPerspectiveDirLs() => default; // 0x0000000184D94CF0-0x0000000184D95460
		// [XID] // 0x000000018984AD00-0x000000018984AD20
		private void CalcLightMatrix() {} // 0x0000000184D93E00-0x0000000184D948C0
		// [XID] // 0x0000000189852000-0x0000000189852020
		private void CalcLVS(float clipDist, Vector3[] lvs) {} // 0x0000000184D90130-0x0000000184D90500
		// [XID] // 0x00000001898599C0-0x00000001898599E0
		private void CalcLightBoundingPoints() {} // 0x0000000184D8ECC0-0x0000000184D8EF00
		// [IDTag] // 0x0000000189860B40-0x0000000189860B80
		// [XID] // 0x0000000189860B40-0x0000000189860B80
		private void GetLightPerspectiveParam(float farZ, float farWidth, float nearZ, float nearWidth, out float N) {
			N = default;
		} // 0x0000000184D93870-0x0000000184D93A10
		// [IDTag] // 0x000000018986B2B0-0x000000018986B2F0
		// [XID] // 0x000000018986B2B0-0x000000018986B2F0
		private void GetLightPerspectiveParam(float minBZ, float maxBWidth, float farZ, float farWidth, float nearZ, float nearWidth, out float N, out float ratio) {
			N = default;
			ratio = default;
		} // 0x0000000184D93640-0x0000000184D93870
		// [XID] // 0x00000001898755B0-0x00000001898755D0
		private void CalcLightProjectionOptimized() {} // 0x0000000184D917C0-0x0000000184D924F0
		// [XID] // 0x000000018987D100-0x000000018987D120
		private Vector3 GetHitPointToTerrain(Vector3 v1, Vector3 v2) => default; // 0x0000000184D8EF00-0x0000000184D8F1F0
		// [XID] // 0x0000000189884060-0x0000000189884080
		private Vector3 GetFarLVSHitPointToTerrain(Vector3 v1, Vector3 v2, Vector3 v3) => default; // 0x0000000184D924F0-0x0000000184D92760
		// [XID] // 0x000000018988B7C0-0x000000018988B7E0
		private Vector3 GetHitPointToPlane(Plane plane, Vector3 v1, Vector3 v2) => default; // 0x0000000184D93B40-0x0000000184D93E00
		// [XID] // 0x0000000189892EC0-0x0000000189892EE0
		private Vector3 GetFarLVSHitPointToPlane(Plane plane, Vector3 v1, Vector3 v2, Vector3 v3) => default; // 0x0000000184D8F8A0-0x0000000184D8FB70
		// [XID] // 0x000000018989A530-0x000000018989A550
		private void CalcLVSHitPoints() {} // 0x0000000184D8D8F0-0x0000000184D8ECC0
		// [XID] // 0x00000001898A1850-0x00000001898A1870
		private Bounds CalculateBounds(Vector3[] positions, Matrix4x4 projMat, Matrix4x4 viewMat, bool isClipZ = false /* Metadata: 0x00B0C4A7 */) => default; // 0x0000000184D8D510-0x0000000184D8D8F0
		// [XID] // 0x00000001898A9000-0x00000001898A9020
		private Matrix4x4 GetScaleTranslateToFitOptimized() => default; // 0x0000000184D8F1F0-0x0000000184D8F8A0
		// [XID] // 0x00000001898B0970-0x00000001898B0990
		private float GetMaxDistCulledByFloor(float maxDist, float maxDistDown, Vector3[] LVS) => default; // 0x0000000184D8FB70-0x0000000184D90130
		// [XID] // 0x00000001898B8030-0x00000001898B8050
		private Vector3 ProjectPointToHorizonalPlaneAlongDir(Vector3 point, Vector3 dir, float planeY) => default; // 0x0000000184D930A0-0x0000000184D933A0
		// [XID] // 0x00000001898BF740-0x00000001898BF760
		private void CalcLightProjection() {} // 0x0000000184D8CB70-0x0000000184D8D110
		// [XID] // 0x00000001898C6F80-0x00000001898C6FA0
		private void UpdateLightProjN() {} // 0x0000000184D933A0-0x0000000184D93470
		// [XID] // 0x00000001898CE4A0-0x00000001898CE4C0
		private Vector3 GetZ0_ls() => default; // 0x0000000184D8D110-0x0000000184D8D510
		// [XID] // 0x00000001898D5F30-0x00000001898D5F50
		private float CalcLightProjN() => default; // 0x0000000184D948C0-0x0000000184D94CF0
		// [XID] // 0x00000001898DDBC0-0x00000001898DDBE0
		private float CalcLightProjN2() => default; // 0x0000000184D91570-0x0000000184D917C0
		// [XID] // 0x00000001898E54B0-0x00000001898E54D0
		private Matrix4x4 GetScaleTranslateToFit() => default; // 0x0000000184D92850-0x0000000184D92CF0
		// [XID] // 0x00000001898ECC80-0x00000001898ECCA0
		private void CalDIYUnityShadowMatrix() {} // 0x0000000184D905F0-0x0000000184D91570
		// [XID] // 0x00000001898F4630-0x00000001898F4650
		private void CalBoundingSpereOfFrustrume(Vector3[] frustrumePts) {} // 0x0000000184D95810-0x0000000184D95CC0
	}
}
