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
	public class LuaEnv : IDisposable // TypeDefIndex: 32383
	{
		// Fields
		public const string CSHARP_NAMESPACE = "xlua_csharp_namespace"; // Metadata: 0x00B14388
		public const string MAIN_SHREAD = "xlua_main_thread"; // Metadata: 0x00B143A1
		internal IntPtr rawL; // 0x10
		private LuaTable _G; // 0x18
		internal ObjectTranslator translator; // 0x20
		internal int errorFuncRef; // 0x28
		internal object luaLock; // 0x30
		private const int LIB_VERSION_EXPECT = 105; // Metadata: 0x00B143B5
		private static List<Action<LuaEnv, ObjectTranslator>> initers; // 0x00
		private int last_check_point; // 0x38
		private int max_check_per_tick; // 0x3C
		private Func<object, bool> object_valid_checker; // 0x40
		private bool disposed; // 0x48
		private Queue<GCAction> refQueue; // 0x50
		internal List<object> customLoaders; // 0x58
		internal Dictionary<string, lua_CSFunction> buildin_initer; // 0x60
	
		// Properties
		internal IntPtr L { get => default; } // 0x0000000183EEF060-0x0000000183EEF110 
		internal object luaEnvLock { get => default; } // 0x0000000183EEF260-0x0000000183EEF2C0 
		public LuaTable Global { get => default; } // 0x0000000183EEF000-0x0000000183EEF060 
		public int GcPause { get => default; set {} } // 0x0000000183EEED20-0x0000000183EEEE90 0x0000000183EEF2C0-0x0000000183EEF3F0
		public int GcStepmul { get => default; set {} } // 0x0000000183EEEE90-0x0000000183EEF000 0x0000000183EEF3F0-0x0000000183EEF520
		public int Memroy { get => default; } // 0x0000000183EEF110-0x0000000183EEF260 
	
		// Nested types
		internal struct GCAction // TypeDefIndex: 32384
		{
			// Fields
			public int Reference; // 0x00
			public bool IsDelegate; // 0x04
		}
	
		public delegate byte[] CustomLoader(ref string filepath, out bool recycleBytes); // TypeDefIndex: 32385; 0x000000018612A490-0x000000018612A650
	
		public delegate byte[] CustomLoader_MHY<T>(T filepath, out bool recycleBytes); // TypeDefIndex: 32386; 0x00000000-0x00000000
	
		// Constructors
		public LuaEnv() {} // 0x0000000183EEDB60-0x0000000183EEEC40
		static LuaEnv() {} // 0x0000000183EEDB00-0x0000000183EEDB60
	
		// Methods
		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer) {} // 0x0000000183EEC0C0-0x0000000183EEC1F0
		public T LoadStringEx<T>(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x00B14337 */, LuaTable env = null) => default;
		public T LoadStringEx<T>(string chunk, string chunkName = "chunk" /* Metadata: 0x00B14340 */, LuaTable env = null) => default;
		public LuaFunction LoadStringEx(string chunk, string chunkName = "chunk" /* Metadata: 0x00B14349 */, LuaTable env = null) => default; // 0x0000000183EED070-0x0000000183EED100
		public T LoadString<T>(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x00B14352 */, LuaTable env = null) => default;
		public T LoadString<T>(string chunk, string chunkName = "chunk" /* Metadata: 0x00B1435B */, LuaTable env = null) => default;
		public LuaFunction LoadString(string chunk, string chunkName = "chunk" /* Metadata: 0x00B14364 */, LuaTable env = null) => default; // 0x0000000183EED100-0x0000000183EED190
		public object[] DoLuaFile(string filePath, string fileName = "chunk" /* Metadata: 0x00B1436D */) => default; // 0x0000000183EEC940-0x0000000183EECA60
		public object[] DoString(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x00B14376 */, LuaTable env = null) => default; // 0x0000000183EECA60-0x0000000183EECCB0
		public object[] DoString(string chunk, string chunkName = "chunk" /* Metadata: 0x00B1437F */, LuaTable env = null) => default; // 0x0000000183EECCB0-0x0000000183EECDA0
		private void AddSearcher(lua_CSFunction searcher, int index, string dstSearchers = null) {} // 0x0000000183EEC310-0x0000000183EEC5D0
		public void Alias(System.Type type, string alias) {} // 0x0000000183EEC5D0-0x0000000183EEC660
		private static bool ObjectValidCheck(object obj) => default; // 0x0000000183EED380-0x0000000183EED4B0
		public void Tick() {} // 0x0000000183EED8D0-0x0000000183EEDB00
		public void GC() {} // 0x0000000183EECEC0-0x0000000183EECF20
		public LuaTable NewTable() => default; // 0x0000000183EED190-0x0000000183EED380
		public void Dispose() {} // 0x0000000183EEC6E0-0x0000000183EEC780
		public void Clear() {} // 0x0000000183EEC660-0x0000000183EEC6E0
		public virtual void Dispose(bool dispose) {} // 0x0000000183EEC780-0x0000000183EEC940
		public void ThrowExceptionFromError(int oldTop) {} // 0x0000000183EED6F0-0x0000000183EED8D0
		internal void equeueGCAction(GCAction action) {} // 0x0000000183EEEC40-0x0000000183EEED20
		public void AddLoader(CustomLoader loader) {} // 0x0000000183EEC280-0x0000000183EEC310
		public void AddLoader(CustomLoader_MHY<long> loader) {} // 0x0000000183EEC1F0-0x0000000183EEC280
		public void AddBuildin(string name, lua_CSFunction initer) {} // 0x0000000183EEBFE0-0x0000000183EEC0C0
		public void FullGc() {} // 0x0000000183EECDA0-0x0000000183EECEC0
		public void StopGc() {} // 0x0000000183EED5D0-0x0000000183EED6F0
		public void RestartGc() {} // 0x0000000183EED4B0-0x0000000183EED5D0
		public bool GcStep(int data) => default; // 0x0000000183EECF20-0x0000000183EED070
	}
}
