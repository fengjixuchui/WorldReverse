/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class PostProcessRenderContext // TypeDefIndex: 9594
	{
		// Fields
		private Camera m_Camera; // 0x10
		private RenderTextureFormat m_SourceFormat; // 0x118
		public static readonly RenderTextureFormat[] forceFormat; // 0x00
		private bool m_FlipFinal; // 0x11C
		private bool m_IsFinalPass; // 0x11D
		private bool m_useLDRMediumBuffer; // 0x1E8
		private MediumBufferManager mediumBufferManager; // 0x1F0
		private RenderTexture m_HalfColorBuffer; // 0x1F8
		private RenderTexture m_HalfAlphaBuffer; // 0x200
		private RenderTexture m_HalfColorMediumBuffer; // 0x208
		private RenderTexture m_HalfAlphaMediumBuffer; // 0x210
		private static readonly string halfColorBufferName; // 0x08
		private static readonly string halfAlphaBufferName; // 0x10
		private static readonly string halfColorMediumBufferName; // 0x18
		private static readonly string halfAlphaMediumBufferName; // 0x20
		private int m_ForceFormat; // 0x218
		internal bool needToUpdateUberPass; // 0x21C
		internal bool hasAfterPostprocessObj; // 0x21D
		private PropertySheet _uberSheet; // 0x220
		internal Texture autoExposureTexture; // 0x228
		internal Texture prevExposureTexture; // 0x230
		internal LogHistogram logHistogram; // 0x238
		internal Texture logLut; // 0x240
		internal AutoExposure autoExposure; // 0x248
	
		// Properties
		public Camera camera { /* [XID] */ /* 0x00000001899C67F0-0x00000001899C6810 */ get => default; /* [XID] */ /* 0x000000018982E300-0x000000018982E320 */ set {} } // 0x0000000185E08A80-0x0000000185E08B20 0x0000000185E09C50-0x0000000185E09FB0
		public Camera cameraToCopyScreen { /* [XID] */ /* 0x00000001899D5240-0x00000001899D5280 */ get; /* [XID] */ /* 0x00000001899DF7F0-0x00000001899DF830 */ set; } // 0x0000000185E08A20-0x0000000185E08A80 0x0000000185E09BF0-0x0000000185E09C50
		public PostProcessLayer postProcessLayer { /* [XID] */ /* 0x00000001899E9ED0-0x00000001899E9F10 */ get; /* [XID] */ /* 0x00000001899F4CA0-0x00000001899F4CE0 */ set; } // 0x0000000185E09400-0x0000000185E09460 0x0000000185E0A440-0x0000000185E0A4A0
		public CommandBuffer command { /* [XID] */ /* 0x00000001899FEF90-0x00000001899FEFD0 */ get; /* [XID] */ /* 0x0000000189A09540-0x0000000189A09580 */ set; } // 0x0000000185E08B20-0x0000000185E08B80 0x0000000185E09FB0-0x0000000185E0A010
		public bool pipelineDirty { /* [XID] */ /* 0x0000000189A13D90-0x0000000189A13DD0 */ get; /* [XID] */ /* 0x0000000189A1DE20-0x0000000189A1DE60 */ set; } // 0x0000000185E093A0-0x0000000185E09400 0x0000000185E0A3E0-0x0000000185E0A440
		public RenderTextureWrapper source { /* [XID] */ /* 0x0000000189A28280-0x0000000189A282C0 */ get; /* [XID] */ /* 0x0000000189A328F0-0x0000000189A32930 */ set; } // 0x0000000185E09630-0x0000000185E096D0 0x0000000185E0A630-0x0000000185E0A6D0
		public RenderTextureWrapper destination { /* [XID] */ /* 0x0000000189A3D190-0x0000000189A3D1D0 */ get; /* [XID] */ /* 0x0000000189A47950-0x0000000189A47990 */ set; } // 0x0000000185E08BE0-0x0000000185E08C90 0x0000000185E0A080-0x0000000185E0A130
		public RenderTextureFormat sourceFormat { /* [XID] */ /* 0x0000000189675570-0x0000000189675590 */ get => default; /* [XID] */ /* 0x0000000189A06A70-0x0000000189A06A90 */ set {} } // 0x0000000185E09520-0x0000000185E09630 0x0000000185E0A580-0x0000000185E0A630
		public bool flipFinal { /* [XID] */ /* 0x000000018974D0F0-0x000000018974D110 */ get => default; /* [XID] */ /* 0x00000001897DC080-0x00000001897DC0A0 */ set {} } // 0x0000000185E08DA0-0x0000000185E08E60 0x0000000185E0A250-0x0000000185E0A300
		public bool isFinalPass { /* [XID] */ /* 0x0000000189690AA0-0x0000000189690AC0 */ get => default; } // 0x0000000185E09180-0x0000000185E09230 
		public PostProcessResources resources { /* [XID] */ /* 0x0000000189A77B40-0x0000000189A77B80 */ get; /* [XID] */ /* 0x0000000189A825C0-0x0000000189A82600 */ internal set; } // 0x0000000185E094C0-0x0000000185E09520 0x0000000185E0A510-0x0000000185E0A580
		public PropertySheetFactory propertySheets { /* [XID] */ /* 0x0000000189A8CF80-0x0000000189A8CFC0 */ get; /* [XID] */ /* 0x0000000189A976F0-0x0000000189A97730 */ internal set; } // 0x0000000185E09460-0x0000000185E094C0 0x0000000185E0A4A0-0x0000000185E0A510
		public PostProcessDebugLayer debugLayer { /* [XID] */ /* 0x0000000189AA18E0-0x0000000189AA1920 */ get; /* [XID] */ /* 0x0000000189AAC250-0x0000000189AAC290 */ internal set; } // 0x0000000185E08B80-0x0000000185E08BE0 0x0000000185E0A010-0x0000000185E0A080
		public int width { /* [XID] */ /* 0x0000000189AB6C50-0x0000000189AB6C90 */ get; /* [XID] */ /* 0x0000000189AC1610-0x0000000189AC1650 */ private set; } // 0x0000000185E09840-0x0000000185E098A0 0x0000000185E0A860-0x0000000185E0A8D0
		public int height { /* [XID] */ /* 0x0000000189ACBEA0-0x0000000189ACBEE0 */ get; /* [XID] */ /* 0x0000000189AD6CD0-0x0000000189AD6D10 */ private set; } // 0x0000000185E09120-0x0000000185E09180 0x0000000185E0A300-0x0000000185E0A370
		public int camWidth { /* [XID] */ /* 0x0000000189AE1660-0x0000000189AE16A0 */ get; /* [XID] */ /* 0x0000000189AEBE70-0x0000000189AEBEB0 */ private set; } // 0x0000000185E089C0-0x0000000185E08A20 0x0000000185E09B80-0x0000000185E09BF0
		public int camHeight { /* [XID] */ /* 0x0000000189AF66A0-0x0000000189AF66E0 */ get; /* [XID] */ /* 0x0000000189B00D20-0x0000000189B00D60 */ private set; } // 0x0000000185E08960-0x0000000185E089C0 0x0000000185E09B10-0x0000000185E09B80
		public int xrActiveEye { /* [XID] */ /* 0x0000000189B0B3E0-0x0000000189B0B420 */ get; /* [XID] */ /* 0x0000000189B156B0-0x0000000189B156F0 */ private set; } // 0x0000000185E098A0-0x0000000185E09900 0x0000000185E0A8D0-0x0000000185E0A940
		public int xrSingleEyeWidth { /* [XID] */ /* 0x0000000189B1FFB0-0x0000000189B1FFF0 */ get; /* [XID] */ /* 0x0000000189B2A5C0-0x0000000189B2A600 */ private set; } // 0x0000000185E09960-0x0000000185E099C0 0x0000000185E0A9B0-0x0000000185E0AA20
		public int xrSingleEyeHeight { get; /* [XID] */ /* 0x0000000189B3C0B0-0x0000000189B3C0F0 */ private set; } // 0x0000000185E09900-0x0000000185E09960 0x0000000185E0A940-0x0000000185E0A9B0
		public bool isSceneView { /* [XID] */ /* 0x0000000189B46C80-0x0000000189B46CC0 */ get; /* [XID] */ /* 0x0000000189B51600-0x0000000189B51640 */ internal set; } // 0x0000000185E09230-0x0000000185E09290 0x0000000185E0A370-0x0000000185E0A3E0
		public bool bMotionBlur { /* [XID] */ /* 0x0000000189B5BE90-0x0000000189B5BED0 */ get; /* [XID] */ /* 0x0000000189B663B0-0x0000000189B663F0 */ internal set; } // 0x0000000185E08900-0x0000000185E08960 0x0000000185E09AA0-0x0000000185E09B10
		public bool bDepthOfField { /* [XID] */ /* 0x0000000189B70990-0x0000000189B709D0 */ get; /* [XID] */ /* 0x0000000189B7AD40-0x0000000189B7AD80 */ internal set; } // 0x0000000185E088A0-0x0000000185E08900 0x0000000185E09A30-0x0000000185E09AA0
		public PostProcessLayer.Antialiasing antialiasing { /* [XID] */ /* 0x0000000189B859C0-0x0000000189B85A00 */ get; /* [XID] */ /* 0x0000000189B8F940-0x0000000189B8F980 */ internal set; } // 0x0000000185E08840-0x0000000185E088A0 0x0000000185E099C0-0x0000000185E09A30
		public TemporalAntialiasing temporalAntialiasing { /* [XID] */ /* 0x0000000189B99C80-0x0000000189B99CC0 */ get; /* [XID] */ /* 0x0000000189BA4430-0x0000000189BA4470 */ internal set; } // 0x0000000185E09730-0x0000000185E09790 0x0000000185E0A740-0x0000000185E0A7B0
		public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing { /* [XID] */ /* 0x0000000189BAE5A0-0x0000000189BAE5E0 */ get; /* [XID] */ /* 0x0000000189BB8B60-0x0000000189BB8BA0 */ internal set; } // 0x0000000185E096D0-0x0000000185E09730 0x0000000185E0A6D0-0x0000000185E0A740
		private RenderTextureWrapper finalDestination { /* [XID] */ /* 0x0000000189BC3C70-0x0000000189BC3CB0 */ get; /* [XID] */ /* 0x0000000189BCE440-0x0000000189BCE480 */ set; } // 0x0000000185E08CF0-0x0000000185E08DA0 0x0000000185E0A1A0-0x0000000185E0A250
		public CommandBuffer finalCommandBuffer { /* [XID] */ /* 0x0000000189BD8890-0x0000000189BD88D0 */ get; /* [XID] */ /* 0x00000001895E84D0-0x00000001895E8510 */ set; } // 0x0000000185E08C90-0x0000000185E08CF0 0x0000000185E0A130-0x0000000185E0A1A0
		private RenderTextureFormat m_MediumBufferFormat { /* [XID] */ /* 0x00000001895F2AC0-0x00000001895F2AE0 */ get => default; } // 0x0000000185E09290-0x0000000185E093A0 
		public RenderTexture halfColorBuffer { /* [XID] */ /* 0x00000001899BFB90-0x00000001899BFBB0 */ get => default; } // 0x0000000185E08FC0-0x0000000185E09070 
		public RenderTexture halfAlphaBuffer { /* [XID] */ /* 0x0000000189601D50-0x0000000189601D70 */ get => default; } // 0x0000000185E08E60-0x0000000185E08F10 
		public RenderTexture halfColorMediumBuffer { /* [XID] */ /* 0x0000000189824680-0x00000001898246A0 */ get => default; } // 0x0000000185E09070-0x0000000185E09120 
		public RenderTexture halfAlphaMediumBuffer { /* [XID] */ /* 0x0000000189610D60-0x0000000189610D80 */ get => default; } // 0x0000000185E08F10-0x0000000185E08FC0 
		internal PropertySheet uberSheet { /* [XID] */ /* 0x000000018966A850-0x000000018966A870 */ get => default; /* [XID] */ /* 0x000000018981F6F0-0x000000018981F710 */ set {} } // 0x0000000185E09790-0x0000000185E09840 0x0000000185E0A7B0-0x0000000185E0A860
	
		// Nested types
		private class MediumBufferManager // TypeDefIndex: 9595
		{
			// Fields
			private static readonly int MAX_MEDIUM_BUFFER_COUNT; // 0x00
			private static readonly string[] mediumBuffer_names; // 0x08
			private RenderTextureWrapper[] buffers; // 0x10
			private bool[] usageFlags; // 0x18
			private bool[] usageFootprints; // 0x20
	
			// Constructors
			public MediumBufferManager() {} // 0x0000000185E01DC0-0x0000000185E01EE0
			static MediumBufferManager() {} // 0x0000000185E01BD0-0x0000000185E01DC0
	
			// Methods
			// [XID] // 0x00000001899168A0-0x00000001899168C0
			public void Release() {} // 0x0000000185E01620-0x0000000185E017A0
			// [XID] // 0x0000000189A41DB0-0x0000000189A41DD0
			public void Reset() {} // 0x0000000185E017A0-0x0000000185E01950
			// [XID] // 0x0000000189947060-0x0000000189947080
			public void SetAsUnused(RenderTextureWrapper wrapper) {} // 0x0000000185E01950-0x0000000185E01BD0
			// [XID] // 0x00000001896D08C0-0x00000001896D08E0
			public RenderTextureWrapper Get(PostProcessRenderContext context, bool forceHDR = false /* Metadata: 0x00AE5C54 */) => default; // 0x0000000185E00F40-0x0000000185E01620
		}
	
		// Constructors
		public PostProcessRenderContext() {} // 0x0000000185E08770-0x0000000185E08840
		static PostProcessRenderContext() {} // 0x0000000185E08630-0x0000000185E08770
	
		// Methods
		// [XID] // 0x00000001897FA390-0x00000001897FA3B0
		public void ResetEveryFrame() {} // 0x0000000185E07030-0x0000000185E077B0
		// [XID] // 0x000000018961FC50-0x000000018961FC70
		public void SetResolution(int curWidth, int curHeight, int secondWidth, int secondHeight) {} // 0x0000000185E07AD0-0x0000000185E07C30
		// [XID] // 0x0000000189626FF0-0x0000000189627010
		private void GenerateHalfColorBuffer(bool alwaysGenerate, CommandBuffer genHalfColorCmdBuffer) {} // 0x0000000185E05A80-0x0000000185E06780
		// [XID] // 0x00000001896BA690-0x00000001896BA6B0
		public void SetupBuffer(RenderTextureWrapper source, CommandBuffer genHalfColorCmdBuffer, CommandBuffer finalCommandBuffer, RenderTextureWrapper finalDestination, bool flipFinal = true /* Metadata: 0x00AE5C4D */, bool useLDRMediumBuffer = false /* Metadata: 0x00AE5C4E */, bool genHalfColor = false /* Metadata: 0x00AE5C4F */) {} // 0x0000000185E07C30-0x0000000185E080A0
		// [XID] // 0x0000000189636640-0x0000000189636660
		public void ToLDR() {} // 0x0000000185E08580-0x0000000185E08630
		// [XID] // 0x00000001896E79E0-0x00000001896E7A00
		private void DestinationToLDRIfNeeded() {} // 0x0000000185E057D0-0x0000000185E05A80
		// [XID] // 0x0000000189645330-0x0000000189645350
		public void ToHDR() {} // 0x0000000185E084D0-0x0000000185E08580
		// [XID] // 0x00000001896A01B0-0x00000001896A01D0
		private void DestinationToHDRIfNeeded() {} // 0x0000000185E05520-0x0000000185E057D0
		// [XID] // 0x0000000189955CE0-0x0000000189955D00
		public void SetFinalDestination() {} // 0x0000000185E077B0-0x0000000185E07AD0
		// [XID] // 0x00000001899EC1B0-0x00000001899EC1D0
		public void SwapBuffer() {} // 0x0000000185E080A0-0x0000000185E08360
		// [XID] // 0x0000000189662EA0-0x0000000189662EC0
		public void SwapHalfColorBuffer() {} // 0x0000000185E08360-0x0000000185E084D0
		// [XID] // 0x000000018966AA10-0x000000018966AA30
		public void CopyDestinationToFinal() {} // 0x0000000185E04F60-0x0000000185E05520
		// [XID] // 0x000000018966EBE0-0x000000018966EC00
		public void BindCommandBuffer(CameraEvent evt, CommandBuffer buffer) {} // 0x0000000185E04E30-0x0000000185E04F60
		// [XID] // 0x0000000189679F40-0x0000000189679F60
		public static void ReleaseTemporaryTexture(ref RenderTexture texture) {} // 0x0000000185E06E90-0x0000000185E06F80
		// [XID] // 0x0000000189824B00-0x0000000189824B20
		public void ReleaseBuffers() {} // 0x0000000185E06CD0-0x0000000185E06D80
		// [XID] // 0x000000018980E030-0x000000018980E050
		public bool IsTemporalAntialiasingActive() => default; // 0x0000000185E069E0-0x0000000185E06B40
		// [XID] // 0x0000000189690C60-0x0000000189690C80
		public bool IsSubpixelMorphologicalAntialiasingActive() => default; // 0x0000000185E06880-0x0000000185E069E0
		// [XID] // 0x000000018967CC80-0x000000018967CCA0
		public bool IsDebugOverlayEnabled(DebugOverlay overlay) => default; // 0x0000000185E06780-0x0000000185E06880
		// [XID] // 0x000000018972ED70-0x000000018972ED90
		public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet = null, int pass = 0 /* Metadata: 0x00AE5C50 */) {} // 0x0000000185E06B40-0x0000000185E06CD0
		// [XID] // 0x0000000189933230-0x0000000189933250
		public void ReleaseHalfRes() {} // 0x0000000185E06D80-0x0000000185E06E90
		// [XID] // 0x00000001896AE190-0x00000001896AE1B0
		internal void Release() {} // 0x0000000185E06F80-0x0000000185E07030
	}
}
