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
	[CreateAssetMenu] // 0x0000000189915B60-0x0000000189915BA0
	public class EquipElementStyle : ScriptableObject // TypeDefIndex: 19629
	{
		// Fields
		public EquipStyle[] equips; // 0x18
	
		// Nested types
		[Serializable]
		public class Style // TypeDefIndex: 19630
		{
			// Fields
			public Color emissionColor; // 0x10
			public float emissionScaler; // 0x20
	
			// Constructors
			public Style() {} // 0x0000000181F8D260-0x0000000181F8D4A0
		}
	
		[Serializable]
		public class EquipStyle // TypeDefIndex: 19631
		{
			// Fields
			public uint[] configIDs; // 0x10
			public Style none; // 0x18
			public Style fire; // 0x20
			public Style water; // 0x28
			public Style grass; // 0x30
			public Style electric; // 0x38
			public Style wind; // 0x40
			public Style ice; // 0x48
			public Style rock; // 0x50
	
			// Constructors
			public EquipStyle() {} // 0x0000000181F6E410-0x0000000181F6E470
		}
	
		// Constructors
		public EquipElementStyle() {} // 0x0000000181F6DC10-0x0000000181F6DC70
	
		// Methods
		// [IDTag] // 0x000000018991EC40-0x000000018991EC80
		// [XID] // 0x000000018991EC40-0x000000018991EC80
		public EquipStyle GetStyle(uint configId) => default; // 0x0000000181F6DA70-0x0000000181F6DC10
		// [IDTag] // 0x00000001899295C0-0x0000000189929600
		// [XID] // 0x00000001899295C0-0x0000000189929600
		public Style GetStyle(uint configId, ElementType type) => default; // 0x0000000181F6D990-0x0000000181F6DA70
		// [XID] // 0x00000001899338C0-0x00000001899338E0
		private Style GetEquipStyle(EquipStyle equip, ElementType type) => default; // 0x0000000181F6D7F0-0x0000000181F6D990
	}
}
