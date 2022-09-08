/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public abstract class DelegateBridgeBase : LuaBase // TypeDefIndex: 32365
	{
		// Fields
		private System.Type firstKey; // 0x20
		private Delegate firstValue; // 0x28
		private Dictionary<System.Type, Delegate> bindTo; // 0x30
		protected int errorFuncRef; // 0x38
	
		// Constructors
		protected DelegateBridgeBase() {} // Dummy constructor
		public DelegateBridgeBase(int reference, LuaEnv luaenv) {} // 0x0000000183EE6570-0x0000000183EE6610
	
		// Methods
		public bool TryGetDelegate(System.Type key, out Delegate value) {
			value = default;
			return default;
		} // 0x0000000183EE64C0-0x0000000183EE6570
		public void AddDelegate(System.Type key, Delegate value) {} // 0x0000000183EE6320-0x0000000183EE6470
		public virtual Delegate GetDelegateByType(System.Type type) => default; // 0x0000000183EE6470-0x0000000183EE64C0
	}
}
