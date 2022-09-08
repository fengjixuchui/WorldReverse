/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using XLua.LuaDLL;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public class MethodWrapsCache // TypeDefIndex: 32404
	{
		// Fields
		private ObjectTranslator translator; // 0x10
		private ObjectCheckers objCheckers; // 0x18
		private ObjectCasters objCasters; // 0x20
		private Dictionary<System.Type, lua_CSFunction> constructorCache; // 0x28
		private Dictionary<System.Type, Dictionary<string, lua_CSFunction>> methodsCache; // 0x30
		private Dictionary<System.Type, lua_CSFunction> delegateCache; // 0x38
	
		// Constructors
		public MethodWrapsCache() {} // Dummy constructor
		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters) {} // 0x000000018612E330-0x000000018612E430
	
		// Methods
		public lua_CSFunction GetConstructorWrap(System.Type type) => default; // 0x000000018612D290-0x000000018612D5F0
		public lua_CSFunction GetMethodWrap(System.Type type, string methodName) => default; // 0x000000018612DDE0-0x000000018612E000
		public lua_CSFunction GetMethodWrapInCache(System.Type type, string methodName) => default; // 0x000000018612DCA0-0x000000018612DDE0
		public lua_CSFunction GetDelegateWrap(System.Type type) => default; // 0x000000018612D5F0-0x000000018612D830
		public lua_CSFunction GetEventWrap(System.Type type, string eventName) => default; // 0x000000018612D830-0x000000018612DCA0
		public MethodWrap _GenMethodWrap(System.Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false /* Metadata: 0x00B143F0 */) => default; // 0x000000018612E000-0x000000018612E330
		private static bool tryMakeGenericMethod(ref MethodBase method) => default; // 0x000000018612E430-0x000000018612E740
	}
}
