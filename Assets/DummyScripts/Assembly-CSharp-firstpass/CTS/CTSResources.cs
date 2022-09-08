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

namespace CTS
{
	public sealed class CTSResources : ScriptableObject // TypeDefIndex: 9127
	{
		// Fields
		public Shaders shaders; // 0x18
	
		// Nested types
		[Serializable]
		public sealed class Shaders // TypeDefIndex: 9128
		{
			// Fields
			public Shader CTSShaderBasic; // 0x10
			public Shader CTSShaderBasicCutout; // 0x18
			public Shader CTSShaderAdvanced; // 0x20
			public Shader CTSShaderAdvancedCutout; // 0x28
			public Shader CTSShaderTesselated; // 0x30
			public Shader CTSShaderTesselatedCutout; // 0x38
			public Shader miHoYoCTSShader; // 0x40
			public Shader miHoYoCTSShaderSecondPass; // 0x48
			public Shader miHoYoCTSShaderPCPS4; // 0x50
			public Shader miHoYoCTSShaderSecondPassPCPS4; // 0x58
			public List<UnityEngine.Material> miHoYoCTSInstancedMaterials; // 0x60
	
			// Constructors
			public Shaders() {} // 0x00000001875879F0-0x0000000187587A80
	
			// Methods
			// [XID] // 0x0000000189B5EC20-0x0000000189B5EC40
			public bool IsShaderMatched(Shader src) => default; // 0x00000001875878D0-0x00000001875879F0
		}
	
		// Constructors
		public CTSResources() {} // 0x0000000187572270-0x00000001875722D0
	}
}
