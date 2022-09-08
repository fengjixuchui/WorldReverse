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
	public abstract class LuaBase : IDisposable // TypeDefIndex: 32380
	{
		// Fields
		protected bool disposed; // 0x10
		protected readonly int luaReference; // 0x14
		protected readonly LuaEnv luaEnv; // 0x18
	
		// Constructors
		protected LuaBase() {} // Dummy constructor
		public LuaBase(int reference, LuaEnv luaenv) {} // 0x0000000183EEBE10-0x0000000183EEBE90
	
		// Methods
		~LuaBase() {} // 0x0000000183EEBC70-0x0000000183EEBD20
		public void Dispose() {} // 0x0000000183EEB9A0-0x0000000183EEBA20
		public virtual void Dispose(bool disposeManagedResources) {} // 0x0000000183EEB7A0-0x0000000183EEB9A0
		public override bool Equals(object o) => default; // 0x0000000183EEBA20-0x0000000183EEBC70
		public override int GetHashCode() => default; // 0x0000000183EEBD20-0x0000000183EEBE10
		internal virtual void push(IntPtr L) {} // 0x0000000183EEBE90-0x0000000183EEBF10
	}
}
