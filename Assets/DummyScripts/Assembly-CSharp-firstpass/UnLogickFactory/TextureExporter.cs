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

namespace UnLogickFactory
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class TextureExporter : MonoBehaviour // TypeDefIndex: 10136
	{
		// Fields
		private Camera _exportCamera; // 0x18
		public Texture2D _diffuseTexture; // 0x20
		public Texture2D _normalMapTexture; // 0x28
		public Texture2D _specularMapTexture; // 0x30
		public RenderTexture rt; // 0x38
		public Renderer _textureExporter; // 0x40
		private UnityEngine.Material _normalMat; // 0x48
		private UnityEngine.Material _specularMat; // 0x50
		private UnityEngine.Material _diffuseMat; // 0x58
		public string _normalMapFilename; // 0x60
		public string _specularMapFilename; // 0x68
		public string _diffuseTextureFilename; // 0x70
		private Dictionary<UnityEngine.Material, UnityEngine.Material> AlreadyProcessedMaterials; // 0x78
		private UnityEngine.Material lastMaterial; // 0x80
		private int renderTextureSize; // 0x88
	
		// Constructors
		public TextureExporter() {} // 0x00000001862B0B40-0x00000001862B0BD0
	
		// Methods
		// [XID] // 0x00000001896BC8C0-0x00000001896BC8E0
		public static TextureExporter CreateTextureExporter() => default; // 0x00000001862AE7D0-0x00000001862AE960
		// [XID] // 0x00000001896997F0-0x0000000189699810
		private void Awake() {} // 0x00000001862AE410-0x00000001862AE5E0
		// [XID] // 0x0000000189BD8640-0x0000000189BD8660
		private void OnDestroy() {} // 0x00000001862AEDA0-0x00000001862AF000
		// [XID] // 0x0000000189B74DF0-0x0000000189B74E10
		public void ProcessTerrain(Terrain terrain, int resolution, FbxTextureExportScheme textureScheme, string path) {} // 0x00000001862AFA00-0x00000001862B0220
		// [XID] // 0x000000018974E7F0-0x000000018974E810
		public UnityEngine.Material ProcessMaterial(UnityEngine.Material mat, Renderer renderer, FbxTextureExportScheme textureScheme, string path) => default; // 0x00000001862AF460-0x00000001862AFA00
		// [XID] // 0x0000000189755F50-0x0000000189755F70
		protected void CleanupLastMaterial() {} // 0x00000001862AE5E0-0x00000001862AE7D0
		// [XID] // 0x000000018975D1C0-0x000000018975D1E0
		protected Texture MakeDummyTexture(Texture texture) => default; // 0x00000001862AEC90-0x00000001862AEDA0
		// [XID] // 0x0000000189764940-0x0000000189764960
		protected UnityEngine.Material SetupTerrainMaterial(Terrain terrain, int layer, SplatPrototype[] splats, Texture2D control) => default; // 0x00000001862B0220-0x00000001862B0980
		// [XID] // 0x0000000189B0C9E0-0x0000000189B0CA00
		protected void PerformTextureExport(int resolutionX, int resolutionY) {} // 0x00000001862AF130-0x00000001862AF460
		// [XID] // 0x00000001896A0C20-0x00000001896A0C40
		public virtual void OnRenderImage(RenderTexture src, RenderTexture dest) {} // 0x00000001862AF000-0x00000001862AF130
		// [XID] // 0x000000018977B050-0x000000018977B070
		protected void ExportSingleTexture(RenderTexture src, Texture2D dest, UnityEngine.Material mat, string filename) {} // 0x00000001862AEA60-0x00000001862AEC90
		// [XID] // 0x0000000189782C00-0x0000000189782C20
		protected void WriteAllBytes(string filename, byte[] data) {} // 0x00000001862B0980-0x00000001862B0B40
		// [XID] // 0x0000000189789E90-0x0000000189789EB0
		protected void EnsureFolderExists(string folder) {} // 0x00000001862AE960-0x00000001862AEA60
	}
}
