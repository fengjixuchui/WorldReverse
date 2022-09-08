/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x00000001898FBE20-0x00000001898FBE70
	public class DirectionLightShadowLayerShadowMap : MonoBehaviour // TypeDefIndex: 26531
	{
		// Fields
		// [Header] // 0x00000001899080D0-0x0000000189908100
		public bool IsRenderTwice; // 0x18
		public int UnitTextureSize; // 0x1C
		public float BoundScale; // 0x20
		public float MainCameraFrustumDist; // 0x24
		public float DistanceThresh; // 0x28
		public int CullingLayer; // 0x2C
		public int RenderTextureSize; // 0x30
		public RenderTextureFormat Format; // 0x34
		public float ShadowLayerBias; // 0x38
		public float EntiyRenderInAvatarLayerBias; // 0x3C
		public float EntiyRenderInAvatarLayerNormalBias; // 0x40
		public float EntiyRenderInSceneLayerBias; // 0x44
		public float EntiyRenderInSceneLayerNormalBias; // 0x48
		public bool UseBigTexture; // 0x4C
		private int BigRenderTextureSize; // 0x50
		private int BigUnitTextureSize; // 0x54
		private RenderTextureWrapper _shadowLayerRenderTexture; // 0x58
		private Light _sceneLight; // 0x60
		private Camera _camForAvatarLayer; // 0x68
		private Camera _mainCam; // 0x70
		private Vector3[] _cornerPoints; // 0x78
		private static readonly string UsinghadowLayer_ShaderVarName; // 0x00
		private static readonly string ShadowLayerShadowMapName_ShaderVarName; // 0x08
		private static readonly string ShadowLayerWorldToShadow_ShaderVarName; // 0x10
		private static readonly string ShadowLayerWorldToShadowMap_ShaderVarName; // 0x18
		private static readonly string ShadowLayerBias_ShaderVarName; // 0x20
		private static readonly string AVATAR_BIAS_ShaderVarName; // 0x28
		private static readonly string AVATAR_NORMAL_BIAS_ShaderVarName; // 0x30
		private int UsinghadowLayer_ShaderVarName_ID; // 0x80
		private int ShadowLayerShadowMapName_ShaderVarName_ID; // 0x84
		private int ShadowLayerWorldToShadow_ShaderVarName_ID; // 0x88
		private int ShadowLayerWorldToShadowMap_ShaderVarName_ID; // 0x8C
		private int ShadowLayerBias_ShaderVarName_ID; // 0x90
		private int AVATAR_BIAS_ShaderVarName_ID; // 0x94
		private int AVATAR_NORMAL_BIAS_ShaderVarName_ID; // 0x98
		private Matrix4x4 _shadowLayerWorld2Shadow; // 0x9C
		private Matrix4x4 _shadowLayerWorld2ShadowMap; // 0xDC
		private bool _isInitialRight; // 0x11C
		private List<Renderer> _shadowLayerRenderers; // 0x120
		private Bounds _entityBounds; // 0x128
		private BaseEntity _localAvatarEntity; // 0x140
		private List<Bounds> _selectEntitesBounds; // 0x148
		private List<Renderer[]> _selectEntitesRenders; // 0x150
		private List<List<int>> _clusterIndex; // 0x158
		private List<Bounds> _clusterBounds; // 0x160
		// [Header] // 0x0000000189910CA0-0x0000000189910CD0
		public QualityType SmallShadowMapQuality; // 0x168
		public bool UseBlur; // 0x16C
		public bool UseCustomSize; // 0x16D
		public RenderTextureFormat DrawShadowRenderTexFormat; // 0x170
		public int DrawShadowRenderTexDepth; // 0x174
		public Color DrawShadowClearColor; // 0x178
		private static readonly float HighQualityBlurShaderBaseImageSize; // 0x38
		private static readonly string CurCameraSpaceShadowMap_ShaderVarName; // 0x40
		private static readonly string CurCameraSpaceWorldToShadow_ShaderVarName; // 0x48
		private static readonly string SrcRenderRect_ShaderVarName; // 0x50
		private static readonly string DstRenderRect_ShaderVarName; // 0x58
		private static readonly string ScalerInBlur_ShaderVarName; // 0x60
		private int CurCameraSpaceShadowMap_ShaderVarName_ID; // 0x188
		private int CurCameraSpaceWorldToShadow_ShaderVarName_ID; // 0x18C
		private int SrcRenderRect_ShaderVarName_ID; // 0x190
		private int DstRenderRect_ShaderVarName_ID; // 0x194
		private int ScalerInBlur_ShaderVarName_ID; // 0x198
		private Shader MultipleGaussPassFilterShaderHQ; // 0x1A0
		private UnityEngine.Material MultipleGaussPassFilterHQ; // 0x1A8
		private Shader DrawShadowShader; // 0x1B0
		private UnityEngine.Material DrawShadowMat; // 0x1B8
		private Shader CopyShader; // 0x1C0
		private UnityEngine.Material CopyMat; // 0x1C8
		private RenderTextureWrapper _temp_buffer; // 0x1D0
		private RenderTextureWrapper _renderTexture; // 0x1D8
		private float _aspectRatio; // 0x1E0
		private Rect _srcPixelRect; // 0x1E4
		private Rect _dstPixelRect; // 0x1F4
		private Matrix4x4 _curCameraSpaceWorld2Shadow; // 0x204
		private CommandBuffer _cb; // 0x248
		private bool _haveRemoveCB; // 0x250
		private Matrix4x4 ConvertWorldToShadowMap; // 0x254
		// [Header] // 0x000000018991A2E0-0x000000018991A310
		public bool ShowBoudingBox; // 0x294
		private Vector3[] corners_CalcLVS; // 0x298
	
		// Nested types
		public enum QualityType // TypeDefIndex: 26532
		{
			Low = 0,
			Medium = 1,
			High = 2
		}
	
		// Constructors
		public DirectionLightShadowLayerShadowMap() {} // 0x0000000184D8C820-0x0000000184D8CB70
		static DirectionLightShadowLayerShadowMap() {} // 0x0000000184D8C6A0-0x0000000184D8C820
	
		// Methods
		// [XID] // 0x0000000189923100-0x0000000189923120
		private void OnEnable() {} // 0x0000000184D8C500-0x0000000184D8C600
		// [XID] // 0x000000018992A8D0-0x000000018992A8F0
		private void OnDisable() {} // 0x0000000184D8C400-0x0000000184D8C500
		// [XID] // 0x0000000189931F50-0x0000000189931F70
		public void Awake() {} // 0x0000000184D86BC0-0x0000000184D87030
		// [XID] // 0x0000000189939880-0x00000001899398A0
		public void Start() {} // 0x0000000184D8C600-0x0000000184D8C6A0
		// [XID] // 0x0000000189940B70-0x0000000189940B90
		private void LateUpdate() {} // 0x0000000184D8B750-0x0000000184D8C0B0
		// [XID] // 0x0000000189948470-0x0000000189948490
		private void OnDestroy() {} // 0x0000000184D8C310-0x0000000184D8C400
		// [XID] // 0x000000018994FBB0-0x000000018994FBD0
		public List<Renderer> GetShadowLayerRenderers() => default; // 0x0000000184D88AF0-0x0000000184D88BA0
		// [XID] // 0x00000001899571D0-0x00000001899571F0
		private void CalcFrustrumeInWorldSpace(float clipDist, Vector3[] lvs) {} // 0x0000000184D87C10-0x0000000184D87F70
		// [XID] // 0x000000018995ECC0-0x000000018995ECE0
		private void SetLightCameraParameters() {} // 0x0000000184D8AFA0-0x0000000184D8B750
		// [XID] // 0x0000000189966440-0x0000000189966460
		private void CalStableProjectionMatrix() {} // 0x0000000184D89A60-0x0000000184D89F70
		// [XID] // 0x000000018996D860-0x000000018996D880
		private void CollectShadowLayerBoundsAndRenderers(IEnumerable<BaseEntity> entites) {} // 0x0000000184D8A820-0x0000000184D8AE00
		// [XID] // 0x0000000189975400-0x0000000189975420
		private void ClusterRendersBoundingBoxs() {} // 0x0000000184D87710-0x0000000184D878A0
		// [XID] // 0x000000018997C5C0-0x000000018997C5E0
		private void FindNearBoundsAndCombine() {} // 0x0000000184D89F70-0x0000000184D8A730
		// [XID] // 0x0000000189984320-0x0000000189984340
		private void GenerateCommandBuffer() {} // 0x0000000184D88BA0-0x0000000184D89A60
		// [XID] // 0x000000018998BE10-0x000000018998BE30
		private void AddCommandBuffer() {} // 0x0000000184D874C0-0x0000000184D87580
		// [XID] // 0x0000000189993A00-0x0000000189993A20
		private void RemoveCommandBuffer() {} // 0x0000000184D8A730-0x0000000184D8A820
		// [XID] // 0x000000018999B360-0x000000018999B380
		private void CalBoundingInPic(Bounds b) {} // 0x0000000184D87F70-0x0000000184D887D0
		// [XID] // 0x00000001899A2B20-0x00000001899A2B40
		private UnityEngine.Material CheckShaderAndCreateMaterial(Shader s, UnityEngine.Material m2Create) => default; // 0x0000000184D87030-0x0000000184D874C0
		// [XID] // 0x00000001899AA4F0-0x00000001899AA510
		private void CheckResources() {} // 0x0000000184D88900-0x0000000184D88AF0
		// [XID] // 0x00000001899B1ED0-0x00000001899B1EF0
		private void ShaderVarNameToID() {} // 0x0000000184D8C0B0-0x0000000184D8C310
		// [XID] // 0x00000001899B9250-0x00000001899B9270
		private void CreateRenderTextures(int w, int h) {} // 0x0000000184D87580-0x0000000184D87710
		// [XID] // 0x00000001899C0BA0-0x00000001899C0BC0
		private void ReleaseRenderTextures() {} // 0x0000000184D887D0-0x0000000184D88900
		// [XID] // 0x00000001899C82A0-0x00000001899C82C0
		private void DoBlurInCB() {} // 0x0000000184D8AE00-0x0000000184D8AFA0
		// [XID] // 0x00000001899CFD00-0x00000001899CFD20
		private void BlurInCB(RenderTexture source, RenderTexture destination, UnityEngine.Material material, int level, float offsetScale = 1f /* Metadata: 0x00B0C4BC */) {} // 0x0000000184D878A0-0x0000000184D87C10
	}
}
