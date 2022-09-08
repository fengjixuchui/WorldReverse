/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CTS
{
	public static class CTSConstants // TypeDefIndex: 9115
	{
		// Fields
		public static readonly int MajorVersion; // 0x00
		public static readonly int MinorVersion; // 0x04
		public static readonly string CTSPresentSymbol; // 0x08
		public const string CTSShaderName = "CTS Terrain"; // Metadata: 0x00AE52B1
		public const string CTSShaderBasicName = "miHoYo/CTS original/CTS Terrain Shader Basic"; // Metadata: 0x00AE52C0
		public const string CTSShaderBasicCutoutName = "miHoYo/CTS original/CTS Terrain Shader Basic CutOut"; // Metadata: 0x00AE52F0
		public const string CTSShaderAdvancedName = "miHoYo/CTS original/CTS Terrain Shader Advanced"; // Metadata: 0x00AE5327
		public const string CTSShaderAdvancedCutoutName = "miHoYo/CTS original/CTS Terrain Shader Advanced CutOut"; // Metadata: 0x00AE535A
		public const string CTSShaderTesselatedName = "miHoYo/CTS original/CTS Terrain Shader Advanced Tess"; // Metadata: 0x00AE5394
		public const string CTSShaderTesselatedCutoutName = "miHoYo/CTS original/CTS Terrain Shader Advanced Tess CutOut"; // Metadata: 0x00AE53CC
	
		// Nested types
		public enum ShaderType // TypeDefIndex: 9116
		{
			Unity = 0,
			miHoYo = 1
		}
	
		public enum ShaderMode // TypeDefIndex: 9117
		{
			DesignTime = 0,
			RunTime = 1
		}
	
		public enum TextureSize // TypeDefIndex: 9118
		{
			Texture_64 = 0,
			Texture_128 = 1,
			Texture_256 = 2,
			Texture_512 = 3,
			Texture_1024 = 4,
			Texture_2048 = 5,
			Texture_4096 = 6,
			Texture_8192 = 7
		}
	
		public enum TextureType // TypeDefIndex: 9119
		{
			Albedo = 0,
			Normal = 1,
			AmbientOcclusion = 2,
			Height = 3,
			Splat = 4,
			Emission = 5
		}
	
		public enum TextureChannel // TypeDefIndex: 9120
		{
			R = 0,
			G = 1,
			B = 2,
			A = 3
		}
	
		// Constructors
		static CTSConstants() {} // 0x0000000186420BC0-0x0000000186420C50
	
		// Methods
		// [XID] // 0x00000001897DEDF0-0x00000001897DEE10
		public static int GetTextureSize(TextureSize size) => default; // 0x0000000186420AB0-0x0000000186420BC0
	}
}
