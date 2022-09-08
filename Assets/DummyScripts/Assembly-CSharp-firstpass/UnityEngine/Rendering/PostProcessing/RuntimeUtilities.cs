/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public static class RuntimeUtilities // TypeDefIndex: 9617
	{
		// Fields
		private static PostProcessResources s_Resources; // 0x00
		private static Texture2D m_WhiteTexture; // 0x08
		private static Texture2D m_BlackTexture; // 0x10
		private static Texture2D m_TransparentTexture; // 0x18
		private static Mesh s_FullscreenTriangle; // 0x20
		private static Mesh s_FlippedFullscreenTriangle; // 0x28
		private static Mesh s_FullscreenRect; // 0x30
		public static PostProcessResources resource; // 0x38
		private static UnityEngine.Material s_CopyStdMaterial; // 0x40
		private static UnityEngine.Material s_CopyMaterial; // 0x48
		private static PropertySheet s_CopySheet; // 0x50
		private static PropertySheet s_GaussFilterLowSheet; // 0x58
		private static PropertySheet s_GaussFilterMediumSheet; // 0x60
		private static PropertySheet s_GaussFilterHighSheet; // 0x68
	
		// Properties
		public static Texture2D whiteTexture { /* [XID] */ /* 0x0000000189606310-0x0000000189606330 */ get; } // 0x0000000185E17520-0x0000000185E176D0 
		public static Texture2D blackTexture { /* [XID] */ /* 0x00000001899FBDB0-0x00000001899FBDD0 */ get; } // 0x0000000185E15820-0x0000000185E159D0 
		public static Texture2D transparentTexture { /* [XID] */ /* 0x0000000189B50960-0x0000000189B50980 */ get; } // 0x0000000185E17370-0x0000000185E17520 
		public static Mesh fullscreenTriangle { /* [XID] */ /* 0x000000018962B750-0x000000018962B770 */ get; } // 0x0000000185E166B0-0x0000000185E16AC0 
		public static Mesh flippedFullscreenTriangle { /* [XID] */ /* 0x0000000189B76700-0x0000000189B76720 */ get; } // 0x0000000185E15F10-0x0000000185E16330 
		public static Mesh fullscreenRect { /* [XID] */ /* 0x0000000189B7DCC0-0x0000000189B7DCE0 */ get; } // 0x0000000185E16330-0x0000000185E166B0 
		public static UnityEngine.Material copyStdMaterial { /* [XID] */ /* 0x0000000189B6E4C0-0x0000000189B6E4E0 */ get; } // 0x0000000185E15CF0-0x0000000185E15F10 
		public static UnityEngine.Material copyMaterial { /* [XID] */ /* 0x00000001898E4760-0x00000001898E4780 */ get; } // 0x0000000185E159D0-0x0000000185E15BF0 
		public static PropertySheet copySheet { /* [XID] */ /* 0x0000000189B5FB60-0x0000000189B5FB80 */ get; } // 0x0000000185E15BF0-0x0000000185E15CF0 
		public static PropertySheet gaussFilterLowSheet { /* [XID] */ /* 0x0000000189607960-0x0000000189607980 */ get; } // 0x0000000185E16CA0-0x0000000185E16E80 
		public static PropertySheet gaussFilterMediumSheet { /* [XID] */ /* 0x00000001898FB2B0-0x00000001898FB2D0 */ get; } // 0x0000000185E16E80-0x0000000185E17060 
		public static PropertySheet gaussFilterHighSheet { /* [XID] */ /* 0x000000018990A4D0-0x000000018990A4F0 */ get; } // 0x0000000185E16AC0-0x0000000185E16CA0 
		public static bool isSinglePassStereoEnabled { /* [XID] */ /* 0x000000018974F050-0x000000018974F070 */ get; } // 0x0000000185E171C0-0x0000000185E172D0 
		public static bool isVREnabled { /* [XID] */ /* 0x000000018964F8D0-0x000000018964F8F0 */ get; } // 0x0000000185E172D0-0x0000000185E17370 
		public static bool isAndroidOpenGL { /* [XID] */ /* 0x00000001899956F0-0x0000000189995710 */ get; } // 0x0000000185E17060-0x0000000185E17120 
		public static bool isLinearColorSpace { /* [XID] */ /* 0x0000000189665FE0-0x0000000189666000 */ get; } // 0x0000000185E17120-0x0000000185E171C0 
	
		// Methods
		// [XID] // 0x0000000189B49D50-0x0000000189B49D70
		public static void Init(PostProcessResources resources) {} // 0x0000000185E14860-0x0000000185E14910
		// [XID] // 0x0000000189B515E0-0x0000000189B51600
		public static bool IsInit() => default; // 0x0000000185E149C0-0x0000000185E14AA0
		// [XID] // 0x0000000189B9B820-0x0000000189B9B840
		public static float GaussianDistribution1D(float x, float rho) => default; // 0x0000000185E139F0-0x0000000185E13B20
		// [IDTag] // 0x00000001895F5ED0-0x00000001895F5F10
		// [XID] // 0x00000001895F5ED0-0x00000001895F5F10
		public static void BlitFullscreenTriangle(Texture source, RenderTexture destination, UnityEngine.Material material, int pass, bool flip = false /* Metadata: 0x00AE5CB5 */) {} // 0x0000000185E11B50-0x0000000185E11DF0
		// [XID] // 0x00000001896002D0-0x00000001896002F0
		public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) {} // 0x0000000185E133B0-0x0000000185E13580
		// [XID] // 0x0000000189679D80-0x0000000189679DA0
		public static void Destroy(UnityEngine.Object obj) {} // 0x0000000185E13820-0x0000000185E13920
		// [XID] // 0x0000000189637D20-0x0000000189637D40
		public static bool IsResolvedDepthAvailable(Camera camera) => default; // 0x0000000185E14B70-0x0000000185E14C60
		// [XID] // 0x0000000189675670-0x0000000189675690
		public static int IsMSAASample(Camera camera) => default; // 0x0000000185E14AA0-0x0000000185E14B70
		// [XID] // 0x000000018967CDD0-0x000000018967CDF0
		public static bool IsHDRFormat(RenderTextureFormat format) => default; // 0x0000000185E14910-0x0000000185E149C0
		// [XID] // 0x0000000189684440-0x0000000189684460
		public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) {} // 0x0000000185E13580-0x0000000185E13740
		// [XID] // 0x000000018968C060-0x000000018968C080
		public static void DestroyVolume(PostProcessVolume volume, bool destroySharedProfile) {} // 0x0000000185E13740-0x0000000185E13820
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public static IEnumerable<T> GetAllSceneObjects<T>()
			where T : Component => default;
		public static void CreateIfNull<T>(ref T obj)
			where T : class, new() {}
		// [XID] // 0x000000018969AFF0-0x000000018969B010
		public static float Exp2(float x) => default; // 0x0000000185E13920-0x0000000185E139F0
		// [XID] // 0x0000000189899150-0x0000000189899170
		public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) => default; // 0x0000000185E14150-0x0000000185E14640
		// [XID] // 0x00000001896A9CB0-0x00000001896A9CD0
		public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) => default; // 0x0000000185E13EE0-0x0000000185E14150
		// [XID] // 0x0000000189B5FB80-0x0000000189B5FBA0
		public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) => default; // 0x0000000185E13B20-0x0000000185E13EE0
		public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr) => default;
		public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr) => default;
		// [XID] // 0x000000018998FCC0-0x000000018998FCE0
		public static object GetParentObject(string path, object obj) => default; // 0x0000000185E14640-0x0000000185E14860
	
		// Extension methods
		// [IDTag] // 0x0000000189BA3030-0x0000000189BA3080
		// [XID] // 0x0000000189BA3030-0x0000000189BA3080
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false /* Metadata: 0x00AE5C9E */, bool flip = false /* Metadata: 0x00AE5C9F */, bool bDicardColor = false /* Metadata: 0x00AE5CA0 */, bool bDiscardDepth = false /* Metadata: 0x00AE5CA1 */, bool bGammaToLinear = false /* Metadata: 0x00AE5CA2 */, bool bSetViewport = true /* Metadata: 0x00AE5CA3 */) {} // 0x0000000185E12910-0x0000000185E12BF0
		// [IDTag] // 0x0000000189BAFDF0-0x0000000189BAFE40
		// [XID] // 0x0000000189BAFDF0-0x0000000189BAFE40
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false /* Metadata: 0x00AE5CA4 */, bool bDicardColor = false /* Metadata: 0x00AE5CA5 */, bool bDiscardDepth = false /* Metadata: 0x00AE5CA6 */, bool flip = false /* Metadata: 0x00AE5CA7 */) {} // 0x0000000185E11DF0-0x0000000185E12160
		// [XID] // 0x0000000189BBD450-0x0000000189BBD490
		public static void BlitSubRect(this CommandBuffer cmd, RenderTargetIdentifier source, Vector4 transformSource, Vector4 transformTarget, PropertySheet propertySheet, int pass, bool clear = false /* Metadata: 0x00AE5CA8 */) {} // 0x0000000185E12F80-0x0000000185E133B0
		// [IDTag] // 0x0000000189BC7E40-0x0000000189BC7E90
		// [XID] // 0x0000000189BC7E40-0x0000000189BC7E90
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false /* Metadata: 0x00AE5CA9 */, bool bDicardColor = false /* Metadata: 0x00AE5CAA */, bool bDiscardDepth = false /* Metadata: 0x00AE5CAB */, bool bDepthStore = true /* Metadata: 0x00AE5CAC */, bool flip = false /* Metadata: 0x00AE5CAD */) {} // 0x0000000185E12160-0x0000000185E12530
		// [IDTag] // 0x0000000189BD5730-0x0000000189BD5780
		// [XID] // 0x0000000189BD5730-0x0000000189BD5780
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear, Color groundColor, bool clearDepth, bool bDicardColor = false /* Metadata: 0x00AE5CAE */, bool bDiscardDepth = false /* Metadata: 0x00AE5CAF */, bool flip = false /* Metadata: 0x00AE5CB0 */) {} // 0x0000000185E12530-0x0000000185E12910
		// [IDTag] // 0x00000001895E8480-0x00000001895E84D0
		// [XID] // 0x00000001895E8480-0x00000001895E84D0
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false /* Metadata: 0x00AE5CB1 */, bool bDicardColor = false /* Metadata: 0x00AE5CB2 */, bool bDiscardDepth = false /* Metadata: 0x00AE5CB3 */, bool flip = false /* Metadata: 0x00AE5CB4 */) {} // 0x0000000185E12BF0-0x0000000185E12F80
		// [XID] // 0x000000018961E3C0-0x000000018961E400
		private static void _gaussianBlur(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier temp, PropertySheet sheet, float aspectRatio, int level) {} // 0x0000000185E14C60-0x0000000185E150D0
		// [XID] // 0x00000001896289E0-0x0000000189628A20
		public static void gaussianBlurLow(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier temp, float aspectRatio, int level) {} // 0x0000000185E15340-0x0000000185E155B0
		// [XID] // 0x0000000189633270-0x00000001896332B0
		public static void gaussianBlurMedium(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier temp, float aspectRatio, int level) {} // 0x0000000185E155B0-0x0000000185E15820
		// [XID] // 0x000000018963DC70-0x000000018963DCB0
		public static void gaussianBlurHigh(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier temp, float aspectRatio, int level) {} // 0x0000000185E150D0-0x0000000185E15340
		public static T GetAttribute<T>(this System.Type type)
			where T : Attribute => default;
	}
}
