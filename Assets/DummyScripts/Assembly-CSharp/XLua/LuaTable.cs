/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public sealed class LuaTable : LuaBase // TypeDefIndex: 32399
	{
		// Properties
		[Obsolete] // 0x000000018974BD80-0x000000018974BDB0
		public object this[string field] { get => default; set {} } // 0x000000018612CAA0-0x000000018612CB20 0x000000018612CE20-0x000000018612CEB0
		[Obsolete] // 0x000000018974BD80-0x000000018974BDB0
		public object this[object field] { get => default; set {} } // 0x000000018612CB20-0x000000018612CBA0 0x000000018612CD90-0x000000018612CE20
		public int Length { get => default; } // 0x000000018612CBA0-0x000000018612CD10 
	
		// Constructors
		public LuaTable() {} // Dummy constructor
		public LuaTable(int reference, LuaEnv luaenv) {} // 0x000000018612CA20-0x000000018612CAA0
	
		// Methods
		public void Get<TKey, TValue>(TKey key, out TValue value) {
			value = default;
		}
		public bool ContainsKey<TKey>(TKey key) => default;
		public void Set<TKey, TValue>(TKey key, TValue value) {}
		public T GetInPath<T>(string path) => default;
		public void SetInPath<T>(string path, T val) {}
		public void ForEach<TKey, TValue>(Action<TKey, TValue> action) {}
		[DebuggerHidden] // 0x00000001897232B0-0x0000000189723300
		[Obsolete] // 0x00000001897232B0-0x0000000189723300
		public IEnumerable GetKeys() => default; // 0x000000018612C6F0-0x000000018612C7D0
		[DebuggerHidden] // 0x00000001897232B0-0x0000000189723300
		[Obsolete] // 0x00000001897232B0-0x0000000189723300
		public IEnumerable<T> GetKeys<T>() => default;
		[Obsolete] // 0x0000000189739780-0x00000001897397B0
		public T Get<T>(object key) => default;
		public TValue Get<TKey, TValue>(TKey key) => default;
		public TValue Get<TValue>(string key) => default;
		public void SetMetaTable(LuaTable metaTable) {} // 0x000000018612C7D0-0x000000018612C970
		public T Cast<T>() => default;
		internal override void push(IntPtr L) {} // 0x000000018612CD10-0x000000018612CD90
		public override string ToString() => default; // 0x000000018612C970-0x000000018612CA20
	}
}
