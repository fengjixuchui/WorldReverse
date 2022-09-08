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
	[CreateAssetMenu] // 0x0000000189882B50-0x0000000189882B90
	public class CookTabConfig : ScriptableObject // TypeDefIndex: 19622
	{
		// Fields
		public CookMenuConfig[] menuConfig; // 0x18
		public FoodTypeConfig[] foodConfig; // 0x20
	
		// Nested types
		[Serializable]
		public struct CookMenuConfig // TypeDefIndex: 19623
		{
			// Fields
			public CookingPageType cookType; // 0x00
			public string nameTextID; // 0x08
			public string iconName; // 0x10
		}
	
		[Serializable]
		public struct FoodTypeConfig // TypeDefIndex: 19624
		{
			// Fields
			public CookFoodType foodType; // 0x00
			public string nameTextID; // 0x08
			public string iconName; // 0x10
		}
	
		// Constructors
		public CookTabConfig() {} // 0x0000000186B5E9B0-0x0000000186B5EAB0
	
		// Methods
		// [XID] // 0x000000018988BB40-0x000000018988BB60
		public CookMenuConfig GetMenuTabConfig(CookingPageType type) => default; // 0x0000000186B5E650-0x0000000186B5E800
		// [XID] // 0x00000001898931F0-0x0000000189893210
		public FoodTypeConfig GetFoodTabConfig(CookFoodType type) => default; // 0x0000000186B5E800-0x0000000186B5E9B0
	}
}
