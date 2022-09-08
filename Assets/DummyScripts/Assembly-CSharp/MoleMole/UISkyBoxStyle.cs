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
	[CreateAssetMenu] // 0x0000000189B96060-0x0000000189B960A0
	public class UISkyBoxStyle : ScriptableObject // TypeDefIndex: 19661
	{
		// Fields
		public Style team; // 0x18
		public Style defaultColor; // 0x84
		public Style battlePass; // 0xF0
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style coopDefault; // 0x15C
		public Style coopFire; // 0x1C8
		public Style coopWater; // 0x234
		public Style coopGrass; // 0x2A0
		public Style coopElectric; // 0x30C
		public Style coopWind; // 0x378
		public Style coopIce; // 0x3E4
		public Style coopRock; // 0x450
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 19662
		{
			// Fields
			public Color color; // 0x00
			public Color skyboxLightColor; // 0x10
			public Color skyboxDarkColor; // 0x20
			public Color skyboxThirdColor; // 0x30
			public Color skyboxMaterial02Color01; // 0x40
			public Color skyboxMaterial02Color02; // 0x50
			public Vector3 position; // 0x60
		}
	
		// Constructors
		public UISkyBoxStyle() {} // 0x00000001821A1610-0x00000001821A1670
	
		// Methods
		// [XID] // 0x0000000189BA6680-0x0000000189BA66A0
		public Style GetStyle(SkyBoxType type) => default; // 0x00000001821A1010-0x00000001821A1610
	}
}
