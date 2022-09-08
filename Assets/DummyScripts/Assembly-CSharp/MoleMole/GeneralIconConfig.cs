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
	[CreateAssetMenu] // 0x0000000189984690-0x00000001899846D0
	public class GeneralIconConfig : ScriptableObject // TypeDefIndex: 19641
	{
		// Fields
		public IconConfig[] configs; // 0x18
	
		// Nested types
		[Serializable]
		public struct IconConfig // TypeDefIndex: 19642
		{
			// Fields
			public string key; // 0x00
			public string iconName; // 0x08
			public string iconPath; // 0x10
		}
	
		// Constructors
		public GeneralIconConfig() {} // 0x0000000181F87820-0x0000000181F87880
	
		// Methods
		// [XID] // 0x000000018998DA00-0x000000018998DA20
		public IconConfig GetIconConfig(string key) => default; // 0x0000000181F87610-0x0000000181F87820
	}
}
