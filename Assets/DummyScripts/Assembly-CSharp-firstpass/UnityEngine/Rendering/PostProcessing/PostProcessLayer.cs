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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	// [AddComponentMenu] // 0x0000000189977FF0-0x00000001899780C0
	[DisallowMultipleComponent] // 0x0000000189977FF0-0x00000001899780C0
	[ExecuteInEditMode] // 0x0000000189977FF0-0x00000001899780C0
	[ImageEffectAllowedInSceneView] // 0x0000000189977FF0-0x00000001899780C0
	// [RequireComponent] // 0x0000000189977FF0-0x00000001899780C0
	// [RequireComponent] // 0x0000000189977FF0-0x00000001899780C0
	public sealed class PostProcessLayer : MonoBehaviour // TypeDefIndex: 9580
	{
		// Fields
		public Transform volumeTrigger; // 0x18
		public LayerMask volumeLayer; // 0x20
		public bool useVolumeBlending; // 0x24
		public bool stopNaNPropagation; // 0x25
		public float outlineCorrectionWidth; // 0x28
		public float resolutionOutlineCorrectionWidth; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_InnerResolutionScale; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_InnerResolutionScaleRatio; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_InnerResolutionScalePreset; // 0x3C
		private RenderTexture m_FinalTarget; // 0x50
		private int m_ScreenWidth; // 0x58
		private int m_ScreenHeight; // 0x5C
		private RenderTexture m_InnerTarget; // 0x60
		private GameObject m_DummyScreenCameraObject; // 0x68
		private Camera m_DummyScreenCamera; // 0x70
		public bool notHideScreenCamera; // 0x78
		private CommandBuffer m_ScreenCopyCommandBuffer; // 0x80
		private CommandBuffer m_GrabScreenCaptureCommandBuffer; // 0x88
		private RenderTextureWrapper _finalTargetWrapper; // 0x90
		private List<ScreenCapture> m_ScreenCaptureList; // 0x100
		private List<KeyValuePair<GameObject, Action<PostProcessLayer, RenderTexture>>> m_CaptureRequestList; // 0x108
		private RenderTexture m_ScreenCaptureTexture; // 0x110
		private readonly int k_ScreenCaptureReferenceCheckingPeriod; // 0x118
		private int m_ScreenCaptureReferenceCheckingCount; // 0x11C
		private int m_CurrentGrabScreenCaptureFrameId; // 0x120
		private int k_SendScreenCaptureDelayFrameCount; // 0x124
		public Antialiasing antialiasingMode; // 0x128
		public TemporalAntialiasing temporalAntialiasing; // 0x130
		public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing; // 0x138
		public FastApproximateAntialiasing fastApproximateAntialiasing; // 0x140
		public CustomEffect customEffect; // 0x148
		private bool genHalfColorBuffer; // 0x150
		public bool optimizeEffectUpdate; // 0x151
		public bool m_DeferredToonEnable; // 0x152
		public Texture m_DeferredToonRampTex; // 0x158
		public static string s_DeferredToonEnableKeyword; // 0x00
		public PostProcessDebugLayer debugLayer; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PostProcessResources m_Resources; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_ShowToolkit; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_ShowCustomSorter; // 0x171
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<SerializedBundleRef> m_BeforeTransparentBundles; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<SerializedBundleRef> m_BeforeStackBundles; // 0x180
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<SerializedBundleRef> m_AfterStackBundles; // 0x188
		private Dictionary<System.Type, PostProcessBundle> m_Bundles; // 0x1A0
		private PropertySheetFactory m_PropertySheetFactory; // 0x1A8
		private CommandBuffer m_UberCmdBuffer; // 0x1B0
		private CommandBuffer m_FinalCmdBuffer; // 0x1B8
		private CommandBuffer m_GenHalfColorCmdBuffer; // 0x1C0
		private Camera m_Camera; // 0x1C8
		private PostProcessRenderContext m_CurrentContext; // 0x1D0
		private LogHistogram m_LogHistogram; // 0x1D8
		private bool m_SettingsUpdateNeeded; // 0x1E0
		private bool m_IsRenderingInSceneView; // 0x1E1
		private PostProcessVolume m_CurPostProcessVolume; // 0x1E8
		private TargetPool m_TargetPool; // 0x1F0
		private bool m_ForceUpdatePipeline; // 0x1F8
		private bool m_LastTAAActive; // 0x1F9
		private bool m_LastSMAAActive; // 0x1FA
		private bool m_LastFXAAActive; // 0x1FB
		private bool m_LastCustomEffectEnable; // 0x1FC
		private bool m_InnerTargetDirty; // 0x1FD
		private int m_LastLineInterActive; // 0x200
		private static PostProcessLayer k_LastUpdateEntity; // 0x08
		private readonly List<PostProcessEffectRenderer> m_ActiveEffects; // 0x208
		private readonly List<RenderTargetIdentifier> m_Targets; // 0x210
		private RenderTextureWrapper _cachedUberPassSource; // 0x218
		private RenderTextureWrapper _cachedUberPassDestination; // 0x288
		public bool enableReflection; // 0x2F8
		public bool useReflectionBlur; // 0x2F9
		public float reflectionBlurRadius; // 0x2FC
		public int reflectionBlurIterations; // 0x300
		public ReflectionType reflectionType; // 0x304
		public ReflectionQuality reflectionTextureQuality; // 0x308
		public RenderTextureFormat reflectionTextureFormat; // 0x30C
		public float reflectionClipPlaneOffset; // 0x310
		public Transform reflectionTransform; // 0x318
		public LayerMask reflectionLayers; // 0x320
		private GameObject m_ReflectionCameraObject; // 0x328
		private Camera m_ReflectionCamera; // 0x330
		private RenderTexture m_ReflectionTexture; // 0x338
		private RenderTexture m_TempReflectionTexture; // 0x340
		private ReflectionQuality m_oldReflectionTextureQuality; // 0x348
		private bool oldUseReflectionBlur; // 0x34C
		private float oldReflectionBlurRadius; // 0x350
		private int oldReflectionIterations; // 0x354
		private UnityEngine.Material _blurMat; // 0x358
		private UnityEngine.Material _hdr2sdrMat; // 0x360
		private Texture2D _dummyDepthTexture; // 0x368
		private bool _isReflectCameraInitial; // 0x370
		private bool _isReflectCameraCMDDirty; // 0x371
		private CommandBuffer _reflectCamraBeforeOpaque; // 0x378
		private CommandBuffer _reflectCamraAfterEveryThing; // 0x380
		private static int CAMERA_DEPTH_TEXTURE_ID; // 0x10
	
		// Properties
		public bool cameraBufferDirty { /* [XID] */ /* 0x0000000189A282C0-0x0000000189A28300 */ get; /* [XID] */ /* 0x0000000189A32930-0x0000000189A32970 */ set; } // 0x0000000185C0FA30-0x0000000185C0FA90 0x0000000185C107E0-0x0000000185C10840
		public float innerResolutionScale { /* [XID] */ /* 0x0000000189795080-0x00000001897950A0 */ get => default; /* [XID] */ /* 0x0000000189A44A40-0x0000000189A44A60 */ set {} } // 0x0000000185C101D0-0x0000000185C10280 0x0000000185C10C40-0x0000000185C11100
		public float innerResolutionScaleRatio { /* [XID] */ /* 0x0000000189A1EC30-0x0000000189A1EC50 */ get => default; /* [XID] */ /* 0x0000000189A53870-0x0000000189A53890 */ set {} } // 0x0000000185C10120-0x0000000185C101D0 0x0000000185C10970-0x0000000185C10C40
		public int m_InnerResWidth { /* [XID] */ /* 0x0000000189A5B000-0x0000000189A5B040 */ get; /* [XID] */ /* 0x0000000189A65BC0-0x0000000189A65C00 */ private set; } // 0x0000000185C103A0-0x0000000185C10400 0x0000000185C11220-0x0000000185C11280
		public int m_InnerResHeight { /* [XID] */ /* 0x0000000189A702D0-0x0000000189A70310 */ get; /* [XID] */ /* 0x0000000189A7AF70-0x0000000189A7AFB0 */ private set; } // 0x0000000185C10280-0x0000000185C102E0 0x0000000185C11100-0x0000000185C11160
		public int m_InnerResSecondWidth { /* [XID] */ /* 0x0000000189A85680-0x0000000189A856C0 */ get; /* [XID] */ /* 0x0000000189A8FF30-0x0000000189A8FF70 */ private set; } // 0x0000000185C10340-0x0000000185C103A0 0x0000000185C111C0-0x0000000185C11220
		public int m_InnerResSecondHeight { /* [XID] */ /* 0x0000000189A9A8C0-0x0000000189A9A900 */ get; /* [XID] */ /* 0x0000000189AA4B60-0x0000000189AA4BA0 */ private set; } // 0x0000000185C102E0-0x0000000185C10340 0x0000000185C11160-0x0000000185C111C0
		private bool innerResIsSet { /* [XID] */ /* 0x0000000189735A40-0x0000000189735A60 */ get => default; } // 0x0000000185C10000-0x0000000185C10120 
		private bool needResScale { /* [XID] */ /* 0x0000000189ABE6E0-0x0000000189ABE700 */ get => default; } // 0x0000000185C104A0-0x0000000185C10600 
		public bool needCopyToScreen { /* [XID] */ /* 0x00000001895F99A0-0x00000001895F99C0 */ get => default; } // 0x0000000185C10400-0x0000000185C104A0 
		public RenderTexture finalTarget { /* [XID] */ /* 0x0000000189ACD860-0x0000000189ACD880 */ get => default; /* [XID] */ /* 0x0000000189AD5690-0x0000000189AD56B0 */ set {} } // 0x0000000185C0FD60-0x0000000185C0FE00 0x0000000185C10840-0x0000000185C10900
		private int finalTargetWidth { /* [XID] */ /* 0x0000000189ADCFB0-0x0000000189ADCFD0 */ get => default; } // 0x0000000185C0FC50-0x0000000185C0FD60 
		private int finalTargetHeight { /* [XID] */ /* 0x0000000189AE46E0-0x0000000189AE4700 */ get => default; } // 0x0000000185C0FB40-0x0000000185C0FC50 
		public bool DeferredToonShadingEnable { /* [XID] */ /* 0x0000000189B22F30-0x0000000189B22F50 */ get => default; /* [XID] */ /* 0x0000000189B2A600-0x0000000189B2A620 */ set {} } // 0x0000000185C0F7E0-0x0000000185C0F890 0x0000000185C10720-0x0000000185C107E0
		public Texture DeferredToonRampTex { /* [XID] */ /* 0x00000001896C6630-0x00000001896C6650 */ get => default; /* [XID] */ /* 0x0000000189B38FD0-0x0000000189B38FF0 */ set {} } // 0x0000000185C0F730-0x0000000185C0F7E0 0x0000000185C10660-0x0000000185C10720
		public Dictionary<PostProcessEvent, List<SerializedBundleRef>> sortedBundles { /* [XID] */ /* 0x0000000189B40BB0-0x0000000189B40BF0 */ get; /* [XID] */ /* 0x0000000189B4B280-0x0000000189B4B2C0 */ private set; } // 0x0000000185C10600-0x0000000185C10660 0x0000000185C11280-0x0000000185C112F0
		public bool haveBundlesBeenInited { /* [XID] */ /* 0x0000000189B559E0-0x0000000189B55A20 */ get; /* [XID] */ /* 0x0000000189B60560-0x0000000189B605A0 */ private set; } // 0x0000000185C0FE00-0x0000000185C0FE60 0x0000000185C10900-0x0000000185C10970
		public PostProcessRenderContext currentContext { /* [XID] */ /* 0x0000000189B6ABF0-0x0000000189B6AC10 */ get => default; } // 0x0000000185C0FA90-0x0000000185C0FB40 
		public UnityEngine.Material blurMat { /* [XID] */ /* 0x000000018969B010-0x000000018969B030 */ get => default; } // 0x0000000185C0F890-0x0000000185C0FA30 
		public UnityEngine.Material hdr2sdrMat { /* [XID] */ /* 0x00000001896A29A0-0x00000001896A29C0 */ get => default; } // 0x0000000185C0FE60-0x0000000185C10000 
	
		// Nested types
		public enum Antialiasing // TypeDefIndex: 9581
		{
			None = 0,
			FastApproximateAntialiasing = 1,
			miHoYoFXAA = 2,
			SubpixelMorphologicalAntialiasing = 3,
			TemporalAntialiasing = 4
		}
	
		private class ScreenCapture // TypeDefIndex: 9582
		{
			// Fields
			public RenderTexture texture; // 0x10
			public List<KeyValuePair<GameObject, Action<PostProcessLayer, RenderTexture>>> clientList; // 0x18
			public int requestReleaseFrameID; // 0x20
	
			// Constructors
			public ScreenCapture() {} // 0x0000000185E18600-0x0000000185E18660
	
			// Methods
			// [XID] // 0x0000000189705230-0x0000000189705250
			public void ReleaseReference(GameObject obj) {} // 0x0000000185E181C0-0x0000000185E18450
			// [XID] // 0x000000018970C940-0x000000018970C960
			public void CheckReferenceValid() {} // 0x0000000185E17DB0-0x0000000185E18010
			// [XID] // 0x0000000189617EF0-0x0000000189617F10
			private void SetrequestReleaseFrameID(int frameID) {} // 0x0000000185E18550-0x0000000185E18600
			// [XID] // 0x000000018980D4E0-0x000000018980D500
			public void Release() {} // 0x0000000185E18450-0x0000000185E18550
			// [XID] // 0x000000018983E7D0-0x000000018983E7F0
			public bool IsEmpty() => default; // 0x0000000185E180D0-0x0000000185E181C0
			// [XID] // 0x00000001898E0E10-0x00000001898E0E30
			public void DelayRelease() {} // 0x0000000185E18010-0x0000000185E180D0
		}
	
		public static class DeferredToonShadingShaderIDs // TypeDefIndex: 9583
		{
			// Fields
			public static readonly int rampTex; // 0x00
	
			// Constructors
			static DeferredToonShadingShaderIDs() {} // 0x0000000185E00ED0-0x0000000185E00F40
		}
	
		[Serializable]
		public sealed class SerializedBundleRef // TypeDefIndex: 9584
		{
			// Fields
			public string assemblyQualifiedName; // 0x10
			public PostProcessBundle bundle; // 0x18
	
			// Constructors
			public SerializedBundleRef() {} // 0x0000000185E1B8B0-0x0000000185E1B910
		}
	
		public enum ReflectionType // TypeDefIndex: 9585
		{
			Character = 0,
			HLOD = 1
		}
	
		public enum ReflectionQuality // TypeDefIndex: 9586
		{
			RES_5 = 5,
			RES_10 = 10,
			RES_25 = 25,
			RES_33 = 33,
			RES_40 = 40,
			RES_50 = 50,
			RES_75 = 75,
			RES_100 = 100
		}
	
		// Constructors
		public PostProcessLayer() {} // 0x0000000185C0F400-0x0000000185C0F730
		static PostProcessLayer() {} // 0x0000000185C0F360-0x0000000185C0F400
	
		// Methods
		// [XID] // 0x0000000189728C40-0x0000000189728C60
		public void SetInnerResolution(int width, int height, int secondWidth, int secondHeight) {} // 0x0000000185C0C3D0-0x0000000185C0C8C0
		// [XID] // 0x000000018990F010-0x000000018990F030
		public void RequestScreenCapture(GameObject obj, Action<PostProcessLayer, RenderTexture> callback) {} // 0x0000000185C0BAA0-0x0000000185C0BBF0
		// [XID] // 0x0000000189AF3930-0x0000000189AF3950
		public void ReleaseScreenCapture(GameObject obj, RenderTexture texture) {} // 0x0000000185C08EA0-0x0000000185C09050
		// [XID] // 0x0000000189641C40-0x0000000189641C60
		public bool HasUnfinishedScreenCapture() => default; // 0x0000000185C05F80-0x0000000185C06030
		// [XID] // 0x0000000189B02760-0x0000000189B02780
		private void CheckScreenCaptureReferencePeriodically() {} // 0x0000000185C04E20-0x0000000185C05020
		// [XID] // 0x000000018965F940-0x000000018965F960
		private void GrabScreenCapture(PostProcessRenderContext context) {} // 0x0000000185C05860-0x0000000185C05C20
		[DebuggerHidden] // 0x0000000189B116E0-0x0000000189B11720
		// [XID] // 0x0000000189B116E0-0x0000000189B11720
		private IEnumerator SendScreenCaptureAtEndOfFrame() => default; // 0x0000000185C0BE80-0x0000000185C0BF50
		// [XID] // 0x0000000189683690-0x00000001896836B0
		private void SendScreenCapture() {} // 0x0000000185C0BF50-0x0000000185C0C060
		// [XID] // 0x00000001899D2FF0-0x00000001899D3010
		public void EnableTAA() {} // 0x0000000185C05610-0x0000000185C056B0
		// [XID] // 0x00000001895EB510-0x00000001895EB530
		private void OnEnable() {} // 0x0000000185C07940-0x0000000185C07E20
		// [XID] // 0x0000000189B80AE0-0x0000000189B80B00
		public void SetDeferredToonShading() {} // 0x0000000185C0C060-0x0000000185C0C200
		// [XID] // 0x0000000189B886E0-0x0000000189B88700
		private void DisableDeferredToonShading() {} // 0x0000000185C052B0-0x0000000185C053C0
		// [XID] // 0x0000000189B8F980-0x0000000189B8F9A0
		public void Init(PostProcessResources resources) {} // 0x0000000185C064B0-0x0000000185C06650
		// [XID] // 0x0000000189B96F10-0x0000000189B96F30
		public void InitBundles() {} // 0x0000000185C06030-0x0000000185C064B0
		// [XID] // 0x0000000189705B80-0x0000000189705BA0
		private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt) {} // 0x0000000185C0D270-0x0000000185C0D870
		// [XID] // 0x00000001899711E0-0x0000000189971200
		public void SetupInnerResolution() {} // 0x0000000185C0CE30-0x0000000185C0CF60
		// [XID] // 0x0000000189BAD0E0-0x0000000189BAD100
		private void CreateDummyCamera() {} // 0x0000000185C05210-0x0000000185C052B0
		// [XID] // 0x0000000189B32720-0x0000000189B32740
		private void UpdateInnerTarget() {} // 0x0000000185C0D870-0x0000000185C0E540
		// [XID] // 0x00000001897272E0-0x0000000189727300
		private void ReleaseInnerTargetResource() {} // 0x0000000185C08D40-0x0000000185C08EA0
		// [XID] // 0x0000000189BC3CB0-0x0000000189BC3CD0
		private void OnDisable() {} // 0x0000000185C07580-0x0000000185C07940
		// [XID] // 0x0000000189BCB4A0-0x0000000189BCB4C0
		private void Reset() {} // 0x0000000185C0BDD0-0x0000000185C0BE80
		// [XID] // 0x0000000189BD2A30-0x0000000189BD2A50
		private void Update() {} // 0x0000000185C0F0B0-0x0000000185C0F360
		// [XID] // 0x00000001899DD000-0x00000001899DD020
		private void OnDestroy() {} // 0x0000000185C072A0-0x0000000185C07580
		// [XID] // 0x00000001895E6A70-0x00000001895E6A90
		private void OnPreCull() {} // 0x0000000185C08030-0x0000000185C088B0
		// [XID] // 0x00000001896DAE00-0x00000001896DAE20
		private void OnPostGeomRender() {} // 0x0000000185C07E20-0x0000000185C07EC0
		// [XID] // 0x000000018973B750-0x000000018973B770
		private void OnPreRender() {} // 0x0000000185C088B0-0x0000000185C08950
		// [XID] // 0x00000001899D0690-0x00000001899D06B0
		private void RemoveAllEffectCommandBuffersFromCamera() {} // 0x0000000185C09050-0x0000000185C09530
		// [XID] // 0x00000001898DCF90-0x00000001898DCFB0
		private void CheckPipelineDirty(PostProcessRenderContext context) {} // 0x0000000185C04920-0x0000000185C04E20
		// [XID] // 0x000000018960C480-0x000000018960C4A0
		private void BuildCommandBuffers() {} // 0x0000000185C02F90-0x0000000185C03910
		// [XID] // 0x0000000189613BF0-0x0000000189613C10
		private void OnPostRender() {} // 0x0000000185C07EC0-0x0000000185C08030
		public PostProcessBundle GetBundle<T>()
			where T : PostProcessEffectSettings => default;
		// [XID] // 0x00000001898B74D0-0x00000001898B74F0
		public PostProcessBundle GetBundle(System.Type settingsType) => default; // 0x0000000185C05760-0x0000000185C05860
		public bool IsEffectEnableAndSupported<T>(PostProcessRenderContext context)
			where T : PostProcessEffectSettings => default;
		public T GetSettings<T>()
			where T : PostProcessEffectSettings => default;
		// [XID] // 0x0000000189B8C670-0x0000000189B8C690
		internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) {} // 0x0000000185C08950-0x0000000185C08C50
		// [XID] // 0x000000018962A220-0x000000018962A240
		private void SetLegacyCameraFlags(PostProcessRenderContext context) {} // 0x0000000185C0C8C0-0x0000000185C0CC60
		// [XID] // 0x00000001896319A0-0x00000001896319C0
		public void ResetHistory() {} // 0x0000000185C0BBF0-0x0000000185C0BDD0
		// [XID] // 0x00000001896E9AA0-0x00000001896E9AC0
		public void ForceUpdatePipeline() {} // 0x0000000185C056B0-0x0000000185C05760
		// [XID] // 0x0000000189743200-0x0000000189743220
		public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) => default; // 0x0000000185C05EC0-0x0000000185C05F80
		// [XID] // 0x0000000189648290-0x00000001896482B0
		public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) => default; // 0x0000000185C05C20-0x0000000185C05EC0
		// [XID] // 0x000000018964F8F0-0x000000018964F910
		private void SetupContext(PostProcessRenderContext context) {} // 0x0000000185C0CC60-0x0000000185C0CE30
		// [XID] // 0x00000001896572E0-0x0000000189657300
		private void UpdateSettingsIfNeeded(PostProcessRenderContext context) {} // 0x0000000185C0EE10-0x0000000185C0F0B0
		// [XID] // 0x00000001897EADE0-0x00000001897EAE00
		private void CorrectOutlineWidth(PostProcessRenderContext context) {} // 0x0000000185C05020-0x0000000185C05210
		// [XID] // 0x00000001898E1AC0-0x00000001898E1AE0
		public void Render(PostProcessRenderContext context) {} // 0x0000000185C0B040-0x0000000185C0BAA0
		// [XID] // 0x000000018974AD80-0x000000018974ADA0
		private void RenderList(List<SerializedBundleRef> list, PostProcessRenderContext context, string marker) {} // 0x0000000185C09B60-0x0000000185C0A430
		// [XID] // 0x0000000189ADFE00-0x0000000189ADFE20
		private void SetupUberSheet(PostProcessRenderContext context, bool isFinalPass) {} // 0x0000000185C0CF60-0x0000000185C0D200
		// [XID] // 0x0000000189B5BBC0-0x0000000189B5BBE0
		private void RenderEffects(PostProcessRenderContext context) {} // 0x0000000185C09530-0x0000000185C09750
		// [XID] // 0x0000000189684460-0x0000000189684480
		private void RenderUberPass(PostProcessRenderContext context, bool isFinalPass) {} // 0x0000000185C0A5A0-0x0000000185C0B040
		// [XID] // 0x0000000189777310-0x0000000189777330
		private void RenderSMAA(PostProcessRenderContext context) {} // 0x0000000185C0A430-0x0000000185C0A5A0
		// [XID] // 0x00000001896BD420-0x00000001896BD440
		private void RenderFXAA(PostProcessRenderContext context) {} // 0x0000000185C09750-0x0000000185C09B60
		private void RenderEffect<T>(PostProcessRenderContext context, bool swapBufferBefore = false /* Metadata: 0x00AE5C0A */, bool swapBufferAfter = false /* Metadata: 0x00AE5C0B */, bool isFinalPass = false /* Metadata: 0x00AE5C0C */)
			where T : PostProcessEffectSettings {}
		// [XID] // 0x00000001896A9CD0-0x00000001896A9CF0
		private void UpdateReflectionCamera() {} // 0x0000000185C0ED10-0x0000000185C0EE10
		// [XID] // 0x00000001896B0B40-0x00000001896B0B60
		private void DisableReflectionCamera() {} // 0x0000000185C053C0-0x0000000185C05610
		// [XID] // 0x0000000189610BE0-0x0000000189610C00
		private void PreRenderReflectionCamera() {} // 0x0000000185C08C50-0x0000000185C08D40
		// [XID] // 0x000000018993E210-0x000000018993E230
		private void InitialReflectionCameraAndTex() {} // 0x0000000185C06650-0x0000000185C072A0
		// [XID] // 0x00000001896C7210-0x00000001896C7230
		private void BuildReflectionCamera() {} // 0x0000000185C03910-0x0000000185C03F30
		// [XID] // 0x00000001897B6350-0x00000001897B6370
		private void UpdateReflectCameraCMD() {} // 0x0000000185C0E540-0x0000000185C0ED10
		// [XID] // 0x00000001896D5BF0-0x00000001896D5C10
		private static float sgn(float a) => default; // 0x0000000185C112F0-0x0000000185C113C0
		// [XID] // 0x00000001897BE0C0-0x00000001897BE0E0
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) => default; // 0x0000000185C04570-0x0000000185C04920
		// [XID] // 0x00000001897CCD80-0x00000001897CCDA0
		private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane) {} // 0x0000000185C03F30-0x0000000185C04230
		// [XID] // 0x00000001896EBFD0-0x00000001896EBFF0
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) {} // 0x0000000185C04230-0x0000000185C04570
		// [XID] // 0x00000001896F3720-0x00000001896F3740
		public void SetInnerResolutionForStat(int width, int height, int secondWidth, int secondHeight) {} // 0x0000000185C0C200-0x0000000185C0C3D0
	}
}
