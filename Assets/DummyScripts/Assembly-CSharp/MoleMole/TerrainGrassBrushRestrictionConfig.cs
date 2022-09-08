/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class TerrainGrassBrushRestrictionConfig : ScriptableObject // TypeDefIndex: 26507
	{
		// Fields
		public List<TextureRestriction> textureRestrictions; // 0x18
	
		// Nested types
		[Serializable]
		public class TextureRestriction // TypeDefIndex: 26508
		{
			// Fields
			public Texture2D texture; // 0x10
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float intensity; // 0x18
	
			// Constructors
			public TextureRestriction() {} // 0x0000000182B1D3C0-0x0000000182B1D420
		}
	
		// Constructors
		public TerrainGrassBrushRestrictionConfig() {} // 0x0000000182B1CA50-0x0000000182B1CAB0
	}
}
