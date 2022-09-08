/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MHYRenderResources : ScriptableObject // TypeDefIndex: 26516
	{
		// Fields
		public MHYShaders shaders; // 0x18
		public MHYMeshes meshes; // 0x20
		public MHYMaterial materials; // 0x28
	
		// Nested types
		[Serializable]
		public sealed class MHYShaders // TypeDefIndex: 26517
		{
			// Fields
			public Shader characterAmbientSensors; // 0x10
			public Shader rgbmCopy; // 0x18
			public Shader elementsExamination; // 0x20
			public Shader debugVertexDensity; // 0x28
	
			// Constructors
			public MHYShaders() {} // 0x000000018113FE40-0x000000018113FEA0
		}
	
		[Serializable]
		public sealed class MHYMeshes // TypeDefIndex: 26518
		{
			// Fields
			public Mesh lowQualityShadowMesh; // 0x10
	
			// Constructors
			public MHYMeshes() {} // 0x000000018113FD20-0x000000018113FD80
		}
	
		[Serializable]
		public sealed class MHYMaterial // TypeDefIndex: 26519
		{
			// Fields
			public UnityEngine.Material lowQualityShadowMaterial; // 0x10
	
			// Constructors
			public MHYMaterial() {} // 0x000000018113FCC0-0x000000018113FD20
		}
	
		// Constructors
		public MHYRenderResources() {} // 0x000000018113FDE0-0x000000018113FE40
	}
}
