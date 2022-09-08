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

namespace ProCore.Decals
{
	[Serializable]
	public class DecalGroup // TypeDefIndex: 9717
	{
		// Fields
		public const int MAX_ATLAS_SIZE_DEFAULT = 4096; // Metadata: 0x00AE5F5C
		public const int ATLAS_PADDING_DEFAULT = 4; // Metadata: 0x00AE5F60
		public List<Decal> decals; // 0x10
		public string name; // 0x18
		public Shader shader; // 0x20
		public Shader deferredShader; // 0x28
		public bool isPacked; // 0x30
		public UnityEngine.Material material; // 0x38
		public UnityEngine.Material deferredMaterial; // 0x40
		public int maxAtlasSize; // 0x48
		public int padding; // 0x4C
	
		// Constructors
		public DecalGroup() {} // Dummy constructor
		public DecalGroup(string name, List<Decal> decals, bool isPacked, Shader shader, Shader deferredShader, UnityEngine.Material material, UnityEngine.Material deferredMaterial, int maxAtlasSize, int padding) {} // 0x000000018600B140-0x000000018600B210
	
		// Methods
		// [XID] // 0x00000001897DED00-0x00000001897DED20
		public bool ContainsTexture(Texture2D tex) => default; // 0x000000018600AF40-0x000000018600B140
	}
}
