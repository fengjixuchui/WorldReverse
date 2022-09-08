/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using CriMana;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CriMana.Detail
{
	public class RendererResourceSofdecPrimeYuvRawData : RendererResource // TypeDefIndex: 7175
	{
		// Fields
		private int width; // 0x30
		private int height; // 0x34
		private int chromaWidth; // 0x38
		private int chromaHeight; // 0x3C
		private bool useUserShader; // 0x40
		private CodecType codecType; // 0x44
		private Vector4 movieTextureST; // 0x48
		private Vector4 movieChromaTextureST; // 0x58
		private Texture2D[][] textures; // 0x68
		private int currentTextureSet; // 0x70
		private int drawTextureSet; // 0x74
		private IntPtr[] nativePixels; // 0x78
		private int playerID; // 0x80
		private bool hasTextureUpdated; // 0x84
		private bool isTextureReady; // 0x85
	
		// Properties
		private static int NumTextureSets { /* [XID] */ /* 0x00000001896BC9E0-0x00000001896BCA00 */ get => default; } // 0x0000000187A480A0-0x0000000187A48140 
	
		// Constructors
		public RendererResourceSofdecPrimeYuvRawData() {} // Dummy constructor
		public RendererResourceSofdecPrimeYuvRawData(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) {} // 0x0000000187A47900-0x0000000187A480A0
	
		// Methods
		// [XID] // 0x00000001896C3F60-0x00000001896C3F80
		protected override void OnDisposeManaged() {} // 0x0000000187A46B50-0x0000000187A46BF0
		// [XID] // 0x00000001896CB3B0-0x00000001896CB3D0
		protected override void OnDisposeUnmanaged() {} // 0x0000000187A46BF0-0x0000000187A46CF0
		// [XID] // 0x0000000189910650-0x0000000189910670
		public override bool IsPrepared() => default; // 0x0000000187A468F0-0x0000000187A469A0
		// [XID] // 0x00000001896DA440-0x00000001896DA460
		public override bool ContinuePreparing() => default; // 0x0000000187A46850-0x0000000187A468F0
		// [XID] // 0x00000001896E1BA0-0x00000001896E1BC0
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x0000000187A469A0-0x0000000187A46B50
		// [XID] // 0x00000001896E90D0-0x00000001896E90F0
		public override void AttachToPlayer(int playerId) {} // 0x0000000187A465C0-0x0000000187A46670
		// [XID] // 0x000000018992EA70-0x000000018992EA90
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop) => default; // 0x0000000187A46CF0-0x0000000187A46E40
		// [XID] // 0x00000001896FF5B0-0x00000001896FF5D0
		public override bool UpdateMaterial(UnityEngine.Material material) => default; // 0x0000000187A46E40-0x0000000187A47190
		// [XID] // 0x00000001896F7AB0-0x00000001896F7AD0
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight) {} // 0x0000000187A47190-0x0000000187A47350
		// [XID] // 0x0000000189944EB0-0x0000000189944ED0
		public override void UpdateTextures() {} // 0x0000000187A47350-0x0000000187A47900
		// [XID] // 0x000000018970E250-0x000000018970E270
		private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma) {} // 0x0000000187A46670-0x0000000187A46850
	}
}
