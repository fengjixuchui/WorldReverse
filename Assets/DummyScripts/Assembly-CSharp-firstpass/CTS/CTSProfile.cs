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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CTS
{
	[Serializable]
	public class CTSProfile : ScriptableObject // TypeDefIndex: 9126
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_ctsMajorVersion; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_ctsMinorVersion; // 0x1C
		public bool m_persistMaterials; // 0x20
		public bool m_showGlobalSettings; // 0x21
		public bool m_showSnowSettings; // 0x22
		public bool m_showTextureSettings; // 0x23
		public bool m_showGeoSettings; // 0x24
		public bool m_showDetailSettings; // 0x25
		public bool m_showColorMapSettings; // 0x26
		public bool m_showOptimisationSettings; // 0x27
		public string m_ctsDirectory; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool m_instanceChanged; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CTSConstants.ShaderType m_shaderType; // 0x34
		public float m_globalUvMixPower; // 0x38
		public float m_globalUvMixStartDistance; // 0x3C
		public float m_globalUvMixRange; // 0x40
		public float m_globalNormalPower; // 0x44
		public float m_globalDetailNormalClosePower; // 0x48
		public float m_globalDetailNormalCloseTiling; // 0x4C
		public float m_globalDetailNormalFarPower; // 0x50
		public float m_globalDetailNormalFarTiling; // 0x54
		public float m_globalDetailHeightZScale; // 0x58
		public float m_globalTerrainSmoothness; // 0x5C
		public float m_globalTerrainSpecular; // 0x60
		public float m_globalBasemapDistance; // 0x64
		public float m_globalSSAOIntensity; // 0x68
		public float m_globalDeformationFakeAO; // 0x6C
		public bool m_globalOptimiseAtRuntime; // 0x70
		public bool m_globalDisconnectAtRuntime; // 0x71
		public TextureFormat m_albedoFormat; // 0x74
		public int m_albedoAniso; // 0x78
		public FilterMode m_albedoFilterMode; // 0x7C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CTSConstants.TextureSize m_albedoTextureSize; // 0x80
		public int m_albedoTextureSizePx; // 0x84
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_albedoCompress; // 0x88
		public TextureFormat m_normalFormat; // 0x8C
		public int m_normalAniso; // 0x90
		public FilterMode m_normalFilterMode; // 0x94
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CTSConstants.TextureSize m_normalTextureSize; // 0x98
		public int m_normalTextureSizePx; // 0x9C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_normalCompress; // 0xA0
		public bool enableFadeTint; // 0xA1
		public int m_globalDetailNormalMapIdx; // 0xA4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Texture2D m_globalDetailNormalMap; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_enableSSS; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Terrain.TessellationLevel m_tessellationLevel; // 0xB4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<CTSTerrainTextureDetails> m_terrainTextures; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Texture2D> m_replacementTerrainAlbedos; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Texture2D> m_replacementTerrainNormals; // 0xC8
	
		// Properties
		public int MajorVersion { /* [XID] */ /* 0x0000000189B987E0-0x0000000189B98800 */ get => default; /* [XID] */ /* 0x0000000189B9FCE0-0x0000000189B9FD00 */ set {} } // 0x0000000187571330-0x00000001875713D0 0x0000000187571CD0-0x0000000187571D90
		public int MinorVersion { /* [XID] */ /* 0x0000000189603260-0x0000000189603280 */ get => default; /* [XID] */ /* 0x0000000189BAE690-0x0000000189BAE6B0 */ set {} } // 0x00000001875713D0-0x0000000187571470 0x0000000187571D90-0x0000000187571E50
		public CTSConstants.ShaderType ShaderType { /* [XID] */ /* 0x0000000189A94190-0x0000000189A941B0 */ get => default; /* [XID] */ /* 0x0000000189BBD4D0-0x0000000189BBD4F0 */ set {} } // 0x0000000187571720-0x00000001875717C0 0x0000000187572060-0x0000000187572110
		public CTSConstants.TextureSize AlbedoTextureSize { /* [XID] */ /* 0x0000000189BC5220-0x0000000189BC5240 */ get => default; /* [XID] */ /* 0x0000000189BCCC60-0x0000000189BCCC80 */ set {} } // 0x0000000187571130-0x00000001875711D0 0x0000000187571A00-0x0000000187571B20
		public bool AlbedoCompressionEnabled { /* [XID] */ /* 0x0000000189BD42B0-0x0000000189BD42D0 */ get => default; /* [XID] */ /* 0x0000000189BDBC40-0x0000000189BDBC60 */ set {} } // 0x0000000187571080-0x0000000187571130 0x0000000187571910-0x0000000187571A00
		public CTSConstants.TextureSize NormalTextureSize { /* [XID] */ /* 0x00000001895E85D0-0x00000001895E85F0 */ get => default; /* [XID] */ /* 0x000000018990D780-0x000000018990D7A0 */ set {} } // 0x0000000187571520-0x00000001875715C0 0x0000000187571F40-0x0000000187572060
		public bool NormalCompressionEnabled { /* [XID] */ /* 0x00000001895F7710-0x00000001895F7730 */ get => default; /* [XID] */ /* 0x00000001895FEAD0-0x00000001895FEAF0 */ set {} } // 0x0000000187571470-0x0000000187571520 0x0000000187571E50-0x0000000187571F40
		public Texture2D GlobalDetailNormalMap { /* [XID] */ /* 0x00000001896064B0-0x00000001896064D0 */ get => default; /* [XID] */ /* 0x000000018960DE70-0x000000018960DE90 */ set {} } // 0x0000000187571280-0x0000000187571330 0x0000000187571BD0-0x0000000187571CD0
		public bool EnableSSS { /* [XID] */ /* 0x00000001898F9D00-0x00000001898F9D20 */ get => default; /* [XID] */ /* 0x00000001895F9840-0x00000001895F9860 */ set {} } // 0x00000001875711D0-0x0000000187571280 0x0000000187571B20-0x0000000187571BD0
		public Terrain.TessellationLevel TessellationLevel { /* [XID] */ /* 0x00000001896240E0-0x0000000189624100 */ get => default; /* [XID] */ /* 0x000000018962B990-0x000000018962B9B0 */ set {} } // 0x0000000187571870-0x0000000187571910 0x00000001875721C0-0x0000000187572270
		public List<CTSTerrainTextureDetails> TerrainTextures { /* [XID] */ /* 0x0000000189633320-0x0000000189633340 */ get => default; /* [XID] */ /* 0x000000018994B7E0-0x000000018994B800 */ set {} } // 0x00000001875717C0-0x0000000187571870 0x0000000187572110-0x00000001875721C0
		public List<Texture2D> ReplacementTerrainAlbedos { /* [XID] */ /* 0x0000000189649B80-0x0000000189649BA0 */ get => default; } // 0x00000001875715C0-0x0000000187571670 
		public List<Texture2D> ReplacementTerrainNormals { /* [XID] */ /* 0x0000000189651160-0x0000000189651180 */ get => default; } // 0x0000000187571670-0x0000000187571720 
	
		// Constructors
		public CTSProfile() {} // 0x0000000187570E60-0x0000000187571080
	
		// Methods
		// [XID] // 0x0000000189B9B000-0x0000000189B9B020
		public void Lerp(List<CTSTerrainTextureDetails> ctsList, float ratio) {} // 0x000000018756F160-0x000000018756F3D0
		// [XID] // 0x00000001899D7FF0-0x00000001899D8010
		public void UpdateSettingsFromTerrain(Terrain terrain, bool forceUpdate) {} // 0x00000001875707B0-0x0000000187570E60
		// [XID] // 0x000000018965FFD0-0x000000018965FFF0
		public void UpdateSettingsFromMultiTerrain(Terrain[] terrainArray, bool forceUpdate) {} // 0x00000001875700D0-0x00000001875707B0
		// [XID] // 0x0000000189667AB0-0x0000000189667AD0
		public void UnpackSubstance(ProceduralMaterial pm) {} // 0x000000018756F9A0-0x00000001875700D0
		// [XID] // 0x00000001898421E0-0x0000000189842200
		public static void UnpackSubstanceEditorMode(ProceduralMaterial pm) {} // 0x000000018756F8A0-0x000000018756F9A0
		// [XID] // 0x00000001898495C0-0x00000001898495E0
		private void ImportTexture(Texture2D texture, int textureSize, bool asNormal = false /* Metadata: 0x00AE5473 */) {} // 0x000000018756EC80-0x000000018756EF70
		// [XID] // 0x000000018967E400-0x000000018967E420
		private Color32[] GetTextureColors(Texture2D source, TextureFormat format, int dimensions) => default; // 0x000000018756EB10-0x000000018756EC80
		// [XID] // 0x00000001898582A0-0x00000001898582C0
		private Texture2D BakeHAOTexture(string name, Texture2D hTexture, Texture2D aoTexture, out byte minHeight, out byte maxHeight) {
			minHeight = default;
			maxHeight = default;
			return default;
		} // 0x000000018756CEB0-0x000000018756D400
		// [XID] // 0x000000018968D670-0x000000018968D690
		private Texture2D BakeNormal(Texture2D normalTexture) => default; // 0x000000018756D400-0x000000018756D7B0
		// [XID] // 0x0000000189866B10-0x0000000189866B30
		private Texture2D BakeAlbedo(Texture2D albedoTexture, Texture2D smoothnessTexture, Texture2D roughnessTexture) => default; // 0x000000018756C830-0x000000018756CEB0
		// [XID] // 0x000000018986E3D0-0x000000018986E3F0
		private void DebugTextureColorData(string name, Color32 color) {} // 0x000000018756E170-0x000000018756E480
		// [XID] // 0x00000001896F90A0-0x00000001896F90C0
		private void SaveTexture(string path, Texture2D texture) {} // 0x000000018756F790-0x000000018756F8A0
		// [XID] // 0x00000001896AB220-0x00000001896AB240
		public static Texture2D ResizeTexture(Texture2D texture, TextureFormat format, int width, int height, bool mipmap, bool linear, bool compress) => default; // 0x000000018756F3D0-0x000000018756F790
		// [XID] // 0x0000000189875860-0x0000000189875880
		private Texture2DArray GetTextureArray(List<Texture2D> sourceTextures, CTSConstants.TextureType textureType) => default; // 0x000000018756E480-0x000000018756EB10
		// [XID] // 0x0000000189886760-0x0000000189886780
		public static bool IsDifferentTexture(Texture2D src, Texture2D target) => default; // 0x000000018756EF70-0x000000018756F160
		// [XID] // 0x000000018987D3F0-0x000000018987D410
		public void ConstructTerrainReplacementAlbedos() {} // 0x000000018756D7B0-0x000000018756DC90
		// [XID] // 0x00000001896C8660-0x00000001896C8680
		public void ConstructTerrainReplacementNormals() {} // 0x000000018756DC90-0x000000018756E170
	}
}
