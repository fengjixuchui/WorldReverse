/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using XLua.LuaDLL;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public static class LuaMemoryLeakChecker // TypeDefIndex: 32392
	{
		// Fields
		private const string UNKNOW_KEY = "???"; // Metadata: 0x00B143D1
		private const string METATABLE_KEY = "__metatable"; // Metadata: 0x00B143D8
		private const string KEY_OF_TABLE = "!KEY!"; // Metadata: 0x00B143E7
	
		// Nested types
		public class Data // TypeDefIndex: 32393
		{
			// Fields
			internal int Memroy; // 0x10
			internal Dictionary<IntPtr, int> TableSizes; // 0x18
	
			// Properties
			public int PotentialLeakCount { get => default; } // 0x000000018612AA80-0x000000018612ABD0 
	
			// Constructors
			public Data() {} // 0x000000018612A9E0-0x000000018612AA80
	
			// Methods
			public override string ToString() => default; // 0x000000018612A6D0-0x000000018612A9E0
		}
	
		private struct RefInfo // TypeDefIndex: 32394
		{
			// Fields
			public string Key; // 0x00
			public bool HasNext; // 0x08
			public IntPtr Parent; // 0x10
			public bool IsNumberKey; // 0x18
		}
	
		// Methods
		private static Data getSizeReport(LuaEnv env) => default; // 0x000000018612C3D0-0x000000018612C540
		private static string makeKey(RelationshipType type, string key, double d, string key2) => default; // 0x000000018612C540-0x000000018612C6F0
		private static Dictionary<IntPtr, List<RefInfo>> getRelationship(LuaEnv env) => default; // 0x000000018612C200-0x000000018612C3D0
		private static Data findGrowing(Data from, Data to) => default; // 0x000000018612BF50-0x000000018612C200
	
		// Extension methods
		public static Data StartMemoryLeakCheck(this LuaEnv env) => default; // 0x000000018612BCC0-0x000000018612BD40
		public static Data MemoryLeakCheck(this LuaEnv env, Data last) => default; // 0x000000018612B480-0x000000018612B520
		public static string MemoryLeakReport(this LuaEnv env, Data data, int maxLevel = 10 /* Metadata: 0x00B143CD */) => default; // 0x000000018612B520-0x000000018612BCC0
	}
}
