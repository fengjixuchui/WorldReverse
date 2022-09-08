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
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	public sealed class PostProcessDebugLayer // TypeDefIndex: 9573
	{
		// Fields
		public LightMeterMonitor lightMeter; // 0x10
		public HistogramMonitor histogram; // 0x18
		public WaveformMonitor waveform; // 0x20
		public VectorscopeMonitor vectorscope; // 0x28
		private Dictionary<MonitorType, Monitor> m_Monitors; // 0x30
		private int frameWidth; // 0x38
		private int frameHeight; // 0x3C
		public OverlaySettings overlaySettings; // 0x50
	
		// Properties
		public RenderTexture debugOverlayTarget { /* [XID] */ /* 0x000000018982FBB0-0x000000018982FBF0 */ get; /* [XID] */ /* 0x000000018983A150-0x000000018983A190 */ private set; } // 0x0000000185C00F90-0x0000000185C00FF0 0x0000000185C010B0-0x0000000185C01110
		public bool debugOverlayActive { /* [XID] */ /* 0x0000000189844B10-0x0000000189844B50 */ get; /* [XID] */ /* 0x000000018984EEC0-0x000000018984EF00 */ private set; } // 0x0000000185C00F30-0x0000000185C00F90 0x0000000185C01050-0x0000000185C010B0
		public DebugOverlay debugOverlay { /* [XID] */ /* 0x0000000189859360-0x00000001898593A0 */ get; /* [XID] */ /* 0x0000000189863890-0x00000001898638D0 */ private set; } // 0x0000000185C00FF0-0x0000000185C01050 0x0000000185C01110-0x0000000185C01170
	
		// Nested types
		[Serializable]
		public class OverlaySettings // TypeDefIndex: 9574
		{
			// Fields
			// [Range] // 0x00000001898BEDE0-0x00000001898BEE00
			public float motionColorIntensity; // 0x10
			// [Range] // 0x00000001898C66D0-0x00000001898C66F0
			public int motionGridSize; // 0x14
			public ColorBlindnessType colorBlindnessType; // 0x18
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float colorBlindnessStrength; // 0x1C
	
			// Constructors
			public OverlaySettings() {} // 0x0000000185BFDA90-0x0000000185BFDB10
		}
	
		// Constructors
		public PostProcessDebugLayer() {} // 0x0000000185C00ED0-0x0000000185C00F30
	
		// Methods
		// [XID] // 0x000000018986D7E0-0x000000018986D800
		internal void OnEnable() {} // 0x0000000185BFF4F0-0x0000000185BFF7A0
		// [XID] // 0x00000001899AE8C0-0x00000001899AE8E0
		internal void OnDisable() {} // 0x0000000185BFF320-0x0000000185BFF4F0
		// [XID] // 0x0000000189990180-0x00000001899901A0
		private void DestroyDebugOverlayTarget() {} // 0x0000000185BFEE50-0x0000000185BFEF80
		// [XID] // 0x00000001898B9610-0x00000001898B9630
		public void RequestMonitorPass(MonitorType monitor) {} // 0x0000000185C00D00-0x0000000185C00DD0
		// [XID] // 0x000000018988B030-0x000000018988B050
		public void RequestDebugOverlay(DebugOverlay mode) {} // 0x0000000185C00C20-0x0000000185C00D00
		// [XID] // 0x0000000189988970-0x0000000189988990
		public void SetFrameSize(int width, int height) {} // 0x0000000185C00DD0-0x0000000185C00ED0
		// [XID] // 0x0000000189899E70-0x0000000189899E90
		public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet = null, int pass = 0 /* Metadata: 0x00AE5BF9 */) {} // 0x0000000185BFF7A0-0x0000000185BFFD20
		// [XID] // 0x00000001898A10A0-0x00000001898A10C0
		internal DepthTextureMode GetCameraFlags() => default; // 0x0000000185BFF1D0-0x0000000185BFF320
		// [XID] // 0x00000001898A85A0-0x00000001898A85C0
		internal void RenderMonitors(PostProcessRenderContext context) {} // 0x0000000185BFFD20-0x0000000185C003C0
		// [XID] // 0x0000000189B67B90-0x0000000189B67BB0
		internal void RenderSpecialOverlays(PostProcessRenderContext context) {} // 0x0000000185C003C0-0x0000000185C00C20
		// [XID] // 0x00000001898B7770-0x00000001898B7790
		internal void EndFrame() {} // 0x0000000185BFEF80-0x0000000185BFF1D0
	}
}
