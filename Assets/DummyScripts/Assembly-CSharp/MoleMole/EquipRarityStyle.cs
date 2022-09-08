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
	[CreateAssetMenu] // 0x000000018994B7A0-0x000000018994B7E0
	public class EquipRarityStyle : ScriptableObject // TypeDefIndex: 19634
	{
		// Fields
		public Style gray; // 0x18
		public Style green; // 0xA8
		public Style blue; // 0x138
		public Style purple; // 0x1C8
		public Style orange; // 0x258
		public Style none; // 0x2E8
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 19635
		{
			// Fields
			public Color bg; // 0x00
			public Color icon; // 0x10
			public Color text; // 0x20
			public Color skyboxLightColor; // 0x30
			public Color skyboxDarkColor; // 0x40
			public Color skyboxThirdColor; // 0x50
			public Color skyboxMaterial02Color01; // 0x60
			public Color skyboxMaterial02Color02; // 0x70
			public string rankTextId; // 0x80
			public string bgIconName; // 0x88
		}
	
		// Constructors
		public EquipRarityStyle() {} // 0x0000000181F6E3B0-0x0000000181F6E410
	
		// Methods
		// [XID] // 0x0000000189954560-0x0000000189954580
		public Style GetStyle(QualityType type) => default; // 0x0000000181F6DEE0-0x0000000181F6E3B0
	}
}
