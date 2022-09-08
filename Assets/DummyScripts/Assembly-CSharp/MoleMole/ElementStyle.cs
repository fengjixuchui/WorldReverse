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

namespace MoleMole
{
	[CreateAssetMenu] // 0x00000001898B9F00-0x00000001898B9F40
	public class ElementStyle : ScriptableObject // TypeDefIndex: 19627
	{
		// Fields
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style none; // 0x18
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style fire; // 0x100
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style water; // 0x1E8
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style grass; // 0x2D0
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style electric; // 0x3B8
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style wind; // 0x4A0
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style ice; // 0x588
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style rock; // 0x670
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 19628
		{
			// Fields
			public Color color; // 0x00
			public Color skyboxLightColor; // 0x10
			public Color skyboxDarkColor; // 0x20
			public Color skyboxThirdColor; // 0x30
			public Color skyboxMaterial02Color01; // 0x40
			public Color skyboxMaterial02Color02; // 0x50
			public Color skyboxMaterial03BGColor; // 0x60
			public Color skyboxMaterial03DarkColor; // 0x70
			public Color skyboxMaterial03LightColor; // 0x80
			public Color talentActiveEffectColor; // 0x90
			public string effectName; // 0xA0
			public string talentEffectName; // 0xA8
			public string pendantEffectPattern; // 0xB0
			public string pendantFullEffectPattern; // 0xB8
			public string changeAvatarEffectPattern; // 0xC0
			public string goddessUnlockIconName; // 0xC8
			public string iconName; // 0xD0
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong elementIconPathHash; // 0xD8
			[GameObjectHashPath] // 0x00000001896C4C00-0x00000001896C4C10
			public ulong avatarGachaEffectPathHash; // 0xE0
		}
	
		// Constructors
		public ElementStyle() {} // 0x000000018149C1E0-0x000000018149C240
	
		// Methods
		// [XID] // 0x00000001898FF1B0-0x00000001898FF1D0
		public Style GetStyle(ElementType type) => default; // 0x000000018149BE70-0x000000018149C1E0
	}
}
