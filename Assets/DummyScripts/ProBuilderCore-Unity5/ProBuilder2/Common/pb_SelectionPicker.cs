/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public static class pb_SelectionPicker // TypeDefIndex: 3423
	{
		// Fields
		private static bool m_Initialized; // 0x00
		private static RenderTextureFormat m_RenderTextureFormat; // 0x04
		private static RenderTextureFormat[] m_PreferredFormats; // 0x08
	
		// Properties
		private static RenderTextureFormat renderTextureFormat { get; } // 0x0000000186BBC280-0x0000000186BBC4B0 
		private static TextureFormat textureFormat { get; } // 0x0000000186BBC4B0-0x0000000186BBC500 
	
		// Constructors
		static pb_SelectionPicker() {} // 0x0000000186BBC1A0-0x0000000186BBC280
	
		// Methods
		public static Dictionary<pb_Object, HashSet<pb_Face>> PickFacesInRect(Camera camera, Rect pickerRect, IEnumerable<pb_Object> selection, int renderTextureWidth = -1 /* Metadata: 0x00AC3CDC */, int renderTextureHeight = -1 /* Metadata: 0x00AC3CE0 */) => default; // 0x0000000186BBAD50-0x0000000186BBB260
		public static Dictionary<pb_Object, HashSet<int>> PickVerticesInRect(Camera camera, Rect pickerRect, IEnumerable<pb_Object> selection, int renderTextureWidth = -1 /* Metadata: 0x00AC3CE4 */, int renderTextureHeight = -1 /* Metadata: 0x00AC3CE8 */) => default; // 0x0000000186BBB260-0x0000000186BBB760
		public static Texture2D RenderSelectionPickerTexture(Camera camera, IEnumerable<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map, int width = -1 /* Metadata: 0x00AC3CEC */, int height = -1 /* Metadata: 0x00AC3CF0 */) {
			map = default;
			return default;
		} // 0x0000000186BBB760-0x0000000186BBB9B0
		public static Texture2D RenderSelectionPickerTexture(Camera camera, IEnumerable<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, int>> map, int width = -1 /* Metadata: 0x00AC3CF4 */, int height = -1 /* Metadata: 0x00AC3CF8 */) {
			map = default;
			return default;
		} // 0x0000000186BBB9B0-0x0000000186BBBC00
		public static List<GameObject> GenerateFaceDepthTestMeshes(IEnumerable<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, pb_Face>> map) {
			map = default;
			return default;
		} // 0x0000000186BBA080-0x0000000186BBA7F0
		private static List<GameObject> GenerateVertexDepthTestMeshes(IEnumerable<pb_Object> selection, out Dictionary<uint, pb_Tuple<pb_Object, int>> map) {
			map = default;
			return default;
		} // 0x0000000186BBA7F0-0x0000000186BBAD50
		private static Mesh BuildVertexMesh(pb_Object pb, Dictionary<uint, pb_Tuple<pb_Object, int>> map, ref uint index) => default; // 0x0000000186BB93F0-0x0000000186BB9EF0
		public static uint DecodeRGBA(Color32 color) => default; // 0x0000000186BB9EF0-0x0000000186BB9FB0
		public static Color32 EncodeRGBA(uint hash) => default; // 0x0000000186BB9FB0-0x0000000186BBA080
		private static Texture2D RenderWithReplacementShader(Camera camera, Shader shader, string tag, int width = -1 /* Metadata: 0x00AC3CFC */, int height = -1 /* Metadata: 0x00AC3D00 */) => default; // 0x0000000186BBBC00-0x0000000186BBC0A0
	}
}
