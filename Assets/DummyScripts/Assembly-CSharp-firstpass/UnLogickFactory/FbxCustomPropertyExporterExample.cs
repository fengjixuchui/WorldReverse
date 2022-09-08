/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnLogickFactory
{
	public class FbxCustomPropertyExporterExample : MonoBehaviour // TypeDefIndex: 10107
	{
		// Fields
		// [FormerlySerializedAs] // 0x00000001899A0C50-0x00000001899A0C80
		public string editorFilename; // 0x18
		public string runtimeFilename; // 0x20
		public int logLevel; // 0x28
	
		// Constructors
		public FbxCustomPropertyExporterExample() {} // 0x00000001862A1AE0-0x00000001862A1B60
	
		// Methods
		// [XID] // 0x00000001899CF570-0x00000001899CF590
		private void Start() {} // 0x00000001862A16E0-0x00000001862A1AE0
		// [XID] // 0x00000001897E4D50-0x00000001897E4D70
		public static void OnFbxNodeCallback(Transform transform, IntPtr fbxNode) {} // 0x00000001862A12F0-0x00000001862A1400
		// [XID] // 0x00000001899DE010-0x00000001899DE030
		public static void OnFbxMeshCallback(Transform transform, IntPtr fbxNode, MeshRenderer meshRenderer, IntPtr fbxMesh) {} // 0x00000001862A1170-0x00000001862A12F0
		// [XID] // 0x00000001899E5D80-0x00000001899E5DA0
		public static void OnFbxTerrainCallback(Transform transform, IntPtr fbxNode, Terrain terrain, IntPtr fbxMesh) {} // 0x00000001862A1530-0x00000001862A16E0
		// [XID] // 0x00000001899ECEA0-0x00000001899ECEC0
		public static void OnFbxSkinnedMeshCallback(Transform transform, IntPtr fbxNode, SkinnedMeshRenderer skinnedMeshRenderer, IntPtr fbxMesh) {} // 0x00000001862A1400-0x00000001862A1530
		// [XID] // 0x00000001899F4C40-0x00000001899F4C60
		public static void OnFbxMaterialCallback(Transform transform, IntPtr fbxNode, IntPtr fbxMaterial, IntPtr[] fbxTextures) {} // 0x00000001862A1040-0x00000001862A1170
	}
}
