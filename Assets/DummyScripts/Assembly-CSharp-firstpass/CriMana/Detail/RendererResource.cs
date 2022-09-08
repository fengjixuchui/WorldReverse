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
	public abstract class RendererResource : IDisposable // TypeDefIndex: 7165
	{
		// Fields
		private bool disposed; // 0x10
		protected Shader shader; // 0x18
		protected UnityEngine.Material currentMaterial; // 0x20
		protected bool hasAlpha; // 0x28
		protected bool additive; // 0x29
		protected bool applyTargetAlpha; // 0x2A
		protected bool ui; // 0x2B
	
		// Properties
		protected bool isLinearSpace { /* [XID] */ /* 0x00000001899D2290-0x00000001899D22B0 */ get; } // 0x0000000187A4B6F0-0x0000000187A4B850 
	
		// Constructors
		protected RendererResource() {} // 0x0000000187A4B680-0x0000000187A4B6F0
	
		// Methods
		~RendererResource() {} // 0x0000000187A4AB70-0x0000000187A4AC20
		// [IDTag] // 0x000000018973E5A0-0x000000018973E5E0
		// [XID] // 0x000000018973E5A0-0x000000018973E5E0
		public void Dispose() {} // 0x0000000187A4A9E0-0x0000000187A4AA90
		// [IDTag] // 0x0000000189748B00-0x0000000189748B40
		// [XID] // 0x0000000189748B00-0x0000000189748B40
		private void Dispose(bool disposing) {} // 0x0000000187A4AA90-0x0000000187A4AB70
		// [XID] // 0x00000001899E0EF0-0x00000001899E0F10
		public int GetNumberOfFrameBeforeDestroy(int playerId) => default; // 0x0000000187A4AD10-0x0000000187A4ADD0
		// [XID] // 0x000000018975A200-0x000000018975A220
		protected void SetupStaticMaterialProperties() {} // 0x0000000187A4B340-0x0000000187A4B5E0
		// [XID] // 0x0000000189761F80-0x0000000189761FA0
		private void GetBlendModes(out int srcBlendMode, out int dstBlendMode) {
			srcBlendMode = default;
			dstBlendMode = default;
		} // 0x0000000187A4AC20-0x0000000187A4AD10
		// [XID] // 0x00000001897693B0-0x00000001897693D0
		public virtual void SetApplyTargetAlpha(bool flag) {} // 0x0000000187A4B1C0-0x0000000187A4B280
		// [XID] // 0x00000001899E8AC0-0x00000001899E8AE0
		public virtual void SetUiRenderMode(bool flag) {} // 0x0000000187A4B280-0x0000000187A4B340
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract bool IsPrepared();
		public abstract bool ContinuePreparing();
		public abstract void AttachToPlayer(int playerId);
		public abstract bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop);
		public abstract bool UpdateMaterial(UnityEngine.Material material);
		public abstract void UpdateTextures();
		public abstract bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
		// [XID] // 0x00000001899F0220-0x00000001899F0240
		public virtual void OnPlayerPause(bool pauseStatus) {} // 0x0000000187A4AFD0-0x0000000187A4B080
		// [XID] // 0x00000001899F7810-0x00000001899F7830
		public virtual bool OnPlayerStopForSeek() => default; // 0x0000000187A4B120-0x0000000187A4B1C0
		// [XID] // 0x00000001899FEEA0-0x00000001899FEEC0
		public virtual void OnPlayerStart() {} // 0x0000000187A4B080-0x0000000187A4B120
		// [XID] // 0x0000000189A067A0-0x0000000189A067C0
		public virtual bool ShouldSkipDestroyOnStopForSeek() => default; // 0x0000000187A4B5E0-0x0000000187A4B680
		// [XID] // 0x0000000189795F50-0x0000000189795F70
		public virtual bool HasRenderedNewFrame() => default; // 0x0000000187A4ADD0-0x0000000187A4AE70
		// [IDTag] // 0x000000018979E270-0x000000018979E2B0
		// [XID] // 0x000000018979E270-0x000000018979E2B0
		public static uint NextPowerOfTwo(uint x) => default; // 0x0000000187A4AE70-0x0000000187A4AF30
		// [IDTag] // 0x00000001897A84B0-0x00000001897A84F0
		// [XID] // 0x00000001897A84B0-0x00000001897A84F0
		public static int NextPowerOfTwo(int x) => default; // 0x0000000187A4AF30-0x0000000187A4AFD0
		// [XID] // 0x0000000189A1C590-0x0000000189A1C5B0
		public static int CeilingWith(int x, int ceilingValue) => default; // 0x0000000187A4A7A0-0x0000000187A4A850
		// [XID] // 0x00000001897BAB20-0x00000001897BAB40
		public static int Ceiling16(int x) => default; // 0x0000000187A4A510-0x0000000187A4A5B0
		// [XID] // 0x0000000189A3A1B0-0x0000000189A3A1D0
		public static int Ceiling32(int x) => default; // 0x0000000187A4A660-0x0000000187A4A700
		// [XID] // 0x00000001897C9E80-0x00000001897C9EA0
		public static int Ceiling64(int x) => default; // 0x0000000187A4A700-0x0000000187A4A7A0
		// [XID] // 0x00000001897D1620-0x00000001897D1640
		public static int Ceiling256(int x) => default; // 0x0000000187A4A5B0-0x0000000187A4A660
		// [XID] // 0x00000001897D9440-0x00000001897D9460
		protected static void DisposeTextures(Texture[] textures) {} // 0x0000000187A4A850-0x0000000187A4A9E0
		protected static extern bool CRIWAREF463354B(int player_id, int num_textures, IntPtr[] tex_ptrs, [In, Out] FrameInfo frame_info, ref bool frame_drop); // 0x0000000187A4A2A0-0x0000000187A4A510
		protected static extern bool CRIWARE9B186887(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x0000000187A4A0A0-0x0000000187A4A1B0
		protected static extern bool CRIWARE702CADE1(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x0000000187A49F90-0x0000000187A4A0A0
		protected static extern bool CRIWARE44F6DEE8(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x0000000187A49E80-0x0000000187A49F90
		protected static extern sbyte CRIWAREA9D27250(int player_id); // 0x0000000187A4A1B0-0x0000000187A4A2A0
	}
}
