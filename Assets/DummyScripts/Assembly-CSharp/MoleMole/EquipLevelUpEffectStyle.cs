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
	[CreateAssetMenu] // 0x000000018993B490-0x000000018993B4D0
	public class EquipLevelUpEffectStyle : ScriptableObject // TypeDefIndex: 19632
	{
		// Fields
		public Style[] styles; // 0x18
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 19633
		{
			// Fields
			public WeaponType weaponType; // 0x00
			public Vector3 centerOffset; // 0x04
			public string gachaIcon; // 0x10
			public string gachaBgIcon; // 0x18
		}
	
		// Constructors
		public EquipLevelUpEffectStyle() {} // 0x0000000181F6DE80-0x0000000181F6DEE0
	
		// Methods
		// [XID] // 0x00000001899441A0-0x00000001899441C0
		public Style GetStyle(WeaponType type) => default; // 0x0000000181F6DC70-0x0000000181F6DE80
	}
}
