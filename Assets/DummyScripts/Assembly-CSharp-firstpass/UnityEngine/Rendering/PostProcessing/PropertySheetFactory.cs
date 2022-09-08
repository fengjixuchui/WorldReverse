/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class PropertySheetFactory // TypeDefIndex: 9614
	{
		// Fields
		private readonly Dictionary<Shader, PropertySheet> m_Sheets; // 0x10
	
		// Constructors
		public PropertySheetFactory() {} // 0x0000000185E0C0B0-0x0000000185E0C140
	
		// Methods
		// [IDTag] // 0x000000018994C460-0x000000018994C4A0
		// [XID] // 0x000000018994C460-0x000000018994C4A0
		public PropertySheet Get(string shaderName) => default; // 0x0000000185E0BB70-0x0000000185E0BC30
		// [IDTag] // 0x0000000189956940-0x0000000189956980
		// [XID] // 0x0000000189956940-0x0000000189956980
		public PropertySheet Get(Shader shader) => default; // 0x0000000185E0BC30-0x0000000185E0BEE0
		// [XID] // 0x00000001898DE1A0-0x00000001898DE1C0
		public void Release() {} // 0x0000000185E0BEE0-0x0000000185E0C0B0
	}
}
