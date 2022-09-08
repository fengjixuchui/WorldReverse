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
	public class RendererResourceSofdecPrimeYuv : RendererResource // TypeDefIndex: 7174
	{
		// Fields
		private int width; // 0x30
		private int height; // 0x34
		private bool useUserShader; // 0x38
		private CodecType codecType; // 0x3C
		private Vector4 movieTextureST; // 0x40
		private Vector4 movieChromaTextureST; // 0x50
		private Texture2D[] textureY; // 0x60
		private Texture2D[] textureU; // 0x68
		private Texture2D[] textureV; // 0x70
		private Texture2D[] textureA; // 0x78
		private IntPtr[] nativeTextures; // 0x80
		private int currentTextureSet; // 0x88
		private int drawTextureSet; // 0x8C
		private int playerID; // 0x90
		private bool hasTextureUpdated; // 0x94
		private bool isTextureReady; // 0x95
		private bool hasRenderedNewFrame; // 0x96
	
		// Properties
		private static int NumTextureSets { /* [XID] */ /* 0x0000000189A9BBC0-0x0000000189A9BBE0 */ get => default; } // 0x0000000187A49DE0-0x0000000187A49E80 
		private static bool IsEditor { /* [XID] */ /* 0x0000000189AAA610-0x0000000189AAA630 */ get => default; } // 0x0000000187A49D40-0x0000000187A49DE0 
	
		// Constructors
		public RendererResourceSofdecPrimeYuv() {} // Dummy constructor
		public RendererResourceSofdecPrimeYuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) {} // 0x0000000187A496D0-0x0000000187A49D40
	
		// Methods
		// [XID] // 0x0000000189898490-0x00000001898984B0
		protected override void OnDisposeManaged() {} // 0x0000000187A485B0-0x0000000187A48650
		// [XID] // 0x00000001897F5840-0x00000001897F5860
		protected override void OnDisposeUnmanaged() {} // 0x0000000187A48650-0x0000000187A48CB0
		// [XID] // 0x0000000189AB2490-0x0000000189AB24B0
		public override bool IsPrepared() => default; // 0x0000000187A48350-0x0000000187A48400
		// [XID] // 0x00000001898B6010-0x00000001898B6030
		public override bool ContinuePreparing() => default; // 0x0000000187A48200-0x0000000187A482A0
		// [XID] // 0x0000000189AC1490-0x0000000189AC14B0
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x0000000187A48400-0x0000000187A485B0
		// [XID] // 0x00000001898C5180-0x00000001898C51A0
		public override bool OnPlayerStopForSeek() => default; // 0x0000000187A48CB0-0x0000000187A48D60
		// [XID] // 0x0000000189BCCB40-0x0000000189BCCB60
		public override bool HasRenderedNewFrame() => default; // 0x0000000187A482A0-0x0000000187A48350
		// [XID] // 0x00000001898D4040-0x00000001898D4060
		public override void AttachToPlayer(int playerId) {} // 0x0000000187A48140-0x0000000187A48200
		// [XID] // 0x000000018967FD10-0x000000018967FD30
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop) => default; // 0x0000000187A48E40-0x0000000187A48F90
		// [XID] // 0x000000018968F170-0x000000018968F190
		public override bool UpdateMaterial(UnityEngine.Material material) => default; // 0x0000000187A48F90-0x0000000187A49250
		// [XID] // 0x0000000189687360-0x0000000189687380
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight) {} // 0x0000000187A49250-0x0000000187A49400
		// [XID] // 0x00000001898F2760-0x00000001898F2780
		public override void UpdateTextures() {} // 0x0000000187A49400-0x0000000187A496D0
	}
}
