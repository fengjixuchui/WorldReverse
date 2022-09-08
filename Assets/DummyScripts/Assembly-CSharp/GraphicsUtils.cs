/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class GraphicsUtils // TypeDefIndex: 31550
{
	// Fields
	public static bool isDisableRenderTexture; // 0x00
	private static RenderTextureWrapperPool _renderTextureWrapperPool; // 0x08

	// Constructors
	static GraphicsUtils() {} // 0x00000001851B7220-0x00000001851B72B0

	// Methods
	// [XID] // 0x0000000189A735E0-0x0000000189A73600
	public static void CreateAndAssignInstancedMaterial(Renderer renderer, UnityEngine.Material targetMaterial) {} // 0x00000001851B4E10-0x00000001851B4FF0
	// [XID] // 0x0000000189A7B180-0x0000000189A7B1A0
	public static bool IsInstancedMaterial(UnityEngine.Material mat) => default; // 0x00000001851B7000-0x00000001851B7110
	// [XID] // 0x0000000189A82830-0x0000000189A82850
	public static void TryCleanRendererInstancedMaterial(Renderer renderer) {} // 0x00000001851B4B00-0x00000001851B4CA0
	// [XID] // 0x0000000189A8A290-0x0000000189A8A2B0
	public static void WarmupAllShaders() {} // 0x00000001851B4D80-0x00000001851B4E10
	// [XID] // 0x0000000189A919A0-0x0000000189A919C0
	public static void SetShaderBloomMaxBlendParams() {} // 0x00000001851B7110-0x00000001851B7220
	// [XID] // 0x0000000189A994B0-0x0000000189A994D0
	public static int GetRenderTextureNumber() => default; // 0x00000001851B4CA0-0x00000001851B4D80
	// [IDTag] // 0x0000000189AA05F0-0x0000000189AA0630
	// [XID] // 0x0000000189AA05F0-0x0000000189AA0630
	public static RenderTextureWrapper GetRenderTexture(RenderTextureWrapper.Param param) => default; // 0x00000001851B6D50-0x00000001851B6E80
	// [IDTag] // 0x0000000189AAAC90-0x0000000189AAACD0
	// [XID] // 0x0000000189AAAC90-0x0000000189AAACD0
	public static RenderTextureWrapper GetRenderTexture(int width, int height, int depth, string name = null) => default; // 0x00000001851B6A90-0x00000001851B6BE0
	// [IDTag] // 0x0000000189AB5610-0x0000000189AB5650
	// [XID] // 0x0000000189AB5610-0x0000000189AB5650
	public static RenderTextureWrapper GetRenderTexture(int width, int height, int depth, RenderTextureFormat format, string name = null) => default; // 0x00000001851B6BE0-0x00000001851B6D50
	// [IDTag] // 0x0000000189AC01C0-0x0000000189AC0200
	// [XID] // 0x0000000189AC01C0-0x0000000189AC0200
	public static RenderTextureWrapper GetRenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, string name = null) => default; // 0x00000001851B6E80-0x00000001851B7000
	// [XID] // 0x0000000189ACAA20-0x0000000189ACAA40
	public static void ReleaseRenderTexture(RenderTextureWrapper wrapper) {} // 0x00000001851B4A10-0x00000001851B4B00
	// [XID] // 0x0000000189AD2480-0x0000000189AD24A0
	public static void RebindAllRenderTexturesToCamera() {} // 0x00000001851B4820-0x00000001851B4A10
	// [IDTag] // 0x0000000189AD9EF0-0x0000000189AD9F30
	// [XID] // 0x0000000189AD9EF0-0x0000000189AD9F30
	public static void DrawBoundsForDebug(Bounds b, Color c) {} // 0x00000001851B5DB0-0x00000001851B6A90
	// [IDTag] // 0x0000000189AE4A80-0x0000000189AE4AC0
	// [XID] // 0x0000000189AE4A80-0x0000000189AE4AC0
	public static void DrawBoundsForDebug(Bounds b, Color c, Matrix4x4 mat) {} // 0x00000001851B4FF0-0x00000001851B5DB0
}

