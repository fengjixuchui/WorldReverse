/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public sealed class LuaFunction : LuaBase // TypeDefIndex: 32388
	{
		// Constructors
		public LuaFunction() {} // Dummy constructor
		public LuaFunction(int reference, LuaEnv luaenv) {} // 0x000000018612B200-0x000000018612B280
	
		// Methods
		public void Action<T>(T a) {}
		public TResult Func<T, TResult>(T a) => default;
		public void Action<T1, T2>(T1 a1, T2 a2) {}
		public TResult Func<T1, T2, TResult>(T1 a1, T2 a2) => default;
		public object[] Call(object[] args, System.Type[] returnTypes) => default; // 0x000000018612ACD0-0x000000018612AF70
		public object[] Call(params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x000000018612AC50-0x000000018612ACD0
		public T Cast<T>() => default;
		public void SetEnv(LuaTable env) {} // 0x000000018612AFD0-0x000000018612B150
		internal override void push(IntPtr L) {} // 0x000000018612B280-0x000000018612B300
		public override string ToString() => default; // 0x000000018612B150-0x000000018612B200
		public int GetReference() => default; // 0x000000018612AF70-0x000000018612AFD0
	}
}
