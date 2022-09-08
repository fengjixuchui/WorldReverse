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
	[CreateAssetMenu] // 0x00000001897163A0-0x00000001897163E0
	public class AvatarQualityStyle : ScriptableObject // TypeDefIndex: 19604
	{
		// Fields
		public Style gray; // 0x18
		public Style blue; // 0x38
		public Style purple; // 0x58
		public Style orange; // 0x78
		private Style none; // 0x98
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 19605
		{
			// Fields
			public Color bg; // 0x00
			public Color icon; // 0x10
		}
	
		// Constructors
		public AvatarQualityStyle() {} // 0x0000000182DC0100-0x0000000182DC0210
	
		// Methods
		// [XID] // 0x000000018971F5B0-0x000000018971F5D0
		public Style GetStyle(QualityType type) => default; // 0x0000000182DBFFA0-0x0000000182DC0100
	}
}
