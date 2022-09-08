/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ChillyRoom.UnityEditor.iOS.Xcode;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode.PBX
{
	internal class FileTypeUtils // TypeDefIndex: 10411
	{
		// Fields
		private static readonly Dictionary<string, FileTypeDesc> types; // 0x00
		private static readonly Dictionary<PBXSourceTree, string> sourceTree; // 0x08
		private static readonly Dictionary<string, PBXSourceTree> stringToSourceTreeMap; // 0x10
	
		// Nested types
		internal class FileTypeDesc // TypeDefIndex: 10412
		{
			// Fields
			public string name; // 0x10
			public PBXFileType type; // 0x18
			public bool isExplicit; // 0x1C
	
			// Constructors
			public FileTypeDesc() {} // Dummy constructor
			public FileTypeDesc(string typeName, PBXFileType type) {} // 0x00000001864D71E0-0x00000001864D7270
			public FileTypeDesc(string typeName, PBXFileType type, bool isExplicit) {} // 0x00000001864D7270-0x00000001864D7300
		}
	
		// Constructors
		public FileTypeUtils() {} // 0x00000001864D91F0-0x00000001864D9250
		static FileTypeUtils() {} // 0x00000001864D7F50-0x00000001864D91F0
	
		// Methods
		// [XID] // 0x00000001897BA540-0x00000001897BA560
		public static string TrimExtension(string ext) => default; // 0x00000001864D7E40-0x00000001864D7F50
		// [XID] // 0x000000018961C900-0x000000018961C920
		public static bool IsKnownExtension(string ext) => default; // 0x00000001864D7B10-0x00000001864D7C00
		// [XID] // 0x00000001897B2A70-0x00000001897B2A90
		internal static bool IsFileTypeExplicit(string ext) => default; // 0x00000001864D79B0-0x00000001864D7B10
		// [XID] // 0x00000001896078E0-0x0000000189607900
		public static PBXFileType GetFileType(string ext, bool isFolderRef) => default; // 0x00000001864D7430-0x00000001864D75D0
		// [XID] // 0x000000018960F3D0-0x000000018960F3F0
		public static string GetTypeName(string ext) => default; // 0x00000001864D75D0-0x00000001864D7740
		// [XID] // 0x000000018963A8F0-0x000000018963A910
		public static bool IsBuildableFile(string ext) => default; // 0x00000001864D7740-0x00000001864D78A0
		// [XID] // 0x00000001897F8880-0x00000001897F88A0
		public static bool IsBuildable(string ext, bool isFolderReference) => default; // 0x00000001864D78A0-0x00000001864D79B0
		// [XID] // 0x0000000189625830-0x0000000189625850
		internal static string SourceTreeDesc(PBXSourceTree tree) => default; // 0x00000001864D7D50-0x00000001864D7E40
		// [XID] // 0x0000000189805C50-0x0000000189805C70
		internal static PBXSourceTree ParseSourceTree(string tree) => default; // 0x00000001864D7C00-0x00000001864D7D50
		// [XID] // 0x0000000189807640-0x0000000189807660
		internal static List<PBXSourceTree> AllAbsoluteSourceTrees() => default; // 0x00000001864D7300-0x00000001864D7430
	}
}
