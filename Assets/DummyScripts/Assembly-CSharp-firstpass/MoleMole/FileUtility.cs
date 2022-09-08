/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class FileUtility // TypeDefIndex: 10543
	{
		// Fields
		public static string streamingDirRoot; // 0x00
		private static readonly string _pathSeperator; // 0x08
		private static readonly char[] _pathSeperators; // 0x10
	
		// Constructors
		static FileUtility() {} // 0x0000000189BE3D70-0x0000000189BE3EC0
	
		// Methods
		// [XID] // 0x0000000189ABE520-0x0000000189ABE540
		public static bool IsFileExists(string filePath) => default; // 0x0000000189BE2A60-0x0000000189BE2B40
		// [XID] // 0x00000001899C6700-0x00000001899C6720
		public static bool IsFilePathStartsFromStreamingAssets(string filePath) => default; // 0x0000000189BE2B40-0x0000000189BE2C30
		// [XID] // 0x00000001899CDB80-0x00000001899CDBA0
		public static bool ExistsInStreamingAssets(string pathInStreamingAssets) => default; // 0x0000000189BE2940-0x0000000189BE2A60
		// [XID] // 0x00000001899D51C0-0x00000001899D51E0
		public static Stream OpenRead(string filePath) => default; // 0x0000000189BE30E0-0x0000000189BE3190
		// [XID] // 0x00000001899DC760-0x00000001899DC780
		public static string ReadFromFile(string path) => default; // 0x0000000189BE3190-0x0000000189BE34D0
		// [XID] // 0x00000001898165A0-0x00000001898165C0
		public static void WriteToFile(string path, string content) {} // 0x0000000189BE3A30-0x0000000189BE3D70
		// [XID] // 0x00000001899D5100-0x00000001899D5120
		public static string[] SplitPath(string path) => default; // 0x0000000189BE34D0-0x0000000189BE35C0
		// [IDTag] // 0x00000001899F3200-0x00000001899F3240
		// [XID] // 0x00000001899F3200-0x00000001899F3240
		public static string JoinPath(string[] splitPath) => default; // 0x0000000189BE2C30-0x0000000189BE2D80
		// [IDTag] // 0x00000001899FD5D0-0x00000001899FD610
		// [XID] // 0x00000001899FD5D0-0x00000001899FD610
		public static string JoinPath(string[] splitPath, int startIndex) => default; // 0x0000000189BE2F20-0x0000000189BE30E0
		// [IDTag] // 0x0000000189A07BB0-0x0000000189A07BF0
		// [XID] // 0x0000000189A07BB0-0x0000000189A07BF0
		public static string JoinPath(string[] splitPath, int startIndex, int count) => default; // 0x0000000189BE2D80-0x0000000189BE2F20
		// [XID] // 0x0000000189706DC0-0x0000000189706DE0
		public static string UnifySeperators(string path) => default; // 0x0000000189BE3860-0x0000000189BE3A30
		// [XID] // 0x0000000189A19850-0x0000000189A19870
		public static string Combine(string path1, string path2) => default; // 0x0000000189BE24F0-0x0000000189BE26A0
		// [XID] // 0x000000018970E6A0-0x000000018970E6C0
		public static string CommonPath(string path1, string path2) => default; // 0x0000000189BE26A0-0x0000000189BE2940
		// [XID] // 0x0000000189A281A0-0x0000000189A281C0
		public static string SubtractPath(string minuend, string subtrahend) => default; // 0x0000000189BE35C0-0x0000000189BE3860
	}
}
