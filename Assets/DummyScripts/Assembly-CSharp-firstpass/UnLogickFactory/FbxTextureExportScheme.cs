/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnLogickFactory
{
	[Serializable]
	public class FbxTextureExportScheme // TypeDefIndex: 10132
	{
		// Fields
		public ColorSpace textureColorSpace; // 0x10
		public TextureElements textureElements; // 0x14
		public TextureSizes textureSize; // 0x18
	
		// Properties
		public bool ExportMeshTextures { /* [XID] */ /* 0x0000000189B66220-0x0000000189B66240 */ get => default; } // 0x00000001862ADBC0-0x00000001862ADC60 
		public bool ExportSkinnedMeshTextures { /* [XID] */ /* 0x00000001896ED520-0x00000001896ED540 */ get => default; } // 0x00000001862ADC60-0x00000001862ADD10 
		public bool ExportTerrainTextures { /* [XID] */ /* 0x00000001896F4E60-0x00000001896F4E80 */ get => default; } // 0x00000001862ADD10-0x00000001862ADF40 
	
		// Nested types
		public enum TextureElements // TypeDefIndex: 10133
		{
			None = 0,
			Meshes = 1,
			SkinnedMeshes = 2,
			MeshesAndSkinnedMeshes = 3,
			Terrains = 4,
			MeshesAndTerrains = 5,
			SkinnedMeshesAndTerrains = 6,
			MeshesAndSkinnedMeshesAndTerrains = 7,
			Everything = 7
		}
	
		public enum TextureElementsMask // TypeDefIndex: 10134
		{
			Meshes = 1,
			SkinnedMeshes = 2,
			Terrains = 4
		}
	
		public enum TextureSizes // TypeDefIndex: 10135
		{
			ScaleFull = 0,
			ScaleHalf = 1,
			ScaleQuarter = 2,
			ScaleEighth = 3,
			ScaleSixteenth = 4,
			Scale32nd = 5
		}
	
		// Constructors
		public FbxTextureExportScheme() {} // 0x00000001862ADB50-0x00000001862ADBC0
	
		// Methods
		// [XID] // 0x00000001896FC5F0-0x00000001896FC610
		public virtual void AllocateTextures(UnityEngine.Material mat, Renderer renderer, ref Texture2D _diffuseTexture, ref Texture2D _specularMapTexture, ref Texture2D _normalMapTexture, out int resolutionX, out int resolutionY) {
			resolutionX = default;
			resolutionY = default;
		} // 0x00000001862AD550-0x00000001862AD6A0
		// [XID] // 0x0000000189AFDB90-0x0000000189AFDBB0
		public virtual float CalcColorSpace() => default; // 0x00000001862AD6A0-0x00000001862AD750
		// [XID] // 0x000000018970B390-0x000000018970B3B0
		protected void _AllocateTextures(UnityEngine.Material mat, Renderer renderer, ref Texture2D _diffuseTexture, ref Texture2D _normalMapTexture, ref Texture2D _specularMapTexture, out int maxResolutionX, out int maxResolutionY) {
			maxResolutionX = default;
			maxResolutionY = default;
		} // 0x00000001862AD750-0x00000001862ADB50
		// [XID] // 0x0000000189712B50-0x0000000189712B70
		protected bool AllocateTextureBasedOnMaterial(UnityEngine.Material mat, string shaderVariableName, ref Texture2D _diffuseTexture, ref int maxResolutionX, ref int maxResolutionY) => default; // 0x00000001862AD150-0x00000001862AD350
		// [XID] // 0x000000018971A440-0x000000018971A460
		public void AllocateTexture(ref Texture2D texture, int resolutionX, int resolutionY) {} // 0x00000001862AD350-0x00000001862AD550
		// [XID] // 0x0000000189721760-0x0000000189721780
		protected void AdjustResolution(ref int resolutionX, ref int resolutionY) {} // 0x00000001862ACFD0-0x00000001862AD150
	}
}
