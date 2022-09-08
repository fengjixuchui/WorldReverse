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
	[CreateAssetMenu] // 0x0000000189726B40-0x0000000189726B80
	public class BagTabConfig : ScriptableObject // TypeDefIndex: 19606
	{
		// Fields
		public Config[] configs; // 0x18
	
		// Nested types
		[Serializable]
		public struct Config // TypeDefIndex: 19607
		{
			// Fields
			public ItemType itemType; // 0x00
			public MaterialType[] materialTypes; // 0x08
			public string nameTextID; // 0x10
			public string iconName; // 0x18
			public BagTab tabType; // 0x20
		}
	
		// Constructors
		public BagTabConfig() {} // 0x0000000182DC05B0-0x0000000182DC0610
	
		// Methods
		// [IDTag] // 0x000000018972F9B0-0x000000018972F9F0
		// [XID] // 0x000000018972F9B0-0x000000018972F9F0
		public int GetTabIndex(BagTab tab) => default; // 0x0000000182DC04A0-0x0000000182DC05B0
		// [IDTag] // 0x0000000189739FF0-0x000000018973A030
		// [XID] // 0x0000000189739FF0-0x000000018973A030
		public int GetTabIndex(uint itemID) => default; // 0x0000000182DC0270-0x0000000182DC04A0
	}
}
