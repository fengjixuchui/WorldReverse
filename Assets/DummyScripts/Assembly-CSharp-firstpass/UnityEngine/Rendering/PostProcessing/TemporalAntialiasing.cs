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
	[Serializable]
	public sealed class TemporalAntialiasing // TypeDefIndex: 9536
	{
		// Fields
		// [Range] // 0x00000001899735E0-0x0000000189973630
		// [Tooltip] // 0x00000001899735E0-0x0000000189973630
		public float jitterSpread; // 0x10
		// [Range] // 0x000000018997F170-0x000000018997F1C0
		// [Tooltip] // 0x000000018997F170-0x000000018997F1C0
		public float sharpness; // 0x14
		// [Range] // 0x000000018998B720-0x000000018998B780
		// [Tooltip] // 0x000000018998B720-0x000000018998B780
		public float stationaryBlending; // 0x18
		// [Range] // 0x00000001899977A0-0x00000001899977F0
		// [Tooltip] // 0x00000001899977A0-0x00000001899977F0
		public float motionBlending; // 0x1C
		public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc; // 0x20
		public bool needToUpdate; // 0x58
		private readonly RenderTargetIdentifier[] m_Mrt; // 0x60
		private bool m_ResetHistory; // 0x68
		private const int k_SampleCount = 8; // Metadata: 0x00AE5B6D
		private int m_SampleIndex; // 0x6C
		private const int k_NumEyes = 2; // Metadata: 0x00AE5B71
		private const int k_NumHistoryTextures = 2; // Metadata: 0x00AE5B75
		private readonly RenderTexture[][] m_HistoryTextures; // 0x70
		private readonly RenderTexture[][] m_HistoryIDs; // 0x78
		public TAAQuality quality; // 0x80
		private int[] m_HistoryPingPong; // 0x88
		private static readonly string[] TAA_RT_HIST_NAMES; // 0x00
		private static readonly string[] TAA_RT_NAMES; // 0x08
	
		// Properties
		public Vector4 jitter { /* [XID] */ /* 0x00000001899CDC50-0x00000001899CDC90 */ get; /* [XID] */ /* 0x00000001899D81B0-0x00000001899D81F0 */ private set; } // 0x0000000185E25FF0-0x0000000185E26060 0x0000000185E26190-0x0000000185E26200
		public Vector4 preJitter { /* [XID] */ /* 0x00000001899E28B0-0x00000001899E28F0 */ get; /* [XID] */ /* 0x00000001899ECEC0-0x00000001899ECF00 */ private set; } // 0x0000000185E26060-0x0000000185E260D0 0x0000000185E26200-0x0000000185E26270
		public CameraEvent commandBufferEvent { /* [XID] */ /* 0x00000001899F78F0-0x00000001899F7930 */ get; /* [XID] */ /* 0x0000000189A01B20-0x0000000189A01B60 */ private set; } // 0x0000000185E25F30-0x0000000185E25F90 0x0000000185E260D0-0x0000000185E26130
		public CommandBuffer commandBuffer { /* [XID] */ /* 0x0000000189A0C3B0-0x0000000189A0C3F0 */ get; /* [XID] */ /* 0x0000000189A168E0-0x0000000189A16920 */ private set; } // 0x0000000185E25F90-0x0000000185E25FF0 0x0000000185E26130-0x0000000185E26190
	
		// Nested types
		private enum Pass // TypeDefIndex: 9537
		{
			SolverDilate = 0,
			SolverNoDilate = 1
		}
	
		public enum TAAQuality // TypeDefIndex: 9538
		{
			TAALow = 0,
			TAAHigh = 1
		}
	
		// Constructors
		public TemporalAntialiasing() {} // 0x0000000185E25E10-0x0000000185E25F30
		static TemporalAntialiasing() {} // 0x0000000185E25BF0-0x0000000185E25E10
	
		// Methods
		// [XID] // 0x0000000189A20F60-0x0000000189A20F80
		public void Init() {} // 0x0000000185E24300-0x0000000185E24460
		// [XID] // 0x0000000189A28300-0x0000000189A28320
		public bool IsSupported() => default; // 0x0000000185E24460-0x0000000185E24530
		// [XID] // 0x0000000189B32700-0x0000000189B32720
		internal DepthTextureMode GetCameraFlags() => default; // 0x0000000185E23CE0-0x0000000185E23D80
		// [XID] // 0x0000000189A37460-0x0000000189A37480
		internal void ResetHistory() {} // 0x0000000185E25B50-0x0000000185E25BF0
		// [XID] // 0x0000000189A3EC30-0x0000000189A3EC50
		private Vector2 GenerateRandomOffset() => default; // 0x0000000185E23B10-0x0000000185E23C20
		// [XID] // 0x0000000189A462E0-0x0000000189A46300
		public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) => default; // 0x0000000185E23FA0-0x0000000185E24300
		// [XID] // 0x00000001897CA910-0x00000001897CA930
		public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) {} // 0x0000000185E23260-0x0000000185E233E0
		// [XID] // 0x00000001897B3A00-0x00000001897B3A20
		public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) {} // 0x0000000185E233E0-0x0000000185E23950
		// [XID] // 0x0000000189A5CAA0-0x0000000189A5CAC0
		private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context, bool bID) {} // 0x0000000185E23950-0x0000000185E23B10
		// [XID] // 0x0000000189A64410-0x0000000189A64430
		private ulong GetHistoryLifeTimeMask(int id) => default; // 0x0000000185E23EE0-0x0000000185E23FA0
		// [XID] // 0x00000001898BFAE0-0x00000001898BFB00
		private ulong GetAccumulateLifeTimeMask(int id) => default; // 0x0000000185E23C20-0x0000000185E23CE0
		// [XID] // 0x0000000189893C90-0x0000000189893CB0
		private RenderTexture CheckHistory(int id, PostProcessRenderContext context, bool bID) => default; // 0x0000000185E22520-0x0000000185E23260
		// [XID] // 0x0000000189A7AFB0-0x0000000189A7AFD0
		public RenderTexture GetCurrentRT(PostProcessRenderContext context) => default; // 0x0000000185E23D80-0x0000000185E23EE0
		// [XID] // 0x00000001897628D0-0x00000001897628F0
		internal void Render(PostProcessRenderContext context) {} // 0x0000000185E24F30-0x0000000185E25B50
		// [XID] // 0x0000000189A89E40-0x0000000189A89E60
		internal void Release() {} // 0x0000000185E24B70-0x0000000185E24F30
		// [XID] // 0x000000018978F1E0-0x000000018978F200
		internal void ReleaseTextureTemp(int id, PostProcessRenderContext context) {} // 0x0000000185E24530-0x0000000185E247B0
		// [XID] // 0x0000000189A99280-0x0000000189A992A0
		internal void ReleaseTexture() {} // 0x0000000185E247B0-0x0000000185E24B70
	}
}
