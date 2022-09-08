/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x00000001895F6540-0x00000001895F65A0
	// [RequireComponent] // 0x00000001895F6540-0x00000001895F65A0
	public class SkyBoxCapture : MonoBehaviour // TypeDefIndex: 26521
	{
		// Fields
		public static readonly string CAPTURE_SKYBOX_TEX_NAME; // 0x00
		public static readonly string CAPTURE_SKYBOX_TEX_HDR_NAME; // 0x08
		private static readonly int FRAME_THRESH; // 0x10
		public CaptureSkyBoxSizeType CaptureSize; // 0x18
		public int NearPlane; // 0x1C
		// [Header] // 0x0000000189605120-0x0000000189605180
		// [Range] // 0x0000000189605120-0x0000000189605180
		public float UpdateFrequency; // 0x20
		public LayerMask CaptureLayers; // 0x24
		// [Header] // 0x0000000189611480-0x00000001896114E0
		// [Range] // 0x0000000189611480-0x00000001896114E0
		public float reflectionIntensity; // 0x28
		private Camera m_SkyBoxCaptureCamera; // 0x30
		private Camera m_MainCam; // 0x38
		private int m_CaptureSkyBoxPropID; // 0x40
		private int m_CaptureSkyBoxHDRPropID; // 0x44
		private RenderTexture m_CapturedSkyBoxMap; // 0x48
		private bool m_CapturedSkyBoxMapDataValid; // 0x50
		private Vector4 m_CapturedSkyBoxMapHDR; // 0x54
		private float m_PrevTime; // 0x64
		private float m_Ratio; // 0x68
		private RenderTexture m_CapturedTarget; // 0x70
		private CommandBuffer m_CaptureCameraAfterTransparent; // 0x78
		private MHYRenderResourcesSetting _renderResourcesSetting; // 0x80
		private UnityEngine.Material m_CopyMaterial; // 0x88
		private LevelTimeManager m_TimeManager; // 0x90
		private BaseLevel m_LcLevel; // 0x98
		private EnviroSky m_EnviroSky; // 0xA0
		private CaptureFaceType m_curFrameRenderFace; // 0xA8
		private bool m_DoRefresh; // 0xAC
		private Matrix4x4 m_Translate; // 0xB0
		private int m_LastCaptureFrame; // 0xF0
		private static readonly bool useReflection; // 0x14
		private static readonly bool setCapturedSkyBoxMapEvenDataInvalid; // 0x15
		private static readonly Vector3[] kCubemapOrthoBases; // 0x18
		private CommandBuffer _waterRippleCb; // 0xF8
		private RenderTexture _waterRippleRT; // 0x100
		private ParticleSystemRenderer _rainRipplePSRendererFrom; // 0x108
		private ParticleSystemRenderer _rainRipplePSRendererTo; // 0x110
		private bool _haveAddWaterRippleCB; // 0x118
		private bool _haveInitRippleResources; // 0x119
	
		// Properties
		private RenderTextureFormat hdrRTFormat { /* [XID] */ /* 0x000000018961D320-0x000000018961D340 */ get => default; } // 0x0000000184EFC230-0x0000000184EFC300 
		private bool isInEditMode { /* [XID] */ /* 0x0000000189624770-0x0000000189624790 */ get => default; } // 0x0000000184EFC300-0x0000000184EFC3A0 
	
		// Nested types
		public enum CaptureSkyBoxSizeType // TypeDefIndex: 26522
		{
			SMALL = 64,
			Middle = 128,
			Large = 256
		}
	
		public enum CaptureFaceType // TypeDefIndex: 26523
		{
			kFaceNone = 0,
			kFace0 = 1,
			kFace1 = 2,
			kFace2 = 3,
			kFace3 = 4,
			kFace4 = 5,
			kFace5 = 6,
			kFaceAll = 7
		}
	
		private enum CopyPassType // TypeDefIndex: 26524
		{
			RGBMCopy = 0,
			SimpleCopy = 1
		}
	
		private static class Uniforms // TypeDefIndex: 26525
		{
			// Fields
			internal static readonly string WATERRIPPLE_CB_NAME; // 0x00
			internal static readonly int WATERRIPPLES; // 0x08
			internal static readonly int RIPPLE_TEXTURE_SIZE; // 0x0C
			internal static readonly Color WaterRippleClearColor; // 0x10
			internal static readonly float HALF_WIDTH; // 0x20
			internal static readonly string WATER_RIPPLE_NAME; // 0x28
	
			// Constructors
			static Uniforms() {} // 0x0000000184EDCA70-0x0000000184EDCB70
		}
	
		// Constructors
		public SkyBoxCapture() {} // 0x0000000184EFE3D0-0x0000000184EFE530
		static SkyBoxCapture() {} // 0x0000000184EFDD40-0x0000000184EFE3D0
	
		// Methods
		// [XID] // 0x000000018962BEF0-0x000000018962BF10
		private void Awake() {} // 0x0000000184EFA380-0x0000000184EFA4D0
		// [XID] // 0x0000000189633A50-0x0000000189633A70
		private void ForceUpdate(bool isRenderAll = false /* Metadata: 0x00B0C471 */) {} // 0x0000000184EFC160-0x0000000184EFC230
		// [XID] // 0x000000018963B330-0x000000018963B350
		private void OnEnable() {} // 0x0000000184EFD740-0x0000000184EFD7F0
		// [XID] // 0x0000000189642AA0-0x0000000189642AC0
		private void LateUpdate() {} // 0x0000000184EFC3A0-0x0000000184EFC560
		// [XID] // 0x000000018964A190-0x000000018964A1B0
		private void UpdateCaptureCamera() {} // 0x0000000184EFB4A0-0x0000000184EFBC40
		// [XID] // 0x0000000189651850-0x0000000189651870
		private void SetBasisTransposedMatrix(ref Matrix4x4 mat, ref Vector3 inX, ref Vector3 inY, ref Vector3 inZ) {} // 0x0000000184EFB2F0-0x0000000184EFB4A0
		// [XID] // 0x0000000189659090-0x00000001896590B0
		private void EnableCaptureCamera(bool enable) {} // 0x0000000184EF9DD0-0x0000000184EF9EB0
		// [XID] // 0x00000001896607E0-0x0000000189660800
		private static void LinearToGamma(Color inCol, out Color outCol) {
			outCol = default;
		} // 0x0000000184EFA990-0x0000000184EFAAB0
		// [XID] // 0x0000000189668160-0x0000000189668180
		private void SetCaptureCameraClearColor(CubemapFace face) {} // 0x0000000184EFBC40-0x0000000184EFBE10
		// [XID] // 0x000000018966FC20-0x000000018966FC40
		private void OnWeatherChange(EnviroWeatherPreset weatherType) {} // 0x0000000184EFAAB0-0x0000000184EFAB80
		// [XID] // 0x0000000189677480-0x00000001896774A0
		private void OnWeatherChangeFinish(EnviroWeatherPreset weatherType1, EnviroWeatherPreset weatherType2) {} // 0x0000000184EFA2A0-0x0000000184EFA380
		// [XID] // 0x000000018967EA10-0x000000018967EA30
		private void OnWorldShiftOffsetChange(Vector3 offset) {} // 0x0000000184EF9EB0-0x0000000184EF9F90
		// [XID] // 0x00000001896862A0-0x00000001896862C0
		private void InitialCamera() {} // 0x0000000184EFC560-0x0000000184EFCC70
		// [XID] // 0x000000018968E150-0x000000018968E170
		private void SetSkyCaptureForCamera(RenderTexture rt, Camera.SkyCaptureTextureStatus state, bool setRT = true /* Metadata: 0x00B0C472 */) {} // 0x0000000184EFCC70-0x0000000184EFCDC0
		// [XID] // 0x0000000189695A20-0x0000000189695A40
		private void InitialRenderTexture() {} // 0x0000000184EFCDC0-0x0000000184EFD260
		// [XID] // 0x000000018969D110-0x000000018969D130
		private void InitialMaterial() {} // 0x0000000184EFA0B0-0x0000000184EFA2A0
		// [XID] // 0x00000001896A42E0-0x00000001896A4300
		private void InitialTimeVCLevelAndWeather() {} // 0x0000000184EFBE10-0x0000000184EFC160
		// [XID] // 0x00000001896AB970-0x00000001896AB990
		private void OnDisable() {} // 0x0000000184EFD260-0x0000000184EFD740
		// [XID] // 0x00000001896B2B40-0x00000001896B2B60
		private void SetWaterRippleEffect(bool isBegin) {} // 0x0000000184EFDB40-0x0000000184EFDD40
		// [XID] // 0x00000001896BA2C0-0x00000001896BA2E0
		private void GetRainRippleParticleRes(EnviroWeatherPrefab prefab, ref ParticleSystemRenderer pRenderer) {} // 0x0000000184EFA4D0-0x0000000184EFA790
		// [XID] // 0x00000001896C1570-0x00000001896C1590
		private void UpdateWaterRippleProps() {} // 0x0000000184EF9F90-0x0000000184EFA0B0
		// [XID] // 0x00000001896C8C10-0x00000001896C8C30
		private void AddWaterRippleCB() {} // 0x0000000184EFAB80-0x0000000184EFB2F0
		// [XID] // 0x00000001896D0620-0x00000001896D0640
		private void InitWaterRippleRes() {} // 0x0000000184EFD7F0-0x0000000184EFDB40
		// [XID] // 0x00000001896D7AA0-0x00000001896D7AC0
		private void ReleaseWaterRippleRes() {} // 0x0000000184EFA790-0x0000000184EFA990
	}
}
