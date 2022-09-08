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
	public class FbxExporter // TypeDefIndex: 10126
	{
		// Fields
		private static int loggingLevel; // 0x00
	
		// Properties
		public static bool FbxSupported { /* [XID] */ /* 0x0000000189B33030-0x0000000189B33050 */ get => default; } // 0x00000001862A9780-0x00000001862A9820 
		public static string Version { /* [XID] */ /* 0x00000001896F1670-0x00000001896F1690 */ get => default; } // 0x00000001862A9820-0x00000001862A98C0 
	
		// Nested types
		private struct TempTransformScope : IDisposable // TypeDefIndex: 10127
		{
			// Fields
			public readonly Transform[] transforms; // 0x00
	
			// Constructors
			public TempTransformScope(Mesh mesh) {
				transforms = default;
			} // 0x00000001862AE330-0x00000001862AE340
			public TempTransformScope(IList<Mesh> meshes) {
				transforms = default;
			} // 0x00000001862AE230-0x00000001862AE330
	
			// Methods
			// [XID] // 0x0000000189BDFEC0-0x0000000189BDFEE0
			public void Dispose() {} // 0x00000001862ADF40-0x00000001862AE230
			// [XID] // 0x0000000189692390-0x00000001896923B0
			public static implicit operator Transform[](TempTransformScope scope) => default; // 0x00000001862AE340-0x00000001862AE410
		}
	
		// Constructors
		public FbxExporter() {} // 0x00000001862A9060-0x00000001862A90C0
	
		// Methods
		// [XID] // 0x0000000189B3AB70-0x0000000189B3AB90
		public static int GetDefaultFormat() => default; // 0x00000001862A7E40-0x00000001862A80F0
		// [XID] // 0x0000000189B42350-0x0000000189B42370
		public static void SetPosOffset(Vector3 offset) {} // 0x00000001862A8BE0-0x00000001862A8CD0
		// [XID] // 0x0000000189B49D10-0x0000000189B49D30
		public static void ClearPosOffset() {} // 0x00000001862A3E30-0x00000001862A3F30
		// [XID] // 0x0000000189B51490-0x0000000189B514B0
		public static void SetScale(float scale) {} // 0x00000001862A8CD0-0x00000001862A8DE0
		// [XID] // 0x0000000189BBA180-0x0000000189BBA1A0
		public static void ClearScale() {} // 0x00000001862A3F30-0x00000001862A4030
		// [IDTag] // 0x0000000189B604D0-0x0000000189B60510
		// [XID] // 0x0000000189B604D0-0x0000000189B60510
		public static bool Export(Mesh mesh, string fbxFile) => default; // 0x00000001862A7550-0x00000001862A7690
		// [IDTag] // 0x0000000189B6ABB0-0x0000000189B6ABF0
		// [XID] // 0x0000000189B6ABB0-0x0000000189B6ABF0
		public static bool Export(Mesh mesh, FbxExportSettings settings, string fbxFile) => default; // 0x00000001862A7930-0x00000001862A7A90
		// [IDTag] // 0x0000000189B74F30-0x0000000189B74F70
		// [XID] // 0x0000000189B74F30-0x0000000189B74F70
		public static bool Export(IList<Mesh> meshes, string fbxFile) => default; // 0x00000001862A77F0-0x00000001862A7930
		// [IDTag] // 0x0000000189B7F460-0x0000000189B7F4A0
		// [XID] // 0x0000000189B7F460-0x0000000189B7F4A0
		public static bool Export(IList<Mesh> meshes, FbxExportSettings settings, string fbxFile) => default; // 0x00000001862A7B70-0x00000001862A7CD0
		// [IDTag] // 0x0000000189B89DD0-0x0000000189B89E10
		// [XID] // 0x0000000189B89DD0-0x0000000189B89E10
		public static bool Export(string filename, params /* 0x000000018989F6F0-0x000000018989F700 */ Transform[] roots) => default; // 0x00000001862A7400-0x00000001862A7550
		// [IDTag] // 0x0000000189B9B730-0x0000000189B9B770
		// [XID] // 0x0000000189B9B730-0x0000000189B9B770
		public static bool Export(string filename, int formatId, params /* 0x000000018989F6F0-0x000000018989F700 */ Transform[] roots) => default; // 0x00000001862A7690-0x00000001862A77F0
		// [IDTag] // 0x0000000189BAD020-0x0000000189BAD060
		// [XID] // 0x0000000189BAD020-0x0000000189BAD060
		public static bool Export(string filename, FbxExportSettings settings, params /* 0x000000018989F6F0-0x000000018989F700 */ Transform[] roots) => default; // 0x00000001862A7A90-0x00000001862A7B70
		// [IDTag] // 0x0000000189BBEAB0-0x0000000189BBEAF0
		// [XID] // 0x0000000189BBEAB0-0x0000000189BBEAF0
		public static bool Export(string filename, FbxExportSettings settings, bool bakeTexture, params /* 0x000000018989F6F0-0x000000018989F700 */ Transform[] roots) => default; // 0x00000001862A5550-0x00000001862A7400
		// [XID] // 0x0000000189BD1170-0x0000000189BD1190
		public static void BakeTerrainTexture(Terrain terrain, string dir) {} // 0x00000001862A30F0-0x00000001862A3E30
		// [XID] // 0x0000000189A9E810-0x0000000189A9E830
		private static void ExportSkinnedMeshOrCloth(SkinnedMeshRenderer smr, Transform root, TextureExporter textureExporter, string outputPath, Dictionary<IntPtr, IntPtr> skeletonNodes, Dictionary<UnityEngine.Material, IntPtr> materialDictionary, FbxExportSettings settings, FbxExportCollection fbxCollection) {} // 0x00000001862A40F0-0x00000001862A5550
		// [XID] // 0x0000000189BDFFD0-0x0000000189BDFFF0
		private static UnityFbxExporterBinding.EType ConvertLightType(LightType type) => default; // 0x00000001862A4030-0x00000001862A40F0
		// [IDTag] // 0x00000001895ECDC0-0x00000001895ECE00
		// [XID] // 0x00000001895ECDC0-0x00000001895ECE00
		public static bool Export(string filename, int formatId, FbxTextureExportScheme textureScheme, int terrainQuality, FbxLODScheme LODScheme, int logLevel, params /* 0x000000018989F6F0-0x000000018989F700 */ Transform[] roots) => default; // 0x00000001862A7CD0-0x00000001862A7E40
		// [XID] // 0x0000000189B5EBE0-0x0000000189B5EC00
		private static void RecursivelyEnsureLimb(Transform root, Transform bone, Dictionary<Transform, IntPtr> fbxNodes, Dictionary<IntPtr, IntPtr> skeletonNodes) {} // 0x00000001862A89C0-0x00000001862A8BE0
		// [IDTag] // 0x00000001896063F0-0x0000000189606430
		// [XID] // 0x00000001896063F0-0x0000000189606430
		public static void LogFormat(bool actuallyLogThis, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] arguments) {} // 0x00000001862A86D0-0x00000001862A87C0
		// [IDTag] // 0x00000001896180C0-0x0000000189618100
		// [XID] // 0x00000001896180C0-0x0000000189618100
		public static void LogFormat(bool actuallyLogThis, UnityEngine.Object context, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] arguments) {} // 0x00000001862A87C0-0x00000001862A88D0
		// [XID] // 0x000000018962A1A0-0x000000018962A1C0
		public static void LogWarningFormat(bool actuallyLogThis, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] arguments) {} // 0x00000001862A88D0-0x00000001862A89C0
		// [XID] // 0x0000000189A359C0-0x0000000189A359E0
		public static void LogErrorFormat(bool actuallyLogThis, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] arguments) {} // 0x00000001862A85E0-0x00000001862A86D0
		// [IDTag] // 0x0000000189648210-0x0000000189648250
		// [XID] // 0x0000000189648210-0x0000000189648250
		private static bool checkIsValid(Terrain terrain, out TerrainData terrainData) {
			terrainData = default;
			return default;
		} // 0x00000001862A90C0-0x00000001862A91D0
		// [IDTag] // 0x0000000189652860-0x00000001896528A0
		// [XID] // 0x0000000189652860-0x00000001896528A0
		private static bool checkIsValid(MeshRenderer mr, out Mesh mesh, out UnityEngine.Material[] materials) {
			mesh = default;
			materials = default;
			return default;
		} // 0x00000001862A91D0-0x00000001862A9410
		// [IDTag] // 0x000000018965D240-0x000000018965D280
		// [XID] // 0x000000018965D240-0x000000018965D280
		private static bool checkIsValid(SkinnedMeshRenderer smr, bool exportCloth, out Transform[] bones, out Mesh mesh, out Cloth cloth, out UnityEngine.Material[] materials) {
			bones = default;
			mesh = default;
			cloth = default;
			materials = default;
			return default;
		} // 0x00000001862A9410-0x00000001862A9780
		// [XID] // 0x00000001896679E0-0x0000000189667A00
		public static void GetFormatNames(bool filterFbx, out string[] names, out int[] formatIds) {
			names = default;
			formatIds = default;
		} // 0x00000001862A80F0-0x00000001862A85E0
		// [XID] // 0x00000001896E8F10-0x00000001896E8F30
		private static void SkinAddCluster(IntPtr fbxSkin, IntPtr fbxCluster, IntPtr fbxRoot, Transform bone) {} // 0x00000001862A8DE0-0x00000001862A9060
	}
}
