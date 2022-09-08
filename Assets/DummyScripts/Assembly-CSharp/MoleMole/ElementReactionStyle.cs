/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x000000018989A910-0x000000018989A950
	public class ElementReactionStyle : ScriptableObject // TypeDefIndex: 19625
	{
		// Fields
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Style[] data; // 0x18
		[NonSerialized]
		public Dictionary<ElementReactionType, Style> dataDict; // 0x20
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 19626
		{
			// Fields
			public ElementReactionType type; // 0x00
			public string text; // 0x08
		}
	
		// Constructors
		public ElementReactionStyle() {} // 0x000000018149BE10-0x000000018149BE70
	
		// Methods
		// [XID] // 0x00000001898AA840-0x00000001898AA860
		public void InitDict() {} // 0x000000018149BAE0-0x000000018149BCE0
		// [XID] // 0x00000001898B2210-0x00000001898B2230
		public Style GetStyle(ElementReactionType type) => default; // 0x000000018149BCE0-0x000000018149BE10
	}
}
